using Amazon;
using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using BenchmarkDotNet.Attributes;

namespace CborPerformanceBenchmarksRunner.CloudWatchBenchmarks;

public class PutAndGetMetricDataBenchmarks : BaseDoubleBenchmarks
{
    [Params(16, 64, 256, 1000)]
    public override int DimensionValue { get; set; }
    public override string Protocol { get; } =
#if USE_CBOR
        "CBOR";
#else
        "Query";
#endif

    public static string SuiteId { get; set; } = Guid.NewGuid().ToString();
    public static DateTime BaseTime { get; set; } = DateTime.Now.AddHours(-2);

    public override string Service { get; } = "CloudWatch";
    public override string TestCase { get; } = "Put metric data";
    public override string TestCase2 { get; } = "Get metric data";

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

    private PutMetricDataRequest request;

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall()
    {
        var iRequest = PutMetricDataRequestMarshaller.Instance.Marshall(request);
        MarshalledRequest = iRequest;

        return iRequest.Content;
    }

    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest()
    {
        var response = await _client.PutMetricDataAsync(request);
        ResponseSizeBytes = Math.Max(ResponseSizeBytes, response.ContentLength);

        return response;
    }

    public override void GenerateRequest()
    {
        var rng = Random.Shared;

        request = new PutMetricDataRequest()
        {
            Namespace = "TestNamespace",
            MetricData =
            Enumerable.Range(1, DimensionValue).Select(i =>
            new MetricDatum
            {
                MetricName = "TestMetric",
                Dimensions = new List<Dimension>
                {
                    new Dimension
                    {
                        Name = "TestDimension",
                        Value = $"{SuiteId}-{DimensionValue}"
                    }
                },
                Unit = "None",
                Timestamp = BaseTime.AddSeconds(2 * (i + 1)),
                Value = rng.NextDouble(),
            }).ToList()
        };
    }

    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall()
    {
        var response = PutMetricDataResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }

    private GetMetricDataRequest request2;

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall2()
    {
        var iRequest = GetMetricDataRequestMarshaller.Instance.Marshall(request2);
        MarshalledRequest2 = iRequest;

        return iRequest.Content;
    }

    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest2()
    {
        var response = await _client.GetMetricDataAsync(request2);
        ResponseSizeBytes2 = Math.Max(ResponseSizeBytes2, response.ContentLength);

        return response;
    }

    public override void GenerateRequest2()
    {
        request2 = new GetMetricDataRequest
        {
            StartTime = BaseTime,
            EndTime = BaseTime.AddHours(1),
            MetricDataQueries = new List<MetricDataQuery>
            {
                new MetricDataQuery
                {
                    Id = "m0",
                    ReturnData = true,
                    MetricStat = new MetricStat
                    {
                        Unit = "None",
                        Stat = "Sum",
                        Period = 60,
                        Metric = new Amazon.CloudWatch.Model.Metric
                        {
                            Namespace = "TestNamespace",
                            MetricName = "TestMetric",
                            Dimensions = new List<Dimension>
                            {
                                new Dimension
                                {
                                    Name = "TestDimension",
                                    Value = $"{SuiteId}-{DimensionValue}"
                                }
                            }
                        }
                    }
                }
            }
        };
    }

    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall2()
    {
        var response = GetMetricDataResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }


    public override void TotalRequestBeforeIteration()
    {
        if (IterationCount % 50 == 0)
        {
            Thread.Sleep(2000); // Sleep 2 seconds every 50 iterations to avoid throttling
        }
        base.TotalRequestBeforeIteration();
    }

    public override void TotalRequestBeforeIteration2()
    {
        if (IterationCount % 50 == 0)
        {
            Thread.Sleep(2000); // Sleep 2 seconds every 50 iterations to avoid throttling
        }
        base.TotalRequestBeforeIteration2();
    }
}