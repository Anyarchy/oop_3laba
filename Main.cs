using System;

namespace OOP_3laba
{

    public class Program
    {
        public static void Out(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Students student = new Students();
            student.AddStudent("Nechai", "Oleg", "Petrovich");
            student.AddStudent("Pupkin", "Vasya", "oleksandrovich");
            student.AddStudent("Kotenko", "Kotya", "Kotyakivna");
            student.AddStudent("Nechai", "Ivan", "Stepanovich");
            student.AddStudent("Filimononenko", "Filimon", "Filimonovich");
            student.AddStudent("My", "disgusting", "Friend");
            student.AddStudent("Be", "Like", "Beach");
            student.AddStudent("Nechai", "Piedro", "Horniovich");
            student.AddStudent("Zubenko", "Michael", "Petrovich");
            student.AddStudent("Zhmyshenko", "Valery", "Albertovich");
            student.Outer();
            Out(student["1"]);
            Console.WriteLine(student.Nechai);
        }
    }
}