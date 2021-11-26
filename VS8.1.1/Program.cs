using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VS8._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // вывоз каталога ВАРИАНТ1
            string dirName = "D:/Моя/Могутнова М/мои доки";

            if (Directory.Exists(dirName))
            {
                string ss = "*.*";
                DirectoryInfo di = new DirectoryInfo(dirName);
                DirectoryInfo[] directories = di.GetDirectories(ss, SearchOption.AllDirectories);
                FileInfo[] files = di.GetFiles();
                Console.WriteLine("Каталог:");                
                foreach (DirectoryInfo s in directories)
                {
                    Console.WriteLine("\nПапка:");
                    Console.WriteLine(s.Name);
                    Console.WriteLine("\nФайлы:");
                    string sub = s.FullName;
                    DirectoryInfo nemeSub = new DirectoryInfo(sub);
                    FileInfo[] file = nemeSub.GetFiles(ss, SearchOption.AllDirectories);
                    foreach (FileInfo i in file)
                    {
                        Console.WriteLine(i.Name);
                    }                    
                }
                Console.WriteLine("\nФайлы:");
                foreach (FileInfo i in files)
                {
                    Console.WriteLine(i.Name);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
