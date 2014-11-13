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
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;

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

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
        /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class NotificationTests
    {
        [TestMethod]
        public void SetTopicConfigurationTests()
        {
            var s3Config = new AmazonS3Config();
            using(var s3Client = new AmazonS3Client(s3Config))
            using (var snsClient = new AmazonSimpleNotificationServiceClient())
            {
                var snsCreateResponse = snsClient.CreateTopic("events-test-" + DateTime.Now.Ticks);
                var bucketName = S3TestUtils.CreateBucket(s3Client);

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

                    var getResponse = s3Client.GetBucketNotification(bucketName);

                    Assert.AreEqual(1, getResponse.TopicConfigurations.Count);
                    Assert.AreEqual(1, getResponse.TopicConfigurations[0].Events.Count);
                    Assert.AreEqual(EventType.ObjectCreatedPut, getResponse.TopicConfigurations[0].Events[0]);

#pragma warning disable 618
                    Assert.AreEqual("s3:ObjectCreated:Put", getResponse.TopicConfigurations[0].Event);
#pragma warning restore 618
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
        public void SetQueueConfigurationTests()
        {
            var s3Config = new AmazonS3Config();
            using (var s3Client = new AmazonS3Client(s3Config))
            using (var sqsClient = new AmazonSQSClient())
            {
                var createResponse = sqsClient.CreateQueue("events-test-" + DateTime.Now.Ticks);
                var bucketName = S3TestUtils.CreateBucket(s3Client);
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
                                Events = new List<EventType>{EventType.ObjectCreatedPut}
                            }
                        }
                    };

                    s3Client.PutBucketNotification(putRequest);

                    var getResponse = s3Client.GetBucketNotification(bucketName);

                    Assert.AreEqual(1, getResponse.QueueConfigurations.Count);
                    Assert.AreEqual(1, getResponse.QueueConfigurations[0].Events.Count);
                    Assert.AreEqual(EventType.ObjectCreatedPut, getResponse.QueueConfigurations[0].Events[0]);

                    Assert.AreEqual("the-queue-test", getResponse.QueueConfigurations[0].Id);
                    Assert.AreEqual(queueArn, getResponse.QueueConfigurations[0].Queue);

                }
                finally
                {
                    sqsClient.DeleteQueue(createResponse.QueueUrl);
                    AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
                }
            }
        }
    }
}