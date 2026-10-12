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
    /// Metadata about the pull request that is used when comparing the pull request source
    /// with its destination.
    /// </summary>
    public partial class PullRequestCreatedEventMetadata
    {
        /// <summary>
        /// Gets and sets the property DestinationCommitId. 
        /// <para>
        /// The commit ID of the tip of the branch specified as the destination branch when the
        /// pull request was created.
        /// </para>
        /// </summary>
        public string DestinationCommitId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCommitId property is set.
        /// </summary>
        internal bool IsSetDestinationCommitId() => this.DestinationCommitId != null;

        /// <summary>
        /// Gets and sets the property MergeBase. 
        /// <para>
        /// The commit ID of the most recent commit that the source branch and the destination
        /// branch have in common.
        /// </para>
        /// </summary>
        public string MergeBase { get; set; }

        /// <summary>
        /// Checks to see if the MergeBase property is set.
        /// </summary>
        internal bool IsSetMergeBase() => this.MergeBase != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where the pull request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property SourceCommitId. 
        /// <para>
        /// The commit ID on the source branch used when the pull request was created.
        /// </para>
        /// </summary>
        public string SourceCommitId { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommitId property is set.
        /// </summary>
        internal bool IsSetSourceCommitId() => this.SourceCommitId != null;
    }
}
