using System;

namespace ScannerDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            string numeros =
@"                              .     __  __      __  __  __  __  __  __  __  __  __ .
                                .  |  __| __||__||__ |__    ||__||__||  | __||__    |.
                                .  | |__  __|   | __||__|   ||__| __||__||__ |__|   |.
                                                                                    ";
                System.IO.StringReader imprimir = new System.IO.StringReader(numeros.Trim());
                string primeiraLinha = imprimir.ReadLine();
                primeiraLinha = primeiraLinha.Trim();
                char[] primeira = primeiraLinha.ToCharArray();
                string segundaLinha = imprimir.ReadLine();
                segundaLinha = segundaLinha.Trim();
                char[] segunda = segundaLinha.ToCharArray();
                string terceiraLinha = imprimir.ReadLine();
                terceiraLinha = terceiraLinha.Trim();
                char[] terceira = terceiraLinha.ToCharArray();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\nENTRADA:");
            for (int i = 1; i < primeira.Length-1; i++)
            {
                Console.Write(primeira[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < segunda.Length-1; i++)
            {
                Console.Write(segunda[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < terceira.Length-1; i++)
            {
                Console.Write(terceira[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nSAÍDA:");
                for (int i = 1; i < primeira.Length-1; i+=4)
                {
                string strprimeira = "";
                string strsegunda = "";
                string strterceira = "";

                for (int j = i; j <= i + 3; j++)
                    {
                        strprimeira = strprimeira + primeira[j];
                        strsegunda = strsegunda + segunda[j];
                        strterceira = strterceira + terceira[j];

                    }
                    
                    //numero 1
                    if (strprimeira == "    " && strsegunda == "  | " && strterceira == "  | ")
                    {
                        Console.Write("1");
                        continue;
                    }
                    //numero 2
                    else if (strprimeira == " __ " && strsegunda == " __|" && strterceira == "|__ ")
                    {
                        Console.Write("2");
                        continue;
                    }
                    //numero 3
                    else if (strprimeira == " __ " && strsegunda == " __|" && strterceira == " __|")
                    {
                        Console.Write("3");
                        continue;
                    }
                    //numero 4 
                    else if (strprimeira == "    " && strsegunda == "|__|" && strterceira == "   |")
                    {
                        Console.Write("4");
                        continue;
                    }
                    //numero 5
                    else if (strprimeira == " __ " && strsegunda == "|__ " && strterceira == " __|")
                    {
                        Console.Write("5");
                        continue;
                    }
                    //numero 6
                    else if (strprimeira == " __ " && strsegunda == "|__ " && strterceira == "|__|")
                    {
                        Console.Write("6");
                    }
                    //numero 7
                    else if (strprimeira == " __ " && strsegunda == "   |" && strterceira == "   |")
                    {
                        Console.Write("7");
                    }
                    //numero 8 
                    else if (strprimeira == " __ " && strsegunda == "|__|" && strterceira == "|__|")
                    {
                        Console.Write("8");
                    }
                    //numero 9 
                    else if (strprimeira == " __ " && strsegunda == "|__|" && strterceira == " __|")
                    {
                        Console.Write("9");
                    }
                    //numero 0
                    else if (strprimeira == " __ " && strsegunda == "|  |" && strterceira == "|__|")
                    {
                        Console.Write("0");
                    }
                    
                }
                Console.ReadLine();
            }
        }
    
}
