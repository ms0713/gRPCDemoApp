// See https://aka.ms/new-console-template for more information

using Greet;
using Grpc.Core;
using gRPCServerUI;

const int port = 50051;
Server m_Server = null;

try
{
    Console.WriteLine("Welcome to gRPC!");

    m_Server = new Server()
    {
        Services = { GreetingService.BindService(new GreetingServiceImpl()) },
        Ports = { new ServerPort("localhost", port, ServerCredentials.Insecure) }
    };
    m_Server.Start();

    Console.WriteLine($"Server started on port : {port}");
    Console.ReadLine();
}
catch (IOException ex)
{
    Console.WriteLine($"Server failed to start. Error: {ex.Message}");
}
finally
{
    if (m_Server is not null)
    {
        m_Server.ShutdownAsync().Wait();
    }
}

