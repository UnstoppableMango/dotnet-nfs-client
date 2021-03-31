using System;
using System.Diagnostics;

namespace NfsClient
{
    public class NfsContext
    {
        public const int MaxClientName = 64;
        public const int NfsVerifierSize = 8;
        
        public NfsContext()
        {
            var clientName = new char[MaxClientName];

            Rpc = new RpcContext();
            Cwd = "/";
            Mask = 022;
            AutoTraverseMounts = 1;
            DirCacheEnabled = 1;
            AutoReconnect = -1;
            Version = (int)NfsVersion.V3;
            
            // NFS V4 Stuff
            Verifier = new char[NfsVerifierSize];
            SetClientIdConfirm = new char[NfsVerifierSize];
            
            // Create random initial verifier
            var pid = (uint)Process.GetCurrentProcess().Id;
            var v = DateTime.Now.Ticks << 32 | pid;
            for (int i = 0; i < NfsVerifierSize; i++)
            {
                Verifier[i] = (char)(v & 0xFF);
                v >>= 8;
            }

            ClientName = $"dotnet-nfs-client pid:{pid} {DateTime.Now}";
        }
        
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

        public char[] Verifier { get; set; }

        public string ClientName { get; set; }

        public ulong ClientId { get; set; }

        public char[] SetClientIdConfirm { get; set; }

        public uint SeqId { get; set; }

        public int HasLockOwner { get; set; }
    }
}
