/*
 Ex. 02 Número Positivo ou Negativo
 

Objetivo: Aprenda a trabalhar com várias condições. 
Descrição: Desenvolva um programa que solicite ao usuário um número. O programa deve determinar se o número é positivo, negativo ou zero, usando if, else if e else para todas as três possibilidades. Exiba a mensagem correspondente. 
Exemplo de saída: "O número é positivo.", "O número é negativo." ou "O número é zero".
 
 */

using System.ComponentModel.Design;

Console.WriteLine("digite um numero");
int numero = int.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine("maior que zero");
}
else if (numero == 0)
{
    Console.WriteLine("zero");
}
else if (numero < 0)
{
    Console.WriteLine("numero negativo");
}







