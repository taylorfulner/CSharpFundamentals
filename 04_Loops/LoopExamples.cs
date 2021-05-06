using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);

                total = total + 1; //3 dots suggest a more efficent way to do something.
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                if(someCount <= 100)
                {
                    Console.WriteLine(someCount);
                    someCount++; //same as someCount = someCount + 1
                }
                else
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod] //shortcut to get here is testm tab tab
        public void ForLoops()
        {
            int studentCount = 28;

            //for loop rules: 
            //1 set variable and start value.
            //2 set condition
            //3 what to do after each loop

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Aaron", "Alexandro", "Andrew", "Ben", "Chris" };

            //for each string (student), in our collection (students), we want the console to write
            //the student name and the text after. This will loop through each student

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in this class");
            }

            string myName = "Taylor Leeann Fulner";

            foreach (char letter in myName)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator++;
            }
            while (iterator < 5);
        }
    }
}
