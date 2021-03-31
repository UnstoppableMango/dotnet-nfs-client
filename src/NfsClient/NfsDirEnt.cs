namespace NfsClient
{
    public class NfsDirEnt
    {
        public NfsDirEnt Next { get; set; }

        public string Name { get; set; }

        public ulong INode { get; set; }

        public uint Type { get; set; }

        public uint Mode { get; set; }

        public ulong Size { get; set; }

        public Timeval ATime { get; set; }

        public Timeval MTime { get; set; }

        public Timeval CTime { get; set; }

        public uint Uid { get; set; }

        public uint Gid { get; set; }

        public uint NLink { get; set; }

        public ulong Dev { get; set; }

        public ulong RDev { get; set; }

        public ulong BlkSize { get; set; }

        public ulong Blocks { get; set; }

        public ulong Used { get; set; }

        public uint ATimeNSec { get; set; }

        public uint MTimeNSec { get; set; }

        public uint CTimeNSec { get; set; }
    }
}
