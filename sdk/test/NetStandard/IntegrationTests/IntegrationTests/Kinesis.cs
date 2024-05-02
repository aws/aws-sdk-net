using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Kinesis;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Xunit;
using Amazon.DNXCore.IntegrationTests;


namespace Amazon.DNXCore.IntegrationTests
{

    public class Kinesis : TestBase<AmazonKinesisClient>
    {
        private List<string> _streamNames = new List<string>();

        protected override void Dispose(bool disposing)
        {
            foreach (var streamName in _streamNames)
            {
                try
                {
                    Client.DeleteStreamAsync(new DeleteStreamRequest
                    {
                        StreamName = streamName
                    }).Wait();
                }
                catch { };
            }
            base.Dispose(disposing);
        }
        
        [Fact]
        [Trait(CategoryAttribute,"Kinesis")]
        public async Task KinesisCRUD()
        {
            var streamName = UtilityMethods.GenerateName("KinesisCRUD");

            // Create a stream.
            await Client.CreateStreamAsync(new CreateStreamRequest
            {
                ShardCount = 1,
                StreamName = streamName
            });
            _streamNames.Add(streamName);

            // Describe the stream.
            var stream = (await Client.DescribeStreamAsync(new DescribeStreamRequest
            {
                StreamName = streamName
            })).StreamDescription;
            Assert.False(stream.HasMoreShards);
            Assert.False(string.IsNullOrEmpty(stream.StreamARN));
            Assert.Equal(stream.StreamName, streamName);
            Assert.True(stream.StreamStatus == StreamStatus.CREATING || stream.StreamStatus == StreamStatus.ACTIVE);

            // List streams.
            var streamNames = (await Client.ListStreamsAsync()).StreamNames;
            Assert.True(streamNames.Count > 0);
            Assert.Contains(streamName, streamNames);
        }

        private StreamDescription WaitForStreamToBeActive(string streamName)
        {
            while (true)
            {
                var stream = Client.DescribeStreamAsync(new DescribeStreamRequest
                {
                    StreamName = streamName
                }).Result.StreamDescription;

                if (stream.StreamStatus != StreamStatus.ACTIVE)
                {
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(5));
                    continue;
                }
                else
                {
                    return stream;
                }
            }
        }
    }
}
