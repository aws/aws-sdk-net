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
    /// Describes a comment.
    /// </summary>
    public partial class Comment
    {
        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The ID of the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string CommentId { get; set; }

        /// <summary>
        /// Checks to see if the CommentId property is set.
        /// </summary>
        internal bool IsSetCommentId() => this.CommentId != null;

        /// <summary>
        /// Gets and sets the property Contributor. 
        /// <para>
        /// The details of the user who made the comment.
        /// </para>
        /// </summary>
        public User Contributor { get; set; }

        /// <summary>
        /// Checks to see if the Contributor property is set.
        /// </summary>
        internal bool IsSetContributor() => this.Contributor != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time that the comment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The ID of the parent comment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId != null;

        /// <summary>
        /// Gets and sets the property RecipientId. 
        /// <para>
        /// If the comment is a reply to another user's comment, this field contains the user
        /// ID of the user being replied to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RecipientId { get; set; }

        /// <summary>
        /// Checks to see if the RecipientId property is set.
        /// </summary>
        internal bool IsSetRecipientId() => this.RecipientId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the comment.
        /// </para>
        /// </summary>
        public CommentStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text of the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property ThreadId. 
        /// <para>
        /// The ID of the root comment in the thread.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Checks to see if the ThreadId property is set.
        /// </summary>
        internal bool IsSetThreadId() => this.ThreadId != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the comment. Options are either PRIVATE, where the comment is visible
        /// only to the comment author and document owner and co-owners, or PUBLIC, where the
        /// comment is visible to document owners, co-owners, and contributors.
        /// </para>
        /// </summary>
        public CommentVisibilityType Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
