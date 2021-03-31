# CountCharacters
Create a class with two property i.e. Character and occurence say Data.
Create and array of Data and initialize the Character property with a-z with index 0-25.
Get the input string and convert it into char array.
Loop through the char array and read the current item.
If current item's(which is a char) ASCCI falls between 97-122 that means it is a small alphabet character.
Subtract 97 from the char ascii to get the index of the corresponding letter in Data array, and increase the occurence property by 1.
If current item's(which is a char) ASCCI falls between 65-90 that means it is a small alphabet character.
Subtract 65 from the char ascii to get the index of the corresponding letter in Data array, and increase the occurence property by 1.
Filter out all the array item for which the occurence property is greater than zero.

