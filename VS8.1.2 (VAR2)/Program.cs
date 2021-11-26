using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VS8._1._2__VAR2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "D:/Моя/Могутнова М/мои доки"; 
            // вывоз каталога ВАРИАНТ1

            Console.WriteLine("Каталог:");
            if (Directory.Exists(dirName))
            {
                string[] s2 = Directory.GetDirectories(dirName);
                foreach (string folder in s2)
                {
                    Console.WriteLine("\nПапка:");
                    Console.WriteLine(folder);
                    Console.WriteLine("\nФайл:");
                    var s1 = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
                    foreach (string filename in s1)
                    {
                        Console.WriteLine(filename);
                    }

                }
                string[] allfiles = Directory.GetFiles(dirName);
                Console.WriteLine("\nФайлы:");
                foreach (string filename in allfiles)
                {
                    Console.WriteLine(filename);
                }

            }
            Console.ReadKey();

        }
    }
}
