Console.WriteLine("PROGAMA CALCULAR MÉDIA");
Console.WriteLine("Digite a primeira nota");
decimal nota1 =Convert.ToDecimal ( Console.ReadLine());
Console.WriteLine("Digite a segunda nota");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a terceira nota");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a terceira nota");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());

decimal media = (nota1 + nota2 + nota3+nota4) / 3;

Console.WriteLine($"A média é: {media} ");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}