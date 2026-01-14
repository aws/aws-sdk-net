using Amazon.Auth.AccessControlPolicy;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class NotificationTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;
        private static string topicArn;
        private static AmazonSimpleNotificationServiceClient snsClient;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext tc)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);

            snsClient = new AmazonSimpleNotificationServiceClient(region: Client.Config.RegionEndpoint);
            var snsCreateResponse = snsClient.CreateTopic("events-test-" + DateTime.UtcNow.Ticks);
            topicArn = snsCreateResponse.TopicArn;
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            
            await snsClient.DeleteTopicAsync(topicArn);
            snsClient.Dispose();

            BaseClean();
        }

        [TestMethod]
        public async Task SetTopicConfigurationTests()
        {
            using (var stsClient = new AmazonSecurityTokenServiceClient(region: Client.Config.RegionEndpoint))
            {
                await snsClient.AuthorizeS3ToPublishAsync(topicArn, bucketName);
                await Client.PutBucketNotificationAsync(new PutBucketNotificationRequest
                {
                    BucketName = bucketName,
                    TopicConfigurations = new List<TopicConfiguration>
                    {
                        new TopicConfiguration
                        {
                            Id = "the-topic-test",
                            Topic = topicArn,
                            Events = new List<EventType> { EventType.ObjectCreatedPut }
                        }
                    }
                });

                var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
                {
                    var res = await Client.GetBucketNotificationAsync(bucketName);
                    return res.TopicConfigurations?.Count > 0 && res.TopicConfigurations[0].Id == "the-topic-test" ? res : null;
                });

                var getAttributeResponse = await snsClient.GetTopicAttributesAsync(new GetTopicAttributesRequest
                {
                    TopicArn = topicArn
                });
                var policy = Policy.FromJson(getAttributeResponse.Attributes["Policy"]);

                // SNS topics already have a default statement. We need to evaluate the second statement that the SDK appended.
                var conditions = policy.Statements[1].Conditions;
                Assert.AreEqual(2, conditions.Count);

                var accountCondition = conditions.FirstOrDefault(x => string.Equals(x.ConditionKey, ConditionFactory.SOURCE_ACCOUNT_KEY));
                Assert.IsNotNull(accountCondition);
                Assert.AreEqual(ConditionFactory.StringComparisonType.StringEquals.ToString(), accountCondition.Type);
                Assert.AreEqual(12, accountCondition.Values[0].Length);

                var currentAccountId = (await stsClient.GetCallerIdentityAsync(new GetCallerIdentityRequest())).Account;
                Assert.AreEqual(currentAccountId, accountCondition.Values[0]);
                Assert.AreEqual(1, getResponse.TopicConfigurations.Count);
                Assert.AreEqual(1, getResponse.TopicConfigurations[0].Events.Count);
                Assert.AreEqual(EventType.ObjectCreatedPut, getResponse.TopicConfigurations[0].Events[0]);
                Assert.AreEqual("s3:ObjectCreated:Put", getResponse.TopicConfigurations[0].Events[0].Value);
                Assert.AreEqual("the-topic-test", getResponse.TopicConfigurations[0].Id);
                Assert.AreEqual(topicArn, getResponse.TopicConfigurations[0].Topic);
            }
        }

        [TestMethod]
        public async Task PutAndGetEventBridgeConfigurationTest()
        {
            var putResponse = await Client.PutBucketNotificationAsync(new PutBucketNotificationRequest
            {
                BucketName = bucketName,
                EventBridgeConfiguration = new EventBridgeConfiguration(),
                SkipDestinationValidation = true
            });
            Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);

            var getResponse = await Client.GetBucketNotificationAsync(new GetBucketNotificationRequest
            {
                BucketName = bucketName,
            });
            Assert.IsNotNull(getResponse.EventBridgeConfiguration);
        }
    }
}