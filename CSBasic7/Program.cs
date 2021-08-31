﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Wanted<T>
        // where T : Student
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class Student
    {
        public override string ToString()
        {
            return "학생";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> ws = new Wanted<string>("String");
            Wanted<int> wi = new Wanted<int>(42);
            Wanted<Student> wstu = new Wanted<Student>(new Student());

            Console.WriteLine(ws);
            Console.WriteLine(wi);
            Console.WriteLine(wstu);
        }
    }
}
