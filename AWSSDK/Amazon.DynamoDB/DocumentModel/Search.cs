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

using Amazon.DynamoDB.Model;
using Amazon.Runtime;

namespace Amazon.DynamoDB.DocumentModel
{
    /// <summary>
    /// Search response object
    /// </summary>
    public class Search
    {
        #region Internal constructors

        internal Search()
            : this((SearchType)0)
        {
        }

        internal Search(SearchType searchMethod)
        {
            IsDone = false;
            NextKey = null;
            Matches = new List<Document>();
            SearchMethod = searchMethod;
        }

        #endregion


        #region Public properties

        /// <summary>
        /// Name of the table being searched
        /// </summary>
        public String TableName { get; internal set; }

        /// <summary>
        /// Upper limit on the number of items returned.
        /// For Queries: upper limit on the number of items returned.
        /// For Scan: limit on the number of items scanned.
        /// 
        /// Maps directly to Limit property on Query and Scan operations.
        /// </summary>
        public int Limit { get; internal set; }

        /// <summary>
        /// Filter for the search operation
        /// </summary>
        public Filter Filter { get; internal set; }

        /// <summary>
        /// List of attribute names to retrieve
        /// </summary>
        public List<String> AttributesToGet { get; internal set; }

        /// <summary>
        /// Flag that, if true, indicates that the search is operating in consistent-read mode
        /// </summary>
        public bool IsConsistentRead { get; internal set; }

        /// <summary>
        /// HashKey value associated with the search
        /// </summary>
        public AttributeValue HashKey { get; internal set; }

        /// <summary>
        /// Flag that, if true, indicates that the search is traversing backwards
        /// </summary>
        public bool IsBackwardSearch { get; internal set; }

        /// <summary>
        /// Flag that, if true, indicates that the search is done
        /// </summary>
        public bool IsDone { get; internal set; }

        /// <summary>
        /// Key denoting the starting point of the next set of results
        /// </summary>
        public Key NextKey { get; internal set; }

        /// <summary>
        /// List of currently found items
        /// </summary>
        public List<Document> Matches { get; internal set; }

