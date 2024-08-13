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
    /// Container for the parameters to the CreateUnreferencedMergeCommit operation.
    /// Creates an unreferenced commit that represents the result of merging two branches
    /// using a specified merge strategy. This can help you determine the outcome of a potential
    /// merge. This API cannot be used with the fast-forward merge strategy because that strategy
    /// does not create a merge commit.
    /// 
    ///  <note> 
    /// <para>
    /// This unreferenced merge commit can only be accessed using the GetCommit API or through
    /// git commands such as git fetch. To retrieve this commit, you must specify its commit
    /// ID or otherwise reference it.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateUnreferencedMergeCommitRequest : AmazonCodeCommitRequest
    {
        private string _authorName;
        private string _commitMessage;
        private ConflictDetailLevelTypeEnum _conflictDetailLevel;
        private ConflictResolution _conflictResolution;
        private ConflictResolutionStrategyTypeEnum _conflictResolutionStrategy;
        private string _destinationCommitSpecifier;
        private string _email;
        private bool? _keepEmptyFolders;
        private MergeOptionTypeEnum _mergeOption;
        private string _repositoryName;
        private string _sourceCommitSpecifier;

        /// <summary>
        /// Gets and sets the property AuthorName. 
        /// <para>
        /// The name of the author who created the unreferenced commit. This information is used
        /// as both the author and committer for the commit.
        /// </para>
        /// </summary>
        public string AuthorName
        {
            get { return this._authorName; }
            set { this._authorName = value; }
        }

        // Check to see if AuthorName property is set
        internal bool IsSetAuthorName()
        {
            return this._authorName != null;
        }

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// The commit message for the unreferenced commit.
        /// </para>
        /// </summary>
        public string CommitMessage
        {
            get { return this._commitMessage; }
            set { this._commitMessage = value; }
        }

        // Check to see if CommitMessage property is set
        internal bool IsSetCommitMessage()
        {
            return this._commitMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ConflictDetailLevel. 
        /// <para>
        /// The level of conflict detail to use. If unspecified, the default FILE_LEVEL is used,
        /// which returns a not-mergeable result if the same file has differences in both branches.
        /// If LINE_LEVEL is specified, a conflict is considered not mergeable if the same file
        /// in both branches has differences on the same line.
        /// </para>
        /// </summary>
        public ConflictDetailLevelTypeEnum ConflictDetailLevel
        {
            get { return this._conflictDetailLevel; }
            set { this._conflictDetailLevel = value; }
        }

        // Check to see if ConflictDetailLevel property is set
        internal bool IsSetConflictDetailLevel()
        {
            return this._conflictDetailLevel != null;
        }

        /// <summary>
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// If AUTOMERGE is the conflict resolution strategy, a list of inputs to use when resolving
        /// conflicts during a merge.
        /// </para>
        /// </summary>
        public ConflictResolution ConflictResolution
        {
            get { return this._conflictResolution; }
            set { this._conflictResolution = value; }
        }

        // Check to see if ConflictResolution property is set
        internal bool IsSetConflictResolution()
        {
            return this._conflictResolution != null;
        }

        /// <summary>
        /// Gets and sets the property ConflictResolutionStrategy. 
        /// <para>
        /// Specifies which branch to use when resolving conflicts, or whether to attempt automatically
        /// merging two versions of a file. The default is NONE, which requires any conflicts
        /// to be resolved manually before the merge operation is successful.
        /// </para>
        /// </summary>
        public ConflictResolutionStrategyTypeEnum ConflictResolutionStrategy
        {
            get { return this._conflictResolutionStrategy; }
            set { this._conflictResolutionStrategy = value; }
        }

        // Check to see if ConflictResolutionStrategy property is set
        internal bool IsSetConflictResolutionStrategy()
        {
            return this._conflictResolutionStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, a branch name or a full commit ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationCommitSpecifier
        {
            get { return this._destinationCommitSpecifier; }
            set { this._destinationCommitSpecifier = value; }
        }

        // Check to see if DestinationCommitSpecifier property is set
        internal bool IsSetDestinationCommitSpecifier()
        {
            return this._destinationCommitSpecifier != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address for the person who created the unreferenced commit.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property KeepEmptyFolders. 
        /// <para>
        /// If the commit contains deletions, whether to keep a folder or folder structure if
        /// the changes leave the folders empty. If this is specified as true, a .gitkeep file
        /// is created for empty folders. The default is false.
        /// </para>
        /// </summary>
        public bool? KeepEmptyFolders
        {
            get { return this._keepEmptyFolders; }
            set { this._keepEmptyFolders = value; }
        }

        // Check to see if KeepEmptyFolders property is set
        internal bool IsSetKeepEmptyFolders()
        {
            return this._keepEmptyFolders.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MergeOption. 
        /// <para>
        /// The merge option or strategy you want to use to merge the code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MergeOptionTypeEnum MergeOption
        {
            get { return this._mergeOption; }
            set { this._mergeOption = value; }
        }

        // Check to see if MergeOption property is set
        internal bool IsSetMergeOption()
        {
            return this._mergeOption != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you want to create the unreferenced merge commit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, a branch name or a full commit ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceCommitSpecifier
        {
            get { return this._sourceCommitSpecifier; }
            set { this._sourceCommitSpecifier = value; }
        }

        // Check to see if SourceCommitSpecifier property is set
        internal bool IsSetSourceCommitSpecifier()
        {
            return this._sourceCommitSpecifier != null;
        }

    }
}