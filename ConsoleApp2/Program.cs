﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts

{   /// <summary>
    /// Bank Account demo class 
    /// </summary>
    public class BankAccount
    {
        private string m_customerName;
        private double m_balance;
        private bool m_frozen = false;
        private BankAccount()
        {

        }
        public BankAccount(String customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        public string CustomerName
        {
            get { return m_customerName; }
        }
        public double Balance
        {
            get { return m_balance; }
        }
        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account Frozen");
            }
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");

            }
            if (amount<0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;//intentionally incorrect code
        }
        public void Credit(double amount)
        {
            if(m_frozen)
            {
                throw new ArgumentOutOfRangeException("Account frozen");
            }
            if (amount<0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
