namespace Datacenter.Server.TL.Test
{
    class Program
    {
        static void Main()
        {
            Logging log = new Logging("Datacenter.Server.TL.Test");

            log.Info("Starting tests");

            if (SimpleDeserializationTest.Start())
                log.Success("SimpleDeserializationTest passed");
            else
                log.Error("SimpleDeserializationTest failed");
        }
    }
}
