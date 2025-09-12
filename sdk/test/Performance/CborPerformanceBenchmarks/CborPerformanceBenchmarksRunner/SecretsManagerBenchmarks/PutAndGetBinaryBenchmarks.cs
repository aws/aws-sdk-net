using Amazon.SecretsManager.Model;
using System.Security.Cryptography;

namespace CborPerformanceBenchmarksRunner.SecretsManagerBenchmarks;

public class PutAndGetBinaryBenchmarks: PutAndGetStringBenchmarks
{
    public override string TestCase { get; } = "Put binary secret";
    public override string TestCase2 { get; } = "Get binary secret";

    public override void GenerateRequest()
    {
        request = new PutSecretValueRequest()
        {
            SecretId = $"TestBinarySecret_{Utils.RunStartTimestamp}_{IterationCount.ToString("D3")}"
        };

        var rng = RandomNumberGenerator.Create();
        byte[] buffer = new byte[DimensionValue];
        rng.GetBytes(buffer);

        request.SecretBinary = new MemoryStream(buffer);
    }

    public override void GenerateRequest2()
    {
        request2 = new GetSecretValueRequest()
        {
            SecretId = $"TestBinarySecret_{Utils.RunStartTimestamp}_{IterationCount.ToString("D3")}"
        };
    }
}