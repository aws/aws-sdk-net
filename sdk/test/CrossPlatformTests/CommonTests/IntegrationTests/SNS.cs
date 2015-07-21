using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Amazon.Auth.AccessControlPolicy;

using System.Threading;



using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;

using SNSMessageAttributeValue = Amazon.SimpleNotificationService.Model.MessageAttributeValue;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class SNS : TestBase<AmazonSimpleNotificationServiceClient>
    {
        static AmazonSQSClient sqsClient;

        [OneTimeSetUp]
        public void ClassInitialize()
        {
            sqsClient = TestBase.CreateClient<AmazonSQSClient>();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
            if (sqsClient != null)
            {
                sqsClient.Dispose();
                sqsClient = null;
            }
        }

        [Test]
        [Category("SNS")]
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
            var createTopicResult = Client.CreateTopicAsync(createTopicRequest).Result;
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
                Client.SetTopicAttributesAsync(setTopicAttributesRequest).Wait();

                // verify topic attributes
                var getTopicAttributesRequest = new GetTopicAttributesRequest
                {
                    TopicArn = topicArn
                };
                var topicAttributes =
                    Client.GetTopicAttributesAsync(getTopicAttributesRequest).Result.Attributes;
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
                Client.DeleteTopicAsync(deleteTopicRequest).Wait();

                // verify the topic was deleted
                allTopics = GetAllTopics();
                Assert.AreEqual(currentTopicCount, allTopics.Count);
            }
        }

        // Constraints:
        // to run this test, a valid email address must be supplied and
        // the subscription confirmed within two minutes by default
        //[Test]
        [Category("SNS")]
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
            var createTopicResult = Client.CreateTopicAsync(createTopicRequest).Result;
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
                Client.SubscribeAsync(subscribeRequest).Wait();

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
                    var subs = Client.ListSubscriptionsByTopicAsync(listSubscriptionsRequest).Result.Subscriptions;
                    Assert.AreEqual(1, subs.Count);

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
                Assert.IsNotNull(subArn);

                // publish a message to the topic
                Client.PublishAsync(new PublishRequest
                {
                    TopicArn = topicArn,
                    Subject = "Test subject",
                    Message = "Test message"
                }).Wait();

                // delete the subscription
                Client.UnsubscribeAsync(new UnsubscribeRequest
                {
                    SubscriptionArn = subArn
                }).Wait();
            }
            finally
            {
                // delete the topic
                var deleteTopicRequest = new DeleteTopicRequest
                {
                    TopicArn = topicArn
                };
                Client.DeleteTopicAsync(deleteTopicRequest).Wait();
            }
        }

        [Test]
        [Category("SNS")]
        public void TestPublishAsJson()
        {
            // create new topic
            var name = "dotnetsdk" + DateTime.Now.Ticks;
            var createTopicRequest = new CreateTopicRequest
            {
                Name = name
            };
            var createTopicResult = Client.CreateTopicAsync(createTopicRequest).Result;
            var topicArn = createTopicResult.TopicArn;

            try
            {
                var pubRequest = new PublishRequest()
                {
                    TopicArn = topicArn,
                    MessageStructure = "json",
                    Message = "stuff"
                };

                var e = AssertExtensions.ExpectExceptionAsync<InvalidParameterException>(Client.PublishAsync(pubRequest)).Result;
                Assert.AreEqual("InvalidParameter", e.ErrorCode);
                Assert.IsTrue(e.Message.Contains("parse"));

                pubRequest.Message = "{\"default\" : \"Data\"}";
                Client.PublishAsync(pubRequest).Wait();
            }
            finally
            {
                Client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn }).Wait();
            }
        }

        private List<Topic> GetAllTopics()
        {
            var allTopics = new List<Topic>();
            var listRequest = new ListTopicsRequest();
            do
            {
                var listResponse = Client.ListTopicsAsync(listRequest).Result;
                allTopics.AddRange(listResponse.Topics);

                listRequest.NextToken = listResponse.NextToken;
            } while (!string.IsNullOrEmpty(listRequest.NextToken));
            return allTopics;
        }

    }
}
