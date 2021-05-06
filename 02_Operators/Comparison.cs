using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Jacob";

            bool isEqual = age == 41; // the value of isEqual depends on the comparison in the ()

            bool userIsMichael = userName == "Michael";

            Console.WriteLine(userIsMichael);
            Console.WriteLine(isEqual);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);


            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = (firstList == secondList);
            Console.WriteLine(listsAreEqual);

            bool isGreaterThan = age > 36;
            Console.WriteLine(isGreaterThan);

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan);
        }
    }
}
