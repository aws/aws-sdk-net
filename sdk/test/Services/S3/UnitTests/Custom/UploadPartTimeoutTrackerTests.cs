#if !NETFRAMEWORK
using System;
using Amazon.S3.Transfer.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Covers the adaptive first-byte timeout math, including both paths that permanently disable it.
    /// Getting this wrong turns healthy requests into retries, so the self-disable paths matter as much
    /// as the happy path.
    /// </summary>
    [TestClass]
    public class UploadPartTimeoutTrackerTests
    {
        private const int IdealConnections = 10;

        private static UploadPartTimeoutTracker Sample(params double[] millisecondSamples)
        {
            var tracker = new UploadPartTimeoutTracker(IdealConnections);
            foreach (var ms in millisecondSamples)
                tracker.RecordSuccess(TimeSpan.FromMilliseconds(ms));

            return tracker;
        }

        [TestMethod]
        [TestCategory("S3")]
        public void NoTimeoutWhileStillSampling()
        {
            // Acting on too few samples would be guessing.
            var tracker = new UploadPartTimeoutTracker(IdealConnections);
            for (var i = 0; i < 9; i++)
                tracker.RecordSuccess(TimeSpan.FromMilliseconds(200));

            Assert.IsNull(tracker.CurrentTimeout);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RequiresAtLeastTenSamplesEvenWithFewerConnections()
        {
            var tracker = new UploadPartTimeoutTracker(idealConnectionCount: 2);
            for (var i = 0; i < 9; i++)
                tracker.RecordSuccess(TimeSpan.FromMilliseconds(200));
            Assert.IsNull(tracker.CurrentTimeout);

            tracker.RecordSuccess(TimeSpan.FromMilliseconds(200));
            Assert.IsNotNull(tracker.CurrentTimeout);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TimeoutNeverBelowOneSecond()
        {
            // Ten fast samples: P90 is 200ms, but a sub-second timeout would be far too aggressive.
            var tracker = Sample(200, 200, 200, 200, 200, 200, 200, 200, 200, 200);

            Assert.AreEqual(TimeSpan.FromSeconds(1), tracker.CurrentTimeout);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TimeoutSeededFromP90WhenAboveOneSecond()
        {
            // Sorted, index 8 (the P90 of ten samples) is 1500ms; mean stays well under the 5s bound.
            var tracker = Sample(100, 100, 100, 100, 100, 100, 100, 100, 1500, 1500);

            Assert.AreEqual(TimeSpan.FromMilliseconds(1500), tracker.CurrentTimeout);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DisabledWhenRequestsAreGenuinelySlow()
        {
            // If the mean is at or above 5s, retrying a slow part is slower than waiting for it.
            var tracker = Sample(6000, 6000, 6000, 6000, 6000, 6000, 6000, 6000, 6000, 6000);

            Assert.IsNull(tracker.CurrentTimeout);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StaysDisabledAfterFurtherSamples()
        {
            var tracker = Sample(6000, 6000, 6000, 6000, 6000, 6000, 6000, 6000, 6000, 6000);

            for (var i = 0; i < 50; i++)
                tracker.RecordSuccess(TimeSpan.FromMilliseconds(10));

            Assert.IsNull(tracker.CurrentTimeout);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void SustainedTimeoutsEventuallyDisableTheOptimization()
        {
            // A timeout rate above 1% escalates by a full second each time; once past 5s the whole
            // mechanism switches off rather than degrading into a retry storm.
            var tracker = Sample(100, 100, 100, 100, 100, 100, 100, 100, 1500, 1500);
            Assert.IsNotNull(tracker.CurrentTimeout);

            for (var i = 0; i < 10; i++)
                tracker.RecordTimeout();

            Assert.IsNull(tracker.CurrentTimeout);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TimeoutIncreasesAfterATimeout()
        {
            var tracker = Sample(100, 100, 100, 100, 100, 100, 100, 100, 1500, 1500);
            var before = tracker.CurrentTimeout.Value;

            tracker.RecordTimeout();

            Assert.IsTrue(
                tracker.CurrentTimeout.Value > before,
                $"Expected the timeout to grow from {before} but it was {tracker.CurrentTimeout}.");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void SteadyStateDriftsTowardObservedLatency()
        {
            // EWMA at 0.99/0.01 moves slowly and must not jump to the new sample.
            var tracker = Sample(100, 100, 100, 100, 100, 100, 100, 100, 3000, 3000);
            var before = tracker.CurrentTimeout.Value;

            tracker.RecordSuccess(TimeSpan.FromMilliseconds(100));
            var after = tracker.CurrentTimeout.Value;

            Assert.AreNotEqual(before, after);
            Assert.IsTrue(
                Math.Abs((after - before).TotalMilliseconds) < 100,
                $"EWMA should move gradually, but moved from {before} to {after}.");
        }
    }
}
#endif
