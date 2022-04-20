using Homework21._4._2022.Models;
using System;

namespace Homework21._4._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("groupno daxil et");
            string a = Console.ReadLine();
            Console.WriteLine("Yasinizi daxil edin");
            string b = Console.ReadLine();
            byte.TryParse(b, out byte d);
            Console.WriteLine("Ad Soyadinizi daxil edin");
            string c = Console.ReadLine();
            Student student = new Student(a,d,c);
            
            
        }
    }
}
