namespace NfsClient
{
    public class RpcFragment
    {
        public RpcFragment Next { get; set; }

        public uint Size { get; set; }

        public byte[] Data { get; set; }
    }
}
