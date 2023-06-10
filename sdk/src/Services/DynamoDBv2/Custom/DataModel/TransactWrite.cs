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
using System.Globalization;
#if AWS_ASYNC_API
using System.Threading;
using System.Threading.Tasks;
#endif
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic object for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public abstract partial class TransactWrite
    {
        #region Internal/protected properties

        internal DynamoDBContext Context { get; set; }
        internal DynamoDBFlatConfig Config { get; set; }
        internal DocumentTransactWrite DocumentTransaction { get; set; }

        #endregion


        #region Constructor

        internal TransactWrite(DynamoDBContext context, DynamoDBFlatConfig config)
        {
            Context = context;
            Config = config;
        }

        #endregion


        #region Protected methods

        /// <summary>
        /// Executes a server call to write/delete/version-check the items requested in a transaction.
        /// </summary>
        protected internal abstract void ExecuteHelper();

#if AWS_ASYNC_API
        /// <summary>
        /// Executes an asynchronous server call to write/delete/version-check the items requested in a transaction.
        /// </summary>
        protected internal abstract Task ExecuteHelperAsync(CancellationToken cancellationToken);
#endif
        #endregion


        #region Internal methods

        internal abstract void PopulateObjects();

        #endregion
    }

    /// <summary>
    /// Represents a strongly-typed object for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public class TransactWrite<T> : TransactWrite
    {
        #region Public Combine methods

        /// <summary>
        /// Creates a MultiTableTransactWrite object that is a combination
        /// of the current TransactWrite and the specified TransactWrites.
        /// </summary>
        /// <param name="otherTransactionParts">Other TransactWrite objects.</param>
        /// <returns>
        /// MultiTableTransactWrite consisting of the multiple TransactWrite objects:
        /// the current TransactWrite object and the passed-in TransactWrite objects.
        /// </returns>
        public MultiTableTransactWrite Combine(params TransactWrite[] otherTransactionParts)
        {
            return new MultiTableTransactWrite(this, otherTransactionParts);
        }

        #endregion


        #region Public Save methods

        /// <summary>
        /// Add a number of items to be saved in the current transaction operation.
        /// </summary>
        /// <param name="values">Items to save.</param>
        public void AddSaveItems(IEnumerable<T> values)
        {
            if (values == null) return;

            foreach (T item in values)
            {
                AddSaveItem(item);
            }
        }

        /// <summary>
        /// Add a single item to be saved in the current transaction operation.
        /// </summary>
        /// <param name="item">Item to save.</param>
        public void AddSaveItem(T item)
        {
            if (item == null) return;

            ItemStorage storage = Context.ObjectToItemStorageHelper(item, StorageConfig, Config, keysOnly: false, Config.IgnoreNullValues ?? false);
            if (storage == null) return;
            Expression conditionExpression = CreateConditionExpressionForVersion(storage);
            SetNewVersion(storage);

            DocumentTransaction.AddDocumentToUpdate(storage.Document, new TransactWriteItemOperationConfig
            {
                ConditionalExpression = conditionExpression,
                ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
            });
            var objectItem = new DynamoDBContext.ObjectWithItemStorage
            {
                OriginalObject = item,
                ItemStorage = storage
            };
            objectItems.Add(objectItem);
        }

        #endregion


        #region Public Delete methods

        /// <summary>
        /// Add a number of items to be deleted in the current transaction operation.
        /// </summary>
        /// <param name="values">Items to be deleted.</param>
        public void AddDeleteItems(IEnumerable<T> values)
        {
            if (values == null) return;

            foreach (T item in values)
            {
                AddDeleteItem(item);
            }
        }

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// </summary>
        /// <param name="item">Item to be deleted.</param>
        public void AddDeleteItem(T item)
        {
            if (item == null) return;

            ItemStorage storage = Context.ObjectToItemStorageHelper(item, StorageConfig, Config, keysOnly: true, Config.IgnoreNullValues ?? false);
            if (storage == null) return;
            Expression conditionExpression = CreateConditionExpressionForVersion(storage);

            DocumentTransaction.AddItemToDelete(storage.Document, new TransactWriteItemOperationConfig
            {
                ConditionalExpression = conditionExpression,
                ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
            });
        }

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// Item is identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        public void AddDeleteKey(object hashKey)
        {
            AddDeleteKey(hashKey, rangeKey: null);
        }

        /// <summary>
        /// Add a single item to be deleted in the current transaction operation.
        /// Item is identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete.</param>
        /// <param name="rangeKey">Range key of the item to delete.</param>
        public void AddDeleteKey(object hashKey, object rangeKey)
        {
            DocumentTransaction.AddKeyToDeleteHelper(Context.MakeKey(hashKey, rangeKey, StorageConfig, Config));
        }

        #endregion


        #region Public VersionCheck methods

        /// <summary>
        /// Add a single item to be version checked in the current transaction operation.
        /// The item must have a single property marked with the DynamoDBVersionAttribute.
        /// </summary>
        /// <param name="item">Item to be version checked.</param>
        public void AddVersionCheckItem(T item)
        {
            CheckUseVersioning();

            if (item == null) return;

            ItemStorage storage = Context.ObjectToItemStorageHelper(item, StorageConfig, Config, keysOnly: true, Config.IgnoreNullValues ?? false);
            if (storage == null) return;
            Expression conditionExpression = CreateConditionExpressionForVersion(storage);

            DocumentTransaction.AddItemToConditionCheck(storage.Document, new TransactWriteItemOperationConfig
            {
                ConditionalExpression = conditionExpression,
                ReturnValuesOnConditionCheckFailure = DocumentModel.ReturnValuesOnConditionCheckFailure.None
            });
        }

        /// <summary>
        /// Add a number of items to be version checked in the current transaction operation.
        /// All items must have a single property marked with the DynamoDBVersionAttribute.
        /// </summary>
        /// <param name="items">Items to be version checked.</param>
        public void AddVersionCheckItems(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                AddVersionCheckItem(item);
            }
        }

        /// <summary>
        /// Add a single item to be version checked in the current transaction operation.
        /// Item is identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to be version checked.</param>
        /// <param name="version">Version of the item.</param>
        public void AddVersionCheckKey(object hashKey, object version)
        {
            AddVersionCheckKey(hashKey, rangeKey: null, version);
        }

        /// <summary>
        /// Add a single item to be version checked in the current transaction operation.
        /// Item is identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to be version checked.</param>
        /// <param name="rangeKey">Range key of the item to be version checked.</param>
        /// <param name="version">Version of the item.</param>
        public void AddVersionCheckKey(object hashKey, object rangeKey, object version)
        {
            CheckUseVersioning();

            Key key = Context.MakeKey(hashKey, rangeKey, StorageConfig, Config);
            DynamoDBEntry versionEntry = Context.ToDynamoDBEntry(StorageConfig.VersionPropertyStorage, version, Config);
            Primitive versionPrimitive = versionEntry?.AsPrimitive();

            if (versionEntry != null && versionPrimitive == null)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Version property {0} must be Primitive.",
                    StorageConfig.VersionPropertyName));
            }

            ItemStorage storage = new ItemStorage(StorageConfig)
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

        #endregion


        #region Constructor

        internal TransactWrite(DynamoDBContext context, DynamoDBFlatConfig config)
            : base(context, config)
        {
            StorageConfig = context.StorageConfigCache.GetConfig<T>(config);
            Table table = Context.GetTargetTable(StorageConfig, Config);
            DocumentTransaction = table.CreateTransactWrite();
        }

        #endregion


        #region Internal/protected/private members

        private readonly List<DynamoDBContext.ObjectWithItemStorage> objectItems = new List<DynamoDBContext.ObjectWithItemStorage>();

        internal ItemStorageConfig StorageConfig { get; set; }

        /// <summary>
        /// Executes a server call to write/delete/version-check the items requested in a transaction.
        /// </summary>
        protected internal override void ExecuteHelper()
        {
            DocumentTransaction.ExecuteHelper();
            PopulateObjects();
        }

