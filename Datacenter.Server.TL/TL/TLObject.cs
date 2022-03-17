namespace Datacenter.Server.TL
{
    abstract public class TLObject
    {
        public static readonly byte[] Id = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        public static readonly byte[] EmptyId = new byte[] { 0x00, 0x00, 0x00, 0x00 };

        public static readonly Dictionary<byte[], Func<byte[], TLObject>> Mapping = new Dictionary<byte[], Func<byte[], TLObject>>() {
            {new byte[] { 0xf1, 0x8e, 0x7e, 0xbe }, TL.MTProto.Constructors.ResPQMulti.Create},
            {new byte[] { 0x63, 0x24, 0x16, 0x05 }, TL.MTProto.Constructors.ResPQ.Create},
        };

        public static TLObject Create(byte[] data)
        {
            if (Mapping.ContainsKey(data[..4]))
                return Mapping[data[..4]](data);
            else
                throw new NotImplementedException();
        }

        abstract public byte[] Serialize();
    }
}
