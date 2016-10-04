using Amazon;
using Amazon.MobileAnalytics;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using CommonTests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCLStorage;
using ThirdParty.Json.LitJson;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestFixture]
    public class AnalyticsManager : TestBase<AmazonMobileAnalyticsClient>
    {
        [OneTimeSetUp]
        public async void Setup()
        {
            string dbPath = Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, "mobile_analytic_event.db");
            IFile file = await FileSystem.Current.GetFileFromPathAsync(dbPath);
            if (file != null)
                await file.DeleteAsync();
        }

        [OneTimeTearDown]
        public async void Destroy()
        {
            string dbPath = Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, "mobile_analytic_event.db");
            IFile file = await FileSystem.Current.GetFileFromPathAsync(dbPath);
            if (file != null)
                await file.DeleteAsync();
        }

        [Test]
        [Category("AnalyticsManager")]
        public void TestEventStore()
        {
            // Create table
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
                List<JsonData> allEventList = eventStore.GetEvents(appId, EVENT_COUNT / 2);
                List<string> deleteEventsIdList = new List<string>();
                foreach (JsonData eventData in allEventList)
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
    }
}
