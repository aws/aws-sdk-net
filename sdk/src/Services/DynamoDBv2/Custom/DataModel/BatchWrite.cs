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
using System.Globalization;
using Amazon.Runtime.Telemetry.Tracing;
using System.Diagnostics.CodeAnalysis;
using ThirdParty.RuntimeBackports;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic interface for writing/deleting a batch of items
    /// in a single DynamoDB table
    /// </summary>
    public partial interface IBatchWrite
    {
    }

    /// <summary>
    /// Represents a generic interface for writing/deleting a batch of items
    /// in a single DynamoDB table
    /// </summary>
    public interface IBatchWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : IBatchWrite

    {
        /// <summary>
        /// Creates a MultiTableBatchWrite object that is a combination
        /// of the current BatchWrite and the specified BatchWrites
        /// </summary>
        /// <param name="otherBatches">Other BatchWrite objects</param>
        /// <returns>
        /// MultiTableBatchWrite consisting of the multiple BatchWrite objects:
        /// the current batch and the passed-in batches.
        /// </returns>
        IMultiTableBatchWrite Combine(params IBatchWrite[] otherBatches);

        /// <summary>
        /// Add a number of items to be put in the current batch operation
        /// </summary>
        /// <param name="values">Items to put</param>
        void AddPutItems(IEnumerable<T> values);

        /// <summary>
        /// Add a single item to be put in the current batch operation
        /// </summary>
        /// <param name="item"></param>
        void AddPutItem(T item);

        /// <summary>
        /// Add a number of items to be deleted in the current batch operation
        /// </summary>
        /// <param name="values">Items to be deleted</param>
        void AddDeleteItems(IEnumerable<T> values);

        /// <summary>
        /// Add a single item to be deleted in the current batch operation.
        /// </summary>
        /// <param name="item">Item to be deleted</param>
        void AddDeleteItem(T item);

        /// <summary>
        /// Add a single item to be deleted in the current batch operation.
        /// Item is identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete</param>
        void AddDeleteKey(object hashKey);

        /// <summary>
        /// Add a single item to be deleted in the current batch operation.
        /// Item is identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete</param>
        /// <param name="rangeKey">Range key of the item to delete</param>
        void AddDeleteKey(object hashKey, object rangeKey);
    }

    /// <summary>
    /// Represents a non-generic object for writing/deleting a batch of items
    /// in a single DynamoDB table
    /// </summary>
    public abstract partial class BatchWrite : IBatchWrite
    {
        internal DocumentBatchWrite DocumentBatch { get; set; }

        internal TracerProvider TracerProvider { get; set; }
    }

    /// <summary>
    /// Represents a strongly-typed object for writing/deleting a batch of items
    /// in a single DynamoDB table
    /// </summary>
    public partial class BatchWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : BatchWrite, IBatchWrite<T>
    {
        private readonly DynamoDBContext _context;
        private readonly DynamoDBFlatConfig _config;
        private readonly ItemStorageConfig _storageConfig;

        internal BatchWrite(DynamoDBContext context, DynamoDBFlatConfig config)
            : this(context, typeof(T), config)
        {
        }

        internal BatchWrite(DynamoDBContext context, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valuesType, DynamoDBFlatConfig config)
        {
            _context = context;
            _config = config;
            _storageConfig = context.StorageConfigCache.GetConfig(valuesType, config);

            if (_storageConfig.HasVersion)
            {
                if (!_config.SkipVersionCheck.GetValueOrDefault(false))
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                        "Object {0} has a versioning field, which is not supported for this operation. To ignore versioning, use the DynamoDBContextConfig.SkipVersionCheck property.",
                        valuesType.Name));
            }

            Table table = _context.GetTargetTable(_storageConfig, _config);

            // Table.CreateBatchWrite() returns the IDocumentBatchWrite interface.
            // But since we rely on the internal behavior of DocumentBatchWrite, we instantiate it via the constructor.
            DocumentBatch = new DocumentBatchWrite(table);

            TracerProvider = context?.Client?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        /// <inheritdoc/>
        public IMultiTableBatchWrite Combine(params IBatchWrite[] otherBatches)
        {
            return new MultiTableBatchWrite(this, otherBatches);
        }

        /// <inheritdoc/>
        public void AddPutItems(IEnumerable<T> values)
        {
            if (values == null) return;

            foreach (T item in values)
            {
                AddPutItem(item);
            }
        }

        /// <inheritdoc/>
        public void AddPutItem(T item)
        {
            if (item == null) return;

            ItemStorage storage = _context.ObjectToItemStorageHelper(item, _storageConfig, _config, keysOnly: false, ignoreNullValues: true);
            if (storage == null) return;
            DocumentBatch.AddDocumentToPut(storage.Document);
        }

        /// <inheritdoc/>
        public void AddDeleteItems(IEnumerable<T> values)
        {
            if (values == null) return;

            foreach (T item in values)
            {
                AddDeleteItem(item);
            }
        }

        /// <inheritdoc/>
        public void AddDeleteItem(T item)
        {
            if (item == null) return;

            ItemStorage storage = _context.ObjectToItemStorageHelper(item, _storageConfig, _config, keysOnly: true, ignoreNullValues: true);
            if (storage == null) return;
            DocumentBatch.AddItemToDelete(storage.Document);
        }

        /// <inheritdoc/>
        public void AddDeleteKey(object hashKey)
        {
            AddDeleteKey(hashKey, null);
        }

        /// <inheritdoc/>
        public void AddDeleteKey(object hashKey, object rangeKey)
        {
            DocumentBatch.AddKeyToDelete(_context.MakeKey(hashKey, rangeKey, _storageConfig, _config));
        }

        private void ExecuteHelper()
        {
            DocumentBatch.ExecuteHelper();
        }

        private Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            return DocumentBatch.ExecuteHelperAsync(cancellationToken);
        }
    }

    /// <summary>
    /// Interface for writing/deleting a batch of items in multiple DynamoDB tables,
    /// using multiple strongly-typed BatchWrite objects
    /// </summary>
    public partial interface IMultiTableBatchWrite
    {
        /// <summary>
        /// Add a BatchWrite object to the multi-table batch request
        /// </summary>
        /// <param name="batch">BatchWrite to add</param>
        void AddBatch(IBatchWrite batch);
    }

    /// <summary>
    /// Class for writing/deleting a batch of items in multiple DynamoDB tables,
    /// using multiple strongly-typed BatchWrite objects
    /// </summary>
    public partial class MultiTableBatchWrite : IMultiTableBatchWrite
    {
        private List<IBatchWrite> allBatches = new();

        internal TracerProvider TracerProvider { get; set; }

        /// <summary>
        /// Constructs a MultiTableBatchWrite object from a number of
        /// BatchWrite objects
        /// </summary>
        /// <param name="batches">Collection of BatchWrite objects</param>
        public MultiTableBatchWrite(params IBatchWrite[] batches)
        {
            allBatches = new List<IBatchWrite>(batches);
            TracerProvider = GetTracerProvider(allBatches);
        }

        internal MultiTableBatchWrite(IBatchWrite first, params IBatchWrite[] rest)
        {
            allBatches = new List<IBatchWrite>();
            allBatches.Add(first);
            allBatches.AddRange(rest);
            TracerProvider = GetTracerProvider(allBatches);
        }

        /// <inheritdoc/>
        public void AddBatch(IBatchWrite batch)
        {
            allBatches.Add(batch);
        }

        private void ExecuteHelper()
        {
            MultiTableDocumentBatchWrite superBatch = new MultiTableDocumentBatchWrite();
            var errorMsg = $"All batches must be of type {nameof(BatchWrite)}";
            foreach (var batch in allBatches)
            {
                var abstractBatch = batch as BatchWrite ?? throw new InvalidOperationException(errorMsg);
                superBatch.AddBatch(abstractBatch.DocumentBatch);
            }
            superBatch.ExecuteHelper();
        }

        private Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiTableDocumentBatchWrite superBatch = new MultiTableDocumentBatchWrite();
            var errorMsg = $"All batches must be of type {nameof(BatchWrite)}";
            foreach (var batch in allBatches)
            {
                var abstractBatch = batch as BatchWrite ?? throw new InvalidOperationException(errorMsg);
                superBatch.AddBatch(abstractBatch.DocumentBatch);
            }
            return superBatch.ExecuteHelperAsync(cancellationToken);
        }

        private TracerProvider GetTracerProvider(List<IBatchWrite> allBatches)
        {
            var tracerProvider = AWSConfigs.TelemetryProvider.TracerProvider;
            if (allBatches.Count > 0)
            {
                var firstBatch = allBatches[0];
                if (firstBatch is BatchWrite batchWrite)
                {
                    tracerProvider = batchWrite.TracerProvider;
                }
            }
            return tracerProvider;
        }
    }
}
