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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
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
namespace Amazon.JsonProtocol.Model
{
    /// <summary>
    /// This is the response object from the PutAndGetInlineDocuments operation.
    /// </summary>
    public partial class PutAndGetInlineDocumentsResponse : AmazonWebServiceResponse
    {
        private Amazon.Runtime.Documents.Document _inlineDocument;

        /// <summary>
        /// Gets and sets the property InlineDocument.
        /// </summary>
        public Amazon.Runtime.Documents.Document InlineDocument
        {
            get { return this._inlineDocument; }
            set { this._inlineDocument = value; }
        }

        // Check to see if InlineDocument property is set
        internal bool IsSetInlineDocument()
        {
            return !this._inlineDocument.IsNull();
        }

    }
}