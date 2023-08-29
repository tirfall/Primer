using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer
{
    public class Student
    {
        public string Name { get; set; }
        public int age;
        private readonly string _city;
        public string status;

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                age = value;
                if (Age < 18) status = "alaealine";
                else status = "täiskavanud";
            }
        }
        public string Birthday
        {

        }
        public string Status
        {
            get { return status; }
        }
        public string GetCity()
        {
            return _city;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
        }
    }
}
