using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.SimpleNotificationService.Util;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    [TestCategory("SimpleNotificationService")]
    public class SNSMessageUtilityTests
    {
        [TestMethod]
        public void HandleMixedCaseKeys()
        {
            var value = "arn:aws:sns:us-east-1:123456789012:MyTopic";
            var expectedCase =
"{" +
"  \"TopicArn\" : \"" + value + "\"," +
"  \"SigningCertURL\" : \"https://sns.us-east-1.amazonaws.com/SimpleNotificationService-f3ecfb7224c7233fe7bb5f59f96de52f.pem\"," +
"  \"SignatureVersion\" : \"1\"" +
"}";

            var message = Message.ParseMessage(expectedCase);
            Assert.AreEqual(value, message.TopicArn);

            var differentCase = expectedCase.Replace("TopicArn", "TopicARN");
            message = Message.ParseMessage(differentCase);
            Assert.AreEqual(value, message.TopicArn);
        }

        [TestMethod]
        public void TestSubscribeConfirmationMessage()
        {
            var json = @"
            {
              ""Type"" : ""SubscriptionConfirmation"",
              ""MessageId"" : ""165545c9-2a5c-472c-8df2-7ff2be2b3b1b"",
              ""Token"" : ""2336412f37..."",
              ""TopicArn"" : ""arn:aws:sns:us-west-2:123456789012:MyTopic"",
              ""Message"" : ""You have chosen to subscribe to the topic arn:aws:sns:us-west-2:123456789012:MyTopic"",
              ""SubscribeURL"" : ""https://sns.us-west-2.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-west-2:123456789012:MyTopic&Token=2336412f37..."",
              ""Timestamp"" : ""2012-04-26T20:45:04.751Z"",
              ""SignatureVersion"" : ""1"",
              ""Signature"" : ""EXAMPLEHXgJm..."",
              ""SigningCertURL"" : ""https://sns.us-west-2.amazonaws.com/SimpleNotificationService-f3ecfb7224c7233fe7bb5f59f96de52f.pem""
            }";

            var actualMessage = Message.ParseMessage(json);
            Assert.IsNotNull(actualMessage);
            Assert.AreEqual(Message.MESSAGE_TYPE_SUBSCRIPTION_CONFIRMATION, actualMessage.Type);
            Assert.AreEqual("165545c9-2a5c-472c-8df2-7ff2be2b3b1b", actualMessage.MessageId);
            Assert.AreEqual("2336412f37...", actualMessage.Token);
            Assert.AreEqual("arn:aws:sns:us-west-2:123456789012:MyTopic", actualMessage.TopicArn);
            Assert.IsNotNull(actualMessage.MessageText);
            Assert.AreNotEqual(default, actualMessage.Timestamp);
            Assert.AreEqual("1", actualMessage.SignatureVersion);
            Assert.IsNotNull(actualMessage.Signature);
            Assert.IsNotNull(actualMessage.SigningCertURL);
        }

        [TestMethod]
        public void TestUnsubscribeConfirmationMessage()
        {
            var json = @"
            {
              ""Type"" : ""UnsubscribeConfirmation"",
              ""MessageId"" : ""47138184-6831-46b8-8f7c-afc488602d7d"",
              ""Token"" : ""2336412f37..."",
              ""TopicArn"" : ""arn:aws:sns:us-west-2:123456789012:MyTopic"",
              ""Message"" : ""You have chosen to deactivate subscription arn:aws:sns:us-west-2:123456789012:MyTopic:2bcfbf39-05c3-41de-beaa-fcfcc21c8f55"",
              ""SubscribeURL"" : ""https://sns.us-west-2.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-west-2:123456789012:MyTopic&Token=2336412f37fb6..."",
              ""Timestamp"" : ""2012-04-26T20:06:41.581Z"",
              ""SignatureVersion"" : ""1"",
              ""Signature"" : ""EXAMPLEHXgJm..."",
              ""SigningCertURL"" : ""https://sns.us-west-2.amazonaws.com/SimpleNotificationService-f3ecfb7224c7233fe7bb5f59f96de52f.pem""
            }";

            var actualMessage = Message.ParseMessage(json);
            Assert.IsNotNull(actualMessage);
            Assert.AreEqual(Message.MESSAGE_TYPE_UNSUBSCRIPTION_CONFIRMATION, actualMessage.Type);
            Assert.AreEqual("47138184-6831-46b8-8f7c-afc488602d7d", actualMessage.MessageId);
            Assert.AreEqual("2336412f37...", actualMessage.Token);
            Assert.AreEqual("arn:aws:sns:us-west-2:123456789012:MyTopic", actualMessage.TopicArn);
            Assert.IsNotNull(actualMessage.MessageText);
            Assert.AreNotEqual(default, actualMessage.Timestamp);
            Assert.AreEqual("1", actualMessage.SignatureVersion);
            Assert.IsNotNull(actualMessage.Signature);
            Assert.IsNotNull(actualMessage.SigningCertURL);
        }

        [TestMethod]
        public void TestNotificationMessage()
        {
            var json = @"
            {
              ""Type"" : ""Notification"",
              ""MessageId"" : ""22b80b92-fdea-4c2c-8f9d-bdfb0c7bf324"",
              ""TopicArn"" : ""arn:aws:sns:us-west-2:123456789012:MyTopic"",
              ""Subject"" : ""My First Message"",
              ""Message"" : ""Hello world!"",
              ""Timestamp"" : ""2012-05-02T00:54:06.655Z"",
              ""SignatureVersion"" : ""1"",
              ""Signature"" : ""EXAMPLEw6JRN..."",
              ""SigningCertURL"" : ""https://sns.us-west-2.amazonaws.com/SimpleNotificationService-f3ecfb7224c7233fe7bb5f59f96de52f.pem"",
              ""UnsubscribeURL"" : ""https://sns.us-west-2.amazonaws.com/?Action=Unsubscribe&SubscriptionArn=arn:aws:sns:us-west-2:123456789012:MyTopic:c9135db0-26c4-47ec-8998-413945fb5a96""
            }";

            var actualMessage = Message.ParseMessage(json);
            Assert.IsNotNull(actualMessage);
            Assert.AreEqual(Message.MESSAGE_TYPE_NOTIFICATION, actualMessage.Type);
            Assert.AreEqual("22b80b92-fdea-4c2c-8f9d-bdfb0c7bf324", actualMessage.MessageId);
            Assert.IsNull(actualMessage.Token);
            Assert.AreEqual("arn:aws:sns:us-west-2:123456789012:MyTopic", actualMessage.TopicArn);
            Assert.AreEqual("Hello world!", actualMessage.MessageText);
            Assert.AreNotEqual(default, actualMessage.Timestamp);
            Assert.AreEqual("1", actualMessage.SignatureVersion);
            Assert.IsNotNull(actualMessage.Signature);
            Assert.IsNotNull(actualMessage.SigningCertURL);
        }

        [TestMethod]
        public void TestFIFOMessage()
        {
            var json = @"
            {
              ""Type"" : ""Notification"",
              ""MessageId"" : ""8c4be66f-5b81-5167-ae85-87a115101ce3"",
              ""SequenceNumber"" : ""10000000000000003000"",
              ""TopicArn"" : ""arn:aws:sns:us-west-2:123456789012:MyTopic.fifo"",
              ""Message"" : ""Hello world!"",
              ""Timestamp"" : ""2025-12-30T22:04:01.247Z"",
              ""UnsubscribeURL"" : ""https://sns.us-west-2.amazonaws.com/?Action=Unsubscribe&SubscriptionArn=arn:aws:sns:us-west-2:123456789012:MyTopic:c9135db0-26c4-47ec-8998-413945fb5a96""
            }";

            var actualMessage = Message.ParseMessage(json);
            Assert.IsNotNull(actualMessage);
            Assert.AreEqual(Message.MESSAGE_TYPE_NOTIFICATION, actualMessage.Type);
            Assert.AreEqual("8c4be66f-5b81-5167-ae85-87a115101ce3", actualMessage.MessageId);
            Assert.AreEqual("Hello world!", actualMessage.MessageText);
            Assert.AreNotEqual(default, actualMessage.Timestamp);
            Assert.AreEqual("10000000000000003000", actualMessage.SequenceNumber);

            Assert.IsNull(actualMessage.Signature);
            Assert.IsNull(actualMessage.SigningCertURL);
            Assert.IsNull(actualMessage.SignatureVersion);
        }
    }
}
