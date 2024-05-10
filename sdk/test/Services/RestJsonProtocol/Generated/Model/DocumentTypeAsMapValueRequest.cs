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
    /// Container for the parameters to the DocumentTypeAsMapValue operation.
    /// This example serializes documents as the value of maps.
    /// </summary>
    public partial class DocumentTypeAsMapValueRequest : AmazonRestJsonProtocolRequest
    {
        private Dictionary<string, Amazon.Runtime.Documents.Document> _docValuedMap = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Gets and sets the property DocValuedMap.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> DocValuedMap
        {
            get { return this._docValuedMap; }
            set { this._docValuedMap = value; }
        }

        // Check to see if DocValuedMap property is set
        internal bool IsSetDocValuedMap()
        {
            return this._docValuedMap != null && (this._docValuedMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}