using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic6
{
    class Program
    {
        class Animal
        {
            public void Eat() { Console.WriteLine("냠냠"); }
            public virtual void Eat2() { Console.WriteLine("냠냠"); }
        }
        class Cat : Animal
        {
            public new void Eat() { Console.WriteLine("냥냥"); }
            public override void Eat2() { Console.WriteLine("냥냥"); }
        }
        class Dog : Animal
        {
            public new void Eat() { Console.WriteLine("멍멍"); }
            public override void Eat2() { Console.WriteLine("멍멍"); }
        }
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("난 부모 메서드");
            }
            // 메서드는 오버라이드가 불가능하므로 virtual 입력
            public virtual void Method2()
            {
                Console.WriteLine("난 부모 메서드");

            }
        }
        class Child : Parent
        {
            public new string variable = "hiding";
            public new void Method()
            {
                Console.WriteLine("난 자식 메서드");
            }
            public override void Method2()
            {
                Console.WriteLine("난 자식 메서드");
            }
        }

        static void Main(string[] args)
        {
            Child child = new Child();
            //Console.WriteLine(child.variable);
            //Console.WriteLine(((Parent)child).variable);
            child.Method();
            ((Parent)child).Method();

            child.Method();
            ((Parent)child).Method2();

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };
            foreach (var item in Animals) { item.Eat(); }
            foreach (var item in Animals) { item.Eat2(); }
        }
    }
}