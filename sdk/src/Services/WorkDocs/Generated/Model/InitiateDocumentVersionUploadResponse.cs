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
    /// This is the response object from the InitiateDocumentVersionUpload operation.
    /// </summary>
    public partial class InitiateDocumentVersionUploadResponse : AmazonWebServiceResponse
    {
        private DocumentMetadata _metadata;
        private UploadMetadata _uploadMetadata;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The document metadata.
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

        /// <summary>
        /// Gets and sets the property UploadMetadata. 
        /// <para>
        /// The upload metadata.
        /// </para>
        /// </summary>
        public UploadMetadata UploadMetadata
        {
            get { return this._uploadMetadata; }
            set { this._uploadMetadata = value; }
        }

        // Check to see if UploadMetadata property is set
        internal bool IsSetUploadMetadata()
        {
            return this._uploadMetadata != null;
        }

    }
}