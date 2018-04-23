using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Kinesis;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using AWSSDK_DotNet.IntegrationTests.Utils;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Kinesis : TestBase<AmazonKinesisClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            // Delete all dotnet integ test streams.
            var streamNames = Client.ListStreams().StreamNames;
            foreach (var streamName in streamNames)
            {
                if (streamName.Contains("dotnet-integ-test-stream"))
                {
                    try
                    {
                        Client.DeleteStream(new DeleteStreamRequest
                        {
                            StreamName = streamName
                        });
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Failed to delete stream {0}: {1}", streamName, e.Message);
                    }
                }
            }

            // BaseClean();
        }
        

        [TestMethod]
        [TestCategory("Kinesis")]
        public void KinesisCRUD()
        {
            var streamName = "dotnet-integ-test-stream-" + DateTime.Now.Ticks;
            Action waitUntilStreamActive = () => UtilityMethods.WaitUntil(() =>
                Client.DescribeStream(new DescribeStreamRequest { StreamName = streamName }).StreamDescription.StreamStatus == StreamStatus.ACTIVE);

            // Create a stream.
            Client.CreateStream(new CreateStreamRequest
            {
                ShardCount = 1,
                StreamName = streamName
            });

            // Describe the stream.
            var stream = Client.DescribeStream(new DescribeStreamRequest
            {
                StreamName = streamName
            }).StreamDescription;
            Assert.AreEqual(stream.HasMoreShards, false);
            Assert.IsFalse(string.IsNullOrEmpty(stream.StreamARN));
            Assert.AreEqual(stream.StreamName, streamName);
            Assert.IsTrue(stream.StreamStatus == StreamStatus.CREATING);

            waitUntilStreamActive();

            var retentionHours = stream.RetentionPeriodHours;
            var newRetentionHours = retentionHours * 2;

            Client.IncreaseStreamRetentionPeriod(streamName, newRetentionHours);
            waitUntilStreamActive();
            stream = Client.DescribeStream(new DescribeStreamRequest
            {
                StreamName = streamName
            }).StreamDescription;
            Assert.AreEqual(newRetentionHours, stream.RetentionPeriodHours);

            Client.DecreaseStreamRetentionPeriod(streamName, retentionHours);
            waitUntilStreamActive();
            stream = Client.DescribeStream(new DescribeStreamRequest
            {
                StreamName = streamName
            }).StreamDescription;
            Assert.AreEqual(retentionHours, stream.RetentionPeriodHours);

            // List streams.
            var streamNames = Client.ListStreams().StreamNames;
            Assert.IsTrue(streamNames.Count > 0);
            Assert.IsTrue(streamNames.Contains(streamName));

            // Delete the stream.
            Client.DeleteStream(new DeleteStreamRequest
            {
                StreamName = streamName
            });
            stream = Client.DescribeStream(new DescribeStreamRequest
            {
                StreamName = streamName
            }).StreamDescription;
            Assert.IsTrue(stream.StreamStatus == StreamStatus.DELETING);
        }

        private StreamDescription WaitForStreamToBeActive(string streamName)
        {
            while (true)
            {
                var stream = Client.DescribeStream(new DescribeStreamRequest
                {
                    StreamName = streamName
                }).StreamDescription;

                if (stream.StreamStatus != StreamStatus.ACTIVE)
                {
                    Thread.Sleep(5 * 1000);
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
