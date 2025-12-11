using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    [TestCategory("SQS")]
    public class SQS : TestBase<AmazonSQSClient>
    {
        private const string prefix = "TestQueue";
        private const string defaultTimeout = "30";

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestInitialize]
        public async Task TestInit()
        {
            var result = await Client.ListQueuesAsync(new ListQueuesRequest());
            Assert.IsNotNull(result);

            if (result.QueueUrls == null)
            {
                Assert.IsFalse(AWSConfigs.InitializeCollections);
            }
            else
            {
                Assert.IsNotNull(result.QueueUrls);
            }
        }

        [TestCleanup]
        public async Task SQSCleanup()
        {
            var result = await Client.ListQueuesAsync(new ListQueuesRequest());
            if (result.QueueUrls == null)
            {
                return;
            }

            foreach (string queue in result.QueueUrls)
            {
                if (queue.Contains("TestQueue"))
                {
                    try
                    {
                        await Client.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queue });
                    }
                    catch
                    {
                        Console.Write("Failed to clean up queue {0}", queue);
                    }
                }
            }
        }

        [TestMethod]
        public async Task SQSDLQTest()
        {
            string mainQueueName = prefix + new Random().Next() + "MQ";
            string mainQueueURL = await CreateQueueTest(mainQueueName);
            string deadQueueName = prefix + new Random().Next() + "DLQ";
            string deadQueueURL = await CreateQueueTest(deadQueueName);
            string deadQueueArn = await GetQueueArn(deadQueueURL);

            string redrivePolicy = string.Format(@"{{""maxReceiveCount"" : 5, ""deadLetterTargetArn"" : ""{0}""}}", deadQueueArn);
            await Client.SetQueueAttributesAsync(new SetQueueAttributesRequest
            {
                QueueUrl = mainQueueURL,
                Attributes = new Dictionary<string, string>
                {
                    { QueueAttributeName.RedrivePolicy, redrivePolicy }
                }
            });

            // Wait a bit to make sure the attribute has fully propagated.
            await Task.Delay(1000);

            var response = await Client.ListDeadLetterSourceQueuesAsync(new ListDeadLetterSourceQueuesRequest
            {
                QueueUrl = deadQueueURL
            });
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.QueueUrls);
            Assert.AreEqual(1, response.QueueUrls.Count);
            
            var metadata = response.ResponseMetadata;
            Assert.IsNotNull(metadata);
            Assert.IsNotNull(metadata.RequestId);
        }

        [TestMethod]
        public async Task SimpleSend()
        {
            int maxMessageLength = 20 * 1024;
            string queueName = prefix + new Random().Next();
            var queueURL = await CreateQueueTest(queueName);

            StringBuilder sb = new StringBuilder("The quick brown fox jumped over the lazy dog");
            string messageBody = sb.ToString();
            if (messageBody.Length > maxMessageLength)
            {
                messageBody = messageBody.Substring(0, maxMessageLength);
            }

            await TestSendMessage(Client, queueURL, messageBody);
            await TestSendMessageBatch(Client, queueURL, messageBody);
            await TestReceiveMessage(Client, queueURL);
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

        [TestMethod]
        public async Task TestGetQueueUrl()
        {
            var queueName = "TestGetQueueUrl" + DateTime.UtcNow.Ticks;
            var createResponse = await Client.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = queueName
            });

            try
            {
                var request = new GetQueueUrlRequest { QueueName = queueName };
                var response = await Client.GetQueueUrlAsync(request);
                Assert.AreEqual(createResponse.QueueUrl, response.QueueUrl);
            }
            finally
            {
                await Client.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = createResponse.QueueUrl });
            }
        }

        private async Task<string> GetQueueArn(string queueUrl)
        {
            var getResponse = await Client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                AttributeNames = new List<string> { "All" },
                QueueUrl = queueUrl
            });

            return getResponse.QueueARN;
        }

        private async Task<string> CreateQueueTest(string name)
        {
            var result = await Client.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = name,
                Attributes = new Dictionary<string, string>
                {
                    { SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT, defaultTimeout }
                }
            });
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.QueueUrl);

            var attrResults = await Client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                QueueUrl = result.QueueUrl,
                AttributeNames = new List<string> { SQSConstants.ATTRIBUTE_ALL }
            });

            // if a new attribute has been added, then it's necessary to also update
            // SQSConstants and the GetQueueAttributesResponse.Extensions
            Assert.AreEqual(12, attrResults.Attributes.Count);
            Assert.AreEqual(int.Parse(defaultTimeout), int.Parse(attrResults.Attributes[SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT]));
            Assert.AreEqual(false, attrResults.FifoQueue);
            Assert.AreEqual(false, attrResults.ContentBasedDeduplication.HasValue);
            Assert.AreEqual(null, attrResults.ContentBasedDeduplication);

            for (int i = 0; i < 30; i++)
            {
                var listResult = await Client.ListQueuesAsync(new ListQueuesRequest { QueueNamePrefix = prefix });
                if (listResult.QueueUrls.FirstOrDefault(x => x == result.QueueUrl) != null)
                {
                    return result.QueueUrl;
                }

                await Task.Delay(TimeSpan.FromSeconds(2));
            }

            Assert.Fail("Queue never created");
            return "fail";
        }

        [TestMethod]
        public async Task SQSFIFOTest()
        {
            var fifoQueueName = prefix + new Random().Next() + ".fifo";
            var result = await Client.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = fifoQueueName,
                Attributes = new Dictionary<string, string>
                {
                    { SQSConstants.ATTRIBUTE_FIFO_QUEUE, "true" },
                    { SQSConstants.ATTRIBUTE_CONTENT_BASED_DEDUPLICATION , "true" }
                }
            });

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.QueueUrl);

            var attrResults = await Client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                QueueUrl = result.QueueUrl,
                AttributeNames = new List<string> { SQSConstants.ATTRIBUTE_FIFO_QUEUE, SQSConstants.ATTRIBUTE_CONTENT_BASED_DEDUPLICATION }
            });

            Assert.AreEqual(true, attrResults.FifoQueue);
            Assert.AreEqual(true, attrResults.ContentBasedDeduplication);
        }
    }
}
