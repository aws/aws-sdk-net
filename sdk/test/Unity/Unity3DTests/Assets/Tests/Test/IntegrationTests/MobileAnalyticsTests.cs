using Amazon.Runtime;
using Amazon.MobileAnalytics;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.MobileAnalytics.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;
using Amazon;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using System.Net;
using System.Collections;
using ThirdParty.Json.LitJson;
using Amazon.CognitoIdentity;
using AWSSDK.Tests.Framework;
using Amazon.Util.Internal;

namespace AWSSDK.IntegrationTests.MobileAnalytics
{
    [TestFixture(TestOf = typeof(MobileAnalyticsTests))]
    [Category("Integration")]
    class MobileAnalyticsTests : TestBase<AmazonMobileAnalyticsClient>
    {
        private const String dbFileName = "mobile_analytic_event.db";

        [OneTimeSetUp]
        public void Setup()
        {
            File.Delete(Path.Combine(AmazonHookedPlatformInfo.Instance.PersistentDataPath, dbFileName));
        }

        [OneTimeTearDown]
        public void OneTimeCleanUp()
        {
            File.Delete(Path.Combine(AmazonHookedPlatformInfo.Instance.PersistentDataPath, dbFileName));
        }

        [TearDown]
        public void Cleanup()
        {
            BackgroundRunner.AbortBackgroundThread();
        }

        // This test passes but is related to bug issues/mobilesdk-1249
        [Test]
        [Category("WWW")]
        public void TestConstructor()
        {
            string appID1 = Guid.NewGuid().ToString();

            MobileAnalyticsManager.GetOrCreateInstance(appID1, TestRunner.Credentials, RegionEndpoint.USEast1);
            MobileAnalyticsManager mam = MobileAnalyticsManager.GetInstance(appID1);
            Assert.IsNotNull(mam);

            string appID2 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID2, TestRunner.Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID2));

            string notInstantiatedID = Guid.NewGuid().ToString();

