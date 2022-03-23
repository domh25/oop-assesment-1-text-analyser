using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_2
{
    public class Report
    {
        //input error method
        public string input_error()
        {
            Console.WriteLine("input error occured"); //notify user
            Environment.Exit(0); //console closes
            return null;
        }
        //file extension method
        public string file_existion_error()
        {
            Console.WriteLine("file existion error occured"); //notify user
            Environment.Exit(0); //console closes
            return null;
        }

        //
    }
}
