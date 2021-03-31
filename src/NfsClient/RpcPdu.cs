namespace NfsClient
{
    public class RpcPdu
    {
        public RpcPdu Next { get; set; }

        public uint Xid { get; set; }

        public Zdr Zdr { get; set; }

        public uint Written { get; set; }

        public RpcData OutData { get; set; }

        public RpcCallback Callback { get; set; }

        public byte[] PrivateData { get; set; }

        public ZdrProc ZdrDecode { get; set; }

        public byte[] ZdrDecodeBuf { get; set; }

        public uint ZdrDecodeBufSize { get; set; }

        public uint Flags { get; set; }

        public ulong Timeout { get; set; }
    }
}
