using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string symbols;

        using (FileStream fstream = File.OpenRead("task1.txt"))
        {
            byte[] buffer = new byte[fstream.Length];
            fstream.Read(buffer, 0, buffer.Length);

            symbols = System.Text.Encoding.UTF8.GetString(buffer);
        }

        int max = 0, counter = 0;

        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i] == 'A' || symbols[i] == 'E')
            {
                if (counter > max)
                {
                    max = counter;
                }

                counter = 0;
            }
            else
            {
                counter++;
            }
        }

        Console.WriteLine($"Длина длинейшей подцепочки без гласных в строке - {max}");
    }
}

