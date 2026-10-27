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
    /// List of Documents, Folders, Comments, and Document Versions matching the query.
    /// </summary>
    public partial class ResponseItem
    {
        /// <summary>
        /// Gets and sets the property CommentMetadata. 
        /// <para>
        /// The comment that matches the query.
        /// </para>
        /// </summary>
        public CommentMetadata CommentMetadata { get; set; }

        /// <summary>
        /// Checks to see if the CommentMetadata property is set.
        /// </summary>
        internal bool IsSetCommentMetadata() => this.CommentMetadata != null;

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// The document that matches the query.
        /// </para>
        /// </summary>
        public DocumentMetadata DocumentMetadata { get; set; }

        /// <summary>
        /// Checks to see if the DocumentMetadata property is set.
        /// </summary>
        internal bool IsSetDocumentMetadata() => this.DocumentMetadata != null;

        /// <summary>
        /// Gets and sets the property DocumentVersionMetadata. 
        /// <para>
        /// The document version that matches the metadata.
        /// </para>
        /// </summary>
        public DocumentVersionMetadata DocumentVersionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersionMetadata property is set.
        /// </summary>
        internal bool IsSetDocumentVersionMetadata() => this.DocumentVersionMetadata != null;

        /// <summary>
        /// Gets and sets the property FolderMetadata. 
        /// <para>
        /// The folder that matches the query.
        /// </para>
        /// </summary>
        public FolderMetadata FolderMetadata { get; set; }

        /// <summary>
        /// Checks to see if the FolderMetadata property is set.
        /// </summary>
        internal bool IsSetFolderMetadata() => this.FolderMetadata != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of item being returned.
        /// </para>
        /// </summary>
        public ResponseItemType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property WebUrl. 
        /// <para>
        /// The webUrl of the item being returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 512)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebUrl property is set.
        /// </summary>
        internal bool IsSetWebUrl() => this.WebUrl != null;
    }
}
