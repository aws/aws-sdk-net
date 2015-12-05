using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Util;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    /// <summary>
    /// Summary description for SQSIntegrationTest
    /// </summary>
    
    public class SQS : TestBase<AmazonSQSClient>
    {

        private const string prefix = "TestQueue";
        private const string defaultTimeout = "30";

        public SQS()
        {
        }

        async Task SQSCleanup()
        {
            var result = await Client.ListQueuesAsync(new ListQueuesRequest());
            foreach (string queue in result.QueueUrls)
            {
                Console.WriteLine("Queue: {0}", queue);
                if (queue.Contains("TestQueue"))
                {
                    try
                    {
                        await Client.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = queue });
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Failed to clean up queue {0}", queue);
                    }
                }
            }
        }


        [Fact]
        [Trait(CategoryAttribute,"SQS")]
        public async Task SQSDLQTest()
        {
            try
            {
                string mainQueueName = prefix + new Random().Next() + "MQ";
                string mainQueueURL = await createQueueTest(mainQueueName);
                string deadQueueName = prefix + new Random().Next() + "DLQ";
                string deadQueueURL = await createQueueTest(deadQueueName);

                string deadQueueArn = await getQueueArn(deadQueueURL);

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
                UtilityMethods.Sleep(TimeSpan.FromSeconds(1));

                var response = await Client.ListDeadLetterSourceQueuesAsync(new ListDeadLetterSourceQueuesRequest
                {
                    QueueUrl = deadQueueURL
                });
                Assert.NotNull(response);
                Assert.NotNull(response.QueueUrls);
                Assert.Equal(1, response.QueueUrls.Count);
                var metadata = response.ResponseMetadata;
                Assert.NotNull(metadata);
                Assert.NotNull(metadata.RequestId);
            }
            finally
            {
                await SQSCleanup();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"SQS")]
        public async Task SimpleSend()
        {
            try
            {
                int maxMessageLength = 20 * 1024;
                string queueName = prefix + new Random().Next();
                string queueURL;
                queueURL = await createQueueTest(queueName);
                StringBuilder sb = new StringBuilder("The quick brown fox jumped over the lazy dog");
                string messageBody = sb.ToString();
                if (messageBody.Length > maxMessageLength)
                    messageBody = messageBody.Substring(0, maxMessageLength);

                await TestSendMessage(Client, queueURL, messageBody);
                await TestSendMessageBatch(Client, queueURL, messageBody);
                await TestReceiveMessage(Client, queueURL);
            }finally
            {
                await SQSCleanup();
            }
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

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string CalculateMD5(string message)
        {
            return Amazon.SQS.Internal.ValidationResponseHandler.CalculateMD5(message);
        }
        private static void ValidateMD5(string message, string md5)
        {
            Amazon.SQS.Internal.ValidationResponseHandler.ValidateMD5(message, md5);
        }

        [Fact]
        [Trait(CategoryAttribute,"SQS")]
        public async Task TestGetQueueUrl()
        {            
            string queueName = "TestGetQueueUrl" + DateTime.Now.Ticks;
            CreateQueueResponse createResponse = await Client.CreateQueueAsync(new CreateQueueRequest()
            {
                QueueName = queueName
            });
            try
            {
                GetQueueUrlRequest request = new GetQueueUrlRequest() { QueueName = queueName };
                GetQueueUrlResponse response = await Client.GetQueueUrlAsync(request);
                Assert.Equal(createResponse.QueueUrl, response.QueueUrl);
            }
            finally
            {
                await Client.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = createResponse.QueueUrl });
                await SQSCleanup();
            }
        }

        private async Task<string> getQueueArn(string queueUrl)
        {
            return (await Client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                AttributeNames = new List<string> { "All" },
                QueueUrl = queueUrl
            })).QueueARN;
        }


        private async Task deleteQueueTest(string queueUrl)
        {
            var listResult = await Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = prefix });
            int count = listResult.QueueUrls.Count;

            await Client.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = queueUrl });
            for (int i = 0; i < 10; i++)
            {
                listResult = await Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = prefix });
                if (count - 1 == listResult.QueueUrls.Count)
                {
                    return;
                }
                Console.WriteLine("Sleeping 10s while queue is being deleted");
                UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
            }
        }

        private async Task<string> createQueueTest(string name)
        {
            var result = await Client.CreateQueueAsync(
                new CreateQueueRequest()
                {
                    QueueName = name,
                    Attributes = new Dictionary<string, string>
                    {
                     {SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT,defaultTimeout}
                    }
                });
            Assert.NotNull(result);
            Assert.NotNull(result.QueueUrl);

            var attrResults = await Client.GetQueueAttributesAsync(new GetQueueAttributesRequest()
            {
                QueueUrl = result.QueueUrl,
                AttributeNames = new List<string>() { SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT }
            });

            Assert.Equal(1, attrResults.Attributes.Count);
            Assert.Equal(int.Parse(defaultTimeout), int.Parse(attrResults.Attributes[SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT]));

            for (int i = 0; i < 30; i++)
            {
                var listResult = await Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = prefix });
                if (listResult.QueueUrls.FirstOrDefault(x => x == result.QueueUrl) != null)
                    return result.QueueUrl;

                Console.WriteLine("Sleeping 10s while queue is being created");
                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
            }
            AssertExtensions.Fail("Queue never created");

            return "fail";
        }
    }
}
