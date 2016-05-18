using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleNotificationService.Util;

namespace AWSSDK_DotNet35.UnitTests
{
    // Temporarily disabling failing test, need to make less brittle and move to integ tests.
    //[TestClass]
    public class SNSMessageUtilityTests
    {
        public const string SUBSCRIPTION_EXAMPLE = @"{
  ""Type"" : ""SubscriptionConfirmation"",
  ""MessageId"" : ""b53690f0-ef60-4739-b395-6d5ef4527be1"",
  ""Token"" : ""2336412f37fb687f5d51e6e241d7700aef3051116e61aa4999170097f4ea414f8c1e18026c13443b7372b77f3d1a959e1b417ea2578177928f79593e09c6df8ec23fdd0bfdfeacae2d6412d6b6969ead83e0f8a5cec9a7829b0c213e4095dc1276d4ae8a29e7652054899b195ef688cf"",
  ""TopicArn"" : ""arn:aws:sns:us-east-1:246796806071:snsNetTest"",
  ""Message"" : ""You have chosen to subscribe to the topic arn:aws:sns:us-east-1:246796806071:snsNetTest.\nTo confirm the subscription, visit the SubscribeURL included in this message."",
  ""SubscribeURL"" : ""https://sns.us-east-1.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-east-1:246796806071:snsNetTest&Token=2336412f37fb687f5d51e6e241d7700aef3051116e61aa4999170097f4ea414f8c1e18026c13443b7372b77f3d1a959e1b417ea2578177928f79593e09c6df8ec23fdd0bfdfeacae2d6412d6b6969ead83e0f8a5cec9a7829b0c213e4095dc1276d4ae8a29e7652054899b195ef688cf"",
  ""Timestamp"" : ""2015-08-18T17:34:14.978Z"",
  ""SignatureVersion"" : ""1"",
  ""Signature"" : ""jLr5XCdgeh0hI841UFt4/2doUka6i2+QwnW+GfRSP3BMX8GGIy9BPSVgM9+i5RqMifocZtkYqfEIy9xppkyUc47JXi5/IgIj9DAFSOxkVILg+DMlM4gDZXpVrd7BwgLUORrrNoqsucZ7f4Pf/jikFz6myFg1bGKsTabdhP/PRrTa9/Ll1gRXZ4pbdet8wH9lgdRUh3Hu3To/WN91QK3xwTxvzStOKtebuMDCd6u4Zqg/Q8F/4U+PexyRIXWgB5PIXEQPYe0caK/GHizRRPftxG4nGffM1Mieo1RMRDAhIajZtFTHSS1KLmfSWPTdg2vcCNoh7xT5wEO5tQmO4mz/Tw=="",
  ""SigningCertURL"" : ""https://sns.us-east-1.amazonaws.com/SimpleNotificationService-d6d679a1d18e95c2f9ffcf11f4f9e198.pem""
}";

        public const string NOTIFICATION_EXAMPLE = @"{
  ""Type"" : ""Notification"",
  ""MessageId"" : ""82833b5c-8d5d-56d0-b0e1-7511f8253eb8"",
  ""TopicArn"" : ""arn:aws:sns:us-east-1:246796806071:snsNetTest"",
  ""Subject"" : ""Greetings"",
  ""Message"" : ""Hello\r\nworld!"",
  ""Timestamp"" : ""2015-08-18T18:02:32.111Z"",
  ""SignatureVersion"" : ""1"",
  ""Signature"" : ""e+khMfZriwAOTkF0OVm3tmdVq9eY6s5Bj6rXZty4B2TYssx7SSSBpvsDCiDuzgeHe++MNsGLDDT+5OpGEFBqCcd/K7iXhofz+KabMEtvM2Ku3aXcFixjOCAY1BF8hH6zU6nKzOy+m7K4UIoVqIOOhqsLWoXNFWgwQseBol1pFQ/MRi9UH84/WGdU8//dH+1/zjLxCud8Lg1vY9Yi/jxMU1HVpZ2JuvzJBdNBFJWc/VYAiw8K1r/J+dxAiLr87P96MgUqyg1wWxYe00HaEXGtjIctCNcd92s3pngOOeGvPYGaTIZEbYhSf2leMYd+CXujUHRqozru5K0Zp+l99fUNTg=="",
  ""SigningCertURL"" : ""https://sns.us-east-1.amazonaws.com/SimpleNotificationService-d6d679a1d18e95c2f9ffcf11f4f9e198.pem"",
  ""UnsubscribeURL"" : ""https://sns.us-east-1.amazonaws.com/?Action=Unsubscribe&SubscriptionArn=arn:aws:sns:us-east-1:246796806071:snsNetTest:228cc6c9-dcd8-4c92-9f3a-77f55176b9e3""
}
";

        public const string UNSUBSCRIBE_EXAMPLE = 
