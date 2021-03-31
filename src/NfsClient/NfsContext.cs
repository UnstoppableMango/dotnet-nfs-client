namespace NfsClient
{
    public class NfsContext
    {
        public RpcContext Rpc { get; set; }

        public string Server { get; set; }

        public string Export { get; set; }

        public NfsFh RootFh { get; set; }

        public ulong ReadMax { get; set; }

        public ulong WriteMax { get; set; }

        public string Cwd { get; set; }

        public int DirCacheEnabled { get; set; }

        public int AutoReconnect { get; set; }

        public NfsDir DirCache { get; set; }

        public ushort Mask { get; set; }

        public int AutoTraverseMounts { get; set; }

        public NestedMounts NestedMounts { get; set; }

        public int Version { get; set; }

        public int NfsPort { get; set; }

        public int MountPort { get; set; }

        public string Verifier { get; set; }

        public string ClientName { get; set; }

        public ulong ClientId { get; set; }

        public string SetClientIdConfirm { get; set; }

        public uint SeqId { get; set; }

        public int HasLockOwner { get; set; }
    }
}
