using Amazon.IoT;
using Amazon.IoT.Model;
using Amazon.IotData;
using Amazon.IotData.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    [TestCategory("IoTData")]
    public class IotData
    {
        private const string TopicThatRequiresUrlEncoding = "X$aws/,topic";
        private static string THING_NAME = null;
        private static string CREATED_THING_NAME = null;

        static AmazonIotDataClient Client = null;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext)
        {
            Client = new AmazonIotDataClient("https://data-ats.iot.us-east-1.amazonaws.com/");

            using (var iotClient = new AmazonIoTClient())
            {
                var listResponse = await iotClient.ListThingsAsync();
                var things = listResponse.Things;

                var firstThing = things.FirstOrDefault();
                if (firstThing == null)
                {
                    THING_NAME = "dotnettest" + DateTime.UtcNow.ToFileTime();
                    await iotClient.CreateThingAsync(new CreateThingRequest
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
        public static async Task Cleanup()
        {
            if (!string.IsNullOrEmpty(CREATED_THING_NAME))
            {
                using (var iotClient = new AmazonIoTClient())
                {
                    await iotClient.DeleteThingAsync(CREATED_THING_NAME);
                }
            }

            Client?.Dispose();
        }

        [TestMethod]
        public async Task PublishTopicWithUrlEncodedCharacters()
        {
            var response = await Client.PublishAsync(new PublishRequest
            {
                Topic = TopicThatRequiresUrlEncoding
            });
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
        }

        [TestMethod]
        public async Task IotDataTests()
        {
            var topicName = "$aws/things/" + THING_NAME + "/shadow/update";
            await Client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1,
                Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
            });
            await Client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1
            });

            topicName = "$aws/things/" + THING_NAME + "/shadow/get";
            await Client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1,
                Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
            });
            await Client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1
            });

            var payload = new MemoryStream(Encoding.UTF8.GetBytes(@"{ ""state"": {}}"));
            var updateThingShadowResponse = await Client.UpdateThingShadowAsync(new UpdateThingShadowRequest
            {
                ThingName = THING_NAME,
                Payload = payload
            });
            Assert.IsTrue(payload.Length < updateThingShadowResponse.Payload.Length);

            var getThingShadowResponse = await Client.GetThingShadowAsync(new GetThingShadowRequest
            {
                ThingName = THING_NAME
            });
            Assert.IsTrue(getThingShadowResponse.Payload.Length > 0);

            var deleteThingShadowResponse = await Client.DeleteThingShadowAsync(new DeleteThingShadowRequest
            {
                ThingName = THING_NAME
            });
            Assert.IsTrue(deleteThingShadowResponse.Payload.Length > 0);
        }

        [TestMethod]
        public async Task IotDataErrorTests()
        {
            await Assert.ThrowsExceptionAsync<AmazonIotDataException>(() =>
                Client.UpdateThingShadowAsync(new UpdateThingShadowRequest
                {
                    Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
                })
            );

            await Assert.ThrowsExceptionAsync<AmazonIotDataException>(() =>
                Client.UpdateThingShadowAsync(new UpdateThingShadowRequest())
            );

            await Assert.ThrowsExceptionAsync<Amazon.IotData.Model.InvalidRequestException>(() =>
                Client.UpdateThingShadowAsync(new UpdateThingShadowRequest
                {
                    ThingName = THING_NAME,
                    Payload = new MemoryStream(Encoding.UTF8.GetBytes("{}"))
                })
            );
        }
    }
}
