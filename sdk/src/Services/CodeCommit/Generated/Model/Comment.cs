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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
        private string _authorArn;
        private List<string> _callerReactions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientRequestToken;
        private string _commentId;
        private string _content;
        private DateTime? _creationDate;
        private bool? _deleted;
        private string _inReplyTo;
        private DateTime? _lastModifiedDate;
        private Dictionary<string, int> _reactionCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Gets and sets the property AuthorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the person who posted the comment.
        /// </para>
        /// </summary>
        public string AuthorArn
        {
            get { return this._authorArn; }
            set { this._authorArn = value; }
        }

        // Check to see if AuthorArn property is set
        internal bool IsSetAuthorArn()
        {
            return this._authorArn != null;
        }

        /// <summary>
        /// Gets and sets the property CallerReactions. 
        /// <para>
        /// The emoji reactions to a comment, if any, submitted by the user whose credentials
        /// are associated with the call to the API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CallerReactions
        {
            get { return this._callerReactions; }
            set { this._callerReactions = value; }
        }

        // Check to see if CallerReactions property is set
        internal bool IsSetCallerReactions()
        {
            return this._callerReactions != null && (this._callerReactions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, client-generated idempotency token that, when provided in a request, ensures
        /// the request cannot be repeated with a changed parameter. If a request is received
        /// with the same parameters and a token is included, the request returns information
        /// about the initial request that used that token.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The system-generated comment ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the comment.
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the comment was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// A Boolean value indicating whether the comment has been deleted.
        /// </para>
        /// </summary>
        public bool? Deleted
        {
            get { return this._deleted; }
            set { this._deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this._deleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InReplyTo. 
        /// <para>
        /// The ID of the comment for which this comment is a reply, if any.
        /// </para>
        /// </summary>
        public string InReplyTo
        {
            get { return this._inReplyTo; }
            set { this._inReplyTo = value; }
        }

        // Check to see if InReplyTo property is set
        internal bool IsSetInReplyTo()
        {
            return this._inReplyTo != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time the comment was most recently modified, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReactionCounts. 
        /// <para>
        /// A string to integer map that represents the number of individual users who have responded
        /// to a comment with the specified reactions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ReactionCounts
        {
            get { return this._reactionCounts; }
            set { this._reactionCounts = value; }
        }

        // Check to see if ReactionCounts property is set
        internal bool IsSetReactionCounts()
        {
            return this._reactionCounts != null && (this._reactionCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}