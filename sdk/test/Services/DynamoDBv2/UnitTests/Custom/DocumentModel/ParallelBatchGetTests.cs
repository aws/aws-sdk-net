/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Focused coverage for the opt-in parallel execution path of <see cref="DocumentBatchGet"/> /
    /// <see cref="MultiBatchGet"/> (the <c>MaxParallelBatches</c> knob). These tests mock
    /// <c>IAmazonDynamoDB.BatchGetItemAsync</c> directly so that chunking, concurrency bounding,
    /// result assembly, UnprocessedKeys retry, ordering, cancellation, and error handling can all be
    /// verified deterministically without touching a real service.
    /// </summary>
    [TestClass]
    public class ParallelBatchGetTests
    {
        private Mock<IAmazonDynamoDB> ddbClientMock;
        private Table table;

        [TestInitialize]
        public void Setup()
        {
            ddbClientMock = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);

            var clientConfigMock = new Mock<IClientConfig>();
            clientConfigMock.SetupGet(c => c.RegionEndpoint).Returns((Amazon.RegionEndpoint)null);
            clientConfigMock.SetupGet(c => c.ServiceURL).Returns((string)null);
            ddbClientMock.SetupGet(c => c.Config).Returns(clientConfigMock.Object);

            table = CreateTable(ddbClientMock.Object, "AddressTable");
        }

        #region Concurrency bound

        [TestMethod]
        public async Task DefaultConfig_ExecutesSequentially_MaxOneInFlight()
        {
            var tracker = new ConcurrencyTracker();
            SetupTrackedResponses(tracker);

            // 500 keys => 5 chunks of 100. MaxParallelBatches unset => sequential.
            var batch = CreateBatchWithKeys("K", 500);
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch } };

            await multiBatchGet.GetItemsAsync();

            Assert.AreEqual(5, tracker.TotalCalls);
            Assert.AreEqual(1, tracker.MaxObservedConcurrency, "Default behavior must never issue more than one call at a time.");
        }

        [TestMethod]
        public async Task MaxParallelBatchesOne_ExecutesSequentially_MaxOneInFlight()
        {
            var tracker = new ConcurrencyTracker();
            SetupTrackedResponses(tracker);

            var batch = CreateBatchWithKeys("K", 500);
            batch.MaxParallelBatches = 1;
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 1 };

            await multiBatchGet.GetItemsAsync();

            Assert.AreEqual(5, tracker.TotalCalls);
            Assert.AreEqual(1, tracker.MaxObservedConcurrency);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-100)]
        public async Task MaxParallelBatchesLessThanOne_TreatedAsSequential(int invalidValue)
        {
            var tracker = new ConcurrencyTracker();
            SetupTrackedResponses(tracker);

            var batch = CreateBatchWithKeys("K", 300);
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = invalidValue };

            await multiBatchGet.GetItemsAsync();

            Assert.AreEqual(3, tracker.TotalCalls);
            Assert.AreEqual(1, tracker.MaxObservedConcurrency, "Values < 1 must be clamped to sequential behavior.");
        }

        [TestMethod]
        public async Task ParallelExecution_NeverExceedsConfiguredBound()
        {
            var tracker = new ConcurrencyTracker();
            // Hold every call open until we explicitly release, so multiple calls pile up concurrently.
            var gate = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
            SetupTrackedResponses(tracker, gate.Task);

            // 1000 keys => 10 chunks, cap at 3 in flight.
            var batch = CreateBatchWithKeys("K", 1000);
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 3 };

            var execution = multiBatchGet.GetItemsAsync();

            // Give the scheduler time to launch as many calls as it is willing to.
            await tracker.WaitForConcurrencyAtLeast(3, TimeSpan.FromSeconds(5));
            await Task.Delay(100);

            Assert.IsTrue(tracker.MaxObservedConcurrency <= 3, $"Observed {tracker.MaxObservedConcurrency} in flight, cap was 3.");

            gate.SetResult(true);
            await execution;

            Assert.AreEqual(10, tracker.TotalCalls);
            Assert.IsTrue(tracker.MaxObservedConcurrency <= 3, "Concurrency bound must hold for the whole operation.");
        }

        [TestMethod]
        public async Task ParallelExecution_ActuallyReachesConfiguredBound()
        {
            var tracker = new ConcurrencyTracker();
            var gate = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
            SetupTrackedResponses(tracker, gate.Task);

            var batch = CreateBatchWithKeys("K", 500); // 5 chunks
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 4 };

            var execution = multiBatchGet.GetItemsAsync();

            // Prove it is genuinely parallel (not accidentally serial) by requiring 4 concurrent in-flight calls.
            await tracker.WaitForConcurrencyAtLeast(4, TimeSpan.FromSeconds(5));

            gate.SetResult(true);
            await execution;

            Assert.AreEqual(4, tracker.MaxObservedConcurrency);
        }

        #endregion

        #region Result correctness

        [TestMethod]
        public async Task ParallelExecution_CollectsAllResults_NoLossOrDuplication()
        {
            // Each chunk returns one item per key it was asked for, echoing the key back as the Id.
            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((BatchGetItemRequest request, CancellationToken _) => EchoResponse(request));

            var batch = CreateBatchWithKeys("K", 550); // 6 chunks (5 x 100 + 1 x 50)
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 6 };

            var results = await multiBatchGet.GetItemsAsync();

            var docs = results["AddressTable"];
            Assert.AreEqual(550, docs.Count, "Every requested key must be represented exactly once.");

            var returnedIds = docs.Select(d => d["Id"].AsString()).ToList();
            var expectedIds = Enumerable.Range(1, 550).Select(i => $"K{i}").ToList();
            CollectionAssert.AreEquivalent(expectedIds, returnedIds);
            Assert.AreEqual(550, returnedIds.Distinct().Count(), "No key may be duplicated across parallel chunks.");
        }

        [TestMethod]
        public async Task ParallelExecution_ResultOrderIsDeterministic_RegardlessOfCompletionOrder()
        {
            // Force later chunks to complete BEFORE earlier ones, to prove result ordering is by chunk index,
            // not by completion time.
            var callIndex = 0;
            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .Returns(async (BatchGetItemRequest request, CancellationToken _) =>
                {
                    var myIndex = Interlocked.Increment(ref callIndex);
                    // First-dispatched chunk waits the longest; last-dispatched returns immediately.
                    await Task.Delay(myIndex == 1 ? 200 : 10);
                    return EchoResponse(request);
                });

            var batch = CreateBatchWithKeys("K", 300); // 3 chunks: K1..K100, K101..K200, K201..K300
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 3 };

            var results = await multiBatchGet.GetItemsAsync();
            var ids = results["AddressTable"].Select(d => d["Id"].AsString()).ToList();

            // Chunk 0's keys must appear before chunk 1's, which appear before chunk 2's, even though chunk 0
            // finished last.
            var expected = Enumerable.Range(1, 300).Select(i => $"K{i}").ToList();
            CollectionAssert.AreEqual(expected, ids, "Assembled results must follow deterministic chunk order.");
        }

        [TestMethod]
        public async Task FewerKeysThanOneChunk_SendsSingleCall_EvenWithHighParallelism()
        {
            var tracker = new ConcurrencyTracker();
            SetupTrackedResponses(tracker);

            var batch = CreateBatchWithKeys("K", 42);
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 10 };

            await multiBatchGet.GetItemsAsync();

            Assert.AreEqual(1, tracker.TotalCalls);
            Assert.AreEqual(1, tracker.MaxObservedConcurrency);
        }

        [TestMethod]
        public async Task ParallelExecution_ExactChunkBoundary_ProducesCorrectCallCount()
        {
            var tracker = new ConcurrencyTracker();
            SetupTrackedResponses(tracker);

            // Exactly 200 keys => exactly 2 chunks, no partial trailing chunk.
            var batch = CreateBatchWithKeys("K", 200);
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 5 };

            await multiBatchGet.GetItemsAsync();

            Assert.AreEqual(2, tracker.TotalCalls);
        }

        [TestMethod]
        public async Task ParallelExecution_EachChunkCarriesAtMostMaxItems()
        {
            var perCallKeyCounts = new List<int>();
            var sync = new object();
            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((BatchGetItemRequest request, CancellationToken _) =>
                {
                    var count = request.RequestItems.Values.Sum(v => v.Keys.Count);
                    lock (sync) { perCallKeyCounts.Add(count); }
                    return EmptyResponse();
                });

            var batch = CreateBatchWithKeys("K", 250); // 100 + 100 + 50
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 8 };

            await multiBatchGet.GetItemsAsync();

            Assert.AreEqual(3, perCallKeyCounts.Count);
            Assert.IsTrue(perCallKeyCounts.All(c => c <= MultiBatchGet.MaxItemsPerCall));
            Assert.AreEqual(250, perCallKeyCounts.Sum());
        }

        #endregion

        #region UnprocessedKeys retry under parallelism

        [TestMethod]
        public async Task ParallelExecution_RetriesUnprocessedKeysPerChunk()
        {
            // Each key must be "seen" twice before it is returned: the first time a key appears in a request it
            // comes back as unprocessed, the second time it is processed. This exercises the per-chunk
            // UnprocessedKeys retry loop while several chunks are in flight concurrently. Tracking is per-key
            // (not per-request-first-key) because a retry request carries only the previously-unprocessed keys,
            // so its first key differs from the initial call's.
            var seenKeys = new HashSet<string>();
            var totalCalls = 0;
            var sync = new object();

            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((BatchGetItemRequest request, CancellationToken _) =>
                {
                    var ka = request.RequestItems["AddressTable"];

                    var processed = new List<Dictionary<string, AttributeValue>>();
                    var unprocessed = new List<Dictionary<string, AttributeValue>>();

                    lock (sync)
                    {
                        totalCalls++;
                        foreach (var key in ka.Keys)
                        {
                            var id = key["Id"].S;
                            if (seenKeys.Add(id))
                                unprocessed.Add(key); // first sighting => defer
                            else
                                processed.Add(key);   // second sighting => fulfill
                        }
                    }

                    var response = new BatchGetItemResponse
                    {
                        Responses = ToResponses(processed),
                        UnprocessedKeys = new Dictionary<string, KeysAndAttributes>()
                    };
                    if (unprocessed.Count > 0)
                        response.UnprocessedKeys["AddressTable"] = new KeysAndAttributes { Keys = unprocessed };

                    return response;
                });

            var batch = CreateBatchWithKeys("K", 300); // 3 chunks
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 3 };

            var results = await multiBatchGet.GetItemsAsync();

            // Every key must still be retrieved despite the unprocessed-key round trips, with no loss or dupes.
            Assert.AreEqual(300, results["AddressTable"].Count);
            Assert.AreEqual(300, results["AddressTable"].Select(d => d["Id"].AsString()).Distinct().Count());
            // 3 chunks x (initial call + at least one retry) => strictly more than one call per chunk.
            Assert.IsTrue(totalCalls >= 6, $"Expected at least 6 calls (3 chunks retried), saw {totalCalls}.");
        }

        #endregion

        #region Error and cancellation

        [TestMethod]
        public async Task ParallelExecution_ChunkFailure_SurfacesException()
        {
            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((BatchGetItemRequest request, CancellationToken _) =>
                {
                    var firstKey = request.RequestItems["AddressTable"].Keys[0]["Id"].S;
                    if (firstKey == "K201") // the 3rd chunk
                        throw new AmazonDynamoDBException("Simulated failure");
                    return EmptyResponse();
                });

            var batch = CreateBatchWithKeys("K", 500);
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 5 };

            await Assert.ThrowsExactlyAsync<AmazonDynamoDBException>(() => multiBatchGet.GetItemsAsync());
        }

        [TestMethod]
        public async Task ParallelExecution_CancellationRequested_Throws()
        {
            using var cts = new CancellationTokenSource();
            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .Returns(async (BatchGetItemRequest request, CancellationToken ct) =>
                {
                    cts.Cancel();
                    await Task.Delay(50, ct);
                    return EmptyResponse();
                });

            var batch = CreateBatchWithKeys("K", 500);
            var multiBatchGet = new MultiBatchGet { Batches = new List<DocumentBatchGet> { batch }, MaxParallelBatches = 5 };

            await Assert.ThrowsExactlyAsync<TaskCanceledException>(() => multiBatchGet.GetItemsAsync(cts.Token));
        }

        #endregion

        #region End-to-end through the document-model ExecuteAsync

        [TestMethod]
        public async Task DocumentBatchGet_ExecuteAsync_HonorsMaxParallelBatches()
        {
            var tracker = new ConcurrencyTracker();
            var gate = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
            SetupTrackedResponses(tracker, gate.Task);

            var batch = (DocumentBatchGet)table.CreateBatchGet();
            for (var i = 1; i <= 400; i++)
                batch.AddKey(new Primitive($"K{i}"));
            batch.MaxParallelBatches = 4;

            var execution = batch.ExecuteAsync();
            await tracker.WaitForConcurrencyAtLeast(4, TimeSpan.FromSeconds(5));
            gate.SetResult(true);
            await execution;

            Assert.AreEqual(4, tracker.TotalCalls);
            Assert.AreEqual(4, tracker.MaxObservedConcurrency);
        }

        [TestMethod]
        public async Task DocumentBatchGet_ExecuteAsync_DefaultIsSequential()
        {
            var tracker = new ConcurrencyTracker();
            SetupTrackedResponses(tracker);

            var batch = (DocumentBatchGet)table.CreateBatchGet();
            for (var i = 1; i <= 400; i++)
                batch.AddKey(new Primitive($"K{i}"));

            await batch.ExecuteAsync();

            Assert.AreEqual(4, tracker.TotalCalls);
            Assert.AreEqual(1, tracker.MaxObservedConcurrency);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Tracks live concurrency of BatchGetItemAsync calls: increments on entry, records the running max,
        /// decrements on exit. Lets tests assert both an upper bound (cap respected) and a lower bound
        /// (parallelism actually achieved).
        /// </summary>
        private sealed class ConcurrencyTracker
        {
            private int _current;
            private int _max;
            private int _total;
            private readonly object _sync = new object();

            public int MaxObservedConcurrency { get { lock (_sync) return _max; } }
            public int TotalCalls { get { lock (_sync) return _total; } }

            public void Enter()
            {
                lock (_sync)
                {
                    _current++;
                    _total++;
                    if (_current > _max) _max = _current;
                }
            }

            public void Exit()
            {
                lock (_sync) { _current--; }
            }

            public async Task WaitForConcurrencyAtLeast(int target, TimeSpan timeout)
            {
                var deadline = DateTime.UtcNow + timeout;
                while (DateTime.UtcNow < deadline)
                {
                    lock (_sync) { if (_current >= target) return; }
                    await Task.Delay(10);
                }
                lock (_sync)
                {
                    Assert.Fail($"Timed out waiting for {target} concurrent calls; peaked at {_max} (currently {_current}).");
                }
            }
        }

        private void SetupTrackedResponses(ConcurrencyTracker tracker, Task hold = null)
        {
            ddbClientMock
                .Setup(c => c.BatchGetItemAsync(It.IsAny<BatchGetItemRequest>(), It.IsAny<CancellationToken>()))
                .Returns(async (BatchGetItemRequest request, CancellationToken ct) =>
                {
                    tracker.Enter();
                    try
                    {
                        if (hold != null)
                            await hold.ConfigureAwait(false);
                        else
                            await Task.Yield();
                        return EmptyResponse();
                    }
                    finally
                    {
                        tracker.Exit();
                    }
                });
        }

        private static BatchGetItemResponse EmptyResponse()
        {
            return new BatchGetItemResponse
            {
                Responses = new Dictionary<string, List<Dictionary<string, AttributeValue>>>(),
                UnprocessedKeys = new Dictionary<string, KeysAndAttributes>()
            };
        }

        private static BatchGetItemResponse EchoResponse(BatchGetItemRequest request)
        {
            var ka = request.RequestItems["AddressTable"];
            return new BatchGetItemResponse
            {
                Responses = ToResponses(ka.Keys),
                UnprocessedKeys = new Dictionary<string, KeysAndAttributes>()
            };
        }

        private static Dictionary<string, List<Dictionary<string, AttributeValue>>> ToResponses(List<Dictionary<string, AttributeValue>> keys)
        {
            return new Dictionary<string, List<Dictionary<string, AttributeValue>>>
            {
                ["AddressTable"] = keys
                    .Select(k => new Dictionary<string, AttributeValue>
                    {
                        ["Id"] = new AttributeValue { S = k["Id"].S }
                    })
                    .ToList()
            };
        }

        private DocumentBatchGet CreateBatchWithKeys(string keyPrefix, int count)
        {
            var batch = (DocumentBatchGet)table.CreateBatchGet();
            for (var i = 1; i <= count; i++)
                batch.AddKey(new Primitive($"{keyPrefix}{i}"));
            return batch;
        }

        private static Table CreateTable(IAmazonDynamoDB client, string tableName)
        {
            var config = new TableConfig(tableName);
            var table = new Table(client, config);

            table.ClearTableData();
            table.Keys.Add("Id", new KeyDescription { IsHash = true, Type = DynamoDBEntryType.String });
            table.HashKeys.Add("Id");

            return table;
        }

        #endregion
    }
}
