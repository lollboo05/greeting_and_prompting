using System;
using System.Media;

namespace Greeting_and_prompting
{
    public class greet_voice
    {

        //start of class


        //auto path
        string path = AppDomain.CurrentDomain.BaseDirectory;


        public greet_voice()
        {//start of constructor




            //call the voice method
            voice();


        }//end of constructor

        //method to voice greet the user
        private void voice()
        {//start of method voice

            //get the full path replace of debug\bin\
            string fullpath = path.Replace(@"bin\Debug\", "");


            //play the sound
            string joined_path = fullpath + "greet.wav";
            //create an instance for the soundplayer class
            SoundPlayer voice_play = new SoundPlayer(joined_path);
            //load the audio
            voice_play.Load();
            //play till the end
            voice_play.PlaySync();
        }
    }
}