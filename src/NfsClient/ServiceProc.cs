namespace NfsClient
{
    public class ServiceProc
    {
        public int Proc { get; set; }

        public ServiceFn Func { get; set; }

        public ZdrProc DecodeFn { get; set; }

        public int DecodeBufSize { get; set; }
    }
}
