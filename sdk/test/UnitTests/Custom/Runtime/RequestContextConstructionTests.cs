using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RequestContextConstructionTests
    {
        private static readonly Regex GuidV4Format =
            new Regex("^[0-9a-f]{8}-[0-9a-f]{4}-4[0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$");

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FromRandomBytesMatchesGuidByteLayout()
        {
            var random = new byte[20];
            for (int i = 0; i < random.Length; i++)
                random[i] = (byte)(0xA0 + i * 7);

            for (int offset = 0; offset <= 4; offset++)
            {
                var expectedBytes = new byte[16];
                Array.Copy(random, offset, expectedBytes, 0, 16);
                expectedBytes[7] = (byte)((expectedBytes[7] & 0x0F) | 0x40);
                expectedBytes[8] = (byte)((expectedBytes[8] & 0x3F) | 0x80);

                Assert.AreEqual(new Guid(expectedBytes), GuidUtils.FromRandomBytes(random, offset));
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NewRandomGuidDoesNotBufferUnderSnapStart()
        {
            var saved = Environment.GetEnvironmentVariable("AWS_LAMBDA_INITIALIZATION_TYPE");
            try
            {
                Environment.SetEnvironmentVariable("AWS_LAMBDA_INITIALIZATION_TYPE", "snap-start");
                GuidUtils.ResetIsSnapStart();
                Assert.IsTrue(GuidUtils.IsSnapStart);
                AssertVersion4(GuidUtils.NewRandomGuid());

                Environment.SetEnvironmentVariable("AWS_LAMBDA_INITIALIZATION_TYPE", "on-demand");
                GuidUtils.ResetIsSnapStart();
                Assert.IsFalse(GuidUtils.IsSnapStart);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_LAMBDA_INITIALIZATION_TYPE", saved);
                GuidUtils.ResetIsSnapStart();
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NewRandomGuidIsVersion4Variant1AndUnique()
        {
            // Spans several refills of the per-thread batch.
            const int count = 1000;
            var seen = new HashSet<Guid>();
            for (int i = 0; i < count; i++)
            {
                var guid = GuidUtils.NewRandomGuid();
                AssertVersion4(guid);
                Assert.IsTrue(seen.Add(guid), "Duplicate Guid generated");
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NewRandomGuidMatchesGuidNewGuidFormat()
        {
            // Version/variant bits are set the same way Guid.NewGuid sets them.
            AssertVersion4(Guid.NewGuid());
            var bytes = GuidUtils.NewRandomGuid().ToByteArray();
            Assert.AreEqual(0x40, bytes[7] & 0xF0);
            Assert.AreEqual(0x80, bytes[8] & 0xC0);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NewRandomGuidIsUniqueAcrossThreads()
        {
            const int threads = 8;
            const int perThread = 500;
            var all = new ConcurrentBag<Guid>();
            using (var start = new ManualResetEventSlim(false))
            {
                var tasks = Enumerable.Range(0, threads).Select(_ => Task.Factory.StartNew(() =>
                {
                    start.Wait();
                    for (int i = 0; i < perThread; i++)
                        all.Add(GuidUtils.NewRandomGuid());
                }, TaskCreationOptions.LongRunning)).ToArray();
                start.Set();
                Task.WaitAll(tasks);
            }

            Assert.AreEqual(threads * perThread, all.Count);
            Assert.AreEqual(threads * perThread, all.Distinct().Count());
            foreach (var guid in all)
                AssertVersion4(guid);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequestContextInvocationIdIsStableAndDistinct()
        {
            var first = new RequestContext(false);
            var second = new RequestContext(false);

            Assert.AreNotEqual(Guid.Empty, first.InvocationId);
            Assert.AreEqual(first.InvocationId, first.InvocationId);
            Assert.AreNotEqual(first.InvocationId, second.InvocationId);
            AssertVersion4(first.InvocationId);
            AssertVersion4(second.InvocationId);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequestContextDefaults()
        {
            var signer = new NullSigner();
            var context = new RequestContext(true, signer);

            Assert.AreSame(signer, context.Signer);
            Assert.IsNotNull(context.Metrics);
            Assert.IsTrue(context.Metrics.IsEnabled);
            Assert.IsFalse(new RequestContext(false).Metrics.IsEnabled);
            Assert.IsNull(new RequestContext(false).Signer);

            Assert.AreEqual(0, context.Retries);
            Assert.AreEqual(0, context.EndpointDiscoveryRetries);
            Assert.AreEqual(CapacityManager.CapacityType.Increment, context.LastCapacityType);
            Assert.IsFalse(context.IsSigned);
            Assert.IsFalse(context.IsAsync);
            Assert.IsFalse(context.IsLastExceptionRetryable);
            Assert.IsFalse(context.CSMEnabled);
            Assert.IsNull(context.CSMCallEvent);
            Assert.IsNull(context.CSMCallAttempt);
            Assert.AreEqual(default(CancellationToken), context.CancellationToken);
            Assert.IsFalse(context.CancellationToken.CanBeCanceled);
            Assert.IsNull(context.Request);
            Assert.IsNull(context.Identity);
            Assert.IsNull(context.ClientConfig);
            Assert.IsNull(context.ServiceMetaData);
            Assert.IsNull(context.ClockSkewAttemptCandidate);

            Assert.IsNull(context.ContextAttributesIfCreated);
            var attributes = context.ContextAttributes;
            Assert.IsNotNull(attributes);
            Assert.AreEqual(0, attributes.Count);
            Assert.AreSame(attributes, context.ContextAttributes);
            Assert.AreSame(attributes, context.ContextAttributesIfCreated);

            var userAgentDetails = context.UserAgentDetails;
            Assert.IsNotNull(userAgentDetails);
            Assert.AreSame(userAgentDetails, context.UserAgentDetails);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequestContextKeepsAssignedCancellationToken()
        {
            using (var cts = new CancellationTokenSource())
            {
                var context = new RequestContext(false) { CancellationToken = cts.Token, IsAsync = true };
                Assert.AreEqual(cts.Token, context.CancellationToken);
                Assert.IsTrue(context.IsAsync);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ExecutionContextConstructors()
        {
            var signer = new NullSigner();
            var built = new Amazon.Runtime.Internal.ExecutionContext(true, signer);
            Assert.IsInstanceOfType(built.RequestContext, typeof(RequestContext));
            Assert.IsInstanceOfType(built.ResponseContext, typeof(ResponseContext));
            Assert.AreSame(signer, built.RequestContext.Signer);
            Assert.IsTrue(built.RequestContext.Metrics.IsEnabled);

            var requestContext = new RequestContext(false);
            var responseContext = new ResponseContext();
            var wrapped = new Amazon.Runtime.Internal.ExecutionContext(requestContext, responseContext);
            Assert.AreSame(requestContext, wrapped.RequestContext);
            Assert.AreSame(responseContext, wrapped.ResponseContext);
        }

#if NETCOREAPP
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NewRandomGuidDoesNotAllocateAfterWarmup()
        {
            // Initialize this thread's batch.
            GuidUtils.NewRandomGuid();

            long before = GC.GetAllocatedBytesForCurrentThread();
            for (int i = 0; i < 1000; i++)
                GuidUtils.NewRandomGuid();
            long allocated = GC.GetAllocatedBytesForCurrentThread() - before;

            Assert.AreEqual(0L, allocated);
        }
#endif

        private static void AssertVersion4(Guid guid)
        {
            Assert.IsTrue(GuidV4Format.IsMatch(guid.ToString("D")), "Not a version 4 Guid: " + guid);
        }
    }
}
