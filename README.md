# Word Counter

#### By **Loren Glenn**

## Description

Enter a sentence and a word to count how many times that word appears in the sentence.

#### Specs

| Test                                                                                    | Input                                  | Output | Description                                                                                                              |
|-----------------------------------------------------------------------------------------|----------------------------------------|--------|--------------------------------------------------------------------------------------------------------------------------|
|  Count a single letter word in a single letter string                                   | "a", "a"                               | 1      | This will be the most simple because the program won't have to loop through multiple unmatched words in the input string |
| Count a multi letter word in a single word string                                       | "apple", "apple"                       | 1      | This will look for a slightly more complex word inside the user input                                                    |
| Count a word that occurs only one time in a multi word string                           | "an apple", "apple"                    | 1      | This will need to search a more complex string for a specific word that occurs once                                      |
| Count a word that occurs multiple times in a multi word string                          | "the big red apple was big", "big"     | 2      | This will need to find all occurrences of a word that appears more than once in the same string                          |
| Count a word that occurs multiple times in a multi word string that is case insensitive | "the Big rEd BIG apPle was bIg", "big" | 3      | This will need to find all occurrences of a word that appears more than once in the same string ignoring case            |


## Setup/Installation Requirements

Requires Windows and .Net

Clone repository, run ">dnx kestrel" in Powershell and visit "localhost:5004".

## Known Bugs

None.


## Technologies Used

 C# was used for the backend logic as well as routing with Nancy and testing with Xunit. Razor was used to display data on the html pages.

 ## Support and contact details

 _lorencglenn@gmail.com_

 ### License

 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

 Copyright (c) 2016 **_Loren Glenn_**
