using System;

namespace Tema1  
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int nr = rnd.Next(0, 100);
            int num;
           // Console.WriteLine("Numarul este {0}", nr);
                                   
            do
            {
                Console.WriteLine("Introduceti un nr:\n");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Ai introdus numarul {0}", num);

                if (num == nr)
                {
                    Console.WriteLine("Felicitari ai ghicit numarul, el este {0}", nr);
                }
                else
                {
                    Console.WriteLine("Mai incearca o data");
                    if (num > nr)
                    {
                        Console.WriteLine("Numarul introdus este mai mare");
                    }
                    else
                    {
                        Console.WriteLine("Numarul introdus este mai mic");
                    }
                }
            }

            while (num != nr);
        }
    }
}
