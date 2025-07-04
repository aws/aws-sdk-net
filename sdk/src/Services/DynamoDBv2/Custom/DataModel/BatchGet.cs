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
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime.Telemetry.Tracing;
using System.Diagnostics.CodeAnalysis;
using ThirdParty.RuntimeBackports;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic interface for retrieving a batch of items
    /// from a single DynamoDB table
    /// </summary>
    public partial interface IBatchGet
    {
        /// <summary>
        /// Returns the total number of keys associated with this Batch request.
        /// </summary>
        public int TotalKeys { get; }

        /// <summary>
        /// List of non-generic results retrieved from DynamoDB.
        /// </summary>
        /// <remarks>
        /// This is only populated after a call to Execute.
        /// </remarks>
        List<object> UntypedResults { get; }

        /// <summary>
        /// If set to true, a consistent read is issued. Otherwise eventually-consistent is used.
        /// </summary>
        /// <remarks>
        /// Refer to the <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// Read Consistency</see> topic in the DynamoDB Developer Guide for more information.
        /// </remarks>
        bool ConsistentRead { get; set; }
    }

    /// <summary>
    /// Represents a generic interface for retrieving a batch of items
    /// from a single DynamoDB table
    /// </summary>
    public interface IBatchGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : IBatchGet
    {
        /// <summary>
        /// List of generic results retrieved from DynamoDB.
        /// </summary>
        /// <remarks>
        /// This is only populated after a call to Execute.
        /// </remarks>
        List<T> Results { get; }

        /// <summary>
        /// Add a single item to get, identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to get</param>
        void AddKey(object hashKey);

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to get</param>
        /// <param name="rangeKey">Range key of the item to get</param>
        void AddKey(object hashKey, object rangeKey);

        /// <summary>
        /// Add a single item to get.
        /// </summary>
        /// <param name="keyObject">Object key of the item to get</param>
        void AddKey(T keyObject);

        /// <summary>
        /// Creates a MultiTableBatchGet object that is a combination
        /// of the current BatchGet and the specified BatchGets
        /// </summary>
        /// <param name="otherBatches">Other BatchGet objects</param>
        /// <returns>
        /// An interface with the ability to perform MultiTableBatchGet operations.
        /// </returns>
        IMultiTableBatchGet Combine(params IBatchGet[] otherBatches);
    }

    /// <summary>
    /// Represents a non-generic object for retrieving a batch of items
    /// from a single DynamoDB table
    /// </summary>
    public abstract partial class BatchGet : IBatchGet
    {
        internal DocumentBatchGet DocumentBatch { get; set; }

        internal TracerProvider TracerProvider { get; set; }

        internal abstract void CreateDocumentBatch();

        internal abstract void PopulateResults(List<Document> items);

        /// <inheritdoc/>
        public abstract int TotalKeys { get; }

        /// <inheritdoc/>
        public List<object> UntypedResults { get; } = new();

        /// <inheritdoc/>
        public bool ConsistentRead { get; set; }
    }

    /// <summary>
    /// Represents a strongly-typed object for retrieving a batch of items
    /// from a single DynamoDB table
    /// </summary>
    public partial class BatchGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : BatchGet, IBatchGet<T>
    {
        private readonly DynamoDBContext _context;
        private readonly DynamoDBFlatConfig _config;
        private readonly ItemStorageConfig _itemStorageConfig;
        private readonly List<Key> _keys = new();

        /// <inheritdoc/>
        public override int TotalKeys => _keys.Count;

        /// <inheritdoc/>
        public List<T> Results { get; } = new();

        /// <inheritdoc/>
        public void AddKey(object hashKey)
        {
            AddKey(hashKey, null);
        }

        /// <inheritdoc/>
        public void AddKey(object hashKey, object rangeKey)
        {
            Key key = _context.MakeKey(hashKey, rangeKey, _itemStorageConfig, _config);
            _keys.Add(key);
        }

        /// <inheritdoc/>
        public void AddKey(T keyObject)
        {
            Key key = _context.MakeKey(keyObject, _itemStorageConfig, _config);
            _keys.Add(key);
        }

        /// <inheritdoc/>
        public IMultiTableBatchGet Combine(params IBatchGet[] otherBatches)
        {
            return new MultiTableBatchGet(this, otherBatches);
        }

        internal BatchGet(DynamoDBContext context, DynamoDBFlatConfig config)
        {
            _context = context;
            _config = config;
            _itemStorageConfig = context.StorageConfigCache.GetConfig<T>(config);
            TracerProvider = context?.Client?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        private void ExecuteHelper()
        {
            CreateDocumentBatch();
            DocumentBatch.ExecuteHelper();
            PopulateResults(DocumentBatch.Results);
        }

        private async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            CreateDocumentBatch();
            await DocumentBatch.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            PopulateResults(DocumentBatch.Results);
        }

        internal override void CreateDocumentBatch()
        {
            var table = _context.GetTargetTable(_itemStorageConfig, _config);

            DocumentBatchGet docBatch = new DocumentBatchGet(table)
            {
                AttributesToGet = _itemStorageConfig.AttributesToGet,
                ConsistentRead = ConsistentRead
            };
            docBatch.Keys.AddRange(_keys);

            DocumentBatch = docBatch;
        }

        internal override void PopulateResults(List<Document> items)
        {
            UntypedResults.Clear();
            Results.Clear();
            foreach (var doc in items)
            {
                var item = _context.FromDocumentHelper<T>(doc, _config);
                Results.Add(item);
                UntypedResults.Add(item);
            }
        }
    }

    /// <summary>
    /// Interface for retrieving a batch of items from multiple DynamoDB tables,
    /// using multiple strongly-typed BatchGet objects
    /// </summary>
    public partial interface IMultiTableBatchGet
    {
        /// <summary>
        /// Gets the total number of primary keys to be loaded from DynamoDB,
        /// across all batches
        /// </summary>
        int TotalKeys { get; }

        /// <summary>
        /// Add a BatchGet object to the multi-table batch request
        /// </summary>
        /// <param name="batch">BatchGet to add</param>
        void AddBatch(IBatchGet batch);
    }

    /// <summary>
    /// Class for retrieving a batch of items from multiple DynamoDB tables,
    /// using multiple strongly-typed BatchGet objects
    /// </summary>
    public partial class MultiTableBatchGet : IMultiTableBatchGet
    {
        private List<IBatchGet> allBatches = new List<IBatchGet>();

        internal TracerProvider TracerProvider { get; set; }

        /// <summary>
        /// Constructs a MultiTableBatchGet object from a number of
        /// BatchGet objects
        /// </summary>
        /// <param name="batches">Collection of BatchGet objects</param>
        public MultiTableBatchGet(params IBatchGet[] batches)
        {
            allBatches = new List<IBatchGet>(batches);
            TracerProvider = GetTracerProvider(allBatches);
        }

        internal MultiTableBatchGet(IBatchGet first, params IBatchGet[] rest)
        {
            allBatches = new List<IBatchGet>();
            allBatches.Add(first);
            allBatches.AddRange(rest);
            TracerProvider = GetTracerProvider(allBatches);
        }

        /// <inheritdoc/>
        public int TotalKeys
        {
            get
            {
                int count = 0;
                foreach (var batch in allBatches)
                {
                    count += batch.TotalKeys;
                }
                return count;
            }
        }

        /// <inheritdoc/>
        public void AddBatch(IBatchGet batch)
        {
            allBatches.Add(batch);
        }

        private void ExecuteHelper()
        {
            MultiTableDocumentBatchGet superBatch = new MultiTableDocumentBatchGet();
            var errorMsg = $"All batches must be of type {nameof(BatchGet)}";
            foreach (var batch in allBatches)
            {
                var abstractBatch = batch as BatchGet ?? throw new InvalidOperationException(errorMsg);
                abstractBatch.CreateDocumentBatch();
                superBatch.AddBatch(abstractBatch.DocumentBatch);
            }

            superBatch.ExecuteHelper();

            foreach (var batch in allBatches)
            {
                var abstractBatch = batch as BatchGet ?? throw new InvalidOperationException(errorMsg);
                abstractBatch.PopulateResults(abstractBatch.DocumentBatch.Results);
            }
        }

        private async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiTableDocumentBatchGet superBatch = new MultiTableDocumentBatchGet();
            var errorMsg = $"All batches must be of type {nameof(BatchGet)}";
            foreach (var batch in allBatches)
            {
                var abstractBatch = batch as BatchGet ?? throw new InvalidOperationException(errorMsg);
                abstractBatch.CreateDocumentBatch();
                superBatch.AddBatch(abstractBatch.DocumentBatch);
            }

            await superBatch.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);

            foreach (var batch in allBatches)
            {
                var abstractBatch = batch as BatchGet ?? throw new InvalidOperationException(errorMsg);
                abstractBatch.PopulateResults(abstractBatch.DocumentBatch.Results);
            }
        }

        private TracerProvider GetTracerProvider(List<IBatchGet> allBatches)
        {
            var tracerProvider = AWSConfigs.TelemetryProvider.TracerProvider;
            if (allBatches.Count > 0)
            {
                var firstBatch = allBatches[0];
                if (firstBatch is BatchGet batchGet)
                {
                    tracerProvider = batchGet.TracerProvider;
                }
            }
            return tracerProvider;
        }
    }
}
