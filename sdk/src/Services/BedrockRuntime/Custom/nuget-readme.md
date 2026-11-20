## Bidirectional streaming

`InvokeModelWithBidirectionalStream` sends and receives events over HTTP/2. It is available on .NET 8 and later.

The SDK calls `BodyPublisher` to get each event to send, until it returns `null`. The call does not return a response until some events have been published, so provide events from a different thread than the one that invokes the operation.

```csharp
using System.Text;
using System.Threading.Channels;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;

var client = new AmazonBedrockRuntimeClient();
var input = Channel.CreateUnbounded<string>();

var request = new InvokeModelWithBidirectionalStreamRequest
{
    ModelId = "<model-id>",
    BodyPublisher = async () =>
    {
        if (!await input.Reader.WaitToReadAsync())
        {
            return null;
        }

        var json = await input.Reader.ReadAsync();
        return new BidirectionalInputPayloadPart
        {
            Bytes = new MemoryStream(Encoding.UTF8.GetBytes(json))
        };
    }
};

// The event format is defined by the model.
_ = Task.Run(async () =>
{
    await input.Writer.WriteAsync(firstEventJson);
    // Write more events here, then end the input stream.
    input.Writer.Complete();
});

using var response = await client.InvokeModelWithBidirectionalStreamAsync(request);
await foreach (var item in response.Body)
{
    if (item is BidirectionalOutputPayloadPart part)
    {
        Console.WriteLine(Encoding.UTF8.GetString(part.Bytes.ToArray()));
    }
}
```

## Microsoft.Extensions.AI

Besides the low-level client shown above, the [AWS.Bedrock.MEAI](https://www.nuget.org/packages/AWS.Bedrock.MEAI) package lets you use Bedrock models through `Microsoft.Extensions.AI` abstractions such as `IChatClient` and `IEmbeddingGenerator`.

## Resources

- [HTTP/2 support in the AWS SDK for .NET](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/http2-support.html)
- [Amazon Bedrock Runtime code examples](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/csharp_bedrock-runtime_code_examples.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
