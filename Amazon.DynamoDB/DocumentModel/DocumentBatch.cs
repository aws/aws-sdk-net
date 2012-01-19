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
using System.Collections.Generic;

using Amazon.DynamoDB.Model;

namespace Amazon.DynamoDB.DocumentModel
{
    /// <summary>
    /// Class for retrieving a batch of Documents from a single DynamoDB table.
    /// </summary>
    public class DocumentBatchGet
    {
        #region Internal properties

        internal Table TargetTable { get; private set; }
        internal List<Key> Keys { get; private set; }

        #endregion


        #region Public properties

        /// <summary>
        /// List of results retrieved from DynamoDB.
        /// Populated after Execute is called.
        /// </summary>
        public List<Document> Results { get; internal set; }

        /// <summary>
        /// List of attributes to retrieve.
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a DocumentBatchGet instance for a specific table.
        /// </summary>
        /// <param name="targetTable">Table to get items from.</param>
        public DocumentBatchGet(Table targetTable)
        {
            TargetTable = targetTable;
            Keys = new List<Key>();
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Add a single item to get, identified by its hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        public void AddKey(Primitive hashKey)
        {
            AddKey(hashKey, null);
        }

        /// <summary>
        /// Add a single item to get, identified by its hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the item to get.</param>
        /// <param name="rangeKey">Range key element of the item to get.</param>
        public void AddKey(Primitive hashKey, Primitive rangeKey)
        {
            Keys.Add(TargetTable.MakeKey(hashKey, rangeKey));
        }

        /// <summary>
        /// Creates a MultiTableDocumentBatchGet object that is a combination
        /// of the current DocumentBatchGet and the specified DocumentBatchGet.
        /// </summary>
        /// <param name="otherBatch">Other DocumentBatchGet object.</param>
        /// <returns>
        /// MultiTableDocumentBatchGet consisting of the two DocumentBatchGet
        /// objects.
        /// </returns>
        public MultiTableDocumentBatchGet Combine(DocumentBatchGet otherBatch)
        {
            return new MultiTableDocumentBatchGet(this, otherBatch);
        }

        /// <summary>
        /// Executes a server call to batch-get the documents requested.
        /// Populates Results with the retrieved items.
        /// </summary>
        public void Execute()
        {
            MultiBatchGet resultsObject = new MultiBatchGet
            {
                Batches = new List<DocumentBatchGet> { this }
            };

            var results = resultsObject.GetItems();
            Results = results[TargetTable.TableName];
        }

        #endregion


        #region Internal methods

        internal void AddKey(Document document)
        {
            Keys.Add(TargetTable.MakeKey(document));
        }
        internal void AddKey(Key key)
        {
            Keys.Add(key);
        }

        #endregion
    }

    /// <summary>
    /// Class for retrieving a batch of Documents from multiple DynamoDB tables.
    /// </summary>
    public class MultiTableDocumentBatchGet
    {
        #region Properties

        /// <summary>
        /// List of DocumentBatchGet objects to include in the multi-table
        /// batch request.
        /// </summary>
        public List<DocumentBatchGet> Batches { get; private set; }

        /// <summary>
        /// Total number of primary keys in the multi-table batch request.
        /// </summary>
        public int TotalKeys
        {
            get
            {
                int count = 0;
                foreach (var batch in Batches)
                {
                    count += batch.Keys.Count;
                }
                return count;
            }
        }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructs a MultiTableDocumentBatchGet object from a number of
        /// DocumentBatchGet objects.
        /// </summary>
        /// <param name="batches">Collection of DocumentBatchGet objects.</param>
        public MultiTableDocumentBatchGet(params DocumentBatchGet[] batches)
        {
            if (batches == null)
                throw new ArgumentNullException("batches");

            Batches = new List<DocumentBatchGet>(batches);
        }

        #endregion


        #region Public methods
        
        /// <summary>
        /// Add a DocumentBatchGet object to the multi-table batch request.
        /// </summary>
        /// <param name="batch">DocumentBatchGet to add.</param>
        public void AddBatch(DocumentBatchGet batch)
        {
            Batches.Add(batch);
        }

        /// <summary>
        /// Executes a multi-table batch request against all configured batches.
        /// Results are stored in the respective DocumentBatchGet objects.
        /// </summary>
        public void Execute()
        {
            MultiBatchGet resultsObject = new MultiBatchGet
            {
                Batches = Batches
            };

            var results = resultsObject.GetItems();

            foreach (var batch in Batches)
            {
                List<Document> batchResults;
                if (results.TryGetValue(batch.TargetTable.TableName, out batchResults))
                {
                    batch.Results = batchResults;
                }
                else
                {
                    batch.Results = new List<Document>();
                }
            }
        }

        #endregion
    }


    internal class MultiBatchGet
    {
        public List<DocumentBatchGet> Batches { get; set; }

        public Dictionary<string, List<Document>> GetItems()
        {
            var itemsAsDictionaries = GetItemsHelper();
            var itemsAsDocuments = new Dictionary<string, List<Document>>();

            foreach (var kvp in itemsAsDictionaries)
            {
                List<Document> documents = new List<Document>();
                foreach (var dictionary in kvp.Value)
                {
                    documents.Add(Document.FromAttributeMap(dictionary));
                }
                itemsAsDocuments[kvp.Key] = documents;
            }

            return itemsAsDocuments;
        }

        private Dictionary<string, List<Dictionary<string, AttributeValue>>> GetItemsHelper()
        {
            var allItems = new Dictionary<string, List<Dictionary<string, AttributeValue>>>();
            if (Batches == null || Batches.Count == 0)
                return allItems;

            DocumentBatchGet firstBatch = this.Batches[0];
            BatchGetItemRequest request = new BatchGetItemRequest();
            request.BeforeRequestEvent += firstBatch.TargetTable.UserAgentRequestEventHandler;

            foreach (var batch in Batches)
            {
                if (batch.Keys != null && batch.Keys.Count > 0)
                {
                    if (request.RequestItems.ContainsKey(batch.TargetTable.TableName))
                    {
                        throw new InvalidOperationException("Multiple batches refer to the same table.");
                    }

                    request.RequestItems.Add(
                        batch.TargetTable.TableName,
                        new KeysAndAttributes
                        {
                            Keys = batch.Keys,
                            AttributesToGet = batch.AttributesToGet
                        });
                }
            }
            var client = firstBatch.TargetTable.DDBClient;

            do
            {
                var batchGetItemResponse = client.BatchGetItem(request);
                var result = batchGetItemResponse.BatchGetItemResult;

                var responses = result.Responses;
                foreach (var response in responses)
                {
                    string tableName = response.Key;
                    BatchResponse batchResponse = response.Value;
                    List<Dictionary<string, AttributeValue>> items = batchResponse.Items;

                    List<Dictionary<string, AttributeValue>> fetchedItems;
                    if (!allItems.TryGetValue(tableName, out fetchedItems))
                    {
                        fetchedItems = new List<Dictionary<string, AttributeValue>>();
                        allItems[tableName] = fetchedItems;
                    }
                    fetchedItems.AddRange(items);
                }

                request.RequestItems = result.UnprocessedKeys;
            } while (request.RequestItems.Count > 0);

            return allItems;
        }
    }
}
