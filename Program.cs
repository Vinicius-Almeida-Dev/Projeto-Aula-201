using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Projeto_Aula_201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Windows\Temp\soucerFile.csv";
            string targetFolder = @"C:\É-O-VINI-AMIGO";

            try
            {
                Directory.CreateDirectory($"{targetFolder}");


                using (StreamWriter sw = File.AppendText($@"{targetFolder}\Summary.txt"))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        string laEle = $@" lá ele {i} -  lá ele {i} - lá ele {i} -  lá ele {i}";
                        sw.WriteLine(laEle.ToUpper());

                        Console.WriteLine("Caiu no bait BB");
                    }
                }

                Console.ReadLine();

            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
