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
    /// Returns information about a pull request target.
    /// </summary>
    public partial class PullRequestTarget
    {
        /// <summary>
        /// Gets and sets the property DestinationCommit. 
        /// <para>
        /// The full commit ID that is the tip of the destination branch. This is the commit where
        /// the pull request was or will be merged.
        /// </para>
        /// </summary>
        public string DestinationCommit { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCommit property is set.
        /// </summary>
        internal bool IsSetDestinationCommit() => this.DestinationCommit != null;

        /// <summary>
        /// Gets and sets the property DestinationReference. 
        /// <para>
        /// The branch of the repository where the pull request changes are merged. Also known
        /// as the destination branch. 
        /// </para>
        /// </summary>
        public string DestinationReference { get; set; }

        /// <summary>
        /// Checks to see if the DestinationReference property is set.
        /// </summary>
        internal bool IsSetDestinationReference() => this.DestinationReference != null;

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
        /// Gets and sets the property MergeMetadata. 
        /// <para>
        /// Returns metadata about the state of the merge, including whether the merge has been
        /// made.
        /// </para>
        /// </summary>
        public MergeMetadata MergeMetadata { get; set; }

        /// <summary>
        /// Checks to see if the MergeMetadata property is set.
        /// </summary>
        internal bool IsSetMergeMetadata() => this.MergeMetadata != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the pull request source and destination branches.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property SourceCommit. 
        /// <para>
        /// The full commit ID of the tip of the source branch used to create the pull request.
        /// If the pull request branch is updated by a push while the pull request is open, the
        /// commit ID changes to reflect the new tip of the branch.
        /// </para>
        /// </summary>
        public string SourceCommit { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommit property is set.
        /// </summary>
        internal bool IsSetSourceCommit() => this.SourceCommit != null;

        /// <summary>
        /// Gets and sets the property SourceReference. 
        /// <para>
        /// The branch of the repository that contains the changes for the pull request. Also
        /// known as the source branch.
        /// </para>
        /// </summary>
        public string SourceReference { get; set; }

        /// <summary>
        /// Checks to see if the SourceReference property is set.
        /// </summary>
        internal bool IsSetSourceReference() => this.SourceReference != null;
    }
}