#if AWS_ASYNC_API
        /// <summary>
        /// Executes an asynchronous server call to write/delete/version-check the items requested in a transaction.
        /// </summary>
        protected internal override async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            await DocumentTransaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            PopulateObjects();
        }
#endif

        internal override void PopulateObjects()
        {
            foreach (var objectItem in objectItems)
            {
                objectItem.PopulateObject(Context, Config);
            }
        }

        private bool ShouldUseVersioning()
        {
            var skipVersionCheck = Config.SkipVersionCheck ?? false;
            return !skipVersionCheck && StorageConfig.HasVersion;
        }

        private void CheckUseVersioning()
        {
            if (Config.SkipVersionCheck == true)
            {
                throw new InvalidOperationException(
                    "Using DynamoDBContextConfig.SkipVersionCheck property with true value is not supported for this operation.");
            }

            if (!StorageConfig.HasVersion)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Object {0} does not have a versioning field, which is not supported for this operation.",
                    typeof(T).Name));
            }
        }

        private Expression CreateConditionExpressionForVersion(ItemStorage storage)
        {
            if (!ShouldUseVersioning()) return null;
            var conversionConfig = new DynamoDBEntry.AttributeConversionConfig(
                DocumentTransaction.TargetTable.Conversion,
                DocumentTransaction.TargetTable.IsEmptyStringValueEnabled);
            return DynamoDBContext.CreateConditionExpressionForVersion(storage, conversionConfig);
        }

        private void SetNewVersion(ItemStorage storage)
        {
            if (!ShouldUseVersioning()) return;
            DynamoDBContext.SetNewVersion(storage);
        }

        #endregion
    }

    /// <summary>
    /// Class for writing/deleting/version-checking multiple items in multiple DynamoDB tables,
    /// using multiple strongly-typed TransactWrite objects.
    /// </summary>
    public partial class MultiTableTransactWrite
    {
        #region Private members

        private readonly List<TransactWrite> allTransactionParts;

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableTransactWrite object from a number of
        /// TransactWrite objects
        /// </summary>
        /// <param name="transactionParts">Collection of TransactWrite objects</param>
        public MultiTableTransactWrite(params TransactWrite[] transactionParts)
        {
            allTransactionParts = new List<TransactWrite>(transactionParts);
        }

        internal MultiTableTransactWrite(TransactWrite first, params TransactWrite[] rest)
        {
            allTransactionParts = new List<TransactWrite>();
            allTransactionParts.Add(first);
            allTransactionParts.AddRange(rest);
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a TransactWrite object to the multi-table transaction request.
        /// </summary>
        /// <param name="transactionPart">TransactWrite to add.</param>
        public void AddTransactionPart(TransactWrite transactionPart)
        {
            allTransactionParts.Add(transactionPart);
        }

        internal void ExecuteHelper()
        {
            MultiTableDocumentTransactWrite transaction = new MultiTableDocumentTransactWrite();
            foreach (var transactionPart in allTransactionParts)
            {
                transaction.AddTransactionPart(transactionPart.DocumentTransaction);
            }
            transaction.ExecuteHelper();
            foreach (var transactionPart in allTransactionParts)
            {
                transactionPart.PopulateObjects();
            }
        }

#if AWS_ASYNC_API
        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiTableDocumentTransactWrite transaction = new MultiTableDocumentTransactWrite();
            foreach (var transactionPart in allTransactionParts)
            {
                transaction.AddTransactionPart(transactionPart.DocumentTransaction);
            }
            await transaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            foreach (var transactionPart in allTransactionParts)
            {
                transactionPart.PopulateObjects();
            }
        }
#endif

        #endregion
    }
}
