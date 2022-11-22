using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var kuznetchik = new Kuznetchik();

        const string key = "8899AABBCCDDEEFF0011223344556677FEDCBA98765432100123456789ABCDEF";
        var byteKey = Converter.HexStringToByteArray(key);

        const string strInput = "1122334455667700ffeeddccbbaa9988";
        Console.WriteLine("Initial input:");
        Console.WriteLine(strInput);
        Console.WriteLine("--------------------------------");

        var encryptByte = kuznetchik.Encrypt(Converter.HexStringToByteArray(strInput), byteKey);
        var encryptStr = Converter.ByteArrayToString(encryptByte);
        Console.WriteLine("Encrypted:");
        Console.WriteLine(encryptStr);
        Console.WriteLine("--------------------------------");

        var decryptByte = kuznetchik.Decrypt(encryptByte, byteKey);
        var decryptStr = Converter.ByteArrayToString(decryptByte);
        Console.WriteLine("Decrypted:");
        Console.WriteLine(decryptStr);
    }
}