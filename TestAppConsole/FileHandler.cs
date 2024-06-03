using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class FileHandler
    {
        // Static context methods parameters must be static
        public static readonly string myPathRead = "./text";
        public static readonly string myPathWrite = "./textWrite";
        public static void RunCode()
        {
            // static int x = 0;//error, static must be class level

            FileInfo fileInfo = new(myPathRead);
            FileInfo fileInfoWrite = new(myPathWrite);
            using  (StreamReader sr = fileInfo.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            using StreamWriter sw = fileInfoWrite.CreateText();
            try
            {
                sw.WriteLine("I'm Writing");
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
    
}