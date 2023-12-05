using Lab13;
using System;
using System.Reflection;

namespace Lab
{

    internal class Program
    {
        static void DoExercises_Lab13()
        {
            Console.WriteLine("Упражнения 1-3\n");
            BankAccount account = new BankAccount(BankType.Сберегательный, 1000, "name");
            account.DepositMoney(333);
            account.DepositMoney(3332);
            account.DepositMoney(3323);
            Console.WriteLine(account[1].Print());
        }
        static void DoHomework_Lab13()
        {
            Console.WriteLine("Домашние задания 1-2\n");
            BuildingList buildings = new BuildingList();
            buildings.Print();
        }
        static void DoExercise1_Lab14()
        {
            Console.WriteLine("Упражнение 1\n");
            BankAccount account = new BankAccount(BankType.Сберегательный, 10000, "DEBUG_ACCOUNT");
            account.DumpToScreen();
            AttributeCheck.CheckDumpToScreen(account);
        }
        static void DoExercise2_Lab14()
        {
            Console.WriteLine("Упражнение 2\n");

            MemberInfo type = typeof(RationalNumbers);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {
                if (attribute is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute info = (DeveloperInfoAttribute)attribute;
                    Console.WriteLine($"Создатель: {info.Name}, Дата создания: {info.Date}\n");
                }
            }
        }
        static void DoHomework_Lab14()
        {
            Console.WriteLine("Домашнее задание 1\n");
            MemberInfo type = typeof(Building);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {
                if (attribute is DevelopmentBuildingInfoAttribute)
                {
                    DevelopmentBuildingInfoAttribute info = (DevelopmentBuildingInfoAttribute)attribute;
                    Console.WriteLine($"Создатель: {info.Name}, Организация: {info.Organization}\n");
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 13\n"); //Сделал в одном проекте, чтобы класс банка не копировать в новый
            DoExercises_Lab13();
            DoHomework_Lab13();
            Console.WriteLine("Лабораторная 14\n");
            DoExercise1_Lab14();
            DoExercise2_Lab14();
            DoHomework_Lab14();

            Console.ReadKey();
        }
    }
}
