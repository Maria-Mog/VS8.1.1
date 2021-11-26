using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VS8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/log2.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            //tring[] text = File.ReadAllLines(path);

            string[] textArray = path.Split();
            Console.WriteLine(textArray.Length);
            //foreach (string i in textArray)
            //{
            //    Console.WriteLine(i.Length);
            //}

            //using (StreamReader sr = File.OpenText(path))
            //{
            //    while (true)
            //    {

            //    }
            //    string[] textArray = sr.
            //    //Console.WriteLine(sr.ReadToEnd());
            //}


            ////using (StreamReader sr = new StreamReader(path))
            ////{
            ////    Console.WriteLine(sr.ReadToEnd());
            ////}

            ////string[] text = File.ReadAllLines(path);
            //string text = Console.ReadLine();
            //string[] textArray = text.Split();
            //string rezultString = "";
            //foreach (string s in textArray)
            //{
            //    rezultString += s.Substring(0, 1).ToUpper() + s.Substring(1) + ' '; //(0,1) -  с нулевого индекса взять один символ

            //}
            //Console.WriteLine(text.Length);
            Console.ReadKey();
        }
    }
}
