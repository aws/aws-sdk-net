using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using SNSMessageAttributeValue = Amazon.SimpleNotificationService.Model.MessageAttributeValue;
using AWSSDK.Tests.Framework;

namespace AWSSDK.IntegrationTests.SNS
{
    [TestFixture(TestOf = typeof(SNSTests))]
    [Category("Integration")]
    public class SNSTests : TestBase<AmazonSimpleNotificationServiceClient>
    {
        [Test]
        [Category("WWW")]
        public void CRUDTopics()
        {
            // list all topics
            var allTopics = GetAllTopics();
            var currentTopicCount = allTopics.Count;

            // create new topic
            var name = "unitysdk" + DateTime.Now.Ticks;


            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string topicArn = null;
            Client.CreateTopicAsync(new CreateTopicRequest
            {
                Name = name
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    topicArn = response.Response.TopicArn;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(topicArn);

            try
            {
                // verify there is a new topic
                allTopics = GetAllTopics();
                Assert.AreNotEqual(currentTopicCount, allTopics.Count);

                // set topic attribute

                var attributeName = "DisplayName";
                var attributeValue = "Test topic";
                Client.SetTopicAttributesAsync(new SetTopicAttributesRequest
                {
                    TopicArn = topicArn,
                    AttributeName = attributeName,
                    AttributeValue = attributeValue
                },
                (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);

                // verify topic attributes
                Dictionary<string, string> attributes = null;
                Client.GetTopicAttributesAsync(new GetTopicAttributesRequest
                {
                    TopicArn = topicArn
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
                Assert.AreEqual(attributeValue,
                    attributes[attributeName]);

            }
            finally
            {
                // delete new topic
                Client.DeleteTopicAsync(new DeleteTopicRequest
                {
                    TopicArn = topicArn
                },
                (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);

                // verify the topic was deleted
                allTopics = GetAllTopics();
                Assert.AreEqual(currentTopicCount, allTopics.Count);
            }
        }

        [Test]
        [Category("WWW")]
        public void TestPublishAsJson()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            // create new topic
            string topicArn = null;
            var name = "unitysdk" + DateTime.Now.Ticks;
            Client.CreateTopicAsync(new CreateTopicRequest
            {
                Name = name
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    topicArn = response.Response.TopicArn;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            try
            {
                Client.PublishAsync(new PublishRequest()
                {
                    TopicArn = topicArn,
                    MessageStructure = "json",
                    Message = "{\"default\" : \"Data\"}"
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);

                var x = new PublishRequest()
                {
                    TopicArn = topicArn,
                    MessageStructure = "json",
                    Message = "stuff"
                };
                Client.PublishAsync(x, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNotNull(responseException);
                var invalidParameterResponse = responseException as InvalidParameterException;
                Assert.AreEqual("InvalidParameter", invalidParameterResponse.ErrorCode);
                Utils.AssertTrue(invalidParameterResponse.Message.Contains("parse"));
            }
            finally
            {
                Client.DeleteTopicAsync(new DeleteTopicRequest { TopicArn = topicArn }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                });
                ars.WaitOne();
                Assert.IsNull(responseException);
            }
        }

        // Constraints:
        // to run this test, a valid email address must be supplied and
        // the subscription confirmed within two minutes by default
        //[Test]
        // [Category("WWW")]
        public void SubscribeTopicTest()
        {
            const string emailAddress = "replaceme@example.com";
            var subscriptionWaitDelay = TimeSpan.FromMinutes(2);

            // create new topic
            var name = "unitysdk" + DateTime.Now.Ticks;

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string topicArn = null;
            Client.CreateTopicAsync(new CreateTopicRequest
            {
                Name = name
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    topicArn = response.Response.TopicArn;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            try
            {
                // subscribe an email address to the topic
                Client.SubscribeAsync(new SubscribeRequest
                {
                    Protocol = "email",
                    Endpoint = emailAddress,
                    TopicArn = topicArn
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                });
                ars.WaitOne();
                Assert.IsNull(responseException);

                // wait until subscription has been confirmed, maximum wait time of two minutes
                // by default
                string subArn = null;
                var latest = DateTime.Now + subscriptionWaitDelay;
                while (DateTime.Now < latest)
                {
                    List<Subscription> subscriptions = null;
                    // get subscriptions for topic
                    Client.ListSubscriptionsByTopicAsync(new ListSubscriptionsByTopicRequest
                    {
                        TopicArn = topicArn
                    }, (response) =>
                    {
                        responseException = response.Exception;
                        if (responseException == null)
                        {
                            subscriptions = response.Response.Subscriptions;
                        }
                        ars.Set();
                    }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                    ars.WaitOne();
                    Assert.IsNull(responseException);
                    Assert.AreEqual(1, subscriptions.Count);

                    // test whether the subscription has been confirmed
                    var subscription = subscriptions[0];
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
                Client.PublishAsync(new PublishRequest
                {
                    TopicArn = topicArn,
                    Subject = "Test subject",
                    Message = "Test message"
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);

                // delete the subscription
                Client.UnsubscribeAsync(new UnsubscribeRequest
                {
                    SubscriptionArn = subArn
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
            }
            finally
            {
                // delete the topic
                Client.DeleteTopicAsync(new DeleteTopicRequest
                {
                    TopicArn = topicArn
                }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
            }
        }

        private List<Topic> GetAllTopics()
        {
            var allTopics = new List<Topic>();
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            var listRequest = new ListTopicsRequest();
            do
            {
                Client.ListTopicsAsync(listRequest, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        allTopics.AddRange(response.Response.Topics);
                        listRequest.NextToken = response.Response.NextToken;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
            } while (!string.IsNullOrEmpty(listRequest.NextToken));
            return allTopics;
        }
    }
}
