/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Amazon.DynamoDB.Model;
using Amazon.DynamoDB.DocumentModel;

namespace Amazon.DynamoDB.DataModel
{
    /// <summary>
    /// Represents a non-generic object for retrieving a batch of items
    /// from a single DynamoDB table
    /// </summary>
    public abstract class BatchGet
    {
        #region Internal/protected properties

        protected List<object> UntypedResults { get; set; }
        internal DynamoDBContext Context { get; set; }
        internal DynamoDBFlatConfig Config { get; set; }
        internal List<BatchGetKey> Keys { get; set; }
        internal DocumentBatchGet DocumentBatch { get; set; }

        #endregion


        #region Constructor

        internal BatchGet(DynamoDBContext context, DynamoDBFlatConfig config)
        {
            Context = context;
            Config = config;
            Keys = new List<BatchGetKey>();
        }
        
        #endregion


        #region Public properties

        /// <summary>
        /// List of results retrieved from DynamoDB.
        /// Populated after Execute is called.
        /// </summary>
        public List<object> Results { get { return UntypedResults; } }

        /// <summary>
        /// If set to true, a consistent read is issued. Otherwise eventually-consistent is used.
        /// </summary>
        public bool ConsistentRead { get; set; }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a single item to get, identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to get</param>
        public void AddKey(object hashKey)
        {
            AddKey(hashKey, null);
        }

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to get</param>
        /// <param name="rangeKey">Range key of the item to get</param>
        public void AddKey(object hashKey, object rangeKey)
        {
            Keys.Add(new BatchGetKey(hashKey, rangeKey));
        }

        /// <summary>
        /// Executes a server call to batch-get the items requested.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper(false);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.BatchGet.Execute"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecute
        ///         operation.</returns>
        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { ExecuteHelper(true); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.BatchGet.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion


        #region Protected methods

        /// <summary>
        /// Executes a server call to batch-get the items requested.
        /// Populates Results with the retrieved items.
        /// </summary>
        protected virtual void ExecuteHelper(bool isAsync)
        {
        }

        #endregion


        #region Internal methods

        internal abstract void CreateDocumentBatch();
        internal abstract void PopulateResults(List<Document> items);

        #endregion
    }

    /// <summary>
    /// Represents a strongly-typed object for retrieving a batch of items
    /// from a single DynamoDB table
    /// </summary>
    public class BatchGet<T> : BatchGet
    {
        #region Public properties

        /// <summary>
        /// List of results retrieved from DynamoDB.
        /// Populated after Execute is called.
        /// </summary>
        new public List<T> Results { get { return TypedResults; } }

        #endregion


        #region Public methods

        /// <summary>
        /// Creates a MultiTableBatchGet object that is a combination
        /// of the current BatchGet and the specified BatchGets
        /// </summary>
        /// <param name="otherBatches">Other BatchGet objects</param>
        /// <returns>
        /// MultiTableBatchGet consisting of the multiple BatchGet objects:
        /// the current batch and the passed-in batches.
        /// </returns>
        public MultiTableBatchGet Combine(params BatchGet[] otherBatches)
        {
            return new MultiTableBatchGet(this, otherBatches);
        }

        #endregion


        #region Constructor

        internal BatchGet(DynamoDBContext context, DynamoDBFlatConfig config)
            : base(context, config)
        {
        }

        #endregion


        #region Internal/protected/private members

        protected override void ExecuteHelper(bool isAsync)
        {
            CreateDocumentBatch();
            DocumentBatch.ExecuteHelper(isAsync);
            PopulateResults(DocumentBatch.Results);
        }
        protected List<T> TypedResults { get; set; }
        internal override void CreateDocumentBatch()
        {
            var keys = CreateKeys();
            var storageConfig = ItemStorageConfigCache.GetConfig<T>();
            var table = Context.GetTargetTable(storageConfig, Config);

            DocumentBatchGet docBatch = new DocumentBatchGet(table)
            {
                AttributesToGet = storageConfig.AttributesToGet,
                ConsistentRead = this.ConsistentRead
            };
            docBatch.Keys.AddRange(keys);

            DocumentBatch = docBatch;
        }
        internal override void PopulateResults(List<Document> items)
        {
            UntypedResults = new List<object>();
            TypedResults = new List<T>();
            foreach (var doc in items)
            {
                var item = Context.FromDocument<T>(doc);
                TypedResults.Add(item);
                UntypedResults.Add(item);
            }
        }
        private List<Key> CreateKeys()
        {
            var itemStorageConfig = ItemStorageConfigCache.GetConfig<T>();
            var keys = new List<Key>();
            foreach (var key in Keys)
            {
                keys.Add(DynamoDBContext.MakeKey(key.HashKey, key.RangeKey, itemStorageConfig));
            }
            return keys;
        }

        #endregion
    }

    /// <summary>
    /// Class for retrieving a batch of items from multiple DynamoDB tables,
    /// using multiple strongly-typed BatchGet objects
    /// </summary>
    public class MultiTableBatchGet
    {
        #region Private members

        private List<BatchGet> allBatches = new List<BatchGet>();

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableBatchGet object from a number of
        /// BatchGet objects
        /// </summary>
        /// <param name="batches">Collection of BatchGet objects</param>
        public MultiTableBatchGet(params BatchGet[] batches)
        {
            allBatches = new List<BatchGet>(batches);
        }

        internal MultiTableBatchGet(BatchGet first, params BatchGet[] rest)
        {
            allBatches = new List<BatchGet>();
            allBatches.Add(first);
            allBatches.AddRange(rest);
        }

        #endregion


        #region Public properties

        /// <summary>
        /// Gets the total number of primary keys to be loaded from DynamoDB,
        /// across all batches
        /// </summary>
        public int TotalKeys
        {
            get
            {
                int count = 0;
                foreach (var batch in allBatches)
                {
                    count += batch.Keys.Count;
                }
                return count;
            }
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a BatchGet object to the multi-table batch request
        /// </summary>
        /// <param name="batch">BatchGet to add</param>
        public void AddBatch(BatchGet batch)
        {
            allBatches.Add(batch);
        }

        /// <summary>
        /// Executes a multi-table batch request against all configured batches.
        /// Results are stored in the respective BatchGet objects.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper(false);
        }

        internal void ExecuteHelper(bool isAsync)
        {
            MultiTableDocumentBatchGet superBatch = new MultiTableDocumentBatchGet();
            foreach (var batch in allBatches)
            {
                batch.CreateDocumentBatch();
                superBatch.AddBatch(batch.DocumentBatch);
            }
            superBatch.ExecuteHelper(isAsync);

            foreach (var batch in allBatches)
            {
                batch.PopulateResults(batch.DocumentBatch.Results);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.MultiTableBatchGet.Execute"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecute
        ///         operation.</returns>
        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { ExecuteHelper(true); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.MultiTableBatchGet.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion
    }

    internal class BatchGetKey
    {
        public object HashKey { get; set; }
        public object RangeKey { get; set; }

        public BatchGetKey(object hashKey)
            : this(hashKey, null) { }
        public BatchGetKey(object hashKey, object rangeKey)
        {
            HashKey = hashKey;
            RangeKey = rangeKey;
        }
    }
}
