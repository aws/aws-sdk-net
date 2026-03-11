using BenchmarkDotNet.Attributes;
using Amazon.Runtime;
using Amazon.SecretsManager.Model;
using Amazon.SecretsManager.Model.Internal.MarshallTransformations;
using Amazon.SecretsManager;
using Amazon;

namespace CborPerformanceBenchmarksRunner.SecretsManagerBenchmarks;

public class DescribeSecretBenchmarks : BaseBenchmarks
{
    [Params(0)]
    public override int DimensionValue { get; set; }

    public override string Service { get; } = "SecretsManager";
    public override string TestCase { get; } = "Describe secret";

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

    protected DescribeSecretRequest request;

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall()
    {
        var iRequest = DescribeSecretRequestMarshaller.Instance.Marshall(request);
        MarshalledRequest = iRequest;

        return iRequest.Content;
    }

    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest()
    {
        var response = await _client.DescribeSecretAsync(request);
        ResponseSizeBytes = Math.Max(ResponseSizeBytes, response.ContentLength);

        return response;
    }

    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall()
    {
        var response = DescribeSecretResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }

    public override void GenerateRequest()
    {
        request = new DescribeSecretRequest()
        {
            SecretId = $"TestSecret_{Utils.RunStartTimestamp}_{IterationCount.ToString("D3")}"
        };
    }
}