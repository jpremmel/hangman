# _Hangman_

#### _A game where the user guesses a word one letter at a time, 1 Oct 2019_

#### By _**Anita Kemp, Jacqueline Remmel, and Sofia Giordano**_

## Specifications

| Behavior | Input | Output |
| -------- | :---------: | :---------: |
| The program only accepts a single character of alphabetical input | "10" | "Please try again." |
| The program picks a word and returns an underscore for each letter | none | "_ _ _ _ _ _ _ _" |
| The program prints a "try again" message if the letter is not in the pre-selected word | "t"  | "This letter is not in the word, please try again." |
| If the input letter is in the chosen word, the program prints out the letter at the appropriate spot in the word, replacing that underscore | "v" | "_ _ _ _ v _ _ _" |
| When all of the letters have been guessed, the entire word is displayed | "r" | "aardvark" |


## Setup/Installation Requirements

* _Clone this repository and navigate to the "hangman" project directory_
* _Navigate to "Hangman.Solution" and then to "Hangman"_
* _Run the command "dotnet restore"_
* _Run the command "dotnet run"_

## Technologies Used

_C#, .NET_

### License

*Open-source*

Copyright (c) 2019 **_Anita Kemp, Jacqueline Remmel, and Sofia Giordano_**