"{" +
"  \"Type\" : \"UnsubscribeConfirmation\"," +
"  \"MessageId\" : \"47138184-6831-46b8-8f7c-afc488602d7d\"," +
"  \"Token\" : \"2336412f37fb687f5d51e6e241d09c805a5a57b30d712f7948a98bac386edfe3e10314e873973b3e0a3c09119b722dedf2b5e31c59b13edbb26417c19f109351e6f2169efa9085ffe97e10535f4179ac1a03590b0f541f209c190f9ae23219ed6c470453e06c19b5ba9fcbb27daeb7c7\"," +
"  \"TopicArn\" : \"arn:aws:sns:us-east-1:123456789012:MyTopic\"," +
"  \"Message\" : \"You have chosen to deactivate subscription arn:aws:sns:us-east-1:123456789012:MyTopic:2bcfbf39-05c3-41de-beaa-fcfcc21c8f55.\nTo cancel this operation and restore the subscription, visit the SubscribeURL included in this message.\"," +
"  \"SubscribeURL\" : \"https://sns.us-east-1.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-east-1:123456789012:MyTopic&Token=2336412f37fb687f5d51e6e241d09c805a5a57b30d712f7948a98bac386edfe3e10314e873973b3e0a3c09119b722dedf2b5e31c59b13edbb26417c19f109351e6f2169efa9085ffe97e10535f4179ac1a03590b0f541f209c190f9ae23219ed6c470453e06c19b5ba9fcbb27daeb7c7\"," +
"  \"Timestamp\" : \"2012-04-26T20:06:41.581Z\"," +
"  \"SignatureVersion\" : \"1\"," +
"  \"Signature\" : \"EXAMPLEHXgJmXqnqsHTlqOCk7TIZsnk8zpJJoQbr8leD+8kAHcke3ClC4VPOvdpZo9s/vR9GOznKab6sjGxE8uwqDI9HwpDm8lGxSlFGuwCruWeecnt7MdJCNh0XK4XQCbtGoXB762ePJfaSWi9tYwzW65zAFU04WkNBkNsIf60=\"," +
"  \"SigningCertURL\" : \"https://sns.us-east-1.amazonaws.com/SimpleNotificationService-f3ecfb7224c7233fe7bb5f59f96de52f.pem\"" +
"}";

        [TestMethod]
        public void SubscriptionFormatTest()
        {
            var message = Message.ParseMessage(SUBSCRIPTION_EXAMPLE);

            Assert.AreEqual(Message.MESSAGE_TYPE_SUBSCRIPTION_CONFIRMATION, message.Type);
            Assert.AreEqual("b53690f0-ef60-4739-b395-6d5ef4527be1", message.MessageId);
            Assert.AreEqual("2336412f37fb687f5d51e6e241d7700aef3051116e61aa4999170097f4ea414f8c1e18026c13443b7372b77f3d1a959e1b417ea2578177928f79593e09c6df8ec23fdd0bfdfeacae2d6412d6b6969ead83e0f8a5cec9a7829b0c213e4095dc1276d4ae8a29e7652054899b195ef688cf", message.Token);
            Assert.AreEqual("arn:aws:sns:us-east-1:246796806071:snsNetTest", message.TopicArn);
            Assert.AreEqual("You have chosen to subscribe to the topic arn:aws:sns:us-east-1:246796806071:snsNetTest.\nTo confirm the subscription, visit the SubscribeURL included in this message.", message.MessageText);
            Assert.AreEqual("https://sns.us-east-1.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-east-1:246796806071:snsNetTest&Token=2336412f37fb687f5d51e6e241d7700aef3051116e61aa4999170097f4ea414f8c1e18026c13443b7372b77f3d1a959e1b417ea2578177928f79593e09c6df8ec23fdd0bfdfeacae2d6412d6b6969ead83e0f8a5cec9a7829b0c213e4095dc1276d4ae8a29e7652054899b195ef688cf", message.SubscribeURL);
            Assert.AreEqual(2015, message.Timestamp.Year);
            Assert.AreEqual("1", message.SignatureVersion);
            Assert.AreEqual("jLr5XCdgeh0hI841UFt4/2doUka6i2+QwnW+GfRSP3BMX8GGIy9BPSVgM9+i5RqMifocZtkYqfEIy9xppkyUc47JXi5/IgIj9DAFSOxkVILg+DMlM4gDZXpVrd7BwgLUORrrNoqsucZ7f4Pf/jikFz6myFg1bGKsTabdhP/PRrTa9/Ll1gRXZ4pbdet8wH9lgdRUh3Hu3To/WN91QK3xwTxvzStOKtebuMDCd6u4Zqg/Q8F/4U+PexyRIXWgB5PIXEQPYe0caK/GHizRRPftxG4nGffM1Mieo1RMRDAhIajZtFTHSS1KLmfSWPTdg2vcCNoh7xT5wEO5tQmO4mz/Tw==", message.Signature);
            Assert.AreEqual("https://sns.us-east-1.amazonaws.com/SimpleNotificationService-d6d679a1d18e95c2f9ffcf11f4f9e198.pem", message.SigningCertURL);

            Assert.IsTrue(message.IsMessageSignatureValid());
        }

        [TestMethod]
        public void NotificationFormatTest()
        {
            var message = Message.ParseMessage(NOTIFICATION_EXAMPLE);

            Assert.AreEqual(Message.MESSAGE_TYPE_NOTIFICATION, message.Type);
            Assert.AreEqual("82833b5c-8d5d-56d0-b0e1-7511f8253eb8", message.MessageId);
            Assert.AreEqual("arn:aws:sns:us-east-1:246796806071:snsNetTest", message.TopicArn);
            Assert.AreEqual("Greetings", message.Subject);
            Assert.AreEqual("Hello\r\nworld!", message.MessageText);
            Assert.AreEqual(2015, message.Timestamp.Year);
            Assert.AreEqual("1", message.SignatureVersion);
            Assert.AreEqual("e+khMfZriwAOTkF0OVm3tmdVq9eY6s5Bj6rXZty4B2TYssx7SSSBpvsDCiDuzgeHe++MNsGLDDT+5OpGEFBqCcd/K7iXhofz+KabMEtvM2Ku3aXcFixjOCAY1BF8hH6zU6nKzOy+m7K4UIoVqIOOhqsLWoXNFWgwQseBol1pFQ/MRi9UH84/WGdU8//dH+1/zjLxCud8Lg1vY9Yi/jxMU1HVpZ2JuvzJBdNBFJWc/VYAiw8K1r/J+dxAiLr87P96MgUqyg1wWxYe00HaEXGtjIctCNcd92s3pngOOeGvPYGaTIZEbYhSf2leMYd+CXujUHRqozru5K0Zp+l99fUNTg==", message.Signature);
            Assert.AreEqual("https://sns.us-east-1.amazonaws.com/SimpleNotificationService-d6d679a1d18e95c2f9ffcf11f4f9e198.pem", message.SigningCertURL);
            Assert.AreEqual("https://sns.us-east-1.amazonaws.com/?Action=Unsubscribe&SubscriptionArn=arn:aws:sns:us-east-1:246796806071:snsNetTest:228cc6c9-dcd8-4c92-9f3a-77f55176b9e3", message.UnsubscribeURL);

            Assert.IsTrue(message.IsMessageSignatureValid());
        }

        [TestMethod]
        public void UnscribeFormatTest()
        {
            var message = Message.ParseMessage(UNSUBSCRIBE_EXAMPLE);

            Assert.AreEqual(Message.MESSAGE_TYPE_UNSUBSCRIPTION_CONFIRMATION, message.Type);
            Assert.AreEqual("47138184-6831-46b8-8f7c-afc488602d7d", message.MessageId);
            Assert.AreEqual("2336412f37fb687f5d51e6e241d09c805a5a57b30d712f7948a98bac386edfe3e10314e873973b3e0a3c09119b722dedf2b5e31c59b13edbb26417c19f109351e6f2169efa9085ffe97e10535f4179ac1a03590b0f541f209c190f9ae23219ed6c470453e06c19b5ba9fcbb27daeb7c7", message.Token);
            Assert.AreEqual("arn:aws:sns:us-east-1:123456789012:MyTopic", message.TopicArn);
            Assert.AreEqual("You have chosen to deactivate subscription arn:aws:sns:us-east-1:123456789012:MyTopic:2bcfbf39-05c3-41de-beaa-fcfcc21c8f55.\nTo cancel this operation and restore the subscription, visit the SubscribeURL included in this message.", message.MessageText);
            Assert.AreEqual("https://sns.us-east-1.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-east-1:123456789012:MyTopic&Token=2336412f37fb687f5d51e6e241d09c805a5a57b30d712f7948a98bac386edfe3e10314e873973b3e0a3c09119b722dedf2b5e31c59b13edbb26417c19f109351e6f2169efa9085ffe97e10535f4179ac1a03590b0f541f209c190f9ae23219ed6c470453e06c19b5ba9fcbb27daeb7c7", message.SubscribeURL);
            Assert.AreEqual(2012, message.Timestamp.Year);
            Assert.AreEqual("1", message.SignatureVersion);
            Assert.AreEqual("EXAMPLEHXgJmXqnqsHTlqOCk7TIZsnk8zpJJoQbr8leD+8kAHcke3ClC4VPOvdpZo9s/vR9GOznKab6sjGxE8uwqDI9HwpDm8lGxSlFGuwCruWeecnt7MdJCNh0XK4XQCbtGoXB762ePJfaSWi9tYwzW65zAFU04WkNBkNsIf60=", message.Signature);
            Assert.AreEqual("https://sns.us-east-1.amazonaws.com/SimpleNotificationService-f3ecfb7224c7233fe7bb5f59f96de52f.pem", message.SigningCertURL);
        }
    }
}
