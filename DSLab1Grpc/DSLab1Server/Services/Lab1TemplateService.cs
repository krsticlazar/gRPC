using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace DSLab1Server.Services;

public class Lab1TemplateService : Lab1Template.Lab1TemplateBase
{
    public override Task<TextReply> Ping(Empty request, ServerCallContext context)
    {
        return Task.FromResult(new TextReply
        {
            Text = "Server radi"
        });
    }
}
