using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please chose the language");
            Console.WriteLine("1. Azerbaijani \n 2.russian \n 3. china");
            int command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                    Console.WriteLine("Gire bileceyiniz formatlar: '.jpg' '.txt' '.pdf'");

                    goto TryAgain;
                case 2:
                    Console.WriteLine("Форматы, которые можно ввести:  '.jpg' '.txt' '.pdf'");
                    goto TryAgain;
                case 3:
                    Console.WriteLine("可以输入的格式： '.jpg' '.txt' '.pdf'");
                    goto TryAgain;
                default:
                    break;
            }
        TryAgain:
            Console.WriteLine("fayli girin");
            MyDocument doc = new MyDocument(Console.ReadLine(), ".jpg", ".txt", ".pdf");
            Console.WriteLine("Tekrar yazarag fayli sisteme elave edin");
            Console.WriteLine(doc.IsChekerextation(Console.ReadLine()));
            Console.WriteLine("Faylin adin daxil edin");
            Console.WriteLine(doc.ReturnExtation(Console.ReadLine()));


        }
        class MyDocument
        {
            private string[] _extations;
            private string _filename;

            public MyDocument(params string[] extation)
            {
                _extations = extation;
            }
            public MyDocument(string filename, params string[] extation)
            {
                _filename = filename;
                _extations = extation;

            }
            public string IsChekerextation(string text)
            {
                string Newtext = "";
                for (int i = 0; i < text.Length; i++)
                {



                    if (text[i] == '.')
                    {
                        for (int j = i; j < text.Length; j++)
                        {
                            Newtext += text[j];
                        }
                    }

                }
                foreach (string ext in _extations)
                {
                    if (ext == Newtext)
                    {
                        return "Sisteme elave olundu :)";
                    }
                }
                return "Xaiw olunur yazilan formatda daxil edin :(";
            }
            public string ReturnExtation(string name)
            {
                string filename = _filename;
                string targetname = "";
                for (int i = 0; i < filename.Length; i++)
                {
                    if (filename[i] == '.')
                    {
                        for (int j = i; j > filename.Length; j--)
                        {
                            targetname += filename[j];
                        }
                    }

                }
                return filename;
            }



        }
    }

}
