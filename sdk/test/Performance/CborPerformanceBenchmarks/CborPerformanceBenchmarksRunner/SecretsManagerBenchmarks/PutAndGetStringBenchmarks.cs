using Amazon;
using Amazon.Runtime;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Amazon.SecretsManager.Model.Internal.MarshallTransformations;
using BenchmarkDotNet.Attributes;
using System.Text;

namespace CborPerformanceBenchmarksRunner.SecretsManagerBenchmarks;

public class PutAndGetStringBenchmarks : BaseDoubleBenchmarks
{
    [Params(64, 512, 4096, 8192, 45056)]
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

    public override string TestCase { get; } = "Put string secret";
    public override string TestCase2 { get; } = "Get string secret";

    protected PutSecretValueRequest request;
    protected GetSecretValueRequest request2;

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall()
    {
        var iRequest = PutSecretValueRequestMarshaller.Instance.Marshall(request);
        MarshalledRequest = iRequest;

        return iRequest.Content;
    }

    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest()
    {
        var response = await _client.PutSecretValueAsync(request);
        ResponseSizeBytes = Math.Max(ResponseSizeBytes, response.ContentLength);

        return response;
    }

    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall()
    {
        var response = PutSecretValueResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }

    public override void GenerateRequest()
    {
        request = new PutSecretValueRequest()
        {
            SecretId = $"TestSecret_{Utils.RunStartTimestamp}_{IterationCount.ToString("D3")}"
        };

        var rng = Random.Shared;
        var sb = new StringBuilder(DimensionValue);
        int currentByteCount = 0;

        while (true)
        {
            char c = (char)rng.Next(32, 127);

            sb.Append(c);
            currentByteCount = Encoding.UTF8.GetByteCount(sb.ToString());

            if (currentByteCount > DimensionValue)
            {
                sb.Length--;
                break;
            }
            if (currentByteCount == DimensionValue)
            {
                break;
            }
        }

        request.SecretString = sb.ToString();
    }

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall2()
    {
        var iRequest = GetSecretValueRequestMarshaller.Instance.Marshall(request2);
        MarshalledRequest2 = iRequest;

        return iRequest.Content;
    }
    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest2()
    {
        var response = await _client.GetSecretValueAsync(request2);
        ResponseSizeBytes2 = Math.Max(ResponseSizeBytes2, response.ContentLength);

        return response;
    }

    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall2()
    {
        var response = GetSecretValueResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }

    public override void GenerateRequest2()
    {
        request2 = new GetSecretValueRequest()
        {
            SecretId = $"TestSecret_{Utils.RunStartTimestamp}_{IterationCount.ToString("D3")}"
        };
    }
}