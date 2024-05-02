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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// Information, such as repository, branch, provider, and resource names for a specific
    /// sync configuration.
    /// </summary>
    public partial class SyncConfiguration
    {
        private string _branch;
        private string _configFile;
        private string _ownerId;
        private ProviderType _providerType;
        private PublishDeploymentStatus _publishDeploymentStatus;
        private string _repositoryLinkId;
        private string _repositoryName;
        private string _resourceName;
        private string _roleArn;
        private SyncConfigurationType _syncType;
        private TriggerResourceUpdateOn _triggerResourceUpdateOn;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch associated with a specific sync configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigFile. 
        /// <para>
        /// The file path to the configuration file associated with a specific sync configuration.
        /// The path should point to an actual file in the sync configurations linked repository.
        /// </para>
        /// </summary>
        public string ConfigFile
        {
            get { return this._configFile; }
            set { this._configFile = value; }
        }

        // Check to see if ConfigFile property is set
        internal bool IsSetConfigFile()
        {
            return this._configFile != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner ID for the repository associated with a specific sync configuration, such
        /// as the owner ID in GitHub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The connection provider type associated with a specific sync configuration, such as
        /// GitHub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property PublishDeploymentStatus. 
        /// <para>
        /// Whether to enable or disable publishing of deployment status to source providers.
        /// </para>
        /// </summary>
        public PublishDeploymentStatus PublishDeploymentStatus
        {
            get { return this._publishDeploymentStatus; }
            set { this._publishDeploymentStatus = value; }
        }

        // Check to see if PublishDeploymentStatus property is set
        internal bool IsSetPublishDeploymentStatus()
        {
            return this._publishDeploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryLinkId. 
        /// <para>
        /// The ID of the repository link associated with a specific sync configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RepositoryLinkId
        {
            get { return this._repositoryLinkId; }
            set { this._repositoryLinkId = value; }
        }

        // Check to see if RepositoryLinkId property is set
        internal bool IsSetRepositoryLinkId()
        {
            return this._repositoryLinkId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository associated with a specific sync configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the connection resource associated with a specific sync configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with a specific sync configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The type of sync for a specific sync configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SyncConfigurationType SyncType
        {
            get { return this._syncType; }
            set { this._syncType = value; }
        }

        // Check to see if SyncType property is set
        internal bool IsSetSyncType()
        {
            return this._syncType != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerResourceUpdateOn. 
        /// <para>
        /// When to trigger Git sync to begin the stack update.
        /// </para>
        /// </summary>
        public TriggerResourceUpdateOn TriggerResourceUpdateOn
        {
            get { return this._triggerResourceUpdateOn; }
            set { this._triggerResourceUpdateOn = value; }
        }

        // Check to see if TriggerResourceUpdateOn property is set
        internal bool IsSetTriggerResourceUpdateOn()
        {
            return this._triggerResourceUpdateOn != null;
        }

    }
}