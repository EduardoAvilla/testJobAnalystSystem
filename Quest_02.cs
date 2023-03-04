/*


2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo
valor sempre será a soma dos 2 valores anteriores 
(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa
na linguagem que desejar onde, informado um número
ele calcule a sequência de Fibonacci e retorne uma mensagem avisando 
se o número informado pertence ou não a sequência.

*/


using System;

class Program
{
    static void Main(string[] args)
    {
        int numero, a = 0, b = 1, c = 0;
        bool condition = false;

        Console.Write("Digite um número:");
        
        numero = int.Parse(Console.ReadLine());
        
 
        if (numero == 0 || numero == 1)
        {
            condition = true;
            
        }
        else
        
        {
            
            while (c < numero){
            
            
                c = a + b;
                
                a = b;
                
                
                b = c;

                if (c == numero){
                
                
                    condition = true;
                    
                    break;
                }
                
                
                
                
            }
            
        }

        if (condition){
        
        
            Console.WriteLine("{0} pertence a sequencia.", numero);
        }
        else{
              
        
            Console.WriteLine("{0} nao pertence a sequencia.", numero);
        }
        
    }
    
}
