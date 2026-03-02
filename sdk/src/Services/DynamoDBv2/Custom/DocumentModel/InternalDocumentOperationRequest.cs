using Amazon.DynamoDBv2.Model;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
   

    /// <summary>
    /// Represents a request to get a single item from a DynamoDB table using the Document Model.
    /// This class introduces a modern expression-based API that replaces legacy parameter-based approaches.
    /// Legacy parameters such as AttributesToGet are not supported. Use ProjectionExpression instead.
    /// </summary>
    internal class InternalGetItemDocumentOperationRequest : BaseGetItemDocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the key identifying the item in the table.
        /// All key components (partition and sort key, if the table has one) must be provided.
        /// </summary>
        internal IDictionary<string, AttributeValue> Key { get; set; }

    }
}