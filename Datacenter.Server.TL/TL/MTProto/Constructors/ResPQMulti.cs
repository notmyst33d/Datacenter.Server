using Datacenter.Server.TL.Primitives;

namespace Datacenter.Server.TL.MTProto.Constructors
{
    public class ResPQMulti : TLObject
    {
        // req_pq_multi#be7e8ef1 nonce:int128 = ResPQ;

        new public static readonly byte[] Id = new byte[] { 0xf1, 0x8e, 0x7e, 0xbe };

        public TLInt128? Nonce { get; set; }

        new public static ResPQMulti Create(byte[] data)
        {
            return new ResPQMulti
            {
                Nonce = TLInt128.Create(data)
            };
        }

        override public byte[] Serialize()
        {
            return Id;
        }
    }
}
