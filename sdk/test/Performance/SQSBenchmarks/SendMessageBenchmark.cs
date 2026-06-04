using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;

namespace SQSBenchmarks;

[MemoryDiagnoser]
[Config(typeof(Config))]
public class SendMessageBenchmark
{
    private class Config : ManualConfig
    {
        public Config()
        {
            AddColumn(StatisticColumn.P50);
            AddColumn(StatisticColumn.P90);
        }
    }

    private IAmazonSQS _client;
    private string _queueUrl;

    [Params("small", "medium", "large", "xlarge")]
    public string PayloadSize { get; set; }

    private string _messageBody;

    [GlobalSetup]
    public async Task Setup()
    {
        _client = new AmazonSQSClient(RegionEndpoint.USEast1);

        // Create a temporary queue for benchmarking
        var createResponse = await _client.CreateQueueAsync(new CreateQueueRequest
        {
            QueueName = $"benchmark-queue-{Guid.NewGuid():N}"
        });
        _queueUrl = createResponse.QueueUrl;

        _messageBody = PayloadSize switch
        {
            "small" => GeneratePayload(256),       // 256 bytes
            "medium" => GeneratePayload(4096),     // 4 KB
            "large" => GeneratePayload(65536),     // 64 KB
            "xlarge" => GeneratePayload(262144),   // 256 KB (SQS max message size)
            _ => throw new ArgumentException($"Unknown payload size: {PayloadSize}")
        };
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        if (_queueUrl != null)
        {
            await _client.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = _queueUrl });
        }
        _client?.Dispose();
    }

    [Benchmark(Description = "SendMessage")]
    public async Task<SendMessageResponse> SendMessage()
    {
        return await _client.SendMessageAsync(new SendMessageRequest
        {
            QueueUrl = _queueUrl,
            MessageBody = _messageBody
        });
    }

    [Benchmark(Description = "SendMessageBatch")]
    public async Task<SendMessageBatchResponse> SendMessageBatch()
    {
        // SQS batch limit is 1MB total across all entries
        var maxEntries = Math.Min(5, 1_048_576 / _messageBody.Length);
        var entries = new List<SendMessageBatchRequestEntry>();
        for (int i = 0; i < maxEntries; i++)
        {
            entries.Add(new SendMessageBatchRequestEntry { Id = (i + 1).ToString(), MessageBody = _messageBody });
        }

        return await _client.SendMessageBatchAsync(new SendMessageBatchRequest
        {
            QueueUrl = _queueUrl,
            Entries = entries
        });
    }

    private static string GeneratePayload(int length)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random(42);
        var buffer = new char[length];
        for (int i = 0; i < length; i++)
        {
            buffer[i] = chars[random.Next(chars.Length)];
        }
        return new string(buffer);
    }
}
