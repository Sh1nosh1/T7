using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Th7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1
                //Matching a number from the Unicode table to a symbol.

                /*for (int i = 0; i <= 256; i++)
                {
                    WriteLine($"The code {i} corresponds to the symbol {(char)i}");
                }*/


                //Task 2
                //A symbol is given. Output its code.

                /*Write("Enter a symbol: ");
                char ch = Convert.ToChar(ReadLine());
                WriteLine($"\nThe symbol has a code: {(int)ch}");*/


                //Task 3
                //A symbol is given. Output the symbol that follows this symbol in the ASCII code table.

                /*Write("Enter a symbol: ");
                char ch = Convert.ToChar(ReadLine());
                WriteLine($"\nThe following symbol has a code: {(char)(int)(ch + 1)}");*/


                //Task 4
                //A symbol is given. Output the two symbols preceding it in the ASCII code table.

                /*Write("Enter a symbol: ");
                char ch = Convert.ToChar(ReadLine());
                WriteLine($"\nThe two symbols preceding it: {(char)(int)(ch - 1)} and {(char)(int)(ch - 2)}");*/


                //Task 5
                //A symbol is given.
                //Output two symbols, the first of which precedes the entered character in the code table, and the second which follows it.

                /*Write("Enter a symbol: ");
                char ch = Convert.ToChar(ReadLine());
                WriteLine($"\nTwo characters before and after the entered: {(char)(int)(ch - 1)} and {(char)(int)(ch + 1)}");*/


                //Task 6
                //Type the name of the soccer club. Print it on the screen in a column.

                /*Write("Type the name of the soccer club: ");
                string ch = ReadLine();
                char[] chars = ch.ToCharArray();
                foreach (char element in chars)
                {
                    WriteLine($"{element}");
                }*/


                //Task 7
                //Make a program that prints the given word starting from the last letter.

                /*Write("Type the word: ");
                string word = ReadLine();
                char[] chars = word.ToCharArray();
                for (int a = word.Length - 1; a >= 0; a--)
                {
                    WriteLine($"{chars[a]}");
                }*/


                //Task 8
                //Convert symbols in a string from lowercase to uppercase and back again.

                /*Write("Type a word: ");
                string word = ReadLine();
                WriteLine($"\n{word.ToUpper()}\n{word.ToLower()}");*/


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
