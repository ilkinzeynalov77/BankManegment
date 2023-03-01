using System;

namespace BankManegment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount(200,"Ilkin");
            bankAccount.StartOperation();
        }
    }

}