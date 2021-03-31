namespace NfsClient
{
    public class CallBody
    {
        public uint RpcVers { get; set; }

        public uint Prog { get; set; }

        public uint Vers { get; set; }

        public uint Proc { get; set; }

        public Auth Cred { get; set; }

        public Auth Verf { get; set; }

        public byte[] Args { get; set; }
    }
}
