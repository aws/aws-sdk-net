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
using Amazon.Runtime.Telemetry.Tracing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DocumentModel
{

    /// <summary>
    /// Represents the interface for a vector search response.
    /// </summary>
    public partial interface ISearchVectors
    {
        /// <summary>
        /// DynamoDB table name targeted by this vector search operation.
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// Vector index name used to execute the similarity search.
        /// </summary>
        string IndexName { get; }

        /// <summary>
        /// The query embedding values used for similarity matching. The vector length must match
        /// the dimensions configured for the target vector index.
        /// </summary>
        List<float> SearchVector { get; }

        /// <summary>
        /// The number of top results to return from the vector search. This value must be greater than 0.
        /// </summary>
        int TopK { get; }

        /// <summary>
        /// Optional filter expression applied to items during vector search.
        /// </summary>
        Expression SearchConditionExpression { get; }

        /// <summary>
        /// Optional projection expression that controls which attributes are returned in matches.
        /// </summary>
        Expression ProjectionExpression { get; }

        /// <summary>
        /// Match results.
        /// </summary>
        List<DocumentSearchVectorsItem> Matches { get; }

        /// <summary>
        /// Consumed capacity metrics captured for this search operation.
        /// </summary>
        SearchVectorsMetrics Metrics { get; }
    }

    /// <inheritdoc/>
    public partial class SearchVectors : ISearchVectors
    {
        /// <inheritdoc/>
        public string TableName { get; internal set; }

        /// <inheritdoc/>
        public string IndexName { get; internal set; }

        /// <inheritdoc/>
        public List<float> SearchVector { get; internal set; }
        
        /// <inheritdoc/>
        public int TopK { get; internal set; }

        /// <inheritdoc/>
        public Expression SearchConditionExpression { get; internal set; }

        /// <inheritdoc/>
        public Expression ProjectionExpression { get; internal set; }

        /// <summary>
        /// ReturnConsumedCapacity setting for vector search.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity { get; internal set; }

        /// <inheritdoc/>
        public List<DocumentSearchVectorsItem> Matches { get; private set; }

        /// <inheritdoc/>
        public SearchVectorsMetrics Metrics => _metrics;

        internal TracerProvider TracerProvider { get; private set; }

        internal Table SourceTable { get; set; }

        internal SearchVectors()
        {
            ReturnConsumedCapacity = ReturnConsumedCapacity.NONE;
            Matches = new List<DocumentSearchVectorsItem>();
            _metrics = new SearchVectorsMetrics();
            TracerProvider = AWSConfigs.TelemetryProvider.TracerProvider;
        }

        internal List<DocumentSearchVectorsItem> GetHelper()
        {
            if (SourceTable == null)
                throw new System.InvalidOperationException("SourceTable must be set for vector search.");


            if (TopK <= 0)
                throw new ArgumentOutOfRangeException(nameof(TopK), "TopK must be greater than 0.");
            
#if NETSTANDARD
            var internalClient = SourceTable.DDBClient as AmazonDynamoDBClient;
            if (internalClient == null)
            {
                throw new System.InvalidOperationException("Calling synchronous Get() from .NET or .NET Core requires initializing the Table with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when calling GetAsync instead.");
            }
#else
            var internalClient = SourceTable.DDBClient;
#endif

            Matches.Clear();

            var queryRequest = BuildSearchVectorsRequest();
            SourceTable.UpdateRequestUserAgentDetails(queryRequest, isAsync: false);

            var queryResponse = internalClient.SearchVectors(queryRequest);
            var results = new List<DocumentSearchVectorsItem>();
            if (queryResponse.SearchResults != null)
            {
                foreach (var item in queryResponse.SearchResults)
                {
                    var doc = SourceTable.FromAttributeMap(item.Item);
                    var result = new DocumentSearchVectorsItem
                    {
                        Document = doc,
                        Score = item.Score
                    };
                    results.Add(result);
                    Matches.Add(result);                    
                }
            }

            UpdateMetricsAfterCall(queryResponse.ConsumedCapacity, results.Count);
            return results;
        }

        internal Task<List<DocumentSearchVectorsItem>> GetHelperAsync( CancellationToken cancellationToken)
        {
            if (SourceTable == null)
                throw new System.InvalidOperationException("SourceTable must be set for vector search.");


            return ExecuteAsync(cancellationToken);
        }

        private async Task<List<DocumentSearchVectorsItem>> ExecuteAsync(CancellationToken cancellationToken)
        {
            if (TopK <= 0)
                throw new ArgumentOutOfRangeException(nameof(TopK), "TopK must be greater than 0.");

            Matches.Clear();

            var queryRequest = BuildSearchVectorsRequest();

            SourceTable.UpdateRequestUserAgentDetails(queryRequest, isAsync: true);

            var queryResponse = await SourceTable.DDBClient.SearchVectorsAsync(queryRequest, cancellationToken).ConfigureAwait(false);
            var results = new List<DocumentSearchVectorsItem>();
            if (queryResponse.SearchResults != null)
            {
                foreach (var item in queryResponse.SearchResults)
                {
                    var doc = SourceTable.FromAttributeMap(item.Item);
                    var result = new DocumentSearchVectorsItem
                    {
                        Document = doc,
                        Score = item.Score,
                    };
                    results.Add(result);
                    Matches.Add(result);
                    
                }
            }

            UpdateMetricsAfterCall(queryResponse.ConsumedCapacity, results.Count);
            return results;
        }

        private SearchVectorsRequest BuildSearchVectorsRequest()
        {
            var request = new SearchVectorsRequest
            {
                TableName = TableName,
                IndexName = IndexName,
                TopK = TopK,
            };


            if (this.SearchVector != null && this.SearchVector.Count > 0)
            {
                request.SearchVector = new List<AttributeValue>(this.SearchVector.Count);

                for (int i = 0; i < this.SearchVector.Count; i++)
                {
                    var attribute = this.SearchVector[i];
                    request.SearchVector.Add(new AttributeValue() { N = attribute.ToString("R", CultureInfo.InvariantCulture) });
                }
            }
            else
            {
                throw new InvalidOperationException("SearchVector must be set and contain at least one value.");
            }

            if (ReturnConsumedCapacity != ReturnConsumedCapacity.NONE)
                request.ReturnConsumedCapacity = ReturnConsumedCapacity;

            if (this.SearchConditionExpression != null && this.SearchConditionExpression.IsSet)
            {
                this.SearchConditionExpression.ApplySearchCondition(request,SourceTable);
            }

            if (this.ProjectionExpression != null && this.ProjectionExpression.IsSet)
            {
                this.ProjectionExpression.ApplyProjection(request,SourceTable);
            }

            return request;
        }

        private SearchVectorsMetrics _metrics;

        internal void UpdateMetricsAfterCall(VectorCapacity consumed, int itemsReturned)
        {
            _metrics.ItemsReturnedLast = itemsReturned;
            _metrics.TotalItemsReturned += itemsReturned;
            if (consumed != null)
            {
                _metrics.LastConsumedCapacity = consumed;
                _metrics._history.Add(consumed);
                if (consumed.IsSetVectorSearchRequestBytes())
                    _metrics.TotalVectorSearchRequestBytes = (_metrics.TotalVectorSearchRequestBytes ?? 0) + consumed.VectorSearchRequestBytes.Value;
                if (consumed.IsSetVectorWriteRequestBytes())
                    _metrics.TotalVectorWriteRequestBytes = (_metrics.TotalVectorWriteRequestBytes ?? 0) + consumed.VectorWriteRequestBytes.Value;
            }
        }

    }


    /// <summary>
    /// Provides aggregated metrics and capacity usage information for a multi-page vector search operation.
    /// </summary>
    /// <remarks>This class exposes read-only properties that summarize capacity consumption, item counts, and
    /// scan statistics across all pages retrieved during a vector search. Instances are typically returned by
    /// operations that support capacity reporting, such as paginated database queries. All properties reflect the
    /// cumulative or most recent values as appropriate, and are updated as additional pages are processed. This type is
    /// not intended to be instantiated directly.</remarks>
    public sealed class SearchVectorsMetrics
    {
        internal SearchVectorsMetrics()
        {
            _history = new List<VectorCapacity>();
        }

        internal List<VectorCapacity> _history;

        /// <summary>
        /// Gets the details of the capacity units consumed by the most recent operation.
        /// </summary>
        /// <remarks>This property is typically populated after a request to a data service that tracks
        /// consumed capacity, such as a database or storage operation. The value may be null if capacity information is
        /// not available for the last operation.</remarks>
        public VectorCapacity LastConsumedCapacity { get; internal set; }

        /// <summary>
        /// Gets the history of consumed capacity details for all operations performed during the search.
        /// </summary>
        public IReadOnlyList<VectorCapacity> ConsumedCapacityHistory => _history;

        /// <summary>
        /// Gets the total consumed vector search request bytes accumulated across all operations performed during the search.
        /// </summary>
        public double? TotalVectorSearchRequestBytes { get; internal set; }

        /// <summary>
        /// Gets the total accumulated vector write request bytes for all operations performed during the search.
        /// </summary>
        public double? TotalVectorWriteRequestBytes { get; internal set; }


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
