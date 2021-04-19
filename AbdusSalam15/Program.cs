using System;

namespace MrYusufAssingment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any word:  ");
            string word = Console.Readline();

            string reverseWordString = string.Join("", word.Split(' ').select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"Reverse Word String : {reverseWordString}");
        }
    }
}
