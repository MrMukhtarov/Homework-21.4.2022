using System;
using System.Collections.Generic;
using System.Text;

namespace Homework21._4._2022.Models
{
    class Student
    {
        public string FullName { get; set; }
        public byte Age { get; set; }

        private string _groupNo;

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Duzgun daxil edin");
                    value = Console.ReadLine();
                    break;
                }
                _groupNo = value;
            }
        }
        public Student(string groupno, byte age , string fullname)
        {
            GroupNo = groupno;
            Age = age;
            FullName = fullname;
        }

        static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length >= 4)
            {
                bool isupper = false;
                bool isdigit1 = false;
                bool isdigit2 = false;
                bool isdigit3 = false;

                foreach (var item in groupNo)
                {
                    if (char.IsUpper(groupNo[0]))
                    {
                        isupper = true;
                    }
                    else if (char.IsDigit(groupNo[1]))
                    {
                        isdigit1 = false;
                    }
                    else if (char.IsDigit(groupNo[2]))
                    {
                        isdigit2 = false;
                    }
                    else if (char.IsDigit(groupNo[3]))
                    {
                        isdigit3 = false;
                    }
                    if (isupper && isdigit1 && isdigit2 && isdigit3)
                    {
                        return true;
                    }
                }
                if (isupper || isdigit1 || isdigit2 || isdigit3)
                {
                    return false;
                }
            }
            return false;
        }
        //static bool CheckFullName(string fullName)
        //{

        //}
    }
}
