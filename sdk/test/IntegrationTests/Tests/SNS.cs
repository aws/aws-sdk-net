using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Amazon.Auth.AccessControlPolicy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;

using SNSMessageAttributeValue = Amazon.SimpleNotificationService.Model.MessageAttributeValue;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class SNS : TestBase<AmazonSimpleNotificationServiceClient>
    {

        static AmazonSQSClient sqsClient;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            sqsClient = new AmazonSQSClient();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
            if (sqsClient != null)
            {
                sqsClient.Dispose();
                sqsClient = null;
            }
        }

        [TestMethod]
        [TestCategory("SimpleNotificationService")]
        public void CRUDTopics()
        {
            // list all topics
            var allTopics = GetAllTopics();
            var currentTopicCount = allTopics.Count;

            // create new topic
            var name = "dotnetsdk" + DateTime.Now.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = Client.CreateTopic(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                // verify there is a new topic
                allTopics = GetAllTopics();
                Assert.AreNotEqual(currentTopicCount, allTopics.Count);

                // set topic attribute
                var setTopicAttributesRequest = new SetTopicAttributesRequest
                {
                    TopicArn = topicArn,
                    AttributeName = "DisplayName",
                    AttributeValue = "Test topic"
                };
                Client.SetTopicAttributes(setTopicAttributesRequest);

                // verify topic attributes
                var getTopicAttributesRequest = new GetTopicAttributesRequest
                {
                    TopicArn = topicArn
                };
                var topicAttributes =
                    Client.GetTopicAttributes(getTopicAttributesRequest).Attributes;
                Assert.AreEqual(setTopicAttributesRequest.AttributeValue,
                    topicAttributes[setTopicAttributesRequest.AttributeName]);

            }
            finally
            {
                // delete new topic
                var deleteTopicRequest = new DeleteTopicRequest
                {
                    TopicArn = topicArn
                };
                Client.DeleteTopic(deleteTopicRequest);

                // verify the topic was deleted
                allTopics = GetAllTopics();
                Assert.AreEqual(currentTopicCount, allTopics.Count);
            }
        }

        // Constraints:
        // to run this test, a valid email address must be supplied and
        // the subscription confirmed within two minutes by default
        //[TestMethod]
        [TestCategory("SNS")]
        public void SubscribeTopic()
        {
            const string emailAddress = "replaceme@example.com";
            var subscriptionWaitDelay = TimeSpan.FromMinutes(2);

            // create new topic
            var name = "dotnetsdk" + DateTime.Now.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = Client.CreateTopic(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                // subscribe an email address to the topic
                var subscribeRequest = new SubscribeRequest
                {
                    Protocol = "email",
                    Endpoint = emailAddress,
                    TopicArn = topicArn
                };
                Client.Subscribe(subscribeRequest);

                // wait until subscription has been confirmed, maximum wait time of two minutes
                // by default
                string subArn = null;
                var latest = DateTime.Now + subscriptionWaitDelay;
                while (DateTime.Now < latest)
                {
                    // get subscriptions for topic
                    var listSubscriptionsRequest = new ListSubscriptionsByTopicRequest
                    {
                        TopicArn = topicArn
                    };
                    var subs = Client.ListSubscriptionsByTopic(listSubscriptionsRequest).Subscriptions;
                    Assert.AreEqual(1, subs.Count);

                    // test whether the subscription has been confirmed
                    var subscription = subs[0];
                    if (!string.Equals(subscription.SubscriptionArn, "PendingConfirmation", StringComparison.Ordinal))
                    {
                        subArn = subscription.SubscriptionArn;
                        break;
                    }

                    // wait
                    Thread.Sleep(TimeSpan.FromSeconds(15));
                }

                // verify that the subscription was confirmed and the arn has been set
                Assert.IsNotNull(subArn);

                // publish a message to the topic
                Client.Publish(new PublishRequest
                {
                    TopicArn = topicArn,
                    Subject = "Test subject",
                    Message = "Test message"
                });

                // delete the subscription
                Client.Unsubscribe(new UnsubscribeRequest
                {
                    SubscriptionArn = subArn
                });
            }
            finally
            {
                // delete the topic
                var deleteTopicRequest = new DeleteTopicRequest
                {
                    TopicArn = topicArn
                };
                Client.DeleteTopic(deleteTopicRequest);
            }
        }

        [TestMethod]
        [TestCategory("SimpleNotificationService")]
        public void TestPublishAsJson()
        {
            // create new topic
            var name = "dotnetsdk" + DateTime.Now.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = Client.CreateTopic(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                var pubRequest = new PublishRequest()
                {
                    TopicArn = topicArn,
                    MessageStructure = "json",
                    Message = "stuff"
                };

                var gotException = true;
                try
                {
                    Client.Publish(pubRequest);
                    gotException = false;
                }
                catch (AmazonSimpleNotificationServiceException e)
                {
                    Assert.AreEqual("InvalidParameter", e.ErrorCode);
                    Assert.IsTrue(e.Message.Contains("parse"));
                }
                Assert.IsTrue(gotException, "Failed to get exception about invalid JSON");

                pubRequest.Message = "{\"default\" : \"Data\"}";
                Client.Publish(pubRequest);
            }
            finally
            {
                Client.DeleteTopic(new DeleteTopicRequest { TopicArn = topicArn });
            }
        }

        [TestMethod]
        [TestCategory("SimpleNotificationService")]
        public void TestQueueSubscription()
        {
            // create new topic
            var topicName = "dotnetsdkTopic" + DateTime.Now.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = topicName
            };
            var createTopicResult = Client.CreateTopic(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            var queueName = "dotnetsdkQueue-" + DateTime.Now.Ticks;
            var queueUrl = sqsClient.CreateQueue(new CreateQueueRequest
            {
                QueueName = queueName
            }).QueueUrl;

            try
            {
                var subscriptionARN = Client.SubscribeQueue(topicArn, sqsClient, queueUrl);

                // Sleep to wait for the subscribe to complete.
                Thread.Sleep(TimeSpan.FromSeconds(5));

                var publishRequest = new PublishRequest
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
                Client.Publish(publishRequest);

                var messages = sqsClient.ReceiveMessage(new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    WaitTimeSeconds = 20
                }).Messages;

                Assert.AreEqual(1, messages.Count);
                var message = messages[0];

                string bodyJson;
                // Handle some accounts returning message body as base 64 encoded.
                if (message.Body.Trim()[0] == '{')
                    bodyJson = message.Body;
                else
                    bodyJson = Encoding.UTF8.GetString(Convert.FromBase64String(message.Body));

                var json = ThirdParty.Json.LitJson.JsonMapper.ToObject(bodyJson);
                var messageText = json["Message"];
                var messageSubject = json["Subject"];
                Assert.AreEqual(publishRequest.Message, messageText.ToString());
                Assert.AreEqual(publishRequest.Subject, messageSubject.ToString());
                var messageAttributes = json["MessageAttributes"];
                Assert.AreEqual(publishRequest.MessageAttributes.Count, messageAttributes.Count);
                foreach (var ma in publishRequest.MessageAttributes)
                {
                    var name = ma.Key;
                    var value = ma.Value;
                    Assert.IsTrue(messageAttributes.PropertyNames.Contains(name, StringComparer.Ordinal));
                    var jsonAttribute = messageAttributes[name];
                    var jsonType = jsonAttribute["Type"].ToString();
                    var jsonValue = jsonAttribute["Value"].ToString();
                    Assert.IsNotNull(jsonType);
                    Assert.IsNotNull(jsonValue);
                    Assert.AreEqual(value.DataType, jsonType);
                    Assert.AreEqual(value.DataType != "Binary"
                                        ? value.StringValue
                                        : Convert.ToBase64String(value.BinaryValue.ToArray()), jsonValue);
                }

                sqsClient.DeleteMessage(new DeleteMessageRequest
                {
                    QueueUrl = queueUrl,
                    ReceiptHandle = messages[0].ReceiptHandle
                });

                // This will unsubscribe but leave the policy in place.
                Client.Unsubscribe(new UnsubscribeRequest
                {
                    SubscriptionArn = subscriptionARN
                });

                // Subscribe again to see if this affects the policy.
                Client.SubscribeQueue(topicArn, sqsClient, queueUrl);

                Client.Publish(new PublishRequest
                {
                    TopicArn = topicArn,
                    Message = "Test Message again"
                });

                messages = sqsClient.ReceiveMessage(new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    WaitTimeSeconds = 20
                }).Messages;

                Assert.AreEqual(1, messages.Count);

                var getAttributeResponse = sqsClient.GetQueueAttributes(new GetQueueAttributesRequest
                {
                    AttributeNames = new List<string> { "All" },
                    QueueUrl = queueUrl
                });

                var policy = Policy.FromJson(getAttributeResponse.Policy);
                Assert.AreEqual(1, policy.Statements.Count);
            }
            finally
            {
                Client.DeleteTopic(new DeleteTopicRequest { TopicArn = topicArn });
                sqsClient.DeleteQueue(new DeleteQueueRequest { QueueUrl = queueUrl });
            }
        }

        [TestMethod]
        [TestCategory("SimpleNotificationService")]
        public void TestMultipleQueueSubscription()
        {
            var topicArns = new List<string>();

            var topicName1 = "dotnetsdkTopic" + DateTime.Now.Ticks;
            topicArns.Add(Client.CreateTopic(topicName1).TopicArn);

            var topicName2 = "dotnetsdkTopic" + DateTime.Now.Ticks;
            topicArns.Add(Client.CreateTopic(topicName2).TopicArn);

            var queueName = "dotnetsdkQueue-" + DateTime.Now.Ticks;
            var queueUrl = sqsClient.CreateQueue(queueName).QueueUrl;

            try
            {
                var subscriptionArns = Client.SubscribeQueueToTopics(topicArns, sqsClient, queueUrl).Values;

                Assert.AreEqual(2, subscriptionArns.Count);

                Thread.Sleep(TimeSpan.FromSeconds(5));

                var attributes = sqsClient.GetQueueAttributes(queueUrl, new List<string> { "All" }).Attributes;
                var policy = Policy.FromJson(attributes["Policy"]);

                Assert.AreEqual(2, policy.Statements.Count);
            }
            finally
            {
                foreach (var topicArn in topicArns)
                {
                    Client.DeleteTopic(new DeleteTopicRequest { TopicArn = topicArn });
                }
                sqsClient.DeleteQueue(new DeleteQueueRequest { QueueUrl = queueUrl });
            }
        }

        [TestMethod]
        [TestCategory("SimpleNotificationService")]
        public void FindTopic()
        {
            // create new topic
            var name = "dotnetsdk" + DateTime.Now.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = Client.CreateTopic(createTopicRequest);
            var topicArn = createTopicResult.TopicArn;

            try
            {
                // find the topic by name
                var foundTopic = Client.FindTopic(name);

                // verify that the topic was fund
                Assert.IsNotNull(foundTopic);
            }
            finally
            {
                // delete the topic
                var deleteTopicRequest = new DeleteTopicRequest
                {
                    TopicArn = topicArn
                };
                Client.DeleteTopic(deleteTopicRequest);
            }
        }

        private static List<Topic> GetAllTopics()
        {
            var allTopics = new List<Topic>();
            var listRequest = new ListTopicsRequest();
            do
            {
                var listResponse = Client.ListTopics(listRequest);
                allTopics.AddRange(listResponse.Topics);

                listRequest.NextToken = listResponse.NextToken;
            } while (!string.IsNullOrEmpty(listRequest.NextToken));
            return allTopics;
        }

    }
}
