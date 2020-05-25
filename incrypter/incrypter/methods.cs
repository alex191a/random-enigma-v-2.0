using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incrypter
{
    class methods
    {
        public static void inhold()
        {
            Console.WriteLine("Hvor vil du gerne have filen gemt?\n Her kommer et exempel på hvordan det skal stå: \n c:\\temp\\MyTest.txt ");
        }
        public static void filecreator( string branch, string information) { 
        try
            {
                ///creates the file
                using (FileStream crypt = File.Create(branch))
                {
                    /// adding stuff to the file we just created
                    byte[] text = new UTF8Encoding(true).GetBytes(information);
                    crypt.Write(text, 0, text.Length);
                }
                /// Opens and reads stream
                using (StreamReader sR = File.OpenText(branch))
                {
                    string eString = "";
                    while((eString = sR.ReadLine()) != null)
                    {
                        Console.WriteLine(eString);
                    }
                }
            }
            catch(Exception example)
            {
                Console.WriteLine(example.ToString());
            }
        }
    }
}
