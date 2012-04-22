﻿/*
 * Copyright 2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Represents a non-generic object for writing/deleting a batch of items
    /// in a single DynamoDB table
    /// </summary>
    public abstract class BatchWrite
    {
        #region Internal/protected properties

        internal DynamoDBContext Context { get; set; }
        internal DynamoDBFlatConfig Config { get; set; }
        internal DocumentBatchWrite DocumentBatch { get; set; }

        #endregion


        #region Constructor

        internal BatchWrite(DynamoDBContext context, DynamoDBFlatConfig config)
        {
            Context = context;
            Config = config;
        }
        
        #endregion


        #region Public methods

        /// <summary>
        /// Executes a server call to batch-write/delete the items requested.
        /// 
        /// If more than 25 put/delete operations are specified, calls of up to 25
        /// put/delete items will be made until all items are processed.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper(false);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.BatchWrite.Execute"/>
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
        /// <seealso cref="Amazon.DynamoDB.DataModel.BatchWrite.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion


        #region Protected methods

        /// <summary>
        /// Executes a server call to batch-write/delete the items requested.
        /// </summary>
        protected virtual void ExecuteHelper(bool isAsync)
        {
        }

        #endregion
    }

    /// <summary>
    /// Represents a strongly-typed object for writing/deleting a batch of items
    /// in a single DynamoDB table
    /// </summary>
    public class BatchWrite<T> : BatchWrite
    {
        #region Public combine methods

        /// <summary>
        /// Creates a MultiTableBatchWrite object that is a combination
        /// of the current BatchWrite and the specified BatchWrites
        /// </summary>
        /// <param name="otherBatches">Other BatchWrite objects</param>
        /// <returns>
        /// MultiTableBatchWrite consisting of the multiple BatchWrite objects:
        /// the current batch and the passed-in batches.
        /// </returns>
        public MultiTableBatchWrite Combine(params BatchWrite[] otherBatches)
        {
            return new MultiTableBatchWrite(this, otherBatches);
        }

        #endregion


        #region Public Put methods

        /// <summary>
        /// Add a number of items to be put in the current batch operation
        /// </summary>
        /// <param name="values">Items to put</param>
        public void AddPutItems(IEnumerable<T> values)
        {
            if (values == null) return;

            foreach (T item in values)
            {
                AddPutItem(item);
            }
        }

        /// <summary>
        /// Add a single item to be put in the current batch operation
        /// </summary>
        /// <param name="item"></param>
        public void AddPutItem(T item)
        {
            if (item == null) return;

            ItemStorage storage = DynamoDBContext.ObjectToItemStorage<T>(item, false, StorageConfig);
            if (storage == null) return;
            DocumentBatch.AddDocumentToPut(storage.Document);
        }

        #endregion


        #region Public Delete methods

        /// <summary>
        /// Add a number of items to be deleted in the current batch operation
        /// </summary>
        /// <param name="values">Items to be deleted</param>
        public void AddDeleteItems(IEnumerable<T> values)
        {
            if (values == null) return;

            foreach (T item in values)
            {
                AddDeleteItem(item);
            }
        }

        /// <summary>
        /// Add a single item to be deleted in the current batch operation.
        /// </summary>
        /// <param name="item">Item to be deleted</param>
        public void AddDeleteItem(T item)
        {
            if (item == null) return;

            ItemStorage storage = DynamoDBContext.ObjectToItemStorage<T>(item, true, StorageConfig);
            if (storage == null) return;
            DocumentBatch.AddItemToDelete(storage.Document);
        }

        /// <summary>
        /// Add a single item to be deleted in the current batch operation.
        /// Item is identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete</param>
        public void AddDeleteKey(object hashKey)
        {
            AddDeleteKey(hashKey, null);
        }

        /// <summary>
        /// Add a single item to be deleted in the current batch operation.
        /// Item is identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key of the item to delete</param>
        /// <param name="rangeKey">Range key of the item to delete</param>
        public void AddDeleteKey(object hashKey, object rangeKey)
        {
            DocumentBatch.AddKeyToDelete(DynamoDBContext.MakeKey(hashKey, rangeKey, StorageConfig));
        }

        #endregion


        #region Constructor

        internal BatchWrite(DynamoDBContext context, DynamoDBFlatConfig config)
            : base(context, config)
        {
            Type type = typeof(T);
            StorageConfig = ItemStorageConfigCache.GetConfig(type);

            if (StorageConfig.HasVersion)
            {
                if (!Config.SkipVersionCheck.GetValueOrDefault(false))
                    throw new InvalidOperationException(string.Format(
                        "Object {0} has a versioning field, which is not supported for this operation. To ignore versioning, use the DynamoDBContextConfig.SkipVersionCheck property.",
                        type.Name));
            }

            Table table = Context.GetTargetTable(StorageConfig, Config);
            DocumentBatch = table.CreateBatchWrite();
        }

        #endregion


        #region Internal/protected/private members

        internal ItemStorageConfig StorageConfig { get; set; }

        internal void ExecuteInternal(bool isAsync)
        {
            ExecuteHelper(isAsync);
        }

        protected override void ExecuteHelper(bool isAsync)
        {
            DocumentBatch.ExecuteHelper(isAsync);
        }

        #endregion
    }

    /// <summary>
    /// Class for writing/deleting a batch of items in multiple DynamoDB tables,
    /// using multiple strongly-typed BatchWrite objects
    /// </summary>
    public class MultiTableBatchWrite
    {
        #region Private members

        private List<BatchWrite> allBatches = new List<BatchWrite>();

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableBatchGet object from a number of
        /// BatchGet objects
        /// </summary>
        /// <param name="batches">Collection of BatchGet objects</param>
        public MultiTableBatchWrite(params BatchWrite[] batches)
        {
            allBatches = new List<BatchWrite>(batches);
        }

        internal MultiTableBatchWrite(BatchWrite first, params BatchWrite[] rest)
        {
            allBatches = new List<BatchWrite>();
            allBatches.Add(first);
            allBatches.AddRange(rest);
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a BatchWrite object to the multi-table batch request
        /// </summary>
        /// <param name="batch">BatchGet to add</param>
        public void AddBatch(BatchWrite batch)
        {
            allBatches.Add(batch);
        }

        /// <summary>
        /// Executes a multi-table batch request against all configured batches.
        /// 
        /// If more than 25 put/delete operations are specified, calls of up to 25
        /// put/delete items will be made until all items are processed.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper(false);
        }

        internal void ExecuteHelper(bool isAsync)
        {
            MultiTableDocumentBatchWrite superBatch = new MultiTableDocumentBatchWrite();
            foreach (var batch in allBatches)
            {
                superBatch.AddBatch(batch.DocumentBatch);
            }
            superBatch.ExecuteHelper(isAsync);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.MultiTableBatchWrite.Execute"/>
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
        /// <seealso cref="Amazon.DynamoDB.DataModel.MultiTableBatchWrite.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion
    }
}
