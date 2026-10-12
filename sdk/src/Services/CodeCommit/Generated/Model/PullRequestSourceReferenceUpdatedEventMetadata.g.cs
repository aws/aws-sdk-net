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
    /// Information about an update to the source branch of a pull request.
    /// </summary>
    public partial class PullRequestSourceReferenceUpdatedEventMetadata
    {
        /// <summary>
        /// Gets and sets the property AfterCommitId. 
        /// <para>
        /// The full commit ID of the commit in the source branch that was the tip of the branch
        /// at the time the pull request was updated.
        /// </para>
        /// </summary>
        public string AfterCommitId { get; set; }

        /// <summary>
        /// Checks to see if the AfterCommitId property is set.
        /// </summary>
        internal bool IsSetAfterCommitId() => this.AfterCommitId != null;

        /// <summary>
        /// Gets and sets the property BeforeCommitId. 
        /// <para>
        /// The full commit ID of the commit in the destination branch that was the tip of the
        /// branch at the time the pull request was updated.
        /// </para>
        /// </summary>
        public string BeforeCommitId { get; set; }

        /// <summary>
        /// Checks to see if the BeforeCommitId property is set.
        /// </summary>
        internal bool IsSetBeforeCommitId() => this.BeforeCommitId != null;

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
        /// The name of the repository where the pull request was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
