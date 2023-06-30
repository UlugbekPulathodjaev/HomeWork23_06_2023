using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileCreator.CreateFiles();
        FileCreator.WriteMathToFile();
    }
}

public static class FileCreator
{
    public static void CreateFiles()
    {
        for (int i = 1; i <= 10; i++)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\file{i}.txt";
            FileStream file = new FileStream(path, FileMode.Create);
            file.Close();
            Console.WriteLine($"created file {i}");
        }
    }

    public static void WriteMathToFile()
    {
        for (int i = 1; i <= 10; i++)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\file{i}.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("math");
            }
            Console.WriteLine($"written 'math' to file {i}");
        }
    }
}
