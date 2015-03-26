using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleNotificationService.Util;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class SNSMessageUtilityTests
    {
        public const string SUBSCRIPTION_EXAMPLE =
"{" +
"  \"Type\" : \"SubscriptionConfirmation\"," +
"  \"MessageId\" : \"8e549c0e-6cc3-45a4-9fba-79c473f91527\"," +
"  \"Token\" : \"2336412f37fb687f5d51e6e241d638b05983341a95037295695a241455b7aeb274dae3d53d11dc1718cce496fe86b49ec04f9dd5494feec7e0698e6161aa2c6e1e3e31d5a0c8fb99b621551bf07cfa64665e8951e12c0e8917e7f61c35b21bba9fe0aa2447f7bafa0bc41458386b7ec3\"," +
"  \"TopicArn\" : \"arn:aws:sns:us-west-2:245953695175:snstest1\"," +
"  \"Message\" : \"You have chosen to subscribe to the topic arn:aws:sns:us-west-2:245953695175:snstest1.\nTo confirm the subscription, visit the SubscribeURL included in this message.\"," +
"  \"SubscribeURL\" : \"https://sns.us-west-2.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-west-2:245953695175:snstest1&Token=2336412f37fb687f5d51e6e241d638b05983341a95037295695a241455b7aeb274dae3d53d11dc1718cce496fe86b49ec04f9dd5494feec7e0698e6161aa2c6e1e3e31d5a0c8fb99b621551bf07cfa64665e8951e12c0e8917e7f61c35b21bba9fe0aa2447f7bafa0bc41458386b7ec3\"," +
"  \"Timestamp\" : \"2014-07-03T21:34:38.100Z\"," +
"  \"SignatureVersion\" : \"1\"," +
"  \"Signature\" : \"px/FrK5NvYrMyCoqks7XpXfiPpPwH8dsuISfGWAxIwS9ywV0W98alhusMdjCJpI/n6gGj8EyNNBUNBzRC5gQQ7kX76iJdncdwaD/E1fSEPe0birkia793iQayGNoeAunUEtL3pLUCsTnt5+tm1EFOfEnKdKhOJ4mDpEGhcallMEYz21Dd2eu8kSTltYpI1SmS62le3Bla4PgExalnw6d324p3jdJ2dQbpH9Nexy9R9I+3tSB0bDR+DIcM/f+0FJhnI6X9aEvzwP1uLQfXKgFXHvECpgUoO4VsKrqPLUyOriuES768zq7WgJbJns6nq3WUAbq2Qflj1hxWy2Ri1u25g==\"," +
"  \"SigningCertURL\" : \"https://sns.us-west-2.amazonaws.com/SimpleNotificationService-e372f8ca30337fdb084e8ac449342c77.pem\"" +
"}";

        public const string NOTIFICATION_EXAMPLE = 
"{" +
"  \"Type\" : \"Notification\"," +
"  \"MessageId\" : \"0b68823a-c5fd-5da4-b99a-ce15238d3c5d\"," +
"  \"TopicArn\" : \"arn:aws:sns:us-west-2:245953695175:snstest1\"," +
"  \"Subject\" : \"Greetings\"," +
"  \"Message\" : \"Hello\r\nTo\r\nThe\r\nWorld\"," +
"  \"Timestamp\" : \"2014-07-03T23:16:00.794Z\"," +
"  \"SignatureVersion\" : \"1\"," +
"  \"Signature\" : \"Uae26RRYgt3SjQCvyPwSxfjoyb8qmh4LiUr1Hz4YcAVgFjbozxiotCVRlRYmTnUjnRrtUzIP0nEWBv5t6C+lbhIT+jD8c9vK/FrDi5q60ghH0UinUQPSsmeo9iRwTwNT6Z91o8GHwgpIxjB7nM6jKBfsYUC8EjsWZ2eAFNJDvx4ggJZM8wkHiqreqIwy6RBI8xQvo8S8ZQxrhkFYajH+wQF7/CJfgHXBmnENCZlHPsp/t81myRAZW6crk8RAuIUNPAMz2KoiDaSVmQ2beVDXlV1gaudwwfiZgEd49gYV+DyLI5aiiaajQVVHaVEgQ5la/RFGC13oh/KiMhdHHb1AKA==\"," +
"  \"SigningCertURL\" : \"https://sns.us-west-2.amazonaws.com/SimpleNotificationService-e372f8ca30337fdb084e8ac449342c77.pem\"," +
"  \"UnsubscribeURL\" : \"https://sns.us-west-2.amazonaws.com/?Action=Unsubscribe&SubscriptionArn=arn:aws:sns:us-west-2:245953695175:snstest1:2d79be76-0e5a-4073-b000-294bd1f6d04a\"" +
"}";


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
            Assert.AreEqual("8e549c0e-6cc3-45a4-9fba-79c473f91527", message.MessageId);
            Assert.AreEqual("2336412f37fb687f5d51e6e241d638b05983341a95037295695a241455b7aeb274dae3d53d11dc1718cce496fe86b49ec04f9dd5494feec7e0698e6161aa2c6e1e3e31d5a0c8fb99b621551bf07cfa64665e8951e12c0e8917e7f61c35b21bba9fe0aa2447f7bafa0bc41458386b7ec3", message.Token);
            Assert.AreEqual("arn:aws:sns:us-west-2:245953695175:snstest1", message.TopicArn);
            Assert.AreEqual("You have chosen to subscribe to the topic arn:aws:sns:us-west-2:245953695175:snstest1.\nTo confirm the subscription, visit the SubscribeURL included in this message.", message.MessageText);
            Assert.AreEqual("https://sns.us-west-2.amazonaws.com/?Action=ConfirmSubscription&TopicArn=arn:aws:sns:us-west-2:245953695175:snstest1&Token=2336412f37fb687f5d51e6e241d638b05983341a95037295695a241455b7aeb274dae3d53d11dc1718cce496fe86b49ec04f9dd5494feec7e0698e6161aa2c6e1e3e31d5a0c8fb99b621551bf07cfa64665e8951e12c0e8917e7f61c35b21bba9fe0aa2447f7bafa0bc41458386b7ec3", message.SubscribeURL);
            Assert.AreEqual(2014, message.Timestamp.Year);
            Assert.AreEqual("1", message.SignatureVersion);
            Assert.AreEqual("px/FrK5NvYrMyCoqks7XpXfiPpPwH8dsuISfGWAxIwS9ywV0W98alhusMdjCJpI/n6gGj8EyNNBUNBzRC5gQQ7kX76iJdncdwaD/E1fSEPe0birkia793iQayGNoeAunUEtL3pLUCsTnt5+tm1EFOfEnKdKhOJ4mDpEGhcallMEYz21Dd2eu8kSTltYpI1SmS62le3Bla4PgExalnw6d324p3jdJ2dQbpH9Nexy9R9I+3tSB0bDR+DIcM/f+0FJhnI6X9aEvzwP1uLQfXKgFXHvECpgUoO4VsKrqPLUyOriuES768zq7WgJbJns6nq3WUAbq2Qflj1hxWy2Ri1u25g==", message.Signature);
            Assert.AreEqual("https://sns.us-west-2.amazonaws.com/SimpleNotificationService-e372f8ca30337fdb084e8ac449342c77.pem", message.SigningCertURL);

            Assert.IsTrue(message.IsMessageSignatureValid());
        }

        [TestMethod]
        public void NotificationFormatTest()
        {
            var message = Message.ParseMessage(NOTIFICATION_EXAMPLE);

            Assert.AreEqual(Message.MESSAGE_TYPE_NOTIFICATION, message.Type);
            Assert.AreEqual("0b68823a-c5fd-5da4-b99a-ce15238d3c5d", message.MessageId);
            Assert.AreEqual("arn:aws:sns:us-west-2:245953695175:snstest1", message.TopicArn);
            Assert.AreEqual("Greetings", message.Subject);
            Assert.AreEqual("Hello\r\nTo\r\nThe\r\nWorld", message.MessageText);
            Assert.AreEqual(2014, message.Timestamp.Year);
            Assert.AreEqual("1", message.SignatureVersion);
            Assert.AreEqual("Uae26RRYgt3SjQCvyPwSxfjoyb8qmh4LiUr1Hz4YcAVgFjbozxiotCVRlRYmTnUjnRrtUzIP0nEWBv5t6C+lbhIT+jD8c9vK/FrDi5q60ghH0UinUQPSsmeo9iRwTwNT6Z91o8GHwgpIxjB7nM6jKBfsYUC8EjsWZ2eAFNJDvx4ggJZM8wkHiqreqIwy6RBI8xQvo8S8ZQxrhkFYajH+wQF7/CJfgHXBmnENCZlHPsp/t81myRAZW6crk8RAuIUNPAMz2KoiDaSVmQ2beVDXlV1gaudwwfiZgEd49gYV+DyLI5aiiaajQVVHaVEgQ5la/RFGC13oh/KiMhdHHb1AKA==", message.Signature);
            Assert.AreEqual("https://sns.us-west-2.amazonaws.com/SimpleNotificationService-e372f8ca30337fdb084e8ac449342c77.pem", message.SigningCertURL);
            Assert.AreEqual("https://sns.us-west-2.amazonaws.com/?Action=Unsubscribe&SubscriptionArn=arn:aws:sns:us-west-2:245953695175:snstest1:2d79be76-0e5a-4073-b000-294bd1f6d04a", message.UnsubscribeURL);

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
