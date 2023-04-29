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

using System.Collections.Generic;
#if AWS_ASYNC_API
using System.Threading;
using System.Threading.Tasks;
#endif
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic object for retrieving multiple items
    /// from a single DynamoDB table in a transaction.
    /// </summary>
    public abstract partial class TransactGet
    {
        #region Internal/protected properties

        /// <summary>
        /// Gets and sets the UntypedResults property.
        /// </summary>
        protected List<object> UntypedResults { get; set; }
        internal DynamoDBContext Context { get; set; }
        internal DynamoDBFlatConfig Config { get; set; }
        internal DocumentTransactGet DocumentTransaction { get; set; }

        #endregion


        #region Public properties

        /// <summary>
        /// List of results retrieved from DynamoDB.
        /// Populated after Execute is called.
        /// </summary>
        public List<object> Results => UntypedResults;

        #endregion


        #region Constructor

        internal TransactGet(DynamoDBContext context, DynamoDBFlatConfig config)
        {
            Context = context;
            Config = config;
        }

        #endregion


        #region Protected methods

        /// <summary>
        /// Executes a server call to get the items requested in a transaction.
        /// Populates Results with the retrieved items.
        /// </summary>
        protected internal abstract void ExecuteHelper();

#if AWS_ASYNC_API
        /// <summary>
        /// Executes an asynchronous server call to get the items requested in a transaction.
        /// Populates Results with the retrieved items.
        /// </summary>
        protected internal abstract Task ExecuteHelperAsync(CancellationToken cancellationToken);
#endif
        #endregion


        #region Internal methods

        internal abstract void PopulateResults();

        #endregion
    }

    /// <summary>
    /// Represents a strongly-typed object for retrieving multiple items
    /// from a single DynamoDB table in a transaction.
    /// </summary>
    public class TransactGet<T> : TransactGet
    {
        #region Public properties

        /// <summary>
        /// List of results retrieved from DynamoDB.
        /// Populated after Execute is called.
        /// </summary>
        public new List<T> Results { get { return TypedResults; } }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a single item to get, identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to get.</param>
        public void AddKey(object hashKey)
        {
            AddKey(hashKey, rangeKey: null);
        }

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to get.</param>
        /// <param name="rangeKey">Range key of the item to get.</param>
        public void AddKey(object hashKey, object rangeKey)
        {
            Key key = Context.MakeKey(hashKey, rangeKey, StorageConfig, Config);
            DocumentTransaction.AddKeyHelper(key);
        }

        /// <summary>
        /// Add a single item to get.
        /// </summary>
        /// <param name="keyObject">Object key of the item to get.</param>
        public void AddKey(T keyObject)
        {
            Key key = Context.MakeKey(keyObject, StorageConfig, Config);
            DocumentTransaction.AddKeyHelper(key);
        }

        /// <summary>
        /// Add multiple items to get.
        /// </summary>
        /// <param name="keyObjects">Object keys of the items to get.</param>
        public void AddKeys(IEnumerable<T> keyObjects)
        {
            foreach (var keyObject in keyObjects)
            {
                AddKey(keyObject);
            }
        }

        /// <summary>
        /// Creates a MultiTableTransactGet object that is a combination
        /// of the current TransactGet and the specified TransactGets.
        /// </summary>
        /// <param name="otherTransactionParts">Other TransactGet objects.</param>
        /// <returns>
        /// MultiTableTransactGet consisting of the multiple TransactGet objects:
        /// the current TransactGet object and the passed-in TransactGet objects.
        /// </returns>
        public MultiTableTransactGet Combine(params TransactGet[] otherTransactionParts)
        {
            return new MultiTableTransactGet(this, otherTransactionParts);
        }

        #endregion


        #region Constructor

        internal TransactGet(DynamoDBContext context, DynamoDBFlatConfig config)
            : base(context, config)
        {
            StorageConfig = context.StorageConfigCache.GetConfig<T>(config);
            Table table = Context.GetTargetTable(StorageConfig, Config);
            DocumentTransaction = table.CreateTransactGet();
        }

        #endregion


        #region Internal/protected/private members

        /// <summary>
        /// Gets and sets the TypedResults property.
        /// </summary>
        protected List<T> TypedResults { get; set; }

        internal ItemStorageConfig StorageConfig { get; set; }

        /// <summary>
        /// Executes a server call to get the items requested in a transaction.
        /// Populates Results with the retrieved items.
        /// </summary>
        protected internal override void ExecuteHelper()
        {
            DocumentTransaction.ExecuteHelper();
            PopulateResults();
        }

#if AWS_ASYNC_API
        /// <summary>
        /// Executes an asynchronous server call to get the items requested in a transaction.
        /// Populates Results with the retrieved items.
        /// </summary>
        protected internal override async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            await DocumentTransaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            PopulateResults();
        }
#endif

        internal override void PopulateResults()
        {
            UntypedResults = new List<object>();
            TypedResults = new List<T>();
            foreach (var doc in DocumentTransaction.Results)
            {
                var result = Context.FromDocumentHelper<T>(doc, Config);
                TypedResults.Add(result);
                UntypedResults.Add(result);
            }
        }

        #endregion
    }

    /// <summary>
    /// Class for retrieving multiple items from multiple DynamoDB tables,
    /// using multiple strongly-typed TransactGet objects.
    /// </summary>
    public partial class MultiTableTransactGet
    {
        #region Private members

        private readonly List<TransactGet> allTransactionParts;

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableTransactGet object from a number of
        /// TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Collection of TransactGet objects</param>
        public MultiTableTransactGet(params TransactGet[] transactionParts)
        {
            allTransactionParts = new List<TransactGet>(transactionParts);
        }

        internal MultiTableTransactGet(TransactGet first, params TransactGet[] rest)
        {
            allTransactionParts = new List<TransactGet>();
            allTransactionParts.Add(first);
            allTransactionParts.AddRange(rest);
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a TransactGet object to the multi-table transaction request.
        /// </summary>
        /// <param name="transactionPart">TransactGet to add.</param>
        public void AddTransactionPart(TransactGet transactionPart)
        {
            allTransactionParts.Add(transactionPart);
        }


        internal void ExecuteHelper()
        {
            MultiTableDocumentTransactGet transaction = new MultiTableDocumentTransactGet();
            foreach (var transactionPart in allTransactionParts)
            {
                transaction.AddTransactionPart(transactionPart.DocumentTransaction);
            }
            transaction.ExecuteHelper();
            foreach (var transactionPart in allTransactionParts)
            {
                transactionPart.PopulateResults();
            }
        }

#if AWS_ASYNC_API
        internal async Task ExecuteHelperAsync(CancellationToken cancellationToken)
        {
            MultiTableDocumentTransactGet transaction = new MultiTableDocumentTransactGet();
            foreach (var transactionPart in allTransactionParts)
            {
                transaction.AddTransactionPart(transactionPart.DocumentTransaction);
            }
            await transaction.ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            foreach (var transactionPart in allTransactionParts)
            {
                transactionPart.PopulateResults();
            }
        }
#endif

        #endregion
    }
}
