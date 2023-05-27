using System;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de manipulação de strings
        string frase = "Olá, isso é um exemplo de manipulação de strings!";
        Console.WriteLine(frase);

        // Tamanho da string
        int tamanho = frase.Length;
        Console.WriteLine("Tamanho da string: " + tamanho);

        // Transformar em maiúsculas
        string fraseMaiuscula = frase.ToUpper();
        Console.WriteLine("Maiúsculas: " + fraseMaiuscula);

        // Transformar em minúsculas
        string fraseMinuscula = frase.ToLower();
        Console.WriteLine("Minúsculas: " + fraseMinuscula);

        // Verificar se contém uma palavra específica
        bool contemPalavra = frase.Contains("exemplo");
        Console.WriteLine("Contém a palavra 'exemplo': " + contemPalavra);

        // Substituir parte da string
        string novaFrase = frase.Replace("exemplo", "teste");
        Console.WriteLine("Nova frase: " + novaFrase);

        // Dividir a string em partes separadas
        string[] partes = frase.Split(' ');
        Console.WriteLine("Partes separadas:");
        foreach (string parte in partes)
        {
            Console.Write(parte + "");
        }

        // Obter parte da string
        string parteDaFrase = frase.Substring(9, 7);
        Console.WriteLine("Parte da frase: " + parteDaFrase);

        // Remover espaços em branco no início e no final
        string fraseSemEspacos = frase.Trim();
        Console.WriteLine("Frase sem espaços: " + fraseSemEspacos);

        // Verificar se a string está vazia
        bool estaVazia = string.IsNullOrEmpty(frase);
        Console.WriteLine("A frase está vazia: " + estaVazia);

        // Aguardar pressionamento de tecla para sair
        Console.ReadKey();
    }
}