using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_and_prompting
{
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //under the voice instant 
            new logo() { };



            //creating an instance for the greet_voice class
            //class with constructor
            new greet_voice();

            //creating an instance for a class greet_and_name
            //with an object name greeting_and_name
            greet_and_name greeting_and_name = new greet_and_name();

            //calling the welcome method
            greeting_and_name.welcome();

            //calling the ask_name
            greeting_and_name.ask_name();

            //calling the chat method
            greeting_and_name.chat();



        }//end of main
    }
}
