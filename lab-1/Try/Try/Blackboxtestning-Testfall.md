# Black-box testning - Testfall
I README.TXT finns instruktioner på hur applikationen är tänkt att fungera. Det är instruktionerna i denna fil som jag utgår från när jag skapar mina testfall.

## Testfall
  * Testfall 1-12 testar giltiga parametrar
	* Testfall 1-3 testar giltiga parametrar på en liksidig triangel
	* Testfall 4-6 testar giltiga parametrar på en likbent triangel
	* Testfall 7-9 testar giltiga parametrar på en triangel utan lika sidor
	* Testfall 10-12 testar heltal som parametrar. Dessa skall kunna omtolkas till decimaltal vid exekveringen.
  * Testfall 13-17 testar olika ormer av ogiltiga parametrar.

<table>
	<tr>
		<th>Testfall</th>
		<th>Indata</th>
		<th>Förväntad utdata</th>
		<th>Beskrivning</th>
	</tr>
	<tr>
		<td>1</td>
		<td>2,0 2,0 2,0</td>
		<td>"Triangeln är liksidig"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>2</td>
		<td>334,5 334,5 334,5</td>
		<td>"Triangeln är liksidig"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>3</td>
		<td>103467,8892 103467,8892 103467,8892</td>
		<td>"Triangeln är liksidig"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>4</td>
		<td>0,3 0,35 0,3</td>
		<td>"Triangeln är likbent"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>5</td>
		<td>103467,8892 103467,8892 69,0</td>
		<td>"Triangeln är likbent"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>6</td>
		<td>2,55 3,0 3,0</td>
		<td>"Triangeln är likbent"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>7</td>
		<td>0,026 0,029 0,036</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>8</td>
		<td>103467,0 103465,0 101,0</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>9</td>
		<td>3,6 4,0 5,7</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Test av giltiga parametrar.</td>
	</tr>
	<tr>
		<td>10</td>
		<td>13 13 13</td>
		<td>"Triangeln är liksidig"</td>
		<td>Test med heltal som parametrar.</td>
	</tr>
	<tr>
		<td>11</td>
		<td>15 13 13</td>
		<td>"Triangeln är likbent"</td>
		<td>Test med heltal som parametrar.</td>
	</tr>
	<tr>
		<td>12</td>
		<td>15 13 11</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Test med heltal som parametrar.</td>
	</tr>
	<tr>
		<td>13</td>
		<td>2,5 1,5</td>
		<td>Felmeddelande</td>
		<td>Test av ogiltigt antal parametrar.</td>
	</tr>
	<tr>
		<td>14</td>
		<td>2,5 3,0 3,0 2,5</td>
		<td>Felmeddelande</td>
		<td>Test av ogiltigt antal parametrar.</td>
	</tr>
	<tr>
		<td>15</td>
		<td>3,0 sju 3,0</td>
		<td>Felmeddelande</td>
		<td>Test av ogiltig typ av parameter.</td>
	</tr>
	<tr>
		<td>16</td>
		<td>3,0 2,5 0,0</td>
		<td>Felmeddelande</td>
		<td>Test av ett nollvärde som parameter.</td>
	</tr>
	<tr>
		<td>17</td>
		<td>-3,0 2,5 2,5</td>
		<td>Felmeddelande</td>
		<td>Test av ett negativt tal som parameter.</td>
	</tr>
</table>

- - -

### Extra tester
Tester av input med små variationer och test av liksidig triangel.

<table>
	<tr>
		<th>Testfall</th>
		<th>Indata</th>
		<th>Förväntad utdata</th>
		<th>Beskrivning</th>
	</tr>
	<tr>
		<td>18</td>
		<td>2,55 3,0 3,0</td>
		<td>"Triangeln är likbent"</td>
		<td>Test av position 2 och 3.</td>
	</tr>
	<tr>
		<td>19</td>
		<td>3,0 2,55 3,0</td>
		<td>"Triangeln är likbent"</td>
		<td>Test av position 1 och 3.</td>
	</tr>
	<tr>
		<td>20</td>
		<td>3,0 3,0 2,55</td>
		<td>"Triangeln är likbent"</td>
		<td>Test av position 1 och 2.</td>
	</tr>
	<tr>
		<td>21</td>
		<td>0,55 0,5 0,6</td>
		<td>"Triangeln har inga lika sidor"</td>
		<td>Test indata med små variationer.</td>
	</tr>
	<tr>
		<td>22</td>
		<td>0,9 0,9 1,0</td>
		<td>"Triangeln är likbent"</td>
		<td>Test indata med små variationer.</td>
	</tr>
	<tr>
		<td>23</td>
		<td>44,45 44,55 44,55</td>
		<td>"Triangeln är likbent"</td>
		<td>Test indata med små variationer.</td>
	</tr>
</table>

- - -

### Extra tester
Test för triangel med ogiltiga värden. Skriven den 19/11.

<table>
	<tr>
		<th>Testfall</th>
		<th>Indata</th>
		<th>Förväntad utdata</th>
		<th>Beskrivning</th>
	</tr>
	<tr>
		<td>24</td>
		<td>1,0 2,0 3,0</td>
		<td>Felmeddelande</td>
		<td>Test av triangel med ogiltiga värden.</td>
	</tr>
</table>