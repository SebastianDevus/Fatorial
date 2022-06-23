int resultado = 1;
int numeroEscolhido;

Console.Clear();
Console.WriteLine("----- Fatorial -----");

Console.Write("Número: ");
numeroEscolhido = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numeroEscolhido; i++)
{
    resultado *= i;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nO fatorial de {numeroEscolhido} é igual a {resultado}\n");
Console.ResetColor();