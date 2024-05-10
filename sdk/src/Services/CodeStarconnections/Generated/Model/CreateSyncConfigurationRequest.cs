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
    /// Container for the parameters to the CreateSyncConfiguration operation.
    /// Creates a sync configuration which allows Amazon Web Services to sync content from
    /// a Git repository to update a specified Amazon Web Services resource. Parameters for
    /// the sync configuration are determined by the sync type.
    /// </summary>
    public partial class CreateSyncConfigurationRequest : AmazonCodeStarconnectionsRequest
    {
        private string _branch;
        private string _configFile;
        private PublishDeploymentStatus _publishDeploymentStatus;
        private string _repositoryLinkId;
        private string _resourceName;
        private string _roleArn;
        private SyncConfigurationType _syncType;
        private TriggerResourceUpdateOn _triggerResourceUpdateOn;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch in the repository from which changes will be synced.
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
        /// The file name of the configuration file that manages syncing between the connection
        /// and the repository. This configuration file is stored in the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the repository link created for the connection. A repository link allows
        /// Git sync to monitor and sync changes to files in a specified Git repository.
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the Amazon Web Services resource (for example, a CloudFormation stack
        /// in the case of CFN_STACK_SYNC) that will be synchronized from the linked repository.
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
        /// The ARN of the IAM role that grants permission for Amazon Web Services to use Git
        /// sync to update a given Amazon Web Services resource on your behalf.
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
        /// The type of sync configuration.
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