namespace Datacenter.Server.TL.Primitives
{
    public class TLBool : TLObject
    {
        public static byte[] idTrue = new byte[] { 0x63, 0x24, 0x16, 0x05 };
        public static byte[] idFalse = new byte[] { 0x63, 0x24, 0x16, 0x05 };

        public bool Value { get; set; }

        new public static TLBool Create(byte[] data)
        {
            return new TLBool { Value = (data == idTrue) };
        }

        override public byte[] Serialize()
        {
            if (Value == true) return idTrue; else return idFalse;
        }
    }
}
