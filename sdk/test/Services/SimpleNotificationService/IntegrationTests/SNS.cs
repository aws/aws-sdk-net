using Amazon;
using Amazon.Auth.AccessControlPolicy;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using SNSMessageAttributeValue = Amazon.SimpleNotificationService.Model.MessageAttributeValue;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// xUnit fixture that owns a single <see cref="AmazonSimpleNotificationServiceClient"/>
    /// and a paired <see cref="AmazonSQSClient"/> for the lifetime of the
    /// <see cref="SNSTests"/> class.
    /// </summary>
    public class SNSClientFixture : IAsyncLifetime
    {
        public AmazonSimpleNotificationServiceClient Client { get; private set; }
        public AmazonSQSClient SqsClient { get; private set; }

        public ValueTask InitializeAsync()
        {
            Client = new AmazonSimpleNotificationServiceClient();
            RetryUtilities.ConfigureClient(Client);
            SqsClient = new AmazonSQSClient(Client.Config.RegionEndpoint);
            RetryUtilities.ConfigureClient(SqsClient);
            return default;
        }

        public ValueTask DisposeAsync()
        {
            SqsClient?.Dispose();
            Client?.Dispose();
            return default;
        }
    }

    [Trait("Category", "SimpleNotificationService")]
    public class SNSTests : IClassFixture<SNSClientFixture>
    {
        private readonly AmazonSimpleNotificationServiceClient _client;
        private readonly AmazonSQSClient _sqsClient;

        public SNSTests(SNSClientFixture fixture)
        {
            _client = fixture.Client;
            _sqsClient = fixture.SqsClient;
        }

        [Fact]
        public async Task CRUDTopics()
        {
            // list all topics
            var allTopics = await GetAllTopics();
            var currentTopicCount = allTopics.Count;

            // create new topic
            var name = UtilityMethods.GenerateName("dotnetsdk");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = await _client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                // verify there is a new topic
                allTopics = await GetAllTopics();
                Assert.NotEqual(currentTopicCount, allTopics.Count);

                // set topic attribute
                var setTopicAttributesRequest = new SetTopicAttributesRequest
                {
                    TopicArn = topicArn,
                    AttributeName = "DisplayName",
                    AttributeValue = "Test topic"
                };
                await _client.SetTopicAttributesAsync(setTopicAttributesRequest);

                // verify topic attributes
                var getTopicAttributesRequest = new GetTopicAttributesRequest
                {
                    TopicArn = topicArn
                };

                var topicAttributes = (await _client.GetTopicAttributesAsync(getTopicAttributesRequest)).Attributes;
                Assert.Equal(
                    setTopicAttributesRequest.AttributeValue,
                    topicAttributes[setTopicAttributesRequest.AttributeName]
                );
            }
            finally
            {
                await _client.DeleteTopicAsync(new DeleteTopicRequest
                {
                    TopicArn = topicArn
                });

                // verify the topic was deleted
                allTopics = await GetAllTopics();
                Assert.False(allTopics.Any(t => t.TopicArn == topicArn));
            }
        }

        [Fact]
        public async Task TestPublishAsJson()
        {
            // create new topic
            var name = UtilityMethods.GenerateName("dotnetsdk");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };

            var createTopicResult = await _client.CreateTopicAsync(createTopicRequest);
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
                    await _client.PublishAsync(pubRequest);
                    gotException = false;
                }
                catch (AmazonSimpleNotificationServiceException e)
                {
                    Assert.Equal("InvalidParameter", e.ErrorCode);
                }

                Assert.True(gotException, "Failed to get exception about invalid JSON");
                pubRequest.Message = "{\"default\" : \"Data\"}";
                await _client.PublishAsync(pubRequest);
            }
            finally
            {
                await _client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
            }
        }

        [Fact]
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

                Assert.Single(messages);
                var bodyJson = GetBodyJson(messages[0]);

                var validMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson);
                Assert.True(validMessage.IsMessageSignatureValid());

                var invalidMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson.Replace("Test Message", "Hacked Message"));
                Assert.False(invalidMessage.IsMessageSignatureValid());
            }
            finally
            {
                if (topicArn != null)
                {
                    await _client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                if (queueUrl != null)
                {
                    await _sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
                }
            }
        }

        [Fact]
        public async Task IsMessageSignatureValidInvalidSignatureVersion()
        {
            string topicArn = null;
            string queueUrl = null;

            try
            {
                topicArn = await CreateTopic();
                queueUrl = await CreateQueue();
                await SubscribeQueue(topicArn, queueUrl);
                List<Message> messages = await PublishToSNSAndReceiveMessages(GetPublishRequest(topicArn), queueUrl);

                Assert.Single(messages);
                var bodyJson = GetBodyJson(messages[0]);

                // Modify message to have invalid SignatureVersion
                var jsonData = System.Text.Json.JsonDocument.Parse(bodyJson);
                string updatedJson;
                using (var memoryStream = new MemoryStream())
                using (var writer = new System.Text.Json.Utf8JsonWriter(memoryStream))
                {
                    writer.WriteStartObject();
                    foreach (var property in jsonData.RootElement.EnumerateObject())
                    {
                        if (property.Name == "SignatureVersion")
                        {
                            writer.WriteString("SignatureVersion", "3");
                        }
                        else
                        {
                            property.WriteTo(writer);
                        }
                    }
                    writer.WriteEndObject();
                    writer.Flush();
                    updatedJson = Encoding.UTF8.GetString(memoryStream.ToArray());
                }

                var ex = Assert.Throws<Amazon.Runtime.AmazonClientException>(
                    () => Amazon.SimpleNotificationService.Util.Message.ParseMessage(updatedJson));
                Assert.Equal("SignatureVersion is not a valid value", ex.Message);
            }
            finally
            {
                if (topicArn != null)
                {
                    await _client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                if (queueUrl != null)
                {
                    await _sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
                }
            }
        }

        [Fact]
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
                await _client.SetTopicAttributesAsync(setTopicAttributesRequest);

                await SubscribeQueue(topicArn, queueUrl);
                List<Message> messages = await PublishToSNSAndReceiveMessages(GetPublishRequest(topicArn), queueUrl);

                Assert.Single(messages);
                var bodyJson = GetBodyJson(messages[0]);

                var validMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson);
                Assert.True(validMessage.IsMessageSignatureValid());

                var invalidMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson.Replace("Test Message", "Hacked Message"));
                Assert.False(invalidMessage.IsMessageSignatureValid());
            }
            finally
            {
                if (topicArn != null)
                {
                    await _client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                if (queueUrl != null)
                {
                    await _sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
                }
            }
        }

        [Fact]
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

                Assert.Single(messages);
                var message = messages[0];

                string bodyJson = GetBodyJson(message);

                var json = JsonDocument.Parse(bodyJson);
                var messageText = json.RootElement.GetProperty("Message");
                var messageSubject = json.RootElement.GetProperty("Subject");
                Assert.Equal(publishRequest.Message, messageText.ToString());
                Assert.Equal(publishRequest.Subject, messageSubject.ToString());
                var messageAttributes = json.RootElement.GetProperty("MessageAttributes");
                Assert.Equal(publishRequest.MessageAttributes.Count, messageAttributes.EnumerateObject().Count());

                foreach (var ma in publishRequest.MessageAttributes)
                {
                    var name = ma.Key;
                    var value = ma.Value;
                    Assert.True(messageAttributes.EnumerateObject().Any(x => x.Name == name));
                    var jsonAttribute = messageAttributes.GetProperty(name);
                    var jsonType = jsonAttribute.GetProperty("Type").ToString();
                    var jsonValue = jsonAttribute.GetProperty("Value").ToString();
                    Assert.NotNull(jsonType);
                    Assert.NotNull(jsonValue);
                    Assert.Equal(value.DataType, jsonType);
                    Assert.Equal(value.DataType != "Binary"
                                        ? value.StringValue
                                        : Convert.ToBase64String(value.BinaryValue.ToArray()), jsonValue);
                }

                await _sqsClient.DeleteMessageAsync(new DeleteMessageRequest
                {
                    QueueUrl = queueUrl,
                    ReceiptHandle = messages[0].ReceiptHandle
                });

                // This will unsubscribe but leave the policy in place.
                await _client.UnsubscribeAsync(new UnsubscribeRequest
                {
                    SubscriptionArn = subscriptionArn
                });

                // Subscribe again to see if this affects the policy.
                await _client.SubscribeQueueAsync(topicArn, _sqsClient, queueUrl);

                await _client.PublishAsync(new PublishRequest
                {
                    TopicArn = topicArn,
                    Message = "Test Message again"
                });

                messages = (await _sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    WaitTimeSeconds = 20
                })).Messages;

                Assert.Single(messages);

                var getAttributeResponse = await _sqsClient.GetQueueAttributesAsync(new GetQueueAttributesRequest
                {
                    AttributeNames = new List<string> { "All" },
                    QueueUrl = queueUrl
                });

                var policy = Policy.FromJson(getAttributeResponse.Policy);
                Assert.Single(policy.Statements);
            }
            finally
            {
                if (topicArn != null)
                {
                    await _client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                if (queueUrl != null)
                {
                    await _sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
                }
            }
        }

        [Fact]
        public async Task TestMultipleQueueSubscription()
        {
            var topicArns = new List<string>();

            var topicName1 = UtilityMethods.GenerateName("dotnetsdkTopic");
            topicArns.Add((await _client.CreateTopicAsync(topicName1)).TopicArn);

            var topicName2 = UtilityMethods.GenerateName("dotnetsdkTopic");
            topicArns.Add((await _client.CreateTopicAsync(topicName2)).TopicArn);

            var queueName = UtilityMethods.GenerateName("dotnetsdkQueue-");
            var queueUrl = (await _sqsClient.CreateQueueAsync(queueName)).QueueUrl;

            try
            {
                var subscriptionArns = (await _client.SubscribeQueueToTopicsAsync(topicArns, _sqsClient, queueUrl)).Values;
                Assert.Equal(2, subscriptionArns.Count);
                await Task.Delay(TimeSpan.FromSeconds(5));

                var attributes = (await _sqsClient.GetQueueAttributesAsync(queueUrl, new List<string> { "All" })).Attributes;
                var policy = Policy.FromJson(attributes["Policy"]);
                Assert.Equal(2, policy.Statements.Count);
            }
            finally
            {
                foreach (var topicArn in topicArns)
                {
                    await _client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn });
                }

                await _sqsClient.DeleteQueueAsync(new DeleteQueueRequest { QueueUrl = queueUrl });
            }
        }

        [Fact]
        public async Task FindTopic()
        {
            var name = UtilityMethods.GenerateName("dotnetsdk");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };

            var createTopicResult = await _client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                var foundTopic = await _client.FindTopicAsync(name);
                Assert.NotNull(foundTopic);
            }
            finally
            {
                await _client.DeleteTopicAsync(new DeleteTopicRequest
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

        private async Task<List<Topic>> GetAllTopics()
        {
            var allTopics = new List<Topic>();
            var listRequest = new ListTopicsRequest();
            do
            {
                var listResponse = await _client.ListTopicsAsync(listRequest);
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
            await _client.PublishAsync(publishRequest);

            var receiveResponse = await _sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest
            {
                QueueUrl = queueUrl,
                WaitTimeSeconds = 20
            });

            return receiveResponse.Messages;
        }

        private async Task<string> SubscribeQueue(string topicArn, string queueUrl)
        {
            var subscriptionARN = await _client.SubscribeQueueAsync(topicArn, _sqsClient, queueUrl);

            // Sleep to wait for the subscribe to complete.
            await Task.Delay(TimeSpan.FromSeconds(5));

            return subscriptionARN;
        }

        private async Task<string> CreateQueue()
        {
            var queueName = UtilityMethods.GenerateName("TestQueueSubscription");
            var createResponse = await _sqsClient.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = queueName
            });

            return createResponse.QueueUrl;
        }

        private async Task<string> CreateTopic()
        {
            var topicName = UtilityMethods.GenerateName("TestQueueSubscription");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = topicName
            };

            var createTopicResult = await _client.CreateTopicAsync(createTopicRequest);
            return createTopicResult.TopicArn;
        }
    }
}
