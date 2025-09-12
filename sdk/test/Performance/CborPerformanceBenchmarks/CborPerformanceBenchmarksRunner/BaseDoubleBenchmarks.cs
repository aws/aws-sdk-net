using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using System.Net;
using System.Text;


// Allowing us to run two benchmarks in the same class, as some benchmarks depends on another one
public abstract class BaseDoubleBenchmarks : BaseBenchmarks
{
    public abstract string TestCase2 { get; }
    public long RequestSizeBytes2 { get; set; }
    public long ResponseSizeBytes2 { get; set; }
    public Stream ResponseStream2 { get; set; }
    public IRequest MarshalledRequest2 { get; set; }


    [IterationSetup(Target = nameof(Marshall2))]
    public virtual void BeforeMarshallIteration2()
    {
        IterationCount++;
        GenerateRequest2();
    }

    public abstract byte[] Marshall2();


    [GlobalCleanup(Target = nameof(Marshall2))]
    public virtual void AfterMarshall2()
    {
#if USE_CBOR
        RequestSizeBytes2 = Math.Max(RequestSizeBytes2, MarshalledRequest2.Content.Length);
#else
        if (Protocol == "Query")
        {
            string queryString = Utils.GetParametersAsString(MarshalledRequest2.ParameterCollection);
            var content = Encoding.UTF8.GetBytes(queryString);

            RequestSizeBytes2 = Math.Max(RequestSizeBytes2, content.Length);
        }
        else if (Protocol == "JSON")
        {
            RequestSizeBytes2 = Math.Max(RequestSizeBytes2, MarshalledRequest2.Content.Length);
        }
        else
        {
            throw new NotImplementedException();
        }
#endif
        var record = new BenchmarkRecord(Service, TestCase2, Protocol, DimensionValue, "Request payload size (bytes)", RequestSizeBytes2, RequestSizeBytes2, RequestSizeBytes2);
        Utils.StoreBenchmarkRecords(new List<BenchmarkRecord> { record });
        RequestSizeBytes2 = 0;
    }


    [GlobalSetup(Target = nameof(TotalRequest2))]
    public virtual void BeforeTotalRequest2()
    {
        IterationCount = 0;
        CreateServiceClient();
    }

    [IterationSetup(Target = nameof(TotalRequest2))]
    public virtual void TotalRequestBeforeIteration2()
    {
        IterationCount++;
        GenerateRequest2();
    }

    public abstract Task<AmazonWebServiceResponse> TotalRequest2();

    [GlobalCleanup(Target = nameof(TotalRequest2))]
    public virtual void AfterTotalRequest2()
    {
        var record = new BenchmarkRecord(Service, TestCase2, Protocol, DimensionValue, "Response payload size (bytes)", ResponseSizeBytes2, ResponseSizeBytes2, ResponseSizeBytes2);
        Utils.StoreBenchmarkRecords(new List<BenchmarkRecord> { record });
        ResponseSizeBytes2 = 0;
    }

    public abstract void GenerateRequest2();



    [GlobalSetup(Target = nameof(Unmarshall2))]
    public virtual async Task BeforeUnmarshall2()
    {
        IterationCount = 0;
        IterationCount++;

        ResponseStream2 = new MemoryStream();
        RuntimePipelineCustomizerRegistry.Instance.Register(new PipelineCustomizer(ResponseStream2));

        // Recreate the service client to pick up the new pipeline handler.
        CreateServiceClient();
        GenerateRequest2();
        try
        {
            // Make a request and copy the response to the ResponseStream
            await TotalRequest2();
        }
        catch (ApplicationException)
        {
            // We expected this exception as we have already read and stored the stream.
        }
    }

    [IterationSetup(Target = nameof(Unmarshall2))]
    public virtual void BeforeUnmarshallIteration2()
    {
        var webResponseData = new FakeWebResponseData();
        webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
        ResponseStream2.Position = 0;
#if USE_CBOR
        UnmarshallerContext = new Amazon.Extensions.CborProtocol.Internal.Transform.CborUnmarshallerContext(ResponseStream2, true, webResponseData);
#else
        if (Service == "CloudWatch")
            UnmarshallerContext = new XmlUnmarshallerContext(ResponseStream2, true, webResponseData);
        else
            UnmarshallerContext = new JsonUnmarshallerContext(ResponseStream2, true, webResponseData);
#endif
    }

    public abstract AmazonWebServiceResponse Unmarshall2();


    [GlobalCleanup(Target = nameof(Unmarshall2))]
    public virtual void AfterUnmarshall2()
    {
        RuntimePipelineCustomizerRegistry.Instance.Deregister(PipelineCustomizer.UniqueName);
    }
}
