using System;

namespace Kredek_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo do wisielca");
            String word = Console.ReadLine();
            int x = word.Length;
            char[] first_list = new char[x];
            first_list = word.ToCharArray(0, x);
            int chances = 5;
            char[] second_list = new char[chances];
            char[] answer = new char[x];

            Console.WriteLine("\r\n" + "Twoje słowo: ");
            Console.Write("=================" + "\r\n");
            for (int i = 0; i < x; i++)
            {
                answer[i] = '#';
                Console.Write(answer[i]);
            }
            Console.Write("\r\n" + "=================");
            Console.WriteLine("\r\n");
            bool c = true;
            int k = 0;
            Console.WriteLine("Masz tylko 5 szans! Inaczej bałwan zawiśnie!");
            while (c && second_list[chances - 1] == 0)
            {

                Console.WriteLine("\r\n" + "Podaj literke:");
                char letter = Char.Parse(Console.ReadLine());
   

                if (word.Contains(letter))
                {
                    Console.WriteLine("\r\n" + "Brawo, poprawna literka!" + "\r\n");

                    Console.WriteLine("\r\n" + "Twoje słowo: ");
                    Console.Write("=================" + "\r\n");
                    for (int i = 0; i < x; i++)
                    {
                        if (first_list[i] == letter)
                        {
                            answer[i] = letter;
                            Console.Write(answer[i]);
                        }
                        else Console.Write(answer[i]);
                    }
                    Console.Write("\r\n" + "=================");
                    Console.WriteLine();
                }
                else
                {
                    second_list[k] = letter;
                    k++;
                    Console.WriteLine("\r\n" + "Niestety, ta literka nie znajduje w słowie" + "\r\n");
                    Console.WriteLine("\r\n" + "Twoje słowo: ");
                    Console.Write("================" + "\r\n");
                    for (int i = 0; i < x; i++)
                    {
                        Console.Write(answer[i]);
                    }
                    Console.Write("\r\n" + "=================");
                    Console.WriteLine();

                    if(k==1)
                    {
                        Console.WriteLine("===============");
                        Console.WriteLine("___________");
                        Console.WriteLine("          |");
                        Console.WriteLine();
                        Console.WriteLine("===============");
                    }else
                        if(k==2)
                    {
                        Console.WriteLine("===============");
                        Console.WriteLine("___________");
                        Console.WriteLine("          |");
                        Console.WriteLine("         (..) ");
                        Console.WriteLine();
                        Console.WriteLine("===============");
                    }else
                        if(k==3)
                    {
                        Console.WriteLine("===============");
                        Console.WriteLine("___________");
                        Console.WriteLine("          |");
                        Console.WriteLine("      \\ (..) /");
                        Console.WriteLine();
                        Console.WriteLine("===============");
                    }else
                        if(k==4)
                    {
                        Console.WriteLine("===============");
                        Console.WriteLine("___________");
                        Console.WriteLine("          |");
                        Console.WriteLine("      \\ (..) /");
                        Console.WriteLine("       (    )");
                        Console.WriteLine();
                        Console.WriteLine("===============");
                    }
                        

                }

                for (int j = 0; j < x; j++)
                {
                    if (answer[j] == first_list[j])
                    {
                        c = false;
                    }
                    else
                    {
                        c = true;
                        break;
                    }

                }

            }

            if (c == false)
            {
                Console.WriteLine("____________________________");
                Console.WriteLine("\r\n" + "Gratulacje! Odgadłeś słowo! :>");
                Console.WriteLine("____________________________");
            }
            else
            {
                Console.WriteLine("____________________________");
                Console.WriteLine("\r\n" + "Przykro mi, przegrałeś :<");
                Console.WriteLine("____________________________");
                Console.WriteLine();
                Console.WriteLine("===============");
                Console.WriteLine("___________");
                Console.WriteLine("          |");
                Console.WriteLine("      \\ (..) /");
                Console.WriteLine("       (    )");
                Console.WriteLine("      (      )");
                Console.WriteLine();
                Console.WriteLine("===============");
            }

        }
    }
}
