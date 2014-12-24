using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

using Amazon.Auth.AccessControlPolicy;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService.Resources;
using Amazon.SQS;
using Amazon.SQS.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using SNSMessageAttributeValue = Amazon.SimpleNotificationService.Model.MessageAttributeValue;

namespace AWSSDK_DotNet.IntegrationTests.Tests.ResourcesAPI
{
    [TestClass]
    public class SNSResources
    {
        static AmazonSimpleNotificationServiceClient snsClient;
        static AmazonSQSClient sqsClient;
        static SimpleNotificationService sns;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            sqsClient = new AmazonSQSClient();
            snsClient = new AmazonSimpleNotificationServiceClient();
            sns = new SimpleNotificationService(snsClient);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            //BaseClean();
            if (sqsClient != null)
            {
                sqsClient.Dispose();
                sqsClient = null;
            }
            if (snsClient != null)
            {
                snsClient.Dispose();
                snsClient = null;
            }
            if (sns != null)
            {
                sns.Dispose();
            }
        }

        [TestMethod]
        [TestCategory("SNS")]
        public void CRUDTopics()
        {
            // list all topics
            var allTopics = sns.GetTopics().ToList();
            var currentTopicCount = allTopics.Count;

            // create new topic
            var name = "dotnetsdk" + DateTime.Now.Ticks;
            var topic = sns.CreateTopic(name);
            var topicArn = topic.Arn;

            try
            {
                // verify there is a new topic
                allTopics = sns.GetTopics().ToList();
                Assert.AreNotEqual(currentTopicCount, allTopics.Count);

                // set topic attribute
                string attributeName = "DisplayName";
                string attributeValue = "TestTopic";
                topic.SetAttributes(attributeName, attributeValue);

                // verify topic attributes
                var topicAttributes = topic.Attributes;
                Assert.AreEqual(attributeValue, topicAttributes[attributeName]);
            }
            finally
            {
                // delete new topic
                topic.Delete();

                // verify the topic was deleted
                allTopics = sns.GetTopics().ToList();
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
            var topic = sns.CreateTopic(name);

            try
            {
                // subscribe an email address to the topic
                var subscription = topic.Subscribe(emailAddress, "email");

                // wait until subscription has been confirmed, maximum wait time of two minutes
                // by default
                string subArn = null;
                var latest = DateTime.Now + subscriptionWaitDelay;
                while (DateTime.Now < latest)
                {
                    // get subscriptions for topic
                    var subs = topic.GetSubscriptions().ToList();
                    Assert.AreEqual(1, subs.Count);

                    // test whether the subscription has been confirmed
                    subscription = subs[0];
                    if (!string.Equals(subscription.Arn, "PendingConfirmation", StringComparison.Ordinal))
                    {
                        subArn = subscription.Arn;
                        break;
                    }

                    // wait
                    Thread.Sleep(TimeSpan.FromSeconds(15));
                }

                // verify that the subscription was confirmed and the arn has been set
                Assert.IsNotNull(subArn);

                var attributes = subscription.Attributes;
                Assert.AreNotEqual(0, attributes.Count);
                AssertExtensions.ExpectException(() => subscription.SetAttributes("RawMessageDelivery", "true"));

                // publish a message to the topic
                topic.Publish("Test message", "Test subject");

                // delete the subscription
                subscription.Delete();
            }
            finally
            {
                // delete the topic
                topic.Delete();
            }
        }

        [TestMethod]
        [TestCategory("SNS")]
        public void TestPublishAsJson()
        {
            // create new topic
            var name = "dotnetsdk" + DateTime.Now.Ticks;
            var topic = sns.CreateTopic(name);
            var topicArn = topic.Arn;

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
                    topic.Publish(pubRequest);
                    gotException = false;
                }
                catch (AmazonSimpleNotificationServiceException e)
                {
                    Assert.AreEqual("InvalidParameter", e.ErrorCode);
                    Assert.IsTrue(e.Message.Contains("parse"));
                }
                Assert.IsTrue(gotException, "Failed to get exception about invalid JSON");

                pubRequest.Message = "{\"default\" : \"Data\"}";
                topic.Publish(pubRequest);
            }
            finally
            {
                topic.Delete();
            }
        }

        [TestMethod]
        [TestCategory("SNS")]
        public void TestQueueSubscription()
        {
            // create new topic
            var topicName = "dotnetsdkTopic" + DateTime.Now.Ticks;
            var topic = sns.CreateTopic(topicName);
            var topicArn = topic.Arn;

            var queueName = "dotnetsdkQueue-" + DateTime.Now.Ticks;
            var queueUrl = sqsClient.CreateQueue(new CreateQueueRequest
            {
                QueueName = queueName
            }).QueueUrl;

            try
            {
                var subscriptionARN = snsClient.SubscribeQueue(topicArn, sqsClient, queueUrl);
                var subscription = sns.GetSubscriptionByArn(subscriptionARN);

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
                topic.Publish(publishRequest);

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
                subscription.Delete();

                // Subscribe again to see if this affects the policy.
                snsClient.SubscribeQueue(topicArn, sqsClient, queueUrl);

                topic.Publish("Test Message again");

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
                topic.Delete();
                sqsClient.DeleteQueue(new DeleteQueueRequest { QueueUrl = queueUrl });
            }
        }
    }
}
