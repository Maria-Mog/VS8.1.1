using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VS8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //рассчитывает сумму 10 рандомных чисел 
            string path = "Logs/log.txt"; //запись файла в папку
            using (StreamWriter sw = new StreamWriter(path))
            {
                double[] array = new double[10];
                Random random = new Random();                
                for (int i = 0; i < array.Length; i++)
                {
                    double v = random.Next(-20,20);
                    sw.WriteLine(v);
                }
                
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            string[] vs = File.ReadAllLines(path);
            double sum = 0;
            foreach (string i in vs)
            {
                sum += Convert.ToInt32(i);
            }
            Console.WriteLine("\nСумма чисел равна {0}",sum);            
            Console.ReadKey();
        }
    }
}
