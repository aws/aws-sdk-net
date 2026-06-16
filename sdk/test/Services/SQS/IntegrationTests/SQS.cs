using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// xUnit fixture that owns a single <see cref="AmazonSQSClient"/> for the lifetime
    /// of the <see cref="SQSTests"/> class.
    /// </summary>
    public class SQSClientFixture : IAsyncLifetime
    {
        public AmazonSQSClient Client { get; private set; }

        public ValueTask InitializeAsync()
        {
            Client = new AmazonSQSClient();
            RetryUtilities.ConfigureClient(Client);
            return default;
        }

        public ValueTask DisposeAsync()
        {
            Client?.Dispose();
            return default;
        }
    }

    [Trait("Category", "SQS")]
    public class SQSTests : IClassFixture<SQSClientFixture>, IAsyncLifetime
    {
        private const string prefix = "TestQueue";
        private const string defaultTimeout = "30";

        private readonly AmazonSQSClient _client;

        // Tracks every queue URL created by this test instance so DisposeAsync can clean up.
        private readonly List<string> _createdQueueUrls = new List<string>();

        public SQSTests(SQSClientFixture fixture)
        {
            _client = fixture.Client;
        }

        // IAsyncLifetime.InitializeAsync — runs before each test method (replaces [TestInitialize])
        public async ValueTask InitializeAsync()
        {
            var result = await _client.ListQueuesAsync(new ListQueuesRequest());
            Assert.NotNull(result);

            if (result.QueueUrls == null)
            {
                Assert.False(AWSConfigs.InitializeCollections);
            }
            else
            {
                Assert.NotNull(result.QueueUrls);
            }
        }

        [Fact]
        public async Task ListQueues()
        {
            var response = await _client.ListQueuesAsync(new ListQueuesRequest());
            Assert.NotNull(response.ResponseMetadata);
            Assert.NotNull(response.ResponseMetadata.Metadata);

            if (AWSConfigs.InitializeCollections)
            {
                Assert.NotNull(response.QueueUrls);
            }
        }

        // IAsyncLifetime.DisposeAsync — runs after each test method (replaces [TestCleanup])
        public async ValueTask DisposeAsync()
        {
            foreach (var url in _createdQueueUrls)
            {
                try
                {
                    await _client.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = url });
                }
                catch
                {
                    Console.Write("Failed to clean up queue: {0}", url);
                }
            }

            _createdQueueUrls.Clear();
        }

        [Fact]
        public async Task SQSDLQTest()
        {
            string mainQueueName = UtilityMethods.GenerateName(prefix) + "MQ";
            string mainQueueURL = await CreateQueueTest(mainQueueName);

            string deadQueueName = UtilityMethods.GenerateName(prefix) + "DLQ";
            string deadQueueURL = await CreateQueueTest(deadQueueName);
            string deadQueueArn = await GetQueueArn(deadQueueURL);

            string redrivePolicy = string.Format(@"{{""maxReceiveCount"" : 5, ""deadLetterTargetArn"" : ""{0}""}}", deadQueueArn);
            await _client.SetQueueAttributesAsync(new SetQueueAttributesRequest
            {
                QueueUrl = mainQueueURL,
                Attributes = new Dictionary<string, string>
                {
                    { QueueAttributeName.RedrivePolicy, redrivePolicy }
                }
            });

            // Wait a bit to make sure the attribute has fully propagated.
            await Task.Delay(1000);

            var response = await _client.ListDeadLetterSourceQueuesAsync(new ListDeadLetterSourceQueuesRequest
            {
                QueueUrl = deadQueueURL
            });
            Assert.NotNull(response);
            Assert.NotNull(response.QueueUrls);
            Assert.Single(response.QueueUrls);

            var metadata = response.ResponseMetadata;
            Assert.NotNull(metadata);
            Assert.NotNull(metadata.RequestId);
        }

        [Fact]
        public async Task SimpleSend()
        {
            int maxMessageLength = 20 * 1024;
            var queueURL = await CreateQueueTest(UtilityMethods.GenerateName(prefix));

            StringBuilder sb = new StringBuilder("The quick brown fox jumped over the lazy dog");
            string messageBody = sb.ToString();
            if (messageBody.Length > maxMessageLength)
            {
                messageBody = messageBody.Substring(0, maxMessageLength);
            }

            await TestSendMessage(_client, queueURL, messageBody);
            await TestSendMessageBatch(_client, queueURL, messageBody);
            await TestReceiveMessage(_client, queueURL);
        }

        static Dictionary<string, MessageAttributeValue> messageAttributes = new Dictionary<string, MessageAttributeValue>
        {
            { "StringAttribute", new MessageAttributeValue { DataType = "String", StringValue = "StringAttributeValue" } },
            { "NumberAttribute", new MessageAttributeValue { DataType = "Number", StringValue = "1234" } },
            { "BinaryAttribute", new MessageAttributeValue { DataType = "Binary", BinaryValue = new MemoryStream(Encoding.UTF8.GetBytes("BinaryAttributeValue")) } },
            { "UPPERCASESTRINGATTRIBUTE", new MessageAttributeValue { DataType = "String", StringValue = "UPPERCASESTRINGATTRIBUTE" } },
            { "lowercasestringattribute", new MessageAttributeValue { DataType = "String", StringValue = "lowercasestringattribute" } },
        };

        private static async Task TestReceiveMessage(IAmazonSQS client, string queueURL)
        {
            var receiveResponse = await client.ReceiveMessageAsync(new ReceiveMessageRequest { QueueUrl = queueURL });
            var messages = receiveResponse.Messages;
            foreach (var message in messages)
            {
                ValidateMD5(message.Body, message.MD5OfBody);
            }
        }

        private static async Task TestSendMessage(IAmazonSQS client, string queueURL, string messageBody)
        {
            var request = new SendMessageRequest
            {
                MessageBody = messageBody,
                QueueUrl = queueURL,
                MessageAttributes = messageAttributes
            };

            var response = await client.SendMessageAsync(request);
            ValidateMD5(request.MessageBody, response.MD5OfMessageBody);
        }

        private static async Task TestSendMessageBatch(IAmazonSQS client, string queueUrl, string messageBody)
        {
            var request = new SendMessageBatchRequest
            {
                QueueUrl = queueUrl,
                Entries = new List<SendMessageBatchRequestEntry>
                {
                    new SendMessageBatchRequestEntry
                    {
                        MessageBody = messageBody, Id = "fooId"
                    }
                }
            };

            var response = await client.SendMessageBatchAsync(request);
            ValidateMD5(request.Entries[0].MessageBody, response.Successful[0].MD5OfMessageBody);
        }

        private static void ValidateMD5(string message, string md5)
        {
            Amazon.SQS.Internal.ValidationResponseHandler.ValidateMD5(message, md5);
        }

        [Fact]
        public async Task TestGetQueueUrl()
        {
            var queueName = UtilityMethods.GenerateName("TestGetQueueUrl");
            var createResponse = await _client.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = queueName
            });

            _createdQueueUrls.Add(createResponse.QueueUrl);
            var response = await _client.GetQueueUrlAsync(new GetQueueUrlRequest { QueueName = queueName });
            Assert.Equal(createResponse.QueueUrl, response.QueueUrl);
        }

        private async Task<string> GetQueueArn(string queueUrl)
        {
            var getResponse = await _client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                AttributeNames = new List<string> { "All" },
                QueueUrl = queueUrl
            });

            return getResponse.QueueARN;
        }

        private async Task<string> CreateQueueTest(string name)
        {
            var result = await _client.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = name,
                Attributes = new Dictionary<string, string>
                {
                    { SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT, defaultTimeout }
                }
            });
            Assert.NotNull(result);
            Assert.NotNull(result.QueueUrl);
            _createdQueueUrls.Add(result.QueueUrl);

            var attrResults = await _client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                QueueUrl = result.QueueUrl,
                AttributeNames = new List<string> { SQSConstants.ATTRIBUTE_ALL }
            });

            // if a new attribute has been added, then it's necessary to also update
            // SQSConstants and the GetQueueAttributesResponse.Extensions
            Assert.Equal(12, attrResults.Attributes.Count);
            Assert.Equal(int.Parse(defaultTimeout), int.Parse(attrResults.Attributes[SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT]));
            Assert.False(attrResults.FifoQueue);
            Assert.False(attrResults.ContentBasedDeduplication.HasValue);
            Assert.Null(attrResults.ContentBasedDeduplication);

            for (int i = 0; i < 30; i++)
            {
                var listResult = await _client.ListQueuesAsync(new ListQueuesRequest { QueueNamePrefix = prefix });
                if (listResult.QueueUrls.FirstOrDefault(x => x == result.QueueUrl) != null)
                {
                    return result.QueueUrl;
                }

                await Task.Delay(TimeSpan.FromSeconds(2));
            }

            Assert.Fail("Queue never created");
            return "fail";
        }

        [Fact]
        public async Task SQSFIFOTest()
        {
            var fifoQueueName = UtilityMethods.GenerateName(prefix) + ".fifo";
            var result = await _client.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = fifoQueueName,
                Attributes = new Dictionary<string, string>
                {
                    { SQSConstants.ATTRIBUTE_FIFO_QUEUE, "true" },
                    { SQSConstants.ATTRIBUTE_CONTENT_BASED_DEDUPLICATION, "true" }
                }
            });

            Assert.NotNull(result);
            Assert.NotNull(result.QueueUrl);
            _createdQueueUrls.Add(result.QueueUrl);

            var attrResults = await _client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                QueueUrl = result.QueueUrl,
                AttributeNames = new List<string> { SQSConstants.ATTRIBUTE_FIFO_QUEUE, SQSConstants.ATTRIBUTE_CONTENT_BASED_DEDUPLICATION }
            });

            Assert.True(attrResults.FifoQueue);
            Assert.True(attrResults.ContentBasedDeduplication);
        }
    }
}
