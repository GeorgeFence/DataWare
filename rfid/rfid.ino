 /*
   Ctecka pro Dignus - verze čeká na DHCP a zkouší přiřazení

   9.12.2019 - camel - pridano vypinani SD
   12.7.2019 - camel - doplnena nekonecna smycka co zkousi ziskat IP z DHCP
     Kazdy 10. neuspesny pokus pipa.

   Popis akusticke signalizace:
     Po zapnuti:  1x 1s + 2x 0,1s = nedari se ziskat konfiguraci site
     Po prilozeni karty:  1x 0,1s pip = nactena karta
     Po nacteni karty:  1x 0,5s pip = data odeslana do Dignus
                        5x 0,1s     = data se nepodarilo poslat do Dignus

   9.12.2019 - VH - verze čtečky 3, odzkoušené a frčí (bez R+C, vč DHCP - kablik reset a pin12) 
   vyhnout reset pin + jeden ze šestky (eth.portem k sobe, pravý u čtečky karet blíž ke mně 
   + propojit dratkem na ES pin č. 12 + Reset žádný R + C na pozastavení shieldu a lze nahrát a aktualizovat složené v krabičce !
   02 zelená, 03 bílá, 04 žlutá, 05 modrá  čip 510 je správný bez odporů
*/
#include <SPI.h>
#include <Ethernet.h>
#include <utility/w5100.h>
#include <Wiegand.h>

// verze čtečky
byte version = 3;

// seriové číslo čtečky
unsigned long serial = 0x000000999;

//Nastavení PostgreSQL databáse
IPAddress PGIP(192,168,0,107);        // your PostgreSQL server IP

const char user[] = "admin";       // your database user
const char password[] = "123";   // your database password
const char dbname[] = "rfid";         // your database name


// Default IP, když selže DHCP
IPAddress ip(192, 168, 0, 177);

// PIN setup
int PINd1 = 2;
int PINd2 = 3;
int PINbeep = 4;
int PINled = 5;

#define ETH_CS 10
#define SD_CS   4
#define RESET_PIN 12

// Maska MAC zarizeni, 2. a 3. byte je verze čtečky a 4. - 6. byte je seriové číslo
byte mac[] = { 0xAE, 0x00, 0x00, 0x00, 0x00, 0x00 };

// Initialize the Ethernet client library
EthernetClient client;

// buffer
#define BUFLEN 100
char buf[BUFLEN + 1];


// Objekt ctecky
WIEGAND wg;

byte dhcpRenew = 1;


void setupEthernet() {
  // start the Ethernet connection:
  // print MAC
  Serial.print("Using MAC address: "); for (byte i = 0; i < 6; i++) Serial.print(mac[i], HEX); Serial.println();
  byte cnt = 0;
  while (Ethernet.begin(mac, 60000, 4000) == 0) {
    Serial.println("Failed to get Ethernet configuration via DHCP... still trying...");
    signalFAILNet();
    delay(1000);
    resetW5100();
  }
  Serial.println("Configured Ethernet using DHCP");
  // setup timeouts
  W5100.setRetransmissionTime(0x07D0);
  W5100.setRetransmissionCount(3);

  // give the Ethernet shield a second to initialize:
  delay(1000);
  // vypis IP adresu
  Serial.print("Using IP address ");
  printIPAddress();
  Serial.println("");
  Serial.println("OK. Lets go:");
  Serial.println("");
  signalOK();
}

void setup() {
  // nastaveni seriaku
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
  // banner
  Serial.print("Card reader version: "); Serial.println(version, HEX);
  Serial.print("Card reader serial: "); Serial.println(serial, HEX);

  // PINy na output
  pinMode(PINbeep, OUTPUT);
  pinMode(PINled, OUTPUT);
  pinMode(ETH_CS, OUTPUT);
  pinMode(SD_CS, OUTPUT);
  pinMode(RESET_PIN, OUTPUT);
  signalSet(HIGH);

  // nastavení MAC
  mac[1] = version;
  for (byte i = 0; i < 4; i++) mac[i + 2] = ((byte *)&serial)[3 - i];

  // setup SPI slaves
  digitalWrite(ETH_CS, LOW); // select ethernet module
  digitalWrite(SD_CS, HIGH); // deselect SD card module
  resetW5100();

  setupEthernet();

  // inicializace databáse


  // inicializace čtečky
  wg.begin(PINd1, digitalPinToInterrupt(PINd1), PINd2, digitalPinToInterrupt(PINd2));
  Serial.println("Done Setup");
  signalOK();
}


void loop() {


  // pokud je něco na čtečce, zpracuj to
  if (wg.available()) {
    unsigned long code = wg.getCode();
    if (code > 100) {
      // karta
      Serial.println("Card...");
      Serial.print("Wiegand HEX = ");
      Serial.print(code, HEX);
      Serial.print(", Type W");
      Serial.println(wg.getWiegandType());
      if (callREST(code)) {
        Serial.println("Code sent to REST");
        signalOK();
      } else {
        Serial.println("Code send failed");
        signalFAIL();
      }
    } else {
      // klavesnice
      Serial.println("Keyboard hit ignored...");
    }
  }
  // DHCP renew
  if (! dhcpRenew++) {
    switch (Ethernet.maintain()) {
      case 0: // nothing to go
      case 2: // renew OK
      case 4: // rebind OK
        break;
      case 1: // renew failed
      case 3: // rebind failed
        resetW5100();
        setupEthernet();
        break;
    }
  }
}

void printIPAddress() {
  for (byte thisByte = 0; thisByte < 4; thisByte++) {
    // print the value of each byte of the IP address:
    Serial.print(Ethernet.localIP()[thisByte], DEC);
    if (thisByte < 3) Serial.print(".");
  }
}

byte callREST(unsigned long code) {
  
  return 0;
}

void signalSet(int level) {
  digitalWrite(PINbeep, level);
  digitalWrite(PINled, level);
}

void signalOK() {
  signalSet(LOW);
  delay(500);
  signalSet(HIGH);
}

void signalFAIL() {
  signalSet(LOW);
  delay(100);
  signalSet(HIGH);
  delay(100);
  signalSet(LOW);
  delay(100);
  signalSet(HIGH);
  delay(100);
  signalSet(LOW);
  delay(100);
  signalSet(HIGH);
}

void signalFAILNet() {
  signalSet(LOW);
  delay(1000);
  signalSet(HIGH);
  delay(100);
  signalSet(LOW);
  delay(100);
  signalSet(HIGH);
  delay(100);
  signalSet(LOW);
  delay(100);
  signalSet(HIGH);
}

void resetW5100() {
  Serial.println("Resetovani ethernet shieldu");
  delay(150);
  digitalWrite(RESET_PIN, LOW);  //low resets the W5100 chip
  delay(125);  //Keep this short, 25ms is good
  digitalWrite(RESET_PIN, HIGH);
  delay(1000);
  Serial.print("Resetovani hotovo!");
  Serial.println();
  Serial.println("Dignus zacal makat!");
}
