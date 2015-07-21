using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;




using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Util;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    /// <summary>
    /// Summary description for SQSIntegrationTest
    /// </summary>
    [TestFixture]
    public class SQS : TestBase<AmazonSQSClient>
    {

        private const string prefix = "TestQueue";
        private const string defaultTimeout = "30";

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [OneTimeSetUp]
        public void TestInit()
        {
            var result = Client.ListQueuesAsync(new ListQueuesRequest()).Result;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.QueueUrls);
        }

        [TearDown]
        public void SQSCleanup()
        {
            var result = Client.ListQueuesAsync(new ListQueuesRequest()).Result;
            foreach (string queue in result.QueueUrls)
            {
                Console.WriteLine("Queue: {0}", queue);
                if (queue.Contains("TestQueue"))
                {
                    try
                    {
                        Client.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = queue }).Wait();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Failed to clean up queue {0}", queue);
                    }
                }
            }
        }

        [Test]
        [Category("SQS")]
        public void SQSDLQTest()
        {
            string mainQueueName = prefix + new Random().Next() + "MQ";
            string mainQueueURL = createQueueTest(mainQueueName);
            string deadQueueName = prefix + new Random().Next() + "DLQ";
            string deadQueueURL = createQueueTest(deadQueueName);

            string deadQueueArn = getQueueArn(deadQueueURL);

            string redrivePolicy = string.Format(@"{{""maxReceiveCount"" : 5, ""deadLetterTargetArn"" : ""{0}""}}", deadQueueArn);
            Client.SetQueueAttributesAsync(new SetQueueAttributesRequest
            {
                QueueUrl = mainQueueURL,
                Attributes = new Dictionary<string, string>
                {
                    { QueueAttributeName.RedrivePolicy, redrivePolicy }
                }
            }).Wait();

            // Wait a bit to make sure the attribute has fully propagated.
            UtilityMethods.Sleep(TimeSpan.FromSeconds(1));

            var response = Client.ListDeadLetterSourceQueuesAsync(new ListDeadLetterSourceQueuesRequest
            {
                QueueUrl = deadQueueURL
            }).Result;
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.QueueUrls);
            Assert.AreEqual(1, response.QueueUrls.Count);
            var metadata = response.ResponseMetadata;
            Assert.IsNotNull(metadata);
            Assert.IsNotNull(metadata.RequestId);
        }

        [Test]
        [Category("SQS")]
        public void SimpleSend()
        {
            int maxMessageLength = 20 * 1024;
            string queueName = prefix + new Random().Next();
            string queueURL;
            queueURL = createQueueTest(queueName);
            StringBuilder sb = new StringBuilder("The quick brown fox jumped over the lazy dog");
            string messageBody = sb.ToString();
            if (messageBody.Length > maxMessageLength)
                messageBody = messageBody.Substring(0, maxMessageLength);

            TestSendMessage(Client, queueURL, messageBody);
            TestSendMessageBatch(Client, queueURL, messageBody);
            TestReceiveMessage(Client, queueURL);
        }

        static Dictionary<string, MessageAttributeValue> messageAttributes = new Dictionary<string, MessageAttributeValue>
        {
            { "StringAttribute", new MessageAttributeValue { DataType = "String", StringValue = "StringAttributeValue" } },
            { "NumberAttribute", new MessageAttributeValue { DataType = "Number", StringValue = "1234" } },
            { "BinaryAttribute", new MessageAttributeValue { DataType = "Binary", BinaryValue = new MemoryStream(Encoding.UTF8.GetBytes("BinaryAttributeValue")) } },
            { "UPPERCASESTRINGATTRIBUTE", new MessageAttributeValue { DataType = "String", StringValue = "UPPERCASESTRINGATTRIBUTE" } },
            { "lowercasestringattribute", new MessageAttributeValue { DataType = "String", StringValue = "lowercasestringattribute" } },
        };

        private static void TestReceiveMessage(IAmazonSQS client, string queueURL)
        {
            var receiveResponse = client.ReceiveMessageAsync(new ReceiveMessageRequest { QueueUrl = queueURL }).Result;
            var messages = receiveResponse.Messages;
            foreach (var message in messages)
            {
                ValidateMD5(message.Body, message.MD5OfBody);
            }
        }

        private static void TestSendMessage(IAmazonSQS client, string queueURL, string messageBody)
        {
            var request = new SendMessageRequest
            {
                MessageBody = messageBody,
                QueueUrl = queueURL,
                MessageAttributes = messageAttributes
            };
            var response = client.SendMessageAsync(request).Result;

            ValidateMD5(request.MessageBody, response.MD5OfMessageBody);
        }
        private static void TestSendMessageBatch(IAmazonSQS client, string queueUrl, string messageBody)
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
            var response = client.SendMessageBatchAsync(request).Result;

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

        [Test]
        [Category("SQS")]
        public void TestGetQueueUrl()
        {
            string queueName = "TestGetQueueUrl" + DateTime.Now.Ticks;
            CreateQueueResponse createResponse = Client.CreateQueueAsync(new CreateQueueRequest()
            {
                QueueName = queueName
            }).Result;
            try
            {
                GetQueueUrlRequest request = new GetQueueUrlRequest() { QueueName = queueName };
                GetQueueUrlResponse response = Client.GetQueueUrlAsync(request).Result;
                Assert.AreEqual(createResponse.QueueUrl, response.QueueUrl);
            }
            finally
            {
                Client.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = createResponse.QueueUrl }).Wait();
            }
        }

        private string getQueueArn(string queueUrl)
        {
            return Client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                AttributeNames = new List<string> { "All" },
                QueueUrl = queueUrl
            }).Result.QueueARN;
        }


        private void deleteQueueTest(string queueUrl)
        {
            var listResult = Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = prefix }).Result;
            int count = listResult.QueueUrls.Count;

            Client.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = queueUrl }).Wait();
            for (int i = 0; i < 10; i++)
            {
                listResult = Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = prefix }).Result;
                if (count - 1 == listResult.QueueUrls.Count)
                {
                    return;
                }
                Console.WriteLine("Sleeping 10s while queue is being deleted");
                UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
            }
        }

        private string createQueueTest(string name)
        {
            var result = Client.CreateQueueAsync(
                new CreateQueueRequest()
                {
                    QueueName = name,
                    Attributes = new Dictionary<string, string>
                    {
                     {SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT,defaultTimeout}
                    }
                }).Result;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.QueueUrl);

            var attrResults = Client.GetQueueAttributesAsync(new GetQueueAttributesRequest()
            {
                QueueUrl = result.QueueUrl,
                AttributeNames = new List<string>() { SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT }
            }).Result;

            Assert.AreEqual(1, attrResults.Attributes.Count);
            Assert.AreEqual(int.Parse(defaultTimeout), int.Parse(attrResults.Attributes[SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT]));

            for (int i = 0; i < 30; i++)
            {
                var listResult = Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = prefix }).Result;
                if (listResult.QueueUrls.FirstOrDefault(x => x == result.QueueUrl) != null)
                    return result.QueueUrl;

                Console.WriteLine("Sleeping 10s while queue is being created");
                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
            }
            Assert.Fail("Queue never created");

            return "fail";
        }
    }
}
