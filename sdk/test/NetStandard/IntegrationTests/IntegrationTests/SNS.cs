using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Amazon.Auth.AccessControlPolicy;

using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.Runtime;

using SNSMessageAttributeValue = Amazon.SimpleNotificationService.Model.MessageAttributeValue;
using Xunit;
using Amazon.DNXCore.IntegrationTests.Common;

namespace Amazon.DNXCore.IntegrationTests
{

    public class SNS : TestBase<AmazonSimpleNotificationServiceClient>
    {
        static AmazonSQSClient sqsClient;
        private List<string> _topicArns = new List<string>();
        private List<string> _queueUrl = new List<string>();

        public SNS()
        {
            sqsClient = TestBase.CreateClient<AmazonSQSClient>();
        }
        
        protected override void Dispose(bool disposing)
        {
            foreach(string arn in _topicArns)
            {
                try
                {
                    Client.DeleteTopicAsync(new DeleteTopicRequest
                    {
                        TopicArn = arn
                    }).Wait();
                }
                catch { };
            }

            foreach (string url in _queueUrl)
            {
                try
                {
                    sqsClient.DeleteQueueAsync(new DeleteQueueRequest
                    {
                        QueueUrl = url
                    }).Wait();
                }
                catch { };
            }

            if (sqsClient != null)
            {
                sqsClient.Dispose();
                sqsClient = null;
            }
            base.Dispose(disposing);
        }
        
        [Fact]
        [Trait(CategoryAttribute,"SNS")]
        public async Task CRUDTopics()
        {
            // list all topics
            var allTopics = await GetAllTopics();

            // create new topic
            var name = UtilityMethods.GenerateName("CrudTopics");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = await Client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;
                _topicArns.Add(topicArn);

            // verify there is a new topic
            allTopics = await GetAllTopics();
            Assert.True(allTopics.Exists(t => t.TopicArn.Contains(name)));

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
            var topicAttributes =
                (await Client.GetTopicAttributesAsync(getTopicAttributesRequest)).Attributes;
            Assert.Equal(setTopicAttributesRequest.AttributeValue,
                topicAttributes[setTopicAttributesRequest.AttributeName]);

        }

        // Constraints:
        // to run this test, a valid email address must be supplied and
        // the subscription confirmed within two minutes by default
        //[Fact]
        [Trait(CategoryAttribute,"SNS")]
        public async Task SubscribeTopic()
        {
            const string emailAddress = "replaceme@example.com";
            var subscriptionWaitDelay = TimeSpan.FromMinutes(2);

            // create new topic
            var name = UtilityMethods.GenerateName("SubscribeTopic");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = await Client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;
                _topicArns.Add(topicArn);

            // subscribe an email address to the topic
            var subscribeRequest = new SubscribeRequest
            {
                Protocol = "email",
                Endpoint = emailAddress,
                TopicArn = topicArn
            };
            await Client.SubscribeAsync(subscribeRequest);

            // wait until subscription has been confirmed, maximum wait time of two minutes
            // by default
            string subArn = null;
            var latest = DateTime.UtcNow + subscriptionWaitDelay;
            while (DateTime.UtcNow < latest)
            {
                // get subscriptions for topic
                var listSubscriptionsRequest = new ListSubscriptionsByTopicRequest
                {
                    TopicArn = topicArn
                };
                var subs = (await Client.ListSubscriptionsByTopicAsync(listSubscriptionsRequest)).Subscriptions;
                Assert.Single(subs);

                // test whether the subscription has been confirmed
                var subscription = subs[0];
                if (!string.Equals(subscription.SubscriptionArn, "PendingConfirmation", StringComparison.Ordinal))
                {
                    subArn = subscription.SubscriptionArn;
                    break;
                }

                // wait
                UtilityMethods.Sleep(TimeSpan.FromSeconds(15));
            }

            // verify that the subscription was confirmed and the arn has been set
            Assert.NotNull(subArn);

            // publish a message to the topic
            await Client.PublishAsync(new PublishRequest
            {
                TopicArn = topicArn,
                Subject = "Test subject",
                Message = "Test message"
            });

            // delete the subscription
            await Client.UnsubscribeAsync(new UnsubscribeRequest
            {
                SubscriptionArn = subArn
            });
        }

