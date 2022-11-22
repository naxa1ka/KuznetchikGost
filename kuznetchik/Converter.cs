using System;
using System.Linq;
using System.Text;

public static class Converter
{
    public static string ByteArrayToString(byte[] array)
    {
        var hex = new StringBuilder(array.Length * 2);
        foreach (var b in array)
            hex.Append($"{b:x2}");
        return hex.ToString();
    }

    public static byte[] HexStringToByteArray(string hex)
    {
        return Enumerable.Range(0, hex.Length)
            .Where(x => x % 2 == 0)
            .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
            .ToArray();
    }
}