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
    /// Container for the parameters to the GetCommentReactions operation.
    /// Returns information about reactions to a specified comment ID. Reactions from users
    /// who have been deleted will not be included in the count.
    /// </summary>
    public partial class GetCommentReactionsRequest : AmazonCodeCommitRequest
    {
        private string _commentId;
        private int? _maxResults;
        private string _nextToken;
        private string _reactionUserArn;

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The ID of the comment for which you want to get reactions information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results. The
        /// default is the same as the allowed maximum, 1,000.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that, when provided in a request, returns the next batch of the
        /// results. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReactionUserArn. 
        /// <para>
        /// Optional. The Amazon Resource Name (ARN) of the user or identity for which you want
        /// to get reaction information.
        /// </para>
        /// </summary>
        public string ReactionUserArn
        {
            get { return this._reactionUserArn; }
            set { this._reactionUserArn = value; }
        }

        // Check to see if ReactionUserArn property is set
        internal bool IsSetReactionUserArn()
        {
            return this._reactionUserArn != null;
        }

    }
}