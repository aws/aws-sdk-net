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

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Telemetry.Tracing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Represents the interface for a search response
    /// </summary>
    public partial interface ISearch
    {
        /// <summary>
        /// Name of the table being searched
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// Whether to collect GetNextSet and GetRemaining results in Matches property.
        /// Default is true. If set to false, Matches will always be empty.
        /// </summary>
        bool CollectResults { get; }

        /// <summary>
        /// Upper limit on the number of items returned.
        /// For Queries: upper limit on the number of items returned.
        /// For Scan: limit on the number of items scanned.
        /// 
        /// Maps directly to Limit property on Query and Scan operations.
        /// </summary>
        int Limit { get; }

        /// <summary>
        /// The key expression that is evaluated for each item of a query.
        /// This applies only to Query operations.
        /// </summary>
        Expression KeyExpression { get; set; }

        /// <summary>
        /// The filter expression that is evaluated for each item.
        /// This applies to Query and Scan operations.
        /// </summary>
        Expression FilterExpression { get; set; }

        /// <summary>
        /// The projection expression that identifies the attributes to retrieve.
        /// </summary>
        Expression ProjectionExpression { get; set; }

        /// <summary>
        /// Filter for the search operation
        /// This applies to Query and Scan operations.
        /// </summary>
        Filter Filter { get; }

        /// <summary>
        /// Conditional operator for the search operation
        /// </summary>
        ConditionalOperatorValues ConditionalOperator { get; }

        /// <summary>
        /// List of attribute names to retrieve
        /// </summary>
        List<String> AttributesToGet { get; }

        /// <summary>
        /// Flag that, if true, indicates that the search is operating in consistent-read mode
        /// </summary>
        bool IsConsistentRead { get; }

        /// <summary>
        /// Flag that, if true, indicates that the search is traversing backwards
        /// </summary>
        bool IsBackwardSearch { get; }

        /// <summary>
        /// Flag that, if true, indicates that the search is done
        /// </summary>
        bool IsDone { get; }

        /// <summary>
        /// Key denoting the starting point of the next set of results
        /// </summary>
        Dictionary<string, AttributeValue> NextKey { get; }

        /// <summary>
        /// Pagination token corresponding to the item where the search operation stopped,
        /// inclusive of the previous result set. Use this value to start a new
        /// operation to resume search from the next item.
        /// </summary>
        string PaginationToken { get; }

        /// <summary>
        /// List of currently found items
        /// </summary>
        List<Document> Matches { get; }

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
        int TotalSegments { get; set; }

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
        int Segment { get; set; }

        /// <summary>
        /// Gets the total number of items that match the search parameters.
        /// 
        /// If IsDone is true and CollectResults is true, returns Matches.Count.
        /// Otherwise, makes a call to DynamoDB to find out the number of
        /// matching items, without retrieving the items. Count is then cached.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the total number of items evaluated, before any ScanFilter is applied, for the current call.
        /// <para>
        /// The number of items evaluated, before any <c>ScanFilter</c> is applied. A high <c>ScannedCount</c>
        /// value with few, or no, <c>Count</c> results indicates an inefficient <c>Scan</c> operation.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html#Count">Count
        /// and ScannedCount</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para>
        /// This value is specific to each call of <c>GetNextSetAsync</c> or <c>GetRemainingAsync</c>.
        /// It is not an accumulated value across multiple calls.
        /// </para>
        /// <para>
        /// If you did not use a filter in the request, then <c>ScannedCount</c> is the same as
        /// <c>Count</c>.
        /// </para>
        /// </summary>
        int ScannedCount { get; }

        /// <summary>
        /// Name of the index to query or scan against.
        /// </summary>
        string IndexName { get; }

        /// <summary>
        /// Enum specifying what data to return from query.
        /// </summary>
        SelectValues Select { get; }
    }

    /// <summary>
    /// Search response object
    /// </summary>
    public partial class Search : ISearch
    {
        #region Internal constructors

        internal Search()
            : this((SearchType)0)
        {
        }

        internal Search(SearchType searchMethod)
        {
            SearchMethod = searchMethod;
            ReturnConsumedCapacity = ReturnConsumedCapacity.NONE;
            Reset();
            TracerProvider = SourceTable?.DDBClient?.Config?.TelemetryProvider?.TracerProvider
                             ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }

        #endregion


        #region Public properties

        /// <inheritdoc/>
        public string TableName { get; internal set; }

        /// <inheritdoc/>
        public bool CollectResults { get; internal set; }

        /// <inheritdoc/>
        public int Limit { get; internal set; }

        /// <inheritdoc/>
        public Expression KeyExpression { get; set; }

        /// <inheritdoc/>
        public Expression FilterExpression { get; set; }

        /// <inheritdoc/>
        public Expression ProjectionExpression { get; set; }

        /// <inheritdoc/>
        public Filter Filter { get; internal set; }

        /// <inheritdoc/>
        public ConditionalOperatorValues ConditionalOperator { get; internal set; }

        /// <inheritdoc/>
        public List<String> AttributesToGet { get; internal set; }

        /// <inheritdoc/>
        public bool IsConsistentRead { get; internal set; }

        /// <inheritdoc/>
        public bool IsBackwardSearch { get; internal set; }

        /// <inheritdoc/>
        public bool IsDone { get; private set; }

        /// <inheritdoc/>
        public Dictionary<string, AttributeValue> NextKey { get; private set; }

        /// <summary>
        /// Aggregated per-call and accumulated metrics for this search operation.
        /// </summary>
        public SearchMetrics Metrics => _metrics;

        /// <summary>
        /// The ReturnConsumedCapacity setting used for this search (NONE, TOTAL, INDEXES).
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity { get; internal set; }

        /// <inheritdoc/>
        public string PaginationToken
        {
            get { return Common.ToPaginationToken(NextKey); }
            internal set { NextKey = Common.FromPaginationToken(value); }
        }

        /// <inheritdoc/>
        public List<Document> Matches { get; private set; }

        /// <inheritdoc/>
        public int TotalSegments { get; set; }

        /// <inheritdoc/>
        public int Segment { get; set; }

        /// <inheritdoc/>
        public int Count => GetCount();

        /// <inheritdoc/>
        public int ScannedCount => scannedCount;

        /// <inheritdoc/>
        public string IndexName { get; internal set; }

        /// <inheritdoc/>
        public SelectValues Select { get; internal set; }

        #endregion


        #region Private/internal members

        internal TracerProvider TracerProvider { get; private set; }

        internal List<Document> GetNextSetHelper()
        {
            List<Document> ret = new List<Document>();

#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var internalClient = SourceTable.DDBClient as AmazonDynamoDBClient;
            if (internalClient == null)
            {
                throw new InvalidOperationException("Calling the synchronous GetNextSet() from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when calling GetNextSetAsync instead.");
            }
#else
            var internalClient = SourceTable.DDBClient;
#endif

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
                            Select = EnumMapper.Convert(Select),
                            ConsistentRead = IsConsistentRead
                        };

                        if (this.Filter != null)
                        {
                            var scanFilter = Filter.ToConditions(SourceTable);
                            if (scanFilter?.Count > 0)
                                scanReq.ScanFilter = scanFilter;
                        }

                        if (!string.IsNullOrEmpty(this.IndexName))
                            scanReq.IndexName = this.IndexName;
                        if (this.FilterExpression != null && this.FilterExpression.IsSet)
                            this.FilterExpression.ApplyExpression(scanReq, SourceTable);
                        if (scanReq.ScanFilter != null && scanReq.ScanFilter.Count > 1)
                            scanReq.ConditionalOperator = EnumMapper.Convert(ConditionalOperator);
                        if (this.AttributesToGet != null)
                        {
                            Common.ConvertAttributesToGetToProjectionExpression(scanReq);
                        }

                        if (this.ProjectionExpression != null && this.ProjectionExpression.IsSet)
                        {
                            this.ProjectionExpression.ApplyExpression(scanReq, SourceTable);
                        }

                        if (this.TotalSegments != 0)
                        {
                            scanReq.TotalSegments = this.TotalSegments;
                            scanReq.Segment = this.Segment;
                        }

                        if (ReturnConsumedCapacity != ReturnConsumedCapacity.NONE)
                            scanReq.ReturnConsumedCapacity = ReturnConsumedCapacity;

                        SourceTable.UpdateRequestUserAgentDetails(scanReq, isAsync: false);

                        var scanResult = internalClient.Scan(scanReq);
                        if (scanResult.Items != null)
                        {
                            foreach (var item in scanResult.Items)
                            {
                                Document doc = SourceTable.FromAttributeMap(item);
                                ret.Add(doc);
                                if (CollectResults)
                                {
                                    Matches.Add(doc);
                                }
                            }
                        }

                        NextKey = scanResult.LastEvaluatedKey;
                        scannedCount = scanResult.ScannedCount.GetValueOrDefault();
                        UpdateMetricsAfterPage(scanResult.ConsumedCapacity, scanResult.ScannedCount.GetValueOrDefault(),
                            ret.Count);
                        if (NextKey == null || NextKey.Count == 0)
                        {
                            IsDone = true;
                        }

                        return ret;
                    case SearchType.Query:
                        QueryRequest queryReq = new QueryRequest
                        {
                            TableName = TableName,
                            ConsistentRead = IsConsistentRead,
                            Select = EnumMapper.Convert(Select),
                            ExclusiveStartKey = NextKey,
                            Limit = Limit,
                            ScanIndexForward = !IsBackwardSearch,
                            AttributesToGet = AttributesToGet,
                            IndexName = IndexName,
                        };

                        Expression.ApplyExpression(queryReq, SourceTable, KeyExpression, FilterExpression);

                        if (Filter != null)
                        {
                            SplitQueryFilter(Filter, SourceTable, queryReq.IndexName, out var keyConditions,
                                out var filterConditions);
                            queryReq.KeyConditions = keyConditions?.Count > 0 ? keyConditions : null;
                            queryReq.QueryFilter = filterConditions?.Count > 0 ? filterConditions : null;
                        }

                        if (this.AttributesToGet != null)
                        {
                            Common.ConvertAttributesToGetToProjectionExpression(queryReq);
                        }

                        if (this.ProjectionExpression != null && this.ProjectionExpression.IsSet)
                        {
                            queryReq.ProjectionExpression = this.ProjectionExpression.ExpressionStatement;
                            foreach (var ean in this.ProjectionExpression.ExpressionAttributeNames)
                            {
                                queryReq.ExpressionAttributeNames.Add(ean.Key, ean.Value);
                            }
                        }

                        if (queryReq.QueryFilter != null && queryReq.QueryFilter.Count > 1)
                            queryReq.ConditionalOperator = EnumMapper.Convert(ConditionalOperator);

                        if (ReturnConsumedCapacity != ReturnConsumedCapacity.NONE)
                            queryReq.ReturnConsumedCapacity = ReturnConsumedCapacity;

                        SourceTable.UpdateRequestUserAgentDetails(queryReq, isAsync: false);

                        var queryResult = internalClient.Query(queryReq);
                        if (queryResult.Items != null)
                        {
                            foreach (var item in queryResult.Items)
                            {
                                Document doc = SourceTable.FromAttributeMap(item);
                                ret.Add(doc);
                                if (CollectResults)
                                {
                                    Matches.Add(doc);
                                }
                            }
                        }

                        NextKey = queryResult.LastEvaluatedKey;
                        scannedCount = queryResult.ScannedCount.GetValueOrDefault();
                        UpdateMetricsAfterPage(queryResult.ConsumedCapacity,
                            queryResult.ScannedCount.GetValueOrDefault(), ret.Count);
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

        internal async Task<List<Document>> GetNextSetHelperAsync(CancellationToken cancellationToken)
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
                            Select = EnumMapper.Convert(Select),
                            ConsistentRead = IsConsistentRead
                        };

                        if (this.Filter != null)
                        {
                            var scanFilter = Filter.ToConditions(SourceTable);
                            if (scanFilter?.Count > 0)
                                scanReq.ScanFilter = scanFilter;
                        }

                        if (!string.IsNullOrEmpty(this.IndexName))
                            scanReq.IndexName = this.IndexName;
                        if (this.FilterExpression != null && this.FilterExpression.IsSet)
                            this.FilterExpression.ApplyExpression(scanReq, SourceTable);
                        if (scanReq.ScanFilter != null && scanReq.ScanFilter.Count > 1)
                            scanReq.ConditionalOperator = EnumMapper.Convert(ConditionalOperator);
                        if (this.AttributesToGet != null)
                        {
                            Common.ConvertAttributesToGetToProjectionExpression(scanReq);
                        }

                        if (this.ProjectionExpression != null && this.ProjectionExpression.IsSet)
                        {
                            this.ProjectionExpression.ApplyExpression(scanReq, SourceTable);
                        }

                        if (this.TotalSegments != 0)
                        {
                            scanReq.TotalSegments = this.TotalSegments;
                            scanReq.Segment = this.Segment;
                        }

                        if (ReturnConsumedCapacity != ReturnConsumedCapacity.NONE)
                            scanReq.ReturnConsumedCapacity = ReturnConsumedCapacity;

                        SourceTable.UpdateRequestUserAgentDetails(scanReq, isAsync: true);

                        var scanResult = await SourceTable.DDBClient.ScanAsync(scanReq, cancellationToken)
                            .ConfigureAwait(false);
                        if (scanResult.Items != null)
                        {
                            foreach (var item in scanResult.Items)
                            {
                                Document doc = SourceTable.FromAttributeMap(item);
                                ret.Add(doc);
                                if (CollectResults)
                                {
                                    Matches.Add(doc);
                                }
                            }
                        }

                        NextKey = scanResult.LastEvaluatedKey;
                        scannedCount = scanResult.ScannedCount.GetValueOrDefault();
                        UpdateMetricsAfterPage(scanResult.ConsumedCapacity, scanResult.ScannedCount.GetValueOrDefault(),
                            ret.Count);

                        if (NextKey == null || NextKey.Count == 0)
                        {
                            IsDone = true;
                        }

                        return ret;
                    case SearchType.Query:
                        QueryRequest queryReq = new QueryRequest
                        {
                            TableName = TableName,
                            ConsistentRead = IsConsistentRead,
                            Select = EnumMapper.Convert(Select),
                            ExclusiveStartKey = NextKey,
                            Limit = Limit,
                            ScanIndexForward = !IsBackwardSearch,
                            AttributesToGet = AttributesToGet,
                            IndexName = IndexName,
                        };

                        Expression.ApplyExpression(queryReq, SourceTable, KeyExpression, FilterExpression);

                        if (Filter != null)
                        {
                            Dictionary<string, Condition> keyConditions, filterConditions;
                            SplitQueryFilter(Filter, SourceTable, queryReq.IndexName, out keyConditions,
                                out filterConditions);
                            queryReq.KeyConditions = keyConditions?.Count > 0 ? keyConditions : null;
                            queryReq.QueryFilter = filterConditions?.Count > 0 ? filterConditions : null;
                        }

                        if (this.AttributesToGet != null)
                        {
                            Common.ConvertAttributesToGetToProjectionExpression(queryReq);
                        }

                        if (this.ProjectionExpression != null && this.ProjectionExpression.IsSet)
                        {
                            queryReq.ProjectionExpression = this.ProjectionExpression.ExpressionStatement;
                            foreach (var ean in this.ProjectionExpression.ExpressionAttributeNames)
                            {
                                queryReq.ExpressionAttributeNames.Add(ean.Key, ean.Value);
                            }
                        }

                        if (queryReq.QueryFilter != null && queryReq.QueryFilter.Count > 1)
                            queryReq.ConditionalOperator = EnumMapper.Convert(ConditionalOperator);

                        if (ReturnConsumedCapacity != ReturnConsumedCapacity.NONE)
                            queryReq.ReturnConsumedCapacity = ReturnConsumedCapacity;

                        SourceTable.UpdateRequestUserAgentDetails(queryReq, isAsync: true);

                        var queryResult = await SourceTable.DDBClient.QueryAsync(queryReq, cancellationToken)
                            .ConfigureAwait(false);
                        if (queryResult.Items != null)
                        {
                            foreach (var item in queryResult.Items)
                            {
                                Document doc = SourceTable.FromAttributeMap(item);
                                ret.Add(doc);
                                if (CollectResults)
                                {
                                    Matches.Add(doc);
                                }
                            }
                        }

                        NextKey = queryResult.LastEvaluatedKey;
                        scannedCount = queryResult.ScannedCount.GetValueOrDefault();
                        UpdateMetricsAfterPage(queryResult.ConsumedCapacity,
                            queryResult.ScannedCount.GetValueOrDefault(), ret.Count);

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

        internal List<Document> GetRemainingHelper()
        {
            List<Document> ret = new List<Document>();

            while (!IsDone)
            {
                var previousScannedCount = scannedCount;
                foreach (Document doc in GetNextSetHelper())
                {
                    ret.Add(doc);
                }

                scannedCount += previousScannedCount;
            }

            return ret;
        }

        internal async Task<List<Document>> GetRemainingHelperAsync(CancellationToken cancellationToken)
        {
            List<Document> ret = new List<Document>();

            while (!IsDone)
            {
                var previousScannedCount = scannedCount;
                foreach (Document doc in await GetNextSetHelperAsync(cancellationToken).ConfigureAwait(false))
                {
                    ret.Add(doc);
                }

                scannedCount += previousScannedCount;
            }

            return ret;
        }

        private int count;

        private int scannedCount;

        private SearchType SearchMethod { get; set; }

        internal Table SourceTable { get; set; }

        private static void SplitQueryFilter(Filter filter, Table targetTable, string indexName,
            out Dictionary<string, Condition> keyConditions, out Dictionary<string, Condition> filterConditions)
        {
            QueryFilter queryFilter = filter as QueryFilter;
            if (queryFilter == null) throw new InvalidOperationException("Filter is not of type QueryFilter");

            var conditions = filter.ToConditions(targetTable);
            keyConditions = null;
            filterConditions = null;

            if (conditions.Count > 0)
            {
                keyConditions = new Dictionary<string, Condition>();
                filterConditions = new Dictionary<string, Condition>();
                foreach (var kvp in conditions)
                {
                    string attributeName = kvp.Key;
                    Condition condition = kvp.Value;

                    // depending on whether the attribute is key, place either in keyConditions or filterConditions
                    if (IsKeyAttribute(targetTable, indexName, attributeName))
                        keyConditions[attributeName] = condition;
                    else
                        filterConditions[attributeName] = condition;
                }
            }
        }

        // Test if the given attribute is a key on the table or a key on the given index
        private static bool IsKeyAttribute(Table table, string indexName, string attributeName)
        {
            GlobalSecondaryIndexDescription gsi;
            LocalSecondaryIndexDescription lsi;

            // if no index, check only table keys
            if (string.IsNullOrEmpty(indexName))
                return table.Keys.ContainsKey(attributeName);
            // for an index, check if attribute is part of KeySchema for GSI or LSI
            else if (table.GlobalSecondaryIndexes.TryGetValue(indexName, out gsi) && gsi != null)
                return gsi.KeySchema.Any(AttributeIsKey(attributeName));
            else if (table.LocalSecondaryIndexes.TryGetValue(indexName, out lsi) && lsi != null)
                return lsi.KeySchema.Any(AttributeIsKey(attributeName));
            else
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to locate index [{0}] on table [{1}]", indexName, table.TableName));
        }

        private static Func<KeySchemaElement, bool> AttributeIsKey(string attributeName)
        {
            return (kse => string.Equals(kse.AttributeName, attributeName, StringComparison.Ordinal));
        }

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
#if NETSTANDARD
                    // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
                    var internalClient = SourceTable.DDBClient as AmazonDynamoDBClient;
                    if (internalClient == null)
                    {
                        throw new InvalidOperationException("Accessing the synchronous Count from .NET or .NET Core requires " +
                            "initializing the Table with an actual AmazonDynamoDBClient.");
                    }
