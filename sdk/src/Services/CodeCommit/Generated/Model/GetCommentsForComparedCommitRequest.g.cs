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
    /// Container for the parameters to the GetCommentsForComparedCommit operation. Returns
    /// information about comments made on the comparison between two commits. <note> <para>
    /// Reaction counts might include numbers from user identities who were deleted after
    /// the reaction was made. For a count of reactions from active identities, use GetCommentReactions.
    /// </para> </note>
    /// </summary>
    public partial class GetCommentsForComparedCommitRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property AfterCommitId. 
        /// <para>
        /// To establish the directionality of the comparison, the full commit ID of the after
        /// commit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AfterCommitId { get; set; }

        /// <summary>
        /// Checks to see if the AfterCommitId property is set.
        /// </summary>
        internal bool IsSetAfterCommitId() => this.AfterCommitId != null;

        /// <summary>
        /// Gets and sets the property BeforeCommitId. 
        /// <para>
        /// To establish the directionality of the comparison, the full commit ID of the before
        /// commit.
        /// </para>
        /// </summary>
        public string BeforeCommitId { get; set; }

        /// <summary>
        /// Checks to see if the BeforeCommitId property is set.
        /// </summary>
        internal bool IsSetBeforeCommitId() => this.BeforeCommitId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results. The
        /// default is 100 comments, but you can configure up to 500.
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
        /// An enumeration token that when provided in a request, returns the next batch of the
        /// results. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you want to compare commits.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
