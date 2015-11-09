using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Filestream_StreamReaderexp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter filename to open");
            string filename = Console.ReadLine();

            FileStream fp = new FileStream(filename, FileMode.Open);
            StreamReader reader = new StreamReader(fp);

            int data;
            while ((data = reader.Read()) != -1)            // -1  is END OF FILE
            {
                Console.Write((char)data);
                Thread.Sleep(50);       // 1000 ms  = 1sec
            }
            reader.Close();
            fp.Close();
        }
    }
}
