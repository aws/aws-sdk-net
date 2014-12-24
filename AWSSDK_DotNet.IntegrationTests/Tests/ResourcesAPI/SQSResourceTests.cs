using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Amazon.SQS.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SQS;
using Amazon.SQS.Resources;

namespace AWSSDK_DotNet.IntegrationTests.Tests.ResourcesAPI
{
    [TestClass]
    public class SQSResourceTests
    {
        private static AmazonSQSClient sqsClient;
        private static Amazon.SQS.Resources.SQS sqs;

        private const string prefix = "ResourceTestQueue";

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContent)
        {
            sqsClient = new AmazonSQSClient();
            sqs = new Amazon.SQS.Resources.SQS(sqsClient);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            if (sqs != null)
            {
                sqs.Dispose();
                sqs = null;
            }
            if (sqsClient != null)
            {
                sqsClient.Dispose();
                sqsClient = null;
            }
        }

        private string[] TestMessages =
        {
            "The quick brown fox jumped over the lazy dog",
            "Another fox jumped over the lazy dog",
            "The original quick brown fox jumped over a different lazy dog"
        };

        [TestMethod]
        [TestCategory("SQS")]
        public void CRUDMessages()
        {
            IQueue queue = null;
            try
            {
                var queueName = prefix + new Random().Next();
                queue = sqs.CreateQueue(queueName);

                var messageHashes = new HashSet<string>
                {
                    TestSendMessage(queue, 0),
                };

                foreach (var hash in TestSendMessageBatch(queue))
                {
                    messageHashes.Add(hash);
                }

                TestReceiveMessages(queue, messageHashes);
            }
            finally
            {
                if (queue != null)
                    queue.Delete();
            }   
        }

        string TestSendMessage(IQueue queue, int index)
        {
            var hash = Amazon.SQS.Internal.ValidationResponseHandler.CalculateMD5(TestMessages[index]);
            queue.SendMessage(TestMessages[index]);
            return hash;
        }

        IEnumerable<string> TestSendMessageBatch(IQueue queue)
        {
            var hashes = new List<string>();
            var messages = new List<SendMessageBatchRequestEntry>();

            for (var i = 1; i < TestMessages.Length; i++)
            {
                hashes.Add(Amazon.SQS.Internal.ValidationResponseHandler.CalculateMD5(TestMessages[i]));
                messages.Add(new SendMessageBatchRequestEntry
                {
                    Id = i.ToString(),
                    MessageBody = TestMessages[i]
                });
            }

            queue.SendMessages(messages);
            return hashes;
        }

        void TestReceiveMessages(IQueue queue, ICollection<string> messageHashes)
        {
            var messages = queue.ReceiveMessages(2);
            while (messages.Count() != 0)
            {
                foreach (var message in messages)
                {
                    if (messageHashes.Contains(message.MD5OfBody))
                        messageHashes.Remove(message.MD5OfBody);
                    else
                        Assert.Fail("Received message not in original set - hash {0}, body {1}", message.MD5OfBody, message.Body);
                }

                messages = queue.ReceiveMessages(10);
            }

            if (messageHashes.Any())
                Assert.Fail("Not all messages sent were received, {0} were outstanding on exit", messageHashes.Count);
        }
    }
}
