# Audio analysis and processing - Project 1

C# / [NAudio](https://github.com/naudio/NAudio) / WinForms

## Features

- `*.wav` files support
- Displaying waveform in time
- Calculating and displaying parameters
    - Values:
        - VSTD *(volume standard deviation)*,
        - VDR *(volume dynamic range)*,
        - LSTER *(low short time energy ratio)*,
        - HZCRR *(high zero crossing rate ratio)*,
        - ZSTD *(ZCR standard deviation)*
    - Charts:
        - volume,
        - STE *(short time energy)*,
        - ZCR *(zero crossing rate)*,
        - silence,
        - voiced / unvoiced speech
- Silence detection (quasi working)
- Detection of voiced / unvoiced speech fragments (using *STE* and *ZCR*)

### Planned features

- Energy entropy chart
- Music / speech detection + chart
- Optional
    - `*.mp3` files support
    - Waveform display: X/Y scaling, offsetting, displaying markers
    - Saving markers definining boundaries for calculated params (samples or time) to csv

## Links

- [Course site](https://mini.pw.edu.pl/~rafalkoj/www/?Dydaktyka:2019%2F2020:-_Analiza_i_przetwarzanie_d%BCwi%EAku)
- [Separation of Voiced and Unvoiced using Zero crossing rate and Energy of the Speech Signal, *Bachu R.G., Kopparthi S., Adapa B., Barkana B.D.*](https://www.asee.org/documents/zones/zone1/2008/student/ASEE12008_0044_paper.pdf)
- [Pitch Detection Methods, *Politechnika Gdańska*](https://sound.eti.pg.gda.pl/student/eim/synteza/leszczyna/index_ang.htm)
