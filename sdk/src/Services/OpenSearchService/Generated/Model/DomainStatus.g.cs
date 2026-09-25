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
    /// The current status of an OpenSearch Service domain.
    /// </summary>
    public partial class DomainStatus
    {
        /// <summary>
        /// Gets and sets the property AIMLOptions. 
        /// <para>
        /// Container for parameters required to enable all machine learning features.
        /// </para>
        /// </summary>
        public AIMLOptionsOutput AIMLOptions { get; set; }

        /// <summary>
        /// Checks to see if the AIMLOptions property is set.
        /// </summary>
        internal bool IsSetAIMLOptions() => this.AIMLOptions != null;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// identifiers </a> in the <i>Amazon Web Services Identity and Access Management User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// Identity and Access Management (IAM) policy document specifying the access policies
        /// for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 102400)]
        public string AccessPolicies { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicies property is set.
        /// </summary>
        internal bool IsSetAccessPolicies() => this.AccessPolicies != null;

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Key-value pairs that specify advanced configuration options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdvancedOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdvancedOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedOptions() => this.AdvancedOptions != null && (this.AdvancedOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdvancedSecurityOptions. 
        /// <para>
        /// Settings for fine-grained access control.
        /// </para>
        /// </summary>
        public AdvancedSecurityOptions AdvancedSecurityOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedSecurityOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedSecurityOptions() => this.AdvancedSecurityOptions != null;

        /// <summary>
        /// Gets and sets the property AutoTuneOptions. 
        /// <para>
        /// Auto-Tune settings for the domain.
        /// </para>
        /// </summary>
        public AutoTuneOptionsOutput AutoTuneOptions { get; set; }

        /// <summary>
        /// Checks to see if the AutoTuneOptions property is set.
        /// </summary>
        internal bool IsSetAutoTuneOptions() => this.AutoTuneOptions != null;

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotPauseOptions. 
        /// <para>
        /// The current status of the domain's automated snapshot pause options.
        /// </para>
        /// </summary>
        public AutomatedSnapshotPauseOptions AutomatedSnapshotPauseOptions { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedSnapshotPauseOptions property is set.
        /// </summary>
        internal bool IsSetAutomatedSnapshotPauseOptions() => this.AutomatedSnapshotPauseOptions != null;

        /// <summary>
        /// Gets and sets the property ChangeProgressDetails. 
        /// <para>
        /// Information about a configuration change happening on the domain.
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
        /// Container for the cluster configuration of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterConfig ClusterConfig { get; set; }

        /// <summary>
        /// Checks to see if the ClusterConfig property is set.
        /// </summary>
        internal bool IsSetClusterConfig() => this.ClusterConfig != null;

        /// <summary>
        /// Gets and sets the property CognitoOptions. 
        /// <para>
        /// Key-value pairs to configure Amazon Cognito authentication for OpenSearch Dashboards.
        /// </para>
        /// </summary>
        public CognitoOptions CognitoOptions { get; set; }

        /// <summary>
        /// Checks to see if the CognitoOptions property is set.
        /// </summary>
        internal bool IsSetCognitoOptions() => this.CognitoOptions != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// Creation status of an OpenSearch Service domain. True if domain creation is complete.
        /// False if domain creation is still in progress.
        /// </para>
        /// </summary>
        public bool? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Deletion status of an OpenSearch Service domain. True if domain deletion is complete.
        /// False if domain deletion is still in progress. Once deletion is complete, the status
        /// of the domain is no longer returned.
        /// </para>
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Checks to see if the Deleted property is set.
        /// </summary>
        internal bool IsSetDeleted() => this.Deleted.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentStrategyOptions. 
        /// <para>
        /// The current status of the domain's deployment strategy options.
        /// </para>
        /// </summary>
        public DeploymentStrategyOptions DeploymentStrategyOptions { get; set; }

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
        public DomainEndpointOptions DomainEndpointOptions { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpointOptions property is set.
        /// </summary>
        internal bool IsSetDomainEndpointOptions() => this.DomainEndpointOptions != null;

        /// <summary>
        /// Gets and sets the property DomainEndpointV2HostedZoneId. 
        /// <para>
        /// The dual stack hosted zone ID for the domain. 
        /// </para>
        /// </summary>
        public string DomainEndpointV2HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpointV2HostedZoneId property is set.
        /// </summary>
        internal bool IsSetDomainEndpointV2HostedZoneId() => this.DomainEndpointV2HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// Unique identifier for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the domain. Domain names are unique across all domains owned by the same account
        /// within an Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainProcessingStatus. 
        /// <para>
        /// The status of any changes that are currently in progress for the domain.
        /// </para>
        /// </summary>
        public DomainProcessingStatusType DomainProcessingStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainProcessingStatus property is set.
        /// </summary>
        internal bool IsSetDomainProcessingStatus() => this.DomainProcessingStatus != null;

        /// <summary>
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// Container for EBS-based storage settings for the domain.
        /// </para>
        /// </summary>
        public EBSOptions EBSOptions { get; set; }

        /// <summary>
        /// Checks to see if the EBSOptions property is set.
        /// </summary>
        internal bool IsSetEBSOptions() => this.EBSOptions != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Encryption at rest settings for the domain.
        /// </para>
        /// </summary>
        public EncryptionAtRestOptions EncryptionAtRestOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRestOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRestOptions() => this.EncryptionAtRestOptions != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Domain-specific endpoint used to submit index, search, and data upload requests to
        /// the domain.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property EndpointV2. 
        /// <para>
        /// If <c>IPAddressType</c> to set to <c>dualstack</c>, a version 2 domain endpoint is
        /// provisioned. This endpoint functions like a normal endpoint, except that it works
        /// with both IPv4 and IPv6 IP addresses. Normal endpoints work only with IPv4 IP addresses.
        /// 
        /// </para>
        /// </summary>
        public string EndpointV2 { get; set; }

        /// <summary>
        /// Checks to see if the EndpointV2 property is set.
        /// </summary>
        internal bool IsSetEndpointV2() => this.EndpointV2 != null;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The key-value pair that exists if the OpenSearch Service domain uses VPC endpoints.
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>IPv4 IP addresses</b> - <c>'vpc','vpc-endpoint-h2dsd34efgyghrtguk5gt6j2foh4.us-east-1.es.amazonaws.com'</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Dual stack IP addresses</b> - <c>'vpcv2':'vpc-endpoint-h2dsd34efgyghrtguk5gt6j2foh4.aos.us-east-1.on.aws'</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The engine mode for the domain.
        /// </para>
        /// </summary>
        public EngineMode EngineMode { get; set; }

        /// <summary>
        /// Checks to see if the EngineMode property is set.
        /// </summary>
        internal bool IsSetEngineMode() => this.EngineMode != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Version of OpenSearch or Elasticsearch that the domain is running, in the format <c>Elasticsearch_X.Y</c>
        /// or <c>OpenSearch_X.Y</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 18)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IPAddressType. 
        /// <para>
        /// The type of IP addresses supported by the endpoint for the domain.
        /// </para>
        /// </summary>
        public IPAddressType IPAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IPAddressType property is set.
        /// </summary>
        internal bool IsSetIPAddressType() => this.IPAddressType != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterOptions. 
        /// <para>
        /// Configuration options for controlling IAM Identity Center integration within a domain.
        /// </para>
        /// </summary>
        public IdentityCenterOptions IdentityCenterOptions { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterOptions property is set.
        /// </summary>
        internal bool IsSetIdentityCenterOptions() => this.IdentityCenterOptions != null;

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Log publishing options for the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, LogPublishingOption> LogPublishingOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, LogPublishingOption>() : null;

        /// <summary>
        /// Checks to see if the LogPublishingOptions property is set.
        /// </summary>
        internal bool IsSetLogPublishingOptions() => this.LogPublishingOptions != null && (this.LogPublishingOptions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public NodeToNodeEncryptionOptions NodeToNodeEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the NodeToNodeEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetNodeToNodeEncryptionOptions() => this.NodeToNodeEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property OffPeakWindowOptions. 
        /// <para>
        /// Options that specify a custom 10-hour window during which OpenSearch Service can perform
        /// configuration changes on the domain.
        /// </para>
        /// </summary>
        public OffPeakWindowOptions OffPeakWindowOptions { get; set; }

        /// <summary>
        /// Checks to see if the OffPeakWindowOptions property is set.
        /// </summary>
        internal bool IsSetOffPeakWindowOptions() => this.OffPeakWindowOptions != null;

        /// <summary>
        /// Gets and sets the property Processing. 
        /// <para>
        /// The status of the domain configuration. True if OpenSearch Service is processing configuration
        /// changes. False if the configuration is active.
        /// </para>
        /// </summary>
        public bool? Processing { get; set; }

        /// <summary>
        /// Checks to see if the Processing property is set.
        /// </summary>
        internal bool IsSetProcessing() => this.Processing.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceSoftwareOptions. 
        /// <para>
        /// The current status of the domain's service software.
        /// </para>
        /// </summary>
        public ServiceSoftwareOptions ServiceSoftwareOptions { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSoftwareOptions property is set.
        /// </summary>
        internal bool IsSetServiceSoftwareOptions() => this.ServiceSoftwareOptions != null;

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// DEPRECATED. Container for parameters required to configure automated snapshots of
        /// domain indexes.
        /// </para>
        /// </summary>
        public SnapshotOptions SnapshotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOptions property is set.
        /// </summary>
        internal bool IsSetSnapshotOptions() => this.SnapshotOptions != null;

        /// <summary>
        /// Gets and sets the property SoftwareUpdateOptions. 
        /// <para>
        /// Service software update options for the domain.
        /// </para>
        /// </summary>
        public SoftwareUpdateOptions SoftwareUpdateOptions { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareUpdateOptions property is set.
        /// </summary>
        internal bool IsSetSoftwareUpdateOptions() => this.SoftwareUpdateOptions != null;

        /// <summary>
        /// Gets and sets the property UpgradeProcessing. 
        /// <para>
        /// The status of a domain version upgrade to a new version of OpenSearch or Elasticsearch.
        /// True if OpenSearch Service is in the process of a version upgrade. False if the configuration
        /// is active.
        /// </para>
        /// </summary>
        public bool? UpgradeProcessing { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeProcessing property is set.
        /// </summary>
        internal bool IsSetUpgradeProcessing() => this.UpgradeProcessing.HasValue;

        /// <summary>
        /// Gets and sets the property UseCase. 
        /// <para>
        /// The primary use case for the domain.
        /// </para>
        /// </summary>
        public DomainUseCase UseCase { get; set; }

        /// <summary>
        /// Checks to see if the UseCase property is set.
        /// </summary>
        internal bool IsSetUseCase() => this.UseCase != null;

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// The VPC configuration for the domain.
        /// </para>
        /// </summary>
        public VPCDerivedInfo VPCOptions { get; set; }

        /// <summary>
        /// Checks to see if the VPCOptions property is set.
        /// </summary>
        internal bool IsSetVPCOptions() => this.VPCOptions != null;
    }
}
