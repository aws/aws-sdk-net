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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateDocumentVersionUpload operation.
    /// Creates a new document object and version object.
    /// 
    ///  
    /// <para>
    /// The client specifies the parent folder ID and name of the document to upload. The
    /// ID is optionally specified when creating a new version of an existing document. This
    /// is the first step to upload a document. Next, upload the document to the URL returned
    /// from the call, and then call <a>UpdateDocumentVersion</a>.
    /// </para>
    ///  
    /// <para>
    /// To cancel the document upload, call <a>AbortDocumentVersionUpload</a>.
    /// </para>
    /// </summary>
    public partial class InitiateDocumentVersionUploadRequest : AmazonWorkDocsRequest
    {
        private string _authenticationToken;
        private DateTime? _contentCreatedTimestamp;
        private DateTime? _contentModifiedTimestamp;
        private string _contentType;
        private long? _documentSizeInBytes;
        private string _id;
        private string _name;
        private string _parentFolderId;

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8199)]
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContentCreatedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was originally created.
        /// </para>
        /// </summary>
        public DateTime ContentCreatedTimestamp
        {
            get { return this._contentCreatedTimestamp.GetValueOrDefault(); }
            set { this._contentCreatedTimestamp = value; }
        }

        // Check to see if ContentCreatedTimestamp property is set
        internal bool IsSetContentCreatedTimestamp()
        {
            return this._contentCreatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentModifiedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was modified.
        /// </para>
        /// </summary>
        public DateTime ContentModifiedTimestamp
        {
            get { return this._contentModifiedTimestamp.GetValueOrDefault(); }
            set { this._contentModifiedTimestamp = value; }
        }

        // Check to see if ContentModifiedTimestamp property is set
        internal bool IsSetContentModifiedTimestamp()
        {
            return this._contentModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentSizeInBytes. 
        /// <para>
        /// The size of the document, in bytes.
        /// </para>
        /// </summary>
        public long DocumentSizeInBytes
        {
            get { return this._documentSizeInBytes.GetValueOrDefault(); }
            set { this._documentSizeInBytes = value; }
        }

        // Check to see if DocumentSizeInBytes property is set
        internal bool IsSetDocumentSizeInBytes()
        {
            return this._documentSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentFolderId. 
        /// <para>
        /// The ID of the parent folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParentFolderId
        {
            get { return this._parentFolderId; }
            set { this._parentFolderId = value; }
        }

        // Check to see if ParentFolderId property is set
        internal bool IsSetParentFolderId()
        {
            return this._parentFolderId != null;
        }

    }
}