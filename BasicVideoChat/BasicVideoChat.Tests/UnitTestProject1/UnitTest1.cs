using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class MathTests
{
    [TestMethod]
    public void Test_Add()
    {
        var actual = MathHelper.Add(1, 2);
        var expected = 2;
        Assert.AreEqual(expected, actual);
    }
}
public class MathHelper
{
    public static int Add(int a, int b) => a + b;
}