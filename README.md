# Analiza i przetwarzanie dźwięku - Projekt #1

C# / [NAudio](https://github.com/naudio/NAudio)

## Features

- Wczytywanie plików wav (mp3)

### TODO

- Wyświetlanie przebiegu czasowego pliku audio
- Skalowanie w osi x i y, przesuwanie, wyświetlanie markerów(opcjonalnie)
- Wyświetlanie parametrów(wartości, wykresy)
- Zapis parametrów, np. csv(opcjonalnie)
- Określenie fragmentów dźwięcznych / bezdźwięcznych
- Określenie fragmentów muzyka / mowa
- Detekcja ciszy
- Zapis markerów określających granice(opcjonalnie)
- Porównanie wyników dla różnych nagrań: radio (mowa + muzyka), mowa (głos męski, żeński), muzyka

### Notes

- wgrać np fragment audycji radiowej spróbować określić gdzie jest muzyka gdzie mowa (nie proste
przy tych parametrach pewnie przybliżone)
- określanie fragmentów dź (ma tor podstawowy krtaniowy), bezdź (nie ma toru, szumy) na podstawie
zcr i ste

- zapis markerów które wyznaczymy (numer próbki czy czas) do pliku
- zapisać wykresy do plików

#### Sprawozdanie

- latex
- w sprawozdaniu porównać dla róźnych nagrań i opisać
- różnego typu nagrania (najlepiej np. audycje radiowe, też nagrania naszych głosów)
- w sprawozdaniu wzory jako wzory nie jpg
- podawać źródła
- podpisywać wykresy i wgl
- wklejanie kodu


### Wstępna obróbka nagrań

1. Wyodrębnienie wszystkich słów do oddzielnych plików
2. Nazwa pliku to wypowiadany wyraz
3. Nazwa zdań to: zdanie_1, zdanie_2, ...
4. Pliki zapisać w folderze o nazwie: Nieznormalizowane
5. Dodatkowo wszystkie wyodrębnione pliki należy znormalizować (w Audacity) i zapisać w drugim
folderze o nazwie: Znormalizowane
6. Wszystko razem wspakowanym folderze Speaker_nr przesłać na mój adres

### Links

- [Course site](https://mini.pw.edu.pl/~rafalkoj/www/?Dydaktyka:2019%2F2020:-_Analiza_i_przetwarzanie_d%BCwi%EAku)
