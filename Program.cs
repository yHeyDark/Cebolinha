string frase;
Console.Write("Traduza em cebolinha: ");
frase = Console.ReadLine()!.Replace('r', 'l').Replace('R', 'L');
Console.Write($"{frase}");