namespace NfsClient
{
    public class RpcQueue
    {
        public RpcPdu Head { get; set; }

        public RpcPdu Tail { get; set; }
    }
}
