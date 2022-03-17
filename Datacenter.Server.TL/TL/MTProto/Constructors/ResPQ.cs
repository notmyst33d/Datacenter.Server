using Datacenter.Server.TL.Primitives;

namespace Datacenter.Server.TL.MTProto.Constructors
{
    public class ResPQ : TLObject
    {
        // resPQ#05162463 nonce:int128 server_nonce:int128 pq:bytes server_public_key_fingerprints:Vector<long> = ResPQ;

        new public static readonly byte[] Id = new byte[] { 0x63, 0x24, 0x16, 0x05 };

        public TLInt128? Nonce { get; set; }
        public TLInt128? ServerNonce { get; set; }

        new public static ResPQ Create(byte[] data)
        {
            return new ResPQ();
        }

        override public byte[] Serialize()
        {
            return Id;
        }
    }
}
