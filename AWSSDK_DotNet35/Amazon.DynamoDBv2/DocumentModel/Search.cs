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

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Search response object
    /// </summary>
    public partial class Search
    {
        #region Internal constructors

        internal Search()
            : this((SearchType)0)
        {
        }

        internal Search(SearchType searchMethod)
        {
            SearchMethod = searchMethod;
            Reset();
        }

        #endregion


        #region Public properties

        /// <summary>
        /// Name of the table being searched
        /// </summary>
        public String TableName { get; internal set; }

        /// <summary>
        /// Whether to collect GetNextSet and GetRemaining results in Matches property.
        /// Default is true. If set to false, Matches will always be empty.
        /// </summary>
        public bool CollectResults { get; internal set; }

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
        /// Flag that, if true, indicates that the search is traversing backwards
        /// </summary>
        public bool IsBackwardSearch { get; internal set; }

        /// <summary>
        /// Flag that, if true, indicates that the search is done
        /// </summary>
        public bool IsDone { get; private set; }

        /// <summary>
        /// Key denoting the starting point of the next set of results
        /// </summary>
        public Dictionary<string, AttributeValue> NextKey { get; private set; }

        /// <summary>
        /// List of currently found items
        /// </summary>
        public List<Document> Matches { get; private set; }

        /// <summary>
        /// For parallel <i>Scan</i> requests, <i>TotalSegments</i>represents the total number of segments for a table that is being scanned. Segments
        /// are a way to logically divide a table into equally sized portions, for the duration of the <i>Scan</i> request. The value of
        /// <i>TotalSegments</i> corresponds to the number of application "workers" (such as threads or processes) that will perform the parallel
        /// <i>Scan</i>. For example, if you want to scan a table using four application threads, you would specify a <i>TotalSegments</i> value of 4.
        /// The value for <i>TotalSegments</i> must be greater than or equal to 1, and less than or equal to 4096. If you specify a <i>TotalSegments</i>
        /// value of 1, the <i>Scan</i> will be sequential rather than parallel. If you specify <i>TotalSegments</i>, you must also specify
        /// <i>Segment</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 4096</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int TotalSegments { get; set; }

        /// <summary>
        /// For parallel <i>Scan</i> requests, <i>Segment</i> identifies an individual segment to be scanned by an application "worker" (such as a
        /// thread or a process). Each worker issues a <i>Scan</i> request with a distinct value for the segment it will scan. Segment IDs are
        /// zero-based, so the first segment is always 0. For example, if you want to scan a table using four application threads, the first thread
        /// would specify a <i>Segment</i> value of 0, the second thread would specify 1, and so on. LastEvaluatedKey returned from a parallel scan
        /// request must be used with same Segment id in a subsequent operation. The value for <i>Segment</i> must be less than or equal to 0, and less
        /// than the value provided for <i>TotalSegments</i>. If you specify <i>Segment</i>, you must also specify <i>TotalSegments</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 4095</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Segment { get; set; }

        /// <summary>
        /// Gets the total number of items that match the search parameters.
        /// 
        /// If IsDone is true and CollectResults is true, returns Matches.Count.
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

        /// <summary>
        /// Name of the index to query against.
        /// </summary>
        public string IndexName { get; internal set; }

        /// <summary>
        /// Enum specifying what data to return from query.
        /// </summary>
        public SelectValues Select { get; internal set; }

        #endregion


        #region Public methods

        internal List<Document> GetNextSetHelper(bool isAsync)
        {
            List<Document> ret = new List<Document>();

            if (!IsDone)
            {
                switch (SearchMethod)
                {
                    case SearchType.Scan:
                        ScanRequest scanReq = new ScanRequest
                        {
                            ExclusiveStartKey = NextKey,
                            Limit = Limit,
                            TableName = TableName,
                            AttributesToGet = AttributesToGet,
                            ScanFilter = Filter,
                            Select = EnumToStringMapper.Convert(Select)
                        };

                        if (this.TotalSegments != 0)
                        {
                            scanReq.TotalSegments = this.TotalSegments;
                            scanReq.Segment = this.Segment;
                        }

                        scanReq.BeforeRequestEvent += isAsync ?
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerAsync) :
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerSync);

                        ScanResult scanResult = SourceTable.DDBClient.Scan(scanReq);
                        foreach (var item in scanResult.Items)
                        {
                            Document doc = Document.FromAttributeMap(item);
                            ret.Add(doc);
                            if (CollectResults)
                            {
                            Matches.Add(doc);
                        }
                        }
                        NextKey = scanResult.LastEvaluatedKey;
                        if (NextKey == null || NextKey.Count == 0)
                        {
                            IsDone = true;
                        }
                        return ret;
                    case SearchType.Query:
                        QueryRequest queryReq = new QueryRequest
                        {
                            ConsistentRead = IsConsistentRead,
                            ExclusiveStartKey = NextKey,
                            Limit = Limit,
                            ScanIndexForward = !IsBackwardSearch,
                            TableName = TableName,
                            AttributesToGet = AttributesToGet,
                            KeyConditions = Filter,
                            IndexName = IndexName,
                            Select = EnumToStringMapper.Convert(Select)
                        };
                        queryReq.BeforeRequestEvent += isAsync ?
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerAsync) :
                            new RequestEventHandler(SourceTable.UserAgentRequestEventHandlerSync);

                        QueryResult queryResult = SourceTable.DDBClient.Query(queryReq);
                        foreach (var item in queryResult.Items)
                        {
                            Document doc = Document.FromAttributeMap(item);
                            ret.Add(doc);
                            if (CollectResults)
                            {
                            Matches.Add(doc);
                        }
                        }
                        NextKey = queryResult.LastEvaluatedKey;
                        if (NextKey == null || NextKey.Count == 0)
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

        internal List<Document> GetRemainingHelper(bool isAsync)
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


        #region Private/internal properties

        private int count;

        private SearchType SearchMethod { get; set; }

        internal Table SourceTable { get; set; }

        private int GetCount()
        {
            if (IsDone && CollectResults)
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
                            ScanRequest scanReq = new ScanRequest
                            {
                                TableName = TableName,
                                Select = EnumToStringMapper.Convert(SelectValues.Count),
                                ExclusiveStartKey = NextKey,
                                ScanFilter = Filter,
                            };

                            if (this.TotalSegments != 0)
                            {
                                scanReq.TotalSegments = this.TotalSegments;
                                scanReq.Segment = this.Segment;
                            }
                            scanReq.BeforeRequestEvent += SourceTable.UserAgentRequestEventHandlerSync;

                            ScanResult scanResult = SourceTable.DDBClient.Scan(scanReq);
                            count = Matches.Count + scanResult.Count;
                            return count;
                        case SearchType.Query:
                            QueryRequest queryReq = new QueryRequest
                            {
                                TableName = TableName,
                                ConsistentRead = IsConsistentRead,
                                Select = EnumToStringMapper.Convert(SelectValues.Count),
                                ExclusiveStartKey = NextKey,
                                ScanIndexForward = !IsBackwardSearch,
                                KeyConditions = Filter,
                                IndexName = IndexName
                            };
                            queryReq.BeforeRequestEvent += SourceTable.UserAgentRequestEventHandlerSync;

                            QueryResult queryResult = SourceTable.DDBClient.Query(queryReq);
                            count = Matches.Count + queryResult.Count;
                            return count;
                        default:
                            throw new InvalidOperationException("Unknown Search Method");
                    }
                }
            }
        }

        /// <summary>
        /// Resets the Search object to default state.
        /// </summary>
        internal void Reset()
        {
            count = -1;
            IsDone = false;
            NextKey = null;
            Matches = new List<Document>();
            CollectResults = true;
        }

        #endregion
    }
}
