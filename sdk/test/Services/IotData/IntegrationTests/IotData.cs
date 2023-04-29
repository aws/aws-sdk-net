using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IotData;
using Amazon.IotData.Model;
using Amazon.Runtime;

using System.IO;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.IoT.Model;
using Amazon.IoT;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class IotData
    {
        private const string TopicThatRequiresUrlEncoding = "X$aws/,topic";

        private static string THING_NAME = null;
        private static string CREATED_THING_NAME = null;

        static AmazonIotDataClient Client = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Client = new AmazonIotDataClient("https://data-ats.iot.us-east-1.amazonaws.com/");

            using (var iotClient = new AmazonIoTClient())
            {
                var things = iotClient.ListThings().Things;
                var firstThing = things.FirstOrDefault();
                if (firstThing == null)
                {
                    THING_NAME = "dotnettest" + DateTime.UtcNow.ToFileTime();
                    iotClient.CreateThing(new CreateThingRequest
                    {
                        ThingName = THING_NAME
                    });
                    CREATED_THING_NAME = THING_NAME;
                }
                else
                {
                    THING_NAME = firstThing.ThingName;
                }
            }
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            if (!string.IsNullOrEmpty(CREATED_THING_NAME))
            {
                using (var iotClient = new AmazonIoTClient())
                {
                    iotClient.DeleteThing(CREATED_THING_NAME);
                }
            }

            if (Client != null)
            {
                Client.Dispose();
            }
        }

        [TestMethod]
        [TestCategory("IoTData")]
        public void PublishTopicWithUrlEncodedCharacters()
        {
            var response = Client.Publish(new PublishRequest
            {
                Topic = TopicThatRequiresUrlEncoding
            });
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
        }

        [TestMethod]
        [TestCategory("IotData")]
        public void IotDataTests()
        {
            var topicName = "$aws/things/" + THING_NAME + "/shadow/update";
            Client.Publish(new PublishRequest
            {
                Topic = topicName,
                Qos = 1,
                Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
            });
            Client.Publish(new PublishRequest
            {
                Topic = topicName,
                Qos = 1
            });

            topicName = "$aws/things/" + THING_NAME + "/shadow/get";
            Client.Publish(new PublishRequest
            {
                Topic = topicName,
                Qos = 1,
                Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
            });
            Client.Publish(new PublishRequest
            {
                Topic = topicName,
                Qos = 1
            });


            var payload = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(
                   @"{ ""state"": {}}"
            ));
            var updateThingShadowResponse = Client.UpdateThingShadow(new UpdateThingShadowRequest
            {
                ThingName = THING_NAME,
                Payload = payload
            });
            Assert.IsTrue(payload.Length < updateThingShadowResponse.Payload.Length);

            var getThingShadowResponse = Client.GetThingShadow(new GetThingShadowRequest
            {
                ThingName = THING_NAME
            });
            Assert.IsTrue(getThingShadowResponse.Payload.Length > 0);

            var deleteThingShadowResponse = Client.DeleteThingShadow(new DeleteThingShadowRequest
            {
                ThingName = THING_NAME
            });
            Assert.IsTrue(getThingShadowResponse.Payload.Length > 0);
        }

        [TestMethod]
        [TestCategory("IotData")]
        public void IotDataErrorTests()
        {
            var exception = AssertExtensions.ExpectException<AmazonIotDataException>(()=>
            {
                Client.UpdateThingShadow(new UpdateThingShadowRequest
                {
                    Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
                });
            });

            exception = AssertExtensions.ExpectException<AmazonIotDataException>(() =>
            {
                Client.UpdateThingShadow(new UpdateThingShadowRequest());
            });

            exception = AssertExtensions.ExpectException<Amazon.IotData.Model.InvalidRequestException>(() =>
            {
                Client.UpdateThingShadow(new UpdateThingShadowRequest
                {
                    ThingName  = THING_NAME,
                    Payload = new MemoryStream(System.Text.Encoding.UTF8.GetBytes("{}"))
                });
            });

        }

    }
}
