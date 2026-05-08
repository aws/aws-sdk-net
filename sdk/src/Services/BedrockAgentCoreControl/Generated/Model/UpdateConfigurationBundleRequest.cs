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
    /// Container for the parameters to the UpdateConfigurationBundle operation.
    /// Updates a configuration bundle by creating a new version with the specified changes.
    /// Each update creates a new version in the version history.
    /// </summary>
    public partial class UpdateConfigurationBundleRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _branchName;
        private string _bundleId;
        private string _bundleName;
        private string _clientToken;
        private string _commitMessage;
        private Dictionary<string, ComponentConfiguration> _components = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentConfiguration>() : null;
        private VersionCreatedBySource _createdBy;
        private string _description;
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
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The unique identifier of the configuration bundle to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property BundleName. 
        /// <para>
        /// The updated name for the configuration bundle.
        /// </para>
        /// </summary>
        public string BundleName
        {
            get { return this._bundleName; }
            set { this._bundleName = value; }
        }

        // Check to see if BundleName property is set
        internal bool IsSetBundleName()
        {
            return this._bundleName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        /// Gets and sets the property Components. 
        /// <para>
        /// The updated component configurations. Creates a new version of the bundle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentConfiguration> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && (this._components.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The source that created this version, including the source name and optional ARN.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ParentVersionIds. 
        /// <para>
        /// A list of parent version identifiers for lineage tracking. Regular commits have a
        /// single parent. Merge commits have two parents: the target branch parent and the source
        /// branch parent. If the branch already exists, the first parent must be the latest version
        /// on that branch.
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