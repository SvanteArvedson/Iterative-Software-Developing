# Kravspecifikation
Skriven av Svante Arvedson den 9 dectember 2013.      
Senast uppdaterad av Svante Arvedson den 11 december 2013.

## Referenser
Vision för projektet: [Vision](Vision.md "Till Visionen")     
Kravlistan: [Kravlista](Kravlista.md "Till Kravlistan")

## Aktörer

### Primära aktörer

#### 1 Besökare/Kund

##### 1a Barnfamilj/Privatperson
Barnfamiljer/Privatpersoner köper endast några få biljetter åt gången. Vill 
snabbt hitta information om öppettider, parkeringsmöjligheter, hur man tar sig 
till djurparken, osv. Vill få information om barnvänliga föreställningar och 
guidade turer. Familjer ska kunna köpa familjebiljetter till rabatterat pris.

##### 1b Skola
Vill snabbt kunna köpa biljetter till en stor grupp med personer (elever och 
lärare). Vill kunna boka guidad tur anpassad till skolklass i samband med 
biljettköpet. Ska erbjudas att boka bussresa i samband med biljettköpet. 
Biljetterna ska levereras som en gruppbiljett och ej som seperata biljetter. 

##### 1c Förening
Vill få information anpassad efter föreningens intresseområde. Vill kunna boka 
anpassad guidad tur och erbjudande om att köpa gruppbiljett ska ges. 
[Föreningar som får rabatt](foreningar-som-far-rabatt.md) ska få specialpris på 
entrebiljetten som på utvalda arrangemang.

##### 1d Student
Studenter på Holmköpings folkhögskola får enligt avtal med studentkåren gratis 
entré till djurparken vardagar klo 09:00-14:00 samt till vissa utvalda 
föreläsningar.

#### 2 Kommunikatör/Webbansvarig
Vill kunna lägga till nya eller förändra information om evenemang i systemet. 
Vill kunna förändra texter och bilder på webbplatsen genom ett enkelt 
användargränssnitt. Vill kunna redigera förslagslådan, exempelvis kunna radera 
stötande inlägg och spärra störande besökare.

#### 3 Systemansvarig
Vill kunna lägga till och ta bort systemanvändare. Vill kunna starta upp, stänga 
ner samt underhålla systemet.

#### 4 Djurparkens ledning
Vill kunna se statistik över antal sålda biljetter, antal osålda biljetter, 
vinster och förluster på ensiljda evenemang osv. Statistiken ska kunna användas 
för att utvärdera evenemangen.

### Stödjande aktörer

#### DIBS
Levererar en plug-and-play modul för betalning över nätet.      
[www.dibs.se](http://www.dibs.se/ "Till DIBS")

#### Busscentralen
Skolor som bokar gruppbiljetter via Barnens djurparks webbplats erbjuds rabatt 
hos Busscentralen.     
[www.busscentralen.se](http://www.busscentralen.se/se/index.php "Till Busscentralen")

#### STIM
Betalar ut licenspengar till artister och upphovsrättsinnehavare till musikaliska 
verk. [www.stim.se](http://www.stim.se "Till STIM")

### Offstage aktörer

#### Stiftelsen Barnens djurparks styrelse
Vill att den nya webbplatsens utseende ska passa in i djurparkens nuvarande 
profil vad gäller val av färger och design.

## Funktionella krav

### Användningsfall

#### 1 Besökare/Kund

##### 1a Barnfamilj/Privatperson
* [AF1.1 - Köpa entrébiljett](anvandarfall/AF1.1-Kopa-entrebiljett.md)
* [AF1.2 - Köpa evenemangsbiljett](anvandarfall/AF1.2-Kopa-evenemangsbiljett.md)
* [AF1.5 - Returnera betald biljett](anvandarfall/AF1.5-Returnera-betald-biljett.md)
* [AF1.6 - Posta förslag i förslagslådan](anvandarfall/AF1.6-Posta-forslag-i-forslagsladan.md)

##### 1d Student
* [AF1.1 - Köpa entrébiljett](anvandarfall/AF1.1-Kopa-entrebiljett.md)
* [AF1.2 - Köpa evenemangsbiljett](anvandarfall/AF1.2-Kopa-evenemangsbiljett.md)
* [AF1.5 - Returnera betald biljett](anvandarfall/AF1.5-Returnera-betald-biljett.md)
* [AF1.6 - Posta förslag i förslagslådan](anvandarfall/AF1.6-Posta-forslag-i-forslagsladan.md)

##### 1b Skola
* [AF1.3 - Köpa entrégruppbiljett](anvandarfall/AF1.3-Kopa-entregruppbiljett.md)
* [AF1.4 - Köpa evenemangsgruppbiljett](anvandarfall/AF1.4-Kopa-evenemangsgruppbiljett.md)
* [AF1.5 - Returnera betald biljett](anvandarfall/AF1.5-Returnera-betald-biljett.md)
* [AF1.6 - Posta förslag i förslagslådan](anvandarfall/AF1.6-Posta-forslag-i-forslagsladan.md)

##### 1c Förening
* [AF1.3 - Köpa entrégruppbiljett](anvandarfall/AF1.3-Kopa-entregruppbiljett.md)
* [AF1.4 - Köpa evenemangsgruppbiljett](anvandarfall/AF1.4-Kopa-evenemangsgruppbiljett.md)
* [AF1.5 - Returnera betald biljett](anvandarfall/AF1.5-Returnera-betald-biljett.md)
* [AF1.6 - Posta förslag i förslagslådan](anvandarfall/AF1.6-Posta-forslag-i-forslagsladan.md)

#### 2 Kommunikatör/Webbansvarig
* [AF2.1 - Lägga in ett nytt evenemang](anvandarfall/AF2.1-Lagga-in-ett-nytt-evenemang.md)
* [AF2.2 - Redigera ett evenemang](anvandarfall/AF2.2-Redigera-ett-evenemang.md)
* [AF2.3 - Publicera en artikel](anvandarfall/AF2.3-Publicera-en-artikel.md)
* [AF2.4 - Ta bort artikel](anvandarfall/AF2.4-Ta-bort-artikel.md)
* [AF2.5 - Ta bort inlägg från förslagslådan](anvandarfall/AF2.5-Ta-bort-inlagg-fran-forslagsladan.md)

#### 3 Systemansvarig
* [AF3.1 - Lägga till en ny medarbetare](anvandarfall/AF3.1-Lagga-till-ny-medarbetare.md)
* [AF3.2 - Ta bort en medarbetare](anvandarfall/AF3.2-Ta-bort-en-medarbetare.md)  

#### 4 Djurparkens ledning
* [AF4.1 - Få ut statistik från systemet](anvandarfall/AF4.1-Fa-ut-statistik-fran-systemet.md)

## Icke funktionella krav
*(Utanför avgränsningen för denna laboration)*