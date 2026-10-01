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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the DocumentType operation. This example serializes
    /// a document as part of the payload.
    /// </summary>
    public partial class DocumentTypeRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property DocumentValue.
        /// </summary>
        public Amazon.Runtime.Documents.Document DocumentValue { get; set; }

        /// <summary>
        /// Checks to see if the DocumentValue property is set.
        /// </summary>
        internal bool IsSetDocumentValue() => !this.DocumentValue.IsNull();

        /// <summary>
        /// Gets and sets the property StringValue.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
