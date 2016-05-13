using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SearchText
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = "D:\\1 семестр"; //The root directory to check
            Search(path); //Function that will be used(described bellow)
        }
        static void Search(String path)
        {
            Queue<string> dirs = new Queue<string>(20);
            dirs.Enqueue(path); //Put the directory into the Queue
            while (dirs.Count > 0) //Until there are items in the Queue  do:
            {
                DirectoryInfo dir = new DirectoryInfo(dirs.Dequeue()); //
                int cnt = dir.GetFiles().Length; //Count how many files in the directory
                Console.WriteLine(cnt + " files are located in " + dir.FullName); //show the number of the files 
                int cn = 0; //counter of the subdirectories
                foreach (DirectoryInfo ndir in dir.GetDirectories()) //ndir is Subdirectory
                {
                    cn++; //counter is increased
                    Console.WriteLine(cn + "." + ndir.Name); //Names of the subdirectories
                    dirs.Enqueue(ndir.FullName); //put the subdirectory in the stack
                }

                Console.ReadKey(); //Next information will be given only after you press the button
            }
        }
    }
}