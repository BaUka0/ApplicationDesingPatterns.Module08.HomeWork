using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public abstract class Beverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        protected void BoilWater()
        {
            Console.WriteLine("Кипятим воду...");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Наливаем в чашку...");
        }
        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем чай...");
        }

        protected override void AddCondiments()
        {
            if(CustomerWantsCondiments())
                Console.WriteLine("Добавляем лимон...");
        }
        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Хотите добавить лимон? (да/нет)");
            string answer = Console.ReadLine();
            return answer.ToLower() == "да";
        }
    }
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе...");
        }

        protected override void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Добавляем сахар и молоко...");
            }
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Хотите добавить сахар и молоко? (да/нет)");
            string answer = Console.ReadLine();
            return answer.ToLower() == "да";
        }
    }
    public class HotChocolate : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Растворяем шоколад в воде...");
        }

        protected override void AddCondiments()
        {
            if(CustomerWantsCondiments())
                Console.WriteLine("Добавляем взбитые сливки...");
        }
        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Хотите добавить взбитые сливки? (да/нет)");
            string answer = Console.ReadLine();
            return answer.ToLower() == "да";
        }
    }
    internal class Template
    {
    }
}
