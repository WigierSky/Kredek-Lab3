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
            char[] answer = new char[x];

            Console.WriteLine("\r\n" + "Twoje słowo: " + "\r\n");
            for (int i = 0; i<x; i++)
            {
                answer[i] = '#';
                Console.Write(answer[i]);
            }
            while()
           Console.WriteLine("\r\n" + "Podaj literke:" + "\r\n");
           char letter = Char.Parse(Console.ReadLine());

            if (word.Contains(letter))
            {
                Console.WriteLine("\r\n"+ "Brawo, poprawna literka!" + "\r\n");

                Console.WriteLine("\r\n" + "Twoje słowo: " + "\r\n");
                for (int i = 0; i < x; i++)
                {
                    if (first_list[i] == letter)
                    {
                        answer[i] = letter;
                        Console.Write(answer[i]);
                        Console.WriteLine();
                    }
                    else Console.Write(answer[i]);
                    Console.WriteLine();
                }
            }
                else
                {
                    Console.WriteLine("\r\n"+"Niestety, ta literka nie znajduje w słowie" + "\r\n");
                    Console.WriteLine("\r\n" + "Twoje słowo: " + "\r\n");
                    Console.WriteLine("\r\n" + answer[] + "\r\n");
            }



               
            




        }

    }
}
