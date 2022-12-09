using Greet;
using Grpc.Core;
using static Greet.GreetingService;

namespace gRPCServerUI;

public class GreetingServiceImpl : GreetingServiceBase
{
    public override Task<GreetingResponse> Greet(GreetingRequest request, ServerCallContext context)
    {
        string output = String.Format($"Welcome {request.Greeting.FirstName} {request.Greeting.LastName}");
        return Task.FromResult(new GreetingResponse() { FullName = output});
    }

    public override async Task GreetManyTimes(GreetingRequest request, IServerStreamWriter<GreetingResponse> responseStream, ServerCallContext context)
    {
        string output = String.Format($"Welcome {request.Greeting.FirstName} {request.Greeting.LastName}");

        foreach (int i in Enumerable.Range(1,10))
        {
            await responseStream.WriteAsync(new GreetingResponse() { FullName = output });
        }
    }

    public override async Task<GreetingResponse> GreetFromClientManyTimes(IAsyncStreamReader<GreetingRequest> requestStream, ServerCallContext context)
    {
        int count = 0;
        string output = string.Empty;
        while(await requestStream.MoveNext())
        {
            output = $"{requestStream.Current.Greeting.FirstName} {requestStream.Current.Greeting.LastName}";
            count++;
        }

        return new GreetingResponse() { FullName = $"{output} : {count}" };
    }

    public override async Task GreetBiDi(IAsyncStreamReader<GreetingRequest> requestStream, IServerStreamWriter<GreetingResponse> responseStream, ServerCallContext context)
    {
        int count = 0;
        string output = string.Empty;
        while (await requestStream.MoveNext())
        {
            output = $"{requestStream.Current.Greeting.FirstName} {requestStream.Current.Greeting.LastName}";
            count++;

            await responseStream.WriteAsync(new GreetingResponse() { FullName = $"{output} : {count}" });
        }
    }
}

