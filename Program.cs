using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una cadena de caracteres: ");
        string chain = Console.ReadLine();

        chain = chain.Replace(" ", "").ToLower();
         
        string reverse = new string(chain.Reverse().ToArray());
        if (chain == reverse)
        {
            Console.WriteLine("La cadena es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La cadena no es un palíndromo.");
        }
    }
}
