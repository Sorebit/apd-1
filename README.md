# Audio analysis and processing - Project 1

C# / [NAudio](https://github.com/naudio/NAudio) / WinForms

## Features

- `*.wav` files support
- Displaying waveform in time
- Calculating and displaying parameters
    - Values: VSTD, VDR, LSTER, HZCRR, ZSTD
    - Charts: Volume, STE, ZCR, silence, voiced / unvoiced speech
- Silence detection (quasi working)
- Detection of voiced / unvoiced speech fragments (using STE and ZCR)

### Planned features

- Energy entropy chart
- Music / speech detection + chart
- Optional
    - `*.mp3` files support
    - Waveform display: X/Y scaling, offsetting, displaying markers
    - Saving markers definining boundaries for calculated params (samples or time) to csv

### Sprawozdanie

- LaTeX
- w sprawozdaniu porównać dla róźnych nagrań i opisać
    - różnego typu nagrania (najlepiej np. audycje radiowe, też nagrania naszych głosów)
    - Porównanie wyników dla różnych nagrań: radio (mowa + muzyka), mowa (głos męski, żeński),
    muzyka
    - Określenie fragmentów muzyka / mowa
    - wgrać np fragment audycji radiowej spróbować określić gdzie jest muzyka gdzie mowa (nie proste
    przy tych parametrach pewnie przybliżone)
- w sprawozdaniu wzory jako wzory nie jpg
- podawać źródła
- podpisywać wykresy i wgl
- wklejanie kodu

## Links

- [Course site](https://mini.pw.edu.pl/~rafalkoj/www/?Dydaktyka:2019%2F2020:-_Analiza_i_przetwarzanie_d%BCwi%EAku)
- [Separation of Voiced and Unvoiced using Zero crossing rate and Energy of the Speech Signal](https://www.asee.org/documents/zones/zone1/2008/student/ASEE12008_0044_paper.pdf)
- [Pitch Detection Methods](https://sound.eti.pg.gda.pl/student/eim/synteza/leszczyna/index_ang.htm)
