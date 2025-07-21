using System.Collections.Generic;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Base class for requests that perform operations on a document in DynamoDB. 
    /// </summary>
    public abstract class DocumentOperationRequest
    {
        //"ReturnConsumedCapacity"
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
    /// Represents a request to get an item from a DynamoDB table using the Document Model.
    /// </summary>
    public class GetItemDocumentOperationRequest : DocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the key identifying the item in the table.
        /// </summary>
        public IDictionary<string, DynamoDBEntry> Key { get; set; }

        /// <summary>
        /// Gets or sets the projection expression specifying which attributes should be retrieved.
        /// </summary>
        public Expression ProjectionExpression { get; set; }

        /// <summary>
        /// Gets or sets the consistent read flag.
        /// </summary>
        public bool ConsistentRead { get; set; }
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

    /// <summary>
    /// Represents a request to scan items in a DynamoDB table using the Document Model.
    /// </summary>
    public class ScanDocumentOperationRequest : DocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the filter expression specifying which items should be returned.
        /// </summary>
        public Expression FilterExpression { get; set; }

        /// <summary>
        /// Gets or sets the projection expression specifying which attributes should be retrieved.
        /// </summary>
        public Expression ProjectionExpression { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items to return.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets the exclusive start key for paginated scans.
        /// </summary>
        public IDictionary<string, DynamoDBEntry> ExclusiveStartKey { get; set; }

        /// <summary>
        /// Gets or sets the consistent read flag.
        /// </summary>
        public bool ConsistentRead { get; set; }

        /// <summary>
        /// Gets or sets the segment number for parallel scans.
        /// </summary>
        public int? Segment { get; set; }

        /// <summary>
        /// Gets or sets the total number of segments for parallel scans.
        /// </summary>
        public int? TotalSegments { get; set; }
    }

    /// <summary>
    /// Represents a request to query items in a DynamoDB table using the Document Model.
    /// </summary>
    public class QueryDocumentOperationRequest : DocumentOperationRequest
    {
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
        /// Gets or sets the exclusive start key for paginated queries.
        /// </summary>
        public IDictionary<string, DynamoDBEntry> ExclusiveStartKey { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items to return.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets the consistent read flag.
        /// </summary>
        public bool ConsistentRead { get; set; }

        /// <summary>
        /// Gets or sets the index name to query against.
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// Gets or sets the scan direction. If true, the scan is performed in descending order.
        /// </summary>
        public bool ScanIndexForward { get; set; }
    }
}