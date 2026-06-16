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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The version lineage metadata that tracks parent versions and creation source. Supports
    /// git-like two-parent merges for branch management.
    /// </summary>
    public partial class VersionLineageMetadata
    {
        private string _branchName;
        private string _commitMessage;
        private VersionCreatedBySource _createdBy;
        private List<string> _parentVersionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The branch name for this version. If not specified, inherits the parent's branch or
        /// defaults to <c>mainline</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// A commit message describing the changes in this version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The source that created this version.
        /// </para>
        /// </summary>
        public VersionCreatedBySource CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property ParentVersionIds. 
        /// <para>
        /// A list of parent version identifiers. Regular commits have 0-1 parents. Merge commits
        /// have 2 parents: the target branch parent and the source branch parent. The first parent
        /// represents the primary lineage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParentVersionIds
        {
            get { return this._parentVersionIds; }
            set { this._parentVersionIds = value; }
        }

        // Check to see if ParentVersionIds property is set
        internal bool IsSetParentVersionIds()
        {
            return this._parentVersionIds != null && (this._parentVersionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}