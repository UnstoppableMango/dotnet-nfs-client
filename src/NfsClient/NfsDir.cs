namespace NfsClient
{
    public class NfsDir
    {
        public NfsFh Fh { get; set; }

        public NfsAttributes Attributes { get; set; }

        public NfsDir Next { get; set; }

        public NfsDirEnt Entries { get; set; }

        public NfsDirEnt Current { get; set; }
    }
}
