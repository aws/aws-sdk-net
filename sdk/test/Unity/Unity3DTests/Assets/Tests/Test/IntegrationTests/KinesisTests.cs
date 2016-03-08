using Amazon.Kinesis;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using AWSSDK.Tests.Framework;

namespace AWSSDK.IntegrationTests.Kinesis
{
    [TestFixture(TestOf = typeof(KinesisTests))]
    [Category("Integration")]
    [Category("K")]
    public class KinesisTests : TestBase<AmazonKinesisClient>
    {
        // Time to wait for status change, in seconds
        private static readonly int WaitForPhaseExitTimeout = 60;
        // Time to sleep in between checking phase status, in seconds
        private static readonly int SleepTime = 5;
        private static readonly string StreamNamePrefix = "unity-integ-test-stream-";

        string StreamName;
        StreamDescription MostRecentStreamDescription;

        [TestFixtureSetUp]
        public void CreateStream()
        {
            StreamName = StreamNamePrefix + DateTime.Now.Ticks;

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.CreateStreamAsync(new CreateStreamRequest
            {
                ShardCount = 1,
                StreamName = StreamName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
        }

        [Test]
        [Category("WWW")]
        public void DescribeStreamTest()
        {
            StreamDescription streamDescription = DescribeStream();
            if (streamDescription == null)
            {
                Assert.Fail();
            }
            Utils.AssertFalse(streamDescription.HasMoreShards);
            Utils.AssertFalse(string.IsNullOrEmpty(streamDescription.StreamARN));
            Assert.AreEqual(StreamName, streamDescription.StreamName);
            Utils.AssertTrue(streamDescription.StreamStatus == StreamStatus.CREATING || streamDescription.StreamStatus == StreamStatus.ACTIVE);
        }

        [Test]
        [Category("WWW")]
        public void DescribeNonexistantStreamTest()
        {
            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.DescribeStreamAsync(new DescribeStreamRequest
            {
                StreamName = "IDontExist"
            }, (response) =>
            {
                responseException = response.Exception;

                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNotNull(responseException);
            Assert.IsInstanceOf(typeof(ResourceNotFoundException), responseException);
        }

        [Test]
        [Category("Kinesis")]
        [Category("WWW")]
        public void IncreaseAndDecreaseStreamRetentionTest()
        {
            StreamDescription streamDescription = WaitForStreamToExitPhase(StreamStatus.CREATING, true);
            Assert.AreEqual(StreamStatus.ACTIVE, streamDescription.StreamStatus);

            var retentionHours = streamDescription.RetentionPeriodHours;
            var newRetentionHours = retentionHours * 2;
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            Client.IncreaseStreamRetentionPeriodAsync(new IncreaseStreamRetentionPeriodRequest
            {
                StreamName = StreamName,
                RetentionPeriodHours = newRetentionHours
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            Assert.IsNull(responseException);
            streamDescription = WaitForStreamToExitPhase(StreamStatus.UPDATING);
            Assert.AreEqual(StreamStatus.ACTIVE, streamDescription.StreamStatus);
            Assert.AreEqual(newRetentionHours, streamDescription.RetentionPeriodHours);

            Client.DecreaseStreamRetentionPeriodAsync(new DecreaseStreamRetentionPeriodRequest
            {
                StreamName = StreamName,
                RetentionPeriodHours = retentionHours
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            Assert.IsNull(responseException);
            streamDescription = WaitForStreamToExitPhase(StreamStatus.UPDATING);
            Assert.AreEqual(StreamStatus.ACTIVE, streamDescription.StreamStatus);
            Assert.AreEqual(retentionHours, streamDescription.RetentionPeriodHours);
        }

        private List<string> ListStreamsHelper()
        {
            List<string> streamNames = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Client.ListStreamsAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    streamNames = response.Response.StreamNames;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            return streamNames;
        }

        [Test]
        [Category("WWW")]
        public void ListStreamsTest()
        {
            List<string> streamNames = ListStreamsHelper();
            Utils.AssertTrue(streamNames.Count > 0);
            Utils.AssertTrue(streamNames.Contains(StreamName));
        }

        [TestFixtureTearDown]
        public void DeleteStreamsHelper()
        {
            List<string> streamNames = ListStreamsHelper();

            foreach (var streamName in streamNames)
            {
                if (streamName.Contains(StreamNamePrefix))
                {
                    Client.DeleteStreamAsync(new DeleteStreamRequest
                    {
                        StreamName = streamName
                    }, (response) => { });
                }
            }
        }

        private StreamDescription WaitForStreamToExitPhase(StreamStatus phaseToExit, bool useMostRecentStreamDescription = false)
        {
            int remainingTime = WaitForPhaseExitTimeout;
            if (useMostRecentStreamDescription && MostRecentStreamDescription != null && MostRecentStreamDescription.StreamStatus != phaseToExit)
            {
                return MostRecentStreamDescription;
            }
            while (true)
            {
                StreamDescription streamDescription = DescribeStream();
                if (streamDescription == null)
                {
                    Assert.Fail();
                }
                if (streamDescription.StreamStatus != phaseToExit)
                {
                    return streamDescription;
                }
                if (remainingTime < 0)
                {
                    Assert.Fail();
                }
                Thread.Sleep(SleepTime * 1000);
                remainingTime -= SleepTime;
            }
        }

        private StreamDescription DescribeStream()
        {
            StreamDescription streamDescription = null;
            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.DescribeStreamAsync(new DescribeStreamRequest
            {
                StreamName = StreamName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    streamDescription = response.Response.StreamDescription;
                    MostRecentStreamDescription = streamDescription;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            return streamDescription;
        }
    }
}
