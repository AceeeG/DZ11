using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{

    internal class Program
    {
        static void DoExercises()
        {
            Console.WriteLine("Упражнения 1-3\n");
            BankAccount account = new BankAccount(BankType.Сберегательный, 1000, "name");
            account.DepositMoney(333);
            account.DepositMoney(3332);
            account.DepositMoney(3323);
            Console.WriteLine(account[1].Print());
        }
        static void DoHomework()
        {
            Console.WriteLine("Домашние задания 1-2\n");
            BuildingList buildings = new BuildingList();
            buildings.Print();
        }
        static void Main(string[] args)
        {
            DoExercises();
            DoHomework();
            Console.ReadKey();
        }
    }
}
