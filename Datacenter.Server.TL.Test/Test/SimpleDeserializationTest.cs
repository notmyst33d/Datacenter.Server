using Datacenter.Server.Logging;

namespace Datacenter.Server.TL.Test
{
    class SimpleDeserializationTest {
        static bool Start() {
            Logging log = new Logging("Datacenter.Server.TL.Test.SimpleDeserializationTest");

            log.Info("Starting SimpleDeserializationTest");

            byte[] tlEncoded = Convert.ToBytes("00000000000000008e22c6969917000014000000f18e7ebe888ba96fbb7905493c691205b9bc411d", 16);
            log.Info(tlEncoded);
        }
    }   
}
