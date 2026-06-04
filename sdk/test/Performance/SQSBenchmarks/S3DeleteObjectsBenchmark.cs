using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;

namespace SQSBenchmarks;

[MemoryDiagnoser]
[Config(typeof(Config))]
public class S3DeleteObjectsBenchmark
{
    private class Config : ManualConfig
    {
        public Config()
        {
            AddColumn(StatisticColumn.P50);
            AddColumn(StatisticColumn.P90);
        }
    }

    private IAmazonS3 _client;
    private string _bucketName;

    [Params(10, 100, 500, 900)]
    public int ObjectCount { get; set; }

    private DeleteObjectsRequest _request;

    [GlobalSetup]
    public async Task Setup()
    {
        _client = new AmazonS3Client(RegionEndpoint.USEast1);

        _bucketName = $"benchmark-bucket-{Guid.NewGuid():N}";
        await _client.PutBucketAsync(new PutBucketRequest { BucketName = _bucketName });

        _request = new DeleteObjectsRequest
        {
            BucketName = _bucketName,
            Quiet = true,
            Objects = Enumerable.Range(0, ObjectCount)
                .Select(i => new KeyVersion { Key = $"obj-{i:D4}" })
                .ToList()
        };
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        if (_bucketName != null)
        {
            try { await _client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = _bucketName }); }
            catch { }
        }
        _client?.Dispose();
    }

    [Benchmark(Description = "DeleteObjects")]
    public async Task<DeleteObjectsResponse> DeleteObjects()
    {
        return await _client.DeleteObjectsAsync(_request);
    }
}
