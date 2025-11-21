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

    /// <summary>
    /// Represents a request to update an item in a DynamoDB table using the Document Model.
    /// </summary>
    public class UpdateItemDocumentOperationRequest : DocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the key identifying the item in the table.
        /// </summary>
        public IDictionary<string, DynamoDBEntry> Key { get; set; }

        /// <summary>
        /// Gets or sets the attributes to be updated in the item.
        /// </summary>
        public Document Document { get; set; }

        /// <summary>
        /// Gets or sets the update expression specifying how attributes should be updated.
        /// </summary>
        public Expression UpdateExpression { get; set; }

        /// <summary>
        /// The expression that is evaluated before the update is performed. If the expression evaluates to false the update
        /// will fail and a ConditionalCheckFailedException exception will be thrown.
        /// </summary>
        public Expression ConditionalExpression { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }

    /// <summary>
    /// Represents a request to delete an item from a DynamoDB table using the Document Model.
    /// </summary>
    public class DeleteItemDocumentOperationRequest : DocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the key identifying the item in the table.
        /// </summary>
        public IDictionary<string, DynamoDBEntry> Key { get; set; }

        /// <summary>
        /// Gets or sets the conditional expression specifying when the item should be deleted.
        /// </summary>
        public Expression ConditionalExpression { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// </summary>
        public ReturnValues ReturnValues { get; set; }

    }

    /// <summary>
    /// Represents a request to put (create or replace) an item in a DynamoDB table using the Document Model.
    /// </summary>
    public class PutItemDocumentOperationRequest : DocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the document to be put in the table.
        /// </summary>
        public Document Document { get; set; }

        /// <summary>
        /// Gets or sets the conditional expression specifying when the item should be put.
        /// </summary>
        public Expression ConditionalExpression { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }
}