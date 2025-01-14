﻿using System;

namespace Student
{
    class Student
    {
        void printName(String firstName, String lastName)
        {
            Console.WriteLine("First Name = { 0}, Last Name = { 1 }", firstName, lastName);
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            /*Passing argument by position*/
            student.printName("Henry","Parker");
            /*Passing named argument*/
            student.printName(firstName: "Henry", lastName: "Parker");
            student.printName(lastName: "Parker", firstName: "Henry");
            /*Passing named argument after positional argument*/
            student.printName("Henry", lastName: "Parker");
        }

    }
}
