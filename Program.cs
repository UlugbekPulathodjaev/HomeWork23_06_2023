using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "forfiles");
        string text;

        for (int i = 1; i <= 10; i++)
        {
            text = $"Файл номер {i}";
            string fileName = Path.Combine(directoryPath, $"file{i}.txt");

            if (File.Exists(fileName))
            {
                Console.WriteLine($"Файл {fileName} уже существует");
                continue;
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(text);
            }
            Console.WriteLine();
        }
    }
}
