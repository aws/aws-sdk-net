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
using Amazon.Runtime;
using Amazon.CognitoIdentity;
using Amazon.Util.Internal;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class SampleTests : TestBase<AmazonMobileAnalyticsClient>
    {
        [OneTimeSetUp]
        public void Init()
        {

        }

        [Test]
        public void TestConstructor()
        {
            string appID1 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID1, CommonTests.Framework.TestRunner.Credentials, RegionEndpoint.USEast1);
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID1));

            string appID2 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID2, CommonTests.Framework.TestRunner.Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID2));
            
            string notInstantiatedID = Guid.NewGuid().ToString();

            try
            {
                MobileAnalyticsManager.GetInstance(notInstantiatedID);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("get exception in constrctor :", e.ToString());
                Assert.IsTrue(e is InvalidOperationException);
            }
        }


        [Test]
        public void TestRecordEvent()
        {
            string appID = Guid.NewGuid().ToString();
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, CommonTests.Framework.TestRunner.Credentials, RegionEndpoint.USEast1);
            SQLiteEventStore eventStore = new SQLiteEventStore(new MobileAnalyticsManagerConfig());

            try
            {
                CustomEvent customEvent = new CustomEvent("TestRecordEvent");
                customEvent.AddAttribute("LevelName", "Level5");
                customEvent.AddAttribute("Successful", "True");
                customEvent.AddMetric("Score", 12345);
                customEvent.AddMetric("TimeInLevel", 64);
                manager.RecordEvent(customEvent);

                MonetizationEvent monetizationEvent = new MonetizationEvent();
                monetizationEvent.Quantity = 10.0;
                monetizationEvent.ItemPrice = 2.00;
                monetizationEvent.ProductId = "ProductId123";
                monetizationEvent.ItemPriceFormatted = "$2.00";
                monetizationEvent.Store = "Amazon";
                monetizationEvent.TransactionId = "TransactionId123";
                monetizationEvent.Currency = "USD";
                manager.RecordEvent(monetizationEvent);
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch exception: " + e.ToString());
                Assert.Fail();
            }

            // sleep a while to make sure event is stored
            Task.Delay(TimeSpan.FromSeconds(1)).Wait();

            // Event store should have one custom event, one monetization event and one session start event.
            Assert.AreEqual(3, eventStore.NumberOfEvents(appID));
        }


        [Test]
        public void TestSessionTimeout()
        {
            MobileAnalyticsManagerConfig maConfig = new MobileAnalyticsManagerConfig();
            Console.WriteLine("session delta is " + maConfig.SessionTimeout);

            string appID = Guid.NewGuid().ToString();

            // create AmazonMobileAnayticsManager instance
            MobileAnalyticsManager.GetOrCreateInstance(appID, CommonTests.Framework.TestRunner.Credentials, RegionEndpoint.USEast1, maConfig);
            Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session session = new Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session(appID, new MobileAnalyticsManagerConfig());
            session.Start();
            DateTime startTime1 = session.StartTime;
            string sessionId1 = session.SessionId;

            // sleep for a while but wake up before session expires
            session.Pause();
            Task.Delay(TimeSpan.FromSeconds(maConfig.SessionTimeout - 1)).Wait();
            session.Resume();

            // make sure session is not expired
            DateTime startTime2 = session.StartTime;
            string sessionId2 = session.SessionId;
            Assert.IsTrue(startTime1 == startTime2);
            Assert.IsTrue(sessionId1 == sessionId2);

            // sleep longer until session expires
            session.Pause();
            Task.Delay(TimeSpan.FromSeconds(maConfig.SessionTimeout + 1)).Wait();
            session.Resume();

            // make sure session is expired
            DateTime startTime3 = session.StartTime;
            string sessionId3 = session.SessionId;
            Assert.IsTrue(startTime3 > startTime2);
            Assert.IsTrue(sessionId2 != sessionId3);

            // sleep for a while but wake up before session expires
            session.Pause();
            Task.Delay(TimeSpan.FromSeconds(maConfig.SessionTimeout - 1)).Wait();
            session.Resume();

            // make sure session is not expired
            DateTime startTime4 = session.StartTime;
            string sessionId4 = session.SessionId;
            Assert.IsTrue(startTime4 == startTime3);
            Assert.IsTrue(sessionId4 == sessionId3);

            // sleep longer until session expires
            session.Pause();
            Task.Delay(TimeSpan.FromSeconds(maConfig.SessionTimeout + 1)).Wait();
            session.Resume();

            // make sure session is expired
            DateTime startTime5 = session.StartTime;
            string sessionId5 = session.SessionId;
            Assert.IsTrue(startTime5 > startTime4); 
            Assert.IsTrue(sessionId5 != sessionId4);
        }


        [Test]
        public void TestLowLevelAPI()
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

            PutEventsResponse PutResponse = Client.PutEventsAsync(putRequest).Result;
            Assert.AreEqual(HttpStatusCode.Accepted, PutResponse.HttpStatusCode);
        }

        [Test]
        public void TestLowLevelAPIErrorCaseEmptyEvent()
        {
            PutEventsRequest putRequest = new PutEventsRequest();
            string clientContext = BuildClientContext();
            Console.WriteLine("client context is {0}", clientContext);
            putRequest.ClientContext = Convert.ToBase64String(
                            System.Text.Encoding.UTF8.GetBytes(clientContext));
            putRequest.ClientContextEncoding = "base64";

            var exception = AssertExtensions.ExpectExceptionAsync<AmazonMobileAnalyticsException>(Client.PutEventsAsync(putRequest)).Result;
            Assert.AreEqual(exception.StatusCode, HttpStatusCode.BadRequest);
            Assert.AreEqual(exception.ErrorCode, "ValidationException");
        }

        [Test]
        public void TestLowLevelAPIErrorCaseWrongClientContext()
        {
            List<Amazon.MobileAnalytics.Model.Event> listEvent = new List<Amazon.MobileAnalytics.Model.Event>();
            listEvent.Add(BuildCustomEvent());

            PutEventsRequest putRequest = new PutEventsRequest();
            putRequest.Events = listEvent;
            string clientContext = BuildClientContext();
            Console.WriteLine("client context is {0}", clientContext);
            putRequest.ClientContext = Convert.ToBase64String(
                            System.Text.Encoding.UTF8.GetBytes(clientContext));
            putRequest.ClientContextEncoding = "base32";
            PutEventsResponse PutResponse = null;
            AmazonMobileAnalyticsException exception = null;
            
            try
            {
                PutResponse = Client.PutEventsAsync(putRequest).Result;
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                {
                    if (e is AmazonMobileAnalyticsException)
                    {
                        exception = e as AmazonMobileAnalyticsException;
                        break;
                    }
                }
            }
            Assert.IsNotNull(exception);
            Assert.AreEqual(exception.StatusCode, HttpStatusCode.BadRequest);
            Assert.AreEqual(exception.ErrorCode, "BadRequestException");
        }

        [Test]
        public void TestLowLevelAPIErrorCaseWrongCognitoCred()
        {
            List<Amazon.MobileAnalytics.Model.Event> listEvent = new List<Amazon.MobileAnalytics.Model.Event>();
            listEvent.Add(BuildCustomEvent());

            PutEventsRequest putRequest = new PutEventsRequest();
            putRequest.Events = listEvent;
            string clientContext = BuildClientContext();
            Console.WriteLine("client context is {0}", clientContext);
            putRequest.ClientContext = Convert.ToBase64String(
                            System.Text.Encoding.UTF8.GetBytes(clientContext));
            putRequest.ClientContextEncoding = "base64";
            PutEventsResponse PutResponse = null;

            AmazonServiceException exception = null;
            AmazonMobileAnalyticsClient client = new AmazonMobileAnalyticsClient(new CognitoAWSCredentials("wrong-cognito-pool-id", RegionEndpoint.USEast1), RegionEndpoint.USEast1);
            try
            {
                PutResponse = client.PutEventsAsync(putRequest).Result;
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                {
                    if (e is AmazonServiceException)
                    {
                        exception = e as AmazonServiceException;
                        break;
                    }
                }
            }
            Assert.IsNotNull(exception);
            Assert.AreEqual(exception.StatusCode, HttpStatusCode.BadRequest);
            Assert.AreEqual(exception.ErrorCode, "ValidationException");
        }

        [Test]
        public void TestSessionEvent()
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

            PutEventsResponse PutResponse = Client.PutEventsAsync(putRequest).Result;
            Assert.AreEqual(HttpStatusCode.Accepted, PutResponse.HttpStatusCode);
        }

        [Test]
        public void TestEventStore()
        {
            // Create table
            SQLiteEventStore eventStore = new SQLiteEventStore(new MobileAnalyticsManagerConfig());

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

        [Test]
        public void TestErrorEventHandler()
        {
            string appID = Guid.NewGuid().ToString();
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, new CognitoAWSCredentials("wrong-cognito-pool-id", RegionEndpoint.USEast1), RegionEndpoint.USEast1);
            manager.MobileAnalyticsErrorEvent += errorHandler;

            Task.Delay(TimeSpan.FromSeconds(75)).Wait();
            lock (_lock)
            {
                Assert.IsTrue(resultList.Count > 0);
                foreach (bool result in resultList)
                {
                    Assert.IsTrue(result);
                }
            }
        }
        private object _lock = new object();
        private List<bool> resultList = new List<bool>();

        private void errorHandler(object sender, MobileAnalyticsErrorEventArgs args)
        {
            Console.WriteLine(args);
            bool catchExpectedError = false;
            lock (_lock)
            {
                if (args.ClassName != null && args.ErrorMessage != null && args.Exception is AmazonServiceException && args.UndeliveredEvents != null)
                {
                    if (args.UndeliveredEvents.Count == 0)
                    {
                        catchExpectedError = true;
                    }
                    else
                    {
                        catchExpectedError = false;
                        Console.WriteLine("The caught low level client events are : ");
                        foreach (Amazon.MobileAnalytics.Model.Event eventObject in args.UndeliveredEvents)
                        {
                            Console.WriteLine("Event type is {0}; Event session ID is {1}.", eventObject.EventType, eventObject.Session.Id);
                        }
                    }
                }
                else
                    catchExpectedError = false;
                resultList.Add(catchExpectedError);
            }
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
            session.Duration = (long)TimeSpan.FromMinutes(30).TotalMilliseconds;
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
            session.Duration = (long)TimeSpan.FromSeconds(20).TotalMilliseconds;
            sessionEndEvent.Session = session;

            Dictionary<string, string> attributes = new Dictionary<string, string>();
            sessionEndEvent.Attributes = attributes;

            Dictionary<string, double> metrics = new Dictionary<string, double>();
            sessionEndEvent.Metrics = metrics;

            sessionEndEvent.Version = "v2.0";
            sessionEndEvent.Timestamp = DateTime.UtcNow;

            return sessionEndEvent;
        }

        protected override RegionEndpoint AlternateEndpoint
        {
            get
            {
                return RegionEndpoint.USEast1;
            }
        }

    }
}

