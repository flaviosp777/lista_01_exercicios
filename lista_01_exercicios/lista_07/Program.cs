/*
 Ex.07 Comparação de números
 

Objetivo: Pratique a comparação de variáveis. 
Descrição: Escreva um programa que solicite ao usuário dois números e determine qual é o maior. Use if, else if e else para exibir a mensagem apropriada. 
Exemplo de saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais."
 
 */

Console.WriteLine(" primeiro numero");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine(" segundo numero ");
int numero2 = int.Parse(Console.ReadLine());
if (numero > numero2)
{
    Console.WriteLine("primeiro numero é maior que o segundo");
}
else if (numero2 > numero)
{
    Console.WriteLine("segundo numero é maior que o primeiro ");
}
else if (numero2 == numero)
{
    Console.WriteLine(" são iguais ");
}