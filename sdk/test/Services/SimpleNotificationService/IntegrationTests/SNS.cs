using Amazon.Auth.AccessControlPolicy;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using SNSMessageAttributeValue = Amazon.SimpleNotificationService.Model.MessageAttributeValue;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    [TestCategory("SimpleNotificationService")]
    public class SNS : TestBase<AmazonSimpleNotificationServiceClient>
    {
        private static AmazonSQSClient sqsClient;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            sqsClient = new AmazonSQSClient(Client.Config.RegionEndpoint);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            sqsClient?.Dispose();
            BaseClean();
        }

        [TestMethod]
        public async Task CRUDTopics()
        {
            // list all topics
            var allTopics = await GetAllTopics();
            var currentTopicCount = allTopics.Count;

            // create new topic
            var name = "dotnetsdk" + DateTime.UtcNow.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = await Client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                // verify there is a new topic
                allTopics = await GetAllTopics();
                Assert.AreNotEqual(currentTopicCount, allTopics.Count);

                // set topic attribute
                var setTopicAttributesRequest = new SetTopicAttributesRequest
                {
                    TopicArn = topicArn,
                    AttributeName = "DisplayName",
                    AttributeValue = "Test topic"
                };
                await Client.SetTopicAttributesAsync(setTopicAttributesRequest);

                // verify topic attributes
                var getTopicAttributesRequest = new GetTopicAttributesRequest
                {
                    TopicArn = topicArn
                };

                var topicAttributes = (await Client.GetTopicAttributesAsync(getTopicAttributesRequest)).Attributes;
                Assert.AreEqual(
                    setTopicAttributesRequest.AttributeValue,
                    topicAttributes[setTopicAttributesRequest.AttributeName]
                );

            }
            finally
            {
                await Client.DeleteTopicAsync(new DeleteTopicRequest
                {
                    TopicArn = topicArn
                });

                // verify the topic was deleted
                allTopics = await GetAllTopics();
                Assert.IsFalse(allTopics.Any(t => t.TopicArn == topicArn));
            }
        }

        [TestMethod]
        public async Task TestPublishAsJson()
        {
            // create new topic
            var name = "dotnetsdk" + DateTime.UtcNow.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };

            var createTopicResult = await Client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                var pubRequest = new PublishRequest
                {
                    TopicArn = topicArn,
                    MessageStructure = "json",
                    Message = "stuff"
                };

                var gotException = true;
                try
                {
                    await Client.PublishAsync(pubRequest);
                    gotException = false;
                }
                catch (AmazonSimpleNotificationServiceException e)
                {
                    Assert.AreEqual("InvalidParameter", e.ErrorCode);
                }

                Assert.IsTrue(gotException, "Failed to get exception about invalid JSON");
                pubRequest.Message = "{\"default\" : \"Data\"}";
                await Client.PublishAsync(pubRequest);
            }
            finally
            {
                await Client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
            }
        }

        [TestMethod]
        public async Task IsMessageSignatureValidSHA1()
        {
            string topicArn = null;
            string queueUrl = null;

            try
            {
                topicArn = await CreateTopic();
                queueUrl = await CreateQueue();

                await SubscribeQueue(topicArn, queueUrl);
                List<Message> messages = await PublishToSNSAndReceiveMessages(GetPublishRequest(topicArn), queueUrl);

                Assert.AreEqual(1, messages.Count);
                var bodyJson = GetBodyJson(messages[0]);

                var validMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson);
                Assert.IsTrue(validMessage.IsMessageSignatureValid());

                var invalidMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson.Replace("Test Message", "Hacked Message"));
                Assert.IsFalse(invalidMessage.IsMessageSignatureValid());
            }
            finally
            {
                if (topicArn != null)
                {
                    await Client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                if (queueUrl != null)
                {
                    await sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
                }
            }
        }

        [TestMethod]
        public async Task IsMessageSignatureValidSHA256()
        {
            string topicArn = null;
            string queueUrl = null;

            try
            {
                topicArn = await CreateTopic();
                queueUrl = await CreateQueue();

                // set topic attribute
                var setTopicAttributesRequest = new SetTopicAttributesRequest
                {
                    TopicArn = topicArn,
                    AttributeName = "SignatureVersion",
                    AttributeValue = "2"
                };
                await Client.SetTopicAttributesAsync(setTopicAttributesRequest);

                await SubscribeQueue(topicArn, queueUrl);
                List<Message> messages = await PublishToSNSAndReceiveMessages(GetPublishRequest(topicArn), queueUrl);

                Assert.AreEqual(1, messages.Count);
                var bodyJson = GetBodyJson(messages[0]);

                var validMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson);
                Assert.IsTrue(validMessage.IsMessageSignatureValid());

                var invalidMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson.Replace("Test Message", "Hacked Message"));
                Assert.IsFalse(invalidMessage.IsMessageSignatureValid());
            }
            finally
            {
                if (topicArn != null)
                {
                    await Client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                if (queueUrl != null)
                {
                    await sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
                }
            }
        }

        [TestMethod]
        public async Task TestQueueSubscription()
        {
            string topicArn = null;
            string queueUrl = null;

            try
            {
                topicArn = await CreateTopic();
                queueUrl = await CreateQueue();

                var subscriptionArn = await SubscribeQueue(topicArn, queueUrl);
                var publishRequest = GetPublishRequest(topicArn);
                List<Message> messages = await PublishToSNSAndReceiveMessages(publishRequest, queueUrl);

                Assert.AreEqual(1, messages.Count);
                var message = messages[0];

                string bodyJson = GetBodyJson(message);

                var json = JsonDocument.Parse(bodyJson);
                var messageText = json.RootElement.GetProperty("Message");
                var messageSubject = json.RootElement.GetProperty("Subject");
                Assert.AreEqual(publishRequest.Message, messageText.ToString());
                Assert.AreEqual(publishRequest.Subject, messageSubject.ToString());
                var messageAttributes = json.RootElement.GetProperty("MessageAttributes");
                Assert.AreEqual(publishRequest.MessageAttributes.Count, messageAttributes.EnumerateObject().Count());

                foreach (var ma in publishRequest.MessageAttributes)
                {
                    var name = ma.Key;
                    var value = ma.Value;
                    Assert.IsTrue(messageAttributes.EnumerateObject().Any(x => x.Name == name));
                    var jsonAttribute = messageAttributes.GetProperty(name);
                    var jsonType = jsonAttribute.GetProperty("Type").ToString();
                    var jsonValue = jsonAttribute.GetProperty("Value").ToString();
                    Assert.IsNotNull(jsonType);
                    Assert.IsNotNull(jsonValue);
                    Assert.AreEqual(value.DataType, jsonType);
                    Assert.AreEqual(value.DataType != "Binary"
                                        ? value.StringValue
                                        : Convert.ToBase64String(value.BinaryValue.ToArray()), jsonValue);
                }

                await sqsClient.DeleteMessageAsync(new DeleteMessageRequest
                {
                    QueueUrl = queueUrl,
                    ReceiptHandle = messages[0].ReceiptHandle
                });

                // This will unsubscribe but leave the policy in place.
                await Client.UnsubscribeAsync(new UnsubscribeRequest
                {
                    SubscriptionArn = subscriptionArn
                });

                // Subscribe again to see if this affects the policy.
                await Client.SubscribeQueueAsync(topicArn, sqsClient, queueUrl);

                await Client.PublishAsync(new PublishRequest
                {
                    TopicArn = topicArn,
                    Message = "Test Message again"
                });

                messages = (await sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    WaitTimeSeconds = 20
                })).Messages;

                Assert.AreEqual(1, messages.Count);

                var getAttributeResponse = await sqsClient.GetQueueAttributesAsync(new GetQueueAttributesRequest
                {
                    AttributeNames = new List<string> { "All" },
                    QueueUrl = queueUrl
                });

                var policy = Policy.FromJson(getAttributeResponse.Policy);
                Assert.AreEqual(1, policy.Statements.Count);
            }
            finally
            {
                if (topicArn != null)
                {
                    await Client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                if (queueUrl != null)
                {
                    await sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
                }
            }
        }

        [TestMethod]
        public async Task TestMultipleQueueSubscription()
        {
            var topicArns = new List<string>();

            var topicName1 = "dotnetsdkTopic" + DateTime.UtcNow.Ticks;
            topicArns.Add((await Client.CreateTopicAsync(topicName1)).TopicArn);

            var topicName2 = "dotnetsdkTopic" + DateTime.UtcNow.Ticks;
            topicArns.Add((await Client.CreateTopicAsync(topicName2)).TopicArn);

            var queueName = "dotnetsdkQueue-" + DateTime.UtcNow.Ticks;
            var queueUrl = (await sqsClient.CreateQueueAsync(queueName)).QueueUrl;

            try
            {
                var subscriptionArns = (await Client.SubscribeQueueToTopicsAsync(topicArns, sqsClient, queueUrl)).Values;
                Assert.AreEqual(2, subscriptionArns.Count);
                Thread.Sleep(TimeSpan.FromSeconds(5));

                var attributes = (await sqsClient.GetQueueAttributesAsync(queueUrl, new List<string> { "All" })).Attributes;
                var policy = Policy.FromJson(attributes["Policy"]);
                Assert.AreEqual(2, policy.Statements.Count);
            }
            finally
            {
                foreach (var topicArn in topicArns)
                {
                    await Client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                await sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
            }
        }

        [TestMethod]
        public async Task FindTopic()
        {
            var name = "dotnetsdk" + DateTime.UtcNow.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };

            var createTopicResult = await Client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                var foundTopic = await Client.FindTopicAsync(name);
                Assert.IsNotNull(foundTopic);
            }
            finally
            {
                await Client.DeleteTopicAsync(new DeleteTopicRequest
                {
                    TopicArn = topicArn
                });
            }
        }

        private static string GetBodyJson(Message message)
        {
            string bodyJson;
            // Handle some accounts returning message body as base 64 encoded.
            if (message.Body.Trim()[0] == '{')
                bodyJson = message.Body;
            else
                bodyJson = Encoding.UTF8.GetString(Convert.FromBase64String(message.Body));
            return bodyJson;
        }

        private static async Task<List<Topic>> GetAllTopics()
        {
            var allTopics = new List<Topic>();
            var listRequest = new ListTopicsRequest();
            do
            {
                var listResponse = await Client.ListTopicsAsync(listRequest);
                if (listResponse.Topics != null)
                {
                    allTopics.AddRange(listResponse.Topics);
                }

                listRequest.NextToken = listResponse.NextToken;
            } while (!string.IsNullOrEmpty(listRequest.NextToken));
            return allTopics;
        }

        private PublishRequest GetPublishRequest(string topicArn)
        {
            return new PublishRequest
            {
                TopicArn = topicArn,
                Subject = "Test Subject",
                Message = "Test Message",
                MessageAttributes = new Dictionary<string, SNSMessageAttributeValue>
                {
                    { "Color", new SNSMessageAttributeValue { StringValue = "Red", DataType = "String" } },
                    { "Binary", new SNSMessageAttributeValue { DataType = "Binary", BinaryValue = new MemoryStream(Encoding.UTF8.GetBytes("Yes please")) } },
                    { "Prime", new SNSMessageAttributeValue { StringValue = "31", DataType = "Number" } },
                }
            };
        }

        private async Task<List<Message>> PublishToSNSAndReceiveMessages(PublishRequest publishRequest, string queueUrl)
        {
            await Client.PublishAsync(publishRequest);

            var receiveResponse = await sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest
            {
                QueueUrl = queueUrl,
                WaitTimeSeconds = 20
            });

            return receiveResponse.Messages;
        }

        private async Task<string> SubscribeQueue(string topicArn, string queueUrl)
        {
            var subscriptionARN = await Client.SubscribeQueueAsync(topicArn, sqsClient, queueUrl);

            // Sleep to wait for the subscribe to complete.
            await Task.Delay(TimeSpan.FromSeconds(5));

            return subscriptionARN;
        }

        private async Task<string> CreateQueue()
        {
            var queueName = UtilityMethods.GenerateName("TestQueueSubscription");
            var createResponse = await sqsClient.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = queueName
            });

            return createResponse.QueueUrl;
        }

        private async Task<string> CreateTopic()
        {
            // create new topic
            var topicName = UtilityMethods.GenerateName("TestQueueSubscription");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = topicName
            };

            var createTopicResult = await Client.CreateTopicAsync(createTopicRequest);
            return createTopicResult.TopicArn;
        }
    }
}
