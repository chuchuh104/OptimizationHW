using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
        Dictionary<string, int> wordCounts = WordFrequency(text);

        foreach (var item in wordCounts)
        {
            Console.WriteLine($"{item.Key}: {item.Value}"); // Используем интерполяцию строк для лучшей читаемости
        }
    }

    static Dictionary<string, int> WordFrequency(string text)
    {
        // Используем LINQ для более компактного и эффективного подсчета слов
        return text.Split(new char[] { ' ', '.', '!' }, StringSplitOptions.RemoveEmptyEntries) // Разделители: пробел, точка, восклицательный знак
                   .GroupBy(word => word.ToLower()) // Группируем слова без учета регистра
                   .ToDictionary(group => group.Key, group => group.Count()); // Создаем словарь: слово (ключ) - количество (значение)

    }
}

