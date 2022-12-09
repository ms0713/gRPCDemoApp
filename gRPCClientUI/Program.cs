// See https://aka.ms/new-console-template for more information

using Greet;
using Grpc.Core;

const string Target = "127.0.0.1:50051";

Console.WriteLine("Welcome to gRPC (client)");

Channel channel = new(Target, ChannelCredentials.Insecure);

await channel.ConnectAsync().ContinueWith((task) =>
{
    if (task.Status == TaskStatus.RanToCompletion)
    {
        Console.WriteLine("Client connected successfully.");
    }
}); 

var client = new GreetingService.GreetingServiceClient(channel);
var greeting = new Greeting()
{
    FirstName = "Milan",
    LastName = "Sangani"
};

var request = new GreetingRequest() { Greeting = greeting };

// Unary
//var response = client.Greet(request);
//Console.WriteLine($"Response : {response.FullName}");

// Server Streaming
//var response = client.GreetManyTimes(request);
//while (await response.ResponseStream.MoveNext())
//{
//    Console.WriteLine($"Response : {response.ResponseStream.Current.FullName}");
//    await Task.Delay(200);
//}

// Client Streaming
//var requestSent = client.GreetFromClientManyTimes();

//foreach (int i in Enumerable.Range(1,10))
//{
//    await requestSent.RequestStream.WriteAsync(request);
//}
//await requestSent.RequestStream.CompleteAsync();
//var response = await requestSent.ResponseAsync;

//Console.WriteLine($"{response.FullName}");

// BiDi Streaming
var stream = client.GreetBiDi();

var responseReaderTask = Task.Run(async () =>
{
    int count = 0;
    while (await stream.ResponseStream.MoveNext())
    {
        count++;
    }

    Console.WriteLine($"Response count : {count}");
});

List<Greeting> greetings = new()
{
    new Greeting() { FirstName = "Milan", LastName = "Sangani"},
    new Greeting() { FirstName = "Nayan", LastName = "Surani"},
    new Greeting() { FirstName = "Pratik", LastName = "Thakkar"},
};

for (int i = 0; i < greetings.Count; i++)
{
    await stream.RequestStream.WriteAsync(new GreetingRequest()
    {
        Greeting = greetings[i],
    });
}

await stream.RequestStream.CompleteAsync();

await responseReaderTask;

channel.ShutdownAsync().Wait();
Console.ReadLine();
