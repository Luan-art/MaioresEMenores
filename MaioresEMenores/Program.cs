int idade = 0, pessoas = 0, maiores = 0, menores = 0;

while (pessoas < 10)
{
    do
    {
    Console.WriteLine("Digite sua idade");
    idade = int.Parse(Console.ReadLine());

    } while (idade < 0);

    if (idade < 18)
    {
        menores++;
    }
    else
    {
        maiores++;
    }

    pessoas++;
}

Console.WriteLine($"Temos ao todos {menores} menores de idade");
Console.WriteLine($"Temos ao todos {maiores} menores de idade");
