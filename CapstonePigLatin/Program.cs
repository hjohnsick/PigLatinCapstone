using System;
using System.Text;
/* NOTE: Points will be awarded for items that are written correctly in themselves but don’t
actually work because other things are broken.There is a total of 10 points available for
this lab.
Intro: Pig Lagin is a children’s word game in English where starting consonants are flipped
to the ends of words and - ay is added to each word.Hello World would be elloyhay
orldway in Pig Latin, for instance.Many languages have games similar to this--read more at
http://mentalfloss.com/article/50242/pig-latins-11-other-languages
Task: Translate from English to Pig Latin
What will the application do?
● 1 Point: The application prompts the user for a word.
● 1 Point: The application translates the text to Pig Latin and displays it on the
console.
● 1 Point: The application asks the user if he or she wants to translate another word.
Build Specifications:
● 1 Point: Convert each word to a lowercase before translating.
● 1 Point: If a word starts with a vowel, just add “way” onto the ending.
● 2 Point: if a word starts with a consonant, move all of the consonants that appear
before the first vowel to the end of the word, then add “ay” to the end of the word.
Additional Requirements:
● 1 Point: For answering Lab Summary when submitting to the LMS
● -2 Points: if there are any syntax errors or if the program does not run(for example,
in a Main method).
Extended Exercises(2 points maximum):
● 1 Point: Keep the case of the word, whether its uppercase(WORD), title case (Word),
or lowercase(word).
● 1 Point: Allow punctuation in the input string.
● 1 Point: Translate words with contractions. Ex: can’t become an’tcay
● 1 Point: Don’t translate words that have numbers or symbols. Ex: 189 should be left
as 189 and hello@grandcircus.co should be left as hello@grandcircus.co.
● 1 Point: Check that the user has actually entered text before translating.
1 Point: Make the application take a line instead of a single word, and then find the
Pig Latin for each word in the line.
Hints:
● Treat “y” as a consonant.
*/
namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            //promts user for a word, captures response, and converts it to lower case
            Console.Write("What word would you like to translate into Pig Latin?");
            string englishWord = Console.ReadLine().ToLower();
            //calls method PigLatin and returns the word the user entered
            PigLatin(englishWord);
                 
        }
        public static void PigLatin(string word)
        {
            bool userInput = true;
                
            while (userInput)
            {
                //i holds the first letter of the word it is at position 0, goes through length of the word, keeps going until condition is met
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                    {// if the first letter is a vowel it will print the word plus way
                        if (i == 0)
                        {
                            Console.WriteLine(word + "way");
                            break;
                        }
                    }

                    else // if the word does not start with a vowel
                    {
                        char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                        int vowelIndex = word.IndexOfAny(vowel);
                        //prefix is the consants up to the vowel
                        string prefix = word.Substring(0, vowelIndex);
                        //suffix is starting with the vowel to the end of the word
                        string suffix = word.Substring(vowelIndex);
                        Console.WriteLine(suffix + prefix + "ay");
                        break;

                    }
                }
                    //I can't get this message to print.  
                    string userContinue = "";
                    while (userContinue != "y" && userContinue != "n")

                    {
                        Console.WriteLine("Would you like to translate another word? (y/n)");
                        userContinue = (Console.ReadLine().ToLower());
                        if (userContinue == "n")
                        {
                            userInput = false;
                            Console.WriteLine("All done");
                        }
                    
                    }
                
            }
            
        }
        
        
    }
}
