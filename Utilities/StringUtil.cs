using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public class StringUtil
    {
        public bool HasLetter(string str, char letterToSearchFor)
        {
            var hasLetter = false;

            for (var i = 0; i < str.Length; i++)
            {
                var charVal = str[i];

                if(str[i] == letterToSearchFor)
                {
                    hasLetter = true;
                    break;
                }
            }

            return hasLetter;
        }

        public void PrintBackwards(string str)
        {
            var i = str.Length - 1;

            while (i >= 0)
            {
                Console.WriteLine(str[i]);
                i = i - 1;
                //i -= 1;
            }
        }

        public string Capitalize(string str)
        {
            var newArray = new char[str.Length];

            for(var i = 0; i < str.Length; i++)
            {
                var charVal = str[i];
                var capitalizedChar = Char.ToUpper(charVal);
                newArray[i] = capitalizedChar;
            }
            
            return new string(newArray);
        }

        public string Reverse(string str)
        {
            var newArray = new char[str.Length];
            var index = 0;
            for (var i = str.Length - 1; i >= 0; i--)
            {
                newArray[index] = str[i];
                index++;
            }

            return new string(newArray);
        }

        public bool IsPalindrome(string phrase)
        {
            var newStr = Reverse(phrase);
            return phrase.Equals(newStr);
        }

        public bool IsPalindrome2(string phrase)
        {
            var index = 0;
            for (var i = phrase.Length - 1; i >= 0; i--)
            {
                if (phrase[index] != phrase[i]) {

                    return false;
                }

                index++;
            }

            return true;
        }
    }
}
