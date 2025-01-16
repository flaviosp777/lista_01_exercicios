/*
 Ex.09 Dia da semana (usando if-else)
 

Objetivo: Pratique o uso de várias condições com if, else if e else. 
Descrição: Desenvolva um programa que solicite um número de 1 a 7 e exiba o dia da semana correspondente (1 para "domingo", 2 para "segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
Exemplo de saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7."
 
 */

using System.Diagnostics.Tracing;
using System.Security.Cryptography;

Console.WriteLine("Insira um numero de 1 a 7");
int Dia = int.Parse(Console.ReadLine());


if (Dia == 1)
{
    Console.WriteLine("Domingo");
}
else if (Dia == 2)
{
    Console.WriteLine("Segunda");
}
else if (Dia == 3)
{
    Console.WriteLine("Terça");
}
else if (Dia == 4)
{
    Console.WriteLine("Quarta");
}
else if (Dia == 5)
{
    Console.WriteLine("Quinta");
}
else if (Dia == 6)
{
    Console.WriteLine("Sexta");
}
else if (Dia == 7)
{
    Console.WriteLine("Sabado");
}
else
{
    Console.WriteLine("dia invalido");
}