using Amazon;
using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using BenchmarkDotNet.Attributes;

namespace CborPerformanceBenchmarksRunner.CloudWatchBenchmarks;

public class ListMetricsBenchmarks : BaseBenchmarks
{
    [Params(0)]
    public override int DimensionValue { get; set; }

    public override string Protocol { get; } =
#if USE_CBOR
        "CBOR";
#else
        "Query";
#endif

    public string SuiteId { get; set; } = Guid.NewGuid().ToString();
    public DateTime BaseTime { get; set; } = DateTime.Now.AddHours(-2);

    public override string Service { get; } = "CloudWatch";
    public override string TestCase { get; } = "List metrics";

    protected IAmazonCloudWatch _client;
    public override void CreateServiceClient()
    {
        _client = new AmazonCloudWatchClient(new AmazonCloudWatchConfig
        {
            DisableRequestCompression = true,
            MaxErrorRetry = 0,
            RegionEndpoint = RegionEndpoint.USWest2,
        });
    }

    private ListMetricsRequest request;

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall()
    {
        var iRequest = ListMetricsRequestMarshaller.Instance.Marshall(request);
        MarshalledRequest = iRequest;

        return iRequest.Content;
    }

    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest()
    {
        var response = await _client.ListMetricsAsync(request);
        ResponseSizeBytes = Math.Max(ResponseSizeBytes, response.ContentLength);

        return response;
    }

    public override void GenerateRequest()
    {
        request = new ListMetricsRequest
        {
            Namespace = "TestNamespace",
        };
    }

    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall()
    {
        var response = ListMetricsResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }

    public override void TotalRequestBeforeIteration()
    {
        if (IterationCount % 25 == 0)
        {
            Thread.Sleep(2000); // Sleep 2 seconds every 25 iterations to avoid throttling
        }
        base.TotalRequestBeforeIteration();
    }
}