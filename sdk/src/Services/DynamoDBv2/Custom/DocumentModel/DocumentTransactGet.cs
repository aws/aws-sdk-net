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
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Class for retrieving multiple Documents from a single DynamoDB table in a transaction.
    /// </summary>
    public partial class DocumentTransactGet
    {
        #region Internal properties

        internal Table TargetTable { get; private set; }
        internal List<TransactGetRequestItem> Items { get; private set; }

        #endregion


        #region Public properties

        /// <summary>
        /// List of results retrieved from DynamoDB.
        /// Populated after Execute is called.
        /// </summary>
        public List<Document> Results { get; internal set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a DocumentTransactGet instance for a specific table.
        /// </summary>
        /// <param name="targetTable">Table to get items from.</param>
        public DocumentTransactGet(Table targetTable)
        {
            TargetTable = targetTable;
            Items = new List<TransactGetRequestItem>();
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a single item to get, identified by its hash primary key,
        /// using the specified expression to identify the attributes to retrieve.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        /// <param name="projectionExpression">
        /// An expression that identifies one or more attributes of the specified item to retrieve from the table.
        /// </param>
        public void AddKey(Primitive hashKey, Expression projectionExpression)
        {
            AddKey(hashKey, new TransactGetItemOperationConfig { ProjectionExpression = projectionExpression });
        }

        /// <summary>
        /// Add a single item to get, identified by its hash primary key, using the specified config.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        public void AddKey(Primitive hashKey, TransactGetItemOperationConfig operationConfig = null)
        {
            AddKey(hashKey, rangeKey: null, operationConfig);
        }

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key,
        /// using the specified expression to identify the attributes to retrieve.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        /// <param name="rangeKey">Range key element of the item to get.</param>
        /// <param name="projectionExpression">
        /// An expression that identifies one or more attributes of the specified item to retrieve from the table.
        /// </param>
        public void AddKey(Primitive hashKey, Primitive rangeKey, Expression projectionExpression)
        {
            AddKey(hashKey, rangeKey, new TransactGetItemOperationConfig { ProjectionExpression = projectionExpression });
        }

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key, using the specified config.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        /// <param name="rangeKey">Range key element of the item to get.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        public void AddKey(Primitive hashKey, Primitive rangeKey, TransactGetItemOperationConfig operationConfig = null)
        {
            AddKeyHelper(TargetTable.MakeKey(hashKey, rangeKey), operationConfig);
        }

        /// <summary>
        /// Add a single item to get, identified by its key,
        /// using the specified expression to identify the attributes to retrieve.
        /// </summary>
        /// <param name="key">Key of the item to get.</param>
        /// <param name="projectionExpression">
        /// An expression that identifies one or more attributes of the specified item to retrieve from the table.
        /// </param>
        public void AddKey(IDictionary<string, DynamoDBEntry> key, Expression projectionExpression)
        {
            AddKey(key, new TransactGetItemOperationConfig { ProjectionExpression = projectionExpression });
        }

        /// <summary>
        /// Add a single item to get, identified by its key, using the specified config.
        /// </summary>
        /// <param name="key">Key of the item to get.</param>
        /// <param name="operationConfig">Configuration to use.</param>
        public void AddKey(IDictionary<string, DynamoDBEntry> key, TransactGetItemOperationConfig operationConfig = null)
        {
            AddKeyHelper(TargetTable.MakeKey(key), operationConfig);
        }

        /// <summary>
        /// Creates a MultiTableDocumentTransactGet object that is a combination
        /// of the current DocumentTransactGet and the specified DocumentTransactGet.
        /// </summary>
        /// <param name="otherTransactionPart">Other DocumentTransactGet object.</param>
        /// <returns>
        /// MultiTableDocumentTransactGet consisting of the two DocumentTransactGet objects.
        /// </returns>
        public MultiTableDocumentTransactGet Combine(DocumentTransactGet otherTransactionPart)
        {
            return new MultiTableDocumentTransactGet(this, otherTransactionPart);
        }

        #endregion


        #region Internal/private methods

        internal void ExecuteHelper()
        {
            var items = GetMultiTransactGet().GetItems();
            Results = items.Values.SingleOrDefault() ?? new List<Document>();
        }

#if AWS_ASYNC_API
        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            var items = await GetMultiTransactGet().GetItemsAsync(cancellationToken).ConfigureAwait(false);
            Results = items.Values.SingleOrDefault() ?? new List<Document>();
        }
#endif

        internal void AddKeyHelper(Key key, TransactGetItemOperationConfig operationConfig = null)
        {
            Items.Add(new TransactGetRequestItem
            {
                Key = key,
                TransactionPart = this,
                OperationConfig = operationConfig
            });
        }

        private MultiTransactGet GetMultiTransactGet()
        {
            return new MultiTransactGet
            {
                Items = Items.ToList()
            };
        }

        #endregion
    }

    /// <summary>
    /// Class for retrieving multiple Documents from multiple DynamoDB tables in a transaction.
    /// </summary>
    public partial class MultiTableDocumentTransactGet
    {
        #region Properties

        /// <summary>
        /// List of DocumentTransactGet objects to include in the multi-table
        /// transaction request.
        /// </summary>
        public List<DocumentTransactGet> TransactionParts { get; private set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableDocumentTransactGet object from a number of
        /// DocumentTransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Collection of DocumentTransactGet objects.</param>
        public MultiTableDocumentTransactGet(params DocumentTransactGet[] transactionParts)
        {
            if (transactionParts == null)
                throw new ArgumentNullException(nameof(transactionParts));

            TransactionParts = new List<DocumentTransactGet>(transactionParts);
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a DocumentTransactGet object to the multi-table transaction request.
        /// </summary>
        /// <param name="transactionPart">DocumentTransactGet to add.</param>
        public void AddTransactionPart(DocumentTransactGet transactionPart)
        {
            TransactionParts.Add(transactionPart);
        }

        #endregion


        #region Internal/private methods

        internal void ExecuteHelper()
        {
            var items = GetMultiTransactGet().GetItems();

            foreach (var transactionPart in TransactionParts)
            {
                items.TryGetValue(transactionPart, out var results);
                transactionPart.Results = results ?? new List<Document>();
            }
        }

#if AWS_ASYNC_API
        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            var items = await GetMultiTransactGet().GetItemsAsync(cancellationToken).ConfigureAwait(false);

            foreach (var transactionPart in TransactionParts)
            {
                items.TryGetValue(transactionPart, out var results);
                transactionPart.Results = results ?? new List<Document>();
            }
        }
#endif

        private MultiTransactGet GetMultiTransactGet()
        {
            return new MultiTransactGet
            {
                Items = TransactionParts.SelectMany(x => x.Items).ToList()
            };
        }

        #endregion
    }

    internal class MultiTransactGet
    {
        #region Properties

        public List<TransactGetRequestItem> Items { get; set; }

        #endregion


        #region Public methods

        public Dictionary<DocumentTransactGet, List<Document>> GetItems()
        {
            return GetItemsHelper();
        }

#if AWS_ASYNC_API
        public Task<Dictionary<DocumentTransactGet, List<Document>>> GetItemsAsync(CancellationToken cancellationToken)
        {
            return GetItemsHelperAsync(cancellationToken);
        }
#endif

        #endregion


        #region Private helper methods

        private Dictionary<DocumentTransactGet, List<Document>> GetItemsHelper()
        {
            if (Items == null || !Items.Any()) return new Dictionary<DocumentTransactGet, List<Document>>();

            var request = ConstructRequest(isAsync: false);
            var dynamoDbClient = Items[0].TransactionPart.TargetTable.DDBClient;
            var response = dynamoDbClient.TransactGetItems(request);
            return GetDocuments(response.Responses);
        }

#if AWS_ASYNC_API
        private async Task<Dictionary<DocumentTransactGet, List<Document>>> GetItemsHelperAsync(CancellationToken cancellationToken)
        {
            if (Items == null || !Items.Any()) return new Dictionary<DocumentTransactGet, List<Document>>();

            var request = ConstructRequest(isAsync: true);
            var dynamoDbClient = Items[0].TransactionPart.TargetTable.DDBClient;
            var response = await dynamoDbClient.TransactGetItemsAsync(request, cancellationToken).ConfigureAwait(false);
            return GetDocuments(response.Responses);
        }
#endif

        private TransactGetItemsRequest ConstructRequest(bool isAsync)
        {
            var transactItems = Items.Select(item => item.GetRequest()).ToList();
            var request = new TransactGetItemsRequest { TransactItems = transactItems };
            Items[0].TransactionPart.TargetTable.AddRequestHandler(request, isAsync);
            return request;
        }

        private Dictionary<DocumentTransactGet, List<Document>> GetDocuments(List<ItemResponse> responses)
        {
            var docs = new Dictionary<DocumentTransactGet, List<Document>>();

            foreach (var entry in responses.Select((response, idx) =>
                         new { response.Item, Items[idx].TransactionPart }))
            {
                var item = entry.Item;
                var transactionPart = entry.TransactionPart;

                if (item == null ||
                    // If the Item property is set to a non-null value in the response,
                    // its type will always be AlwaysSendDictionary, not simply Dictionary.
                    // Therefore, if the type is Dictionary, we can infer it was not set or was set to null.
                    item.GetType() == typeof(Dictionary<string, AttributeValue>))
                {
                    continue;
                }

                if (!docs.TryGetValue(transactionPart, out var partDocs))
                {
                    partDocs = new List<Document>();
                    docs[transactionPart] = partDocs;
                }

                var document = transactionPart.TargetTable.FromAttributeMap(item);
                partDocs.Add(document);
            }

            return docs;
        }

        #endregion
    }

    internal class TransactGetRequestItem
    {
        #region Properties

        public Key Key { get; set; }

        public DocumentTransactGet TransactionPart { get; set; }

        public TransactGetItemOperationConfig OperationConfig { get; set; }

        #endregion


        #region Methods

        public TransactGetItem GetRequest()
        {
            var currentConfig = OperationConfig ?? new TransactGetItemOperationConfig();

            var get = new Get
            {
                Key = Key,
                TableName = TransactionPart.TargetTable.TableName
            };

            currentConfig.ProjectionExpression?.ApplyExpression(get, TransactionPart.TargetTable);

            return new TransactGetItem { Get = get };
        }

        #endregion
    }
}
