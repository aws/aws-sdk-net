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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
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
namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// This is the response object from the GetDocument operation.
    /// </summary>
    public partial class GetDocumentResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _customMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DocumentMetadata _metadata;

        /// <summary>
        /// Gets and sets the property CustomMetadata. 
        /// <para>
        /// The custom metadata on the document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public Dictionary<string, string> CustomMetadata
        {
            get { return this._customMetadata; }
            set { this._customMetadata = value; }
        }

        // Check to see if CustomMetadata property is set
        internal bool IsSetCustomMetadata()
        {
            return this._customMetadata != null && (this._customMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata details of the document.
        /// </para>
        /// </summary>
        public DocumentMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

    }
}