using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop_assigment_2
{
    //analyse class
    public class Analyse
    {
        //encapsulation is used to not allow acces to
        //lists max number of items so list can only be
        //max 5 items no more or less

        //encapsulation used here
        private int z = 5;

        //analyse text method 
        public List<int> analyseText(string input)
        {
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>(); //list called values

            //Initialise all the values in the list to '0'
            for (int i = 0; i < z; i++)
            {
                values.Add(0);
            }

            // 1. sentances 
            string[] sentances = input.Split("."); //split input by full stop
            Console.WriteLine((sentances.Length - 1) + " sentances in text"); //notifies user of result of total sentances in input
            values[0] = (sentances.Length - 1); //adds sentances to first item in values list

            // 2. vowels
            int vowels = 0;
            //searches input for items in the hash set
            var vowels_list = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels_list.Contains(input[i]))
                {
                    vowels++;
                }
            }
            Console.WriteLine(vowels + " vowels"); //notifies user of results of vowels
            values[1] = vowels; //adds vowels to second item in values list


            // 3. number of consonants
            int consonants = 0;
            //searches input for items in has set
            var consonants_list = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z', 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < input.Length; i++)
            {
                if (consonants_list.Contains(input[i]))
                {
                    consonants++;
                }
            }
            Console.WriteLine(consonants + " consonants");  //notifies user of results of consonants
            values[2] = consonants; //adds consonants to third item in values list

            // 4. upper case
            int lower_case = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //if character in input is lower lower case varible is implemented by 1
                if (char.IsLower(input[i])) lower_case++;
            }
            Console.WriteLine(lower_case + " lower case"); //notifies user of results of lower case
            values[3] = lower_case; //adds lower cases to fourth iterm in values list

            // 5. lower case
            int upper_case = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //if character in input is upper lower case varible is implemented by 1
                if (char.IsUpper(input[i])) upper_case++;
            }
            Console.WriteLine(upper_case + " upper case");//notifies user of results of upper case
            values[4] = upper_case; //adds upper cases to fifth iterm in values list

            return values; //reutrns values list
            
        }

        //long words analyse method
        public List<string> long_words_analyse(string input)
        {
            //words list insiated
            List<string> words = new List<string>();
            int comparasion = 7; //comparrasion set to 7 could be changed if needed diffrent length words
            string w = ""; //empty string created
            
            //iterate through every space in loop
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    //append sub string in string w
                    w = w + input[i];
                }
                else
                {
                    // if word (w) is longer than comparrision w is
                    //added to words list and appended to longWords txt file
                    if (w.Length > comparasion)
                    {
                        Console.Write(w + " ");
                        words.Add(w);
                        File.AppendAllText(@"C:\Users\pc\Documents\c# uni\oop_assigment_2\oop_assigment_2\longWords.txt", w + Environment.NewLine);
                    }
                    w = "";
                }
            }


            //words list is returned
            return words;
        }

    }

    //abstrac class created 
    //data abstraction used here
    abstract class long_words_file
    {
        //abstract method (no body on abstract methods)
        public abstract void long_words_working();
    }

    //derived class called long_words (inherit from long_words_file)
    class long_words : long_words_file
    {
        //abstract method overidden here
        public override void long_words_working()
        {
            //body of long_words_working here
            Console.WriteLine("\nWords longer than 7 letters have been added to longWords.txt");
        }
       
    }
}
