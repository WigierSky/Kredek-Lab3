using System;

namespace Kredek_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo do wielca");
            String word = Console.ReadLine();
            int x = word.Length;
            char[] first_list = new char[x];
            first_list = word.ToCharArray(0, x);
            int chances = 10;
            char[] second_list = new char[chances];

           
        }

        bool is_Full(char[] x)
        {
            if (x != null)
            {
                return true;
            }
            else return false;

        }
    }
}
