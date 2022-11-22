using NUnit.Framework;

[TestFixture]
public class TestSFunc
{
    private Kuznetchik _kuznetchik;

    [SetUp]
    public void Setup()
    {
        _kuznetchik = new Kuznetchik();
    }
    
    [Test]
    public void S_Test_1()
    {
        var input = Converter.HexStringToByteArray("ffeeddccbbaa99881122334455667700");
        var output = _kuznetchik.S(input);
        Assert.AreEqual("b66cd8887d38e8d77765aeea0c9a7efc", Converter.ByteArrayToString(output));
    }

    [Test]
    public void S_Test_2()
    {
        var input = Converter.HexStringToByteArray("b66cd8887d38e8d77765aeea0c9a7efc");
        var output = _kuznetchik.S(input);
        Assert.AreEqual("559d8dd7bd06cbfe7e7b262523280d39", Converter.ByteArrayToString(output));
    }

    [Test]
    public void S_Test_3()
    {
        var input = Converter.HexStringToByteArray("559d8dd7bd06cbfe7e7b262523280d39");
        var output = _kuznetchik.S(input);
        Assert.AreEqual("0c3322fed531e4630d80ef5c5a81c50b", Converter.ByteArrayToString(output));
    }

    [Test]
    public void S_Test_4()
    {
        var input = Converter.HexStringToByteArray("0c3322fed531e4630d80ef5c5a81c50b");
        var output = _kuznetchik.S(input);
        Assert.AreEqual("23ae65633f842d29c5df529c13f5acda", Converter.ByteArrayToString(output));
    }
}