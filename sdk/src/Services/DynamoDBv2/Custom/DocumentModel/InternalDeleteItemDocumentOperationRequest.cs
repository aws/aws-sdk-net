using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Represents an internal request to delete an item from a DynamoDB table using the Document Model.
    /// This class introduces a modern expression-based API that replaces legacy parameter-based approaches.
    /// Legacy parameters such as Expected are not supported.
    /// Use ConditionalExpression instead.
    /// </summary>
    internal class InternalDeleteItemDocumentOperationRequest : BaseDeleteItemDocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the key identifying the item in the table.
        /// </summary>
        internal Dictionary<string, AttributeValue> Key { get; set; }
    }
}