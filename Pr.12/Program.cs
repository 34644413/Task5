using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string word = "каміння"; // замість "каміння" можна вказати будь-яке інше слово

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    Console.WriteLine("Однаковi лiтери: " + word[i]);
                    Console.WriteLine("Позицiї: " + i + ", " + j);
                }
            }
        }
    }
}