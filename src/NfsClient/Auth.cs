namespace NfsClient
{
    public class Auth
    {
        public OpaqueAuth AhCred { get; set; }

        public OpaqueAuth AhVerf { get; set; }

        public string AhPrivate { get; set; }
        
        public static Auth CreateUnix(string host, uint uid, uint gid, uint len, uint[] groups)
        {
            var auth = new Auth();
            int size, idx;
            uint[] buf;

            // LibNfs narrows from long to int
            size = (int)(4 + 4 + ((host.Length + 3) & ~3) + 4 + 4 + 4 + len * 4);
            auth.AhCred = new OpaqueAuth {
                OaFlavor = 1,
                OaLength = size,
                OaBase = = size,
            };
        }
    }
}
