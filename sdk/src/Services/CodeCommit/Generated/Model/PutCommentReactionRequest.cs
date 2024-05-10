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
    /// Container for the parameters to the PutCommentReaction operation.
    /// Adds or updates a reaction to a specified comment for the user whose identity is used
    /// to make the request. You can only add or update a reaction for yourself. You cannot
    /// add, modify, or delete a reaction for another user.
    /// </summary>
    public partial class PutCommentReactionRequest : AmazonCodeCommitRequest
    {
        private string _commentId;
        private string _reactionValue;

        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The ID of the comment to which you want to add or update a reaction.
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
        /// Gets and sets the property ReactionValue. 
        /// <para>
        /// The emoji reaction you want to add or update. To remove a reaction, provide a value
        /// of blank or null. You can also provide the value of none. For information about emoji
        /// reaction values supported in CodeCommit, see the <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/how-to-commit-comment.html#emoji-reaction-table">CodeCommit
        /// User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReactionValue
        {
            get { return this._reactionValue; }
            set { this._reactionValue = value; }
        }

        // Check to see if ReactionValue property is set
        internal bool IsSetReactionValue()
        {
            return this._reactionValue != null;
        }

    }
}