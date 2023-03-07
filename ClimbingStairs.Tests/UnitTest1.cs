namespace ClimbingStairs.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int n = 3;
        int result = _test.ClimbStairs(n);
        Assert.AreEqual(3, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int n = 14;
        int result = _test.ClimbStairs(n);
        Assert.AreEqual(610, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        int n = 33;
        int result = _test.ClimbStairs(n);
        Assert.AreEqual(5702887, result);
    }
}