#else
                    var internalClient = SourceTable.DDBClient;
#endif
                    switch (SearchMethod)
                    {
                        case SearchType.Scan:
                            ScanRequest scanReq = new ScanRequest
                            {
                                TableName = TableName,
                                Select = EnumMapper.Convert(SelectValues.Count),
                                ExclusiveStartKey = NextKey,
                                ScanFilter = Filter.ToConditions(SourceTable.Conversion,
                                    SourceTable.IsEmptyStringValueEnabled),
                                ConsistentRead = IsConsistentRead
                            };
                            if (!string.IsNullOrEmpty(this.IndexName))
                                scanReq.IndexName = this.IndexName;
                            if (this.FilterExpression != null && this.FilterExpression.IsSet)
                                this.FilterExpression.ApplyExpression(scanReq, SourceTable);
                            if (scanReq.ScanFilter != null && scanReq.ScanFilter.Count > 1)
                                scanReq.ConditionalOperator = EnumMapper.Convert(ConditionalOperator);

                            if (this.TotalSegments != 0)
                            {
                                scanReq.TotalSegments = this.TotalSegments;
                                scanReq.Segment = this.Segment;
                            }

                            if (ReturnConsumedCapacity != ReturnConsumedCapacity.NONE)
                                scanReq.ReturnConsumedCapacity = ReturnConsumedCapacity;

                            SourceTable.UpdateRequestUserAgentDetails(scanReq, isAsync: false);

                            var scanResult = internalClient.Scan(scanReq);
                            count = Matches.Count + scanResult.Count.GetValueOrDefault();
                            scannedCount = scanResult.ScannedCount.GetValueOrDefault();

                            UpdateMetricsAfterPage(scanResult.ConsumedCapacity,
                                scanResult.ScannedCount.GetValueOrDefault(), 0);

                            return count;
                        case SearchType.Query:
                            QueryRequest queryReq = new QueryRequest
                            {
                                TableName = TableName,
                                ConsistentRead = IsConsistentRead,
                                Select = EnumMapper.Convert(SelectValues.Count),
                                ExclusiveStartKey = NextKey,
                                ScanIndexForward = !IsBackwardSearch,
                                IndexName = IndexName
                            };

                            Expression.ApplyExpression(queryReq, SourceTable, KeyExpression, FilterExpression);

                            if (Filter != null)
                            {
                                Dictionary<string, Condition> keyConditions, filterConditions;
                                SplitQueryFilter(Filter, SourceTable, queryReq.IndexName, out keyConditions,
                                    out filterConditions);
                                queryReq.KeyConditions = keyConditions?.Count > 0 ? keyConditions : null;
                                queryReq.QueryFilter = filterConditions?.Count > 0 ? filterConditions : null;
                            }

                            if (queryReq.QueryFilter != null && queryReq.QueryFilter.Count > 1)
                                queryReq.ConditionalOperator = EnumMapper.Convert(ConditionalOperator);

                            if (ReturnConsumedCapacity != ReturnConsumedCapacity.NONE)
                                queryReq.ReturnConsumedCapacity = ReturnConsumedCapacity;

                            SourceTable.UpdateRequestUserAgentDetails(queryReq, isAsync: false);

                            var queryResult = internalClient.Query(queryReq);
                            count = Matches.Count + queryResult.Count.GetValueOrDefault();
                            scannedCount = queryResult.ScannedCount.GetValueOrDefault();

                            UpdateMetricsAfterPage(queryResult.ConsumedCapacity,
                                queryResult.ScannedCount.GetValueOrDefault(), 0);

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
            scannedCount = 0;
            IsDone = false;
            NextKey = null;
            Matches = new List<Document>();
            CollectResults = true;
            _metrics = new SearchMetrics();
        }

        private SearchMetrics _metrics;

        private void UpdateMetricsAfterPage(ConsumedCapacity consumed, int scannedCountPage, int itemsReturnedPage)
        {
            _metrics.ScannedCountLast = scannedCountPage;
            _metrics.ScannedCountAccumulated += scannedCountPage;
            _metrics.ItemsReturnedLast = itemsReturnedPage;
            _metrics.TotalItemsReturned += itemsReturnedPage;
            if (consumed != null)
            {
                _metrics.LastConsumedCapacity = consumed;
                _metrics._history.Add(consumed);
                if (consumed.CapacityUnits.HasValue)
                    _metrics.TotalCapacityUnits = (_metrics.TotalCapacityUnits ?? 0) + consumed.CapacityUnits.Value;
                if (consumed.ReadCapacityUnits.HasValue)
                    _metrics.TotalReadCapacityUnits =
                        (_metrics.TotalReadCapacityUnits ?? 0) + consumed.ReadCapacityUnits.Value;
                if (consumed.WriteCapacityUnits.HasValue)
                    _metrics.TotalWriteCapacityUnits =
                        (_metrics.TotalWriteCapacityUnits ?? 0) + consumed.WriteCapacityUnits.Value;
            }
        }

        #endregion
    }

    /// <summary>
    /// Provides aggregated metrics and capacity usage information for a multi-page search or query operation.
    /// </summary>
    /// <remarks>This class exposes read-only properties that summarize capacity consumption, item counts, and
    /// scan statistics across all pages retrieved during a search or query. Instances are typically returned by
    /// operations that support capacity reporting, such as paginated database queries. All properties reflect the
    /// cumulative or most recent values as appropriate, and are updated as additional pages are processed. This type is
    /// not intended to be instantiated directly.</remarks>
    public sealed class SearchMetrics
    {
        internal SearchMetrics()
        {
            _history = new List<ConsumedCapacity>();
        }

        internal List<ConsumedCapacity> _history;

        /// <summary>
        /// Gets the details of the capacity units consumed by the most recent operation.
        /// </summary>
        /// <remarks>This property is typically populated after a request to a data service that tracks
        /// consumed capacity, such as a database or storage operation. The value may be null if capacity information is
        /// not available for the last operation.</remarks>
        public ConsumedCapacity LastConsumedCapacity { get; internal set; }

        /// <summary>
        /// Gets the history of consumed capacity details for all operations performed during the search.
        /// </summary>
        public IReadOnlyList<ConsumedCapacity> ConsumedCapacityHistory => _history;

        /// <summary>
        /// Total capacity units accumulated.
        /// </summary>
        public double? TotalCapacityUnits { get; internal set; }

        /// <summary>
        /// Gets the total provisioned read capacity units for all tables in the collection.
        /// </summary>
        public double? TotalReadCapacityUnits { get; internal set; }

        /// <summary>
        /// Gets the total provisioned write capacity units for all tables in the current context.
        /// </summary>
        public double? TotalWriteCapacityUnits { get; internal set; }

        /// <summary>
        /// Gets the number of items scanned during the most recent operation.
        /// </summary>
        public int ScannedCountLast { get; internal set; }

        /// <summary>
        /// Gets the total number of items scanned across all operations.
        /// </summary>
        /// <remarks>This property is updated internally and reflects the cumulative count of scanned items.</remarks>
        public int ScannedCountAccumulated { get; internal set; }

        /// <summary>
        /// Number of items returned in the last operation.
        /// </summary>
        public int ItemsReturnedLast { get; internal set; }

        /// <summary>
        /// Total number of items returned across all operations.
        /// </summary>
        public int TotalItemsReturned { get; internal set; }
    }
}