        [Fact]
        [Trait(CategoryAttribute, "SNS")]
        public async Task FindTopic()
        {
            // create new topic
            var name = UtilityMethods.GenerateName("FindTopic");
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = await Client.CreateTopicAsync(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;
                _topicArns.Add(topicArn);

            var foundTopic = await Client.FindTopicAsync(name);

            // verify that the topic was fund
            Assert.NotNull(foundTopic);
        }

        private async Task<List<Topic>> GetAllTopics()
        {
            var allTopics = new List<Topic>();
            var listRequest = new ListTopicsRequest();
            do
            {
                var listResponse = await Client.ListTopicsAsync(listRequest);
                allTopics.AddRange(listResponse.Topics);

                listRequest.NextToken = listResponse.NextToken;
            } while (!string.IsNullOrEmpty(listRequest.NextToken));
            return allTopics;
        }

        [Fact]
        [Trait(CategoryAttribute, "SNS")]
        public async void IsMessageSignatureValidSHA1()
        {
            var topicArn = await CreateTopic();
            var queueUrl = await CreateQueue();
            await SubscribeQueue(topicArn, queueUrl);
            List<Message> messages = await PublishToSNSAndReceiveMessages(GetPublishRequest(topicArn), topicArn, queueUrl);

            Assert.Single(messages);
            var bodyJson = GetBodyJson(messages[0]);
            var validMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson);
            Assert.True(validMessage.IsMessageSignatureValid());

            var invalidMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson.Replace("Test Message", "Hacked Message"));
            Assert.False(invalidMessage.IsMessageSignatureValid());
        }

        [Fact]
        [Trait(CategoryAttribute, "SNS")]
        public async void IsMessageSignatureValidSHA256()
        {
            var topicArn = await CreateTopic();

            // set topic attribute
            var setTopicAttributesRequest = new SetTopicAttributesRequest
            {
                TopicArn = topicArn,
                AttributeName = "SignatureVersion",
                AttributeValue = "2"
            };
            await Client.SetTopicAttributesAsync(setTopicAttributesRequest);

            var queueUrl = await CreateQueue();
            await SubscribeQueue(topicArn, queueUrl);
            List<Message> messages = await PublishToSNSAndReceiveMessages(GetPublishRequest(topicArn), topicArn, queueUrl);

            Assert.Single(messages);
            var bodyJson = GetBodyJson(messages[0]);
            var validMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson);
            Assert.True(validMessage.IsMessageSignatureValid());

