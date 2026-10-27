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
    /// Describes the metadata of a comment.
    /// </summary>
    public partial class CommentMetadata
    {
        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The ID of the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string CommentId { get; set; }

        /// <summary>
        /// Checks to see if the CommentId property is set.
        /// </summary>
        internal bool IsSetCommentId() => this.CommentId != null;

        /// <summary>
        /// Gets and sets the property CommentStatus. 
        /// <para>
        /// The status of the comment.
        /// </para>
        /// </summary>
        public CommentStatusType CommentStatus { get; set; }

        /// <summary>
        /// Checks to see if the CommentStatus property is set.
        /// </summary>
        internal bool IsSetCommentStatus() => this.CommentStatus != null;

        /// <summary>
        /// Gets and sets the property Contributor. 
        /// <para>
        /// The user who made the comment.
        /// </para>
        /// </summary>
        public User Contributor { get; set; }

        /// <summary>
        /// Checks to see if the Contributor property is set.
        /// </summary>
        internal bool IsSetContributor() => this.Contributor != null;

        /// <summary>
        /// Gets and sets the property ContributorId. 
        /// <para>
        /// The ID of the user who made the comment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContributorId { get; set; }

        /// <summary>
        /// Checks to see if the ContributorId property is set.
        /// </summary>
        internal bool IsSetContributorId() => this.ContributorId != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp that the comment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RecipientId. 
        /// <para>
        /// The ID of the user being replied to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RecipientId { get; set; }

        /// <summary>
        /// Checks to see if the RecipientId property is set.
        /// </summary>
        internal bool IsSetRecipientId() => this.RecipientId != null;
    }
}
