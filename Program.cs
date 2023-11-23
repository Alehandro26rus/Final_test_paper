using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Ввод исходного массива
        string[] source = { "Hello", "2", "world", ":-)" };

        // Находим количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i].Length <= 3)
            {
                count++;
            }
        }
        // Создаем новый массив для хранения результатов
        string[] result = new string[count];


    }
}
