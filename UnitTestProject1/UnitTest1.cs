using System;
using BankAccounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests

{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]


        public void Debit_withValidAmount_UpdatesBalance()
        {
            //Arrange
            double begginingBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", begginingBalance);

            //Act
            account.Debit(debitAmount);
            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
    {
        //arrange
        double beginingBalance = 11.99;
        double debitAmount = -100.00;
        BankAccount account = new BankAccount("Mr.Bryan Walton", beginingBalance);
    }
}
