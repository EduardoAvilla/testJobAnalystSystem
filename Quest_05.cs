/*


5) Escreva um programa que inverta os caracteres de um string.



IMPORTANTE:

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b) Evite usar funções prontas, como, por exemplo, reverse;


*/



 
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
          Console.Write("Digite uma string: ");
        string original = Console.ReadLine();
        string invertida = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }

        Console.WriteLine("texto original: " + original);
        Console.WriteLine("texto invertida: " + invertida);
    }
    }
