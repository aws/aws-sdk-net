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
    /// Container for the parameters to the DescribeMergeConflicts operation.
    /// Returns information about one or more merge conflicts in the attempted merge of two
    /// commit specifiers using the squash or three-way merge strategy. If the merge option
    /// for the attempted merge is specified as FAST_FORWARD_MERGE, an exception is thrown.
    /// </summary>
    public partial class DescribeMergeConflictsRequest : AmazonCodeCommitRequest
    {
        private ConflictDetailLevelTypeEnum _conflictDetailLevel;
        private ConflictResolutionStrategyTypeEnum _conflictResolutionStrategy;
        private string _destinationCommitSpecifier;
        private string _filePath;
        private int? _maxMergeHunks;
        private MergeOptionTypeEnum _mergeOption;
        private string _nextToken;
        private string _repositoryName;
        private string _sourceCommitSpecifier;

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
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The path of the target files used to describe the conflicts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property MaxMergeHunks. 
        /// <para>
        /// The maximum number of merge hunks to include in the output.
        /// </para>
        /// </summary>
        public int? MaxMergeHunks
        {
            get { return this._maxMergeHunks; }
            set { this._maxMergeHunks = value; }
        }

        // Check to see if MaxMergeHunks property is set
        internal bool IsSetMaxMergeHunks()
        {
            return this._maxMergeHunks.HasValue; 
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that, when provided in a request, returns the next batch of the
        /// results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you want to get information about a merge conflict.
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