            var invalidMessage = Amazon.SimpleNotificationService.Util.Message.ParseMessage(bodyJson.Replace("Test Message", "Hacked Message"));
            Assert.False(invalidMessage.IsMessageSignatureValid());
        }

        [Fact]
        [Trait(CategoryAttribute, "SNS")]
        public async void IsMessageSignatureValidInvalidSignatureVersion()
        {
            var topicArn = await CreateTopic();
            var queueUrl = await CreateQueue();
            await SubscribeQueue(topicArn, queueUrl);
            List<Message> messages = await PublishToSNSAndReceiveMessages(GetPublishRequest(topicArn), topicArn, queueUrl);

            Assert.Single(messages);
            var bodyJson = GetBodyJson(messages[0]);

            // modify message to have invalid SignatureVersion
            var jsonData = JsonDocument.Parse(bodyJson);
            using var memoryStream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(memoryStream))
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
                string updatedJson = Encoding.UTF8.GetString(memoryStream.ToArray());

                var ex = Assert.Throws<AmazonClientException>(() => Amazon.SimpleNotificationService.Util.Message.ParseMessage(updatedJson));
                Assert.Equal("SignatureVersion is not a valid value", ex.Message);
            }
        }

        [Fact]
        [Trait(CategoryAttribute, "SNS")]
        public async void TestQueueSubscription()
        {
            var topicArn = await CreateTopic();
            var queueUrl = await CreateQueue();
            var subscriptionArn = await SubscribeQueue(topicArn, queueUrl);
            var publishRequest = GetPublishRequest(topicArn);
            List<Message> messages = await PublishToSNSAndReceiveMessages(publishRequest, topicArn, queueUrl);

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
                Assert.Contains(name, messageAttributes.EnumerateObject().Select(x => x.Name), StringComparer.Ordinal);
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
            await Client.SubscribeQueueAsync(topicArn, sqsClient as ICoreAmazonSQS, queueUrl);

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

            Assert.Single(messages);

            var response = WaitUtils.WaitForComplete(
                () => {
                    return sqsClient.GetQueueAttributesAsync(new GetQueueAttributesRequest
                    {
                        AttributeNames = new List<string> { "All" },
                        QueueUrl = queueUrl
                    }).Result;
                },
                (r) =>
                {
                    return !string.IsNullOrEmpty(r.Policy);
                });

            var policy = Policy.FromJson(response.Policy);
            Assert.Single(policy.Statements);
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

        [Trait(CategoryAttribute, "SNS")]
        public async void TestMultipleQueueSubscription()
        {
            var topicName1 = UtilityMethods.GenerateName("TestMultipleQueueSubscription");
            var topic = await Client.CreateTopicAsync(topicName1);
                _topicArns.Add(topic.TopicArn);

            var topicName2 = UtilityMethods.GenerateName("TestMultipleQueueSubscription2");
            var response = await Client.CreateTopicAsync(topicName2);
                _topicArns.Add(response.TopicArn);

            var queueName = UtilityMethods.GenerateName("TestMultipleQueueSubscription");
            var queueUrl = (await sqsClient.CreateQueueAsync(queueName)).QueueUrl;
                _queueUrl.Add(queueUrl);

            ICoreAmazonSQS coreSqs = sqsClient as ICoreAmazonSQS;
            var topics = await Client.SubscribeQueueToTopicsAsync(_topicArns, coreSqs, queueUrl);
            var subscriptionArns = topics.Values;

            Assert.Equal(2, subscriptionArns.Count);

            Thread.Sleep(TimeSpan.FromSeconds(5));

            var attributes = (await sqsClient.GetQueueAttributesAsync(queueUrl, new List<string> { "All" })).Attributes;
            var policy = Policy.FromJson(attributes["Policy"]);

            Assert.Equal(2, policy.Statements.Count);
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

        private async Task<List<Message>> PublishToSNSAndReceiveMessages(PublishRequest publishRequest, string topicArn, string queueUrl)
        {
            await Client.PublishAsync(publishRequest);

            var messages = (await sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest
            {
                QueueUrl = queueUrl,
                WaitTimeSeconds = 20
            })).Messages;
            return messages;
        }

        private async Task<string> SubscribeQueue(string topicArn, string queueUrl)
        {
            ICoreAmazonSQS coreSqs = sqsClient as ICoreAmazonSQS;
            var subscriptionARN = await Client.SubscribeQueueAsync(topicArn, coreSqs, queueUrl);

            // Sleep to wait for the subscribe to complete.
            Thread.Sleep(TimeSpan.FromSeconds(5));

            return subscriptionARN;
        }

        private async Task<string> CreateQueue()
        {
            var queueName = UtilityMethods.GenerateName("TestQueueSubscription");
            var queueUrl = (await sqsClient.CreateQueueAsync(new CreateQueueRequest
            {
                QueueName = queueName
            })).QueueUrl;
            _queueUrl.Add(queueUrl);
            return queueUrl;
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
            var topicArn = createTopicResult.TopicArn;
            _topicArns.Add(topicArn);
            return topicArn;
        }

    }
}
