using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;

namespace SQSBenchmarks;

[MemoryDiagnoser]
[Config(typeof(Config))]
public class S3PutLifecycleBenchmark
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

    [Params(10, 100, 500, 1000)]
    public int RuleCount { get; set; }

    private PutLifecycleConfigurationRequest _request;

    [GlobalSetup]
    public async Task Setup()
    {
        _client = new AmazonS3Client(RegionEndpoint.USEast1);

        _bucketName = $"benchmark-bucket-{Guid.NewGuid():N}";
        await _client.PutBucketAsync(new PutBucketRequest { BucketName = _bucketName });

        // Enable versioning (required for NoncurrentVersionExpiration rules)
        await _client.PutBucketVersioningAsync(new PutBucketVersioningRequest
        {
            BucketName = _bucketName,
            VersioningConfig = new S3BucketVersioningConfig { Status = VersionStatus.Enabled }
        });

        _request = new PutLifecycleConfigurationRequest
        {
            BucketName = _bucketName,
            Configuration = new LifecycleConfiguration
            {
                Rules = Enumerable.Range(0, RuleCount).Select(i => new LifecycleRule
                {
                    Id = $"rule-{i:D4}",
                    Status = LifecycleRuleStatus.Enabled,
                    Filter = new LifecycleFilter
                    {
                        LifecycleFilterPredicate = new LifecyclePrefixPredicate
                        {
                            Prefix = $"prefix-{i:D4}/"
                        }
                    },
                    Transitions = new List<LifecycleTransition>
                    {
                        new LifecycleTransition
                        {
                            Days = 30,
                            StorageClass = S3StorageClass.StandardInfrequentAccess
                        },
                        new LifecycleTransition
                        {
                            Days = 90,
                            StorageClass = S3StorageClass.Glacier
                        }
                    },
                    NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration
                    {
                        NoncurrentDays = 365
                    }
                }).ToList()
            }
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

    [Benchmark(Description = "PutLifecycleConfiguration")]
    public async Task<PutLifecycleConfigurationResponse> PutLifecycleConfiguration()
    {
        return await _client.PutLifecycleConfigurationAsync(_request);
    }
}
