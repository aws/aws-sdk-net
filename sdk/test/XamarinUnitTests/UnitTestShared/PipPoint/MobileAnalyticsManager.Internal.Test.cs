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
using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal;
using Amazon.MobileAnalytics;

namespace NUnit.Tests.DLL
{
    [TestFixture]
    public class MobileAnalyticsManagerInternalTest
    {
        [Test]
        public void TestDeliveryClient()
        {
            var config = new MobileAnalyticsManagerConfig();
            const int sessionTimeout = 5;
            config.SessionTimeout = sessionTimeout;
            AWSCredentials credentials = new AnonymousAWSCredentials();
            RegionEndpoint regionEndPoint = RegionEndpoint.USEast1;
            var analyticsManager = MobileAnalyticsManager.GetOrCreateInstance("testappid",
                credentials,
                regionEndPoint,
                config
            );


 

            var mockmaConfig = new Moq.Mock<MobileAnalyticsManagerConfig>();
            var mockclientContext = new Moq.Mock<ClientContext>("testappid");
            var mockmaManager = new Moq.Mock<MobileAnalyticsManager>();
            var mockeventStore = new Moq.Mock<SQLiteEventStore>(config);
            mockeventStore.Setup(e => e.PutEvent(It.IsAny<string>(), It.IsAny<string>())).CallBase();
            var deliveryClient = new DeliveryClient(config, analyticsManager.ClientContext, credentials,
                regionEndPoint, analyticsManager);
            PrivateValueAccessor.GetPrivateFieldInfo(typeof(DeliveryClient), "_eventStore").SetValue(deliveryClient, mockeventStore.Object);
            Event eventObject = new Event();
            eventObject.EventType = "test";
    
            deliveryClient.EnqueueEventsForDelivery(eventObject);
            System.Threading.Thread.Sleep(2000);
            mockeventStore.Verify(e => e.PutEvent(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            deliveryClient.EnqueueEventsForDelivery(null);
            System.Threading.Thread.Sleep(2000);
            mockeventStore.Verify(e => e.PutEvent(It.IsAny<string>(), It.IsAny<string>()), Times.Once);

            var mockmobileAnalyticsLowLevelClient =  new Moq.Mock<AmazonMobileAnalyticsClient>(credentials,regionEndPoint);
            mockmobileAnalyticsLowLevelClient.Setup(e => e.PutEventsAsync(It.IsAny<PutEventsRequest>(), It.IsAny<System.Threading.CancellationToken>()));
            PrivateValueAccessor.GetPrivateFieldInfo(typeof(DeliveryClient), "_mobileAnalyticsLowLevelClient").SetValue(deliveryClient, mockmobileAnalyticsLowLevelClient.Object);
            deliveryClient.AttemptDeliveryAsync().Wait();
            mockmobileAnalyticsLowLevelClient.Verify(e => e.PutEventsAsync(It.IsAny<PutEventsRequest>(), It.IsAny<System.Threading.CancellationToken>()), Times.AtLeastOnce);


            deliveryClient.Dispose();

        }
        

        [Test]
        public void TestSQLiteEventStore()
        {
            using (SQLiteEventStore eventStore = new SQLiteEventStore(new MobileAnalyticsManagerConfig()))
            {
                // Insert row
                string eventString = "TestEventStore-dummy-event-string";
                string appId = Guid.NewGuid().ToString();

                const int EVENT_COUNT = 100;

                // Add events
                for (int i = 0; i < EVENT_COUNT / 2; i++)
                {
                    eventStore.PutEvent(eventString, appId);
                }
                long dbFileSizeSmall = eventStore.DatabaseSize;
                for (int i = 0; i < EVENT_COUNT / 2; i++)
                {
                    eventStore.PutEvent(eventString, appId);
                }
                long dbFileSizeBigger = eventStore.DatabaseSize;
                Assert.IsTrue(dbFileSizeBigger > dbFileSizeSmall);

                Console.WriteLine("The num of events are {0}", eventStore.NumberOfEvents(appId));
                Assert.AreEqual(EVENT_COUNT, eventStore.NumberOfEvents(appId));

                // Delete EVENT_COUNT / 2 rows
                List<ThirdParty.Json.LitJson.JsonData> allEventList = eventStore.GetEvents(appId, EVENT_COUNT / 2);
                List<string> deleteEventsIdList = new List<string>();
                foreach (ThirdParty.Json.LitJson.JsonData eventData in allEventList)
                {
                    deleteEventsIdList.Add(eventData["id"].ToString());
                }
                eventStore.DeleteEvent(deleteEventsIdList);

                // check row num again
                Assert.AreEqual(EVENT_COUNT / 2, eventStore.NumberOfEvents(appId));

                // insert EVENT_COUNT / 2 rows again
                for (int i = 0; i < EVENT_COUNT / 2; i++)
                {
                    eventStore.PutEvent(eventString, appId);
                }
                Assert.AreEqual(EVENT_COUNT, eventStore.NumberOfEvents(appId));

                // remove all rows
                allEventList = eventStore.GetEvents(appId, EVENT_COUNT);
                deleteEventsIdList = new List<string>();
                foreach (JsonData eventData in allEventList)
                {
                    deleteEventsIdList.Add(eventData["id"].ToString());
                }
                eventStore.DeleteEvent(deleteEventsIdList);
                Assert.AreEqual(0, eventStore.NumberOfEvents(appId));

            }
        }

        [Test]
        public void TestSqlite3Exception()
        {
            Result r = new Result();
            var ex = Assert.Throws<Sqlite3Exception>(() => throw Sqlite3Exception.New(r, "Sqlite3Exception exception"));
            Assert.AreEqual(ex.Result, r);
            Assert.AreEqual(ex.Message, "Sqlite3Exception exception");

        }

        [Test]
        public void TestEventStoreException()
        {
            Exception innerException = new Exception("inner exception"); 
            string message = "exception message" ;
            var ex = Assert.Throws<EventStoreException>(() => throw new EventStoreException(message));
            Assert.AreEqual(ex.Message, message);
            ex = Assert.Throws<EventStoreException>(() => throw new EventStoreException(message, innerException));
            Assert.AreEqual(ex.Message, message);
            Assert.AreEqual(ex.InnerException, innerException);
        }
    }
}
