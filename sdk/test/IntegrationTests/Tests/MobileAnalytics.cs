#if MobileAnalyticsTest
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.MobileAnalytics;
using Amazon.MobileAnalytics.Model;
using AWSSDK_DotNet.IntegrationTests.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;
using System.Collections;
using ThirdParty.Json.LitJson;
using Amazon.Util;
using System.Globalization;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon;
using Amazon.Runtime;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using System.Threading;
using Amazon.CognitoIdentity;
using Amazon.Util.Internal;
using System.Reflection;
using Amazon.Runtime.Internal;
using Amazon.S3;
using Amazon.S3.Model;
using System.IO.Compression;
using AWSSDK_DotNet.IntegrationTests.Utils;

#if BCL45
using System.Threading.Tasks;
#endif

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class MobileAnalytics : TestBase<AmazonMobileAnalyticsClient>
    {
        [ClassCleanup]
        public static void ClassCleanup()
        {
            BaseClean();
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            // This attribute must be set in BCL platform
            AWSConfigs.ApplicationName = "MobileAnalyticsIntegrationTestApp";

            // clean the session and db files left in last execution
            string appDataPath = InternalSDKUtils.DetermineAppLocalStoragePath("");
            if (Directory.Exists(appDataPath))
            {
                try
                {
                    Directory.Delete(appDataPath, true);
                }
                catch (IOException)
                {
                    Directory.Delete(appDataPath, true);
                }
                catch (UnauthorizedAccessException)
                {
                    Directory.Delete(appDataPath, true);
                }
            }
        }


        [TestInitialize()]
        public void Initialize()
        {
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }


        #region Public API Test
        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestConstructor()
        {
            string appID1 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID1, Credentials, RegionEndpoint.USEast1);
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID1));

            string appID2 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID2, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID2));

            string notInstantiatedID = Guid.NewGuid().ToString();
            AssertExtensions.ExpectException(() => { MobileAnalyticsManager.GetInstance(notInstantiatedID); }, typeof(InvalidOperationException));

#if BCL
            string appID3 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID3);
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID3));

            string appID4 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID4, Credentials);
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID4));

            string appID5 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID5, RegionEndpoint.USEast1);
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID5));

            string appID6 = Guid.NewGuid().ToString();
            MobileAnalyticsManager.GetOrCreateInstance(appID6, new MobileAnalyticsManagerConfig());
            Assert.IsNotNull(MobileAnalyticsManager.GetInstance(appID6));
