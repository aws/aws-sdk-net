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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a specific comment.
    /// </summary>
    public partial class Comment
    {
        /// <summary>
        /// Gets and sets the property AuthorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the person who posted the comment.
        /// </para>
        /// </summary>
        public string AuthorArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthorArn property is set.
        /// </summary>
        internal bool IsSetAuthorArn() => this.AuthorArn != null;

        /// <summary>
        /// Gets and sets the property CallerReactions. 
        /// <para>
        /// The emoji reactions to a comment, if any, submitted by the user whose credentials
        /// are associated with the call to the API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CallerReactions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CallerReactions property is set.
        /// </summary>
        internal bool IsSetCallerReactions() => this.CallerReactions != null && (this.CallerReactions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, client-generated idempotency token that, when provided in a request, ensures
        /// the request cannot be repeated with a changed parameter. If a request is received
        /// with the same parameters and a token is included, the request returns information
        /// about the initial request that used that token.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The system-generated comment ID.
        /// </para>
        /// </summary>
        public string CommentId { get; set; }

        /// <summary>
        /// Checks to see if the CommentId property is set.
        /// </summary>
        internal bool IsSetCommentId() => this.CommentId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the comment.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the comment was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// A Boolean value indicating whether the comment has been deleted.
        /// </para>
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Checks to see if the Deleted property is set.
        /// </summary>
        internal bool IsSetDeleted() => this.Deleted.HasValue;

        /// <summary>
        /// Gets and sets the property InReplyTo. 
        /// <para>
        /// The ID of the comment for which this comment is a reply, if any.
        /// </para>
        /// </summary>
        public string InReplyTo { get; set; }

        /// <summary>
        /// Checks to see if the InReplyTo property is set.
        /// </summary>
        internal bool IsSetInReplyTo() => this.InReplyTo != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time the comment was most recently modified, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property ReactionCounts. 
        /// <para>
        /// A string to integer map that represents the number of individual users who have responded
        /// to a comment with the specified reactions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ReactionCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the ReactionCounts property is set.
        /// </summary>
        internal bool IsSetReactionCounts() => this.ReactionCounts != null && (this.ReactionCounts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
