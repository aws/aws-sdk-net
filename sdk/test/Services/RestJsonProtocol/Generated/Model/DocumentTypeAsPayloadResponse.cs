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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
    /// This is the response object from the DocumentTypeAsPayload operation.
    /// </summary>
    public partial class DocumentTypeAsPayloadResponse : AmazonWebServiceResponse
    {
        private Amazon.Runtime.Documents.Document _documentValue;

        /// <summary>
        /// Gets and sets the property DocumentValue.
        /// </summary>
        public Amazon.Runtime.Documents.Document DocumentValue
        {
            get { return this._documentValue; }
            set { this._documentValue = value; }
        }

        // Check to see if DocumentValue property is set
        internal bool IsSetDocumentValue()
        {
            return !this._documentValue.IsNull();
        }

    }
}