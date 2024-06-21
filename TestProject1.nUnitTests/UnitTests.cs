using LaptopDiscount;

namespace TestProject1.nUnitTests
{
    public class Tests
    {
        // private EmployeeDiscount object
        private EmployeeDiscount _employeeDiscount;
        [SetUp]
        public void Setup()
        {
            // init the object
            _employeeDiscount = new EmployeeDiscount();
        }

        // test for the discount of parttime employee type
        // test case for the price of 300, the price is the minimum boundary of the laptop search
        [TestCase(300)]
        // test case for the price of 301, the price just above the lowest boundary of the laptop search
        [TestCase(301)]
        // test case for the price of 999, the price just below the highest boundary of the laptop search
        [TestCase(999)]
        public void PartTimeEmployeeTest(int price)
        {
            // Assign, set the employee type to PartTime
            _employeeDiscount.EmployeeType = EmployeeType.PartTime;
            // Assign, set the price accordingly
            _employeeDiscount.Price = price;
            // Assert, check if the discounted price is equal to price, which is no discount
            Assert.AreEqual(price, _employeeDiscount.CalculateDiscountedPrice());
        }

        // test for the discount of PartialLoad employee types
        [Test]
        public void PartialLoadEmployeeTest()
        {
            // Assign, set the employee type to PartialLoad
            _employeeDiscount.EmployeeType = EmployeeType.PartialLoad;
            // Assign, set the price to 1000
            _employeeDiscount.Price = 1000;
            // Assert, check if the discount is 5 %, which is 950
            Assert.AreEqual(950, _employeeDiscount.CalculateDiscountedPrice());
        }

        // test for the discount of FullTime employee types
        [Test]
        public void FullTimeEmployeeTest()
        {
            // Assign, set the employee type to FullTime
            _employeeDiscount.EmployeeType = EmployeeType.FullTime;
            // Assign, set the price to 1000
            _employeeDiscount.Price = 1000;
            // Assert, check if the discount is 10 %, which is 900
            Assert.AreEqual(900, _employeeDiscount.CalculateDiscountedPrice());
        }

        // test for the discount of CompanyPurchasing employee types
        [Test]
        public void CompanyPurchasingEmployeeTest()
        {
            // Assign, set the employee type to CompanyPurchasing
            _employeeDiscount.EmployeeType = EmployeeType.CompanyPurchasing;
            // Assign, set the price to 1000
            _employeeDiscount.Price = 1000;
            // Assert, check if the discount is 20%, which is 800
            Assert.AreEqual(800, _employeeDiscount.CalculateDiscountedPrice());
        }
    }
}