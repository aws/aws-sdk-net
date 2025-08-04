using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Base class for requests that perform operations on a document in DynamoDB. 
    /// </summary>
    public abstract class DocumentOperationRequest
    {
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