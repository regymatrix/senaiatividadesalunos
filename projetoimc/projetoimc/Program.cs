double pesoEmKg;
double alturaEmMetros;
double imc;

Console.WriteLine("Digite o peso: ");
pesoEmKg = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Digite a aultra: ");
alturaEmMetros = Convert.ToDouble(Console.ReadLine());

if (alturaEmMetros == 0)
{
    Console.WriteLine("Altura deve ser maior que zero");
    return;
}

double alturaAoQuadrado = alturaEmMetros * alturaEmMetros;
imc = pesoEmKg / alturaAoQuadrado;
double imcFormatado = Math.Round(imc, 2);

Console.WriteLine($"O Imc é: {imcFormatado}");

if (imcFormatado <= 29.9)
{
    Console.WriteLine("Margro");
}
else
{
    Console.WriteLine("Obesidade");
}