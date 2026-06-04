using Amazon;
using Amazon.Route53;
using Amazon.Route53.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;

namespace SQSBenchmarks;

[MemoryDiagnoser]
[Config(typeof(Config))]
public class Route53ChangeRecordsBenchmark
{
    private class Config : ManualConfig
    {
        public Config()
        {
            AddColumn(StatisticColumn.P50);
            AddColumn(StatisticColumn.P90);
        }
    }

    private IAmazonRoute53 _client;
    private string _hostedZoneId;
    private int _iterationCount;

    [Params(10, 100, 250, 500)]
    public int RecordCount { get; set; }

    private ChangeResourceRecordSetsRequest _request;

    [GlobalSetup]
    public async Task Setup()
    {
        _client = new AmazonRoute53Client(RegionEndpoint.USEast1);

        var domainName = $"bench-{Guid.NewGuid():N}.sdkbenchtest.com";
        var createResponse = await _client.CreateHostedZoneAsync(new CreateHostedZoneRequest
        {
            Name = domainName,
            CallerReference = Guid.NewGuid().ToString()
        });
        _hostedZoneId = createResponse.HostedZone.Id;

        _request = new ChangeResourceRecordSetsRequest
        {
            HostedZoneId = _hostedZoneId,
            ChangeBatch = new ChangeBatch
            {
                Comment = "Benchmark batch",
                Changes = Enumerable.Range(0, RecordCount).Select(i => new Change
                {
                    Action = ChangeAction.UPSERT,
                    ResourceRecordSet = new ResourceRecordSet
                    {
                        Name = $"record-{i:D4}.{domainName}",
                        Type = RRType.A,
                        TTL = 300,
                        ResourceRecords = new List<ResourceRecord>
                        {
                            new ResourceRecord { Value = $"10.0.{i / 256}.{i % 256}" }
                        }
                    }
                }).ToList()
            }
        };
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        if (_hostedZoneId != null)
        {
            try
            {
                // Delete all non-default records first
                var listResponse = await _client.ListResourceRecordSetsAsync(new ListResourceRecordSetsRequest
                {
                    HostedZoneId = _hostedZoneId
                });

                var deletableRecords = listResponse.ResourceRecordSets
                    .Where(r => r.Type != RRType.NS && r.Type != RRType.SOA)
                    .ToList();

                if (deletableRecords.Count > 0)
                {
                    await _client.ChangeResourceRecordSetsAsync(new ChangeResourceRecordSetsRequest
                    {
                        HostedZoneId = _hostedZoneId,
                        ChangeBatch = new ChangeBatch
                        {
                            Changes = deletableRecords.Select(r => new Change
                            {
                                Action = ChangeAction.DELETE,
                                ResourceRecordSet = r
                            }).ToList()
                        }
                    });
                }

                await _client.DeleteHostedZoneAsync(new DeleteHostedZoneRequest
                {
                    Id = _hostedZoneId
                });
            }
            catch { }
        }
        _client?.Dispose();
    }

    [IterationSetup]
    public void ThrottleIfNeeded()
    {
        if (++_iterationCount % 5 == 0)
        {
            Thread.Sleep(500);
        }
    }

    [Benchmark(Description = "ChangeResourceRecordSets")]
    public async Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSets()
    {
        return await _client.ChangeResourceRecordSetsAsync(_request);
    }
}
