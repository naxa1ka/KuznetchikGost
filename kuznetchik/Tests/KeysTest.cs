
    using NUnit.Framework;

    [TestFixture]
    public class KeysTest
    {
        [Test]
        public void KeyTest()
        {
            var kuznetchik = new Kuznetchik();
            var generateKeys = kuznetchik.GenerateKeys(ReferenceConstants.ByteKey);
            Assert.AreEqual(Converter.HexStringToByteArray("8899aabbccddeeff0011223344556677"), generateKeys[0]);
            Assert.AreEqual(Converter.HexStringToByteArray("fedcba98765432100123456789abcdef"), generateKeys[1]);
            Assert.AreEqual(Converter.HexStringToByteArray("db31485315694343228d6aef8cc78c44"), generateKeys[2]);
            Assert.AreEqual(Converter.HexStringToByteArray("3d4553d8e9cfec6815ebadc40a9ffd04"), generateKeys[3]);
            Assert.AreEqual(Converter.HexStringToByteArray("57646468c44a5e28d3e59246f429f1ac"), generateKeys[4]);
            Assert.AreEqual(Converter.HexStringToByteArray("bd079435165c6432b532e82834da581b"), generateKeys[5]);
            Assert.AreEqual(Converter.HexStringToByteArray("51e640757e8745de705727265a0098b1"), generateKeys[6]);
            Assert.AreEqual(Converter.HexStringToByteArray("5a7925017b9fdd3ed72a91a22286f984"), generateKeys[7]);
            Assert.AreEqual(Converter.HexStringToByteArray("bb44e25378c73123a5f32f73cdb6e517"), generateKeys[8]);
            Assert.AreEqual(Converter.HexStringToByteArray("72e9dd7416bcf45b755dbaa88e4a4043"), generateKeys[9]);
        }
    }