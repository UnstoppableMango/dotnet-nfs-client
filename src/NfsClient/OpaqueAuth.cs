namespace NfsClient
{
    public class OpaqueAuth
    {
        public uint OaFlavor { get; set; }

        public byte[] OaBase { get; set; }

        public uint OaLength { get; set; }
    }
}
