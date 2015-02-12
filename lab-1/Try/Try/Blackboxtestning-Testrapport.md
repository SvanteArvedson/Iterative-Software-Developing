# Black-box testning - Testrapport
Rapport över testfallen i [Black box testfallen](Blackboxtestning-Testfall.md).

## Testrapport
Testerna utfördes den 14/11 klockan 13:57.

<table>
	<tr>
		<th>Test</th>
		<th>Förväntad utdata</th>
		<th>Faktiskt utdata</th>
		<th>Resultat</th>
		<th>Kommentar</th>
	</tr>
	<tr>
		<td>1</td>
		<td>"Triangeln är liksidig"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>2</td>
		<td>"Triangeln är liksidig"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>3</td>
		<td>"Triangeln är liksidig"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>4</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>5</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är likbent"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>6</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är likbent"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>7</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>8</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>9</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>10</td>
		<td>"Triangeln är liksidig"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>11</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är likbent"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>12</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>13</td>
		<td>Felmeddelande</td>
		<td>"Triangeln är likbent"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>14</td>
		<td>Felmeddelande</td>
		<td>"Triangeln är likbent"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>15</td>
		<td>Felmeddelande</td>
		<td>Ohanterat undantag</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>16</td>
		<td>Felmeddelande</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>17</td>
		<td>Felmeddelande</td>
		<td>"Triangeln är likbent"<</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
</table>

## Analys
Analysen delas in i de test 1-3, test 4-6, test 7-9, test 10-12 och test 13-17. Testerna i de olika gruperna hör ihop och är därför lämpliga att analysera ihop.
### Test 1-3
Test 1-3 testar giltiga parametrar för en liksidig triangel. Testresultaten visar att en giltig liksidig triangel behandlas av programmet på ett korrekt sätt.
### Test 4-6
Test 4-6 testar giltiga parametrar för en likbent triangel. Här misslyckades test 4 medan test 5 och 6 lyckades. Möjliga anledningar till att test 4 misslyckades 
skulle kunna vara placeringen av de lika sidorna eller att variationen mellan de olika talen är väldigt små. Att triangeln tolkades som liksidig skule kunna tyda
på att applikationen på något sätt avrundar värdena och alltså tolkar värdena *0,3* och *0,35* som samma tal. Flera tester måste göras för att avgöra vad felet beror på.
### Test 7-9
Test 7-9 testar giltiga parametrar för en triangel med olika sidor. Test 7 misslyckades och test 8 och 9 lyckades. Även här misslyckades testet när sidornas variation var 
mycket små, vilket skulle kunna tyda på att applikationen gör en avrundning innan triangeln behandlas. Fler tester måste göras för att se vad felet beror på.
### Test 10-12
Test 10-12 testar om programmet klarar av att ta heltal som parametrar. Alla testerna lyckades, det är alltså inga problem för applikationen att omtolka heltalen till decimaltal.
### Test 13-17
Test 13-17 testar på olika sätt om programmet hanterar felaktiga parametrar på ett bra sätt. Samtliga test misslyckades, vilket på ett mycket tydligt sätt visar att programmet
inte validerar parametrarna eller antalet värden som matas in innan programmet körs. Programmet hanterar inte heller de undantag som eventuellt kastas, exempelvis när indatan är av fel typer.
0 värden och negativa värden tolkas som godkända värden trots att detta inte borde gå.  

- - -

## Testrapport extra tester
Testerna utfördes den 14/11 klockan 16:20.

<table>
	<tr>
		<th>Test</th>
		<th>Förväntad utdata</th>
		<th>Faktiskt utdata</th>
		<th>Resultat</th>
		<th>Kommentar</th>
	</tr>
	<tr>
		<td>18</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är likbent"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>19</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är likbent"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>20</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är likbent"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>21</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>22</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är likbent"</td>
		<td>Lyckades</td>
		<td></td>
	</tr>
	<tr>
		<td>23</td>
		<td>"Triangeln är likbent"</td>
		<td>"Triangeln är liksidig"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
</table>

- - -

## Testrapport för extra test
Test utförst den 19/11 klockan 23:15.

<table>
	<tr>
		<th>Test</th>
		<th>Förväntad utdata</th>
		<th>Faktiskt utdata</th>
		<th>Resultat</th>
		<th>Kommentar</th>
	</tr>
	<tr>
		<td>24</td>
		<td>Felmeddelande</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Misslyckades</td>
		<td></td>
	</tr>
</table>

## Analys
### Testfall 18-20
Utifrån testfall 18-20 ser vi att applikationen inte har några problem att hantera när likasidorna i en giltig triangel är på de olika möjliga positionerna(1,2 / 1,3 / 2,3).
### Testfall 21-23
Test 21-23 visar att applikationen inte klarar av att hantera decimaltal som börjar på samma heltal (exempelvis 0,5 och 0,6) utan tolkar dessa som samma tal. När den heltalssiffran 
skiljer (exemelvis 0,9 och 1,0) är det däremot inga problem för applikationen att tolka indatan.
### Testfall 24
Test 24 visar att applikationen inte kontrollerar att indatan gäller för en giltig triangel.

## Slutsats
Applikationen kan inte på ett bra sätt hantera decimaltal. På något sätt så avrundas decimalerna inne i applikationen och beräkningarna blir därför fel. Applikationens felhantering 
fungerar inte heller som den ska, felaktiga parametrar, som exempelvis negativa tal eller fel antal argument godtas och kastade undantag hanteras inte.

/Svante Arvedson, 14/11 klockan 17:06