        /// <summary>
        /// Gets the total number of items that match the search parameters
        /// 
        /// If IsDone is true, returns Matches.Count
        /// Otherwise, makes a call to DynamoDB to find out the number of
        /// matching items, without retrieving the items. Count is then cached.
        /// </summary>
        public int Count
        {
            get
            {
                return GetCount();
            }
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Retrieves the next set (page) of results
        /// </summary>
        /// <returns>Next set of Documents matching the search parameters</returns>
        public List<Document> GetNextSet()
        {
            return GetNextSetHelper(false);
        }

        private List<Document> GetNextSetHelper(bool isAsync)
        {
            List<Document> ret = new List<Document>();

            if (!IsDone)
            {
                switch (SearchMethod)
                {
                    case SearchType.Scan:
                        ScanRequest scanReq = new ScanRequest()
                            .WithExclusiveStartKey(NextKey)
                            .WithLimit(Limit)
                            .WithTableName(TableName);
                        scanReq.BeforeRequestEvent += isAsync ?
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerAsync) :
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerSync);
                        if (AttributesToGet != null)
                            scanReq.AttributesToGet = AttributesToGet;
                        scanReq.ScanFilter = (ScanFilter)Filter;
                        ScanResult scanResult = SourceTable.DDBClient.Scan(scanReq).ScanResult;
                        foreach (var item in scanResult.Items)
                        {
                            Document doc = Document.FromAttributeMap(item);
                            ret.Add(doc);
                            Matches.Add(doc);
                        }
                        NextKey = scanResult.LastEvaluatedKey;
                        if (NextKey == null)
                        {
                            IsDone = true;
                        }
                        return ret;
                    case SearchType.Query:
                        QueryRequest queryReq = new QueryRequest()
                            .WithConsistentRead(IsConsistentRead)
                            .WithExclusiveStartKey(NextKey)
                            .WithHashKeyValue(HashKey)
                            .WithLimit(Limit)
                            .WithScanIndexForward(!IsBackwardSearch)
                            .WithTableName(TableName);
                        if (Filter != null)
                            queryReq.RangeKeyCondition = ((RangeFilter)Filter).Condition;
                        queryReq.BeforeRequestEvent += isAsync ?
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerAsync) :
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerSync);
                        if (AttributesToGet != null)
                            queryReq.AttributesToGet = AttributesToGet;
                        QueryResult queryResult = SourceTable.DDBClient.Query(queryReq).QueryResult;
                        foreach (var item in queryResult.Items)
                        {
                            Document doc = Document.FromAttributeMap(item);
                            ret.Add(doc);
                            Matches.Add(doc);
                        }
                        NextKey = queryResult.LastEvaluatedKey;
                        if (NextKey == null)
                        {
                            IsDone = true;
                        }
                        return ret;
                    default:
                        throw new InvalidOperationException("Unknown Search Method");
                }
            }

            return ret;
        }

        /// <summary>
        /// Retrieves all the remaining results
        /// </summary>
        /// <returns>List of Documents matching the search parameters</returns>
        public List<Document> GetRemaining()
        {
            return GetRemainingHelper(false);
        }

        private List<Document> GetRemainingHelper(bool isAsync)
        {
            List<Document> ret = new List<Document>();

            while (!IsDone)
            {
                foreach (Document doc in GetNextSetHelper(isAsync))
                {
                    ret.Add(doc);
                }
            }

            return ret;
        }

        #endregion


        #region Async public 

        /// <summary>
        /// Initiates the asynchronous execution of the GetNextSet operation.
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.Search.GetNextSet"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNextSet
        ///         operation.</returns>
        public IAsyncResult BeginGetNextSet(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetNextSetHelper(true), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.Search.GetNextSet"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNextSet.</param>
        /// <returns>Next set of Documents matching the search parameters</returns>
        public List<Document> EndGetNextSet(IAsyncResult asyncResult)
        {
            return DynamoDBAsyncExecutor.EndOperation(asyncResult) as List<Document>;
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRemaining operation.
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.Search.GetRemaining"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRemaining
        ///         operation.</returns>
        public IAsyncResult BeginGetRemaining(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetRemainingHelper(true), callback, state);
        }
        /// <summary>
        /// Finishes the asynchronous execution of the GetRemaining operation.
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.Search.GetRemaining"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRemaining.</param>
        /// <returns>List of Documents matching the search parameters</returns>
        public List<Document> EndGetRemaining(IAsyncResult asyncResult)
        {
            return DynamoDBAsyncExecutor.EndOperation(asyncResult) as List<Document>;
        }

        #endregion

        #region Private/internal properties

        private int count = -1;

        private SearchType SearchMethod { get; set; }

        internal Table SourceTable { get; set; }

        private int GetCount()
        {
            if (IsDone)
            {
                return Matches.Count;
            }
            else
            {
                if (count != -1)
                {
                    return count;
                }
                else
                {
                    switch (SearchMethod)
                    {
                        case SearchType.Scan:
                            ScanRequest scanReq = new ScanRequest()
                                .WithCount(true)
                                .WithExclusiveStartKey(NextKey)
                                .WithTableName(TableName)
                                .WithBeforeRequestHandler(SourceTable.UserAgentRequestEventHandlerSync) as ScanRequest;
                            scanReq.ScanFilter = (ScanFilter)Filter;
                            ScanResult scanResult = SourceTable.DDBClient.Scan(scanReq).ScanResult;
                            count = Matches.Count + scanResult.Count;
                            return count;
                        case SearchType.Query:
                            QueryRequest queryReq = new QueryRequest()
                                .WithConsistentRead(IsConsistentRead)
                                .WithCount(true)
                                .WithExclusiveStartKey(NextKey)
                                .WithHashKeyValue(HashKey)
                                .WithRangeKeyCondition(((RangeFilter)Filter).Condition)
                                .WithScanIndexForward(!IsBackwardSearch)
                                .WithTableName(TableName)
                                .WithBeforeRequestHandler(SourceTable.UserAgentRequestEventHandlerSync) as QueryRequest;
                            QueryResult queryResult = SourceTable.DDBClient.Query(queryReq).QueryResult;
                            count = Matches.Count + queryResult.Count;
                            return count;
                        default:
                            throw new InvalidOperationException("Unknown Search Method");
                    }
                }
            }
        }

        #endregion
    }
}
