namespace NfsClient
{
    public class NestedMounts
    {
        public NestedMounts Next { get; set; }

        public string Path { get; set; }

        public NfsFh Fh { get; set; }

        public NfsAttributes Attributes { get; set; }
    }
}
