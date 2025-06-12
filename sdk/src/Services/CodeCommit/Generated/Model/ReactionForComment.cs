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
    /// Information about the reaction values provided by users on a comment.
    /// </summary>
    public partial class ReactionForComment
    {
        private ReactionValueFormats _reaction;
        private int? _reactionsFromDeletedUsersCount;
        private List<string> _reactionUsers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Reaction. 
        /// <para>
        /// The reaction for a specified comment.
        /// </para>
        /// </summary>
        public ReactionValueFormats Reaction
        {
            get { return this._reaction; }
            set { this._reaction = value; }
        }

        // Check to see if Reaction property is set
        internal bool IsSetReaction()
        {
            return this._reaction != null;
        }

        /// <summary>
        /// Gets and sets the property ReactionsFromDeletedUsersCount. 
        /// <para>
        /// A numerical count of users who reacted with the specified emoji whose identities have
        /// been subsequently deleted from IAM. While these IAM users or roles no longer exist,
        /// the reactions might still appear in total reaction counts.
        /// </para>
        /// </summary>
        public int? ReactionsFromDeletedUsersCount
        {
            get { return this._reactionsFromDeletedUsersCount; }
            set { this._reactionsFromDeletedUsersCount = value; }
        }

        // Check to see if ReactionsFromDeletedUsersCount property is set
        internal bool IsSetReactionsFromDeletedUsersCount()
        {
            return this._reactionsFromDeletedUsersCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReactionUsers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of users who have provided reactions to the comment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReactionUsers
        {
            get { return this._reactionUsers; }
            set { this._reactionUsers = value; }
        }

        // Check to see if ReactionUsers property is set
        internal bool IsSetReactionUsers()
        {
            return this._reactionUsers != null && (this._reactionUsers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}