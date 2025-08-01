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
        /// Returns the total number of keys associated with this Batch request.
        /// </summary>
        public int TotalKeys { get; }

        /// <summary>
        /// If set to true, a consistent read is issued. Otherwise eventually-consistent is used.
        /// </summary>
        public bool ConsistentRead { get; set; }

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
        public int TotalKeys => Keys.Count;

        /// <inheritdoc/>
        public bool ConsistentRead { get; set; }

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
                Batches = new List<DocumentBatchGet> { this }
            };

            var results = resultsObject.GetItemsHelper();

            List<Document> batchResults;
            if (results.TryGetValue(TargetTable.TableName, out batchResults))
            {
                Results = batchResults;
            }
            else
            {
                Results = new List<Document>();
            }
        }

        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiBatchGet resultsObject = new MultiBatchGet
            {
                Batches = new List<DocumentBatchGet> { this }
            };

            var results = await resultsObject.GetItemsHelperAsync(cancellationToken).ConfigureAwait(false);

            List<Document> batchResults;
            if (results.TryGetValue(TargetTable.TableName, out batchResults))
            {
                Results = batchResults;
            }
            else
            {
                Results = new List<Document>();
            }
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

            var itemsAsDocuments = new Dictionary<string, List<Document>>(StringComparer.Ordinal);
            foreach (var kvp in results.RetrievedItems)
            {
                var tableName = kvp.Key;
                var table = results.TargetTables[tableName];

                List<Document> documents = new List<Document>();
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

            var itemsAsDocuments = new Dictionary<string, List<Document>>(StringComparer.Ordinal);
            foreach (var kvp in results.RetrievedItems)
            {
                var tableName = kvp.Key;
                var table = results.TargetTables[tableName];

                List<Document> documents = new List<Document>();
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

            var convertedBatches = ConvertBatches();
            while (true)
            {
                var nextSet = GetNextRequestItems(ref convertedBatches, MaxItemsPerCall);
                if (nextSet.Count == 0)
                    break;

                BatchGetItemRequest request = CreateRequest(nextSet);
                targetTable.UpdateRequestUserAgentDetails(request, isAsync: true);

                await CallUntilCompletionAsync(clientToUse, request, results, cancellationToken).ConfigureAwait(false);
            }

            return results;
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
                var nextSet = GetNextRequestItems(ref convertedBatches, MaxItemsPerCall);
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

            var requestItems = new Dictionary<string, KeysAndAttributes>();
            foreach (var kvp in set)
            {
                var tableName = kvp.Key;
                var requestSet = kvp.Value;

                var keys = new KeysAndAttributes
                {
                    Keys = requestSet.GetItems(),
                    ConsistentRead = requestSet.Batch.ConsistentRead,
                    AttributesToGet = requestSet.Batch.AttributesToGet
                };

                requestItems.Add(tableName, keys);
            }
            request.RequestItems = requestItems;

            return request;
        }

        private Dictionary<string, RequestSet> ConvertBatches()
        {
            var allItems = new Dictionary<string, RequestSet>();
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

        private static Dictionary<string, RequestSet> GetNextRequestItems(ref Dictionary<string, RequestSet> getRequestsMap, int maxNumberOfItems)
        {
            int numberOfItems = 0;
            var nextItems = new Dictionary<string, RequestSet>();
            List<string> keys = new List<string>(getRequestsMap.Keys);
            foreach (string tableName in keys)
            {
                if (numberOfItems >= maxNumberOfItems)
                    break;

                var getRequests = getRequestsMap[tableName];
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
