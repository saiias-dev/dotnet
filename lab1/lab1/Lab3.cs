using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class Lab3
    {
        public static void Main()
        {
            //Random random = new Random();
            //int numberOfRows = random.Next(3, 6);
            //string[][] jaggedArray = new string[numberOfRows][];

            //for (int i = 0; i < numberOfRows; i++)
            //{
            //    int length = random.Next(3, 11);
            //    jaggedArray[i] = GenerateRandomString(length);
            //}

            //string filePath = "output.txt";
            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    foreach (var row in jaggedArray)
            //    {
            //        writer.WriteLine(string.Join("", row));
            //    }
            //}

            //Console.WriteLine($"Файл записан в: {filePath}");

            //if (File.Exists(filePath))
            //{
            //    string[] lines = File.ReadAllLines(filePath);
            //    foreach (var line in lines)
            //    {
            //        int count = CountCharacter(line, 's');
            //        Console.Write(count + ", ");
            //    }
            //}


            //string filePath = "C:\\Users\\s05ma\\source\\repos\\lab1\\lab1\\Tasks\\Task1.txt";
            //string newFilePath = "Task1_new.txt";

            //string text;
            //using (StreamReader reader = new StreamReader(sourceFilePath, Encoding.GetEncoding(866)))
            //{
            //    text = reader.ReadToEnd();
            //}

            //using (StreamWriter writer = new StreamWriter(newFilePath, false, Encoding.UTF8))
            //{
            //    writer.Write(text);
            //}

            //Console.WriteLine("Файл успешно сохранен с кодировкой UTF-8.");

            //string filePath = @"C:\Users\s05ma\source\repos\lab1\lab1\Tasks\Task2.txt";
            //string text;
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    text = reader.ReadToEnd();
            //}

            //string newText = text.Replace("объект", "класс");

            //Console.WriteLine(newText);


            //string filePath = @"C:\Users\s05ma\source\repos\lab1\lab1\Tasks\Task2.txt";
            //string text;
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    text = reader.ReadToEnd();
            //}

            //String[] words = text.Split(' ');
            //int counter = 0;
            //foreach (var word in words) 
            //{
            //    counter++;

            //}
            //Console.WriteLine(text);
            //Console.WriteLine("Количество слов: "+counter);
            ////for (int i = 0; i < words.Length; i++)
            ////{
            ////    Console.WriteLine(words[i]);
            ////}
            ///

            string path = @"C:\Program Files";
            try
            {
                string[] dir = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                foreach (string directory in dir)
                {
                    Console.WriteLine(Path.GetFileName(directory));
                }
                foreach (string file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error");
            }
        }


        //private static string[] GenerateRandomString(int length)
        //{
        //    const string chars = "stuvw";
        //    string[] stringChars = new string[length];

        //    Random random = new Random();
        //    for (int i = 0; i < length; i++)
        //    {
        //        stringChars[i] = chars[random.Next(chars.Length)].ToString();
        //    }

        //    return stringChars;
        //}

        //private static int CountCharacter(string lines, char symbol)
        //{
        //    int count = 0;
        //    foreach (char ch in lines)
        //    {
        //        if (ch == symbol) count++;
        //    }
        //    return count;
        //}     
    }
}
