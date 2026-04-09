using Amazon.Auth.AccessControlPolicy;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class NotificationTests : IClassFixture<S3BucketFixture>, IAsyncLifetime
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private string _topicArn;
        private readonly AmazonSimpleNotificationServiceClient _snsClient;

        public NotificationTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
            _snsClient = new AmazonSimpleNotificationServiceClient(region: _client.Config.RegionEndpoint);
        }

        public async ValueTask InitializeAsync()
        {
            var snsCreateResponse = await _snsClient.CreateTopicAsync(UtilityMethods.GenerateName("events-test-"));
            _topicArn = snsCreateResponse.TopicArn;
        }

        public async ValueTask DisposeAsync()
        {
            if (_topicArn != null)
                await _snsClient.DeleteTopicAsync(_topicArn);
            _snsClient.Dispose();
        }

        [Fact]
        public async Task SetTopicConfigurationTests()
        {
            using (var stsClient = new AmazonSecurityTokenServiceClient(region: _client.Config.RegionEndpoint))
            {
                await _snsClient.AuthorizeS3ToPublishAsync(_topicArn, _bucketName);
                await _client.PutBucketNotificationAsync(new PutBucketNotificationRequest
                {
                    BucketName = _bucketName,
                    TopicConfigurations = new List<TopicConfiguration>
                    {
                        new TopicConfiguration
                        {
                            Id = "the-topic-test",
                            Topic = _topicArn,
                            Events = new List<EventType> { EventType.ObjectCreatedPut }
                        }
                    }
                });

                var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
                {
                    var res = await _client.GetBucketNotificationAsync(_bucketName);
                    return res.TopicConfigurations?.Count > 0 && res.TopicConfigurations[0].Id == "the-topic-test" ? res : null;
                });

                var getAttributeResponse = await _snsClient.GetTopicAttributesAsync(new GetTopicAttributesRequest
                {
                    TopicArn = _topicArn
                });
                var policy = Policy.FromJson(getAttributeResponse.Attributes["Policy"]);

                // SNS topics already have a default statement. We need to evaluate the second statement that the SDK appended.
                var conditions = policy.Statements[1].Conditions;
                Assert.Equal(2, conditions.Count);

                var accountCondition = conditions.FirstOrDefault(x => string.Equals(x.ConditionKey, ConditionFactory.SOURCE_ACCOUNT_KEY));
                Assert.NotNull(accountCondition);
                Assert.Equal(ConditionFactory.StringComparisonType.StringEquals.ToString(), accountCondition.Type);
                Assert.Equal(12, accountCondition.Values[0].Length);

                var currentAccountId = (await stsClient.GetCallerIdentityAsync(new GetCallerIdentityRequest())).Account;
                Assert.Equal(currentAccountId, accountCondition.Values[0]);
                Assert.Equal(1, getResponse.TopicConfigurations.Count);
                Assert.Equal(1, getResponse.TopicConfigurations[0].Events.Count);
                Assert.Equal(EventType.ObjectCreatedPut, getResponse.TopicConfigurations[0].Events[0]);
                Assert.Equal("s3:ObjectCreated:Put", getResponse.TopicConfigurations[0].Events[0].Value);
                Assert.Equal("the-topic-test", getResponse.TopicConfigurations[0].Id);
                Assert.Equal(_topicArn, getResponse.TopicConfigurations[0].Topic);
            }
        }

        [Fact]
        public async Task PutAndGetEventBridgeConfigurationTest()
        {
            var putResponse = await _client.PutBucketNotificationAsync(new PutBucketNotificationRequest
            {
                BucketName = _bucketName,
                EventBridgeConfiguration = new EventBridgeConfiguration(),
                SkipDestinationValidation = true
            });
            Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);

            var getResponse = await _client.GetBucketNotificationAsync(new GetBucketNotificationRequest
            {
                BucketName = _bucketName,
            });
            Assert.NotNull(getResponse.EventBridgeConfiguration);
        }
    }
}
