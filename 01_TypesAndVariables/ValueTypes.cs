using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true; // initializing the variable
            bool isDeclaredAndInitialized = false; //declare and initialize in one line
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numberCharacer = '7';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShortExample = 32767;
            int intMin = -2147483648;
            int intMax = 214748364;
            long longExample = 9223372036854775807;
            long longMin = -9223372036854775807;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.234987546513254456123f;
            double doubleExample = 1.234987546513254456123d; //decimal is default. D suffix isn't needed
            decimal decimalExample = 1.234987546513254456123m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli}

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherPastry = PastryType.Eclaire;
        }

        [TestMethod]
        public void Struts()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1992, 05, 17);

            TimeSpan age = today - birthday;
            int ageInDays = age.Days;

            Console.WriteLine(ageInDays / 365);
        }
    }
}
