using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace filestream_streamwriterexp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\chakrapani\Documents\" + DateTime.Now.Day + ".txt";
            FileStream fp = new FileStream(filename, FileMode.Append);
            StreamWriter writer = new StreamWriter(fp);
            Console.WriteLine(DateTime.Now.Day);
            while (true)
            {
                Console.WriteLine("1.Attendance");
                Console.WriteLine("2.Exit");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: Console.WriteLine("enter empno");
                        string empno = Console.ReadLine();
                        writer.WriteLine(empno + "," + DateTime.Now.ToString());
                        break;
                    case 2: writer.Close();
                            fp.Close();
                            return;

                }
            }
            
        }
    }
}
