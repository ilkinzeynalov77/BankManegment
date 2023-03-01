using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManegment
{
    public class BankAccount
    {
        private double Money = 0;
        private readonly string Name;

        public BankAccount(double money, string name)
        {
            this.Money = money;
            this.Name = name;
        }

        public void StartOperation()
        {
            Print();
            while (true)
            {
                Console.Write("\nSeciminizi daxil edin : ");
                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":
                        Console.Write("Meblegi daxil edin : ");
                        int addMoney = int.Parse(Console.ReadLine());
                        AddMoney(addMoney);
                        break;
                    case "2":
                        Console.Write("Meblegi daxil edin : ");
                        addMoney = int.Parse(Console.ReadLine());
                        Subtract(addMoney);
                        break;
                    case "3":
                        getInfo();
                        break;
                    default:
                        Console.WriteLine("Xahis edirik secimi duzgun daxil edin!");
                        break;
                } if(enter == "4")
                {
                    break;
                }
            }
            
            
        }
        public void Print()
        {
            Console.WriteLine("1. Hesabinizi pul elave etmek ");
            Console.WriteLine("2. Hesabinizdan cixaris etmek ");
            Console.WriteLine("3. Hesab melumatlarini gormek ");
            Console.WriteLine("4. Emeliyyati sonlandirmaq ucun ");
        }
        public void AddMoney(double money)
        {
            Console.WriteLine($"{money} AZN sizin hesabiniza elave edildi");
            this.Money += money;
        }
        public void Subtract(double money)
        {
            Console.WriteLine($"{money} AZN sizin hesabiniza cixarildi");
            this.Money -= money;
        }
        public void getInfo()
        {
            Console.WriteLine("Hesab melumatlari");
            Console.WriteLine($"{Name} + {Money}");
        }
    }
}
