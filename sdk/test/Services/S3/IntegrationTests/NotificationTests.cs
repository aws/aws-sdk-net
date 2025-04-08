using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;

using Amazon.Auth.AccessControlPolicy;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

using Amazon.SQS;
using Amazon.SQS.Model;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class NotificationTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void SetTopicConfigurationTests()
        {
            var s3Config = new AmazonS3Config();
            using (var s3Client = new AmazonS3Client(s3Config))
            using (var snsClient = new AmazonSimpleNotificationServiceClient())
            using (var stsClient = new AmazonSecurityTokenServiceClient())
            {
                var snsCreateResponse = snsClient.CreateTopic("events-test-" + DateTime.UtcNow.Ticks);
                var bucketName = S3TestUtils.CreateBucketWithWait(s3Client);

                try
                {
                    snsClient.AuthorizeS3ToPublish(snsCreateResponse.TopicArn, bucketName);

                    PutBucketNotificationRequest putRequest = new PutBucketNotificationRequest
                    {
                        BucketName = bucketName,
                        TopicConfigurations = new List<TopicConfiguration>
                        {
                            new TopicConfiguration
                            {
                                Id = "the-topic-test",
                                Topic = snsCreateResponse.TopicArn,
                                Events = new List<EventType>{EventType.ObjectCreatedPut}
                            }
                        }
                    };

                    s3Client.PutBucketNotification(putRequest);
                                        
                    var getResponse = S3TestUtils.WaitForConsistency(() =>
                    {
                        var res = s3Client.GetBucketNotification(bucketName);
                        return res.TopicConfigurations?.Count > 0 && res.TopicConfigurations[0].Id == "the-topic-test" ? res : null;
                    });

                    var getAttributeResponse = snsClient.GetTopicAttributes(new GetTopicAttributesRequest
                    {
                        TopicArn = snsCreateResponse.TopicArn
                    });

                    var policy = Policy.FromJson(getAttributeResponse.Attributes["Policy"]);

                    // SNS topics already have a default statement. We need to evaluate the second statement that the SDK appended.
                    var conditions = policy.Statements[1].Conditions;
                    Assert.AreEqual(2, conditions.Count);

                    var accountCondition = conditions.FirstOrDefault(x => string.Equals(x.ConditionKey, ConditionFactory.SOURCE_ACCOUNT_KEY));
                    Assert.IsNotNull(accountCondition);
                    Assert.AreEqual(ConditionFactory.StringComparisonType.StringEquals.ToString(), accountCondition.Type);
                    Assert.AreEqual(12, accountCondition.Values[0].Length);

                    var currentAccountId = stsClient.GetCallerIdentity(new GetCallerIdentityRequest()).Account;
                    Assert.AreEqual(currentAccountId, accountCondition.Values[0]);

                    Assert.AreEqual(1, getResponse.TopicConfigurations.Count);
                    Assert.AreEqual(1, getResponse.TopicConfigurations[0].Events.Count);
                    Assert.AreEqual(EventType.ObjectCreatedPut, getResponse.TopicConfigurations[0].Events[0]);

                    Assert.AreEqual("s3:ObjectCreated:Put", getResponse.TopicConfigurations[0].Events[0].Value);
                    Assert.AreEqual("the-topic-test", getResponse.TopicConfigurations[0].Id);
                    Assert.AreEqual(snsCreateResponse.TopicArn, getResponse.TopicConfigurations[0].Topic);

                }
                finally
                {
                    snsClient.DeleteTopic(snsCreateResponse.TopicArn);
                    AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [Ignore]
        public void SetQueueConfigurationTests()
        {
            var filterRule = new FilterRule("Prefix", "test/");
            var s3Config = new AmazonS3Config();
            using (var s3Client = new AmazonS3Client(s3Config))
            using (var sqsClient = new AmazonSQSClient())
            using (var stsClient = new AmazonSecurityTokenServiceClient())
            {
                var createResponse = sqsClient.CreateQueue("events-test-" + DateTime.UtcNow.Ticks);
                var bucketName = S3TestUtils.CreateBucketWithWait(s3Client);
                
                try
                {
                    var queueArn = sqsClient.AuthorizeS3ToSendMessage(createResponse.QueueUrl, bucketName);

                    PutBucketNotificationRequest putRequest = new PutBucketNotificationRequest
                    {
                        BucketName = bucketName,
                        QueueConfigurations = new List<QueueConfiguration>
                        {
                            new QueueConfiguration
                            {
                                Id = "the-queue-test",
                                Queue = queueArn,
                                Events = new List<EventType>{EventType.ObjectCreatedPut},
                                Filter = new Filter
                                {
                                    S3KeyFilter = new S3KeyFilter
                                    {
                                        FilterRules = new List<FilterRule> 
                                        {
                                            filterRule
                                        }
                                    }
                                }
                            }
                        }
                    };

                    s3Client.PutBucketNotification(putRequest);

                    var getResponse = S3TestUtils.WaitForConsistency(() =>
                    {
                        var res = s3Client.GetBucketNotification(bucketName);
                        return res.QueueConfigurations?.Count > 0 && res.QueueConfigurations[0].Id == "the-queue-test" ? res : null;
                    });

                    var getAttributeResponse = sqsClient.GetQueueAttributes(new GetQueueAttributesRequest
                    {
                        QueueUrl = createResponse.QueueUrl,
                        AttributeNames = new List<string> { "All" }
                    });

                    var policy = Policy.FromJson(getAttributeResponse.Policy);
                    var conditions = policy.Statements[0].Conditions;
                    Assert.AreEqual(2, conditions.Count);

                    var accountCondition = conditions.FirstOrDefault(x => string.Equals(x.ConditionKey, ConditionFactory.SOURCE_ACCOUNT_KEY));
                    Assert.IsNotNull(accountCondition);
                    Assert.AreEqual(ConditionFactory.StringComparisonType.StringEquals.ToString(), accountCondition.Type);
                    Assert.AreEqual(12, accountCondition.Values[0].Length);

                    var currentAccountId = stsClient.GetCallerIdentity(new GetCallerIdentityRequest()).Account;
                    Assert.AreEqual(currentAccountId, accountCondition.Values[0]);


                    Assert.AreEqual(1, getResponse.QueueConfigurations.Count);
                    Assert.AreEqual(1, getResponse.QueueConfigurations[0].Events.Count);
                    Assert.AreEqual(EventType.ObjectCreatedPut, getResponse.QueueConfigurations[0].Events[0]);

                    Assert.IsNotNull(getResponse.QueueConfigurations[0].Filter);
                    Assert.IsNotNull(getResponse.QueueConfigurations[0].Filter.S3KeyFilter);
                    Assert.IsNotNull(getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules);
                    Assert.AreEqual(1, getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules.Count);
                    Assert.AreEqual(filterRule.Name, getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules[0].Name);
                    Assert.AreEqual(filterRule.Value, getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules[0].Value);

                    Assert.AreEqual("the-queue-test", getResponse.QueueConfigurations[0].Id);
                    Assert.AreEqual(queueArn, getResponse.QueueConfigurations[0].Queue);

                    // Purge queue to remove test message sent configuration was setup.
                    sqsClient.PurgeQueue(createResponse.QueueUrl);
                    //We must wait 60 seconds or the next message being sent to the queue could be deleted while the queue is being purged.
                    Thread.Sleep(TimeSpan.FromSeconds(60));                    

                    var putObjectRequest = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = "test/data.txt",
                        ContentBody = "Important Data"
                    };

                    s3Client.PutObject(putObjectRequest);

                    string messageBody = null;
                    for (int i = 0; i < 5 && messageBody == null; i++)
                    {
                         var receiveResponse = sqsClient.ReceiveMessage(new ReceiveMessageRequest { QueueUrl = createResponse.QueueUrl, WaitTimeSeconds = 20 });
                        if (receiveResponse.Messages.Count != 0)
                        {
                            messageBody = receiveResponse.Messages[0].Body;
                        }
                    }


                    var evnt = S3EventNotification.ParseJson(messageBody);

                    Assert.AreEqual(1, evnt.Records.Count);
                    Assert.AreEqual(putObjectRequest.BucketName, evnt.Records[0].S3.Bucket.Name);
                    Assert.AreEqual(putObjectRequest.Key, evnt.Records[0].S3.Object.Key);
                    Assert.AreEqual(putObjectRequest.ContentBody.Length, evnt.Records[0].S3.Object.Size);
                    Assert.IsNotNull(evnt.Records[0].S3.Object.Sequencer);
                }
                finally
                {
                    sqsClient.DeleteQueue(createResponse.QueueUrl);
                    AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
                }
            }
        }

        /// <summary>
        /// Tests configuring delivery of bucket events to EventBridge
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void PutAndGetEventBridgeConfigurationTest()
        {
            using (var s3Client = new AmazonS3Client())
            {
                var bucketName = S3TestUtils.CreateBucketWithWait(s3Client);

                try
                {
                    var putRequest = new PutBucketNotificationRequest()
                    {
                        BucketName = bucketName,
                        EventBridgeConfiguration = new EventBridgeConfiguration(),
                        SkipDestinationValidation = true
                    };

                    var putResponse = s3Client.PutBucketNotification(putRequest);

                    Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);

                    var getRequest = new GetBucketNotificationRequest
                    {
                        BucketName = bucketName
                    };

                    var getResponse = s3Client.GetBucketNotification(getRequest);

                    Assert.IsNotNull(getResponse.EventBridgeConfiguration);
                }
                finally 
                {
                    AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
                }
            }
        }
    }
}