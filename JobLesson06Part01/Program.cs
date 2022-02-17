using System;
using System.Diagnostics;

namespace JobLesson06Part01
{
    internal class Program
    {
        static int Main(string[] args)
        {
            //Написать консольное приложение Task Manager,
            //которое выводит на экран запущенные процессы и
            //позволяет завершить указанный процесс.
            //Предусмотреть возможность завершения процессов с помощью указания его ID
            //или имени процесса. 
            //В качестве примера можно использовать консольные утилиты
            //Windows tasklist и taskkill.




            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; i++)
            {
                Process current = processes[i];
                Console.WriteLine($"{current.ProcessName}, ID Процесса:{current.Id}");
            }
            Console.WriteLine("Введите Имя процесса который нужно завершить -");
            string killProcess = Console.ReadLine();
            for (int i = 0; i < processes.Length; i++)
            {
                Process current = processes[i];
                if (current.ProcessName == killProcess)
                {
                    current.Kill();
                    Console.WriteLine($"Процесс -{current.ProcessName} был завершен");
                }
            }
            return 0;

        }

    }
}
