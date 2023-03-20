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
    /// List of Documents, Folders, Comments, and Document Versions matching the query.
    /// </summary>
    public partial class ResponseItem
    {
        private CommentMetadata _commentMetadata;
        private DocumentMetadata _documentMetadata;
        private DocumentVersionMetadata _documentVersionMetadata;
        private FolderMetadata _folderMetadata;
        private ResponseItemType _resourceType;
        private string _webUrl;

        /// <summary>
        /// Gets and sets the property CommentMetadata. 
        /// <para>
        /// The comment that matches the query.
        /// </para>
        /// </summary>
        public CommentMetadata CommentMetadata
        {
            get { return this._commentMetadata; }
            set { this._commentMetadata = value; }
        }

        // Check to see if CommentMetadata property is set
        internal bool IsSetCommentMetadata()
        {
            return this._commentMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// The document that matches the query.
        /// </para>
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
        /// Gets and sets the property DocumentVersionMetadata. 
        /// <para>
        /// The document version that matches the metadata.
        /// </para>
        /// </summary>
        public DocumentVersionMetadata DocumentVersionMetadata
        {
            get { return this._documentVersionMetadata; }
            set { this._documentVersionMetadata = value; }
        }

        // Check to see if DocumentVersionMetadata property is set
        internal bool IsSetDocumentVersionMetadata()
        {
            return this._documentVersionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property FolderMetadata. 
        /// <para>
        /// The folder that matches the query.
        /// </para>
        /// </summary>
        public FolderMetadata FolderMetadata
        {
            get { return this._folderMetadata; }
            set { this._folderMetadata = value; }
        }

        // Check to see if FolderMetadata property is set
        internal bool IsSetFolderMetadata()
        {
            return this._folderMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of item being returned.
        /// </para>
        /// </summary>
        public ResponseItemType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property WebUrl. 
        /// <para>
        /// The webUrl of the item being returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=512)]
        public string WebUrl
        {
            get { return this._webUrl; }
            set { this._webUrl = value; }
        }

        // Check to see if WebUrl property is set
        internal bool IsSetWebUrl()
        {
            return this._webUrl != null;
        }

    }
}