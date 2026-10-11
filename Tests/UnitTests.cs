namespace GithubActionsLab;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_Valid_Sabherwal()
    {
        Assert.AreEqual(3.0, Program.Add("1", "2"), 1e-10);
        Assert.AreEqual(5.0, Program.Add("3", "2"), 1e-10);
        Assert.AreEqual(12.0, Program.Add("5", "7"), 1e-10);
    }

    [TestMethod]
    public void Add_Invalid_Sabherwal()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Sabherwal()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null!, null!));
    }

    [TestMethod]
    public void Subtract_Valid_Sabherwal()
    {
        Assert.AreEqual(3.0, Program.Subtract("5", "2"), 1e-10);
        Assert.AreEqual(-3.0, Program.Subtract("2", "5"), 1e-10);
        Assert.AreEqual(0.0, Program.Subtract("7", "7"), 1e-10);
    }

    [TestMethod]
    public void Subtract_Invalid_Sabherwal()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Sabherwal()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null!, null!));
    }

    [TestMethod]
    public void Multiply_Valid_Sabherwal()
    {
        Assert.AreEqual(6.0, Program.Multiply("2", "3"), 1e-10);
        Assert.AreEqual(-8.0, Program.Multiply("-4", "2"), 1e-10);
        Assert.AreEqual(0.0, Program.Multiply("5", "0"), 1e-10);
    }

    [TestMethod]
    public void Multiply_Invalid_Sabherwal()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Multiply_Null_Sabherwal()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null!, null!));
    }

    [TestMethod]
    public void Divide_Valid_Sabherwal()
    {
        Assert.AreEqual(4.0, Program.Divide("8", "2"), 1e-10);
        Assert.AreEqual(0.5, Program.Divide("1", "2"), 1e-10);
        Assert.AreEqual(-3.0, Program.Divide("-9", "3"), 1e-10);
    }

    [TestMethod]
    public void Divide_Invalid_Sabherwal()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }

    [TestMethod]
    public void Divide_Null_Sabherwal()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null!, null!));
    }

    [TestMethod]
    public void Power_Valid_Sabherwal()
    {
        Assert.AreEqual(8.0, Program.Power("2", "3"), 1e-10);
        Assert.AreEqual(1.0, Program.Power("5", "0"), 1e-10);
        Assert.AreEqual(0.25, Program.Power("2", "-2"), 1e-10);
    }

    [TestMethod]
    public void Power_Invalid_Sabherwal()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }

    [TestMethod]
    public void Power_Null_Sabherwal()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null!, null!));
    }
}