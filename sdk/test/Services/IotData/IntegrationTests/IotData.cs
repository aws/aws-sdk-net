using Amazon.IoT;
using Amazon.IoT.Model;
using Amazon.IotData;
using Amazon.IotData.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// xUnit fixture that creates an IoT thing (or reuses an existing one) for the lifetime
    /// of the <see cref="IotDataTests"/> class and tears down any thing it created.
    /// </summary>
    public class IotDataFixture : IAsyncLifetime
    {
        private const string TopicThatRequiresUrlEncoding = "X$aws/,topic";

        public AmazonIotDataClient Client { get; private set; }
        public string ThingName { get; private set; }
        private string _createdThingName;

        public async ValueTask InitializeAsync()
        {
            Client = new AmazonIotDataClient("https://data-ats.iot.us-east-1.amazonaws.com/");

            using (var iotClient = new AmazonIoTClient())
            {
                var listResponse = await iotClient.ListThingsAsync();
                var things = listResponse.Things;

                var firstThing = things.FirstOrDefault();
                if (firstThing == null)
                {
                    ThingName = "dotnettest" + Guid.NewGuid().ToString("N");
                    await iotClient.CreateThingAsync(new CreateThingRequest
                    {
                        ThingName = ThingName
                    });

                    _createdThingName = ThingName;
                }
                else
                {
                    ThingName = firstThing.ThingName;
                }
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (!string.IsNullOrEmpty(_createdThingName))
            {
                using (var iotClient = new AmazonIoTClient())
                {
                    await iotClient.DeleteThingAsync(_createdThingName);
                }
            }

            Client?.Dispose();
        }
    }

    [Trait("Category", "IoTData")]
    public class IotDataTests : IClassFixture<IotDataFixture>
    {
        private const string TopicThatRequiresUrlEncoding = "X$aws/,topic";

        private readonly AmazonIotDataClient _client;
        private readonly string _thingName;

        public IotDataTests(IotDataFixture fixture)
        {
            _client = fixture.Client;
            _thingName = fixture.ThingName;
        }

        [Fact]
        public async Task PublishTopicWithUrlEncodedCharacters()
        {
            var response = await _client.PublishAsync(new PublishRequest
            {
                Topic = TopicThatRequiresUrlEncoding
            });
            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
        }

        [Fact]
        public async Task IotDataTests_Operations()
        {
            var topicName = "$aws/things/" + _thingName + "/shadow/update";
            await _client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1,
                Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
            });
            await _client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1
            });

            topicName = "$aws/things/" + _thingName + "/shadow/get";
            await _client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1,
                Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
            });
            await _client.PublishAsync(new PublishRequest
            {
                Topic = topicName,
                Qos = 1
            });

            var payload = new MemoryStream(Encoding.UTF8.GetBytes(@"{ ""state"": {}}"));
            var updateThingShadowResponse = await _client.UpdateThingShadowAsync(new UpdateThingShadowRequest
            {
                ThingName = _thingName,
                Payload = payload
            });
            Assert.True(payload.Length < updateThingShadowResponse.Payload.Length);

            var getThingShadowResponse = await _client.GetThingShadowAsync(new GetThingShadowRequest
            {
                ThingName = _thingName
            });
            Assert.True(getThingShadowResponse.Payload.Length > 0);

            var deleteThingShadowResponse = await _client.DeleteThingShadowAsync(new DeleteThingShadowRequest
            {
                ThingName = _thingName
            });
            Assert.True(deleteThingShadowResponse.Payload.Length > 0);
        }

        [Fact]
        public async Task IotDataErrorTests()
        {
            await Assert.ThrowsAsync<AmazonIotDataException>(() =>
                _client.UpdateThingShadowAsync(new UpdateThingShadowRequest
                {
                    Payload = new MemoryStream(new byte[] { 1, 2, 3, 4 })
                })
            );

            await Assert.ThrowsAsync<AmazonIotDataException>(() =>
                _client.UpdateThingShadowAsync(new UpdateThingShadowRequest())
            );

            await Assert.ThrowsAsync<Amazon.IotData.Model.InvalidRequestException>(() =>
                _client.UpdateThingShadowAsync(new UpdateThingShadowRequest
                {
                    ThingName = _thingName,
                    Payload = new MemoryStream(Encoding.UTF8.GetBytes("{}"))
                })
            );
        }
    }
}
