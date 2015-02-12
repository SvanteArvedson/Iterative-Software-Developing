# AF1.1 - Köpa entrébiljett
Skapad av Svante Arvedson den 10 december 2013.      
Senast uppdaterad av Svante Arvedson den 19 december 2013.
      
Besökaren/Kunden går in på webbplatsen och väljer att köpa en entrébiljett. 
Besökaren/Kunden letar upp den datumet för besöket och bokar och betalar 
biljetten/biljetterna. Biljetten/biljetterna levereras på det sätt som 
besökaren/kunden väljer.

Testfall för det här användningsfallet: 
[TF1.1 - Köpa entrébiljett test](../testfall/TF1.1-Kopa-entrebiljett-test.md) 

## Primär aktör
+ Besökare/Kund

## Sekundär aktör
+ IT-Systemet - Tar hand om bokningar och leverans av biljett.
+ DIBS - Sköter internetbatalningar.

## Intressenter
+ Besökare/Kund - Vill enkelt och snabbt hitta och köpa biljetter från webbplatsen.
+ Konsumentlagstiftningen - Vill få in moms på sålda biljetter.
+ Djurparkens ledning - Vill få många sålda biljetter.

## Förkrav
*Inga*

## Efterkrav
Kunden ska ha tagit emot biljetten/biljetterna. Systemet ska ha registrerat 
bokningen och betalningen.

## Huvudscenario
+ 1. Scenariot startar när kunden vill köpa en eller flera entrébiljetter.
+ 2. Kunden går in på djurparkens webbplats och söker upp det datum som hen 
    vill köpa entrébiljetter till.
+ 3. Systemet visar tillgängliga biljetter samt priser och eventuella 
    [rabatter](../Datadefinitioner.md#rabatter) för dessa.
+ 4. Kunden väljer hur många av respektive [biljettyp](../Datadefinitioner.md#biljettyper) 
    som hen ska köpa.
+ 5. Systemet räknar ut totalt pris inklusive rabatter och moms och visar en 
    sammanställning av kundens beställning.      
    *Steg 2-5 upprepas tills kunden är nöjd med beställningen*
+ 6. Kunden kontrollerar beställningen och väljer [betalningsätt](../Datadefinitioner.md#betalningsätt).
+ 7. Systemet skickar kunden vidare till DIBS.
+ 8. Kunden genomför betalning hos DIBS.
+ 9. Systemet bekräftar att betalningen är genomförd.
+ 10. Kunden väljer hur [leverans](../Datadefinitioner.md#biljettleverans) av biljetten 
    ska gå till.
+ 11. Systemet levererar biljetten/biljetterna.
+ 12. Systemet registrerar bokningen och ett [bokningsnummer](../Datadefinitioner.md#bokningsnummer).

## Alternaivscenario
+ *a. Köpet avbryts
    + 1a. Kunden avbryter köpet.      
        + 1. *Användningsfallet avslutas*
    + 1b. Ett oväntat fel uppstår.
        + 1. Systemet uppmanar kunden att ta kontakt med djurparkens kommunikatörer och visar djurparkens kontaktuppgifter.      
        + 2. *Användningsfallet avslutas*
+ 2a. Om kunden väljer ett datum då djurparken är stängd.
    + 1. Systemet informerar kunden om att djurparken är stängd och ber kunden att välja ett nytt datum.      
    + 2. *Gå tillbaka till punkt 2*
+ 4a. Kunden vill köpa en studentbiljett.
    + 1. Systemet begär numret på kundens mecenatkort.
    + 2. Kunden anger numret på sitt mecenatkort.      
    + 3. *Gå tillbaka till punkt 4*
+ 4b. Kunden vill köpa en föreningsbiljett.
    + 1. Systemet begär namn och föreningstillhörighet på den som ska använda biljetten.
    + 2. Kunden anger namn och föreningstillhörighet.      
    + 3. *Gå tillbaka till punkt 4*
+ 6a. Betalningssättet som kunden har valt är inte tillgängligt för tillfället.
    + 1. Systemet informerar kunden om detta och ber henom att välja ett annat betalningssätt.
    + 2. *Gå tillbaka till punkt 6*
+ 9a. Systemet lyckas ej bekräfta att betalningen är genomförd.
    + 1. Systemet informerar kunden om att betalningen ej är bekräftad och frågar kunden om hen har genomfört betalning.
        + 1a. Kunden svarar att hen har betalat
            + 1. Systemet uppmanar kunden att ta kontakt med DIBS      
            + 2. *Användningsfallet avslutas*
        + 1b. Kunden svarar att hen ej har betalat
            + 1. Systemet ber kunden att göra om betalningen      
            + 2. *Gå tillbaka till punkt 6*
+ 10a. Om kunden väljer att få biljetten hemskickad med post
    + 1. Systemet ber kunden att ange en leveransadress.
    + 2. Kunden uppger leveransadress.
    + 3. Systemet presenterar den angivna leveransadressen och ber kunden kontrollera 
        att denna är korrekt.      
        *Steg 2 och 3 upprepas tills kunden är nöjd*
    + 4. Kunden bekräftar adressen.
    + 5. Systemet presenterar biljettens bokningsnummer.      
    + 6. *Gå till punkt 11*

## Speciella krav
+ Användningsfallet ska kunna köras på svenska och engelska.
+ Man ska kunna betala med SEK, DK och Euro.
+ Gränssnittet ska passa ihop med djurparkens nuvarande profil.

## Frågor
+ Är det skillnad på evenemangsbiljetter och entrébiljetter vad gäller moms?
+ Är det skillnad på olika [biljettyper](../Datadefinitioner.md#biljettyper) 
    vad gäller moms?
+ Ska kunden erbjudas försäkrning om biljetten ej kunde användas? Exempelvis vid 
    olycka, sjukdom eller oväder?
+ Hur ska ansvarsfördelningen vid misslyckad betalning delas mellan Barnens djurpark och 
    DIBS? 