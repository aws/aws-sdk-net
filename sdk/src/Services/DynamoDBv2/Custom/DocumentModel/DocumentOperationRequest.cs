using System;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Base class for requests that perform operations on a document in DynamoDB.
    /// This introduces a DocumentOperationRequest object that will no longer support legacy parameters.
    /// Derived classes use modern expression-based APIs instead of legacy parameter-based approaches.
    /// </summary>
    public abstract class DocumentOperationRequest
    {
    }

    /// <summary>
    /// Represents a request to query items in a DynamoDB table using the Document Model.
    /// This class introduces a modern expression-based API that replaces legacy parameter-based approaches.
    /// Legacy parameters such as QueryFilter, AttributesToGet are not supported.
    /// Use KeyConditionExpression, FilterExpression, and ProjectionExpression instead.
    /// </summary>
    public class QueryDocumentOperationRequest : DocumentOperationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDocumentOperationRequest"/> class.
        /// </summary>
        public QueryDocumentOperationRequest()
        {

            Limit = Int32.MaxValue;
            Select = SelectValues.AllAttributes;
        }
        /// <summary>
        /// Gets or sets the key condition expression specifying which items should be returned.
        /// </summary>
        public Expression KeyConditionExpression { get; set; }

        /// <summary>
        /// Gets or sets the filter expression specifying which items should be returned.
        /// </summary>
        public Expression FilterExpression { get; set; }

        /// <summary>
        /// Gets or sets the projection expression specifying which attributes should be retrieved.
        /// </summary>
        public Expression ProjectionExpression { get; set; }

        /// <summary>
        /// Enum specifying what data to return from query.
        /// </summary>
        public SelectValues Select { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items to return.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the consistent read flag.
        /// </summary>
        public bool ConsistentRead { get; set; }

        /// <summary>
        /// Gets or sets the index name to query against.
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// Flag that signals if the search is traversing backwards
        /// </summary>
        public bool BackwardSearch { get; set; }

        /// <summary>
        /// Whether to collect GetNextSet and GetRemaining results in Matches property.
        /// Default is true. If set to false, Matches will always be empty.
        /// </summary>
        public bool CollectResults { get; set; }

        /// <summary>
        /// Pagination token corresponding to the item where the last Query operation
        /// stopped, inclusive of the previous result set. Set this value to resume
        /// Query operation from the next item.
        /// This token should be retrieved from a Search object.
        /// </summary>
        public string PaginationToken { get; set; }
    }
}