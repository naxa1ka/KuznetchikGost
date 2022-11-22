public static class ReferenceConstants
{
    public const string Key = "8899AABBCCDDEEFF0011223344556677FEDCBA98765432100123456789ABCDEF";
    public const string Input = "1122334455667700ffeeddccbbaa9988";
    public const string Output = "7f679d90bebc24305a468d42b9d4edcd";

    public static byte[] ByteKey => Converter.HexStringToByteArray(Key);
    public static byte[] ByteInput => Converter.HexStringToByteArray(Input);
    public static byte[] ByteOutput => Converter.HexStringToByteArray(Output);
}