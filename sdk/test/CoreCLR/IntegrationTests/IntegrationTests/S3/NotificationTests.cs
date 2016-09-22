﻿using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.SimpleNotificationService;
using Amazon.SQS;
using Amazon.SQS.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    public class NotificationTests : TestBase<AmazonS3Client>
    {
        [Fact]
        public async Task SetTopicConfigurationTests()
        {
            using (var snsClient = new AmazonSimpleNotificationServiceClient())
            {
                string topicName = UtilityMethods.GenerateName("events-test");
                var snsCreateResponse = await snsClient.CreateTopicAsync(topicName);
                var bucketName = await UtilityMethods.CreateBucketAsync(Client, "SetTopicConfigurationTests");

                try
                {
                    await snsClient.AuthorizeS3ToPublishAsync(snsCreateResponse.TopicArn, bucketName);

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

                    await Client.PutBucketNotificationAsync(putRequest);

                    var getResponse = await Client.GetBucketNotificationAsync(bucketName);

                    Assert.Equal(1, getResponse.TopicConfigurations.Count);
                    Assert.Equal(1, getResponse.TopicConfigurations[0].Events.Count);
                    Assert.Equal(EventType.ObjectCreatedPut, getResponse.TopicConfigurations[0].Events[0]);

#pragma warning disable 618
                    Assert.Equal("s3:ObjectCreated:Put", getResponse.TopicConfigurations[0].Event);
#pragma warning restore 618
                    Assert.Equal("the-topic-test", getResponse.TopicConfigurations[0].Id);
                    Assert.Equal(snsCreateResponse.TopicArn, getResponse.TopicConfigurations[0].Topic);

                }
                finally
                {
                    await snsClient.DeleteTopicAsync(snsCreateResponse.TopicArn);
                    await UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName);
                }
            }
        }

        [Fact]
        public async Task SetQueueConfigurationTests()
        {
            var filterRule = new FilterRule("Prefix", "test/");
            using (var sqsClient = new AmazonSQSClient())
            {
                string topicName = UtilityMethods.GenerateName("events-test");
                var createResponse = await sqsClient.CreateQueueAsync(topicName);
                var bucketName = await UtilityMethods.CreateBucketAsync(Client, "SetQueueConfigurationTests");
                try
                {
                    var queueArn = await sqsClient.AuthorizeS3ToSendMessageAsync(createResponse.QueueUrl, bucketName);

                    PutBucketNotificationRequest putRequest = new PutBucketNotificationRequest
                    {
                        BucketName = bucketName,
                        QueueConfigurations = new List<QueueConfiguration>
                        {
                            new QueueConfiguration
                            {
                                Id = "the-queue-test",
                                Queue = queueArn,
                                Events = {EventType.ObjectCreatedPut},
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

                    await Client.PutBucketNotificationAsync(putRequest);

                    var getResponse = await Client.GetBucketNotificationAsync(bucketName);

                    Assert.Equal(1, getResponse.QueueConfigurations.Count);
                    Assert.Equal(1, getResponse.QueueConfigurations[0].Events.Count);
                    Assert.Equal(EventType.ObjectCreatedPut, getResponse.QueueConfigurations[0].Events[0]);

                    Assert.NotNull(getResponse.QueueConfigurations[0].Filter);
                    Assert.NotNull(getResponse.QueueConfigurations[0].Filter.S3KeyFilter);
                    Assert.NotNull(getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules);
                    Assert.Equal(1, getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules.Count);
                    Assert.Equal(filterRule.Name, getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules[0].Name);
                    Assert.Equal(filterRule.Value, getResponse.QueueConfigurations[0].Filter.S3KeyFilter.FilterRules[0].Value);

                    Assert.Equal("the-queue-test", getResponse.QueueConfigurations[0].Id);
                    Assert.Equal(queueArn, getResponse.QueueConfigurations[0].Queue);

                    // Purge queue to remove test message sent configuration was setup.
                    await sqsClient.PurgeQueueAsync(createResponse.QueueUrl);
                    Thread.Sleep(TimeSpan.FromSeconds(1));

                    var putObjectRequest = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = "test/data.txt",
                        ContentBody = "Important Data"
                    };

                    await Client.PutObjectAsync(putObjectRequest);

                    string messageBody = null;
                    for (int i = 0; i < 5 && messageBody == null; i++)
                    {
                        var receiveResponse = await sqsClient.ReceiveMessageAsync(new ReceiveMessageRequest { QueueUrl = createResponse.QueueUrl, WaitTimeSeconds = 20 });
                        if (receiveResponse.Messages.Count != 0)
                        {
                            messageBody = receiveResponse.Messages[0].Body;
                        }
                    }


                    var evnt = S3EventNotification.ParseJson(messageBody);

                    Assert.Equal(1, evnt.Records.Count);
                    Assert.Equal(putObjectRequest.BucketName, evnt.Records[0].S3.Bucket.Name);
                    Assert.Equal(putObjectRequest.Key, evnt.Records[0].S3.Object.Key);
                    Assert.Equal(putObjectRequest.ContentBody.Length, evnt.Records[0].S3.Object.Size);
                }
                finally
                {
                    await sqsClient.DeleteQueueAsync(createResponse.QueueUrl);
                    await UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName);
                }
            }
        }
    }
}