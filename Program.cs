using System;
using System.Collections.Generic;

namespace Test
{
   public static class CLI
    {
        public static void Welcome()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("* S T U D E N T *");
            Console.WriteLine("*****************");
            Console.WriteLine();
        }

        public static Student InputStudent()
        {
            Console.Write("Введите имя студента - ");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию студента - ");
            string lastName = Console.ReadLine();
            Console.Write("Введите дату рождения студента - ");
            DateTime birthDay;
            DateTime.TryParse(Console.ReadLine(), out birthDay);

            Console.Write("Введите телефон студента - ");
            string tel = Console.ReadLine();

            Console.Write("Введите адрес студента - ");
            string address = Console.ReadLine();

            Console.Write("Введите Y если необходимо ввести оценки - ");
           string yesNo = Console.ReadLine();
            List<byte> balls = new List<byte>();
            while (yesNo == "Y" || yesNo == "y")
            {
                Console.Write("Введите оценку студента - ");
                byte ball = Convert.ToByte(Console.ReadLine());
                balls.Add(ball);

                Console.Write("Введите Y если необходимо продолжить ввод - ");
                yesNo = Console.ReadLine();
            }

            Student student = new Student(firstName, lastName, birthDay);
            student.contacts.address = address;
            student.contacts.Tel = tel;

            return student;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CLI.Welcome();

            Student student = CLI.InputStudent();
        }
    }
}


/*Student student = new Student("Andrey", "Statinin", new DateTime(1986, 2, 18));
student.contacts.Tel = "+79042144491";
student.contacts.address = "Voronezh";*/
