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
    /// Container for the parameters to the MergePullRequestBySquash operation. Attempts to
    /// merge the source commit of a pull request into the specified destination branch for
    /// that pull request at the specified commit using the squash merge strategy. If the
    /// merge is successful, it closes the pull request.
    /// </summary>
    public partial class MergePullRequestBySquashRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorName. 
        /// <para>
        /// The name of the author who created the commit. This information is used as both the
        /// author and committer for the commit.
        /// </para>
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Checks to see if the AuthorName property is set.
        /// </summary>
        internal bool IsSetAuthorName() => this.AuthorName != null;

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// The commit message to include in the commit information for the merge.
        /// </para>
        /// </summary>
        public string CommitMessage { get; set; }

        /// <summary>
        /// Checks to see if the CommitMessage property is set.
        /// </summary>
        internal bool IsSetCommitMessage() => this.CommitMessage != null;

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
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// If AUTOMERGE is the conflict resolution strategy, a list of inputs to use when resolving
        /// conflicts during a merge.
        /// </para>
        /// </summary>
        public ConflictResolution ConflictResolution { get; set; }

        /// <summary>
        /// Checks to see if the ConflictResolution property is set.
        /// </summary>
        internal bool IsSetConflictResolution() => this.ConflictResolution != null;

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
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the person merging the branches. This information is used in
        /// the commit information for the merge.
        /// </para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property KeepEmptyFolders. 
        /// <para>
        /// If the commit contains deletions, whether to keep a folder or folder structure if
        /// the changes leave the folders empty. If true, a .gitkeep file is created for empty
        /// folders. The default is false.
        /// </para>
        /// </summary>
        public bool? KeepEmptyFolders { get; set; }

        /// <summary>
        /// Checks to see if the KeepEmptyFolders property is set.
        /// </summary>
        internal bool IsSetKeepEmptyFolders() => this.KeepEmptyFolders.HasValue;

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request. To get this ID, use <a>ListPullRequests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PullRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestId property is set.
        /// </summary>
        internal bool IsSetPullRequestId() => this.PullRequestId != null;

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
        /// Gets and sets the property SourceCommitId. 
        /// <para>
        /// The full commit ID of the original or updated commit in the pull request source branch.
        /// Pass this value if you want an exception thrown if the current commit ID of the tip
        /// of the source branch does not match this commit ID.
        /// </para>
        /// </summary>
        public string SourceCommitId { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommitId property is set.
        /// </summary>
        internal bool IsSetSourceCommitId() => this.SourceCommitId != null;
    }
}
