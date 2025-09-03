using System.Text;
using BenchmarkDotNet.Attributes;
using Amazon.Runtime;
using Amazon.SecretsManager.Model;
using Amazon.SecretsManager.Model.Internal.MarshallTransformations;
using Amazon.SecretsManager;
using Amazon;

namespace CborPerformanceBenchmarksRunner.SecretsManagerBenchmarks;

public class ListSecretsBenchmarks : BaseBenchmarks
{
    [Params(0)]
    public override int DimensionValue { get; set; }

    public override string Service { get; } = "SecretsManager";

    protected IAmazonSecretsManager _client;


    public override void CreateServiceClient()
    {
        _client = new AmazonSecretsManagerClient(new AmazonSecretsManagerConfig
        {
            DisableRequestCompression = true,
            MaxErrorRetry = 0,
            RegionEndpoint = RegionEndpoint.USWest2,
        });
    }

    public override string TestCase { get; } = "List secrets";

    protected ListSecretsRequest request;

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall()
    {
        var iRequest = ListSecretsRequestMarshaller.Instance.Marshall(request);
        MarshalledRequest = iRequest;

        return iRequest.Content;
    }

    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest()
    {
        var response = await _client.ListSecretsAsync(request);
        ResponseSizeBytes = Math.Max(ResponseSizeBytes, response.ContentLength);

        return response;
    }

    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall()
    {
        var response = ListSecretsResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }

    public override void GenerateRequest()
    {
        request = new ListSecretsRequest()
        {
            Filters = new List<Filter>
            {
                new Filter
                {
                    Key = FilterNameStringType.TagKey,
                    Values = ["Iteration"]
                },
                new Filter
                {
                    Key = FilterNameStringType.TagValue,
                    Values = [IterationCount.ToString("D3")]
                },
            }
        };
    }
}