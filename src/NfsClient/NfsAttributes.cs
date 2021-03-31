namespace NfsClient
{
    public class NfsAttributes
    {
        public uint Type { get; set; }

        public uint Mode { get; set; }

        public uint Uid { get; set; }

        public uint Gid { get; set; }

        public uint NLink { get; set; }

        public ulong Size { get; set; }

        public ulong Used { get; set; }

        public ulong Fsid { get; set; }

        public NfsSpecdata Specdata { get; set; }

        public NfsTime ATime { get; set; }

        public NfsTime MTime { get; set; }

        public NfsTime CTime { get; set; }
    }
}
