using Amazon;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using Amazon.MobileAnalytics.Model;
using Amazon.Runtime;
using Moq;
using NUnit.Framework;
using NUnit.Tests.DLL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThirdParty.Json.LitJson;
using System.Threading.Tasks;
namespace NUnit.Tests.DLL
{
    [TestFixture]
    public class MobileAnalyticsManagerTest
    {
        [Test]
        public void TestMonetizationEvent()
        {
            MonetizationEvent monetizationEvent = new MonetizationEvent();

            // Set the details of the monetization event
            monetizationEvent.Quantity = 3.0;
            monetizationEvent.ItemPrice = 1.99;
            monetizationEvent.ProductId = "ProductId123";
            monetizationEvent.ItemPriceFormatted = "$1.99";
            monetizationEvent.Store = "Your-App-Store";
            monetizationEvent.TransactionId = "TransactionId123";
            monetizationEvent.Currency = "USD";
            Assert.AreEqual(monetizationEvent.Quantity, 3.0);
            Assert.AreEqual(monetizationEvent.ItemPrice, 1.99);
            Assert.AreEqual(monetizationEvent.ProductId, "ProductId123");
            Assert.AreEqual(monetizationEvent.ItemPriceFormatted, "$1.99");
            Assert.AreEqual(monetizationEvent.Store, "Your-App-Store");
            Assert.AreEqual(monetizationEvent.TransactionId, "TransactionId123");
            Assert.AreEqual(monetizationEvent.Currency, "USD");
        }
        [Test]
        public void TestCustomEvent()
        {
            CustomEvent customEvent = new CustomEvent("first");
            string longAttributeName = "key".PadRight(100, 'k'); // "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz");
            string longValue = "value".PadRight(500, 'v');

            Dictionary<string, string> attributes = new Dictionary<string, string>()
            {
                {"attributename1" , "atrritutevaule1" },
                {"attributename2" , "atrritutevaule2" },
                {"attributename3" , "atrritutevaule3" },

            };
            foreach (var key in attributes.Keys)
            {
                customEvent.AddAttribute(key, attributes[key]);
                Assert.IsTrue(customEvent.HasAttribute(key));
                Assert.AreEqual(customEvent.GetAttribute(key), attributes[key]);
            }
            Assert.AreEqual(customEvent.AllAttributes, attributes);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.HasAttribute("")).Message.Contains("attributeName"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetAttribute("")).Message.Contains("attributeName"));




            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddAttribute("", "atrritutevaule")).Message.Contains("attributeName"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddAttribute("attributename", null)).Message.Contains("attributeValue"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddAttribute(longAttributeName, "atrritutevaule")).Message.Contains("Length of attributeName"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddAttribute("attributename", longValue)).Message.Contains("Length of attributeValue is more than"));
            //make sure not Attribute are added
            Assert.AreEqual(customEvent.AllAttributes, attributes);

            Dictionary<string, double> metrics = new Dictionary<string, double>()
            {
                {"metric1", 1},
                {"metric2", 2},
                {"metric3", 3},
            };
            foreach (var key in metrics.Keys)
            {
                customEvent.AddMetric(key, metrics[key]);
                Assert.IsTrue(customEvent.HasMetric(key));
                Assert.AreEqual(customEvent.GetMetric(key), metrics[key]);
            }
            Assert.AreEqual(customEvent.AllMetrics, metrics);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddMetric("", 0)).Message.Contains("metricName"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddMetric(longAttributeName, 0)).Message.Contains("length of the metricName "));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.HasMetric("")).Message.Contains("metricName"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetMetric("")).Message.Contains("metricName"));



            customEvent.AddGlobalAttribute("CharacterClass", "Warrior");
            Assert.AreEqual(customEvent.GetGlobalAttribute("CharacterClass"), "Warrior");

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalAttribute("", "Warrior")).Message.Contains("attributeName"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalAttribute("CharacterClass", null)).Message.Contains("attributeValue"));
            Assert.IsTrue(  Assert.Throws<ArgumentException>(() => customEvent.AddGlobalAttribute(longAttributeName, "Warrior")).Message.Contains("Length of attributeName"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddGlobalAttribute("CharacterClass", longValue)).Message.Contains("Length of attributeValue is more than"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetGlobalAttribute("")).Message.Contains("attributeName"));





            customEvent.AddGlobalAttribute("type1", "CharacterClass", "Warrior");
            Assert.AreEqual(customEvent.GetGlobalAttribute("type1", "CharacterClass"), "Warrior");
            customEvent.AddGlobalAttribute("type1", "CharacterClass2", "Warrior2");
            Assert.AreEqual(customEvent.GetGlobalAttribute("type1", "CharacterClass2"), "Warrior2");

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalAttribute("", "CharacterClass", "Warrior")).Message.Contains("eventType"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalAttribute("type1", "", "Warrior")).Message.Contains("attributeName"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalAttribute("type1", "CharacterClass", null)).Message.Contains("attributeValue"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddGlobalAttribute("type1", longAttributeName, "Warrior")).Message.Contains("Length of attributeName"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddGlobalAttribute("type1","CharacterClass", longValue)).Message.Contains("Length of attributeValue is more than"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetGlobalAttribute("", "CharacterClass")).Message.Contains("eventType"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetGlobalAttribute("type1", "")).Message.Contains("attributeName"));




            customEvent.AddGlobalMetric("TimeInLevel", 64);
            Assert.AreEqual(customEvent.GetGlobalMetric("TimeInLevel"), 64);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalMetric("", 0)).Message.Contains("metricName"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetGlobalMetric("")).Message.Contains("metricName"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddGlobalMetric(longAttributeName, 0)).Message.Contains("Length of the metricName"));


            customEvent.AddGlobalMetric("type1", "TimeInLevel", 64);
            Assert.AreEqual(customEvent.GetGlobalMetric("type1", "TimeInLevel"), 64);
            customEvent.AddGlobalMetric("type1", "TimeInLevel2", 66);
            Assert.AreEqual(customEvent.GetGlobalMetric("type1", "TimeInLevel2"), 66);

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalMetric("", "TimeInLevel", 0)).Message.Contains("eventType"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.AddGlobalMetric("type1", "", 0)).Message.Contains("metricName"));
            Assert.IsTrue(Assert.Throws<ArgumentException>(() => customEvent.AddGlobalMetric("type1",  longAttributeName, 0)).Message.Contains("Length of the metricName"));

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetGlobalMetric("type1", "")).Message.Contains("metricName"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.GetGlobalMetric("", "TimeInLevel")).Message.Contains("eventType"));



            customEvent.RemoveGlobalAttribute("CharacterClass");
            Assert.AreEqual(customEvent.GetGlobalAttribute("CharacterClass"), null);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.RemoveGlobalAttribute("")).Message.Contains("attributeName"));


            customEvent.RemoveGlobalMetric("TimeInLevel");
            Assert.AreEqual(customEvent.GetGlobalMetric("TimeInLevel"), null);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.RemoveGlobalMetric("")).Message.Contains("metricName"));

            customEvent.RemoveGlobalAttribute("type1", "CharacterClass");
            Assert.AreEqual(customEvent.GetGlobalAttribute("type1", "CharacterClass"), null);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.RemoveGlobalAttribute("", "CharacterClass")).Message.Contains("eventType"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.RemoveGlobalAttribute("type1", "")).Message.Contains("attributeName"));

            customEvent.RemoveGlobalMetric("type1", "TimeInLevel");
            Assert.AreEqual(customEvent.GetGlobalMetric("type1", "TimeInLevel"), null);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.RemoveGlobalMetric("", "TimeInLevel")).Message.Contains("eventType"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => customEvent.RemoveGlobalMetric("type1", "")).Message.Contains("metricName"));

        }

        [Test]
        public void TestMobileAnalyticsManagerConfig()
        {
            var config = new MobileAnalyticsManagerConfig();
            config.AllowUseDataNetwork = true;
            config.DBWarningThreshold = 0.9f;
            config.MaxDBSize = 5242880;
            config.MaxRequestSize = 102400;
            config.SessionTimeout = 5;
            Assert.AreEqual(config.AllowUseDataNetwork, true);
            Assert.AreEqual(config.DBWarningThreshold, 0.9f);
            Assert.AreEqual(config.MaxDBSize, 5242880);
            Assert.AreEqual(config.MaxRequestSize, 102400);
            Assert.AreEqual(config.SessionTimeout, 5);
        }


        [Test]
        public void TestMobileAnalyticsManager()
        {
            var config = new MobileAnalyticsManagerConfig();
            const int sessionTimeout = 5; 
            config.SessionTimeout = sessionTimeout; 
            AWSCredentials credentials = new AnonymousAWSCredentials();
            var analyticsManager = MobileAnalyticsManager.GetOrCreateInstance("testappid",
                credentials,
                RegionEndpoint.USEast1,
                config
            );
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetOrCreateInstance("",
                credentials,
                RegionEndpoint.USEast1,
                config
            )).Message.Contains("appID"));

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetOrCreateInstance("testappid",
                null,
                RegionEndpoint.USEast1,
                config
            )).Message.Contains("credentials"));

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetOrCreateInstance("testappid",
                credentials,
               null,
                config
            )).Message.Contains("regionEndpoint"));

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetOrCreateInstance("testappid",
                credentials,
                RegionEndpoint.USEast1,
                null
            )).Message.Contains("maConfig"));


            var analyticsManager2 = MobileAnalyticsManager.GetOrCreateInstance("testappid",
                credentials,
                RegionEndpoint.USEast1,
                config
            );
            Assert.AreSame(analyticsManager, analyticsManager2);
            var analyticsManager3 = MobileAnalyticsManager.GetOrCreateInstance("testappid",
                credentials,
                RegionEndpoint.USEast1);
            Assert.AreSame(analyticsManager, analyticsManager3);

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetOrCreateInstance("",
                credentials,
                RegionEndpoint.USEast1
            )).Message.Contains("appID"));

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetOrCreateInstance("testappid",
                null,
                RegionEndpoint.USEast1
            )).Message.Contains("credentials"));

            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetOrCreateInstance("testappid",
                credentials,
                null
            )).Message.Contains("regionEndpoint"));

            Assert.AreSame(MobileAnalyticsManager.GetInstance("testappid"), analyticsManager);
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => MobileAnalyticsManager.GetInstance("")).Message.Contains("appID"));
            Assert.IsTrue(Assert.Throws<InvalidOperationException>(() => MobileAnalyticsManager.GetInstance("noexistappid")).Message.Contains("Cannot find MobileAnalyticsManager instance for appID"));



            analyticsManager.AddCustomAttributeToClientContext("thiskey", "thisvalue");
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => analyticsManager.AddCustomAttributeToClientContext("", "thisvalue")).Message.Contains("key"));
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => analyticsManager.AddCustomAttributeToClientContext("thiskey", null)).Message.Contains("value"));

            var mockDeliveryClient = new Moq.Mock<IDeliveryClient>();
            mockDeliveryClient.Setup(s => s.AttemptDeliveryAsync());
            List<Amazon.MobileAnalytics.Model.Event> eventlist = new List<Event>();
            int monetizationEventCount = 0;
            int testEventCount = 0;
            int pauseEventCount = 0;
            int resumeEventCount = 0;
            int startEventCount = 0;
            int stopEventCount = 0; 
            mockDeliveryClient.Setup(s => s.EnqueueEventsForDelivery(It.IsAny<Amazon.MobileAnalytics.Model.Event>())).Callback(
                (Amazon.MobileAnalytics.Model.Event e) =>
                {

                    switch (e.EventType)
                    {
                        case "_monetization.purchase":
                            monetizationEventCount++;
                            break;
                        case Constants.SESSION_PAUSE_EVENT_TYPE:
                            pauseEventCount++;
                            break;
                        case Constants.SESSION_RESUME_EVENT_TYPE:
                            resumeEventCount++;
                            break;
                        case Constants.SESSION_START_EVENT_TYPE:
                            startEventCount++;
                            break;
                        case Constants.SESSION_STOP_EVENT_TYPE:
                            stopEventCount++;
                            break;
                        case "TestCustomEvent":
                            testEventCount++;
                            break;

                    }
                }
                );
            PrivateValueAccessor.GetPrivatePropertyInfo(typeof(MobileAnalyticsManager), "BackgroundDeliveryClient").SetValue(analyticsManager, mockDeliveryClient.Object);
            //      analyticsManager.BackgroundDeliveryClient = mockDeliveryClient.Object; 
            //Set the details of the monetization event
            MonetizationEvent monetizationEvent = new MonetizationEvent();
            monetizationEvent.Quantity = 3.0;
            monetizationEvent.ItemPrice = 1.99;
            monetizationEvent.ProductId = "ProductId123";
            monetizationEvent.ItemPriceFormatted = "$1.99";
            monetizationEvent.Store = "Your-App-Store";
            monetizationEvent.TransactionId = "TransactionId123";
            monetizationEvent.Currency = "USD";

            analyticsManager.RecordEvent(monetizationEvent);
            CustomEvent customEvent = new CustomEvent("TestCustomEvent");
            customEvent.AddAttribute("LevelName", "Level1");
            customEvent.AddAttribute("CharacterClass", "Warrior");
            customEvent.AddAttribute("Successful", "True");
            customEvent.AddMetric("Score", 12345);
            customEvent.AddMetric("TimeInLevel", 64);
            analyticsManager.RecordEvent(customEvent);
            analyticsManager.PauseSession();
            analyticsManager.ResumeSession();
            Assert.IsTrue(Assert.Throws<ArgumentNullException>(() => analyticsManager.RecordEvent(null)).Message.Contains("customEvent"));






            System.Threading.Thread.Sleep(2000);
            Assert.AreEqual(monetizationEventCount, 1);
            Assert.AreEqual(testEventCount, 1);
            Assert.AreEqual(pauseEventCount, 1);
            Assert.AreEqual(resumeEventCount, 1);
            Assert.AreEqual(stopEventCount, 0);

            resumeEventCount = 0;
            startEventCount = 0;
            stopEventCount = 0;
            analyticsManager.PauseSession();
            System.Threading.Thread.Sleep((sessionTimeout+ 1) * 1000);
            analyticsManager.ResumeSession();
            Assert.AreEqual(resumeEventCount, 0);
            Assert.AreEqual(stopEventCount, 1);
            Assert.AreEqual(startEventCount, 1);
            Assert.AreNotEqual(null, MobileAnalyticsManager.CopyOfInstanceDictionary);

            Task.Delay(70 * 1000).Wait();
            BackgroundRunner.AbortBackgroundRunner();
            Task.WhenAll().Wait();
            analyticsManager.Dispose();

        }
 
    }
}
