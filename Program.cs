namespace oop_assigment_2
{
    public class Program
    {
        // main (centre of entire project)
        static void Main()
        {
            int answer; //answer to which option is chosen

            //objects created from other classes
            Report report = new Report(); //report class
            Input input = new Input(); // input class
            long_words long_word = new long_words(); //long word class
            Analyse analyse = new Analyse(); //analyse class

            //question asked for which option to choose
            Console.WriteLine("1. Do you want to enter the text via the keyboard?\n2. Do you want to read in the text from a file?\nEnter option");
            answer = Convert.ToInt32(Console.ReadLine());

            //option 1
            if (answer == 1)
            {
                Console.WriteLine("you entered option 1");
                input.manualTextInput(); //manual input method called from input class
            }

            //option 2
            if (answer == 2)
            {
                Console.WriteLine("you entered option 2");
                Console.WriteLine("Please enter the name of the .txt file you would like to access");
                string fileName = Console.ReadLine(); //filename stored as fileName
                input.fileTextInput(fileName); //text file input method called from input class
            }

            //error handling if muber is out of option range
            if(answer > 2)
            {
                Console.WriteLine("wrong");
                report.input_error(); //method input error is called from report class
            }
            //
                       
            analyse.analyseText(input.text); //text is sent from input class to analyse class to be analysed and output results from analysis
            analyse.long_words_analyse(input.text); //text now sent to look for long words and are outputted to longWords text file
            long_word.long_words_working(); //output message to user to notifiy them of long words working

        }
    }
}

