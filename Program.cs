Console.Clear();

double milhas = 0.0, km = 0;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Digite a medida em Milhas:");
milhas = Convert.ToDouble(Console.ReadLine()!);

km = milhas *  1.60934;

Console.Write($"O valor de milhas convertido é: {km} KM");

Console.ResetColor();

