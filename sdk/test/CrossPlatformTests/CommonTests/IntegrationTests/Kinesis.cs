using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;


using Amazon.Kinesis;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using NUnit.Framework;
using CommonTests.Framework;


namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class Kinesis : TestBase<AmazonKinesisClient>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            // Delete all dotnet integ test streams.
            var streamNames = Client.ListStreamsAsync().Result.StreamNames;
            foreach (var streamName in streamNames)
            {
                if (streamName.Contains("dotnet-integ-test-stream"))
                {
                    try
                    {
                        Client.DeleteStreamAsync(new DeleteStreamRequest
                        {
                            StreamName = streamName
                        }).Wait();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Failed to delete stream {0}: {1}", streamName, e.Message);
                    }
                }
            }

            // BaseClean();
        }
        

        [Test]
        [Category("Kinesis")]
        public void KinesisCRUD()
        {
            var streamName = "dotnet-integ-test-stream-" + DateTime.Now.Ticks;

            // Create a stream.
            Client.CreateStreamAsync(new CreateStreamRequest
            {
                ShardCount = 1,
                StreamName = streamName
            }).Wait();

            // Describe the stream.
            var stream = Client.DescribeStreamAsync(new DescribeStreamRequest
            {
                StreamName = streamName
            }).Result.StreamDescription;
            Assert.AreEqual(stream.HasMoreShards, false);
            Assert.IsFalse(string.IsNullOrEmpty(stream.StreamARN));
            Assert.AreEqual(stream.StreamName, streamName);
            Assert.IsTrue(stream.StreamStatus == StreamStatus.CREATING);

            // List streams.
            var streamNames = Client.ListStreamsAsync().Result.StreamNames;
            Assert.IsTrue(streamNames.Count > 0);
            Assert.IsTrue(streamNames.Contains(streamName));

            // Delete the stream.
            Client.DeleteStreamAsync(new DeleteStreamRequest
            {
                StreamName = streamName
            }).Wait();
            stream = Client.DescribeStreamAsync(new DescribeStreamRequest
            {
                StreamName = streamName
            }).Result.StreamDescription;
            Assert.IsTrue(stream.StreamStatus == StreamStatus.DELETING);
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
