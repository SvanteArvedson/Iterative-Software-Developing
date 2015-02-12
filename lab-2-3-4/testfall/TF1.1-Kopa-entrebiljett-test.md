# TF1.1 - Köpa entrébiljett test
Skapad av Svante Arvedson den 16 december 2013.      
Senast uppdaterad av Svante Arvedson den 19 december 2013.

Testfall för användningsfall 
[AF1.1 - Köpa entrebiljett](../anvandarfall/AF1.1-Kopa-entrebiljett.md)

## Förkrav
Skapa testmiljöns databas.      
Få tillgång till DIBS testmodul.      
Skapa mailkonton testkund@gmail.com.

## Efterkrav
Kontrollera att systemet har registrerat bokningen *20140422-0*, bokningen skall 
innehålla två (2) vuxenbiljetter och två (2) barnbiljetter. Kontrollera att 
biljetterna och [bokningsnumret](../Datadefinitioner.md#bokningsnummer) har nått 
fram till den angivna mottagarna.

## Huvudscenario
+ 1. Gå in på djurparkens webbshop www.barnensdjurpark.se/webbshop.
+ 2. Välj tisdagen den 22 april 2014.
+ 3. Systemet presenterar biljettyperna:      
    Barn      
    Vuxen      
    Pensionär     
    Studentbiljett      
    Föreningsbiljett
+ 4. Välj att köpa två(2) vuxenbiljetter och två(2) barnbiljetter.
+ 5. Systemet visar en sammanställning av bokningen samt totalt pris:      
    Vuxen 280kr      
    Vuxen 280kr      
    Barn 200kr      
    Barn 200kr      
    Totalt: 960kr
+ 6. Välj att betala med internetbank.
+ 7. Systemet skickar dig vidare till DIBS system för internetbanksbetalning 
    (till DIBS testmodul).
+ 8. Betala hos DIBS (i DIBS testmodul).
+ 9. Systemet bekräftar hos DIBS att betalningen är genomförd.
+ 10. Välj att få biljetten levererad som en PDF-fil till e-postadressen 
    testkund@gmail.com
+ 11. Systemet skickar ett mail till testkund@gmail.com med en bifogad PDF-fil 
    där biljetterna och bokningsnumret *20140422-0* finns med. 
+ 12. Systemet registrerar bokningen och bokningsnumret.

## Alternativscenarion
+ 2a. Välj fredagen den 18 april 2014.
    + 1. Systemet informerar om att djurparken är stängd för allmänheten under 
        påskhögtiden den 17-21 april. Systemet ber dig att välja ett annat datum.
    + 2. *Fortsätt med huvudscenario punkt 2*
+ 4a. Välj att köpa en(1) studentbiljett och en(1) vuxenbiljett.
    + 1. Systemet begär ditt Mecenatkortsnummer.
    + 2. Ange Mecenatkortsnummer *03751960*.
    + 3. Systemet visar en sammanställning av bokningen samt totalt pris:      
        Vuxen 280kr      
        Student 0kr      
        Totalt: 280kr
    + 4. *Fortsätt med huvudscenario punkt 6*.
+ 4b. Välj att köpa en(1) föreningsbiljett och en(1) pensionärbiljett.
    + 1. Systemet begär ditt namn och föreningstillhörighet.
    + 2. Ange namn *Kalle Testkund* och föreningstillhörighet 
        *Barnens djurparks vänförening*.
    + 3. Systemet visar en sammanställning av bokningen samt totalt pris:      
        Föreningsmedlem 200kr      
        Pensionär 200kr      
        Totalt pris: 400kr
    + 4. *Fortsätt med huvudscenario punkt 6*
+ 6a. Välj att betala med mobilbank.
    + 1. Systemet skickar dig till DIBS system för mobilbanksbetalning 
        (DIBS testmodul).
    + 2. Betala hos DIBS (i DIBS testmodul).
    + 3. *Fortsätt med huvudscenario punkt 9*
+ 6b. Välj att betala med kreditkort.
    + 1. Systemet skickar dig till DIBS system för kreditkortsbetalning 
        (DIBS testmodul).
    + 2. Betala hos DIBS (i DIBS testmodul).
    + 3. *Fortsätt med huvudscenario punkt 9*
+ 6c. Välj att betala med internetbank.      
    *(Innan detta alternativscenario körs --> stäng av internetbank i DIBS testmodul)*
    + 1. Systemet informerar om att betalning med internetbank ej är tillgängligt 
        för tillfället. Systemet ber dig att välja ett annat betalningsätt.
    + 2. *Fortsätt med huvudscenario punkt 6*
+ 9a. Systemet lyckas inte bekräfta att betalningen lyckades. 
    + 1. Systemet frågar dig om du har betalat.
        + 1a. Välj "Ja"
            + 1. Systemet visar telefonnummer och e-postadress till DIBS och ber 
                dig att ta kontakt med dem.
            + 2. *Köpet avbryts*
        + 1b. Välj "Nej"
            + 1. Systemet ber dig att göra om beställningen och skickar dig 
                tillbaka till start.
            + 2. *Fortsätt med huvudscenario punkt 2*
+ 10a. Välj att få biljetten leverarad som med sms till mobilnummer *0738041412*.
    + 1. Systemet skickar ett sms med en sammanställning av bokningen och 
        bokningsnumret *20140422-0*.
    + 2. *Fortsätt med huvudscenario punkt 12*
+ 10b. Välj att få biljetten hemskickad med post.
    + 1. Systemet frågar efter leveransadress.
    + 2. Ange leveransadress:      
        Utvecklingsteamet      
        Programmeringsgatan 12      
        Malmö 215 32
    + 3. Systemet visar adressen och ber dig kontrollera att adressen är rätt.
    + 4. Välj "Ja".
    + 5. Systemet visar dig bokningsnumret *20140422-0* och uppmanar dig att skriva ner det.
    + 6. Systemet skickar adressen och bokningsinformationen till 
        receptionen@barnensdjurpark.se      
        (receptionen har hand om att skicka ut biljetter).
    + 7. *Fortsätt med huvudscenario punkt 12*