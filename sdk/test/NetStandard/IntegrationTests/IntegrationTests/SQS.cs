using Amazon.S3;
using Amazon.S3.Model;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    /// <summary>
    /// Summary description for SQSIntegrationTest
    /// </summary>

    public class SQS : TestBase<AmazonSQSClient>
    {
        private static Random _rand;
        private const string prefix = "TestQueue";
        private const string defaultTimeout = "30";
        private AmazonS3Config s3ClientConfig = null;

        private List<string> _bucketNames = new List<string>();
        private List<string> _queueUrls = new List<string>();

        public SQS()
        {
            _rand = new Random();
            s3ClientConfig = new AmazonS3Config();
        }

        protected override void Dispose(bool disposing)
        {
            if (_bucketNames.Count != 0)
            {
                using (AmazonS3Client client = new AmazonS3Client(s3ClientConfig))
                {
                    foreach (string bucketName in _bucketNames)
                    {
                        UtilityMethods.DeleteBucketWithObjectsAsync(client, bucketName).Wait();
                    }
                }
            }
            
            foreach (string url in _queueUrls)
            {
                try
                {
                    Client.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = url }).Wait();
                }
                catch { };
            }
                
            base.Dispose(disposing);
        }

        [Fact]
        [Trait(CategoryAttribute,"SQS")]
        public async Task SQSDLQTest()
        {
            string mainQueueName = prefix + _rand.Next() + "MQ";
            string mainQueueURL = await createQueueTest(mainQueueName);
            string deadQueueName = prefix + _rand.Next() + "DLQ";
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
            Assert.Single(response.QueueUrls);
            var metadata = response.ResponseMetadata;
            Assert.NotNull(metadata);
            Assert.NotNull(metadata.RequestId);
        }

        [Fact]
        [Trait(CategoryAttribute,"SQS")]
        public async Task SimpleSend()
        {
            int maxMessageLength = 20 * 1024;
            string queueName = UtilityMethods.GenerateName("SimpleSend");
            string queueURL = await createQueueTest(queueName);

            StringBuilder sb = new StringBuilder("The quick brown fox jumped over the lazy dog");
            string messageBody = sb.ToString();
            if (messageBody.Length > maxMessageLength)
                messageBody = messageBody.Substring(0, maxMessageLength);

            await TestSendMessage(Client, queueURL, messageBody);
            await TestSendMessageBatch(Client, queueURL, messageBody);
            await TestReceiveMessage(Client, queueURL);
        }

        [Fact]
        [Trait(CategoryAttribute, "SQS")]
        public async Task AuthorizeS3ToSendMessageAsyncTest()
        {
            string bucketName = UtilityMethods.GenerateName("AuthorizeS3ToSendMessageAsync");
            string mainQueueName = UtilityMethods.GenerateName("AuthorizeS3ToSendMessageAsync");
            string mainQueueURL = await createQueueTest(mainQueueName);
            string s3ObjectKey = UtilityMethods.GenerateName("key");

            Assert.False(String.Compare(mainQueueURL, "fail") == 0, "Failed to create an SQS queue");

            using (var s3Client = new AmazonS3Client(s3ClientConfig))
            {
                var bucketResponse = await s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName });
                    _bucketNames.Add(bucketName);

                Assert.True(await hasS3Bucket(s3Client, bucketName), "Failed to create an S3 bucket");

                var arn = await Client.AuthorizeS3ToSendMessageAsync(mainQueueURL, bucketName);
                await s3Client.PutBucketNotificationAsync(new PutBucketNotificationRequest{
                    BucketName = bucketName,
                    QueueConfigurations = new List<QueueConfiguration>{
                        new QueueConfiguration { Queue = arn, Events = new List<EventType>{
                                EventType.ObjectCreatedAll
                            }
                        }
                    },
                });

                var count = (await Client.ReceiveMessageAsync(mainQueueURL)).Messages?.Count;

                await s3Client.PutObjectAsync(new PutObjectRequest {
                    ContentBody = "Hello World",
                    BucketName = bucketName,
                    Key = s3ObjectKey,
                });
                
                Assert.True(await hasS3Object(s3Client, bucketName, s3ObjectKey), "Failed to put an S3 object");

                bool objectCreaedMessageReceived = false;
                for (int i = 0; i < 5; i++)
                {
                    var messages = (await Client.ReceiveMessageAsync(mainQueueURL)).Messages;

                    if ( messages != null)
                    {
                        foreach (var message in messages)
                        {
                            objectCreaedMessageReceived = message.Body.Contains("ObjectCreated:Put");
                            if (objectCreaedMessageReceived)
                                return;
                        }
                    }

                    UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
                }

                Assert.True(objectCreaedMessageReceived, "Failed to receive object creaed message.");
            }
        }

        private async static Task<bool> hasS3Bucket(AmazonS3Client client, string bucketName)
        {
            for (int i = 0; i < 5; i++)
            {
                var buckets = (await client.ListBucketsAsync()).Buckets;
                foreach (S3Bucket bucket in buckets)
                {
                    if (bucket.BucketName.Contains(bucketName))
                        return true;
                }

                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
            }

            return false;
        }


        private async static Task<bool> hasS3Object(AmazonS3Client client, string bucketName, string key)
        {
            for (int i = 0; i < 5; i++)
            {
                var response = (await client.ListObjectsAsync(new ListObjectsRequest { BucketName = bucketName }));
                foreach (var obj in response.S3Objects)
                {
                    if (String.Compare(obj.Key, key) == 0) 
                        return true;
                }

                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
            }
            return false;
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
            string queueName = UtilityMethods.GenerateName("TestGetQueueUrl");
            CreateQueueResponse createResponse = await Client.CreateQueueAsync(new CreateQueueRequest()
            {
                QueueName = queueName
            });
            _queueUrls.Add(createResponse.QueueUrl);

            GetQueueUrlRequest request = new GetQueueUrlRequest() { QueueName = queueName };
            GetQueueUrlResponse response = await Client.GetQueueUrlAsync(request);
            Assert.Equal(createResponse.QueueUrl, response.QueueUrl);
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

            Assert.Single(attrResults.Attributes);
            Assert.Equal(int.Parse(defaultTimeout), int.Parse(attrResults.Attributes[SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT]));

            for (int i = 0; i < 30; i++)
            {
                var listResult = await Client.ListQueuesAsync(new ListQueuesRequest() { QueueNamePrefix = name });
                if (listResult.QueueUrls.FirstOrDefault(x => x == result.QueueUrl) != null)
                {
                    _queueUrls.Add(result.QueueUrl);
                    return result.QueueUrl;
                }

                Console.WriteLine("Sleeping 10s while queue is being created");
                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
            }
            AssertExtensions.Fail("Queue never created");

            return "fail";
        }
    }
}
