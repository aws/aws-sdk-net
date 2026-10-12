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
    /// Container for the parameters to the GetCommentReactions operation. Returns information
    /// about reactions to a specified comment ID. Reactions from users who have been deleted
    /// will not be included in the count.
    /// </summary>
    public partial class GetCommentReactionsRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property CommentId. 
        /// <para>
        /// The ID of the comment for which you want to get reactions information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CommentId { get; set; }

        /// <summary>
        /// Checks to see if the CommentId property is set.
        /// </summary>
        internal bool IsSetCommentId() => this.CommentId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results. The
        /// default is the same as the allowed maximum, 1,000.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that, when provided in a request, returns the next batch of the
        /// results. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ReactionUserArn. 
        /// <para>
        /// Optional. The Amazon Resource Name (ARN) of the user or identity for which you want
        /// to get reaction information.
        /// </para>
        /// </summary>
        public string ReactionUserArn { get; set; }

        /// <summary>
        /// Checks to see if the ReactionUserArn property is set.
        /// </summary>
        internal bool IsSetReactionUserArn() => this.ReactionUserArn != null;
    }
}
