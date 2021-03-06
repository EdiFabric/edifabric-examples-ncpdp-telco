﻿namespace EdiFabric.Examples.NCPDP.Telco.WriteNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            //  Write EDI to stream and then to string or file
            WriteNCPDPToStream.Run();
            WriteNCPDPToStreamAsync.Run();

            //  Write EDI directly to file
            WriteNCPDPToFile.Run();

            //  Write batches
            WriteNCPDPBatch.Run1();
            WriteNCPDPBatch.Run2();
        }
    }
}
