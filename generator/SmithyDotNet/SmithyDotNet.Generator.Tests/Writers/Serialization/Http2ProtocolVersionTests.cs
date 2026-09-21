using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// Covers HTTP/2 selection driven by the protocol trait's http/eventStreamHttp version lists: the request
// marshaller pins HttpProtocolVersion.Version20 for the operations the service's h2 degree requires.
public class Http2ProtocolVersionTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static Operation Op(GenerationContext context, string name) => context.Operations.Single(o => o.Name == name);

    [Fact]
    public void Required_ForcesHttp2_OnEveryOperation()
    {
        var context = TestModels.Context("Codegen/Http2/h2-required-model.json");
        Assert.True(Op(context, "Send").RequiresHttp2);

        var source = new JsonRequestMarshallerWriter(context, ModelFileName).Write(Op(context, "Send"), TestContext.Current.CancellationToken);
        Assert.Contains("#if NET8_0_OR_GREATER", source);
        Assert.Contains("request.HttpProtocolVersion = System.Net.HttpVersion.Version20;", source);
    }

    [Fact]
    public void None_NeverForcesHttp2()
    {
        var context = TestModels.Context("Codegen/Http2/h2-none-model.json");
        Assert.False(Op(context, "Send").RequiresHttp2);

        var source = new JsonRequestMarshallerWriter(context, ModelFileName).Write(Op(context, "Send"), TestContext.Current.CancellationToken);
        Assert.DoesNotContain("HttpProtocolVersion", source);
    }

    [Fact]
    public void EventStream_ForcesHttp2_OnOutputStreamsOnly()
    {
        var context = TestModels.Context("Codegen/Http2/h2-eventstream-model.json");
        Assert.True(Op(context, "Receive").RequiresHttp2);
        Assert.False(Op(context, "Ping").RequiresHttp2);

        var writer = new JsonRequestMarshallerWriter(context, ModelFileName);
        Assert.Contains("request.HttpProtocolVersion = System.Net.HttpVersion.Version20;", writer.Write(Op(context, "Receive"), TestContext.Current.CancellationToken));
        Assert.DoesNotContain("HttpProtocolVersion", writer.Write(Op(context, "Ping"), TestContext.Current.CancellationToken));
    }

    [Fact]
    public void Optional_ForcesHttp2_OnBidirectionalStreamsOnly()
    {
        var context = TestModels.Context("Codegen/Http2/h2-optional-model.json");
        Assert.True(Op(context, "Chat").RequiresHttp2);
        Assert.False(Op(context, "Receive").RequiresHttp2);
    }

    // A restJson1 trait with no version lists (the common case) is None — no h2 even when the operation
    // is an event stream.
    [Fact]
    public void EmptyProtocolTrait_NeverForcesHttp2_EvenWithEventStreams()
    {
        var context = TestModels.Context("Codegen/EventStreams/request-event-stream-model.json");
        Assert.False(Op(context, "Talk").RequiresHttp2);
    }

    // An eventStreamHttp that allows http/1.1 is Optional (bidi pinned) even though it lists no h2 at all:
    // only whether event streams can fall back to http/1.1 separates Optional from EventStream.
    [Fact]
    public void EventStreamHttpAllowingHttp11_IsOptional()
    {
        var context = TestModels.Context("Codegen/Http2/h2-eventstream-excluded-model.json");
        Assert.True(Op(context, "Chat").RequiresHttp2);
    }

    // eventStreamHttp with no http/1.1 fallback is EventStream (output stream forced to h2), even when
    // http itself prefers h2 — the event-stream list, not http ordering, decides.
    [Fact]
    public void EventStreamHttpH2Only_IsEventStream_EvenWhenHttpPrefersH2()
    {
        var context = TestModels.Context("Codegen/Http2/h2-eventstream-h2only-model.json");
        Assert.True(Op(context, "Receive").RequiresHttp2);
    }

    // eventStreamHttp defaults to http when absent, so http:["h2","http/1.1"] alone is Optional (bidi h2).
    [Fact]
    public void MissingEventStreamHttp_DefaultsToHttp()
    {
        var context = TestModels.Context("Codegen/Http2/h2-optional-default-model.json");
        Assert.True(Op(context, "Chat").RequiresHttp2);
    }

    // An explicitly empty eventStreamHttp defaults to http too, not to "no h2 for event streams".
    [Fact]
    public void EmptyEventStreamHttp_DefaultsToHttp()
    {
        var context = TestModels.Context("Codegen/Http2/h2-optional-empty-eventstream-model.json");
        Assert.True(Op(context, "Chat").RequiresHttp2);
    }

    // C2J omits h2 operations on .NET Framework and pre-net8 netstandard, so the client and interface
    // writers guard the whole operation with #if NET8_0_OR_GREATER. The client class carries no other
    // net8 guard, so its presence/absence is a clean signal; the interface always guards its
    // static-abstract members, so we compare guard counts there instead.
    [Fact]
    public void RequiredService_PutsOperationSignaturesInsideGuard()
    {
        var context = TestModels.Context("Codegen/Http2/h2-required-model.json");
        var source = new ClientClassWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken);

        // Walk the preprocessor directives and assert every emission of the operation's sync/async
        // signature sits inside an open #if NET8_0_OR_GREATER guard (not merely that a guard exists).
        var guards = new Stack<bool>();
        var sawGuardedSignature = false;
        using var lines = new StringReader(source);
        while (lines.ReadLine() is string line)
        {
            var trimmed = line.Trim();
            if (trimmed.StartsWith("#if"))
            {
                guards.Push(trimmed.Contains("NET8_0_OR_GREATER"));
            }
            else if (trimmed.StartsWith("#endif") && guards.Count > 0)
            {
                guards.Pop();
            }
            else if (trimmed.Contains("Send(") || trimmed.Contains("SendAsync("))
            {
                Assert.True(guards.Contains(true), $"operation emitted outside the h2 guard: {trimmed}");
                sawGuardedSignature = true;
            }
        }

        Assert.True(sawGuardedSignature, "expected the operation signature to be emitted");
    }

    [Fact]
    public void NoneService_DoesNotGuardClientClass()
    {
        var context = TestModels.Context("Codegen/Http2/h2-none-model.json");
        Assert.DoesNotContain("#if NET8_0_OR_GREATER", new ClientClassWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken));
    }

    [Fact]
    public void RequiredService_AddsOperationGuardToInterface()
    {
        var required = TestModels.Context("Codegen/Http2/h2-required-model.json");
        var none = TestModels.Context("Codegen/Http2/h2-none-model.json");
        Assert.Equal(GuardCount(none) + 1, GuardCount(required));

        static int GuardCount(GenerationContext context) =>
            new ClientInterfaceWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken).Split("#if NET8_0_OR_GREATER").Length - 1;
    }
}
