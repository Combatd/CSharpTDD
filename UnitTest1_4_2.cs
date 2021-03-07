[12:12 PM] Mark Calvelo (Aetrotek)
    
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;
namespace PolymorphismTestProject
{​​​​​
    [TestClass]
    public class UnitTest1
    {​​​​​
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {​​​​​
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 1;
            Employee e = new Employee();
            string expectedResponse = String.Format("This ANGRY EMPLOYEE worked {​​​​​0}​​​​​ hrs. " +
                              "Paid for 40 hrs at $ {​​​​​1}​​​​​" +
                              "/hr = ${​​​​​2}​​​​​", weeklyHours, wage, salary);
            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);

        }​​​​​

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursReturns3850Dollars()
        {​​​​​
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 1;
           Contractor e = new Contractor();
            string expectedResponse = String.Format("This HAPPY CONTRACTOR worked {​​​​​0}​​​​​ hrs. " +
                              "Paid for {​​​​​0}​​​​​ hrs at $ {​​​​​1}​​​​​" +
                              "/hr = ${​​​​​2}​​​​​ ", weeklyHours, wage, salary);
            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);

        }​​​​​

        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursDoesNotReturnCorrectString()
        {​​​​​
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 48 * wage;
            Employee e = new Employee();
            string expectedResponse = String.Format("This ANGRY EMPLOYEE worked {​​​​​0}​​​​​ hrs. " +
                              "Paid for 40 hrs at $ {​​​​​1}​​​​​" +
                              "/hr = ${​​​​​2}​​​​​", weeklyHours, wage, salary);
            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);
        }​​​​​

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursDoesNotReturnCorrectStringr()
        {​​​​​
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor e = new Contractor();
            string expectedResponse = String.Format("This HAPPY CONTRACTOR worked {​​​​​0}​​​​​ hrs. " +
                              "Paid for {​​​​​0}​​​​​ hrs at $ {​​​​​1}​​​​​" +
                              "/hr = ${​​​​​2}​​​​​ ", weeklyHours, wage, salary);
            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);

        }​​​​​

    }​​​​​
}​​​​​

