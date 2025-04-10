using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string dictionariesFolder = "dictionaries";

    static void Main()
    {
        if (!Directory.Exists(dictionariesFolder))
            Directory.CreateDirectory(dictionariesFolder);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== МЕНЮ ====");
            Console.WriteLine("1. Создать словарь");
            Console.WriteLine("2. Управление словарями");
            Console.WriteLine("0. Выход");
            Console.Write("Выбор: ");
            var choice = Console.ReadLine();

            if (choice == "1")
                CreateDictionary();
            else if (choice == "2")
                ManageDictionaries();
            else if (choice == "0")
                return;
            else
            {
                Console.WriteLine("Неверный выбор!");
                Console.ReadKey();
            }
        }
    }

    static void CreateDictionary()
    {
        Console.Write("Введите имя словаря (например: en-ru): ");
        string name = Console.ReadLine();
        string path = Path.Combine(dictionariesFolder, name + ".txt");

        if (File.Exists(path))
        {
            Console.WriteLine("Такой словарь уже существует!");
            Console.ReadKey();
            return;
        }

        File.Create(path).Close();
        Console.WriteLine("Словарь создан.");
        Console.ReadKey();
    }

    static void ManageDictionaries()
    {
        var files = Directory.GetFiles(dictionariesFolder, "*.txt");

        if (files.Length == 0)
        {
            Console.WriteLine("Нет доступных словарей.");
            Console.ReadKey();
            return;
        }

        Console.Clear();
        Console.WriteLine("Выберите словарь:");
        
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileNameWithoutExtension(files[i])}");
        }

        Console.Write("Выбор: ");
        int index;
        string input = Console.ReadLine();
        bool isValidIndex = int.TryParse(input, out index);

        if (!isValidIndex || index < 1 || index > files.Length)
        {
            Console.WriteLine("Неверный выбор.");
            Console.ReadKey();
            return;
        }

        string selectedPath = files[index - 1];
        DictionaryMenu(selectedPath);
    }

    static void DictionaryMenu(string path)
    {
        string name = Path.GetFileNameWithoutExtension(path);
        var dict = LoadDictionary(path);

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== Словарь: {name} ===");
            Console.WriteLine("1. Добавить слово и перевод");
            Console.WriteLine("2. Заменить слово или перевод");
            Console.WriteLine("3. Удалить слово или перевод");
            Console.WriteLine("4. Найти перевод слова");
            Console.WriteLine("5. Экспортировать слово в файл");
            Console.WriteLine("0. Назад");
            Console.Write("Выбор: ");
            var choice = Console.ReadLine();

            if (choice == "1")
                AddWord(dict);
            else if (choice == "2")
                ReplaceWordOrTranslation(dict);
            else if (choice == "3")
                DeleteWordOrTranslation(dict);
            else if (choice == "4")
                SearchTranslation(dict);
            else if (choice == "5")
                ExportWord(dict);
            else if (choice == "0")
            {
                SaveDictionary(path, dict);
                return;
            }
            else
            {
                Console.WriteLine("Неверный выбор!");
            }
        }
    }

    static Dictionary<string, List<string>> LoadDictionary(string path)
    {
        return File.ReadLines(path)
    .Where(line => line.Contains("|"))
    .Select(line => line.Split('|'))
    .ToDictionary(parts => parts[0], parts => parts[1].Split(',').Select(p => p.Trim()).ToList());

    }

    static void SaveDictionary(string path, Dictionary<string, List<string>> dict)
    {
        var lines = dict.Select(kvp => $"{kvp.Key}|{string.Join(",", kvp.Value)}");
        File.WriteAllLines(path, lines);
    }

    static void AddWord(Dictionary<string, List<string>> dict)
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите перевод(ы), через запятую: ");
        var translations = Console.ReadLine().Split(',').Select(t => t.Trim()).Where(t => t.Length > 0).ToList();

        if (translations.Count == 0)
        {
            Console.WriteLine("Нет переводов.");
            Console.ReadKey();
            return;
        }

        if (dict.ContainsKey(word))
        {
            
            dict[word].AddRange(translations.Except(dict[word]));
        }
        else
        {
            dict[word] = translations;
        }

        Console.WriteLine("Добавлено.");
        Console.ReadKey();
    }

    static void ReplaceWordOrTranslation(Dictionary<string, List<string>> dict)
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (!dict.ContainsKey(word))
        {
            Console.WriteLine("Слово не найдено.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("1. Заменить слово");
        Console.WriteLine("2. Заменить перевод");
        Console.Write("Выбор: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Новое слово: ");
            string newWord = Console.ReadLine();
            if (dict.ContainsKey(newWord))
            {
                Console.WriteLine("Такое слово уже есть.");
                Console.ReadKey();
                return;
            }

            dict[newWord] = dict[word];
            dict.Remove(word);
            Console.WriteLine("Слово заменено.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Список переводов:");
            for (int i = 0; i < dict[word].Count; i++)
            {
                Console.WriteLine($"{i + 1}. {dict[word][i]}");
            }

            Console.Write("Выберите номер перевода для замены: ");
            int iChoice = int.Parse(Console.ReadLine()) - 1;
            if (iChoice < 0 || iChoice >= dict[word].Count)
            {
                Console.WriteLine("Неверный выбор.");
                Console.ReadKey();
                return;
            }

            Console.Write("Новый перевод: ");
            string newTranslation = Console.ReadLine();
            dict[word][iChoice] = newTranslation;
            Console.WriteLine("Перевод заменён.");
        }

        Console.ReadKey();
    }

    static void DeleteWordOrTranslation(Dictionary<string, List<string>> dict)
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (!dict.ContainsKey(word))
        {
            Console.WriteLine("Слово не найдено.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("1. Удалить всё слово");
        Console.WriteLine("2. Удалить перевод");
        Console.Write("Выбор: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            dict.Remove(word);
            Console.WriteLine("Слово удалено.");
        }
        else if (choice == "2")
        {
            if (dict[word].Count == 1)
            {
                Console.WriteLine("Нельзя удалить единственный перевод.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Список переводов:");
            for (int i = 0; i < dict[word].Count; i++)
            {
                Console.WriteLine($"{i + 1}. {dict[word][i]}");
            }

            Console.Write("Выберите номер перевода для удаления: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < dict[word].Count)
            {
                dict[word].RemoveAt(index);
                Console.WriteLine("Перевод удалён.");
            }
        }

        Console.ReadKey();
    }

    static void SearchTranslation(Dictionary<string, List<string>> dict)
    {
        Console.Write("Введите слово для поиска: ");
        string word = Console.ReadLine();

        if (dict.ContainsKey(word))
        {
            Console.WriteLine($"Переводы для \"{word}\":");
            foreach (var translation in dict[word])
            {
                Console.WriteLine($"- {translation}");
            }
        }
        else
        {
            Console.WriteLine("Слово не найдено.");
        }

        Console.ReadKey();
    }

    static void ExportWord(Dictionary<string, List<string>> dict)
    {
        Console.Write("Введите слово для экспорта: ");
        string word = Console.ReadLine();

        if (!dict.ContainsKey(word))
        {
            Console.WriteLine("Слово не найдено.");
            Console.ReadKey();
            return;
        }

        Console.Write("Имя файла (без расширения): ");
        string fileName = Console.ReadLine();
        string path = fileName + ".txt";

        File.WriteAllText(path, $"{word}: {string.Join(", ", dict[word])}");
        Console.WriteLine($"Экспортировано в файл {path}");
        Console.ReadKey();
    }
}
