using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.MobileAnalytics;
using System.Collections;
using ThirdParty.Json.LitJson;
using Amazon;
using System.Net;
using Amazon.MobileAnalytics.Model;



namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class SampleTests : TestBase<AmazonMobileAnalyticsClient>
    {

        [Test]
        public void TestSessionTimeout()
        {
            MobileAnalyticsManagerConfig maConfig = new MobileAnalyticsManagerConfig();
            Console.WriteLine("session delta is " + maConfig.SessionTimeout);

            string appId = "TestSessionTimeout-dummy-app-id";

            DateTime startTimstamp;
            DateTime? stopTimestamp;
            string sessionId;
            long duration;
            GetMobileAnalyticsManager(appId).Session.GetSessionInfo(out startTimstamp, out stopTimestamp, out sessionId, out duration);

            Console.WriteLine("start time stamp is " + startTimstamp);
            Console.WriteLine("stop time stamp is " + startTimstamp);
            Console.WriteLine("session id is " + sessionId);
            Console.WriteLine("duration is " + duration);

            // sleep for a while but wake up before session expires
            GetMobileAnalyticsManager(appId).PauseSession();
            Task.Delay(Convert.ToInt32((maConfig.SessionTimeout - 1) * 1000));

            GetMobileAnalyticsManager(appId).ResumeSession();

            DateTime startTimstamp2;
            DateTime? stopTimestamp2;
            string sessionId2;
            long duration2;
            GetMobileAnalyticsManager(appId).Session.GetSessionInfo(out startTimstamp2, out stopTimestamp2, out sessionId2, out duration2);
            Console.WriteLine("start time stamp is " + startTimstamp2);
            Console.WriteLine("stop time stamp is " + startTimstamp2);
            Console.WriteLine("session id is " + sessionId2);
            Console.WriteLine("duration is " + duration2);

            Assert.IsTrue(startTimstamp == startTimstamp2 && sessionId == sessionId2);


            // sleep longer until session expires
            GetMobileAnalyticsManager(appId).PauseSession();
            Convert.ToInt32((maConfig.SessionTimeout + 1) * 1000);
            GetMobileAnalyticsManager(appId).ResumeSession();

            DateTime startTimstamp3;
            DateTime? stopTimestamp3;
            string sessionId3;
            long duration3;
            GetMobileAnalyticsManager(appId).Session.GetSessionInfo(out startTimstamp3, out stopTimestamp3, out sessionId3, out duration3);
            Console.WriteLine("start time stamp is " + startTimstamp3);
            Console.WriteLine("stop time stamp is " + startTimstamp3);
            Console.WriteLine("session id is " + sessionId3);
            Console.WriteLine("duration is " + duration3);

            Assert.IsTrue(startTimstamp2 != startTimstamp3 && sessionId2 != sessionId3);
        }


        [Test]
        public void TestManagerAddClientContextCustomAttribute()
        {
            string KEY1 = "key1";
            string KEY2 = "key2";
            string VALUE1 = "value1";
            string VALUE2 = "value2";
            string appId = "dummy-id";

            MobileAnalyticsManager manager = GetMobileAnalyticsManager(appId);

            manager.AddClientContextCustomAttribute(KEY1, VALUE1);
            manager.AddClientContextCustomAttribute(KEY2, VALUE2);

            string clientContextString = manager.ClientContext.ToJsonString();

            Assert.IsTrue(clientContextString.IndexOf("custom") > 0);
            Assert.IsTrue(clientContextString.IndexOf(KEY1) > 0);
            Assert.IsTrue(clientContextString.IndexOf(KEY2) > 0);

            Assert.IsTrue(clientContextString.IndexOf("custom") < clientContextString.IndexOf(KEY1));
            Assert.IsTrue(clientContextString.IndexOf("custom") < clientContextString.IndexOf(KEY2));
            Assert.IsTrue(clientContextString.IndexOf(KEY1) < clientContextString.IndexOf(VALUE1));
            Assert.IsTrue(clientContextString.IndexOf(KEY2) < clientContextString.IndexOf(VALUE2));
        }

        [Test]
        public void TestManagerMultipleInstance()
        {
            string APP_ID_1 = "TestManagerMultipleInstance-app-id-1";
            string APP_ID_2 = "TestManagerMultipleInstance-app-id-2";
            string APP_ID_3 = "TestManagerMultipleInstance-app-id-3";

            MobileAnalyticsManager manager1 = GetMobileAnalyticsManager(APP_ID_1);
            MobileAnalyticsManager manager2 = GetMobileAnalyticsManager(APP_ID_2);
            MobileAnalyticsManager manager3 = GetMobileAnalyticsManager(APP_ID_3);

            string clientContextString1 = manager1.ClientContext.ToJsonString();
            string clientContextString2 = manager2.ClientContext.ToJsonString();
            string clientContextString3 = manager3.ClientContext.ToJsonString();

            Assert.IsTrue(clientContextString1.IndexOf(APP_ID_1) > 0);
            Assert.IsTrue(clientContextString2.IndexOf(APP_ID_2) > 0);
            Assert.IsTrue(clientContextString3.IndexOf(APP_ID_3) > 0);
        }

        [Test]
        public async void TestLowLevelAPI()
        {
            List<Amazon.MobileAnalytics.Model.Event> listEvent = new List<Amazon.MobileAnalytics.Model.Event>();
            listEvent.Add(BuildCustomEvent());

            PutEventsRequest putRequest = new PutEventsRequest();
            putRequest.Events = listEvent;
            string clientContext = BuildClientContext();
            Console.WriteLine("client ocntext is {0}", clientContext);
            putRequest.ClientContext = Convert.ToBase64String(
                            System.Text.Encoding.UTF8.GetBytes(clientContext));
            putRequest.ClientContextEncoding = "base64";

            PutEventsResponse PutResponse = await Client.PutEventsAsync(putRequest);

            Assert.AreEqual(HttpStatusCode.Accepted, PutResponse.HttpStatusCode);

        }

        [Test]
        public async void TestSession()
        {
            string sessionID = Guid.NewGuid().ToString();
            List<Amazon.MobileAnalytics.Model.Event> listEvent = new List<Amazon.MobileAnalytics.Model.Event>();
            listEvent.Add(BuildSessionStartEvent(sessionID));
            listEvent.Add(BuildSessionEndEvent(sessionID));

            PutEventsRequest putRequest = new PutEventsRequest();
            putRequest.Events = listEvent;
            string clientContext = BuildClientContext();
            putRequest.ClientContext = Convert.ToBase64String(
                            System.Text.Encoding.UTF8.GetBytes(clientContext));
            putRequest.ClientContextEncoding = "base64";

            PutEventsResponse PutResponse = await Client.PutEventsAsync(putRequest);

            Assert.AreEqual(HttpStatusCode.Accepted, PutResponse.HttpStatusCode);
        }


        [Test]
        public void TestCustomEventConcurrency()
        {
            // event type
            const string EVENT_TYPE = "MyEventType";

            // attribute config
            string ATTR1 = "ATTR1";
            string ATTR1_VAL_T0 = "dshjadfhjdfa132`23jj`23jh1k2h3h21hg3h21j2gh";
            string ATTR1_VAL_T1 = "gfhfdhgvkfdkgljfdgjfdsj;l34t43jj4erjerb";
            string ATTR1_VAL_T2 = "7t32674tgdfjehkjdksjs;akfdshfjdsafkadsfdsljfa";

            string ATTR2 = "ATTR2";
            string ATTR2_VAL_T0 = "343hjfdshdfjklsafj0913432jh4";
            string ATTR2_VAL_T1 = "378t43y21ggdhsgdahshfdjsfafd";
            string ATTR2_VAL_T2 = "48ry42378tfhsfkds;kfl;dsdfk;ldslks";

            string ATTR3 = "ATTR3";
            string ATTR3_VAL_T0 = "321432g4ghjfjshdggfjhsdgfdskgfjdsjgfsd";
            string ATTR3_VAL_T1 = "76432tgrsgerhjkfgshdfdssfgjdssaf";
            string ATTR3_VAL_T2 = "87549353hjtkgdk;sfgfdgf;kfl;dshfjdsjkhfjs";

            string ATTR_EMPTY1 = "ATTR_EMPTY1";
            string ATTR_EMPTY2 = "ATTR_EMPTY2";
            string ATTR_EMPTY3 = "ATTR_EMPTY3";

            // metric config
            System.Random randObj = new System.Random();
            const string METRIC1 = "METRIC1";
            double METRIC1_VAL_T0 = randObj.Next();
            double METRIC1_VAL_T1 = randObj.Next();
            double METRIC1_VAL_T2 = randObj.Next();

            const string METRIC2 = "METRIC2";
            double METRIC2_VAL_T0 = randObj.Next();
            double METRIC2_VAL_T1 = randObj.Next();
            double METRIC2_VAL_T2 = randObj.Next();

            const string METRIC3 = "METRIC3";
            double METRIC3_VAL_T0 = randObj.Next();
            double METRIC3_VAL_T1 = randObj.Next();
            double METRIC3_VAL_T2 = randObj.Next();


            CustomEvent customEvent = new CustomEvent(EVENT_TYPE);
            const int LOOP_COUNT = 999;

            Task task0 = new Task(() =>
            {

                for (int i = 0; i < LOOP_COUNT; i++)
                {
                    customEvent.AddAttribute(ATTR1, ATTR1_VAL_T0);
                    customEvent.AddGlobalAttribute(ATTR2, ATTR2_VAL_T0);
                    customEvent.AddGlobalAttribute(EVENT_TYPE, ATTR3, ATTR3_VAL_T0);

                    customEvent.AddMetric(METRIC1, METRIC1_VAL_T0);
                    customEvent.AddGlobalMetric(METRIC2, METRIC2_VAL_T0);
                    customEvent.AddGlobalMetric(EVENT_TYPE, METRIC3, METRIC3_VAL_T0);


                    customEvent.AddAttribute(ATTR_EMPTY1, "");
                    customEvent.AddGlobalAttribute(ATTR_EMPTY2, "");
                    customEvent.AddGlobalAttribute(EVENT_TYPE, ATTR_EMPTY3, "");
                }
            });


            Task task1 = new Task(() =>
            {

                for (int i = 0; i < LOOP_COUNT; i++)
                {
                    customEvent.AddAttribute(ATTR1, ATTR1_VAL_T1);
                    customEvent.AddGlobalAttribute(ATTR2, ATTR2_VAL_T1);
                    customEvent.AddGlobalAttribute(EVENT_TYPE, ATTR3, ATTR3_VAL_T1);

                    customEvent.AddMetric(METRIC1, METRIC1_VAL_T1);
                    customEvent.AddGlobalMetric(METRIC2, METRIC2_VAL_T1);
                    customEvent.AddGlobalMetric(EVENT_TYPE, METRIC3, METRIC3_VAL_T1);
                }
            });


            Task task2 = new Task(() =>
            {
                for (int i = 0; i < LOOP_COUNT; i++)
                {
                    customEvent.AddAttribute(ATTR1, ATTR1_VAL_T1);
                    customEvent.AddGlobalAttribute(ATTR2, ATTR2_VAL_T1);
                    customEvent.AddGlobalAttribute(EVENT_TYPE, ATTR3, ATTR3_VAL_T1);

                    customEvent.AddMetric(METRIC1, METRIC1_VAL_T1);
                    customEvent.AddGlobalMetric(METRIC2, METRIC2_VAL_T1);
                    customEvent.AddGlobalMetric(EVENT_TYPE, METRIC3, METRIC3_VAL_T1);
                }
            });


            task0.Start();
            task1.Start();
            task2.Start();

            // wait all task complete 
            Task.WaitAll(new[] { task0, task1, task2 });

            // Get Model event.
            Amazon.MobileAnalytics.Model.Event modelEvent = customEvent.ConvertToMobileAnalyticsModelEvent(GetMobileAnalyticsManager("TestCustomEventConcurrency").Session);

            // check attribute value
            if (!modelEvent.Attributes.ContainsKey(ATTR1) || !modelEvent.Attributes.ContainsKey(ATTR2) || !modelEvent.Attributes.ContainsKey(ATTR3))
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[ATTR1] != ATTR1_VAL_T0 && modelEvent.Attributes[ATTR1] != ATTR1_VAL_T1 && modelEvent.Attributes[ATTR1] != ATTR1_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[ATTR2] != ATTR2_VAL_T0 && modelEvent.Attributes[ATTR2] != ATTR2_VAL_T1 && modelEvent.Attributes[ATTR2] != ATTR2_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[ATTR3] != ATTR3_VAL_T0 && modelEvent.Attributes[ATTR3] != ATTR3_VAL_T1 && modelEvent.Attributes[ATTR3] != ATTR3_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[ATTR_EMPTY1] != "" || modelEvent.Attributes[ATTR_EMPTY2] != "" || modelEvent.Attributes[ATTR_EMPTY3] != "")
            {
                Assert.Fail();
                return;
            }


            // check metric value
            if (!modelEvent.Metrics.ContainsKey(METRIC1) || !modelEvent.Metrics.ContainsKey(METRIC2) || !modelEvent.Metrics.ContainsKey(METRIC3))
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Metrics[METRIC1] != METRIC1_VAL_T0 && modelEvent.Metrics[METRIC1] != METRIC1_VAL_T1 && modelEvent.Metrics[METRIC1] != METRIC1_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Metrics[METRIC2] != METRIC2_VAL_T0 && modelEvent.Metrics[METRIC2] != METRIC2_VAL_T1 && modelEvent.Metrics[METRIC2] != METRIC2_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Metrics[METRIC3] != METRIC3_VAL_T0 && modelEvent.Metrics[METRIC3] != METRIC3_VAL_T1 && modelEvent.Metrics[METRIC3] != METRIC3_VAL_T2)
            {
                Assert.Fail();
                return;
            }

        }


        [Test]
        public void TestMonetizationEventConcurrency()
        {
            // event type
            const string EVENT_TYPE = "_monetization.purchase";

            const double QUANTITY = 321321;
            const double ITEM_PRICE = 854584;
            const string PRODUCT_ID = "PRODUCT_ID123";
            const string ITEM_PRICE_FORMATTED = "$1.99";
            const string STORE = "STORE";
            const string TRANSACTION_ID = "TRANSACTION_ID123";
            const string CURRENCY = "2.22";


            // attribute config
            const string ATTR1 = "ATTR1";
            string ATTR1_VAL_T0 = Guid.NewGuid().ToString();
            string ATTR1_VAL_T1 = Guid.NewGuid().ToString();
            string ATTR1_VAL_T2 = Guid.NewGuid().ToString();

            const string ATTR2 = "ATTR2";
            string ATTR2_VAL_T0 = Guid.NewGuid().ToString();
            string ATTR2_VAL_T1 = Guid.NewGuid().ToString();
            string ATTR2_VAL_T2 = Guid.NewGuid().ToString();

            const string ATTR3 = "ATTR3";
            string ATTR3_VAL_T0 = Guid.NewGuid().ToString();
            string ATTR3_VAL_T1 = Guid.NewGuid().ToString();
            string ATTR3_VAL_T2 = Guid.NewGuid().ToString();


            // metric config
            System.Random randObj = new System.Random();
            const string METRIC1 = "METRIC1";
            double METRIC1_VAL_T0 = randObj.Next();
            double METRIC1_VAL_T1 = randObj.Next();
            double METRIC1_VAL_T2 = randObj.Next();

            const string METRIC2 = "METRIC2";
            double METRIC2_VAL_T0 = randObj.Next();
            double METRIC2_VAL_T1 = randObj.Next();
            double METRIC2_VAL_T2 = randObj.Next();

            const string METRIC3 = "METRIC3";
            double METRIC3_VAL_T0 = randObj.Next();
            double METRIC3_VAL_T1 = randObj.Next();
            double METRIC3_VAL_T2 = randObj.Next();

            MonetizationEvent monetizationEvent = new MonetizationEvent();

            const int LOOP_COUNT = 1;


            Task task0 = new Task(() =>
            {

                int i = 0;
                for (i = 0; i < LOOP_COUNT; i++)
                {
                    monetizationEvent.AddAttribute(ATTR1, ATTR1_VAL_T0);
                    monetizationEvent.AddGlobalAttribute(ATTR2, ATTR2_VAL_T0);
                    monetizationEvent.AddGlobalAttribute(EVENT_TYPE, ATTR3, ATTR3_VAL_T0);

                    monetizationEvent.AddMetric(METRIC1, METRIC1_VAL_T0);
                    monetizationEvent.AddGlobalMetric(METRIC2, METRIC2_VAL_T0);
                    monetizationEvent.AddGlobalMetric(EVENT_TYPE, METRIC3, METRIC3_VAL_T0);
                }

                monetizationEvent.Quantity = QUANTITY;
                monetizationEvent.ItemPrice = ITEM_PRICE;
            });



            Task task1 = new Task(() =>
            {
                int i = 0;
                for (i = 0; i < LOOP_COUNT; i++)
                {
                    monetizationEvent.AddAttribute(ATTR1, ATTR1_VAL_T1);
                    monetizationEvent.AddGlobalAttribute(ATTR2, ATTR2_VAL_T1);
                    monetizationEvent.AddGlobalAttribute(EVENT_TYPE, ATTR3, ATTR3_VAL_T1);

                    monetizationEvent.AddMetric(METRIC1, METRIC1_VAL_T1);
                    monetizationEvent.AddGlobalMetric(METRIC2, METRIC2_VAL_T1);
                    monetizationEvent.AddGlobalMetric(EVENT_TYPE, METRIC3, METRIC3_VAL_T1);
                }

                monetizationEvent.ProductId = PRODUCT_ID;
                monetizationEvent.ItemPriceFormatted = ITEM_PRICE_FORMATTED;
                monetizationEvent.Store = STORE;
                monetizationEvent.TransactionId = TRANSACTION_ID;
                monetizationEvent.Currency = CURRENCY;
            });


            Task task2 = new Task(() =>
            {
                int i = 0;
                for (i = 0; i < LOOP_COUNT; i++)
                {
                    monetizationEvent.AddAttribute(ATTR1, ATTR1_VAL_T2);
                    monetizationEvent.AddGlobalAttribute(ATTR2, ATTR2_VAL_T2);
                    monetizationEvent.AddGlobalAttribute(EVENT_TYPE, ATTR3, ATTR3_VAL_T2);

                    monetizationEvent.AddMetric(METRIC1, METRIC1_VAL_T2);
                    monetizationEvent.AddGlobalMetric(METRIC2, METRIC2_VAL_T2);
                    monetizationEvent.AddGlobalMetric(EVENT_TYPE, METRIC3, METRIC3_VAL_T2);
                }
            });


            task0.Start();
            task1.Start();
            task2.Start();

            // wait all task complete 
            Task.WaitAll(new[] { task0, task1, task2 });

            // Get model event.
            Amazon.MobileAnalytics.Model.Event modelEvent = monetizationEvent.ConvertToMobileAnalyticsModelEvent(GetMobileAnalyticsManager("TestMonetizationEventConcurrency").Session);

            // Check attribute value.
            if (!modelEvent.Attributes.ContainsKey(ATTR1) || !modelEvent.Attributes.ContainsKey(ATTR2) || !modelEvent.Attributes.ContainsKey(ATTR3))
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[ATTR1] != ATTR1_VAL_T0 && modelEvent.Attributes[ATTR1] != ATTR1_VAL_T1 && modelEvent.Attributes[ATTR1] != ATTR1_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[ATTR2] != ATTR2_VAL_T0 && modelEvent.Attributes[ATTR2] != ATTR2_VAL_T1 && modelEvent.Attributes[ATTR2] != ATTR2_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[ATTR3] != ATTR3_VAL_T0 && modelEvent.Attributes[ATTR3] != ATTR3_VAL_T1 && modelEvent.Attributes[ATTR3] != ATTR3_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            // check metric value
            if (!modelEvent.Metrics.ContainsKey(METRIC1) || !modelEvent.Metrics.ContainsKey(METRIC2) || !modelEvent.Metrics.ContainsKey(METRIC3))
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Metrics[METRIC1] != METRIC1_VAL_T0 && modelEvent.Metrics[METRIC1] != METRIC1_VAL_T1 && modelEvent.Metrics[METRIC1] != METRIC1_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Metrics[METRIC2] != METRIC2_VAL_T0 && modelEvent.Metrics[METRIC2] != METRIC2_VAL_T1 && modelEvent.Metrics[METRIC2] != METRIC2_VAL_T2)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Metrics[METRIC3] != METRIC3_VAL_T0 && modelEvent.Metrics[METRIC3] != METRIC3_VAL_T1 && modelEvent.Metrics[METRIC3] != METRIC3_VAL_T2)
            {
                Assert.Fail();
                return;
            }


            // metric name
            const string PURCHASE_EVENT_QUANTITY_METRIC = "_quantity";
            const string PURCHASE_EVENT_ITEM_PRICE_METRIC = "_item_price";

            // attribute name
            const string PURCHASE_EVENT_PRODUCT_ID_ATTR = "_product_id";
            const string PURCHASE_EVENT_ITEM_PRICE_FORMATTED_ATTR = "_item_price_formatted";
            const string PURCHASE_EVENT_STORE_ATTR = "_store";
            const string PURCHASE_EVENT_TRANSACTION_ID_ATTR = "_transaction_id";
            const string PURCHASE_EVENT_CURRENCY_ATTR = "_currency";

            if (modelEvent.Metrics[PURCHASE_EVENT_QUANTITY_METRIC] != QUANTITY || modelEvent.Metrics[PURCHASE_EVENT_ITEM_PRICE_METRIC] != ITEM_PRICE)
            {
                Assert.Fail();
                return;
            }

            if (modelEvent.Attributes[PURCHASE_EVENT_PRODUCT_ID_ATTR] != PRODUCT_ID ||
               modelEvent.Attributes[PURCHASE_EVENT_ITEM_PRICE_FORMATTED_ATTR] != ITEM_PRICE_FORMATTED ||
               modelEvent.Attributes[PURCHASE_EVENT_STORE_ATTR] != STORE ||
               modelEvent.Attributes[PURCHASE_EVENT_TRANSACTION_ID_ATTR] != TRANSACTION_ID ||
               modelEvent.Attributes[PURCHASE_EVENT_CURRENCY_ATTR] != CURRENCY)
            {
                Assert.Fail();
                return;
            }
        }

        [Test]
        public void TestEventStore()
        {
            // Create table
            MobileAnalyticsManagerConfig maConfig = new MobileAnalyticsManagerConfig();
            SQLiteEventStore eventStore = new SQLiteEventStore(maConfig);

            // Insert row
            string eventString = "TestEventStore-dummy-event-string";
            string appId = Guid.NewGuid().ToString();

            const int EVENT_COUNT = 100;

            // Add events
            for (int i = 0; i < EVENT_COUNT / 2; i++)
            {
                eventStore.PutEvent(eventString, appId);
            }
            long dbFileSizeSmall = eventStore.GetDatabaseSize();
            for (int i = 0; i < EVENT_COUNT / 2; i++)
            {
                eventStore.PutEvent(eventString, appId);
            }
            long dbFileSizeBigger = eventStore.GetDatabaseSize();
            //Assert.IsTrue(dbFileSizeBigger > dbFileSizeSmall);

            Console.WriteLine("The num of events are {0}", eventStore.NumberOfEvents(appId));
            Assert.AreEqual(EVENT_COUNT, eventStore.NumberOfEvents(appId));

            // Delete EVENT_COUNT / 2 rows
            List<JsonData> allEventList = eventStore.GetEvents(appId, EVENT_COUNT / 2);
            List<string> deleteEventsIdList = new List<string>();
            foreach (JsonData eventData in allEventList)
            {
                deleteEventsIdList.Add(eventData["id"].ToString());
            }
            Console.WriteLine("The num of events are {0}", eventStore.NumberOfEvents(appId));
            eventStore.DeleteEvent(deleteEventsIdList);
            Console.WriteLine("The num of events are {0}", eventStore.NumberOfEvents(appId));

            // check row num again
            Assert.AreEqual(EVENT_COUNT / 2, eventStore.NumberOfEvents(appId));

            // insert EVENT_COUNT / 2 rows again
            for (int i = 0; i < EVENT_COUNT / 2; i++)
            {
                eventStore.PutEvent(eventString, appId);
            }
            Console.WriteLine("The num of events are {0}", eventStore.NumberOfEvents(appId));
            Assert.AreEqual(EVENT_COUNT, eventStore.NumberOfEvents(appId));
            Console.WriteLine("The num of events are {0}", eventStore.NumberOfEvents(appId));

            // remove all rows
            allEventList = eventStore.GetEvents(appId, EVENT_COUNT);
            deleteEventsIdList = new List<string>();
            foreach (JsonData eventData in allEventList)
            {
                deleteEventsIdList.Add(eventData["id"].ToString());
            }
            eventStore.DeleteEvent(deleteEventsIdList);
            Console.WriteLine("The num of events are {0}", eventStore.NumberOfEvents(appId));
            Assert.AreEqual(0, eventStore.NumberOfEvents(appId));
        }


        private string BuildClientContext()
        {
            Dictionary<string, string> _environment = new Dictionary<string, string>();
            _environment.Add("platform", "Android");
            _environment.Add("model", "Samsung");
            _environment.Add("make", "GT9100");
            _environment.Add("locale", "en-US");
            _environment.Add("platform-version", "4.2.2");

            Dictionary<string, string> _client = new Dictionary<string, string>();
            _client.Add("client_id", Guid.NewGuid().ToString());
            _client.Add("app_title", "Dummy_App");
            _client.Add("app_version_name", "1");
            _client.Add("app_version_code", "1.0.0");
            _client.Add("app_package_name", "com.amazonaws.unity");

            Dictionary<string, string> _servicesData = new Dictionary<string, string>();
            _servicesData.Add("app_id", Guid.NewGuid().ToString());

            Dictionary<string, Dictionary<string, string>> _services = new Dictionary<string, Dictionary<string, string>>();
            _services.Add("mobile_analytics", _servicesData);

            IDictionary<string, IDictionary> context = new Dictionary<string, IDictionary>();
            context.Add("client", _client);
            context.Add("custom", new Dictionary<string, string>());
            context.Add("env", _environment);
            context.Add("services", _services);

            return JsonMapper.ToJson(context).Replace("\"", "'");
        }

        private Amazon.MobileAnalytics.Model.Event BuildCustomEvent()
        {
            Amazon.MobileAnalytics.Model.Event customEvent = new Amazon.MobileAnalytics.Model.Event();

            customEvent.EventType = "LevelComplete";

            Amazon.MobileAnalytics.Model.Session session = new Amazon.MobileAnalytics.Model.Session();
            session.Id = Guid.NewGuid().ToString();
            session.StartTimestamp = DateTime.UtcNow;
            session.StopTimestamp = DateTime.UtcNow;
            session.Duration = 30 * 60 * 1000;
            customEvent.Session = session;

            Dictionary<string, string> attributes = new Dictionary<string, string>();
            attributes.Add("LevelName", "Level1");
            attributes.Add("CharacterClass", "Warrior");
            attributes.Add("Successful", "True");
            customEvent.Attributes = attributes;

            Dictionary<string, double> metrics = new Dictionary<string, double>();
            metrics.Add("Score", 12345);
            metrics.Add("TimeInLevel", 64);
            customEvent.Metrics = metrics;

            customEvent.Version = "v2.0";
            customEvent.Timestamp = DateTime.UtcNow;

            return customEvent;
        }

        private Amazon.MobileAnalytics.Model.Event BuildMonetizationEvent()
        {
            Amazon.MobileAnalytics.Model.Event monetizationEvent = new Amazon.MobileAnalytics.Model.Event();

            monetizationEvent.EventType = "_monetization.purchase";
            Amazon.MobileAnalytics.Model.Session session = new Amazon.MobileAnalytics.Model.Session();
            session.Id = Guid.NewGuid().ToString();
            session.StartTimestamp = DateTime.UtcNow;
            monetizationEvent.Session = session;

            Dictionary<string, string> attributes = new Dictionary<string, string>();
            attributes.Add("_currency_", "USD");
            attributes.Add("_product_id", "Kindle");
            monetizationEvent.Attributes = attributes;

            Dictionary<string, double> metrics = new Dictionary<string, double>();
            metrics.Add("_quantity", 2);
            metrics.Add("_item_price", 110.0);
            monetizationEvent.Metrics = metrics;

            monetizationEvent.Version = "v2.0";
            monetizationEvent.Timestamp = DateTime.Now.ToUniversalTime();

            return monetizationEvent;
        }

        private Amazon.MobileAnalytics.Model.Event BuildSessionStartEvent(string sessionID)
        {
            Amazon.MobileAnalytics.Model.Event sessionStartEvent = new Amazon.MobileAnalytics.Model.Event();

            sessionStartEvent.EventType = "_session.start";
            //CultureInfo provider = CultureInfo.InvariantCulture;

            Amazon.MobileAnalytics.Model.Session session = new Amazon.MobileAnalytics.Model.Session();
            session.Id = sessionID;
            session.StartTimestamp = DateTime.UtcNow;
            sessionStartEvent.Session = session;

            Dictionary<string, string> attributes = new Dictionary<string, string>();
            sessionStartEvent.Attributes = attributes;

            Dictionary<string, double> metrics = new Dictionary<string, double>();
            sessionStartEvent.Metrics = metrics;

            sessionStartEvent.Version = "v2.0";
            sessionStartEvent.Timestamp = DateTime.UtcNow;

            return sessionStartEvent;
        }

        private Amazon.MobileAnalytics.Model.Event BuildSessionEndEvent(string sessionID)
        {
            Amazon.MobileAnalytics.Model.Event sessionEndEvent = new Amazon.MobileAnalytics.Model.Event();

            sessionEndEvent.EventType = "_session.stop";
            //CultureInfo provider = CultureInfo.InvariantCulture;

            Amazon.MobileAnalytics.Model.Session session = new Amazon.MobileAnalytics.Model.Session();
            session.Id = sessionID;
            session.StartTimestamp = DateTime.UtcNow;
            session.StopTimestamp = DateTime.UtcNow;
            session.Duration = 20 * 1000;
            sessionEndEvent.Session = session;

            Dictionary<string, string> attributes = new Dictionary<string, string>();
            sessionEndEvent.Attributes = attributes;

            Dictionary<string, double> metrics = new Dictionary<string, double>();
            sessionEndEvent.Metrics = metrics;

            sessionEndEvent.Version = "v2.0";
            sessionEndEvent.Timestamp = DateTime.UtcNow;

            return sessionEndEvent;
        }

        private MobileAnalyticsManager GetMobileAnalyticsManager(string appId)
        {
            return MobileAnalyticsManager.GetOrCreateInstance(CommonTests.Framework.TestRunner.Credentials, RegionEndpoint.USEast1, appId, null);
        }
    }





}

