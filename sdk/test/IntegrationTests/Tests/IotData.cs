using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IotData;
using Amazon.IotData.Model;
using Amazon.Runtime;

using System.IO;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class IotData
    {
        const string THINGNAME = "device1";

        static AmazonIotDataClient Client = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Client = new AmazonIotDataClient("https://data.iot.us-east-1.amazonaws.com/");
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            if (Client != null)
            {
                Client.Dispose();
            }
        }

        [TestMethod]
        [TestCategory("IotData")]
        public void IotDataTests()
        {
            Client.Publish(new PublishRequest
            {
                Topic = THINGNAME,
                Qos = 1,
                Payload = new MemoryStream(new byte[] {1,2,3,4})
            });

            Client.Publish(new PublishRequest
            {
                Topic = THINGNAME,
                Qos = 1
            });

            var payload = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(
                   @"{ ""state"": {}}"
            ));
            var updateThingShadowResponse = Client.UpdateThingShadow(new UpdateThingShadowRequest
            {
                ThingName = THINGNAME,
                Payload = payload
            });
            Assert.IsTrue(payload.Length < updateThingShadowResponse.Payload.Length);

            var getThingShadowResponse = Client.GetThingShadow(new GetThingShadowRequest
            {
                ThingName = THINGNAME
            });
            Assert.IsTrue(getThingShadowResponse.Payload.Length > 0);

            var deleteThingShadowResponse = Client.DeleteThingShadow(new DeleteThingShadowRequest
            {
                ThingName = THINGNAME
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

            exception = AssertExtensions.ExpectException<InvalidRequestException>(() =>
            {
                Client.UpdateThingShadow(new UpdateThingShadowRequest
                {
                    ThingName  = THINGNAME,
                    Payload = new MemoryStream(System.Text.Encoding.UTF8.GetBytes("{}"))
                });
            });

        }

    }
}
