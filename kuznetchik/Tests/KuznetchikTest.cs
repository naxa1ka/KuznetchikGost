using NUnit.Framework;

[TestFixture]
public class KuznetchikTest
{
    private Kuznetchik _kuznetchik;

    [SetUp]
    public void Setup()
    {
        _kuznetchik = new Kuznetchik();
    }
    
    [Test]
    public void TestEncrypt()
    {
        var encrypt = _kuznetchik.Encrypt(ReferenceConstants.ByteInput, ReferenceConstants.ByteKey);
        var output = Converter.ByteArrayToString(encrypt);

        Assert.AreEqual(ReferenceConstants.Output, output);
    }

    [Test]
    public void TestDecrypt()
    {
        var decrypt = _kuznetchik.Decrypt(ReferenceConstants.ByteOutput, ReferenceConstants.ByteKey);
        var output = Converter.ByteArrayToString(decrypt);
        
        Assert.AreEqual(ReferenceConstants.Input, output);
    }
}