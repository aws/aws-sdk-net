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
    /// Describes the metadata of a comment.
    /// </summary>
    public partial class CommentMetadata
    {
        private string _commentId;
        private CommentStatusType _commentStatus;
        private User _contributor;
        private string _contributorId;
        private DateTime? _createdTimestamp;
        private string _recipientId;

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The ID of the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CommentStatus. 
        /// <para>
        /// The status of the comment.
        /// </para>
        /// </summary>
        public CommentStatusType CommentStatus
        {
            get { return this._commentStatus; }
            set { this._commentStatus = value; }
        }

        // Check to see if CommentStatus property is set
        internal bool IsSetCommentStatus()
        {
            return this._commentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Contributor. 
        /// <para>
        /// The user who made the comment.
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
        /// Gets and sets the property ContributorId. 
        /// <para>
        /// The ID of the user who made the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContributorId
        {
            get { return this._contributorId; }
            set { this._contributorId = value; }
        }

        // Check to see if ContributorId property is set
        internal bool IsSetContributorId()
        {
            return this._contributorId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp that the comment was created.
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
        /// Gets and sets the property RecipientId. 
        /// <para>
        /// The ID of the user being replied to.
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

    }
}