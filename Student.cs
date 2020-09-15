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
        public string firstName; //Имя
        public string lastName; //Фамилия
        public byte age; //Возраст
        public Contacts contacts;
        public int[] balls = new int[5];
        public double average;
    }
}
