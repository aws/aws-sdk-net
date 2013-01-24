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
using System.Collections.Generic;
using System.IO;
using System.Net;
using Amazon.DynamoDB.Model;
using Amazon.Runtime;

namespace Amazon.DynamoDB.DocumentModel
{
    /// <summary>
    /// Class for putting and/or deleting a batch of items in a single DynamoDB table.
    /// </summary>
    public class DocumentBatchWrite
    {
        #region Internal properties

        internal Table TargetTable { get; private set; }
        internal List<Key> ToDelete { get; private set; }
        internal List<Document> ToPut { get; private set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a DocumentBatchWrite instance for a specific table.
        /// </summary>
        /// <param name="targetTable">Table to get items from.</param>
        public DocumentBatchWrite(Table targetTable)
        {
            TargetTable = targetTable;
            ToDelete = new List<Key>();
            ToPut = new List<Document>();
        }

        #endregion


        #region Public Delete methods

        /// <summary>
        /// Add a single item to delete, identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to delete.</param>
        public void AddKeyToDelete(Primitive hashKey)
        {
            AddKeyToDelete(hashKey, null);
        }

        /// <summary>
        /// Add a single item to delete, identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to delete.</param>
        /// <param name="rangeKey">Range key element of the item to delete.</param>
        public void AddKeyToDelete(Primitive hashKey, Primitive rangeKey)
        {
            AddKeyToDelete(TargetTable.MakeKey(hashKey, rangeKey));
        }

        /// <summary>
        /// Add a single item to delete, identified by a Document object.
        /// </summary>
        /// <param name="document">Document representing the item to be deleted.</param>
        public void AddItemToDelete(Document document)
        {
            AddKeyToDelete(TargetTable.MakeKey(document));
        }

        #endregion


        #region Public Put methods

        /// <summary>
        /// Add a single Document to put.
        /// </summary>
        /// <param name="document">Document to put.</param>
        public void AddDocumentToPut(Document document)
        {
            ToPut.Add(document);
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Creates a MultiTableDocumentBatchWrite object that is a combination
        /// of the current DocumentBatchWrite and the specified DocumentBatchWrite.
        /// </summary>
        /// <param name="otherBatch">Other DocumentBatchWrite object.</param>
        /// <returns>
        /// MultiTableDocumentBatchWrite consisting of the two DocumentBatchWrite
        /// objects.
        /// </returns>
        public MultiTableDocumentBatchWrite Combine(DocumentBatchWrite otherBatch)
        {
            return new MultiTableDocumentBatchWrite(this, otherBatch);
        }

        /// <summary>
        /// Executes a server call to batch-put/delete the item specified.
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
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.DocumentBatchWrite.Execute"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecute
        ///         operation.</returns>
        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { ExecuteHelper(true); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.DocumentBatchWrite.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion


        #region Internal methods

        internal void ExecuteHelper(bool isAsync)
        {
            MultiBatchWrite multiBatchWrite = new MultiBatchWrite
            {
                Batches = new List<DocumentBatchWrite> { this }
            };
            multiBatchWrite.WriteItems(isAsync);
        }

        internal void AddKeyToDelete(Key key)
        {
            ToDelete.Add(key);
        }

        #endregion
    }

    /// <summary>
    /// Class for putting and/or deleting a batch of items in multiple DynamoDB tables.
    /// </summary>
    public class MultiTableDocumentBatchWrite
    {
        #region Properties

        /// <summary>
        /// List of DocumentBatchWrite objects to include in the multi-table
        /// batch request.
        /// </summary>
        public List<DocumentBatchWrite> Batches { get; private set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableDocumentBatchWrite object from a number of
        /// DocumentBatchWrite objects.
        /// </summary>
        /// <param name="batches">Collection of DocumentBatchWrite objects.</param>
        public MultiTableDocumentBatchWrite(params DocumentBatchWrite[] batches)
        {
            if (batches == null)
                throw new ArgumentNullException("batches");

            Batches = new List<DocumentBatchWrite>(batches);
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a DocumentBatchWrite object to the multi-table batch request.
        /// </summary>
        /// <param name="batch">DocumentBatchWrite to add.</param>
        public void AddBatch(DocumentBatchWrite batch)
        {
            Batches.Add(batch);
        }

        /// <summary>
        /// Executes a multi-table batch put/delete against all configured batches.
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
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.MultiTableDocumentBatchWrite.Execute"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecute
        ///         operation.</returns>
        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { ExecuteHelper(true); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.MultiTableDocumentBatchWrite.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion


        #region Internal methods

        internal void ExecuteHelper(bool isAsync)
        {
            MultiBatchWrite multiBatchWrite = new MultiBatchWrite
            {
                Batches = Batches
            };
            multiBatchWrite.WriteItems(isAsync);
        }

        #endregion
    }


    /// <summary>
    /// Internal class for handling multi-table batch writes.
    /// </summary>
    internal class MultiBatchWrite
    {
        /// <summary>
        /// Maximum number of items that can be sent in a single BatchWrite request
        /// </summary>
        public const int MaxItemsPerCall = 25;

        /// <summary>
        /// Batches that comprise the current BatchWrite operation
        /// </summary>
        public List<DocumentBatchWrite> Batches { get; set; }

        /// <summary>
        /// Pushes items configured in Batches to the server
        /// </summary>
        /// <param name="isAsync"></param>
        public void WriteItems(bool isAsync)
        {
            WriteItemsHelper(Batches, isAsync);
        }

        #region Private helper methods

        private void WriteItemsHelper(List<DocumentBatchWrite> batches, bool isAsync)
        {
            if (Batches == null || Batches.Count == 0)
                return;

            Dictionary<string, QuickList<WriteRequest>> writeRequestsMap = ConvertBatches(batches);
            Table targetTable = this.Batches[0].TargetTable;
            while (true)
            {
                Dictionary<string, QuickList<WriteRequest>> nextSet = GetNextWriteItems(ref writeRequestsMap, MaxItemsPerCall);
                if (nextSet.Count == 0)
                    break;

                SendSet(nextSet, targetTable, isAsync);
            }
        }

        private void SendSet(Dictionary<string, QuickList<WriteRequest>> set, Table targetTable, bool isAsync)
        {
            BatchWriteItemRequest request = ConstructRequest(set, targetTable, isAsync);
            if (request.RequestItems.Count == 0)
                return;

            bool shouldTrySmallerRequest = false;
            try
            {
                CallUntilCompletion(request, targetTable.DDBClient);
            }
            catch (AmazonDynamoDBException addbex)
            {
                if (addbex.StatusCode == HttpStatusCode.RequestEntityTooLarge)
                    shouldTrySmallerRequest = true;
                else
                    throw;
            }

            if (shouldTrySmallerRequest)
            {
                int totalWrites = GetNumberOfWrites(request);
                if (totalWrites >= 2)
                {
                    // 2 or more items in request, retry with the request split up
                    var partialSet = GetNextWriteItems(ref set, totalWrites / 2);
                    SendSet(partialSet, targetTable, isAsync);
                    SendSet(set, targetTable, isAsync);
                }
                else
                {
                    // only 1 item in request, retry as-is
                    SendSet(set, targetTable, isAsync);
                }
            }
        }

        private int GetNumberOfWrites(BatchWriteItemRequest request)
        {
            int totalWrites = 0;
            foreach (var writeItem in request.RequestItems)
            {
                var writes = writeItem.Value;
                totalWrites += (writes == null ? 0 : writes.Count);
            }
            return totalWrites;
        }

        private BatchWriteItemRequest ConstructRequest(Dictionary<string, QuickList<WriteRequest>> writeItems, Table targetTable, bool isAsync)
        {
            BatchWriteItemRequest request = new BatchWriteItemRequest();
            foreach (var writeItem in writeItems)
            {
                string tableName = writeItem.Key;
                List<WriteRequest> requestItems = writeItem.Value.GetItems();
                if (requestItems != null && requestItems.Count > 0)
                {
                    request.RequestItems[tableName] = requestItems;
                }
            }

            request.BeforeRequestEvent += isAsync ?
                new RequestEventHandler(targetTable.UserAgentRequestEventHandlerAsync) :
                new RequestEventHandler(targetTable.UserAgentRequestEventHandlerSync);

            return request;
        }

        private Dictionary<string, QuickList<WriteRequest>> GetNextWriteItems(ref Dictionary<string, QuickList<WriteRequest>> writeRequestsMap, int maxNumberOfItems)
        {
            int numberOfItems = 0;
            Dictionary<string, QuickList<WriteRequest>> nextItems = new Dictionary<string, QuickList<WriteRequest>>();
            List<string> keys = new List<string>(writeRequestsMap.Keys);
            foreach (string tableName in keys)
            {
                if (numberOfItems >= maxNumberOfItems)
                    break;

                QuickList<WriteRequest> writeRequests = writeRequestsMap[tableName];
                if (writeRequests.Count == 0)
                    continue;

                IEnumerable<WriteRequest> partialRequests = writeRequests.RemoveFromHead(maxNumberOfItems - numberOfItems);
                QuickList<WriteRequest> partialRequestsList = new QuickList<WriteRequest>(partialRequests);

                nextItems[tableName] = partialRequestsList;
                numberOfItems += partialRequestsList.Count;
            }

            return nextItems;
        }

        private void CallUntilCompletion(BatchWriteItemRequest request, AmazonDynamoDB client)
        {
            do
            {
                var batchWriteItemResponse = client.BatchWriteItem(request);
                var result = batchWriteItemResponse.BatchWriteItemResult;
                request.RequestItems = result.UnprocessedItems;
            } while (request.RequestItems.Count > 0);
        }

        private Dictionary<string, QuickList<WriteRequest>> ConvertBatches(List<DocumentBatchWrite> batches)
        {
            Dictionary<string, QuickList<WriteRequest>> result = new Dictionary<string, QuickList<WriteRequest>>();

            foreach (var batch in batches)
            {
                List<WriteRequest> writeRequests = new List<WriteRequest>();
                if (batch.ToDelete != null)
                {
                    foreach (var toDelete in batch.ToDelete)
                        writeRequests.Add(new WriteRequest
                        {
                            DeleteRequest = new DeleteRequest { Key = toDelete }
                        });
                }
                if (batch.ToPut != null)
                {
                    foreach (var toPut in batch.ToPut)
                        writeRequests.Add(new WriteRequest
                        {
                            PutRequest = new PutRequest { Item = toPut.ToAttributeMap() }
                        });
                }

                if (writeRequests.Count > 0)
                {
                    QuickList<WriteRequest> qlWriteRequests = new QuickList<WriteRequest>(writeRequests);
                    result.Add(batch.TargetTable.TableName, qlWriteRequests);
                }
            }

            return result;
        }

        #endregion
    }

    internal class QuickList<T>
    {
        private List<T> List;
        private int StartIndex = 0;

        public QuickList(IEnumerable<T> items)
        {
            List = new List<T>(items);
        }

        public int Count
        {
            get
            {
                return List.Count - StartIndex;
            }
        }

        public IEnumerable<T> RemoveFromHead(int numberOfItems)
        {
            int boundedNumberOfItems = Math.Min(numberOfItems, Count);

            for (int i = 0; i < boundedNumberOfItems; i++)
            {
                yield return List[StartIndex];
                StartIndex++;
            }
        }

        public List<T> GetItems()
        {
            return List.GetRange(StartIndex, Count);
        }
    }
}
