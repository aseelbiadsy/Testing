using BankAccount;
namespace BankAccount;


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         public void TestMethod1()
        {
            double expected = 3400;
            // Arrange
            string accountName = "John Smith";
            double balance = 1000;
            BankAccount b = new BankAccount(balance, accountName);
                  // b.Add(2400);
             b.Remove(200);
            Assert.AreEqual(expected, b.GetBalance());
        }
    }
