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
using System.Diagnostics.CodeAnalysis;

using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime.Telemetry.Tracing;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic interface for retrieving multiple items
    /// from a single DynamoDB table in a transaction.
    /// </summary>
    public partial interface ITransactGet
    {
        /// <summary>
        /// List of non-generic results retrieved from DynamoDB.
        /// </summary>
        /// <remarks>
        /// This is only populated after a call to Execute.
        /// </remarks>
        List<object> UntypedResults { get; }
    }

    /// <summary>
    /// Represents a generic interface for retrieving multiple items
    /// from a single DynamoDB table in a transaction.
    /// </summary>
    public interface ITransactGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : ITransactGet
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
        /// <param name="hashKey">Hash key of the item to get.</param>
        void AddKey(object hashKey);

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to get.</param>
        /// <param name="rangeKey">Range key of the item to get.</param>
        void AddKey(object hashKey, object rangeKey);

        /// <summary>
        /// Add a single item to get.
        /// </summary>
        /// <param name="keyObject">Object key of the item to get.</param>
        void AddKey(T keyObject);

        /// <summary>
        /// Add multiple items to get.
        /// </summary>
        /// <param name="keyObjects">Object keys of the items to get.</param>
        void AddKeys(IEnumerable<T> keyObjects);

        /// <summary>
        /// Creates a MultiTableTransactGet object that is a combination
        /// of the current TransactGet and the specified TransactGets.
        /// </summary>
        /// <param name="otherTransactionParts">Other TransactGet objects.</param>
        /// <returns>
        /// MultiTableTransactGet consisting of the multiple TransactGet objects:
        /// the current TransactGet object and the passed-in TransactGet objects.
        /// </returns>
        IMultiTableTransactGet Combine(params ITransactGet[] otherTransactionParts);
    }

    /// <summary>
    /// Represents a non-generic object for retrieving multiple items
    /// from a single DynamoDB table in a transaction.
    /// </summary>
    public abstract partial class TransactGet : ITransactGet
    {
        internal DocumentTransactGet DocumentTransaction { get; set; }

        internal TracerProvider TracerProvider { get; set; }

        internal abstract void PopulateResults();

        /// <inheritdoc/>
        public List<object> UntypedResults { get; } = new();
    }

    /// <summary>
    /// Represents a strongly-typed object for retrieving multiple items
    /// from a single DynamoDB table in a transaction.
    /// </summary>
    public partial class TransactGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : TransactGet, ITransactGet<T>

    {
        private readonly DynamoDBContext _context;
        private readonly DynamoDBFlatConfig _config;
        private readonly ItemStorageConfig _storageConfig;

        /// <inheritdoc/>
        public List<T> Results { get; } = new();

        /// <inheritdoc/>
        public void AddKey(object hashKey)
        {
            AddKey(hashKey, rangeKey: null);
        }

        /// <inheritdoc/>
        public void AddKey(object hashKey, object rangeKey)
        {
            Key key = _context.MakeKey(hashKey, rangeKey, _storageConfig, _config);
            DocumentTransaction.AddKeyHelper(key);
        }

        /// <inheritdoc/>
        public void AddKey(T keyObject)
        {
            Key key = _context.MakeKey(keyObject, _storageConfig, _config);
            DocumentTransaction.AddKeyHelper(key);
        }

        /// <inheritdoc/>
        public void AddKeys(IEnumerable<T> keyObjects)
        {
            foreach (var keyObject in keyObjects)
            {
                AddKey(keyObject);
            }
        }

        /// <inheritdoc/>
        public IMultiTableTransactGet Combine(params ITransactGet[] otherTransactionParts)
        {
            return new MultiTableTransactGet(this, otherTransactionParts);
        }

        internal TransactGet(DynamoDBContext context, DynamoDBFlatConfig config)
        {
            _context = context;
            _config = config;
            _storageConfig = context.StorageConfigCache.GetConfig<T>(config);
            var table = context.GetTargetTable(_storageConfig, config);

            // Table.CreateTransactGet() returns the IDocumentTransactGet interface.
            // But since we rely on the internal behavior of DocumentTransactGet, we instantiate it via the constructor.
            DocumentTransaction = new DocumentTransactGet(table);

            TracerProvider = context?.Client?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        private void ExecuteHelper()
        {
            DocumentTransaction.ExecuteHelper();
            PopulateResults();
        }

        private async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            await DocumentTransaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            PopulateResults();
        }

        internal override void PopulateResults()
        {
            UntypedResults.Clear();
            Results.Clear();
            foreach (var doc in DocumentTransaction.Results)
            {
                var result = _context.FromDocumentHelper<T>(doc, _config);
                UntypedResults.Add(result);
                Results.Add(result);
            }
        }
    }

    /// <summary>
    /// Interface for retrieving multiple items from multiple DynamoDB tables,
    /// using multiple strongly-typed TransactGet objects.
    /// </summary>
    public partial interface IMultiTableTransactGet
    {
        /// <summary>
        /// Add a TransactGet object to the multi-table transaction request.
        /// </summary>
        /// <param name="transactionPart">TransactGet to add.</param>
        public void AddTransactionPart(ITransactGet transactionPart);
    }

    /// <summary>
    /// Class for retrieving multiple items from multiple DynamoDB tables,
    /// using multiple strongly-typed TransactGet objects.
    /// </summary>
    public partial class MultiTableTransactGet : IMultiTableTransactGet
    {
        private readonly List<ITransactGet> allTransactionParts;

        internal TracerProvider TracerProvider { get; set; }

        /// <summary>
        /// Constructs a MultiTableTransactGet object from a number of
        /// TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Collection of TransactGet objects</param>
        public MultiTableTransactGet(params ITransactGet[] transactionParts)
        {
            allTransactionParts = new List<ITransactGet>(transactionParts);
            TracerProvider = GetTracerProvider(allTransactionParts);
        }

        internal MultiTableTransactGet(ITransactGet first, params ITransactGet[] rest)
        {
            allTransactionParts = new List<ITransactGet>();
            allTransactionParts.Add(first);
            allTransactionParts.AddRange(rest);
            TracerProvider = GetTracerProvider(allTransactionParts);
        }

        /// <inheritdoc/>
        public void AddTransactionPart(ITransactGet transactionPart)
        {
            allTransactionParts.Add(transactionPart);
        }

        private void ExecuteHelper()
        {
            MultiTableDocumentTransactGet transaction = new MultiTableDocumentTransactGet();
            var errorMsg = $"All transactionParts must be of type {nameof(TransactGet)}";
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactGet = transactionPart as TransactGet ?? throw new InvalidOperationException(errorMsg);
                transaction.AddTransactionPart(abstractTransactGet.DocumentTransaction);
            }
            transaction.ExecuteHelper();
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactGet = transactionPart as TransactGet ?? throw new InvalidOperationException(errorMsg);
                abstractTransactGet.PopulateResults();
            }
        }

        private async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiTableDocumentTransactGet transaction = new MultiTableDocumentTransactGet();
            var errorMsg = $"All transactionParts must be of type {nameof(TransactGet)}";
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactGet = transactionPart as TransactGet ?? throw new InvalidOperationException(errorMsg);
                transaction.AddTransactionPart(abstractTransactGet.DocumentTransaction);
            }
            await transaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactGet = transactionPart as TransactGet ?? throw new InvalidOperationException(errorMsg);
                abstractTransactGet.PopulateResults();
            }
        }

        private TracerProvider GetTracerProvider(List<ITransactGet> allTransactionParts)
        {
            var tracerProvider = AWSConfigs.TelemetryProvider.TracerProvider;
            if (allTransactionParts.Count > 0)
            {
                var firstTransactionPart = allTransactionParts[0];
                if (firstTransactionPart is TransactGet transactGet)
                {
                    tracerProvider = transactGet.TracerProvider;
                }
            }
            return tracerProvider;
        }
    }
}
