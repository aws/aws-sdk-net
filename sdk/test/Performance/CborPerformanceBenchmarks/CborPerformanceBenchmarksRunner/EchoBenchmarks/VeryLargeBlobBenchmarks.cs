using Amazon.Echo.Model;

namespace CborPerformanceBenchmarksRunner.EchoBenchmarks;

public class VeryLargeBlobBenchmarks : AllTypesBenchmarks
{
    public override string TestCase { get; } = "Very large blob";

    public override void GenerateRequest()
    {
        request = new EchoOperationRequest
        {
            BlobMember = new MemoryStream(GenerateRandomBytes(262144)),
        };
    }
}