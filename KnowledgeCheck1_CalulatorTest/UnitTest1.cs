using KnowledgeCheck1_Calculator;
namespace KnowledgeCheck1_CalulatorTest;

[TestClass]
public class UnitTest1
{
    Calculator calculator = new Calculator();

    [TestMethod]
    public void TestAddition()
    {
        Assert.AreEqual(12, calculator.Add(8, 4));
    }

    [TestMethod]
    public void TestSubtraction()
    {
        Assert.AreEqual(6, calculator.Subtract(9, 3));
    }

    [TestMethod]
    public void TestMultiply()
    {
        Assert.AreEqual(55, calculator.Multiply(5, 11));
    }

    [TestMethod]
    public void TestDivision()
    {
        Assert.AreEqual(7, calculator.Divide(49, 7));
    }
}
