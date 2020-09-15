using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Contacts
    {
        public string Tel { set; get; }
        public string address;
    }
    public class Student
    {
        public readonly string firstName; //Имя
        public readonly string lastName; //Фамилия
        public readonly DateTime birthDay;
        public byte Age { get; private set; } //Возраст
        public Contacts contacts;
        public List<byte> balls;
        public double Average { get; private set; }

        //public Student() { }
        public Student(string firstName, string lastName, DateTime birthDay)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDay = birthDay;
            balls = new List<byte>();
        }

        public double AverageCalc ()
        {
            int sum = 0;
            for (int i=0; i < 5; i++)
            {
                sum += balls[i];
            }
            Average = sum / 5;
            return Average;
        }
        public byte AgeCalc() { return 20; }
    }
}
