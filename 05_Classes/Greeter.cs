using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {
        //1 access modifier
        //2 return type
        //3 method signature - include method name and any parameters
        //4 body of the method - code that gets executed when the method is called

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random randy = new Random();
            string[] greetings = new string[] { "hello", "hi", "sup", "yo", "hey" };
            int RandomNumber = randy.Next(0, greetings.Length);
            string greeting = greetings[RandomNumber];
            return greeting;
        }
    }
}
