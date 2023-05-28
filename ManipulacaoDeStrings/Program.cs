using System;

class Program
{
    static void Main()
    {
        string text = "  Hello, World!  ";

        // Exemplo 1: Conversão para maiúsculas e minúsculas
        Console.WriteLine(text.ToUpper());  // Resultado: "  HELLO, WORLD!  "
        Console.WriteLine(text.ToLower());  // Resultado: "  hello, world!  "

        // Exemplo 2: Remover espaços em branco
        Console.WriteLine(text.Trim());  // Resultado: "Hello, World!"

        // Exemplo 3: Obter uma substring
        Console.WriteLine(text.Substring(7, 5));  // Resultado: "World"

        // Exemplo 4: Dividir uma string em substrings
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Exemplo 5: Substituir substrings
        Console.WriteLine(text.Replace("World", "Universe"));  // Resultado: "  Hello, Universe!  "

        // Exemplo 6: Combinar uma matriz de strings
        string[] fruits = { "Apple", "Banana", "Orange" };
        string fruitString = string.Join(", ", fruits);
        Console.WriteLine(fruitString);  // Resultado: "Apple, Banana, Orange"

        // Exemplo 7: Verificar se a string é nula ou vazia
        string emptyString = "";
        Console.WriteLine(string.IsNullOrWhiteSpace(emptyString));  // Resultado: true

        // Exemplo 8: Formatação de string
        string name = "John";
        int age = 30;
        string formattedString = string.Format("My name is {0} and I'm {1} years old.", name, age);
        Console.WriteLine(formattedString);  // Resultado: "My name is John and I'm 30 years old."

        // Exemplo 9: Localizar a posição de uma substring
        Console.WriteLine(text.IndexOf("World"));  // Resultado: 9
        Console.WriteLine(text.LastIndexOf("o"));  // Resultado: 10

        // Exemplo 10: Verificar se uma string começa ou termina com uma substring
        Console.WriteLine(text.StartsWith("Hello"));  // Resultado: true
        Console.WriteLine(text.EndsWith("!"));  // Resultado: true

        string sentence = "The quick brown fox jumps over the lazy dog";

        // Exemplo 11: Verificar se uma string contém outra string
        Console.WriteLine(sentence.Contains("fox"));  // Resultado: true

        // Exemplo 12: Dividir uma string em substrings com base em várias opções de separadores
        string[] words2 = sentence.Split(new char[] { ' ', ',' });
        foreach (string word in words2)
        {
            Console.WriteLine(word);
        }

        // Exemplo 13: Remover caracteres específicos de uma string
        string specialChars = "!@#$%^&*()";
        string cleanedString = sentence;
        foreach (char c in specialChars)
        {
            cleanedString = cleanedString.Replace(c.ToString(), "");
        }
        Console.WriteLine(cleanedString);  // Resultado: "The quick brown fox jumps over the lazy dog"

        // Exemplo 14: Contar o número de ocorrências de uma substring em uma string
        int count = sentence.Split(new string[] { "the" }, StringSplitOptions.None).Length - 1;
        Console.WriteLine(count);  // Resultado: 2

        // Exemplo 15: Inverter uma string
        char[] charArray = sentence.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        Console.WriteLine(reversedString);  // Resultado: "god yzal eht revo spmuj xof nworb kciuq ehT"

        // Exemplo 16: Concatenar strings usando o operador "+"
        string part1 = "Hello";
        string part2 = "World";
        string concatenatedString = part1 + ", " + part2;
        Console.WriteLine(concatenatedString);  // Resultado: "Hello, World"

        // Exemplo 17: Verificar se uma string é igual a outra ignorando maiúsculas e minúsculas
        string str1 = "Hello";
        string str2 = "hello";
        bool equalIgnoreCase = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(equalIgnoreCase);  // Resultado: true

        Console.ReadLine();
    }
}