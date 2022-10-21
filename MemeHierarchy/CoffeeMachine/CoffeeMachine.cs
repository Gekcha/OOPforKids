using System;
using System.Collections.Generic;
using System.Text;

namespace MemeHierarchy.CoffeeTime
{
    // С помощью этого класса пользователь может купить кофе 
    public class CoffeeMachine
    {
        private int num=-1;
        private bool key=false;

        public CoffeeMachine()
        {
            BuyCoffee();
        }

        public CoffeeMachine(int _num, bool _key)
        {
            num = _num;
            key = _key;
            BuyCoffee();
        }

        private void NumChecker()
        {

            while (num>3 || num < 0)
            {
                Console.WriteLine("Введите номер кофе: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

        }

        private void CoffeeCook()
        {
            Console.WriteLine($"Ваш кофе {num} имеет статус {key}");
        }

        private int InsertMoney()
        {
            int Nal = 0;
            int Sum = 0;
            while (Sum < 60)
            {
                Console.WriteLine("Введите деньги: ");
                Nal = Convert.ToInt32(Console.ReadLine());
                Sum += Nal;
                if (Sum < 60)
                {
                    Console.WriteLine($"Не хватает: {60 - Sum}");
                }
            }
            return Sum;
        }

        private void Payment()
        {
            int Nal;
            Nal = InsertMoney();
            Console.WriteLine($"Ваша сдача: {Nal - 60}");
            key = true;
        }

        private void BuyCoffee()
        {
            NumChecker();
            Payment();
            CoffeeCook();
        }
    }
}
