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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the configuration of an OpenSearch Service domain.
    /// </summary>
    public partial class DomainConfig
    {
        /// <summary>
        /// Gets and sets the property AIMLOptions. 
        /// <para>
        /// Container for parameters required to enable all machine learning features.
        /// </para>
        /// </summary>
        public AIMLOptionsStatus AIMLOptions { get; set; }

        /// <summary>
        /// Checks to see if the AIMLOptions property is set.
        /// </summary>
        internal bool IsSetAIMLOptions() => this.AIMLOptions != null;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// Specifies the access policies for the domain.
        /// </para>
        /// </summary>
        public AccessPoliciesStatus AccessPolicies { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicies property is set.
        /// </summary>
        internal bool IsSetAccessPolicies() => this.AccessPolicies != null;

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Key-value pairs to specify advanced configuration options. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options">Advanced
        /// options</a>.
        /// </para>
        /// </summary>
        public AdvancedOptionsStatus AdvancedOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedOptions() => this.AdvancedOptions != null;

        /// <summary>
        /// Gets and sets the property AdvancedSecurityOptions. 
        /// <para>
        /// Container for fine-grained access control settings for the domain.
        /// </para>
        /// </summary>
        public AdvancedSecurityOptionsStatus AdvancedSecurityOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedSecurityOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedSecurityOptions() => this.AdvancedSecurityOptions != null;

        /// <summary>
        /// Gets and sets the property AutoTuneOptions. 
        /// <para>
        /// Container for Auto-Tune settings for the domain.
        /// </para>
        /// </summary>
        public AutoTuneOptionsStatus AutoTuneOptions { get; set; }

        /// <summary>
        /// Checks to see if the AutoTuneOptions property is set.
        /// </summary>
        internal bool IsSetAutoTuneOptions() => this.AutoTuneOptions != null;

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotPauseOptions. 
        /// <para>
        /// Specifies <c>AutomatedSnapshotPauseOptions</c> for the domain.
        /// </para>
        /// </summary>
        public AutomatedSnapshotPauseOptionsStatus AutomatedSnapshotPauseOptions { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedSnapshotPauseOptions property is set.
        /// </summary>
        internal bool IsSetAutomatedSnapshotPauseOptions() => this.AutomatedSnapshotPauseOptions != null;

        /// <summary>
        /// Gets and sets the property ChangeProgressDetails. 
        /// <para>
        /// Container for information about the progress of an existing configuration change.
        /// </para>
        /// </summary>
        public ChangeProgressDetails ChangeProgressDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChangeProgressDetails property is set.
        /// </summary>
        internal bool IsSetChangeProgressDetails() => this.ChangeProgressDetails != null;

        /// <summary>
        /// Gets and sets the property ClusterConfig. 
        /// <para>
        /// Container for the cluster configuration of a the domain.
        /// </para>
        /// </summary>
        public ClusterConfigStatus ClusterConfig { get; set; }

        /// <summary>
        /// Checks to see if the ClusterConfig property is set.
        /// </summary>
        internal bool IsSetClusterConfig() => this.ClusterConfig != null;

        /// <summary>
        /// Gets and sets the property CognitoOptions. 
        /// <para>
        /// Container for Amazon Cognito options for the domain.
        /// </para>
        /// </summary>
        public CognitoOptionsStatus CognitoOptions { get; set; }

        /// <summary>
        /// Checks to see if the CognitoOptions property is set.
        /// </summary>
        internal bool IsSetCognitoOptions() => this.CognitoOptions != null;

        /// <summary>
        /// Gets and sets the property DeploymentStrategyOptions. 
        /// <para>
        /// Specifies <c>DeploymentStrategyOptions</c> for the domain.
        /// </para>
        /// </summary>
        public DeploymentStrategyOptionsStatus DeploymentStrategyOptions { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStrategyOptions property is set.
        /// </summary>
        internal bool IsSetDeploymentStrategyOptions() => this.DeploymentStrategyOptions != null;

        /// <summary>
        /// Gets and sets the property DomainEndpointOptions. 
        /// <para>
        /// Additional options for the domain endpoint, such as whether to require HTTPS for all
        /// traffic.
        /// </para>
        /// </summary>
        public DomainEndpointOptionsStatus DomainEndpointOptions { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpointOptions property is set.
        /// </summary>
        internal bool IsSetDomainEndpointOptions() => this.DomainEndpointOptions != null;

        /// <summary>
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// Container for EBS options configured for the domain.
        /// </para>
        /// </summary>
        public EBSOptionsStatus EBSOptions { get; set; }

        /// <summary>
        /// Checks to see if the EBSOptions property is set.
        /// </summary>
        internal bool IsSetEBSOptions() => this.EBSOptions != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Key-value pairs to enable encryption at rest.
        /// </para>
        /// </summary>
        public EncryptionAtRestOptionsStatus EncryptionAtRestOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRestOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRestOptions() => this.EncryptionAtRestOptions != null;

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The engine mode configured for the domain.
        /// </para>
        /// </summary>
        public EngineModeStatus EngineMode { get; set; }

        /// <summary>
        /// Checks to see if the EngineMode property is set.
        /// </summary>
        internal bool IsSetEngineMode() => this.EngineMode != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The OpenSearch or Elasticsearch version that the domain is running.
        /// </para>
        /// </summary>
        public VersionStatus EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IPAddressType. 
        /// <para>
        /// Choose either dual stack or IPv4 as your IP address type. Dual stack allows you to
        /// share domain resources across IPv4 and IPv6 address types, and is the recommended
        /// option. If you set your IP address type to dual stack, you can't change your address
        /// type later.
        /// </para>
        /// </summary>
        public IPAddressTypeStatus IPAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IPAddressType property is set.
        /// </summary>
        internal bool IsSetIPAddressType() => this.IPAddressType != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterOptions. 
        /// <para>
        /// Configuration options for enabling and managing IAM Identity Center integration within
        /// a domain.
        /// </para>
        /// </summary>
        public IdentityCenterOptionsStatus IdentityCenterOptions { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterOptions property is set.
        /// </summary>
        internal bool IsSetIdentityCenterOptions() => this.IdentityCenterOptions != null;

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Key-value pairs to configure log publishing.
        /// </para>
        /// </summary>
        public LogPublishingOptionsStatus LogPublishingOptions { get; set; }

        /// <summary>
        /// Checks to see if the LogPublishingOptions property is set.
        /// </summary>
        internal bool IsSetLogPublishingOptions() => this.LogPublishingOptions != null;

        /// <summary>
        /// Gets and sets the property ModifyingProperties. 
        /// <para>
        /// Information about the domain properties that are currently being modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModifyingProperties> ModifyingProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<ModifyingProperties>() : null;

        /// <summary>
        /// Checks to see if the ModifyingProperties property is set.
        /// </summary>
        internal bool IsSetModifyingProperties() => this.ModifyingProperties != null && (this.ModifyingProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeToNodeEncryptionOptions. 
        /// <para>
        /// Whether node-to-node encryption is enabled or disabled.
        /// </para>
        /// </summary>
        public NodeToNodeEncryptionOptionsStatus NodeToNodeEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the NodeToNodeEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetNodeToNodeEncryptionOptions() => this.NodeToNodeEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property OffPeakWindowOptions. 
        /// <para>
        /// Container for off-peak window options for the domain.
        /// </para>
        /// </summary>
        public OffPeakWindowOptionsStatus OffPeakWindowOptions { get; set; }

        /// <summary>
        /// Checks to see if the OffPeakWindowOptions property is set.
        /// </summary>
        internal bool IsSetOffPeakWindowOptions() => this.OffPeakWindowOptions != null;

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// DEPRECATED. Container for parameters required to configure automated snapshots of
        /// domain indexes.
        /// </para>
        /// </summary>
        public SnapshotOptionsStatus SnapshotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOptions property is set.
        /// </summary>
        internal bool IsSetSnapshotOptions() => this.SnapshotOptions != null;

        /// <summary>
        /// Gets and sets the property SoftwareUpdateOptions. 
        /// <para>
        /// Software update options for the domain.
        /// </para>
        /// </summary>
        public SoftwareUpdateOptionsStatus SoftwareUpdateOptions { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareUpdateOptions property is set.
        /// </summary>
        internal bool IsSetSoftwareUpdateOptions() => this.SoftwareUpdateOptions != null;

        /// <summary>
        /// Gets and sets the property UseCase. 
        /// <para>
        /// The use case configured for the domain.
        /// </para>
        /// </summary>
        public UseCaseStatus UseCase { get; set; }

        /// <summary>
        /// Checks to see if the UseCase property is set.
        /// </summary>
        internal bool IsSetUseCase() => this.UseCase != null;

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// The current VPC options for the domain and the status of any updates to their configuration.
        /// </para>
        /// </summary>
        public VPCDerivedInfoStatus VPCOptions { get; set; }

        /// <summary>
        /// Checks to see if the VPCOptions property is set.
        /// </summary>
        internal bool IsSetVPCOptions() => this.VPCOptions != null;
    }
}
