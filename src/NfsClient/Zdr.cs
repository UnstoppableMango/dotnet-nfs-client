namespace NfsClient
{
    public class Zdr
    {
        public ZdrOp XOp { get; set; }
        
        public byte[] Buf { get; set; }

        public int Size { get; set; }

        public int Pos { get; set; }

        public ZdrMem Mem { get; set; }
    }
}
