using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop_assigment_2
{
    public class Input
    {
        public string text = "nothing"; //
        Report report = new Report(); //report object created from report class

        //user enters text from keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Please enter sentances you would like to enter, please use a * for end of log");
            text = Console.ReadLine(); //user input stored as text varible
            Console.WriteLine("\n" + text + "\n");
            return text; //text varible returned
        }

        //text accesed from a text file
        public string fileTextInput(string fileName)
        {
            //file directory called filename
            string filename = @"C:\Users\pc\Documents\c# uni\oop_assigment_2\oop_assigment_2\" + fileName + ".txt";
            
            //error handling checking if file exists
            if (File.Exists(filename))
            {
                //contents of file added text varible
                text = System.IO.File.ReadAllText(filename); 
                Console.WriteLine("\n" + text + "\n");
            }
            //if file does not exist file_extension_error method
            //is called from report class
            if (!File.Exists(filename))
            {
                report.file_existion_error();
            }
            return text; //text varible is retutned
        }

    }
}
