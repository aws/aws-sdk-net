using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Util;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using AWSSDK.Tests.Framework;

namespace AWSSDK.IntegrationTests.SQS
{
    [TestFixture(TestOf = typeof(SQSTests))]
    [Category("Integration")]
    public class SQSTests : TestBase<AmazonSQSClient>
    {

        private const string prefix = "TestQueue";
        private const string defaultTimeout = "30";

        [OneTimeTearDown]
        public void SQSCleanup()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            List<string> queueUrls = null;
            Client.ListQueuesAsync(new ListQueuesRequest(), (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    queueUrls = response.Response.QueueUrls;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(queueUrls);

            foreach (string queue in queueUrls)
            {
                if (queue.Contains(prefix))
                {
                    Client.DeleteQueueAsync(new DeleteQueueRequest() { QueueUrl = queue },
                    (response) => { });
                }
            }
        }

        [Test]
        [Category("WWW")]
        public void SendRecieveDeleteTest()
        {
            string queueName = prefix + new Random().Next();
            string queueURL;
            queueURL = CreateQueueHelper(queueName);
            string messageBody = "The quick brown fox jumped over the lazy dog";
            TestSendMessage(queueURL, messageBody);
            TestSendMessageBatch(queueURL, messageBody);
            TestReceiveMessage(queueURL);
            TestDeleteQueue(queueURL);
        }

        [Test]
        [Category("WWW")]
        public void GetQueueUrlTest()
        {
            string queueName = prefix + "GetQueueUrl" + DateTime.Now.Ticks;
            string queueUrlFromCreate = CreateQueueHelper(queueName);

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string queueUrlFromGet = null;

            Client.GetQueueUrlAsync(new GetQueueUrlRequest()
            {
                QueueName = queueName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    queueUrlFromGet = response.Response.QueueUrl;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(queueUrlFromCreate, queueUrlFromGet);
        }

        [Test]
        [Category("WWW")]
        public void GetNonExistantQueueUrlTest()
        {
            string queueName = prefix + "GetQueueUrl" + DateTime.Now.Ticks;

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.GetQueueUrlAsync(new GetQueueUrlRequest()
            {
                QueueName = queueName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Assert.IsInstanceOf(typeof(QueueDoesNotExistException), responseException);
        }

        [Test]
        [Category("WWW")]
        public void TestListQueues()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            List<string> queueUrls = null;
            Client.ListQueuesAsync(new ListQueuesRequest(), (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    queueUrls = response.Response.QueueUrls;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(queueUrls);
        }

        [Test]
        [Category("WWW")]
        public void DLQTest()
        {
            string mainQueueName = prefix + new Random().Next() + "MQ";
            string mainQueueURL = CreateQueueHelper(mainQueueName);
            string deadQueueName = prefix + new Random().Next() + "DLQ";
            string deadQueueURL = CreateQueueHelper(deadQueueName);

            string deadQueueArn = getQueueArn(deadQueueURL);

            string redrivePolicy = string.Format(@"{{""maxReceiveCount"" : 5, ""deadLetterTargetArn"" : ""{0}""}}", deadQueueArn);

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.SetQueueAttributesAsync(new SetQueueAttributesRequest
            {
                QueueUrl = mainQueueURL,
                Attributes = new Dictionary<string, string>
                {
                    { QueueAttributeName.RedrivePolicy, redrivePolicy }
                }
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            // Wait a bit to make sure the attribute has fully propagated.
            Thread.Sleep(TimeSpan.FromSeconds(1));

            List<string> queueUrls = null;
            ResponseMetadata responseMetadata = null;
            Client.ListDeadLetterSourceQueuesAsync(new ListDeadLetterSourceQueuesRequest
            {
                QueueUrl = deadQueueURL
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    queueUrls = response.Response.QueueUrls;
                    responseMetadata = response.Response.ResponseMetadata;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(queueUrls);
            Assert.AreEqual(1, queueUrls.Count);
            Assert.IsNotNull(responseMetadata);
            Assert.IsNotNull(responseMetadata.RequestId);
        }

        static Dictionary<string, MessageAttributeValue> messageAttributes = new Dictionary<string, MessageAttributeValue>
        {
            { "StringAttribute", new MessageAttributeValue { DataType = "String", StringValue = "StringAttributeValue" } },
            { "NumberAttribute", new MessageAttributeValue { DataType = "Number", StringValue = "1234" } },
            { "BinaryAttribute", new MessageAttributeValue { DataType = "Binary", BinaryValue = new MemoryStream(Encoding.UTF8.GetBytes("BinaryAttributeValue")) } },
            { "UPPERCASESTRINGATTRIBUTE", new MessageAttributeValue { DataType = "String", StringValue = "UPPERCASESTRINGATTRIBUTE" } },
            { "lowercasestringattribute", new MessageAttributeValue { DataType = "String", StringValue = "lowercasestringattribute" } },
        };

        private void TestSendMessage(string queueURL, string messageBody)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string mD5OfMessageBody = null;
            Client.SendMessageAsync(new SendMessageRequest
            {
                MessageBody = messageBody,
                QueueUrl = queueURL,
                MessageAttributes = messageAttributes
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    mD5OfMessageBody = response.Response.MD5OfMessageBody;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            ValidateMD5(messageBody, mD5OfMessageBody);
        }

        private void TestSendMessageBatch(string queueUrl, string messageBody)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string mD5OfMessageBody = null;
            Client.SendMessageBatchAsync(new SendMessageBatchRequest
            {
                QueueUrl = queueUrl,
                Entries = new List<SendMessageBatchRequestEntry>
                {
                    new SendMessageBatchRequestEntry
                    {
                        MessageBody = messageBody, Id = "fooId"
                    }
                }
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    mD5OfMessageBody = response.Response.Successful[0].MD5OfMessageBody;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            ValidateMD5(messageBody, mD5OfMessageBody);
        }

        private void TestReceiveMessage(string queueURL)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            List<Message> messages = null;
            Client.ReceiveMessageAsync(new ReceiveMessageRequest { QueueUrl = queueURL }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    messages = response.Response.Messages;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            foreach (var message in messages)
            {
                ValidateMD5(message.Body, message.MD5OfBody);
            }
        }

        private void TestDeleteQueue(string queueURL)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueURL }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
        }

        private string getQueueArn(string queueUrl)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string queueARN = null;
            Client.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                AttributeNames = new List<string> { "All" },
                QueueUrl = queueUrl
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    queueARN = response.Response.QueueARN;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            return queueARN;
        }

        private string CreateQueueHelper(string name)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string queueUrl = null;
            Client.CreateQueueAsync(new CreateQueueRequest()
            {
                QueueName = name,
                Attributes = new Dictionary<string, string> { { SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT, defaultTimeout } }
            },
            (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    queueUrl = response.Response.QueueUrl;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(queueUrl);

            Dictionary<string, string> attributes = null;
            Client.GetQueueAttributesAsync(new GetQueueAttributesRequest()
            {
                QueueUrl = queueUrl,
                AttributeNames = new List<string>() { SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT }
            },
            (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    attributes = response.Response.Attributes;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(1, attributes.Count);
            Assert.AreEqual(int.Parse(defaultTimeout), int.Parse(attributes[SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT]));

            List<string> queueUrls = null;
            for (int i = 0; i < 30; i++)
            {
                Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = prefix },
                (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        queueUrls = response.Response.QueueUrls;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();

                Assert.IsNull(responseException);

                foreach (string q in queueUrls)
                {
                    if (q == queueUrl)
                    {
                        return queueUrl;
                    }
                }

                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            Assert.Fail("Queue never created");

            return "fail";
        }

        private static void ValidateMD5(string message, string md5)
        {
            Amazon.SQS.Internal.ValidationResponseHandler.ValidateMD5(message, md5);
        }
    }
}
