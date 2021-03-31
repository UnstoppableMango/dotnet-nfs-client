namespace NfsClient
{
    public class RpcEndpoint
    {
        public RpcEndpoint Next { get; set; }

        public int Program { get; set; }

        public int Version { get; set; }

        public ServiceProc Procs { get; set; }

        public int NumProcs { get; set; }
    }
}
