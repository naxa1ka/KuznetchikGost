using NUnit.Framework;

[TestFixture]
public class TestRFunc
{
    private Kuznetchik _kuznetchik;

    [SetUp]
    public void Setup()
    {
        _kuznetchik = new Kuznetchik();
    }
    
    [Test]
    public void R_Test_1()
    {
        var input = Converter.HexStringToByteArray("00000000000000000000000000000100");
        var output = _kuznetchik.R(input);
        Assert.AreEqual("94000000000000000000000000000001", Converter.ByteArrayToString(output));
    }

    [Test]
    public void R_Test_2()
    {
        var input = Converter.HexStringToByteArray("94000000000000000000000000000001");
        var output = _kuznetchik.R(input);
        Assert.AreEqual("a5940000000000000000000000000000", Converter.ByteArrayToString(output));
    }

    [Test]
    public void R_Test_3()
    {
        var input = Converter.HexStringToByteArray("a5940000000000000000000000000000");
        var output = _kuznetchik.R(input);
        Assert.AreEqual("64a59400000000000000000000000000", Converter.ByteArrayToString(output));
    }

    [Test]
    public void R_Test_4()
    {
        var input = Converter.HexStringToByteArray("64a59400000000000000000000000000");
        var output = _kuznetchik.R(input);
        Assert.AreEqual("0d64a594000000000000000000000000", Converter.ByteArrayToString(output));
    }
}