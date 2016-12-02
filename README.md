| Test                                                                                    | Input                              | Output | Description                                                                                                              |
|-----------------------------------------------------------------------------------------|------------------------------------|--------|--------------------------------------------------------------------------------------------------------------------------|
|  Count a single letter word in a single letter string                                   | "a", "a"                           | 1      | This will be the most simple because the program won't have to loop through multiple unmatched words in the input string |
| Count a multi letter word in a single word string                                       | "apple", "apple"                   | 1      | This will look for a slightly more complex word inside the user input                                                    |
| Count a word that occurs only one time in a multi word string                           | "an apple", "apple"                | 1      | This will need to search a more complex string for a specific word that occurs once                                      |
| Count a word that occurs multiple times in a multi word string                          | "the big red apple was big", "big" | 2      | This will need to find all occurrences of a word that appears more than once in the same string                          |
| Count a word that occurs multiple times in a multi word string that is case insensitive | "the Big rEd apPle was bIg", "big" | 2      | This will need to find all occurrences of a word that appears more than once in the same string ignoring case            |