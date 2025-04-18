using ExampleNUnitConsoleApp;               // Imports NUnit testing framework
using NUnit.Framework.Legacy;               // Imports the project namespace

namespace ExampleNUnitConsoleApp.Test;

[TestFixture]                               // Marks the class as containing NUnit test methods
public class CalculatorTest
{
    private Calculator calculator;          // Declares the Calculator instance
    
    [SetUp]                                 // Initialing resources before each test method
    public void Setup()
    {
        calculator = new Calculator();      // Creates a new Calculator instance
    }

    [TestCase(3, 5, 8)]                                  // Specifies a test case where 3 + 5 should equal 8
    [TestCase(10, 2, 12)]                                  // Specifies a test case where 10 + 2 should equal 12
    [TestCase(-1, 1, 0)]                                  // Specifies a test case where -1 + 1 should equal 0
    public void Add_ShouldReturnCorrectSum(int num1, int num2, int expectedSum)
    {
        int result = calculator.Add(num1, num2);  // Adding the two number and storing the result
        Assert.That(result, Is.EqualTo(expectedSum)); // Assertion to verify the sum is correct
    }

    [Test]                               // Marks the method as a test case
    public void Add_ShouldReturnCorrectSum()
    {
        int result = calculator.Add(5, 3);      // Performs addition and stores result
        Assert.That(result, Is.EqualTo(8));     // Verifies the result is as expected
    }

    [Test]                               // Test for subtraction
    public void Subtract_ShouldReturnCorrectDifference()
    {
        int result = calculator.Subtract(10, 4); // Performs subtraction
        Assert.That(result, Is.EqualTo(6));      // Verifies the difference is correct
    }

    [Test]                               // Test for multiplication
    public void Multiply_ShouldReturnCorrectProduct()
    {
        int result = calculator.Multiply(6, 7);  // Performs multiplication
        Assert.That(result, Is.EqualTo(42));     // Verifies the product is correct
    }

    [Test]                               // Test for division
    public void Divide_ShouldReturnCorrectQuotient()
    {
        int result = calculator.Divide(20, 5);   // Performs division
        Assert.That(result, Is.EqualTo(4));      // Verifies the quotient is correct
    }

    [Test]                               // Test division by zero exception
    public void Divide_ByZero_ShouldThrowDivideByZeroException()
    {
        Assert.That(() => calculator.Divide(10, 0), // Attempts division by zero
                    Throws.TypeOf<DivideByZeroException>()); // Expects DivideByZeroException
    }

    [Test]                               // Test for modulus operation
    public void Modulus_ShouldReturnCorrectRemainder()
    {
        int result = calculator.Modulus(10, 3);   // Performs modulus operation
        Assert.That(result, Is.EqualTo(1));       // Verifies the remainder is correct
    }

    [Test]                               // Test modulus by zero exception
    public void Modulus_ByZero_ShouldThrowDivideByZeroException()
    {
        Assert.That(() => calculator.Modulus(10, 0), // Attempts modulus by zero
                    Throws.TypeOf<DivideByZeroException>()); // Expects DivideByZeroException
    }

    [TearDown]                              // Cleans up after each test method
    public void Cleanup()
    {
        calculator = null;                  // Release the Calculator instance after each test
    }
}
