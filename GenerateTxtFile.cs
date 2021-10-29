using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generateLargeFiles
{
    class GenerateTxtFile
    {
        string[] barcodeLines;
        public void readFromFile(int count) 
        {
            try
            {
                barcodeLines = new string[count];
                barcodeLines = System.IO.File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "entryLines.txt"));
                //foreach (string line in barcodeLines) 
                //{
                //    Console.WriteLine(line);
                //}
                
            }
            catch (Exception e)
            {
                Console.WriteLine("shit");
            }
        }

        public void writeToFile(string name, int count) 
        {
            Console.WriteLine("Generating .txt File " + name + ".txt");
            
            string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),  "testDataCount.txt");

            if (!File.Exists(file))
            {
                File.Create(file);
                Console.WriteLine("File Location:\t" + file);
            }
            if (File.Exists(file))
            {

                using (var tw = new StreamWriter(file, true))
                {
                    //Console.WriteLine(@"Writing to file location: C:\Users\fcasanova\AppData\Roaming\" + name + ".txt");
                    foreach (string lines in barcodeLines)
                    {
                        tw.WriteLine("1001891773460001120100282863789006<0x09>" + lines + "<0x0D>" + " | 10/19/2021 5:12:00 PM");
                    }
                }
            }
            else
            {
                Console.WriteLine("File Location does not exist:\t" + file);
            }
        }

    }
}
