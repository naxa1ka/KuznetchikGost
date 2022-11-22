using NUnit.Framework;

[TestFixture]
public class KuznetchikTest
{
    private const string RefKey = "8899AABBCCDDEEFF0011223344556677FEDCBA98765432100123456789ABCDEF";
    private const string RefInput = "1122334455667700ffeeddccbbaa9988";
    private const string RefOutput = "7f679d90bebc24305a468d42b9d4edcd";

    private Kuznetchik _kuznetchik;
    private byte[] _key;
    private byte[] _refInput;
    private byte[] _refOutput;

    [SetUp]
    public void Setup()
    {
        _kuznetchik = new Kuznetchik();
        _key = Converter.HexStringToByteArray(RefKey);
        _refInput = Converter.HexStringToByteArray(RefInput);
        _refOutput = Converter.HexStringToByteArray(RefOutput);
    }
    
    [Test]
    public void TestEncrypt()
    {
        var encrypt = _kuznetchik.Encrypt(_refInput, _key);
        var output = Converter.ByteArrayToString(encrypt);

        Assert.AreEqual(RefOutput, output);
    }

    [Test]
    public void TestDecrypt()
    {
        var decrypt = _kuznetchik.Decrypt(_refOutput, _key);
        var output = Converter.ByteArrayToString(decrypt);
        
        Assert.AreEqual(RefInput, output);
    }
}