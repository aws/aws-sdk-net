using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Represents a request to update an item document in the internal system.
    /// </summary>
    /// <remarks>This class inherits from BaseUpdateItemDocumentOperationRequest and is used to encapsulate
    /// the details required for updating an item document. It includes a key that uniquely identifies the item to be
    /// updated.</remarks>
    internal class InternalUpdateItemDocumentOperationRequest : BaseUpdateItemDocumentOperationRequest
    {
        /// <summary>
        /// Gets or sets the key identifying the item in the table.
        /// </summary>
        public Key Key { get; set; }
    }
}
