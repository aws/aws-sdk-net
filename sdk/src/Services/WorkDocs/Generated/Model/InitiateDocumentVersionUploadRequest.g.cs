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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateDocumentVersionUpload operation. Creates
    /// a new document object and version object. <para> The client specifies the parent folder
    /// ID and name of the document to upload. The ID is optionally specified when creating
    /// a new version of an existing document. This is the first step to upload a document.
    /// Next, upload the document to the URL returned from the call, and then call <a>UpdateDocumentVersion</a>.
    /// </para> <para> To cancel the document upload, call <a>AbortDocumentVersionUpload</a>.
    /// </para>
    /// </summary>
    public partial class InitiateDocumentVersionUploadRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8199)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationToken property is set.
        /// </summary>
        internal bool IsSetAuthenticationToken() => this.AuthenticationToken != null;

        /// <summary>
        /// Gets and sets the property ContentCreatedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was originally created.
        /// </para>
        /// </summary>
        public DateTime? ContentCreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ContentCreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetContentCreatedTimestamp() => this.ContentCreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ContentModifiedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was modified.
        /// </para>
        /// </summary>
        public DateTime? ContentModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ContentModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetContentModifiedTimestamp() => this.ContentModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DocumentSizeInBytes. 
        /// <para>
        /// The size of the document, in bytes.
        /// </para>
        /// </summary>
        public long? DocumentSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the DocumentSizeInBytes property is set.
        /// </summary>
        internal bool IsSetDocumentSizeInBytes() => this.DocumentSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentFolderId. 
        /// <para>
        /// The ID of the parent folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Checks to see if the ParentFolderId property is set.
        /// </summary>
        internal bool IsSetParentFolderId() => this.ParentFolderId != null;
    }
}
