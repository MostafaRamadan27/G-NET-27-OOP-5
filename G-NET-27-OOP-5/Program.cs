using System.Runtime.InteropServices;

namespace G_NET_27_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1
            // interface is Contract that class must follow , it specifies what class can do no what how does it , because tight coupling and hard to test , hard to change
            // 1-enable multiable inheritance
            // 2- enable polymorphism without inheritance
            // 3- remove tight coupling between classes  

            #endregion

            #region Q2
            // A) IEnglishSpeaker and IArabicSpeaker exact same thing we cant give them different brhavior 
            // print same result in both cases
            // B) Explicit implementation 
            //C) yes can call Translator.Greet() we call each version by Cast interface first 
            //like Translator translator = new Translator();
            //IEnglishSpeaker englishSpeaker = translator;
            // englishSpeaker.Greet(); // Calls IEnglishSpeaker's Greet method
            // IArabicSpeaker arabicSpeaker = translator;
            // arabicSpeaker.Greet(); // Calls IArabicSpeaker's Greet method
            #endregion
            #endregion
        }
    }
}