#endif
        }

        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestRecordEvent()
        {
            string appID = Guid.NewGuid().ToString();
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, Credentials, RegionEndpoint.USEast1);
            SQLiteEventStore eventStore = new SQLiteEventStore(new MobileAnalyticsManagerConfig());

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

            // sleep a while to make sure event is stored
            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Event store should have one custom event, one monetization event and one session start event.
            Assert.AreEqual(eventStore.NumberOfEvents(appID), 3);
        }


        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestSessionTimeout()
        {
            MobileAnalyticsManagerConfig maConfig = new MobileAnalyticsManagerConfig();
            Console.WriteLine("session delta is " + maConfig.SessionTimeout);

            string appID = Guid.NewGuid().ToString();

            // create AmazonMobileAnayticsManager instance
            MobileAnalyticsManager.GetOrCreateInstance(appID, Credentials, RegionEndpoint.USEast1, maConfig);
            Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session session = new Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session(appID, new MobileAnalyticsManagerConfig());
            session.Start();
            DateTime startTime1 = session.StartTime;
            string sessionId1 = session.SessionId;

            // sleep for a while but wake up before session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds((maConfig.SessionTimeout - 1)));
            session.Resume();

            // make sure session is not expired
            DateTime startTime2 = session.StartTime;
            string sessionId2 = session.SessionId;
            Assert.IsTrue(startTime1 == startTime2);
            Assert.IsTrue(sessionId1 == sessionId2);

            // sleep longer until session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds((maConfig.SessionTimeout + 1)));
            session.Resume();

            // make sure session is expired
            DateTime startTime3 = session.StartTime;
            string sessionId3 = session.SessionId;
            Assert.IsTrue(startTime3 > startTime2);
            Assert.IsTrue(sessionId2 != sessionId3);

            // sleep for a while but wake up before session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds((maConfig.SessionTimeout - 1)));
            session.Resume();

            // make sure session is not expired
            DateTime startTime4 = session.StartTime;
            string sessionId4 = session.SessionId;
            Assert.IsTrue(startTime4 == startTime3);
            Assert.IsTrue(sessionId4 == sessionId3);

            // sleep longer until session expires
            session.Pause();
            Thread.Sleep(TimeSpan.FromSeconds((maConfig.SessionTimeout + 1))); 
            session.Resume();

            // make sure session is expired
            DateTime startTime5 = session.StartTime;
            string sessionId5 = session.SessionId;
            Assert.IsTrue(startTime5 > startTime4);
            Assert.IsTrue(sessionId5 != sessionId4);
        }


        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestManagerAddClientContextCustomAttribute()
        {
            string KEY1 = Guid.NewGuid().ToString();
            string KEY2 = Guid.NewGuid().ToString();
            string VALUE1 = Guid.NewGuid().ToString();
            string VALUE2 = Guid.NewGuid().ToString();
            string appID = Guid.NewGuid().ToString();

            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());

            manager.AddCustomAttributeToClientContext(KEY1, VALUE1);
            manager.AddCustomAttributeToClientContext(KEY2, VALUE2);

            var type = manager.GetType();
            var property = type.GetProperty("ClientContext", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var clientContext = property.GetValue(manager, null) as ClientContext;
            string clientContextString = clientContext.ToJsonString();

            Assert.IsTrue(clientContextString.IndexOf("custom") > 0);
            Assert.IsTrue(clientContextString.IndexOf(KEY1) > 0);
            Assert.IsTrue(clientContextString.IndexOf(KEY2) > 0);
            Assert.IsTrue(clientContextString.IndexOf(VALUE1) > 0);
            Assert.IsTrue(clientContextString.IndexOf(VALUE2) > 0);

            Assert.IsTrue(clientContextString.IndexOf("custom") < clientContextString.IndexOf(KEY1));
            Assert.IsTrue(clientContextString.IndexOf("custom") < clientContextString.IndexOf(KEY2));
            Assert.IsTrue(clientContextString.IndexOf(KEY1) < clientContextString.IndexOf(VALUE1));
            Assert.IsTrue(clientContextString.IndexOf(KEY2) < clientContextString.IndexOf(VALUE2));
        }


        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestManagerMultipleInstance()
        {
            string appID1 = Guid.NewGuid().ToString();
            string appID2 = Guid.NewGuid().ToString();
            string appID3 = Guid.NewGuid().ToString();

            MobileAnalyticsManager manager1 = MobileAnalyticsManager.GetOrCreateInstance(appID1, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            MobileAnalyticsManager manager2 = MobileAnalyticsManager.GetOrCreateInstance(appID2, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            MobileAnalyticsManager manager3 = MobileAnalyticsManager.GetOrCreateInstance(appID3, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());

            var type1 = manager1.GetType();
            var property1 = type1.GetProperty("ClientContext", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var clientContext1 = property1.GetValue(manager1, null) as ClientContext;
            string clientContextString1 = clientContext1.ToJsonString();

            var type2 = manager2.GetType();
            var property2 = type2.GetProperty("ClientContext", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var clientContext2 = property2.GetValue(manager2, null) as ClientContext;
            string clientContextString2 = clientContext2.ToJsonString();

            var type3 = manager3.GetType();
            var property3 = type3.GetProperty("ClientContext", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var clientContext3 = property3.GetValue(manager3, null) as ClientContext;
            string clientContextString3 = clientContext3.ToJsonString();

            Assert.IsTrue(clientContextString1.IndexOf(appID1) > 0);
            Assert.IsTrue(clientContextString2.IndexOf(appID2) > 0);
            Assert.IsTrue(clientContextString3.IndexOf(appID3) > 0);
        }
        #endregion


        #region Low Level API Test
        [TestMethod]
        [TestCategory("MobileAnalytics")]
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

            PutEventsResponse PutResponse = Client.PutEvents(putRequest);
            Assert.AreEqual(HttpStatusCode.Accepted, PutResponse.HttpStatusCode);
        }


        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestLowLevelAPIErrorCaseEmptyEvent()
        {
            PutEventsRequest putRequest = new PutEventsRequest();
            string clientContext = BuildClientContext();
            Console.WriteLine("client context is {0}", clientContext);
            putRequest.ClientContext = Convert.ToBase64String(
                            System.Text.Encoding.UTF8.GetBytes(clientContext));
            putRequest.ClientContextEncoding = "base64";
 
            var exception = AssertExtensions.ExpectException(()=>Client.PutEvents(putRequest), typeof(AmazonMobileAnalyticsException));
            Assert.IsTrue(exception is AmazonMobileAnalyticsException);
            Assert.AreEqual((exception as AmazonMobileAnalyticsException).StatusCode, HttpStatusCode.BadRequest);
            Assert.AreEqual((exception as AmazonMobileAnalyticsException).ErrorCode, "ValidationException");

        }

        [TestMethod]
        [TestCategory("MobileAnalytics")]
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
            bool hasCatchException = false;
            AmazonMobileAnalyticsClient client = new AmazonMobileAnalyticsClient(new CognitoAWSCredentials("wrong-cognito-pool-id", RegionEndpoint.USEast1), RegionEndpoint.USEast1);
            try
            {
                PutResponse = client.PutEvents(putRequest);
            }
            catch (AmazonMobileAnalyticsException e)
            {
                Console.WriteLine("Get AmazonMobileAnalyticsException: error code : {0} ; error type : {1} ; request id : {2} ; status code : {3} ; error message is {4}", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                Assert.Fail();
            }
            catch (AmazonServiceException e)
            {
                Console.WriteLine("Get AmazonServiceException: error code : {0} ; error type : {1} ; request id : {2} ; status code : {3} ; error message is {4}", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                Assert.AreEqual(e.StatusCode, HttpStatusCode.BadRequest);
                Assert.AreEqual(true, e.ErrorCode.Equals("ValidationException", StringComparison.InvariantCultureIgnoreCase));
                hasCatchException = true;
            }
            Assert.IsTrue(hasCatchException);
        }

        [TestMethod]
        [TestCategory("MobileAnalytics")]
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
            bool hasCatchException = false;
            AmazonMobileAnalyticsClient client = new AmazonMobileAnalyticsClient(new CognitoAWSCredentials("wrong-cognito-pool-id", RegionEndpoint.USEast1), RegionEndpoint.USEast1);
            try
            {
                PutResponse = client.PutEvents(putRequest);
            }
            catch (AmazonMobileAnalyticsException e)
            {
                Console.WriteLine("Get AmazonMobileAnalyticsException: error code : {0} ; error type : {1} ; request id : {2} ; status code : {3} ; error message is {4}", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                Assert.Fail();
            }
            catch (AmazonServiceException e)
            {
                Console.WriteLine("Get AmazonServiceException: error code : {0} ; error type : {1} ; request id : {2} ; status code : {3} ; error message is {4}", e.ErrorCode, e.ErrorType, e.RequestId, e.StatusCode, e.Message);
                Assert.AreEqual(e.StatusCode, HttpStatusCode.BadRequest);
                Assert.AreEqual(true, e.ErrorCode.Equals("ValidationException", StringComparison.InvariantCultureIgnoreCase));
                hasCatchException = true;
            }
            Assert.IsTrue(hasCatchException);
        }
        #endregion


        # region Session, Event and Client Context Test
        [TestMethod]
        [TestCategory("MobileAnalytics")]
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

            PutEventsResponse PutResponse = Client.PutEvents(putRequest);
            Assert.AreEqual(HttpStatusCode.Accepted, PutResponse.HttpStatusCode);
        }

        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestCustomEventConcurrency()
        {
            // event type
            string EVENT_TYPE = Guid.NewGuid().ToString();

            // attribute config
            const string ATTR1 = "ATTR1";
            string ATTR1_VAL_T0 = Guid.NewGuid().ToString();
            string ATTR1_VAL_T1 = Guid.NewGuid().ToString();
            string ATTR1_VAL_T2 = Guid.NewGuid().ToString();

            string ATTR2 = "ATTR2";
            string ATTR2_VAL_T0 = Guid.NewGuid().ToString();
            string ATTR2_VAL_T1 = Guid.NewGuid().ToString();
            string ATTR2_VAL_T2 = Guid.NewGuid().ToString();

            string ATTR3 = "ATTR3";
            string ATTR3_VAL_T0 = Guid.NewGuid().ToString();
            string ATTR3_VAL_T1 = Guid.NewGuid().ToString();
            string ATTR3_VAL_T2 = Guid.NewGuid().ToString();

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

#if BCL35
            Thread t0 = new Thread(
            () =>
            {
#elif BCL45
            Task task0 = new Task(() =>
            {
#endif
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




#if BCL35
            Thread t1 = new Thread(
            () =>
            {
#elif BCL45
            Task task1 = new Task(() =>
            {
#endif

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


#if BCL35
            Thread t2 = new Thread(
            () =>
            {
#elif BCL45
            Task task2 = new Task(() =>
            {
#endif
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


#if BCL35
            t0.Start();
            t1.Start();
            t2.Start();

            t0.Join();
            t1.Join();
            t2.Join();
#elif BCL45
            task0.Start();
            task1.Start();
            task2.Start();

            // wait all task complete 
            Task.WaitAll(new[] { task0, task1, task2 });
#endif
            // Create Mobile Analytics Manager instance and session
            string appID = Guid.NewGuid().ToString();
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session session = new Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session(appID, new MobileAnalyticsManagerConfig());

            // Get model event
            var type = customEvent.GetType();
            var method = type.GetMethod("ConvertToMobileAnalyticsModelEvent", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            object[] parametersArray = new object[] { session };
            Amazon.MobileAnalytics.Model.Event modelEvent = method.Invoke(customEvent, parametersArray) as Amazon.MobileAnalytics.Model.Event;

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

        [TestMethod]
        [TestCategory("MobileAnalytics")]
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

            const int LOOP_COUNT = 999;

#if BCL35
            Thread t0 = new Thread(
            () =>
            {
#elif BCL45
            Task task0 = new Task(() =>
            {
#endif
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


#if BCL35
            Thread t1 = new Thread(
            () =>
            {
#elif BCL45
            Task task1 = new Task(() =>
            {
#endif
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

#if BCL35
            Thread t2 = new Thread(
            () =>
            {
#elif BCL45
            Task task2 = new Task(() =>
            {
#endif
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


#if BCL35
            t0.Start();
            t1.Start();
            t2.Start();

            t0.Join();
            t1.Join();
            t2.Join();
#elif BCL45
            task0.Start();
            task1.Start();
            task2.Start();

            // wait all task complete 
            Task.WaitAll(new[] { task0, task1, task2 });
#endif

            // Create Mobile Analytics Manager instance and session
            string appID = Guid.NewGuid().ToString();
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session session = new Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session(appID, new MobileAnalyticsManagerConfig());

            // Get model event
            var type = monetizationEvent.GetType();
            var method = type.GetMethod("ConvertToMobileAnalyticsModelEvent", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            object[] parametersArray = new object[] { session };
            Amazon.MobileAnalytics.Model.Event modelEvent = method.Invoke(monetizationEvent, parametersArray) as Amazon.MobileAnalytics.Model.Event;

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
        #endregion

        #region Event Storage Test
        [TestMethod]
        [TestCategory("MobileAnalytics")]
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
        #endregion

        #region Error Handler Test
        [TestMethod]
        [TestCategory("MobileAnalytics")]
        public void TestErrorEventHandler()
        {
            string appID = Guid.NewGuid().ToString();
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, new CognitoAWSCredentials("wrong-cognito-pool-id", RegionEndpoint.USEast1), RegionEndpoint.USEast1);
            manager.MobileAnalyticsErrorEvent += errorHandler;

            Thread.Sleep(TimeSpan.FromSeconds(75));
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
                            System.Console.WriteLine("Event type is {0}; Event session ID is {1}.", eventObject.EventType, eventObject.Session.Id);
                        }
                    }
                }
                else
                    catchExpectedError = false;

                resultList.Add(catchExpectedError);
            }
        }
        #endregion

#if BCL45
        #region End to end test
        //[TestMethod]
        //[TestCategory("MobileAnalytics")]
        /// <summary>
        /// This test case polls events from s3 bucket and verify event content.
        /// To run this test case, enable auto export events to s3 bucket in AWS console.
        /// Then fill AppID and S3 bucket in below testing code.
        /// This test case may wait up to 1 hour to wait all events to arrive at s3 bucket.
        /// </summary>
        public void TestEventContentFromS3Bucket()
        {
            // Fill your App ID and S3 bucket 
            string appID = "YourAppID";
            string s3Bucket = "YourS3Bucket";

            string s3keyPrefix = string.Format("awsma/events/{0}", appID);
            List<S3Object> originalObjList = new List<S3Object>();
            List<S3Object> newObjList = new List<S3Object>();

            // Get original s3 object list
            originalObjList = GetS3ObjectList(s3Bucket, s3keyPrefix);
            Assert.IsTrue(originalObjList != null);
            // send AMA events
            MobileAnalyticsManager manager = MobileAnalyticsManager.GetOrCreateInstance(appID, Credentials, RegionEndpoint.USEast1, new MobileAnalyticsManagerConfig());
            int COUNT = 1000;
            string eventType = string.Format("TestEndToEnd-{0}-{1}", DateTime.UtcNow.ToLocalTime().ToString(), COUNT.ToString());

            for (int i = 0; i < COUNT; i++)
            {
                CustomEvent customEvent = new CustomEvent(eventType);
                customEvent.AddAttribute(MobileAnalyticsEventAttributeID, i.ToString());
                customEvent.AddAttribute("LevelName", "Level5");
                customEvent.AddAttribute("Successful", "True");
                customEvent.AddMetric("Score", 12345);
                customEvent.AddMetric("TimeInLevel", 64);
                manager.RecordEvent(customEvent);
            }

            // wait until all events arrive at s3 bucket
            Thread.Sleep(TimeSpan.FromMinutes(35));

            // Get new s3 object list
            newObjList = GetS3ObjectList(s3Bucket, s3keyPrefix);
            Assert.IsTrue(newObjList != null);

            // get the delta of two lists
            newObjList = newObjList.Where(n => n.Key.EndsWith(".gz") && !originalObjList.Any(o => string.Equals(o.Key, n.Key))).ToList();
            VerifyMobileAnalyticsEvents(s3Bucket, newObjList, eventType, COUNT);
        }

        private string MobileAnalyticsEventAttributeID = "MobileAnalyticsIntegrationTest-Event-ID";
        private void VerifyMobileAnalyticsEvents(string s3Bucket, List<S3Object> s3ObjectList, string eventType, int eventCount)
        {
            // Make local dir
            string testDataDir = InternalSDKUtils.DetermineAppLocalStoragePath("MobileAnalyticsTestDataDir");
            if (Directory.Exists(testDataDir))
            {
                Directory.Delete(testDataDir, true);
            }
            Directory.CreateDirectory(testDataDir);

            // download all .gz file
            using (AmazonS3Client client = new AmazonS3Client())
            {
                foreach (S3Object entry in s3ObjectList)
                {
                    GetObjectRequest request = new GetObjectRequest
                    {
                        BucketName = s3Bucket,
                        Key = entry.Key
                    };

                    using (GetObjectResponse response = client.GetObject(request))
                    {
                        string dest = Path.Combine(testDataDir, entry.Key);
                        if (!File.Exists(dest))
                        {
                            response.WriteResponseStreamToFile(dest);
                        }
                    }
                }
            }


            // unzip gz file and combine it into one unzipped file
            string rawEventSCombinedFile = Path.Combine(testDataDir, "rawEventSCombinedFile");
            if (File.Exists(rawEventSCombinedFile))
            {
                File.Delete(rawEventSCombinedFile);
            }

            using (FileStream decompressedFileStream = File.Open(rawEventSCombinedFile, FileMode.Append, FileAccess.Write))
            {
                foreach (S3Object entry in s3ObjectList)
                {
                    using (FileStream originalFileStream = new FileStream(Path.Combine(testDataDir, entry.Key), FileMode.Open))
                    {

                        using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                            Console.WriteLine("Decompressed: {0}", Path.Combine(testDataDir, entry.Key));
                        }
                    }
                }
            }

            // read combined decompressed file and verify event type and ID
            string line = null;
            Dictionary<int, bool> foundDict = new Dictionary<int, bool>();
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(testDataDir, rawEventSCombinedFile)))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine("Parsing the event :" + line);
                    // find the event type
                    if (line.Contains(eventType))
                    {
                        var jsonData = ThirdParty.Json.LitJson.JsonMapper.ToObject(line);

                        string ID = (string)jsonData["attributes"][MobileAnalyticsEventAttributeID];
                        int numValue = -1;
                        bool parsed = Int32.TryParse(ID, out numValue);
                        Assert.IsTrue(parsed, "Cannot parse attribute {0} value {1}.", MobileAnalyticsEventAttributeID, ID);
                        Assert.IsTrue(numValue >= 0 && numValue <= eventCount, "Error: attribute {0} value {1} is out of range.", MobileAnalyticsEventAttributeID, numValue);
                        foundDict[numValue] = true;
                    }
                }
            }

            for (int i = 0; i < eventCount; i++)
            {
                Assert.IsTrue(foundDict.ContainsKey(i));
            }
        }

        private List<S3Object> GetS3ObjectList(string s3Bucket, string s3KeyPrefix)
        {
            var s3Client = new AmazonS3Client();
            List<S3Object> objList = new List<S3Object>();
            try
            {
                ListObjectsRequest request = new ListObjectsRequest
                {
                    BucketName = s3Bucket,
                    Prefix = s3KeyPrefix
                };

                do
                {
                    ListObjectsResponse response = s3Client.ListObjects(request);

                    // Process response.
                    foreach (S3Object entry in response.S3Objects)
                    {
                        Console.WriteLine("key = {0} size = {1}", entry.Key, entry.Size);
                        Console.WriteLine("Add this s3 key into original s3 object list.");
                        objList.Add(entry);
                    }

                    // If response is truncated, set the marker to get the next 
                    // set of keys.
                    if (response.IsTruncated)
                    {
                        request.Marker = response.NextMarker;
                    }
                    else
                    {
                        request = null;
                    }
                } while (request != null);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                Console.WriteLine("An AmazonS3Exception occurred when listing s3 bucket. error code is {0}, message is {1}.", amazonS3Exception.ErrorCode, amazonS3Exception.Message);
                objList = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("An exception occurred when listing s3 bucket {0}. Exception is : {1}.", s3Bucket, e.ToString()));
                objList = null;
            }
            return objList;
        }
        #endregion
#endif
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


        private AWSCredentials Credentials
        {
            get
            {
                return FallbackCredentialsFactory.GetCredentials();
            }
        }
    }
}
#endif