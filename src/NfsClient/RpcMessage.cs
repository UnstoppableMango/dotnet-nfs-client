namespace NfsClient
{
    public class RpcMessage
    {
        public uint Xid { get; set; }

        public uint Direction { get; set; }
        
        // TODO: Call/Reply union
    }
}
