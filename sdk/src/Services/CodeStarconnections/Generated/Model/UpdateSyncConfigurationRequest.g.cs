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

namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSyncConfiguration operation. Updates the
    /// sync configuration for your connection and a specified external Git repository.
    /// </summary>
    public partial class UpdateSyncConfigurationRequest : AmazonCodeStarconnectionsRequest
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch for the sync configuration to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property ConfigFile. 
        /// <para>
        /// The configuration file for the sync configuration to be updated.
        /// </para>
        /// </summary>
        public string ConfigFile { get; set; }

        /// <summary>
        /// Checks to see if the ConfigFile property is set.
        /// </summary>
        internal bool IsSetConfigFile() => this.ConfigFile != null;

        /// <summary>
        /// Gets and sets the property PublishDeploymentStatus. 
        /// <para>
        /// Whether to enable or disable publishing of deployment status to source providers.
        /// </para>
        /// </summary>
        public PublishDeploymentStatus PublishDeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the PublishDeploymentStatus property is set.
        /// </summary>
        internal bool IsSetPublishDeploymentStatus() => this.PublishDeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property RepositoryLinkId. 
        /// <para>
        /// The ID of the repository link for the sync configuration to be updated.
        /// </para>
        /// </summary>
        public string RepositoryLinkId { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryLinkId property is set.
        /// </summary>
        internal bool IsSetRepositoryLinkId() => this.RepositoryLinkId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the Amazon Web Services resource for the sync configuration to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role for the sync configuration to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The sync type for the sync configuration to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncConfigurationType SyncType { get; set; }

        /// <summary>
        /// Checks to see if the SyncType property is set.
        /// </summary>
        internal bool IsSetSyncType() => this.SyncType != null;

        /// <summary>
        /// Gets and sets the property TriggerResourceUpdateOn. 
        /// <para>
        /// When to trigger Git sync to begin the stack update.
        /// </para>
        /// </summary>
        public TriggerResourceUpdateOn TriggerResourceUpdateOn { get; set; }

        /// <summary>
        /// Checks to see if the TriggerResourceUpdateOn property is set.
        /// </summary>
        internal bool IsSetTriggerResourceUpdateOn() => this.TriggerResourceUpdateOn != null;
    }
}
