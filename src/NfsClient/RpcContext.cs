using System.Net;

namespace NfsClient
{
    public class RpcContext
    {
        public const int Hashes = 1024;
        public const int IfNameSize = 16;
        
        public uint Magic { get; set; }

        public int Fd { get; set; }

        public int OldFd { get; set; }

        public int IsConnected { get; set; }

        public int IsNonBlocking { get; set; }

        public string ErrorString { get; set; }

        public RpcCallback ConnectCallback { get; set; }

        public byte[] ConnectData { get; set; }

        public Auth Auth { get; set; }

        public uint Xid { get; set; }

        public RpcQueue OutQueue { get; set; }

        public SocketAddress UdpSrc { get; set; }

        public RpcQueue[] WaitPdu { get; set; } = new RpcQueue[Hashes];

        public uint WaitPduLen { get; set; }

        public uint InPos { get; set; }

        public char[] RmBuf { get; set; } = new char[4];

        public string InBuf { get; set; }

        public int IsUdp { get; set; }

        public SocketAddress UdpDest { get; set; }

        public int IsBroadcast { get; set; }

        public SocketAddress S { get; set; }

        public int AutoReconnect { get; set; }

        public int NumRetries { get; set; }

        public RpcFragment Fragments { get; set; }

        public int TcpSyncNt { get; set; }

        public int Uid { get; set; }

        public int Gid { get; set; }

        public uint ReadAhead { get; set; }

        public uint PageCache { get; set; }

        public uint PageCacheTtl { get; set; }

        public int Debug { get; set; }

        public int Timeout { get; set; }

        public char[] IfName { get; set; } = new char[IfNameSize];

        public int IsServerContext { get; set; }
    }
}
