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
    /// Interface for condition checking, putting, updating and/or deleting
    /// multiple items in a single DynamoDB table in a transaction.
    /// </summary>
    public partial interface IDocumentTransactWrite
    {
        /// <summary>
        /// List of items retrieved from DynamoDB for which a condition check failure happened.
        /// Populated after Execute is called and a TransactionCanceledException happened due to a condition check failure.
        /// A document is only added to this list if ReturnValuesOnConditionCheckFailure has been set to AllOldAttributes
        /// for the corresponding item in the request.
        /// </summary>
        List<Document> ConditionCheckFailedItems { get; }

        /// <summary>
        /// Add a single item to delete, identified by its hash primary key, using the specified config.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to delete.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddKeyToDelete(Primitive hashKey, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single item to delete, identified by its hash-and-range primary key, using the specified config.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to delete.</param>
        /// <param name="rangeKey">Range key element of the item to delete.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddKeyToDelete(Primitive hashKey, Primitive rangeKey, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single item to delete, identified by its key, using the specified config.
        /// </summary>
        /// <param name="key">Key of the item to delete.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddKeyToDelete(IDictionary<string, DynamoDBEntry> key, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single item to delete, identified by a Document object, using the specified config.
        /// </summary>
        /// <param name="document">Document representing the item to be deleted.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddItemToDelete(Document document, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single Document to update, identified by its hash primary key, using the specified config.
        /// </summary>
        /// <param name="document">Attributes to update.</param>
        /// <param name="hashKey">Hash key of the document.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToUpdate(Document document, Primitive hashKey, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single Document to update, identified by its hash-and-range primary key, using the specified config.
        /// </summary>
        /// <param name="document">Attributes to update.</param>
        /// <param name="hashKey">Hash key of the document.</param>
        /// <param name="rangeKey">Range key of the document.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToUpdate(Document document, Primitive hashKey, Primitive rangeKey, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single Document to update, identified by its key, using the specified config.
        /// </summary>
        /// <param name="document">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToUpdate(Document document, IDictionary<string, DynamoDBEntry> key, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single Document to update, using the specified config.
        /// </summary>
        /// <param name="document">Document to update.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToUpdate(Document document, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single item to update, identified by its hash primary key, using the specified update expression and config.
        /// </summary>
        /// <param name="hashKey">Hash key of the document.</param>
        /// <param name="updateExpression">Update expression to use.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToUpdate(Primitive hashKey, Expression updateExpression, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single item to update, identified by its hash-and-range primary key, using the specified update expression and config.
        /// </summary>
        /// <param name="hashKey">Hash key of the document.</param>
        /// <param name="rangeKey">Range key of the document.</param>
        /// <param name="updateExpression">Update expression to use.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToUpdate(Primitive hashKey, Primitive rangeKey, Expression updateExpression, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single item to update, identified by its key, using the specified update expression and config.
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="updateExpression">Update expression to use.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToUpdate(IDictionary<string, DynamoDBEntry> key, Expression updateExpression, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single Document to put, using the specified config.
        /// </summary>
        /// <param name="document">Document to put.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddDocumentToPut(Document document, TransactWriteItemOperationConfig operationConfig = null);

        /// <summary>
        /// Add a single item to condition check, identified by its hash primary key, using the specified condition expression.
        /// </summary>
        /// <param name="hashKey">Hash key of the item.</param>
        /// <param name="conditionalExpression">The expression to evaluate for the item.</param>
        void AddKeyToConditionCheck(Primitive hashKey, Expression conditionalExpression);

        /// <summary>
        /// Add a single item to condition check, identified by its hash primary key, using the specified config.
        /// </summary>
        /// <param name="hashKey">Hash key of the item.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddKeyToConditionCheck(Primitive hashKey, TransactWriteItemOperationConfig operationConfig);

        /// <summary>
        /// Add a single item to condition check, identified by its hash-and-range primary key, using the specified condition expression.
        /// </summary>
        /// <param name="hashKey">Hash key of the item.</param>
        /// <param name="rangeKey">Range key of the item.</param>
        /// <param name="conditionalExpression">The expression to evaluate for the item.</param>
        void AddKeyToConditionCheck(Primitive hashKey, Primitive rangeKey, Expression conditionalExpression);

        /// <summary>
        /// Add a single item to condition check, identified by its hash-and-range primary key, using the specified config.
        /// </summary>
        /// <param name="hashKey">Hash key of the item.</param>
        /// <param name="rangeKey">Range key of the item.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddKeyToConditionCheck(Primitive hashKey, Primitive rangeKey, TransactWriteItemOperationConfig operationConfig);

        /// <summary>
        /// Add a single item to condition check, identified by its key, using the specified condition expression.
        /// </summary>
        /// <param name="key">Key of the item.</param>
        /// <param name="conditionalExpression">The expression to evaluate for the item.</param>
        void AddKeyToConditionCheck(IDictionary<string, DynamoDBEntry> key, Expression conditionalExpression);

        /// <summary>
        /// Add a single item to condition check, identified by its key, using the specified config.
        /// </summary>
        /// <param name="key">Key of the item.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddKeyToConditionCheck(IDictionary<string, DynamoDBEntry> key, TransactWriteItemOperationConfig operationConfig);

        /// <summary>
        /// Add a single item to condition check, identified by a Document object, using the specified condition expression.
        /// </summary>
        /// <param name="document">Document representing the item.</param>
        /// <param name="conditionalExpression">The expression to evaluate for the item.</param>
        void AddItemToConditionCheck(Document document, Expression conditionalExpression);

        /// <summary>
        ///  Add a single item to condition check, identified by a Document object, using the specified config.
        /// </summary>
        /// <param name="document">Document representing the item.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        void AddItemToConditionCheck(Document document, TransactWriteItemOperationConfig operationConfig);

        /// <summary>
        /// Creates a MultiTableDocumentTransactWrite object that is a combination
        /// of the current DocumentTransactWrite and the specified DocumentTransactWrite.
        /// </summary>
        /// <param name="otherTransactionPart">Other DocumentTransactWrite object.</param>
        /// <returns>
        /// MultiTableDocumentTransactWrite consisting of the two DocumentTransactWrite objects.
        /// </returns>
        IMultiTableDocumentTransactWrite Combine(IDocumentTransactWrite otherTransactionPart);
    }

    /// <summary>
    /// Class for condition checking, putting, updating and/or deleting
    /// multiple items in a single DynamoDB table in a transaction.
    /// </summary>
    public partial class DocumentTransactWrite : IDocumentTransactWrite
    {
        #region Internal properties

        internal Table TargetTable { get; private set; }
        internal List<ITransactWriteRequestItem> Items { get; private set; }
        internal TracerProvider TracerProvider { get; private set; }

        #endregion


        #region Public properties

        /// <inheritdoc/>
        public List<Document> ConditionCheckFailedItems { get; internal set; }

        #endregion


        #region Constructor

        /// <inheritdoc/>
        public DocumentTransactWrite(Table targetTable)
        {
            TargetTable = targetTable;
            Items = new List<ITransactWriteRequestItem>();
            TracerProvider = targetTable?.DDBClient?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        #endregion


        #region Public Delete methods

        /// <inheritdoc/>
        public void AddKeyToDelete(Primitive hashKey, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddKeyToDelete(hashKey, rangeKey: null, operationConfig);
        }

        /// <inheritdoc/>
        public void AddKeyToDelete(Primitive hashKey, Primitive rangeKey, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddKeyToDeleteHelper(TargetTable.MakeKey(hashKey, rangeKey), operationConfig);
        }

        /// <inheritdoc/>
        public void AddKeyToDelete(IDictionary<string, DynamoDBEntry> key, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddKeyToDeleteHelper(TargetTable.MakeKey(key), operationConfig);
        }

        /// <inheritdoc/>
        public void AddItemToDelete(Document document, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddKeyToDeleteHelper(TargetTable.MakeKey(document), operationConfig);
        }

        #endregion


        #region Public Update methods

        /// <inheritdoc/>
        public void AddDocumentToUpdate(Document document, Primitive hashKey, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddDocumentToUpdate(document, hashKey, rangeKey: null, operationConfig);
        }

        /// <inheritdoc/>
        public void AddDocumentToUpdate(Document document, Primitive hashKey, Primitive rangeKey, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddDocumentToUpdateHelper(document, TargetTable.MakeKey(hashKey, rangeKey), operationConfig);
        }

        /// <inheritdoc/>
        public void AddDocumentToUpdate(Document document, IDictionary<string, DynamoDBEntry> key, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddDocumentToUpdateHelper(document, TargetTable.MakeKey(key), operationConfig);
        }

        /// <inheritdoc/>
        public void AddDocumentToUpdate(Document document, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddDocumentToUpdateHelper(document, TargetTable.MakeKey(document), operationConfig);
        }

        /// <inheritdoc/>
        public void AddDocumentToUpdate(Primitive hashKey, Expression updateExpression, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddDocumentToUpdate(hashKey, rangeKey: null, updateExpression, operationConfig);
        }

        /// <inheritdoc/>
        public void AddDocumentToUpdate(Primitive hashKey, Primitive rangeKey, Expression updateExpression, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddDocumentToUpdateHelper(TargetTable.MakeKey(hashKey, rangeKey), updateExpression, operationConfig);
        }

        /// <inheritdoc/>
        public void AddDocumentToUpdate(IDictionary<string, DynamoDBEntry> key, Expression updateExpression, TransactWriteItemOperationConfig operationConfig = null)
        {
            AddDocumentToUpdateHelper(TargetTable.MakeKey(key), updateExpression, operationConfig);
        }

        #endregion


        #region Public Put methods

        /// <inheritdoc/>
        public void AddDocumentToPut(Document document, TransactWriteItemOperationConfig operationConfig = null)
        {
            Items.Add(new ToPutTransactWriteRequestItem
            {
                TransactionPart = this,
                Document = document,
                OperationConfig = operationConfig
            });
        }

        #endregion


        #region Public ConditionCheck methods

        /// <inheritdoc/>
        public void AddKeyToConditionCheck(Primitive hashKey, Expression conditionalExpression)
        {
            AddKeyToConditionCheck(hashKey, new TransactWriteItemOperationConfig { ConditionalExpression = conditionalExpression });
        }

        /// <inheritdoc/>
        public void AddKeyToConditionCheck(Primitive hashKey, TransactWriteItemOperationConfig operationConfig)
        {
            AddKeyToConditionCheck(hashKey, rangeKey: null, operationConfig);
        }

        /// <inheritdoc/>
        public void AddKeyToConditionCheck(Primitive hashKey, Primitive rangeKey, Expression conditionalExpression)
        {
            AddKeyToConditionCheck(hashKey, rangeKey, new TransactWriteItemOperationConfig { ConditionalExpression = conditionalExpression });
        }

        /// <inheritdoc/>
        public void AddKeyToConditionCheck(Primitive hashKey, Primitive rangeKey, TransactWriteItemOperationConfig operationConfig)
        {
            AddKeyToConditionCheckHelper(TargetTable.MakeKey(hashKey, rangeKey), operationConfig);
        }

        /// <inheritdoc/>
        public void AddKeyToConditionCheck(IDictionary<string, DynamoDBEntry> key, Expression conditionalExpression)
        {
            AddKeyToConditionCheck(key, new TransactWriteItemOperationConfig { ConditionalExpression = conditionalExpression });
        }

        /// <inheritdoc/>
        public void AddKeyToConditionCheck(IDictionary<string, DynamoDBEntry> key, TransactWriteItemOperationConfig operationConfig)
        {
            AddKeyToConditionCheckHelper(TargetTable.MakeKey(key), operationConfig);
        }

        /// <inheritdoc/>
        public void AddItemToConditionCheck(Document document, Expression conditionalExpression)
        {
            AddItemToConditionCheck(document, new TransactWriteItemOperationConfig { ConditionalExpression = conditionalExpression });
        }

        /// <inheritdoc/>
        public void AddItemToConditionCheck(Document document, TransactWriteItemOperationConfig operationConfig)
        {
            AddKeyToConditionCheckHelper(TargetTable.MakeKey(document), operationConfig);
        }

        #endregion


        #region Internal/private methods

        internal void ExecuteHelper()
        {
            try
            {
                GetMultiTransactWrite().WriteItems();
            }
            finally
            {
                if (ConditionCheckFailedItems == null) ConditionCheckFailedItems = new List<Document>();
            }
        }

        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            try
            {
                await GetMultiTransactWrite().WriteItemsAsync(cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                if (ConditionCheckFailedItems == null) ConditionCheckFailedItems = new List<Document>();
            }
        }

        private MultiTransactWrite GetMultiTransactWrite()
        {
            return new MultiTransactWrite
            {
                Items = Items.ToList()
            };
        }

        internal void AddKeyToDeleteHelper(Key key, TransactWriteItemOperationConfig operationConfig = null)
        {
            Items.Add(new ToDeleteTransactWriteRequestItem
            {
                TransactionPart = this,
                Key = key,
                OperationConfig = operationConfig
            });
        }

        internal void AddDocumentToUpdateHelper(Document document, Key key, TransactWriteItemOperationConfig operationConfig = null)
        {
            Items.Add(new ToUpdateWithDocumentTransactWriteRequestItem
            {
                TransactionPart = this,
                Document = document,
                Key = key,
                OperationConfig = operationConfig
            });
        }

        internal void AddDocumentToUpdateHelper(Key key, Expression updateExpression, TransactWriteItemOperationConfig operationConfig)
        {
            if (operationConfig?.ConditionalExpression != null)
            {
                // Filter attribute names and values from the update expression that are also found in the condition expression
                // If the value is different for the same key between the two expressions, an exception is thrown
                // This ensures no exception is thrown when the attribute names and values of the update expression are merged into the request object
                if (!TryFilterDuplicates(updateExpression.ExpressionAttributeValues,
                        operationConfig.ConditionalExpression.ExpressionAttributeValues, out var attributeValues,
                        out var conflictingValueKeys))
                {
                    throw new ArgumentException(
                        "Conflicting attribute values found between the update expression and the condition expression. " +
                        "Use a different key instead of each affected attribute value key in one of the expressions. " +
                        $"Affected attribute value keys: {string.Join(", ", conflictingValueKeys.ToArray())}.",
                        "updateExpression");
                }

                if (!TryFilterDuplicates(updateExpression.ExpressionAttributeNames,
                        operationConfig.ConditionalExpression.ExpressionAttributeNames, out var attributeNames,
                        out var conflictingNameKeys))
                {
                    throw new ArgumentException(
                        "Conflicting attribute names found between the update expression and the condition expression. " +
                        "Use a different key instead of each affected attribute name key in one of the expressions. " +
                        $"Affected attribute name keys: {string.Join(", ", conflictingNameKeys.ToArray())}.",
                        "updateExpression");
                }

                updateExpression = new Expression
                {
                    ExpressionStatement = updateExpression.ExpressionStatement,
                    ExpressionAttributeValues = attributeValues,
                    ExpressionAttributeNames = attributeNames
                };
            }

            Items.Add(new ToUpdateWithExpressionTransactWriteRequestItem
            {
                TransactionPart = this,
                Key = key,
                UpdateExpression = updateExpression,
                OperationConfig = operationConfig
            });
        }

        internal void AddKeyToConditionCheckHelper(Key key, TransactWriteItemOperationConfig operationConfig)
        {
            bool isSet = operationConfig?.ConditionalExpression?.IsSet ?? false;
            if (!isSet)
                throw new InvalidOperationException("Conditional expression must be set for this operation.");

            Items.Add(new ToConditionCheckTransactWriteRequestItem
            {
                TransactionPart = this,
                Key = key,
                OperationConfig = operationConfig
            });
        }

        private static bool TryFilterDuplicates<T>(Dictionary<string, T> src, Dictionary<string, T> other,
            out Dictionary<string, T> dest, out List<string> conflictingKeys)
        {
            dest = new Dictionary<string, T>();
            conflictingKeys = new List<string>();

            foreach (var kvp in src)
            {
                if (other.TryGetValue(kvp.Key, out var otherValue))
                {
                    if (!otherValue.Equals(kvp.Value))
                    {
                        conflictingKeys.Add(kvp.Key);
                    }
                }
                else
                {
                    dest.Add(kvp.Key, kvp.Value);
                }
            }

            return conflictingKeys.Count == 0;
        }

        #endregion


        #region Public methods

        /// <inheritdoc/>
        public IMultiTableDocumentTransactWrite Combine(IDocumentTransactWrite otherTransactionPart)
        {
            return new MultiTableDocumentTransactWrite(this, otherTransactionPart);
        }

        #endregion
    }

    /// <summary>
    /// Interface for condition checking, putting, updating and/or deleting
    /// multiple items in multiple DynamoDB tables in a transaction.
    /// </summary>
    public partial interface IMultiTableDocumentTransactWrite
    {
        /// <summary>
        /// List of DocumentTransactWrite objects to include in the multi-table
        /// transaction request.
        /// </summary>
        List<IDocumentTransactWrite> TransactionParts { get; }

        /// <summary>
        /// Add a DocumentTransactWrite object to the multi-table transaction request.
        /// </summary>
        /// <param name="transactionPart">DocumentTransactWrite to add.</param>
        void AddTransactionPart(IDocumentTransactWrite transactionPart);
    }

    /// <summary>
    /// Class for condition checking, putting, updating and/or deleting
    /// multiple items in multiple DynamoDB tables in a transaction.
    /// </summary>
    public partial class MultiTableDocumentTransactWrite : IMultiTableDocumentTransactWrite
    {
        #region Properties

        internal TracerProvider TracerProvider { get; private set; }

        /// <inheritdoc/>
        public List<IDocumentTransactWrite> TransactionParts { get; private set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableDocumentTransactWrite object from a number of
        /// DocumentTransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Collection of DocumentTransactWrite objects.</param>
        public MultiTableDocumentTransactWrite(params IDocumentTransactWrite[] transactionParts)
        {
            if (transactionParts == null)
                throw new ArgumentNullException(nameof(transactionParts));

            TransactionParts = new List<IDocumentTransactWrite>(transactionParts);
            TracerProvider = GetTracerProvider(TransactionParts);
        }

        #endregion


        #region Public methods

        /// <inheritdoc/>
        public void AddTransactionPart(IDocumentTransactWrite transactionPart)
        {
            TransactionParts.Add(transactionPart);
        }

        #endregion


        #region Internal/private methods

        internal void ExecuteHelper()
        {
            List<DocumentTransactWrite> docTransactionParts = new();
            try
            {
                GetMultiTransactWrite().WriteItems();
                var errMsg = $"All transaction parts must be of type {nameof(DocumentTransactWrite)}";
                docTransactionParts = TransactionParts.Select(x => x as DocumentTransactWrite ?? throw new InvalidOperationException(errMsg)).ToList();
            }
            finally
            {
                foreach (var transactionPart in docTransactionParts)
                {
                    if (transactionPart.ConditionCheckFailedItems == null)
                        transactionPart.ConditionCheckFailedItems = new List<Document>();
                }
            }
        }

        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            List<DocumentTransactWrite> docTransactionParts = new();
            try
            {
                await GetMultiTransactWrite().WriteItemsAsync(cancellationToken).ConfigureAwait(false);
                var errMsg = $"All transaction parts must be of type {nameof(DocumentTransactWrite)}";
                docTransactionParts = TransactionParts.Select(x => x as DocumentTransactWrite ?? throw new InvalidOperationException(errMsg)).ToList();
            }
            finally
            {
                foreach (var transactionPart in docTransactionParts)
                {
                    if (transactionPart.ConditionCheckFailedItems == null)
                        transactionPart.ConditionCheckFailedItems = new List<Document>();
                }
            }
        }

        private MultiTransactWrite GetMultiTransactWrite()
        {
            var errMsg = $"All transaction parts must be of type {nameof(DocumentTransactWrite)}";
            return new MultiTransactWrite
            {
                Items = TransactionParts.SelectMany(x =>
                {
                    var docTransactWrite = x as DocumentTransactWrite ?? throw new InvalidOperationException(errMsg);
                    return docTransactWrite.Items;
                }).ToList()
            };
        }

        private TracerProvider GetTracerProvider(List<IDocumentTransactWrite> batches)
        {
            var tracerProvider = AWSConfigs.TelemetryProvider.TracerProvider;
            if (batches.Count > 0)
            {
                if (batches[0] is DocumentBatchWrite documentTransactWrite)
                {
                    tracerProvider = documentTransactWrite.TracerProvider;
                }
            }
            return tracerProvider;
        }

        #endregion
    }

    internal class MultiTransactWrite
    {
        #region Properties

        public List<ITransactWriteRequestItem> Items { get; set; }

        #endregion


        #region Public methods

        public void WriteItems()
        {
            WriteItemsHelper();
        }

        public Task WriteItemsAsync(CancellationToken cancellationToken)
        {
            return WriteItemsHelperAsync(cancellationToken);
        }

        #endregion


        #region Private helper methods

        private void WriteItemsHelper()
        {
            if (Items == null || !Items.Any()) return;

            var request = ConstructRequest(isAsync: false);

            try
            {
#if NETSTANDARD
                // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
                var internalClient = Items[0].TransactionPart.TargetTable.DDBClient as AmazonDynamoDBClient;
                if (internalClient == null)
                {
                    throw new InvalidOperationException("Calling the synchronous DocumentTransactWrite.Execute() from .NET or .NET Core requires initializing the Table " +
                       "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when calling ExecuteAsync instead.");
                }
#else
                var internalClient = Items[0].TransactionPart.TargetTable.DDBClient;
#endif

                internalClient.TransactWriteItems(request);
            }
            catch (TransactionCanceledException ex)
            {
                FillConditionCheckFailedItems(ex.CancellationReasons);
                throw;
            }

            foreach (var item in Items)
            {
                item.CommitChanges();
            }
        }

        private async Task WriteItemsHelperAsync(CancellationToken cancellationToken)
        {
            if (Items == null || !Items.Any()) return;

            var request = ConstructRequest(isAsync: true);

            try
            {
                var dynamoDbClient = Items[0].TransactionPart.TargetTable.DDBClient;
                await dynamoDbClient.TransactWriteItemsAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (TransactionCanceledException ex)
            {
                FillConditionCheckFailedItems(ex.CancellationReasons);
                throw;
            }

            foreach (var item in Items)
            {
                item.CommitChanges();
            }
        }

        private TransactWriteItemsRequest ConstructRequest(bool isAsync)
        {
            var transactItems = Items.Select(item => item.GetRequest()).ToList();
            var request = new TransactWriteItemsRequest { TransactItems = transactItems };
            Items[0].TransactionPart.TargetTable.UpdateRequestUserAgentDetails(request, isAsync);
            return request;
        }

        private void FillConditionCheckFailedItems(List<CancellationReason> cancellationReasons)
        {
            if (cancellationReasons == null) return;

            foreach (var entry in cancellationReasons.Select((cancellationReason, idx) =>
                         new { CancellationReason = cancellationReason, Item = Items[idx] }))
            {
                var cancellationReason = entry.CancellationReason;
                var item = entry.Item;
                var transactionPart = item.TransactionPart;

                if (cancellationReason.Code != BatchStatementErrorCodeEnum.ConditionalCheckFailed ||
                    cancellationReason.Item == null ||
                    // If the Item property is set to a non-null value in the response,
                    // its type will always be AlwaysSendDictionary, not simply Dictionary.
                    // Therefore, if the type is Dictionary, we can infer it was not set or was set to null.
                    cancellationReason.Item.GetType() == typeof(Dictionary<string, AttributeValue>))
                {
                    continue;
                }

                var returnValues = item.OperationConfig != null &&
                                   item.OperationConfig.ReturnValuesOnConditionCheckFailure !=
                                   ReturnValuesOnConditionCheckFailure.None;
                if (!returnValues) continue;

                var document = transactionPart.TargetTable.FromAttributeMap(cancellationReason.Item);
                if (transactionPart.ConditionCheckFailedItems == null)
                    transactionPart.ConditionCheckFailedItems = new List<Document>();
                transactionPart.ConditionCheckFailedItems.Add(document);
            }
        }

        #endregion
    }

    internal interface ITransactWriteRequestItem
    {
        #region Properties

        DocumentTransactWrite TransactionPart { get; }

        TransactWriteItemOperationConfig OperationConfig { get; }

        #endregion


        #region Methods

        TransactWriteItem GetRequest();

        void CommitChanges();

        #endregion
    }

    internal abstract class TransactWriteRequestItemBase : ITransactWriteRequestItem
    {
        public DocumentTransactWrite TransactionPart { get; set; }

        public TransactWriteItemOperationConfig OperationConfig { get; set; }

        public abstract TransactWriteItem GetRequest();

        public virtual void CommitChanges()
        {
        }
    }

    internal class ToPutTransactWriteRequestItem : TransactWriteRequestItemBase
    {
        #region Properties

        public Document Document { get; set; }

        #endregion


        #region Methods

        public override TransactWriteItem GetRequest()
        {
            var currentConfig = OperationConfig ?? new TransactWriteItemOperationConfig();

            var put = new Put
            {
                Item = TransactionPart.TargetTable.ToAttributeMap(Document),
                TableName = TransactionPart.TargetTable.TableName,
                ReturnValuesOnConditionCheckFailure = EnumMapper.Convert(currentConfig.ReturnValuesOnConditionCheckFailure)
            };

            currentConfig.ConditionalExpression?.ApplyExpression(put, TransactionPart.TargetTable);

            return new TransactWriteItem { Put = put };
        }

        public override void CommitChanges()
        {
            Document.CommitChanges();
        }

        #endregion
    }

    internal abstract class ToUpdateTransactWriteRequestItemBase : TransactWriteRequestItemBase
    {
        #region Properties

        public Key Key { get; set; }

        #endregion


        #region Methods

        public sealed override TransactWriteItem GetRequest()
        {
            var currentConfig = OperationConfig ?? new TransactWriteItemOperationConfig();

            var update = new Update
            {
                Key = Key,
                TableName = TransactionPart.TargetTable.TableName,
                ReturnValuesOnConditionCheckFailure = EnumMapper.Convert(currentConfig.ReturnValuesOnConditionCheckFailure)
            };

            currentConfig.ConditionalExpression?.ApplyExpression(update, TransactionPart.TargetTable);

            if (TryGetUpdateExpression(out var statement,
                    out var expressionAttributeValues,
                    out var expressionAttributeNames))
            {
                update.UpdateExpression = statement;

                if (update.ExpressionAttributeValues == null)
                {
                    update.ExpressionAttributeValues = expressionAttributeValues;
                }
                else
                {
                    foreach (var kvp in expressionAttributeValues)
                        update.ExpressionAttributeValues.Add(kvp.Key, kvp.Value);
                }

                if (update.ExpressionAttributeNames == null)
                {
                    update.ExpressionAttributeNames = expressionAttributeNames;
                }
                else
                {
                    foreach (var kvp in expressionAttributeNames)
                        update.ExpressionAttributeNames.Add(kvp.Key, kvp.Value);
                }
            }

            return new TransactWriteItem { Update = update };
        }

        protected abstract bool TryGetUpdateExpression(out string statement,
            out Dictionary<string, AttributeValue> expressionAttributeValues,
            out Dictionary<string, string> expressionAttributes);

        #endregion
    }

    internal class ToUpdateWithDocumentTransactWriteRequestItem : ToUpdateTransactWriteRequestItemBase
    {
        #region Properties

        public Document Document { get; set; }

        #endregion


        #region Methods

        protected override bool TryGetUpdateExpression(out string statement,
            out Dictionary<string, AttributeValue> expressionAttributeValues,
            out Dictionary<string, string> expressionAttributes)
        {
            // If the keys have been changed, treat entire document as having changed
            bool haveKeysChanged = TransactionPart.TargetTable.HaveKeysChanged(Document);
            bool updateChangedAttributesOnly = !haveKeysChanged;

            var attributeUpdates = TransactionPart.TargetTable.ToAttributeUpdateMap(Document, updateChangedAttributesOnly);
            foreach (var keyName in TransactionPart.TargetTable.KeyNames)
            {
                attributeUpdates.Remove(keyName);
            }

            if (!attributeUpdates.Any())
            {
                statement = null;
                expressionAttributeValues = null;
                expressionAttributes = null;
                return false;
            }

            Common.ConvertAttributeUpdatesToUpdateExpression(attributeUpdates,null,null,
                out statement, out expressionAttributeValues, out expressionAttributes);

            return true;
        }

        public override void CommitChanges()
        {
            Document.CommitChanges();
        }

        #endregion
    }

    internal class ToUpdateWithExpressionTransactWriteRequestItem : ToUpdateTransactWriteRequestItemBase
    {
        #region Properties

        public Expression UpdateExpression { get; set; }

        #endregion


        #region Methods

        protected override bool TryGetUpdateExpression(out string statement,
            out Dictionary<string, AttributeValue> expressionAttributeValues,
            out Dictionary<string, string> expressionAttributes)
        {
            statement = UpdateExpression.ExpressionStatement;
            expressionAttributeValues = Expression.ConvertToAttributeValues(UpdateExpression.ExpressionAttributeValues, TransactionPart.TargetTable);
            expressionAttributes = UpdateExpression.ExpressionAttributeNames;
            return true;
        }

        #endregion
    }

    internal class ToDeleteTransactWriteRequestItem : TransactWriteRequestItemBase
    {
        #region Properties

        public Key Key { get; set; }

        #endregion


        #region Methods

        public override TransactWriteItem GetRequest()
        {
            var currentConfig = OperationConfig ?? new TransactWriteItemOperationConfig();

            var delete = new Delete
            {
                Key = Key,
                TableName = TransactionPart.TargetTable.TableName,
                ReturnValuesOnConditionCheckFailure = EnumMapper.Convert(currentConfig.ReturnValuesOnConditionCheckFailure)
            };

            currentConfig.ConditionalExpression?.ApplyExpression(delete, TransactionPart.TargetTable);

            return new TransactWriteItem { Delete = delete };
        }

        #endregion
    }

    internal class ToConditionCheckTransactWriteRequestItem : TransactWriteRequestItemBase
    {
        #region Properties

        public Key Key { get; set; }

        #endregion


        #region Methods

        public override TransactWriteItem GetRequest()
        {
            var currentConfig = OperationConfig ?? new TransactWriteItemOperationConfig();

            var conditionCheck = new ConditionCheck
            {
                Key = Key,
                TableName = TransactionPart.TargetTable.TableName,
                ReturnValuesOnConditionCheckFailure = EnumMapper.Convert(currentConfig.ReturnValuesOnConditionCheckFailure)
            };

            currentConfig.ConditionalExpression?.ApplyExpression(conditionCheck, TransactionPart.TargetTable);

            return new TransactWriteItem { ConditionCheck = conditionCheck };
        }

        #endregion
    }
}
