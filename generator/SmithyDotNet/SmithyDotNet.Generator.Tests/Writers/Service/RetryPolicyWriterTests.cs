using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Service;

public class RetryPolicyWriterTests
{
    // payload-model has one operation per output binding the inclusion rule can see:
    //   DoStructurePayload      -> Unit output, included
    //   GetStructurePayload     -> structure payload, included
    //   GetStringPayload        -> string payload, included (C2J's string guard never fires)
    //   GetBlobPayload          -> non-streaming blob payload, included
    //   GetStreamingBlobPayload -> @streaming blob payload, the one exclusion
    private static readonly string Output =
        new RetryPolicyWriter(TestModels.Context("Codegen/payload-model.json"), "smithy.json").Write(TestContext.Current.CancellationToken);

    // S3's SelectObjectContent is in the shipped list despite its event-stream output, so a streaming
    // union must not exclude the operation.
    private static readonly string EventStreamOutput =
        new RetryPolicyWriter(TestModels.Context("Codegen/EventStreams/event-stream-output-model.json"), "smithy.json").Write(TestContext.Current.CancellationToken);

    [Fact]
    public void EmitsRetryPolicyPartialClass()
    {
        Assert.Contains("namespace Amazon.Example.Internal", Output);
        Assert.Contains("public partial class AmazonExampleRetryPolicy : DefaultRetryPolicy", Output);
        Assert.Contains("internal static readonly ICollection<Type> RequestsWith200Error = new HashSet<Type>", Output);
    }

    // A service other than S3 has no Util namespace, so the file must not import it.
    [Fact]
    public void ImportsOnlyWhatTheBodyUses()
    {
        Assert.DoesNotContain("Amazon.Example.Util", Output);
        Assert.Contains("using Amazon.Runtime.Internal;", Output);
        Assert.Contains("using Amazon.Example.Model;", Output);
        Assert.Contains("using System;", Output);
        Assert.Contains("using System.Collections.Generic;", Output);
    }

    [Fact]
    public void IncludesOperationWithNoOutputShape() => Assert.Contains("typeof(DoStructurePayloadRequest),", Output);

    [Fact]
    public void IncludesOperationWithStructureOutputPayload() => Assert.Contains("typeof(GetStructurePayloadRequest),", Output);

    [Fact]
    public void IncludesOperationWithStringOutputPayload() => Assert.Contains("typeof(GetStringPayloadRequest),", Output);

    [Fact]
    public void IncludesOperationWithNonStreamingBlobOutputPayload() => Assert.Contains("typeof(GetBlobPayloadRequest),", Output);

    [Fact]
    public void ExcludesOperationWithStreamingBlobOutputPayload() => Assert.DoesNotContain("typeof(GetStreamingBlobPayloadRequest),", Output);

    // S3's SelectObjectContent is client-method-only (its request class is hand-written) yet ships in the list,
    // so the list walks every operation, not just the generated ones.
    [Fact]
    public void IncludesClientMethodOnlyOperation()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["SelectThing"] = new OperationModifier { ClientMethodOnly = true };
        var context = TestModels.Context(TestModels.Load("Codegen/restxml-model.json"), customizations);

        Assert.Contains("typeof(SelectThingRequest),", new RetryPolicyWriter(context, "smithy.json").Write(TestContext.Current.CancellationToken));
    }

    [Fact]
    public void IncludesOperationWithOutputEventStream() => Assert.Contains("typeof(ConverseStreamRequest),", EventStreamOutput);
}