            try
            {
                MobileAnalyticsManager.GetInstance(notInstantiatedID);
                Assert.Fail();
            }
            catch (InvalidOperationException e)
            {
                Utils.AssertTrue(e is InvalidOperationException);
            }
        }



        [Test]
        [Category("WWW")]
        public void TestRecordEvent()
        {
            // Need to make sure that background runner does not attempt to deliver events during
            // test (and consequently delete them from local storage). Restart Background runner
            // and sleep until after it checks for events to send.
            BackgroundRunner.AbortBackgroundThread();
            System.Reflection.FieldInfo fieldInfo = typeof(MobileAnalyticsManager).GetField("_backgroundRunner", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            BackgroundRunner backgroundRunner = fieldInfo.GetValue(null) as BackgroundRunner;
            backgroundRunner.StartWork();
            Thread.Sleep(1000);

            string appID = Guid.NewGuid().ToString();
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, TestRunner.Credentials, RegionEndpoint.USEast1);
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
            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Event store should have one custom event, one monetization event and one session start event.
            Assert.AreEqual(3, eventStore.NumberOfEvents(appID));


            eventStore.Dispose();
        }


        // This test passes but is related to bug issues/mobilesdk-1249
        [Test]
        [Category("WWW")]
        public void TestSessionTimeout()
        {
            MobileAnalyticsManagerConfig maConfig = new MobileAnalyticsManagerConfig();
            Console.WriteLine("session delta is " + maConfig.SessionTimeout);

            string appID = Guid.NewGuid().ToString();

            // create AmazonMobileAnayticsManager instance
            MobileAnalyticsManager.GetOrCreateInstance(appID, TestRunner.Credentials, RegionEndpoint.USEast1, maConfig);
            Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session session = new Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session(appID, new MobileAnalyticsManagerConfig());
            session.Start();
            DateTime startTime1 = session.StartTime;
            string sessionId1 = session.SessionId;

            // sleep for a while but wake up before session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds(maConfig.SessionTimeout - 1));
            session.Resume();

            // make sure session is not expired
            DateTime startTime2 = session.StartTime;
            string sessionId2 = session.SessionId;
            Utils.AssertTrue(startTime1 == startTime2);
            Utils.AssertTrue(sessionId1 == sessionId2);

            // sleep longer until session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds(maConfig.SessionTimeout + 1));
            session.Resume();

            // make sure session is expired
            DateTime startTime3 = session.StartTime;
            string sessionId3 = session.SessionId;
            Utils.AssertTrue(startTime3 > startTime2);
            Utils.AssertTrue(sessionId2 != sessionId3);

            // sleep for a while but wake up before session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds(maConfig.SessionTimeout - 1));
            session.Resume();

            // make sure session is not expired
            DateTime startTime4 = session.StartTime;
            string sessionId4 = session.SessionId;
            Utils.AssertTrue(startTime4 == startTime3);
            Utils.AssertTrue(sessionId4 == sessionId3);

            // sleep longer until session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds(maConfig.SessionTimeout + 1));
            session.Resume();

            // make sure session is expired
            DateTime startTime5 = session.StartTime;
            string sessionId5 = session.SessionId;
            Utils.AssertTrue(startTime5 > startTime4);
            Utils.AssertTrue(sessionId5 != sessionId4);
        }


        [Test]
        [Category("WWW")]
        public void TestLowLevelAPI()
        {
            List<Amazon.MobileAnalytics.Model.Event> listEvent = new List<Amazon.MobileAnalytics.Model.Event>();
            listEvent.Add(BuildCustomEvent());


            string clientContext = BuildClientContext();

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            HttpStatusCode httpStatusCode = HttpStatusCode.Forbidden;
            Client.PutEventsAsync(new PutEventsRequest()
            {
                ClientContext = Convert.ToBase64String(
                    System.Text.Encoding.UTF8.GetBytes(clientContext)),
                ClientContextEncoding = "base64",
                Events = listEvent
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    httpStatusCode = response.Response.HttpStatusCode;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(HttpStatusCode.Accepted, httpStatusCode);
        }

        [Test]
        [Category("WWW")]
        public void TestLowLevelAPIErrorCaseEmptyEvent()
        {
            PutEventsRequest putRequest = new PutEventsRequest()
            {
                ClientContext = Convert.ToBase64String(
                                System.Text.Encoding.UTF8.GetBytes(BuildClientContext())),
                ClientContextEncoding = "base64"
            };

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.PutEventsAsync(new PutEventsRequest()
            {
                ClientContext = Convert.ToBase64String(
                                System.Text.Encoding.UTF8.GetBytes(BuildClientContext())),
                ClientContextEncoding = "base64"
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            var amae = responseException as AmazonMobileAnalyticsException;
            // Ignoring this assertion as there seems to be some differences in the iOS
            // WWW implementation that gives us a status code 0.
            //Assert.AreEqual(HttpStatusCode.BadRequest, amae.StatusCode);
            Assert.AreEqual("ValidationException", amae.ErrorCode);
        }

        [Test]
        [Category("WWW")]
        public void TestLowLevelAPIErrorCaseWrongClientContext()
        {

            List<Amazon.MobileAnalytics.Model.Event> listEvent = new List<Amazon.MobileAnalytics.Model.Event>();
            listEvent.Add(BuildCustomEvent());

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.PutEventsAsync(new PutEventsRequest()
            {
                Events = listEvent,
                ClientContext = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(BuildClientContext())),
                ClientContextEncoding = "base632"
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            AmazonMobileAnalyticsException amae = null;

            while (responseException != null)
            {
                if (responseException is AmazonMobileAnalyticsException)
                {
                    amae = responseException as AmazonMobileAnalyticsException;
                    break;
                }
                else
                {
                    responseException = responseException.InnerException;
                }
            }

            Assert.IsNotNull(amae);
            // Ignoring this assertion as there seems to be some differences in the iOS
            // WWW implementation that gives us a status code 0.
            //Assert.AreEqual(HttpStatusCode.BadRequest, amae.StatusCode);
            Assert.AreEqual(amae.ErrorCode, "BadRequestException");
        }


        [Test]
        [Category("WWW")]
        public void TestLowLevelAPIErrorCaseWrongCognitoCred()
        {
            List<Amazon.MobileAnalytics.Model.Event> listEvent = new List<Amazon.MobileAnalytics.Model.Event>();
            listEvent.Add(BuildCustomEvent());

            AmazonMobileAnalyticsClient client = new AmazonMobileAnalyticsClient(new CognitoAWSCredentials("wrong-cognito-pool-id", RegionEndpoint.USEast1), RegionEndpoint.USEast1);

            AmazonServiceException ase = null;
            try
            {
                AutoResetEvent ars = new AutoResetEvent(false);
                client.PutEventsAsync(new PutEventsRequest()
                {
                    Events = listEvent,
                    ClientContext = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(BuildClientContext())),
                    ClientContextEncoding = "base64"
                }, (response) =>
                {
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();

            }
            // TODO: is it the correct behavior that the exception is thrown from the PutEventsAsync call 
            // rather than passed as response.Exception?
            catch (Exception exception)
            {
                if (exception is AmazonServiceException)
                {
                    ase = exception as AmazonServiceException;
                }
            }

            Assert.IsNotNull(ase);
            // Ignoring this assertion as there seems to be some differences in the iOS
            // WWW implementation that gives us a status code 0.
            //Assert.AreEqual(HttpStatusCode.BadRequest, ase.StatusCode);
            Assert.AreEqual(ase.ErrorCode, "ValidationException");
        }

        [Test]
        [Category("WWW")]
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
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            HttpStatusCode httpStatusCode = HttpStatusCode.Forbidden;
            Client.PutEventsAsync(new PutEventsRequest()
            {
                ClientContext = Convert.ToBase64String(
                    System.Text.Encoding.UTF8.GetBytes(clientContext)),
                ClientContextEncoding = "base64",
                Events = listEvent
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    httpStatusCode = response.Response.HttpStatusCode;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(HttpStatusCode.Accepted, httpStatusCode);
        }


        [Test]
        [Category("WWW")]
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
            Utils.AssertTrue(dbFileSizeBigger > dbFileSizeSmall);

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

            eventStore.Dispose();
        }

        private object _lock = new object();
        private List<bool> resultList = new List<bool>();

        //[Test]
        // [Category("WWW")]
        public void TestErrorEventHandler()
        {
            string appID = Guid.NewGuid().ToString();
            bool gotException = false;
            int timeout = 2;
            var ars = new AutoResetEvent(false);
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID,
                new CognitoAWSCredentials("wrong-cognito-pool-id", RegionEndpoint.USEast1),
                RegionEndpoint.USEast1);

            manager.MobileAnalyticsErrorEvent += (object sender, MobileAnalyticsErrorEventArgs args) =>
            {
                gotException = true;
                ars.Set();
            };


            while (!gotException && timeout > 0)
            {
                ars.WaitOne(TimeSpan.FromSeconds(75));
                timeout--;
            }

            Utils.AssertTrue(gotException);
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
    }
}

