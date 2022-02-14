using System;
using System.IO;

namespace JobLesson06Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string log = string.Empty; // пустая строка - ""
            log += $"Начало работы приложения";
            try
            {
                int x = 10;
                int y = x / 0;
                log += $"{Environment.NewLine}Результат деления: {y}";
            }
            catch
            {
                log += $"{Environment.NewLine}Во время выполнения деления произошла ошибка";
            }
            finally
            {
                File.WriteAllText("log.txt", log);
            }
        }
    }
}
