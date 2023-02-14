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
    /// Describes a comment.
    /// </summary>
    public partial class Comment
    {
        private string _commentId;
        private User _contributor;
        private DateTime? _createdTimestamp;
        private string _parentId;
        private string _recipientId;
        private CommentStatusType _status;
        private string _text;
        private string _threadId;
        private CommentVisibilityType _visibility;

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The ID of the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CommentId
        {
            get { return this._commentId; }
            set { this._commentId = value; }
        }

        // Check to see if CommentId property is set
        internal bool IsSetCommentId()
        {
            return this._commentId != null;
        }

        /// <summary>
        /// Gets and sets the property Contributor. 
        /// <para>
        /// The details of the user who made the comment.
        /// </para>
        /// </summary>
        public User Contributor
        {
            get { return this._contributor; }
            set { this._contributor = value; }
        }

        // Check to see if Contributor property is set
        internal bool IsSetContributor()
        {
            return this._contributor != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time that the comment was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
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
        /// Gets and sets the property RecipientId. 
        /// <para>
        /// If the comment is a reply to another user's comment, this field contains the user
        /// ID of the user being replied to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RecipientId
        {
            get { return this._recipientId; }
            set { this._recipientId = value; }
        }

        // Check to see if RecipientId property is set
        internal bool IsSetRecipientId()
        {
            return this._recipientId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the comment.
        /// </para>
        /// </summary>
        public CommentStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text of the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
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