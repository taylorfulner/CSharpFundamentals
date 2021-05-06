using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);

        }

        [TestMethod]
        public void VehicleCreatedTests()
        {
            Indicator thirdVehicle = new Indicator();
            thirdVehicle.TurnOn();
            Console.WriteLine(thirdVehicle.IsFlashing);
        }


        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 100000, VehicleType.Plane);
            Console.WriteLine($"I rode on a spaceship, it was the {rocket.Make}");
        }


        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Brad");

            List<string> students = new List<string>();
            students.Add("Hannah");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach (string student in students)
            {
                greeterInstance.SayHello(student);
            }


            string greeting = greeterInstance.GetRandomGreeting();
            greeterInstance.SaySomething(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator answer = new Calculator();

            int answerInt = answer.Value("16");
            Console.WriteLine(answerInt);

            //int age = calulatorInstance.CalculateAge(new DateTime(1992, 05, 17));
            //Console.WriteLine(age);


        }

        [TestMethod]
        //Person
        public void PersonTests()
        {
            Person person = new Person("Taylor", "Fulner", new DateTime (1992, 05, 17));
            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.Age);

            double myNum = 3.09d;
            decimal myDecimal = (decimal)myNum;
            Console.WriteLine(myDecimal);
        }

        [TestMethod]
        public void LargerOutput()
        {
            double a = 5;
            double b = 10;

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

        }
    }
}
