// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: greeting.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Greet {
  public static partial class GreetingService
  {
    static readonly string __ServiceName = "greet.GreetingService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Greet.GreetingRequest> __Marshaller_greet_GreetingRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Greet.GreetingRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Greet.GreetingResponse> __Marshaller_greet_GreetingResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Greet.GreetingResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse> __Method_Greet = new grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Greet",
        __Marshaller_greet_GreetingRequest,
        __Marshaller_greet_GreetingResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse> __Method_GreetManyTimes = new grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GreetManyTimes",
        __Marshaller_greet_GreetingRequest,
        __Marshaller_greet_GreetingResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse> __Method_GreetFromClientManyTimes = new grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "GreetFromClientManyTimes",
        __Marshaller_greet_GreetingRequest,
        __Marshaller_greet_GreetingResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse> __Method_GreetBiDi = new grpc::Method<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "GreetBiDi",
        __Marshaller_greet_GreetingRequest,
        __Marshaller_greet_GreetingResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Greet.GreetingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GreetingService</summary>
    [grpc::BindServiceMethod(typeof(GreetingService), "BindService")]
    public abstract partial class GreetingServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Greet.GreetingResponse> Greet(global::Greet.GreetingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GreetManyTimes(global::Greet.GreetingRequest request, grpc::IServerStreamWriter<global::Greet.GreetingResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Greet.GreetingResponse> GreetFromClientManyTimes(grpc::IAsyncStreamReader<global::Greet.GreetingRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GreetBiDi(grpc::IAsyncStreamReader<global::Greet.GreetingRequest> requestStream, grpc::IServerStreamWriter<global::Greet.GreetingResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GreetingService</summary>
    public partial class GreetingServiceClient : grpc::ClientBase<GreetingServiceClient>
    {
      /// <summary>Creates a new client for GreetingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GreetingServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GreetingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GreetingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GreetingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GreetingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Greet.GreetingResponse Greet(global::Greet.GreetingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Greet(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Greet.GreetingResponse Greet(global::Greet.GreetingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Greet, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Greet.GreetingResponse> GreetAsync(global::Greet.GreetingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GreetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Greet.GreetingResponse> GreetAsync(global::Greet.GreetingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Greet, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Greet.GreetingResponse> GreetManyTimes(global::Greet.GreetingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GreetManyTimes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Greet.GreetingResponse> GreetManyTimes(global::Greet.GreetingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GreetManyTimes, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Greet.GreetingRequest, global::Greet.GreetingResponse> GreetFromClientManyTimes(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GreetFromClientManyTimes(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Greet.GreetingRequest, global::Greet.GreetingResponse> GreetFromClientManyTimes(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_GreetFromClientManyTimes, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Greet.GreetingRequest, global::Greet.GreetingResponse> GreetBiDi(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GreetBiDi(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Greet.GreetingRequest, global::Greet.GreetingResponse> GreetBiDi(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_GreetBiDi, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override GreetingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreetingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GreetingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Greet, serviceImpl.Greet)
          .AddMethod(__Method_GreetManyTimes, serviceImpl.GreetManyTimes)
          .AddMethod(__Method_GreetFromClientManyTimes, serviceImpl.GreetFromClientManyTimes)
          .AddMethod(__Method_GreetBiDi, serviceImpl.GreetBiDi).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreetingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Greet, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(serviceImpl.Greet));
      serviceBinder.AddMethod(__Method_GreetManyTimes, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(serviceImpl.GreetManyTimes));
      serviceBinder.AddMethod(__Method_GreetFromClientManyTimes, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(serviceImpl.GreetFromClientManyTimes));
      serviceBinder.AddMethod(__Method_GreetBiDi, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Greet.GreetingRequest, global::Greet.GreetingResponse>(serviceImpl.GreetBiDi));
    }

  }
}
#endregion