using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Util;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// Summary description for SQSIntegrationTest
    /// </summary>
    [TestClass]
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
        public void TestInit()
        {
            var result = Client.ListQueues(new ListQueuesRequest());
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.QueueUrls);
        }

        [TestCleanup]
        public void SQSCleanup()
        {
            var result = Client.ListQueues(new ListQueuesRequest());
            foreach (string queue in result.QueueUrls)
            {
                Console.WriteLine("Queue: {0}", queue);
                if (queue.Contains("TestQueue"))
                {
                    try
                    {
                        Client.DeleteQueue(new DeleteQueueRequest() { QueueUrl = queue });
                    }
                    catch (Exception)
                    {
                        Console.Write("Failed to clean up queue {0}", queue);
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("SQS")]
        public void SQSDLQTest()
        {
            string mainQueueName = prefix + new Random().Next() + "MQ";
            string mainQueueURL = createQueueTest(mainQueueName);
            string deadQueueName = prefix + new Random().Next() + "DLQ";
            string deadQueueURL = createQueueTest(deadQueueName);

            string deadQueueArn = getQueueArn(deadQueueURL);

            string redrivePolicy = string.Format(@"{{""maxReceiveCount"" : 5, ""deadLetterTargetArn"" : ""{0}""}}", deadQueueArn);
            Client.SetQueueAttributes(new SetQueueAttributesRequest
            {
                QueueUrl = mainQueueURL,
                Attributes = new Dictionary<string, string>
                {
                    { QueueAttributeName.RedrivePolicy, redrivePolicy }
                }
            });

            // Wait a bit to make sure the attribute has fully propagated.
            Thread.Sleep(1000);

            var response = Client.ListDeadLetterSourceQueues(new ListDeadLetterSourceQueuesRequest
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
        [TestCategory("SQS")]
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
            var receiveResponse = client.ReceiveMessage(new ReceiveMessageRequest { QueueUrl = queueURL });
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
            var response = client.SendMessage(request);

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
            var response = client.SendMessageBatch(request);

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

        [TestMethod]
        [TestCategory("SQS")]
        public void TestGetQueueUrl()
        {
            string queueName = "TestGetQueueUrl" + DateTime.Now.Ticks;
            CreateQueueResponse createResponse = Client.CreateQueue(new CreateQueueRequest()
            {
                QueueName = queueName
            });
            try
            {
                GetQueueUrlRequest request = new GetQueueUrlRequest() { QueueName = queueName };
                GetQueueUrlResponse response = Client.GetQueueUrl(request);
                Assert.AreEqual(createResponse.QueueUrl, response.QueueUrl);
            }
            finally
            {
                Client.DeleteQueue(new DeleteQueueRequest() { QueueUrl = createResponse.QueueUrl });
            }
        }

        private string getQueueArn(string queueUrl)
        {
            return Client.GetQueueAttributes(new GetQueueAttributesRequest
            {
                AttributeNames = new List<string> { "All" },
                QueueUrl = queueUrl
            }).QueueARN;
        }


        private void deleteQueueTest(string queueUrl)
        {
            var listResult = Client.ListQueues(new ListQueuesRequest() { QueueNamePrefix = prefix });
            int count = listResult.QueueUrls.Count;

            Client.DeleteQueue(new DeleteQueueRequest() { QueueUrl = queueUrl });
            for (int i = 0; i < 10; i++)
            {
                listResult = Client.ListQueues(new ListQueuesRequest() { QueueNamePrefix = prefix });
                if (count - 1 == listResult.QueueUrls.Count)
                {
                    return;
                }
                Console.WriteLine("Sleeping 10s while queue is being deleted");
                Thread.Sleep(10000);
            }
        }

        private string createQueueTest(string name)
        {
            var result = Client.CreateQueue(
                new CreateQueueRequest()
                {
                    QueueName = name,
                    Attributes = new Dictionary<string, string>
                    {
                     {SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT,defaultTimeout}
                    }
                });
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.QueueUrl);

            var attrResults = Client.GetQueueAttributes(new GetQueueAttributesRequest()
            {
                QueueUrl = result.QueueUrl,
                AttributeNames = new List<string>() { SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT }
            });

            Assert.AreEqual(1, attrResults.Attributes.Count);
            Assert.AreEqual(int.Parse(defaultTimeout), int.Parse(attrResults.Attributes[SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT]));

            for (int i = 0; i < 30; i++)
            {
                var listResult = Client.ListQueues(new ListQueuesRequest() { QueueNamePrefix = prefix });
                if (listResult.QueueUrls.FirstOrDefault(x => x == result.QueueUrl) != null)
                    return result.QueueUrl;

                Console.WriteLine("Sleeping 10s while queue is being created");
                Thread.Sleep(2000);
            }
            Assert.Fail("Queue never created");

            return "fail";
        }
    }
}
