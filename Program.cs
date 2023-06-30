using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\file{i}.txt";
            FileStream file = new FileStream(path, FileMode.Create);
            file.Close();
            Console.WriteLine($"created file {i}");
        }
    }
}
