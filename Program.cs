// By Silktz 
int Notas1, Nota2, Notas3, Notas4, Medias, Resultado;

Console.BackgroundColor =ConsoleColor.DarkCyan;
Console.WriteLine("=-=-=-=-MediassS-=-=-=-=");

Console.WriteLine("Digite a 1° Nota: ");
Notas1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a 2° Nota: ");
Nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a 3° Nota: ");
Notas3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a 4° Nota: ");
Notas4 = Convert.ToInt32(Console.ReadLine());

bool NotasValidas = Notas1 >= 0 && Notas1 <= 10
                 && Nota2 >= 0 && Nota2 <= 10
                 && Notas3 >= 0 && Notas3 <= 10
                 && Notas4 >= 0 && Notas4 <= 10;


if (NotasValidas)
{
    Medias = (Notas1 + Nota2 + Notas3 + Notas4) / 4;

    if (Medias < 5)
    {
    Resultado = "Reprovado";
    }
    else
    
     if (Medias > 6)
        {
            Resultado = "Aprovado";
        }
        else
        {
            Resultado = "Em recuperação";
        }

    Console.WriteLine($"Você ficou com a média {Medias:N1}. Resultado: {Resultado}");    
}
else
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}