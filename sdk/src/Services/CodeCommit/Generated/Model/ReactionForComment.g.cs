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
    /// Information about the reaction values provided by users on a comment.
    /// </summary>
    public partial class ReactionForComment
    {
        /// <summary>
        /// Gets and sets the property Reaction. 
        /// <para>
        /// The reaction for a specified comment.
        /// </para>
        /// </summary>
        public ReactionValueFormats Reaction { get; set; }

        /// <summary>
        /// Checks to see if the Reaction property is set.
        /// </summary>
        internal bool IsSetReaction() => this.Reaction != null;

        /// <summary>
        /// Gets and sets the property ReactionUsers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of users who have provided reactions to the comment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReactionUsers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReactionUsers property is set.
        /// </summary>
        internal bool IsSetReactionUsers() => this.ReactionUsers != null && (this.ReactionUsers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReactionsFromDeletedUsersCount. 
        /// <para>
        /// A numerical count of users who reacted with the specified emoji whose identities have
        /// been subsequently deleted from IAM. While these IAM users or roles no longer exist,
        /// the reactions might still appear in total reaction counts.
        /// </para>
        /// </summary>
        public int? ReactionsFromDeletedUsersCount { get; set; }

        /// <summary>
        /// Checks to see if the ReactionsFromDeletedUsersCount property is set.
        /// </summary>
        internal bool IsSetReactionsFromDeletedUsersCount() => this.ReactionsFromDeletedUsersCount.HasValue;
    }
}
