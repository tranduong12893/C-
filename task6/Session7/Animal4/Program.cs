﻿using System;

namespace Animal4
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        protected void DoSomething()
        {
            Console.WriteLine("Every animal does something");
        }
    }
    class Cat : Animal
    {
        //Class Cat overrides Eat() method of class Animal
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }
        static void Main(String[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
        }

    }
