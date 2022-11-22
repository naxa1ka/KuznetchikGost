using NUnit.Framework;

[TestFixture]
public class TestLFunc
{
    private Kuznetchik _kuznetchik;

    [SetUp]
    public void Setup()
    {
        _kuznetchik = new Kuznetchik();
    }
    
    [Test]
    public void L_Test_1()
    {
        var input = Converter.HexStringToByteArray("64a59400000000000000000000000000");
        var output = _kuznetchik.L(input);
        Assert.AreEqual("d456584dd0e3e84cc3166e4b7fa2890d", Converter.ByteArrayToString(output));
    }

    [Test]
    public void L_Test_2()
    {
        var input = Converter.HexStringToByteArray("d456584dd0e3e84cc3166e4b7fa2890d");
        var output = _kuznetchik.L(input);
        Assert.AreEqual("79d26221b87b584cd42fbc4ffea5de9a", Converter.ByteArrayToString(output));
    }

    [Test]
    public void L_Test_3()
    {
        var input = Converter.HexStringToByteArray("79d26221b87b584cd42fbc4ffea5de9a");
        var output = _kuznetchik.L(input);
        Assert.AreEqual("0e93691a0cfc60408b7b68f66b513c13", Converter.ByteArrayToString(output));
    }

    [Test]
    public void L_Test_4()
    {
        var input = Converter.HexStringToByteArray("0e93691a0cfc60408b7b68f66b513c13");
        var output = _kuznetchik.L(input);
        Assert.AreEqual("e6a8094fee0aa204fd97bcb0b44b8580", Converter.ByteArrayToString(output));
    }
}