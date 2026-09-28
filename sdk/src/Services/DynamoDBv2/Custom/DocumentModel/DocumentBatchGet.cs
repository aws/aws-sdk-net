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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Telemetry.Tracing;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Interface for retrieving a batch of Documents from a single DynamoDB table.
    /// </summary>
    public partial interface IDocumentBatchGet
    {
        /// <summary>
        /// List of results retrieved from DynamoDB.
        /// Populated after Execute is called.
        /// </summary>
        public List<Document> Results { get; }

        /// <summary>
        /// List of attributes to retrieve.
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        /// <summary>
        /// Expression to specify the attributes to retrieve.
        /// </summary>
        public Expression ProjectionExpression { get; set; }

        /// <summary>
        /// Returns the total number of keys associated with this Batch request.
        /// </summary>
        public int TotalKeys { get; }

        /// <summary>
        /// If set to true, a consistent read is issued. Otherwise eventually-consistent is used.
        /// </summary>
        public bool ConsistentRead { get; set; }

        /// <summary>
        /// The maximum number of <c>BatchGetItem</c> service calls the SDK is allowed to have in flight
        /// at the same time when this request contains more keys than fit in a single call.
        /// </summary>
        /// <remarks>
        /// DynamoDB limits a single <c>BatchGetItem</c> call to 100 keys (and 16 MB). When you request more
        /// keys than that, the SDK automatically splits the work into multiple calls. By default those calls
        /// are made one after another. Set this property to a value greater than 1 to let the SDK send several
        /// of them at once, which can noticeably reduce the total time to retrieve a large number of items.
        /// <para>
        /// Leaving this property unset (or setting it to 1) preserves the default behavior of sending the calls
        /// sequentially. Values less than 1 are treated as 1.
        /// </para>
        /// <para>
        /// Choose this value with your table's read throughput in mind. A higher degree of parallelism drives
        /// reads at the table harder and in a shorter window, which makes request throttling more likely on
        /// tables that are not provisioned (or scaled) for the resulting rate. Start with a small value and
        /// increase it only if your table has the capacity to absorb the additional concurrent reads.
        /// </para>
        /// <para>
        /// This property only applies to the asynchronous execution path (<c>ExecuteAsync</c>). It has no effect
        /// on the synchronous <c>Execute</c> method, which always sends the calls sequentially.
        /// </para>
        /// </remarks>
        public int? MaxParallelBatches { get; set; }

        /// <summary>
        /// Add a single item to get, identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        void AddKey(Primitive hashKey);

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        /// <param name="rangeKey">Range key element of the item to get.</param>
        void AddKey(Primitive hashKey, Primitive rangeKey);

        /// <summary>
        /// Add a single item to get, identified by its key.
        /// </summary>
        /// <param name="key">Key of the item to get.</param>
        void AddKey(IDictionary<string, DynamoDBEntry> key);

        /// <summary>
        /// Creates a MultiTableDocumentBatchGet object that is a combination
        /// of the current DocumentBatchGet and the specified DocumentBatchGet.
        /// </summary>
        /// <param name="otherBatch">Other DocumentBatchGet object.</param>
        /// <returns>
        /// MultiTableDocumentBatchGet consisting of the two DocumentBatchGet
        /// objects.
        /// </returns>
        IMultiTableDocumentBatchGet Combine(IDocumentBatchGet otherBatch);
    }

    /// <summary>
    /// Class for retrieving a batch of Documents from a single DynamoDB table.
    /// </summary>
    public partial class DocumentBatchGet : IDocumentBatchGet
    {
        #region Internal properties

        internal Table TargetTable { get; private set; }
        internal List<Key> Keys { get; private set; }
        internal TracerProvider TracerProvider { get; private set; }

        #endregion


        #region Public properties

        /// <inheritdoc/>
        public List<Document> Results { get; internal set; }

        /// <inheritdoc/>
        public List<string> AttributesToGet { get; set; }

        /// <inheritdoc/>
        public Expression ProjectionExpression { get; set; }

        /// <inheritdoc/>
        public int TotalKeys => Keys.Count;

        /// <inheritdoc/>
        public bool ConsistentRead { get; set; }

        /// <inheritdoc/>
        public int? MaxParallelBatches { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a DocumentBatchGet instance for a specific table.
        /// </summary>
        /// <param name="targetTable">Table to get items from.</param>
        public DocumentBatchGet(Table targetTable)
        {
            TargetTable = targetTable;
            Keys = new List<Key>();
            TracerProvider = targetTable?.DDBClient?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        #endregion


        #region Public methods

        /// <inheritdoc/>
        public void AddKey(Primitive hashKey)
        {
            AddKey(hashKey, null);
        }

        /// <inheritdoc/>
        public void AddKey(Primitive hashKey, Primitive rangeKey)
        {
            Keys.Add(TargetTable.MakeKey(hashKey, rangeKey));
        }

        /// <inheritdoc/>
        public void AddKey(IDictionary<string, DynamoDBEntry> key)
        {
            Keys.Add(TargetTable.MakeKey(key));
        }

        /// <inheritdoc/>
        public IMultiTableDocumentBatchGet Combine(IDocumentBatchGet otherBatch)
        {
            return new MultiTableDocumentBatchGet(this, otherBatch);
        }

        #endregion


        #region Internal methods

        internal void ExecuteHelper()
        {
            MultiBatchGet resultsObject = new MultiBatchGet
            {
                Batches = new List<DocumentBatchGet>(1) { this }
            };

            var results = resultsObject.GetItemsHelper();

            List<Document> batchResults;
            Results = results.TryGetValue(TargetTable.TableName, out batchResults) ? batchResults : new List<Document>();
        }

        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiBatchGet resultsObject = new MultiBatchGet
            {
                Batches = new List<DocumentBatchGet>(1) { this },
                MaxParallelBatches = MaxParallelBatches
            };

            var results = await resultsObject.GetItemsHelperAsync(cancellationToken).ConfigureAwait(false);

            List<Document> batchResults;
            Results = results.TryGetValue(TargetTable.TableName, out batchResults) ? batchResults : new List<Document>();
        }

        internal void AddKey(Document document)
        {
            Keys.Add(TargetTable.MakeKey(document));
        }

        internal void AddKey(Key key)
        {
            Keys.Add(key);
        }

        #endregion
    }

    /// <summary>
    /// Interface for retrieving a batch of Documents from multiple DynamoDB tables.
    /// </summary>
    public partial interface IMultiTableDocumentBatchGet
    {
        /// <summary>
        /// List of DocumentBatchGet objects to include in the multi-table
        /// batch request.
        /// </summary>
        public List<IDocumentBatchGet> Batches { get; }

        /// <summary>
        /// Total number of primary keys in the multi-table batch request.
        /// </summary>
        public int TotalKeys { get; }

        /// <summary>
        /// Add a DocumentBatchGet object to the multi-table batch request.
        /// </summary>
        /// <param name="batch">DocumentBatchGet to add.</param>
        void AddBatch(IDocumentBatchGet batch);
    }

    /// <summary>
    /// Class for retrieving a batch of Documents from multiple DynamoDB tables.
    /// </summary>
    public partial class MultiTableDocumentBatchGet : IMultiTableDocumentBatchGet
    {
        #region Properties

        internal TracerProvider TracerProvider { get; private set; }

        /// <inheritdoc/>
        public List<IDocumentBatchGet> Batches { get; private set; }

        /// <inheritdoc/>
        public int TotalKeys
        {
            get
            {
                int count = 0;
                foreach (var batch in Batches)
                {
                    count += batch.TotalKeys;
                }
                return count;
            }
        }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableDocumentBatchGet object from a number of
        /// DocumentBatchGet objects.
        /// </summary>
        /// <param name="batches">Collection of DocumentBatchGet objects.</param>
        public MultiTableDocumentBatchGet(params IDocumentBatchGet[] batches)
        {
            if (batches == null)
                throw new ArgumentNullException("batches");

            Batches = new List<IDocumentBatchGet>(batches);
            TracerProvider = GetTracerProvider(Batches);
        }

        #endregion


        #region Public methods

        /// <inheritdoc/>
        public void AddBatch(IDocumentBatchGet batch)
        {
            Batches.Add(batch);
        }

        #endregion

        #region Internal methods

        internal void ExecuteHelper()
        {
            var errMsg = $"All {nameof(IDocumentBatchGet)} objects must be of type {nameof(DocumentBatchGet)}";
            var docBatches = Batches.Select(x => x as DocumentBatchGet ?? throw new InvalidOperationException(errMsg)).ToList();
            MultiBatchGet resultsObject = new MultiBatchGet
            {
                Batches = docBatches
            };

            var results = resultsObject.GetItemsHelper();

            foreach (var batch in docBatches)
            {
                List<Document> batchResults;
                if (results.TryGetValue(batch.TargetTable.TableName, out batchResults))
                {
                    batch.Results = batchResults;
                }
                else
                {
                    batch.Results = new List<Document>();
                }
            }
        }

        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            var errMsg = $"All {nameof(IDocumentBatchGet)} objects must be of type {nameof(DocumentBatchGet)}";
            var docBatches = Batches.Select(x => x as DocumentBatchGet ?? throw new InvalidOperationException(errMsg)).ToList();
            MultiBatchGet resultsObject = new MultiBatchGet
            {
                Batches = docBatches
            };

            var results = await resultsObject.GetItemsHelperAsync(cancellationToken).ConfigureAwait(false);

            foreach (var batch in docBatches)
            {
                List<Document> batchResults;
                if (results.TryGetValue(batch.TargetTable.TableName, out batchResults))
                {
                    batch.Results = batchResults;
                }
                else
                {
                    batch.Results = new List<Document>();
                }
            }
        }

        #endregion

        private TracerProvider GetTracerProvider(List<IDocumentBatchGet> batches)
        {
            var tracerProvider = AWSConfigs.TelemetryProvider.TracerProvider;
            if (batches.Count > 0)
            {
                if (batches[0] is DocumentBatchGet documentBatchGet)
                {
                    tracerProvider = documentBatchGet.TracerProvider;
                }
            }
            return tracerProvider;
        }
    }

    /// <summary>
    /// Internal class for handling multi-table batch gets.
    /// </summary>
    internal class MultiBatchGet
    {
        /// <summary>
        /// Batches that comprise the current BatchGet operation
        /// </summary>
        public List<DocumentBatchGet> Batches { get; set; }

        /// <summary>
        /// The maximum number of <c>BatchGetItem</c> service calls to have in flight at the same time on the
        /// asynchronous execution path. When null or &lt;= 1 the calls are made sequentially (default behavior).
        /// </summary>
        public int? MaxParallelBatches { get; set; }

        /// <summary>
        /// Maximum number of items that can be sent in a single BatchGet request
        /// </summary>
        public const int MaxItemsPerCall = 100;

        /// <summary>
        /// Gets items configured in Batches from the server
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<Document>> GetItems()
        {
            return GetItemsHelper();
        }

        /// <summary>
        /// Gets items configured in Batches from the server asynchronously
        /// </summary>
        /// <returns></returns>
        public Task<Dictionary<string, List<Document>>> GetItemsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetItemsHelperAsync(cancellationToken);
        }

        internal async Task<Dictionary<string, List<Document>>> GetItemsHelperAsync(CancellationToken cancellationToken)
        {
            var results = await GetAttributeItemsAsync(cancellationToken).ConfigureAwait(false);

            var itemsAsDocuments = new Dictionary<string, List<Document>>(results.RetrievedItems.Count, StringComparer.Ordinal);
            foreach (var kvp in results.RetrievedItems)
            {
                var tableName = kvp.Key;
                var table = results.TargetTables[tableName];

                List<Document> documents = new List<Document>(kvp.Value.Count);
                foreach (var dictionary in kvp.Value)
                {
                    documents.Add(table.FromAttributeMap(dictionary));
                }
                itemsAsDocuments[kvp.Key] = documents;
            }

            return itemsAsDocuments;
        }

        internal Dictionary<string, List<Document>> GetItemsHelper()
        {
            var results = GetAttributeItems();

            var itemsAsDocuments = new Dictionary<string, List<Document>>(results.RetrievedItems.Count, StringComparer.Ordinal);
            foreach (var kvp in results.RetrievedItems)
            {
                var tableName = kvp.Key;
                var table = results.TargetTables[tableName];

                List<Document> documents = new List<Document>(kvp.Value.Count);
                foreach (var dictionary in kvp.Value)
                {
                    documents.Add(table.FromAttributeMap(dictionary));
                }
                itemsAsDocuments[kvp.Key] = documents;
            }

            return itemsAsDocuments;
        }

        private async Task<Results> GetAttributeItemsAsync(CancellationToken cancellationToken)
        {
            var results = new Results(Batches);
            if (Batches == null || Batches.Count == 0)
                return results;

            // use client from the table from the first batch
            var firstBatch = this.Batches[0];
            var targetTable = firstBatch.TargetTable;
            var clientToUse = targetTable.DDBClient;

            // A value <= 1 (or unset) preserves the historical sequential behavior. Anything higher opts in to
            // sending multiple BatchGetItem calls concurrently, bounded by the requested degree of parallelism.
            // Values less than 1 fall through to the sequential path below (the <= 1 check covers them), so the
            // parallel path only ever sees a degree of parallelism of 2 or more.
            var maxParallelBatches = MaxParallelBatches.GetValueOrDefault(1);

            if (maxParallelBatches <= 1)
            {
                var convertedBatches = ConvertBatches();
                while (true)
                {
                    var nextSet = GetNextRequestItems(convertedBatches, MaxItemsPerCall);
                    if (nextSet.Count == 0)
                        break;

                    BatchGetItemRequest request = CreateRequest(nextSet);
                    targetTable.UpdateRequestUserAgentDetails(request, isAsync: true);

                    await CallUntilCompletionAsync(clientToUse, request, results, cancellationToken).ConfigureAwait(false);
                }

                return results;
            }

            // Parallel path: pre-compute every 100-key chunk up front so each unit of work is independent, then
            // fan them out under a semaphore that caps how many BatchGetItem calls are in flight at once. Each
            // chunk still runs its own UnprocessedKeys retry loop inside CallUntilCompletionAsync; the semaphore is
            // what prevents an unbounded fan-out (and the synchronized retry storm that would come with it).
            var requests = BuildAllRequests(targetTable);
            if (requests.Count == 0)
                return results;

            // Link a private token to the caller's token so that when any chunk faults we can cancel the rest.
            // Chunks that have not yet acquired the semaphore observe the cancellation and never dispatch their
            // BatchGetItem call, so a batch-wide failure (for example ResourceNotFoundException or a validation
            // error) does not keep consuming read capacity on every remaining chunk. Chunks already in flight run
            // to completion. This keeps the parallel path's failure cost closer to the sequential path, which
            // stops at the first faulting chunk.
            using (var throttle = new SemaphoreSlim(maxParallelBatches, maxParallelBatches))
            using (var failFast = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
            {
                var tasks = new List<Task<Results>>(requests.Count);
                foreach (var request in requests)
                {
                    tasks.Add(ExecuteRequestAsync(clientToUse, request, throttle, failFast, cancellationToken));
                }

                // Await all chunks. Task.WhenAll completes only after every chunk has finished; if one or more
                // chunks fault, its Task aggregates all of their exceptions, and awaiting it rethrows the first
                // of those. Any capacity already consumed by chunks that completed before a failure is expected
                // and matches BatchGetItem's at-least-partial execution semantics.
                var chunkResults = await Task.WhenAll(tasks).ConfigureAwait(false);

                // Merge in deterministic chunk order so the assembled result list is stable regardless of the
                // (non-deterministic) order in which the parallel calls actually completed.
                foreach (var chunkResult in chunkResults)
                {
                    foreach (var kvp in chunkResult.RetrievedItems)
                    {
                        results.Add(kvp.Key, kvp.Value);
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Materializes every 100-key <see cref="BatchGetItemRequest"/> needed to satisfy the configured batches.
        /// Used by the parallel execution path so each request can be dispatched as an independent unit of work.
        /// </summary>
        private List<BatchGetItemRequest> BuildAllRequests(Table targetTable)
        {
            var convertedBatches = ConvertBatches();
            var requests = new List<BatchGetItemRequest>();
            while (true)
            {
                var nextSet = GetNextRequestItems(convertedBatches, MaxItemsPerCall);
                if (nextSet.Count == 0)
                    break;

                BatchGetItemRequest request = CreateRequest(nextSet);
                targetTable.UpdateRequestUserAgentDetails(request, isAsync: true);
                requests.Add(request);
            }

            return requests;
        }

        /// <summary>
        /// Runs a single chunk request (including its UnprocessedKeys retry loop) into a private
        /// <see cref="Results"/> instance while holding a slot on the concurrency-limiting semaphore. Using a
        /// per-chunk result avoids any shared mutable state across the concurrent calls; callers merge the
        /// returned results afterwards.
        /// </summary>
        private async Task<Results> ExecuteRequestAsync(IAmazonDynamoDB client, BatchGetItemRequest request, SemaphoreSlim throttle, CancellationTokenSource failFast, CancellationToken cancellationToken)
        {
            try
            {
                // Wait on the linked (fail-fast) token so a chunk still queued behind the semaphore is released
                // immediately once another chunk has faulted, rather than acquiring the semaphore and dispatching
                // a call that is about to be discarded.
                await throttle.WaitAsync(failFast.Token).ConfigureAwait(false);
            }
            catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                // Cancellation came from a sibling chunk's failure (fail-fast), not from the caller. Return an
                // empty result so this discarded chunk does not surface its own OperationCanceledException through
                // Task.WhenAll and mask the original fault. If the caller cancelled, the exception is allowed to
                // propagate (the when-filter above only swallows the internal fail-fast case).
                return new Results(Batches);
            }

            try
            {
                var chunkResults = new Results(Batches);
                await CallUntilCompletionAsync(client, request, chunkResults, cancellationToken).ConfigureAwait(false);
                return chunkResults;
            }
            catch
            {
                // Signal sibling chunks that have not yet dispatched to stop. We do not swallow the exception;
                // it still propagates through Task.WhenAll so the caller sees the original failure.
                failFast.Cancel();
                throw;
            }
            finally
            {
                throttle.Release();
            }
        }

        private Results GetAttributeItems()
        {
            var results = new Results(Batches);
            if (Batches == null || Batches.Count == 0)
                return results;

            // use client from the table from the first batch
            var firstBatch = this.Batches[0];
            var targetTable = firstBatch.TargetTable;
            var clientToUse = targetTable.DDBClient;

            var convertedBatches = ConvertBatches();
            while (true)
            {
                var nextSet = GetNextRequestItems(convertedBatches, MaxItemsPerCall);
                if (nextSet.Count == 0)
                    break;

                BatchGetItemRequest request = CreateRequest(nextSet);
                targetTable.UpdateRequestUserAgentDetails(request, isAsync: false);

                CallUntilCompletion(clientToUse, request, results);
            }

            return results;
        }

        private static void CallUntilCompletion(IAmazonDynamoDB client, BatchGetItemRequest request, Results allResults)
        {
#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var internalClient = client as AmazonDynamoDBClient;
            if (internalClient == null)
            {
                throw new InvalidOperationException("Calling the synchronous DocumentBatchGet.Execute() from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when calling ExecuteAsync instead.");
            }
#else
            var internalClient = client;
#endif
            do
            {
                var serviceResponse = internalClient.BatchGetItem(request);

                foreach (var kvp in serviceResponse.Responses)
                {
                    var tableName = kvp.Key;
                    var items = kvp.Value;

                    allResults.Add(tableName, items);
                }
                request.RequestItems = serviceResponse.UnprocessedKeys;
            } while (request.RequestItems.Count > 0);
        }

        private static async Task CallUntilCompletionAsync(IAmazonDynamoDB client, BatchGetItemRequest request, Results allResults, CancellationToken cancellationToken)
        {
            do
            {
                var serviceResponse = await client.BatchGetItemAsync(request, cancellationToken).ConfigureAwait(false);

                foreach (var kvp in serviceResponse.Responses)
                {
                    var tableName = kvp.Key;
                    var items = kvp.Value;

                    allResults.Add(tableName, items);
                }
                request.RequestItems = serviceResponse.UnprocessedKeys;
            } while (request.RequestItems.Count > 0);
        }

        private static BatchGetItemRequest CreateRequest(Dictionary<string, RequestSet> set)
        {
            BatchGetItemRequest request = new BatchGetItemRequest();

            var requestItems = new Dictionary<string, KeysAndAttributes>(set.Count);
            foreach (var kvp in set)
            {
                var tableName = kvp.Key;
                var requestSet = kvp.Value;

                if (requestSet.Batch.ProjectionExpression is { IsSet: true } &&
                    requestSet.Batch.AttributesToGet is { Count: > 0 }) 
                {
                    throw new  InvalidOperationException($"BatchGetItem request for table {tableName} contains both ProjectionExpression and AttributesToGet, which is not allowed. Please specify only one of these properties.");
                }

                var keys = new KeysAndAttributes
                {
                    Keys = requestSet.GetItems(),
                    ConsistentRead = requestSet.Batch.ConsistentRead
                };

                if (requestSet.Batch.ProjectionExpression is { IsSet: true })
                {
                    keys.ProjectionExpression = requestSet.Batch.ProjectionExpression.ExpressionStatement;
                    if (requestSet.Batch.ProjectionExpression.ExpressionAttributeNames?.Count > 0)
                        keys.ExpressionAttributeNames = requestSet.Batch.ProjectionExpression.ExpressionAttributeNames;
                }
                else
                {
                    keys.AttributesToGet = requestSet.Batch.AttributesToGet;
                }

                requestItems.Add(tableName, keys);
            }
            request.RequestItems = requestItems;

            return request;
        }

        private Dictionary<string, RequestSet> ConvertBatches()
        {
            var allItems = new Dictionary<string, RequestSet>(Batches?.Count ?? 0);
            if (Batches == null || Batches.Count == 0)
                return allItems;

            foreach (var batch in Batches)
            {
                var table = batch.TargetTable;
                var tableName = table.TableName;
                if (allItems.ContainsKey(tableName))
                    throw new AmazonDynamoDBException("More than one batch request against a single table is not supported.");

                if (batch.Keys != null && batch.Keys.Count > 0)
                {
                    var keysList = batch.Keys.Select((Key k) => k as Dictionary<string, AttributeValue>);
                    var keys = new RequestSet(keysList, batch);

                    allItems.Add(tableName, keys);
                }
            }

            return allItems;
        }

        private static Dictionary<string, RequestSet> GetNextRequestItems(Dictionary<string, RequestSet> getRequestsMap, int maxNumberOfItems)
        {
            int numberOfItems = 0;
            var nextItems = new Dictionary<string, RequestSet>(getRequestsMap.Count);
            foreach (var kvp in getRequestsMap)
            {
                if (numberOfItems >= maxNumberOfItems)
                    break;

                var tableName = kvp.Key;
                var getRequests = kvp.Value;
                if (getRequests.Count == 0)
                    continue;

                var partialRequests = getRequests.RemoveFromHead(maxNumberOfItems - numberOfItems);
                var partialRequestsList = new RequestSet(partialRequests, getRequests.Batch);

                nextItems[tableName] = partialRequestsList;
                numberOfItems += partialRequestsList.Count;
            }

            return nextItems;
        }

        private class RequestSet : QuickList<Dictionary<string, AttributeValue>>
        {
            public DocumentBatchGet Batch { get; private set; }

            public RequestSet(IEnumerable<Dictionary<string, AttributeValue>> items, DocumentBatchGet batch)
                : base(items)
            {
                Batch = batch;
            }
        }

        private class Results
        {
            public Dictionary<string, List<Dictionary<string, AttributeValue>>> RetrievedItems { get; private set; }
            public Dictionary<string, Table> TargetTables { get; private set; }

            public Results(IEnumerable<DocumentBatchGet> batches)
            {
                RetrievedItems = new Dictionary<string, List<Dictionary<string, AttributeValue>>>(StringComparer.Ordinal);
                TargetTables = new Dictionary<string, Table>(StringComparer.Ordinal);

                if (batches != null)
                {
                    foreach (var batch in batches)
                    {
                        var table = batch.TargetTable;
                        TargetTables[table.TableName] = table;
                    }
                }
            }

            public void Add(string tableName, List<Dictionary<string, AttributeValue>> items)
            {
                List<Dictionary<string, AttributeValue>> fetchedItems;
                if (!RetrievedItems.TryGetValue(tableName, out fetchedItems))
                {
                    fetchedItems = new List<Dictionary<string, AttributeValue>>();
                    RetrievedItems[tableName] = fetchedItems;
                }
                fetchedItems.AddRange(items);
            }
        }
    }
}
