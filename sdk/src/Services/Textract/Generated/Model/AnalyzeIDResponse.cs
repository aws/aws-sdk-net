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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// This is the response object from the AnalyzeID operation.
    /// </summary>
    public partial class AnalyzeIDResponse : AmazonWebServiceResponse
    {
        private string _analyzeIDModelVersion;
        private DocumentMetadata _documentMetadata;
        private List<IdentityDocument> _identityDocuments = AWSConfigs.InitializeCollections ? new List<IdentityDocument>() : null;

        /// <summary>
        /// Gets and sets the property AnalyzeIDModelVersion. 
        /// <para>
        /// The version of the AnalyzeIdentity API being used to process documents.
        /// </para>
        /// </summary>
        public string AnalyzeIDModelVersion
        {
            get { return this._analyzeIDModelVersion; }
            set { this._analyzeIDModelVersion = value; }
        }

        // Check to see if AnalyzeIDModelVersion property is set
        internal bool IsSetAnalyzeIDModelVersion()
        {
            return this._analyzeIDModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadata.
        /// </summary>
        public DocumentMetadata DocumentMetadata
        {
            get { return this._documentMetadata; }
            set { this._documentMetadata = value; }
        }

        // Check to see if DocumentMetadata property is set
        internal bool IsSetDocumentMetadata()
        {
            return this._documentMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityDocuments. 
        /// <para>
        /// The list of documents processed by AnalyzeID. Includes a number denoting their place
        /// in the list and the response structure for the document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdentityDocument> IdentityDocuments
        {
            get { return this._identityDocuments; }
            set { this._identityDocuments = value; }
        }

        // Check to see if IdentityDocuments property is set
        internal bool IsSetIdentityDocuments()
        {
            return this._identityDocuments != null && (this._identityDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}