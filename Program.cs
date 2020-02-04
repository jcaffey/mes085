using System;
using Mes.Gateway;

namespace Mes085
{
    class Program
    {
        static void Main(string[] args)
        {
            GatewaySettings settings = new GatewaySettings();
            settings.setCredentials("", "")
            .setVerbose(true)
            .setHostUrl(GatewaySettings.URL_CERT);
            Gateway gateway = new Gateway(settings);

            // run verify to get 085
            GatewayRequest request = new GatewayRequest(GatewayRequest.TransactionType.VERIFY);
            request.setCardData("4485317822240309", "1022");
            request.setAmount("0.00");
            GatewayResponse response = gateway.run(request);

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Error code with VERIFY (A) and amount 0.00:");
            Console.WriteLine(response.getErrorCode());
            Console.WriteLine("--------------------------------------------------------");

            // sale at 0.85
            request = new GatewayRequest(GatewayRequest.TransactionType.SALE);
            request.setCardData("4485317822240309", "1022");
            request.setAmount("0.85");
            response = gateway.run(request);
            
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Error code with SALE (D) and amount 0.85:");
            Console.WriteLine(response.getErrorCode());
            Console.WriteLine("--------------------------------------------------------");

            request = new GatewayRequest(GatewayRequest.TransactionType.BATCHCLOSE);
            response = gateway.run(request);

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Error code with BATCHCLOSE (Z)");
            Console.WriteLine(response.getErrorCode());
            Console.WriteLine("--------------------------------------------------------");

            // Make refund request with transaction id of previous sale...
            // No 085 ... error code is 000
            request = new GatewayRequest(GatewayRequest.TransactionType.REFUND);
            request.setTranId(response.getTransactionId());
            response = gateway.run(request);

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Error code with REFUND (U):");
            Console.WriteLine(response.getErrorCode());
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
