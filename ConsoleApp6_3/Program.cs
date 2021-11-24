using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Введите строку, включающую слова в фигурных скобках");
            string str1 = Console.ReadLine();
            int open = 0;
            int close = 0;
            int i = 0;
            while ((str1.IndexOf('{') != -1 || str1.IndexOf('}') != -1) & (i + 1) < str1.Length)
            {
                if (str1[i] == '{')
                {
                    open++;
                    for (int j = i + 1; j < str1.Length; j++)
                    {
                        if (str1[j] == '}')
                        {
                            close++;
                            if (close == open)
                            {
                                str1 = str1.Remove(i, j - i + 1);
                                i = 0;
                                j = 0;
                                open = 0;
                                close = 0;
                                break;
                            }
                        }
                        else if (str1[j] == '{')
                        {
                            open++;
                        }
                    }
                }
                if (i > str1.Length)
                {
                    break; // аварийно завершаем
                }
                i++;
            }

            Console.WriteLine("Результат: " + str1);
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}