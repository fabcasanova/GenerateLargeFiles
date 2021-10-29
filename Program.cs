using System;

namespace generateLargeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to File Generator\n");
            //Console.Write("File Name:\t");
            try 
            {
                string name = Console.ReadLine();

                Console.Write("How many Lines of Code do you need? : \t");
                int count = Console.Read();

                GenerateTxtFile gen = new GenerateTxtFile();
                gen.readFromFile(count);
                gen.writeToFile(name, count);
            } 
            catch (Exception e) 
            {
                Console.WriteLine("Invalid Input \n" + e);
            }
            
        }
    }
}
