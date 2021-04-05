using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3laba
{
    class Students
    {
        private int sizeOfTable;
        private string[,] students;
        private int nechai;

        public Students()
        {
            string[,] temp = new string[0, 3];
            students = temp;
            sizeOfTable = 0;
            nechai = 0;
        }


        public void AddStudent(string Surname, string Name, string FathersName)
        {
            sizeOfTable++;
            string[,] temp = new string[sizeOfTable, 3];
            for (int i = 0; i < sizeOfTable - 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp[i, j] = students[i, j];
                }
            }
            temp[sizeOfTable - 1, 0] = Surname;
            temp[sizeOfTable - 1, 1] = Name;
            temp[sizeOfTable - 1, 2] = FathersName;
            students = temp;
            if (Surname == "Nechai")
            {
                nechai++;
            }
        }

        public void Outer()
        {
            for (int i = 0; i < sizeOfTable; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(students[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public string[] this[string index]
        {
            get
            {
                string[] column = new string[sizeOfTable];
                if (Int32.Parse(index) >= 1 || Int32.Parse(index) <= 3)
                {
                    for (int i = 0; i < sizeOfTable; i++)
                    {
                        column[i] = students[i, Int32.Parse(index) - 1];
                    }
                }
                return column;
            }
        }

        public int Nechai
        {
            get
            {
                return nechai;
            }
        }
    }

}
