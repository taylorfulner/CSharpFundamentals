﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                case 56:
                case 13: //shows the case can be 1 OR 56 OR 13
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("World");
                    break;
                case 55:
                    Console.WriteLine("Huh");
                    break;
                default:
                    Console.WriteLine("What are you doing?");
                    break;
            }
        }
    }
}
