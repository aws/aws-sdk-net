/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Text;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for the real Amazon SQS client wire protocol
/// (awsJson1.0 with the <c>X-Amz-Query-Mode</c> migration header).
///
/// Covers the four operations that dominate live SQS traffic:
///   * SendMessage (single + with attributes + large body)
///   * SendMessageBatch (10 entries, the SQS hard limit)
///   * DeleteMessageBatch / ChangeMessageVisibilityBatch (cheap batch shape)
///   * ReceiveMessage response unmarshalling
///
/// Marshall benchmarks measure <c>Marshaller.Instance.Marshall(request)</c>
/// — i.e. the JSON body + headers built into <c>IRequest.Content</c>.
/// Unmarshall benchmarks feed a captured byte[] through a <c>JsonUnmarshallerContext</c>
/// just as <see cref="AwsJson10Benchmarks"/> does, so we never touch the network.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class SqsBenchmarks
{
    private const string QueueUrl = "https://sqs.us-east-1.amazonaws.com/123456789012/benchmark-queue";

    // --- SendMessage ---
    private SendMessageRequest _sendSmall = null!;
    private SendMessageRequest _sendMedium = null!;
    private SendMessageRequest _sendLarge = null!;
    private SendMessageRequest _sendWithAttrs = null!;
    private SendMessageRequest _sendFifo = null!;

    // --- Batches ---
    private SendMessageBatchRequest _sendBatch10 = null!;
    private SendMessageBatchRequest _sendBatch10WithAttrs = null!;
    private DeleteMessageBatchRequest _deleteBatch10 = null!;
    private ChangeMessageVisibilityBatchRequest _cmvBatch10 = null!;

    // --- ReceiveMessage responses ---
    private byte[] _recvEmptyBytes = null!;
    private byte[] _recv1NoAttrsBytes = null!;
    private byte[] _recv10NoAttrsBytes = null!;
    private byte[] _recv10WithAttrsBytes = null!;
    private byte[] _recv1LargeBodyBytes = null!;

    [GlobalSetup]
    public void Setup()
    {
        _sendSmall = new SendMessageRequest { QueueUrl = QueueUrl, MessageBody = "hello world" };
        _sendMedium = new SendMessageRequest { QueueUrl = QueueUrl, MessageBody = new string('x', 1024) };
        // 256 KiB is the SQS per-message hard limit
        _sendLarge = new SendMessageRequest { QueueUrl = QueueUrl, MessageBody = new string('x', 256 * 1024) };

        _sendWithAttrs = new SendMessageRequest
        {
            QueueUrl = QueueUrl,
            MessageBody = "payload",
            MessageAttributes = BuildStringAttributes(5),
        };

        _sendFifo = new SendMessageRequest
        {
            QueueUrl = QueueUrl,
            MessageBody = "fifo payload",
            MessageGroupId = "group-1",
            MessageDeduplicationId = "dedup-1234567890",
        };

        _sendBatch10 = new SendMessageBatchRequest
        {
            QueueUrl = QueueUrl,
            Entries = BuildSendBatchEntries(10, withAttributes: false),
        };
        _sendBatch10WithAttrs = new SendMessageBatchRequest
        {
            QueueUrl = QueueUrl,
            Entries = BuildSendBatchEntries(10, withAttributes: true),
        };
        _deleteBatch10 = new DeleteMessageBatchRequest
        {
            QueueUrl = QueueUrl,
            Entries = BuildDeleteBatchEntries(10),
        };
        _cmvBatch10 = new ChangeMessageVisibilityBatchRequest
        {
            QueueUrl = QueueUrl,
            Entries = BuildCmvBatchEntries(10),
        };

        _recvEmptyBytes = Encoding.UTF8.GetBytes("{}");
        _recv1NoAttrsBytes = Encoding.UTF8.GetBytes(BuildReceiveMessageJson(1, bodySize: 64, withAttrs: false));
        _recv10NoAttrsBytes = Encoding.UTF8.GetBytes(BuildReceiveMessageJson(10, bodySize: 256, withAttrs: false));
        _recv10WithAttrsBytes = Encoding.UTF8.GetBytes(BuildReceiveMessageJson(10, bodySize: 256, withAttrs: true));
        _recv1LargeBodyBytes = Encoding.UTF8.GetBytes(BuildReceiveMessageJson(1, bodySize: 256 * 1024, withAttrs: false));
    }

    // ---------- SendMessage ----------
    [Benchmark] public void Sqs_SendMessage_Small() => SendMessageRequestMarshaller.Instance.Marshall(_sendSmall);
    [Benchmark] public void Sqs_SendMessage_Medium_1KB() => SendMessageRequestMarshaller.Instance.Marshall(_sendMedium);
    [Benchmark] public void Sqs_SendMessage_Large_256KB() => SendMessageRequestMarshaller.Instance.Marshall(_sendLarge);
    [Benchmark] public void Sqs_SendMessage_WithAttributes() => SendMessageRequestMarshaller.Instance.Marshall(_sendWithAttrs);
    [Benchmark] public void Sqs_SendMessage_Fifo() => SendMessageRequestMarshaller.Instance.Marshall(_sendFifo);

    // ---------- Batches ----------
    [Benchmark] public void Sqs_SendMessageBatch_10() => SendMessageBatchRequestMarshaller.Instance.Marshall(_sendBatch10);
    [Benchmark] public void Sqs_SendMessageBatch_10_WithAttributes() => SendMessageBatchRequestMarshaller.Instance.Marshall(_sendBatch10WithAttrs);
    [Benchmark] public void Sqs_DeleteMessageBatch_10() => DeleteMessageBatchRequestMarshaller.Instance.Marshall(_deleteBatch10);
    [Benchmark] public void Sqs_ChangeMessageVisibilityBatch_10() => ChangeMessageVisibilityBatchRequestMarshaller.Instance.Marshall(_cmvBatch10);

    // ---------- ReceiveMessage (response unmarshalling) ----------
    [Benchmark] public void Sqs_ReceiveMessage_Empty() => UnmarshallReceiveMessage(_recvEmptyBytes);
    [Benchmark] public void Sqs_ReceiveMessage_1Msg_NoAttrs() => UnmarshallReceiveMessage(_recv1NoAttrsBytes);
    [Benchmark] public void Sqs_ReceiveMessage_10Msgs_NoAttrs() => UnmarshallReceiveMessage(_recv10NoAttrsBytes);
    [Benchmark] public void Sqs_ReceiveMessage_10Msgs_WithAttrs() => UnmarshallReceiveMessage(_recv10WithAttrsBytes);
    [Benchmark] public void Sqs_ReceiveMessage_1Msg_LargeBody_256KB() => UnmarshallReceiveMessage(_recv1LargeBodyBytes);

    // ---------- helpers ----------

    private static void UnmarshallReceiveMessage(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        var wr = new WebResponseData
        {
            Headers =
            {
                { "x-amzn-RequestId", "test-id" },
                { "Content-Length", bytes.Length.ToString() },
                { "Content-Type", "application/x-amz-json-1.0" },
            },
        };
        using var ctx = new JsonUnmarshallerContext(stream, false, wr);
        ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    private static Dictionary<string, MessageAttributeValue> BuildStringAttributes(int count)
    {
        var dict = new Dictionary<string, MessageAttributeValue>(count);
        for (int i = 0; i < count; i++)
        {
            dict[$"attr_{i}"] = new MessageAttributeValue
            {
                DataType = "String",
                StringValue = $"value-{i}",
            };
        }
        return dict;
    }

    private static List<SendMessageBatchRequestEntry> BuildSendBatchEntries(int count, bool withAttributes)
    {
        var list = new List<SendMessageBatchRequestEntry>(count);
        for (int i = 0; i < count; i++)
        {
            var entry = new SendMessageBatchRequestEntry
            {
                Id = $"msg-{i}",
                MessageBody = $"batch payload {i} " + new string('x', 256),
            };
            if (withAttributes)
                entry.MessageAttributes = BuildStringAttributes(3);
            list.Add(entry);
        }
        return list;
    }

    private static List<DeleteMessageBatchRequestEntry> BuildDeleteBatchEntries(int count)
    {
        var list = new List<DeleteMessageBatchRequestEntry>(count);
        for (int i = 0; i < count; i++)
        {
            list.Add(new DeleteMessageBatchRequestEntry
            {
                Id = $"msg-{i}",
                ReceiptHandle = "AQEB" + new string('a', 180),
            });
        }
        return list;
    }

    private static List<ChangeMessageVisibilityBatchRequestEntry> BuildCmvBatchEntries(int count)
    {
        var list = new List<ChangeMessageVisibilityBatchRequestEntry>(count);
        for (int i = 0; i < count; i++)
        {
            list.Add(new ChangeMessageVisibilityBatchRequestEntry
            {
                Id = $"msg-{i}",
                ReceiptHandle = "AQEB" + new string('a', 180),
                VisibilityTimeout = 30 + i,
            });
        }
        return list;
    }

    private static string BuildReceiveMessageJson(int messageCount, int bodySize, bool withAttrs)
    {
        if (messageCount == 0)
            return "{\"Messages\":[]}";

        var sb = new StringBuilder(64 + messageCount * (bodySize + 256));
        sb.Append("{\"Messages\":[");
        for (int i = 0; i < messageCount; i++)
        {
            if (i > 0) sb.Append(',');
            sb.Append('{');
            sb.Append("\"MessageId\":\"").Append("00000000-0000-0000-0000-").Append(i.ToString("D12")).Append('"');
            sb.Append(",\"ReceiptHandle\":\"AQEB").Append('a', 180).Append('"');
            sb.Append(",\"MD5OfBody\":\"098f6bcd4621d373cade4e832627b4f6\"");
            sb.Append(",\"Body\":\"").Append('x', bodySize).Append('"');
            sb.Append(",\"Attributes\":{")
              .Append("\"SenderId\":\"AIDAEXAMPLE\",")
              .Append("\"SentTimestamp\":\"1700000000000\",")
              .Append("\"ApproximateReceiveCount\":\"1\",")
              .Append("\"ApproximateFirstReceiveTimestamp\":\"1700000000001\"")
              .Append('}');
            if (withAttrs)
            {
                sb.Append(",\"MD5OfMessageAttributes\":\"abcdef0123456789abcdef0123456789\"");
                sb.Append(",\"MessageAttributes\":{");
                for (int a = 0; a < 3; a++)
                {
                    if (a > 0) sb.Append(',');
                    sb.Append("\"attr_").Append(a).Append("\":{");
                    sb.Append("\"DataType\":\"String\",");
                    sb.Append("\"StringValue\":\"value-").Append(a).Append('"');
                    sb.Append('}');
                }
                sb.Append('}');
            }
            sb.Append('}');
        }
        sb.Append("]}");
        return sb.ToString();
    }
}
