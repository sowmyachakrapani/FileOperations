using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Filestream_streamreader_writer_exp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream src = null;

            try
            {

                #region Read from the source file
                Console.WriteLine("Enter source filename");
                string filename = Console.ReadLine();

                src = new FileStream(filename, FileMode.Open);
                StreamReader reader = new StreamReader(src);

                string content = reader.ReadToEnd();  // read complete file content
                src.Close();
                #endregion

                #region Accept word to find and replace , use string function to replace
                Console.WriteLine("Enter word to find");
                string find = Console.ReadLine();
                Console.WriteLine("Enter word to replace");
                string repl = Console.ReadLine();
                content = content.Replace(find, repl);
                #endregion

                #region Store resultant string
                src = new FileStream(filename, FileMode.Create);
                StreamWriter writer = new StreamWriter(src);
                writer.WriteLine(content);  // store replaced content
                writer.Close();
                src.Close();
                #endregion

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Source file not found");
                return;
            }

        }
    }
}
