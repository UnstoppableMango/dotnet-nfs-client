namespace NfsClient
{
    public delegate void RpcCallback(RpcContext context, int status, byte[] data, byte[] privateData);
}
