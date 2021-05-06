using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string _lastname { get; set; }

        public string FullName
        {
            get 
            {
                return $"{FirstName} {LastName}"; //no set because it is not saved anywhere

            }
        }

        public int Age //this is a property (age) with the get expanded
        { 
            get 
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double ageYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(ageYears));
                return yearsOld;
            } 
        }

        public DateTime DateOfBirth { get; set; }

        public Vehicle Transport { get; set; }
    }
}
