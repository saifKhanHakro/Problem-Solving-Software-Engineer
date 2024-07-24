using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class StringProblems
    {
        public string ReverseString(string input)
        {
            var array = input.ToCharArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            return new string(array);
        }

        public string ReverseWords(string input)
        {

            var words = ReverseString(input).ToCharArray();
            var wordsList = new List<string>();

            int startingIndex = 0;

            for (int i = 0; i < words.Length; i++)
            {
                while (i < words.Length && words[i] != ' ')
                {
                    i++;
                }

                var tempWord = new char[i - startingIndex];

                for (int j = startingIndex, wordInput = 0; j < i; j++)
                {
                    tempWord[wordInput] = words[j];
                    wordInput++;
                }
                wordsList.Add(ReverseString(new string(tempWord)).Trim());

                startingIndex = i;
            }

            return string.Join(" ", wordsList.ToArray());
        }

        public void StringBuilderExample()
        {
            var strings = new List<string>();

            for (int i = 0; i < 10000; i++)
            {
                strings.Add("SAIF HAKRO");
            };

            var stringBuilder = new StringBuilder();

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            foreach (var x in strings)
                stringBuilder.Append(x);

            watch.Stop();

            Console.WriteLine(watch.Elapsed.ToString());

            string complete = string.Empty;

            watch.Start();

            foreach (var x in strings)
                complete.Concat(x);

            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds.ToString());
        }

        public bool IsUnique(string input)
        {
            var unique = new HashSet<char>();

            foreach (var inputCharacter in input.ToCharArray())
            {
                if (!unique.Contains(inputCharacter))
                    unique.Add(inputCharacter);
                else
                    return false;
            }

            return true;
        }

        public bool CheckPermutation(string inputOne, string inputTwo)
        {
            var input1 = inputOne.ToCharArray();
            var input2 = inputTwo.ToCharArray();

            Array.Sort(input1);
            Array.Sort(input2);


            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] != input2[i])
                    return false;
            }

            return true;
        }

        public string URLify(string input)
        {
            var output = string.Empty;
            var charArray = input.Trim().ToCharArray();

            foreach (var x in charArray)
            {
                if (x.Equals(' '))
                    output = string.Concat(output, "%20");
                else
                    output = string.Concat(output, x);
            }


            return output;
        }

        public void PrintPermutations(string input)
        {
            HashSet<string> strings = new HashSet<string>();
            strings.Add(input);

            var arr = input.ToCharArray();


            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i].ToString();//a

                for (int j = 0; j < arr.Length; j++)
                {
                    if (j != i)
                        temp = string.Concat(temp, arr[j]);
                }

                if (!strings.Contains(temp))
                    strings.Add(temp);

                temp = arr[i].ToString();//a

                for (int k = arr.Length - 1; k >= 0; k--)
                {
                    if (k != i)
                        temp = string.Concat(temp, arr[k]);
                }

                if (!strings.Contains(temp))
                    strings.Add(temp);
            }


            foreach (var inputString in strings)
                Console.WriteLine(inputString);

            Console.ReadLine();

        }

        public void PrintsUniqueCharactersInString(string input)
        {
            var characters = new List<char>();

            foreach (var character in input.ToCharArray())
            {
                if (!characters.Contains(character))
                {
                    Console.WriteLine(character);
                    characters.Add(character);
                }
            }
        }

        public void PrintString(string input)
        {
            foreach (var inputCharacter in input.ToCharArray())
            {
                Console.WriteLine(inputCharacter);
            }

            Console.ReadLine();
        }
    }
}