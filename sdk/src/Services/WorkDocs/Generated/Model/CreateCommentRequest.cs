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
    /// Container for the parameters to the CreateComment operation.
    /// Adds a new comment to the specified document version.
    /// </summary>
    public partial class CreateCommentRequest : AmazonWorkDocsRequest
    {
        private string _authenticationToken;
        private string _documentId;
        private bool? _notifyCollaborators;
        private string _parentId;
        private string _text;
        private string _threadId;
        private string _versionId;
        private CommentVisibilityType _visibility;

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
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The ID of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyCollaborators. 
        /// <para>
        /// Set this parameter to TRUE to send an email out to the document collaborators after
        /// the comment is created.
        /// </para>
        /// </summary>
        public bool NotifyCollaborators
        {
            get { return this._notifyCollaborators.GetValueOrDefault(); }
            set { this._notifyCollaborators = value; }
        }

        // Check to see if NotifyCollaborators property is set
        internal bool IsSetNotifyCollaborators()
        {
            return this._notifyCollaborators.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The ID of the parent comment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text of the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property ThreadId. 
        /// <para>
        /// The ID of the root comment in the thread.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThreadId
        {
            get { return this._threadId; }
            set { this._threadId = value; }
        }

        // Check to see if ThreadId property is set
        internal bool IsSetThreadId()
        {
            return this._threadId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the document version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the comment. Options are either PRIVATE, where the comment is visible
        /// only to the comment author and document owner and co-owners, or PUBLIC, where the
        /// comment is visible to document owners, co-owners, and contributors.
        /// </para>
        /// </summary>
        public CommentVisibilityType Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}