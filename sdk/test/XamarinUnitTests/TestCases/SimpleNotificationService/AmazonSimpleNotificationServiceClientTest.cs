using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Moq;
using NUnit.Framework;
using NUnit.Tests.DLL.Utils;
using Amazon.SimpleNotificationService ;
using Amazon.Auth.AccessControlPolicy; 
using Amazon.Runtime.SharedInterfaces;
using Amazon; 
using Amazon.SimpleNotificationService.Model;
namespace XamarinUnitTests.TestCases.SimpleNotificationService
{
    [TestFixture]
    class AmazonSimpleNotificationServiceClientTest
    {
        private AmazonSimpleNotificationServiceClient  SNSClient;
        private Moq.Mock<AmazonSimpleNotificationServiceClient>   mockSNSClient;
        [OneTimeSetUp]
        public void Initialize()
        {
            AWSCredentials credentials = new AnonymousAWSCredentials();
            RegionEndpoint regionEndPoint = RegionEndpoint.USEast1;
            mockSNSClient =new Mock<AmazonSimpleNotificationServiceClient>(credentials, regionEndPoint);
            SNSClient = mockSNSClient.Object;
        }

        [Test]
        public void TestSubscribeQueueToTopicsAsync()
        {
            var topicArns = new List<string>();

            var topicArn1 = "arn:aws:sns:us-east-1:987654321011:MYTOPIC1";
            topicArns.Add(topicArn1);

            var topicArn2 = "arn:aws:sns:us-east-1:987654321011:MYTOPIC2";
            topicArns.Add(topicArn2);

            var mocksqsClient = new Moq.Mock<ICoreAmazonSQS>();
            Dictionary<string, string> attrbutes = new Dictionary<string, string>();
            attrbutes["QueueArn"] = "arn:aws:sqs:us-east-1:987654321011:testtest";
            mocksqsClient.Setup(e => e.GetAttributesAsync(It.IsAny<string>())).Returns(Task.FromResult(attrbutes));
            mockSNSClient.Setup(e => e.SubscribeAsync(It.IsAny<SubscribeRequest>(), It.IsAny<System.Threading.CancellationToken>())).Returns(Task.FromResult(new SubscribeResponse()));  
            mocksqsClient.Setup(e => e.SetAttributesAsync(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>())).Returns(Task.FromResult(default(object)));

            string queueUrl = "https://sqs.us-east-1.amazonaws.com/987654321011/testtest";

            var topics =  SNSClient.SubscribeQueueToTopicsAsync(topicArns, mocksqsClient.Object, queueUrl).Result; 
           var subscriptionArns = topics.Values;
            Assert.AreEqual(2, subscriptionArns.Count);
            mocksqsClient.Verify(e => e.GetAttributesAsync(It.IsAny<string>()), Times.Once);
            mockSNSClient.Verify(e => e.SubscribeAsync(It.IsAny<SubscribeRequest>(), It.IsAny<System.Threading.CancellationToken>()), Times.Exactly(2));
            mocksqsClient.Verify(e => e.SetAttributesAsync(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()), Times.Once);
        }

        [Test]
        public void FindTopicAsyncTest()
        {
            ListTopicsResponse topicsResponses = new ListTopicsResponse();
            string topicName = "MYTOPIC";
            string topicArn = "arn:aws:sns:us-east-1:987654321000:" + topicName; 
            topicsResponses.Topics.Add(new Topic { TopicArn = topicArn });

            mockSNSClient.Setup(e => e.ListTopicsAsync(It.IsAny<ListTopicsRequest>(), It.IsAny<System.Threading.CancellationToken>())).Returns(Task.FromResult(topicsResponses));
            Assert.AreNotEqual(null, SNSClient.FindTopicAsync(topicName).Result);
            string wrongTopicName = "wrongtopic";
            Assert.AreEqual(null, SNSClient.FindTopicAsync(wrongTopicName).Result);
        }

        [Test]
        public void AuthorizeS3ToPublishAsyncTest()
        {

            GetTopicAttributesResponse getTopicAttributesResponse = new GetTopicAttributesResponse();
            //{
            //    Attributes = new Dictionary<string, string>()
            //};
            string topicArn = "arn:aws:sns:us-east-1:987654321011:MYTOPIC1";
            string bucket = "samplebucket";
 
            mockSNSClient.Setup(e => e.GetTopicAttributesAsync(It.IsAny<GetTopicAttributesRequest>(), It.IsAny<System.Threading.CancellationToken>())).Returns(Task.FromResult(getTopicAttributesResponse));
            mockSNSClient.Setup(e => e.SetTopicAttributesAsync(It.IsAny<SetTopicAttributesRequest>(), It.IsAny<System.Threading.CancellationToken>())).Returns(Task.FromResult(new SetTopicAttributesResponse()));
            SNSClient.AuthorizeS3ToPublishAsync(topicArn, bucket).Wait();
            mockSNSClient.Verify(e => e.GetTopicAttributesAsync(It.IsAny<GetTopicAttributesRequest>(), It.IsAny<System.Threading.CancellationToken>()), Times.Once);
            mockSNSClient.Verify(e => e.SetTopicAttributesAsync(It.IsAny<SetTopicAttributesRequest>(), It.IsAny<System.Threading.CancellationToken>()), Times.Once());


        }

    }
}
