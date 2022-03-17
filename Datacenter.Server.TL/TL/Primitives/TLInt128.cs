using System.Numerics;

namespace Datacenter.Server.TL.Primitives
{
    public class TLInt128 : TLObject
    {
        public BigInteger? Value { get; set; }

        new public static TLInt128 Create(byte[] data)
        {
            return new TLInt128
            {
                Value = new BigInteger(data.Reverse().ToArray())
            };
        }

        override public byte[] Serialize()
        {
            if (Value == null)
                return new byte[] {};

            byte[] serializedData = Value?.ToByteArray()!;

            if (serializedData.Length != 16)
            {
                for (int i = 0; i < (serializedData.Length - 16); i++)
                    serializedData = serializedData.Concat(new byte[] { 0x00 }).ToArray();
            }

            return serializedData.Reverse().ToArray();
        }
    }
}
