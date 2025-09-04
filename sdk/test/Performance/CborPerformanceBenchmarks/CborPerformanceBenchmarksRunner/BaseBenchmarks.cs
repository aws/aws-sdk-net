using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Net;
using System.Text;

[MemoryDiagnoser]
public abstract class BaseBenchmarks
{
    public abstract int DimensionValue { get; set; }
    public abstract string Service { get; }
    public abstract string TestCase { get; }

    public virtual string Protocol { get; } =
#if USE_CBOR
             "CBOR";
#else
             "JSON";
#endif

    public UnmarshallerContext UnmarshallerContext { get; set; }
    public IRequest MarshalledRequest { get; set; }
    public long RequestSizeBytes { get; set; }
    public long ResponseSizeBytes { get; set; }
    public int IterationCount { get; set; }
    public Stream ResponseStream { get; set; }
    
    public abstract void CreateServiceClient();


    [IterationSetup(Target = nameof(Marshall))]
    public virtual void BeforeMarshallIteration()
    {
        IterationCount++;
        GenerateRequest();
    }

    public abstract byte[] Marshall();


    [GlobalCleanup(Target = nameof(Marshall))]
    public virtual void AfterMarshall()
    {
#if USE_CBOR
        RequestSizeBytes = Math.Max(RequestSizeBytes, MarshalledRequest.Content.Length);
#else
        if (Protocol == "Query")
        {
            string queryString = Utils.GetParametersAsString(MarshalledRequest.ParameterCollection);
            var content = Encoding.UTF8.GetBytes(queryString);

            RequestSizeBytes = Math.Max(RequestSizeBytes, content.Length);
        }
        else if (Protocol == "JSON")
        {
            RequestSizeBytes = Math.Max(RequestSizeBytes, MarshalledRequest.Content.Length);
        }
        else
        {
            throw new NotImplementedException();
        }
#endif
        var record = new BenchmarkRecord(Service, TestCase, Protocol, DimensionValue, "Request payload size (bytes)", RequestSizeBytes, RequestSizeBytes, RequestSizeBytes);
        Utils.StoreBenchmarkRecords(new List<BenchmarkRecord> { record });
        RequestSizeBytes = 0;
    }


    [GlobalSetup(Target = nameof(TotalRequest))]
    public virtual void BeforeTotalRequest()
    {
        IterationCount = 0;
        CreateServiceClient();
    }

    [IterationSetup(Target = nameof(TotalRequest))]
    public virtual void TotalRequestBeforeIteration()
    {
        IterationCount++;
        GenerateRequest();
    }

    public abstract Task<AmazonWebServiceResponse> TotalRequest();

    [GlobalCleanup(Target = nameof(TotalRequest))]
    public virtual void AfterTotalRequest()
    {
        var record = new BenchmarkRecord(Service, TestCase, Protocol, DimensionValue, "Response payload size (bytes)", ResponseSizeBytes, ResponseSizeBytes, ResponseSizeBytes);
        Utils.StoreBenchmarkRecords(new List<BenchmarkRecord>{ record });
        ResponseSizeBytes = 0;
    }

    public abstract void GenerateRequest();



    [GlobalSetup(Target = nameof(Unmarshall))]
    public virtual async Task BeforeUnmarshall()
    {
        IterationCount = 0;
        IterationCount++;

        ResponseStream = new MemoryStream();
        RuntimePipelineCustomizerRegistry.Instance.Register(new PipelineCustomizer(ResponseStream));

        // Recreate the service client to pick up the new pipeline handler.
        CreateServiceClient();
        GenerateRequest();
        try
        {
            // Make a request and copy the response to the ResponseStream
            await TotalRequest();
        }
        catch (ApplicationException)
        {
            // We expected this exception as we have already read and stored the stream.
        }
    }

    [IterationSetup(Target = nameof(Unmarshall))]
    public virtual void BeforeUnmarshallIteration()
    {
        var webResponseData = new FakeWebResponseData();
        webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
        ResponseStream.Position = 0;
#if USE_CBOR
        UnmarshallerContext = new Amazon.Extensions.CborProtocol.Internal.Transform.CborUnmarshallerContext(ResponseStream, true, webResponseData);
#else
        if (Service == "CloudWatch")
            UnmarshallerContext = new XmlUnmarshallerContext(ResponseStream, true, webResponseData);
        else
            UnmarshallerContext = new JsonUnmarshallerContext(ResponseStream, true, webResponseData);
#endif
    }

    public abstract AmazonWebServiceResponse Unmarshall();


    [GlobalCleanup(Target = nameof(Unmarshall))]
    public virtual void AfterUnmarshall()
    {
        RuntimePipelineCustomizerRegistry.Instance.Deregister(PipelineCustomizer.UniqueName);
    }

}

public class PipelineCustomizer : IRuntimePipelineCustomizer
{
    public const string UniqueName = "Benchmark Registration Customization";
    private Stream responseStream;

    public PipelineCustomizer(Stream responseStream)
    {
        this.responseStream = responseStream;
    }

    string IRuntimePipelineCustomizer.UniqueName => UniqueName;

    public void Customize(Type type, RuntimePipeline pipeline)
    {
        pipeline.AddHandlerAfter<Unmarshaller>(new BenchmarkPipelineHandler(responseStream));
    }
}

public class BenchmarkPipelineHandler : PipelineHandler
{
    private Stream responseStream;

    public BenchmarkPipelineHandler(Stream responseStream)
    {
        this.responseStream = responseStream;
    }

    public override void InvokeSync(IExecutionContext executionContext)
    {
        base.InvokeSync(executionContext);
        ReadResponseStream(executionContext);

        throw new ApplicationException(); // throw an exception to avoid reading the stream again;
    }

    public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
    {
        await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        await ReadResponseStreamAsync(executionContext).ConfigureAwait(false);

        throw new ApplicationException(); // throw an exception to avoid reading the stream again;
    }

    private void ReadResponseStream(IExecutionContext executionContext)
    {
        var stream = executionContext.ResponseContext.HttpResponse.
                       ResponseBody.OpenResponse();

        stream.CopyTo(responseStream);
    }


    private async Task ReadResponseStreamAsync(IExecutionContext executionContext)
    {
        var stream = await executionContext.ResponseContext.HttpResponse.
                       ResponseBody.OpenResponseAsync();

        await stream.CopyToAsync(responseStream);
    }
}