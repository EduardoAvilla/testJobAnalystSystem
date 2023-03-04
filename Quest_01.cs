
/*
1) Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);



Ao final do processamento, qual será o valor da variável SOMA?

Resposta = 91.

*/ 


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int INDICE = 13, SOMA = 0, K = 0;

while (K < INDICE)
{
// OU K=K+1
    K++; 
    SOMA = SOMA + K;
}

Console.WriteLine(SOMA);
    }
}
