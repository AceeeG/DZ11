using System;


namespace Lab
{
    internal class BankTransaction
    {
        private DateTime transaction_time;
        public DateTime Transaction_time
        {
            get 
            { 
                return transaction_time; 
            } 
            set 
            {  
                transaction_time = value; 
            }
        }

        readonly double money;

        internal BankTransaction(double money)
        {
            transaction_time = DateTime.Now;
            this.money = money;
        }
        /// <summary>
        /// Возрвращает строку с инфой о транзакиции
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return ($"{transaction_time} произошла операция на сумму {money} рублей\n");
        }
    }
}
