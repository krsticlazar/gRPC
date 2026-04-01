using DSLab1Client;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;

using var channel = GrpcChannel.ForAddress("http://localhost:5110");
var client = new Lab1Template.Lab1TemplateClient(channel);

var response = await WaitForServerAsync(client);
Console.WriteLine(response.Text);
Console.ReadLine();

static async Task<TextReply> WaitForServerAsync(Lab1Template.Lab1TemplateClient client)
{
    const int maxAttempts = 10;

    for (int attempt = 1; attempt <= maxAttempts; attempt++)
    {
        try
        {
            return await client.PingAsync(new Empty());
        }
        catch (RpcException) when (attempt < maxAttempts)
        {
            await Task.Delay(500);
        }
        catch (HttpRequestException) when (attempt < maxAttempts)
        {
            await Task.Delay(500);
        }
    }

    throw new InvalidOperationException("Klijent nije uspeo da se poveze na gRPC server na adresi http://localhost:5110.");
}
