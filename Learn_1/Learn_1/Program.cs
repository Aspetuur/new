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

        int mak = 0, c = 0;

        for (int i = 0; i < symbols.Length; i++)
        {
            if (symbols[i] == 'A' || symbols[i] == 'E')
            {
                if (c > mak)
                {
                    mak = c;
                }

                c = 0;
            }
            else
            {
                c++;
            }
        }

        Console.WriteLine($"Длина длиной подцепочки без гласных букв в строке - {mak}");
    }
}

