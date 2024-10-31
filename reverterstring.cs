class InverterString
{
    static void Main()
    {
        Console.Write("Digite uma string para ser invertida: ");
        string input = Console.ReadLine();

        char[] caracteresInvertidos = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            caracteresInvertidos[i] = input[input.Length - 1 - i];
        }

        string invertida = new string(caracteresInvertidos);
        Console.WriteLine("String invertida: " + invertida);
    }
}