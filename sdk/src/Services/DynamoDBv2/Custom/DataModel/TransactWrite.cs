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
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime.Telemetry.Tracing;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{

    /// <summary>
    /// Represents a non-generic interface for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public partial interface ITransactWrite
    {
    }

    /// <summary>
    /// Represents a generic interface for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public interface ITransactWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : ITransactWrite
    {
        /// <summary>
        /// Creates a MultiTableTransactWrite object that is a combination
        /// of the current TransactWrite and the specified TransactWrites.
        /// </summary>
        /// <param name="otherTransactionParts">Other TransactWrite objects.</param>
        /// <returns>
        /// MultiTableTransactWrite consisting of the multiple TransactWrite objects:
        /// the current TransactWrite object and the passed-in TransactWrite objects.
        /// </returns>
        MultiTableTransactWrite Combine(params TransactWrite[] otherTransactionParts);

        /// <summary>
        /// Add a number of items to be saved in the current transaction operation.
        /// </summary>
        /// <param name="values">Items to save.</param>
        void AddSaveItems(IEnumerable<T> values);

        /// <summary>
        /// Add a single item to be saved in the current transaction operation.
        /// </summary>
        /// <param name="item">Item to save.</param>
        void AddSaveItem(T item);

        /// <summary>
        /// Add a single item to be saved in the current transaction operation.
        /// Item is identified by its hash primary key and will be updated using the update expression provided.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        /// <param name="updateExpression">Update expression to use.</param>
        /// <param name="conditionExpression">Condition to check before the operation.</param>
        void AddSaveItem(object hashKey, Expression updateExpression, Expression conditionExpression = null);

        /// <summary>
        /// Add a single item to be saved in the current transaction operation.
        /// Item is identified by its hash-and-range primary key and will be updated using the update expression provided.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        /// <param name="rangeKey">Range key of the item to delete.</param>
        /// <param name="updateExpression">Update expression to use.</param>
        /// <param name="conditionExpression">Condition to check before the operation.</param>
        void AddSaveItem(object hashKey, object rangeKey, Expression updateExpression, Expression conditionExpression = null);

        /// <summary>
        /// Add a number of items to be deleted in the current transaction operation.
        /// </summary>
        /// <param name="values">Items to be deleted.</param>
        void AddDeleteItems(IEnumerable<T> values);

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// </summary>
        /// <param name="item">Item to be deleted.</param>
        void AddDeleteItem(T item);

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// Item is identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        void AddDeleteKey(object hashKey);

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// Item is identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        /// <param name="conditionExpression">Condition to check before the operation.</param>
        void AddDeleteKey(object hashKey, Expression conditionExpression);

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// Item is identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        /// <param name="rangeKey">Range key of the item to delete.</param>
        void AddDeleteKey(object hashKey, object rangeKey);

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// Item is identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        /// <param name="rangeKey">Range key of the item to delete.</param>
        /// <param name="conditionExpression">Condition to check before the operation.</param>
        void AddDeleteKey(object hashKey, object rangeKey, Expression conditionExpression);

        /// <summary>
        /// Add a single item to be version checked in the current transaction operation.
        /// The item must have a single property marked with the DynamoDBVersionAttribute.
        /// </summary>
        /// <param name="item">Item to be version checked.</param>
        void AddVersionCheckItem(T item);

        /// <summary>
        /// Add a number of items to be version checked in the current transaction operation.
        /// All items must have a single property marked with the DynamoDBVersionAttribute.
        /// </summary>
        /// <param name="items">Items to be version checked.</param>
        void AddVersionCheckItems(IEnumerable<T> items);

        /// <summary>
        /// Add a single item to be version checked in the current transaction operation.
        /// Item is identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to be version checked.</param>
        /// <param name="version">Version of the item.</param>
        void AddVersionCheckKey(object hashKey, object version);

        /// <summary>
        /// Add a single item to be version checked in the current transaction operation.
        /// Item is identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to be version checked.</param>
        /// <param name="rangeKey">Range key of the item to be version checked.</param>
        /// <param name="version">Version of the item.</param>
        void AddVersionCheckKey(object hashKey, object rangeKey, object version);
    }

    /// <summary>
    /// Represents a non-generic object for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public abstract partial class TransactWrite : ITransactWrite
    {
        internal DocumentTransactWrite DocumentTransaction { get; set; }

        internal TracerProvider TracerProvider { get; set; }

        internal abstract void PopulateObjects();
    }

    /// <summary>
    /// Represents a strongly-typed object for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public partial class TransactWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : TransactWrite, ITransactWrite<T>
    {
        private readonly DynamoDBContext _context;
        private readonly DynamoDBFlatConfig _config;
        private readonly ItemStorageConfig _storageConfig;
        private readonly List<DynamoDBContext.ObjectWithItemStorage> _objectItems = new();

        internal TransactWrite(DynamoDBContext context, DynamoDBFlatConfig config)
        {
            _context = context;
            _config = config;
            _storageConfig = context.StorageConfigCache.GetConfig<T>(config);
            Table table = _context.GetTargetTable(_storageConfig, _config);

            // table.CreateTransactWrite() return the IDocumentTransactWrite interface.
            // But since we rely on the internal behavior of DocumentTransactWrite, we instatiate it via the constructor.
            DocumentTransaction = new DocumentTransactWrite(table);

            TracerProvider = context?.Client?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        /// <inheritdoc/>
        public MultiTableTransactWrite Combine(params TransactWrite[] otherTransactionParts)
        {
            return new MultiTableTransactWrite(this, otherTransactionParts);
        }

        /// <inheritdoc/>
        public void AddSaveItems(IEnumerable<T> values)
        {
            if (values == null) return;

            foreach (T item in values)
            {
                AddSaveItem(item);
            }
        }

        /// <inheritdoc/>
        public void AddSaveItem(T item)
        {
            if (item == null) return;

            ItemStorage storage = _context.ObjectToItemStorageHelper(item, _storageConfig, _config, keysOnly: false, _config.IgnoreNullValues ?? false);
            if (storage == null) return;

            Expression conditionExpression = CreateConditionExpressionForVersion(storage);
            SetNewVersion(storage);

            AddDocumentTransaction(storage, conditionExpression);
            
            var objectItem = new DynamoDBContext.ObjectWithItemStorage
            {
                OriginalObject = item,
                ItemStorage = storage
            };
            _objectItems.Add(objectItem);
        }

        /// <inheritdoc/>
        public void AddSaveItem(object hashKey, Expression updateExpression, Expression conditionExpression = null)
        {
            AddSaveItem(hashKey, rangeKey: null, updateExpression, conditionExpression);
        }

        /// <inheritdoc/>
        public void AddSaveItem(object hashKey, object rangeKey, Expression updateExpression, Expression conditionExpression = null)
        {
            var operationConfig = conditionExpression != null
                ? new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = conditionExpression,
                    ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
                }
                : null;

            DocumentTransaction.AddDocumentToUpdateHelper(_context.MakeKey(hashKey, rangeKey, _storageConfig, _config), updateExpression, operationConfig);
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

            ItemStorage storage = _context.ObjectToItemStorageHelper(item, _storageConfig, _config, keysOnly: true, _config.IgnoreNullValues ?? false);
            if (storage == null) return;
            Expression conditionExpression = CreateConditionExpressionForVersion(storage);

            DocumentTransaction.AddItemToDelete(storage.Document, new TransactWriteItemOperationConfig
            {
                ConditionalExpression = conditionExpression,
                ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
            });
        }

        /// <inheritdoc/>
        public void AddDeleteKey(object hashKey)
        {
            AddDeleteKey(hashKey, conditionExpression: null);
        }

        /// <inheritdoc/>
        public void AddDeleteKey(object hashKey, Expression conditionExpression)
        {
            AddDeleteKey(hashKey, rangeKey: null, conditionExpression);
        }

        /// <inheritdoc/>
        public void AddDeleteKey(object hashKey, object rangeKey)
        {
            AddDeleteKey(hashKey, rangeKey, conditionExpression: null);
        }

        /// <inheritdoc/>
        public void AddDeleteKey(object hashKey, object rangeKey, Expression conditionExpression)
        {
            var operationConfig = conditionExpression != null
                ? new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = conditionExpression,
                    ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
                }
                : null;

            DocumentTransaction.AddKeyToDeleteHelper(_context.MakeKey(hashKey, rangeKey, _storageConfig, _config), operationConfig);
        }

        /// <inheritdoc/>
        public void AddVersionCheckItem(T item)
        {
            CheckUseVersioning();

            if (item == null) return;

            ItemStorage storage = _context.ObjectToItemStorageHelper(item, _storageConfig, _config, keysOnly: true, _config.IgnoreNullValues ?? false);
            if (storage == null) return;
            Expression conditionExpression = CreateConditionExpressionForVersion(storage);

            DocumentTransaction.AddItemToConditionCheck(storage.Document, new TransactWriteItemOperationConfig
            {
                ConditionalExpression = conditionExpression,
                ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
            });
        }

        /// <inheritdoc/>
        public void AddVersionCheckItems(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                AddVersionCheckItem(item);
            }
        }

        /// <inheritdoc/>
        public void AddVersionCheckKey(object hashKey, object version)
        {
            AddVersionCheckKey(hashKey, rangeKey: null, version);
        }

        /// <inheritdoc/>
        public void AddVersionCheckKey(object hashKey, object rangeKey, object version)
        {
            CheckUseVersioning();

            Key key = _context.MakeKey(hashKey, rangeKey, _storageConfig, _config);
            DynamoDBEntry versionEntry = _context.ToDynamoDBEntry(_storageConfig.VersionPropertyStorage, version, _config);
            Primitive versionPrimitive = versionEntry?.AsPrimitive();

            if (versionEntry != null && versionPrimitive == null)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Version property {0} must be Primitive.",
                    _storageConfig.VersionPropertyName));
            }

            ItemStorage storage = new ItemStorage(_storageConfig)
            {
                CurrentVersion = versionPrimitive
            };
            Expression conditionExpression = CreateConditionExpressionForVersion(storage);

            DocumentTransaction.AddKeyToConditionCheckHelper(key,
                new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = conditionExpression,
                    ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
                });
        }

        private void ExecuteHelper()
        {
            DocumentTransaction.ExecuteHelper();
            PopulateObjects();
        }

        private async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            await DocumentTransaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            PopulateObjects();
        }

        internal override void PopulateObjects()
        {
            foreach (var objectItem in _objectItems)
            {
                objectItem.PopulateObject(_context, _config);
            }
        }

        private bool ShouldUseVersioning()
        {
            var skipVersionCheck = _config.SkipVersionCheck ?? false;
            return !skipVersionCheck && _storageConfig.HasVersion;
        }

        private void CheckUseVersioning()
        {
            if (_config.SkipVersionCheck == true)
            {
                throw new InvalidOperationException(
                    "Using DynamoDBContextConfig.SkipVersionCheck property with true value is not supported for this operation.");
            }

            if (!_storageConfig.HasVersion)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Object {0} does not have a versioning field, which is not supported for this operation.",
                    typeof(T).Name));
            }
        }

        private DocumentModel.Expression CreateConditionExpressionForVersion(ItemStorage storage)
        {
            if (!ShouldUseVersioning()) return null;
            var conversionConfig = new DynamoDBEntry.AttributeConversionConfig(
                DocumentTransaction.TargetTable.Conversion,
                DocumentTransaction.TargetTable.IsEmptyStringValueEnabled);
            return DynamoDBContext.CreateConditionExpressionForVersion(storage, conversionConfig);
        }

        private void AddDocumentTransaction(ItemStorage storage, Expression conditionExpression)
        {
            var hashKeyPropertyNames = storage.Config.HashKeyPropertyNames;
            var rangeKeyPropertyNames = storage.Config.RangeKeyPropertyNames;

            var attributeNames = storage.Document.Keys.ToList();

            foreach (var keyPropertyName in hashKeyPropertyNames)
            {
                attributeNames.Remove(keyPropertyName);
            }

            foreach (var rangeKeyPropertyName in rangeKeyPropertyNames)
            {
                attributeNames.Remove(rangeKeyPropertyName);
            }

            // If there are no attributes left, we need to use PutItem
            // as UpdateItem requires at least one data attribute
            if (attributeNames.Any())
            {
                DocumentTransaction.AddDocumentToUpdate(storage.Document, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = conditionExpression,
                    ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
                });
            }
            else
            {
                DocumentTransaction.AddDocumentToPut(storage.Document, new TransactWriteItemOperationConfig
                {
                    ConditionalExpression = conditionExpression,
                    ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
                });
            }
        }

        private void SetNewVersion(ItemStorage storage)
        {
            if (!ShouldUseVersioning()) return;
            DynamoDBContext.SetNewVersion(storage);
        }
    }

    /// <summary>
    /// Interface for writing/deleting/version-checking multiple items in multiple DynamoDB tables,
    /// using multiple strongly-typed TransactWrite objects.
    /// </summary>
    public partial interface IMultiTableTransactWrite
    {
        /// <summary>
        /// Add a TransactWrite object to the multi-table transaction request.
        /// </summary>
        /// <param name="transactionPart">TransactWrite to add.</param>
        void AddTransactionPart(ITransactWrite transactionPart);
    }

    /// <summary>
    /// Class for writing/deleting/version-checking multiple items in multiple DynamoDB tables,
    /// using multiple strongly-typed TransactWrite objects.
    /// </summary>
    public partial class MultiTableTransactWrite : IMultiTableTransactWrite
    {
        private readonly List<ITransactWrite> allTransactionParts;

        internal TracerProvider TracerProvider { get; set; }

        /// <summary>
        /// Constructs a MultiTableTransactWrite object from a number of
        /// TransactWrite objects
        /// </summary>
        /// <param name="transactionParts">Collection of TransactWrite objects</param>
        public MultiTableTransactWrite(params ITransactWrite[] transactionParts)
        {
            allTransactionParts = new List<ITransactWrite>(transactionParts);
            TracerProvider = GetTracerProvider(allTransactionParts);
        }

        internal MultiTableTransactWrite(ITransactWrite first, params ITransactWrite[] rest)
        {
            allTransactionParts = new List<ITransactWrite>();
            allTransactionParts.Add(first);
            allTransactionParts.AddRange(rest);
            TracerProvider = GetTracerProvider(allTransactionParts);
        }

        /// <inheritdoc/>
        public void AddTransactionPart(ITransactWrite transactionPart)
        {
            allTransactionParts.Add(transactionPart);
        }

        private void ExecuteHelper()
        {
            MultiTableDocumentTransactWrite transaction = new MultiTableDocumentTransactWrite();
            var errMsg = $"All transactionParts must be of type {nameof(TransactWrite)}";
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactWrite = transactionPart as TransactWrite ?? throw new InvalidOperationException(errMsg);
                transaction.AddTransactionPart(abstractTransactWrite.DocumentTransaction);
            }
            transaction.ExecuteHelper();
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactWrite = transactionPart as TransactWrite ?? throw new InvalidOperationException(errMsg);
                abstractTransactWrite.PopulateObjects();
            }
        }

        private async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiTableDocumentTransactWrite transaction = new MultiTableDocumentTransactWrite();
            var errMsg = $"All transactionParts must be of type {nameof(TransactWrite)}";
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactWrite = transactionPart as TransactWrite ?? throw new InvalidOperationException(errMsg);
                transaction.AddTransactionPart(abstractTransactWrite.DocumentTransaction);
            }
            await transaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            foreach (var transactionPart in allTransactionParts)
            {
                var abstractTransactWrite = transactionPart as TransactWrite ?? throw new InvalidOperationException(errMsg);
                abstractTransactWrite.PopulateObjects();
            }
        }

        private TracerProvider GetTracerProvider(List<ITransactWrite> allTransactionParts)
        {
            var tracerProvider = AWSConfigs.TelemetryProvider.TracerProvider;
            if (allTransactionParts.Count > 0)
            {
                var firstTransactionPart = allTransactionParts[0];
                if (firstTransactionPart is TransactWrite transactWrite)
                {
                    tracerProvider = transactWrite.TracerProvider;
                }
            }
            return tracerProvider;
        }
    }
}
