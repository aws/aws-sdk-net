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
    /// Container for the parameters to the GetMergeConflicts operation. Returns information
    /// about merge conflicts between the before and after commit IDs for a pull request in
    /// a repository.
    /// </summary>
    public partial class GetMergeConflictsRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property ConflictDetailLevel. 
        /// <para>
        /// The level of conflict detail to use. If unspecified, the default FILE_LEVEL is used,
        /// which returns a not-mergeable result if the same file has differences in both branches.
        /// If LINE_LEVEL is specified, a conflict is considered not mergeable if the same file
        /// in both branches has differences on the same line.
        /// </para>
        /// </summary>
        public ConflictDetailLevelTypeEnum ConflictDetailLevel { get; set; }

        /// <summary>
        /// Checks to see if the ConflictDetailLevel property is set.
        /// </summary>
        internal bool IsSetConflictDetailLevel() => this.ConflictDetailLevel != null;

        /// <summary>
        /// Gets and sets the property ConflictResolutionStrategy. 
        /// <para>
        /// Specifies which branch to use when resolving conflicts, or whether to attempt automatically
        /// merging two versions of a file. The default is NONE, which requires any conflicts
        /// to be resolved manually before the merge operation is successful.
        /// </para>
        /// </summary>
        public ConflictResolutionStrategyTypeEnum ConflictResolutionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ConflictResolutionStrategy property is set.
        /// </summary>
        internal bool IsSetConflictResolutionStrategy() => this.ConflictResolutionStrategy != null;

        /// <summary>
        /// Gets and sets the property DestinationCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, a branch name or a full commit ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationCommitSpecifier { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCommitSpecifier property is set.
        /// </summary>
        internal bool IsSetDestinationCommitSpecifier() => this.DestinationCommitSpecifier != null;

        /// <summary>
        /// Gets and sets the property MaxConflictFiles. 
        /// <para>
        /// The maximum number of files to include in the output.
        /// </para>
        /// </summary>
        public int? MaxConflictFiles { get; set; }

        /// <summary>
        /// Checks to see if the MaxConflictFiles property is set.
        /// </summary>
        internal bool IsSetMaxConflictFiles() => this.MaxConflictFiles.HasValue;

        /// <summary>
        /// Gets and sets the property MergeOption. 
        /// <para>
        /// The merge option or strategy you want to use to merge the code. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MergeOptionTypeEnum MergeOption { get; set; }

        /// <summary>
        /// Checks to see if the MergeOption property is set.
        /// </summary>
        internal bool IsSetMergeOption() => this.MergeOption != null;

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
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where the pull request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property SourceCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, a branch name or a full commit ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceCommitSpecifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommitSpecifier property is set.
        /// </summary>
        internal bool IsSetSourceCommitSpecifier() => this.SourceCommitSpecifier != null;
    }
}
