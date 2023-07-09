using System;

namespace Lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom.


            Console.WriteLine("introduceti un sir de caractere");
            string text = Console.ReadLine();

            string reverseText = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText += text[i];
            }

            if (text == reverseText)
            {
                Console.WriteLine("Sirul e Palindrom");
            }
            else
            {
                Console.WriteLine("Sirul nu e Palindrom");
            }



        }
    }
}
