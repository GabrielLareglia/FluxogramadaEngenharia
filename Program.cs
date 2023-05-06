Console.WriteLine("--- Fluxograma Da Engenharia ---");
Console.WriteLine();

Console.Write("O objeto está se movendo (S/N)?\n");
bool estaEmMovimento = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria?\n");
bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "N";

string mensagem;

if (!estaEmMovimento)
{
    
    if (!deveria)
    {
        mensagem = "Perfeito!";
    }
    else
    {
        mensagem = "Use WD-40.";
    }
}
else
{
    if (deveria)
    {
        mensagem = "Excelente!";
    }
    else
    {
        mensagem = "Use Fita Adesiva.";
    }
}

Console.WriteLine();
Console.WriteLine(mensagem);
