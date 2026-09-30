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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The current status of an Elasticsearch domain.
    /// </summary>
    public partial class ElasticsearchDomainStatus
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon resource name (ARN) of an Elasticsearch domain. See <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access
        /// Management</i> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        ///  IAM access policy as a JSON-formatted string.
        /// </para>
        /// </summary>
        public string AccessPolicies { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicies property is set.
        /// </summary>
        internal bool IsSetAccessPolicies() => this.AccessPolicies != null;

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Specifies the status of the <c>AdvancedOptions</c>
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
        /// The current status of the Elasticsearch domain's advanced security options.
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
        /// The current status of the Elasticsearch domain's Auto-Tune options.
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
        /// The current status of the Elasticsearch domain's automated snapshot pause options.
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
        /// Specifies change details of the domain configuration change.
        /// </para>
        /// </summary>
        public ChangeProgressDetails ChangeProgressDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChangeProgressDetails property is set.
        /// </summary>
        internal bool IsSetChangeProgressDetails() => this.ChangeProgressDetails != null;

        /// <summary>
        /// Gets and sets the property CognitoOptions. 
        /// <para>
        /// The <c>CognitoOptions</c> for the specified domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-cognito-auth.html"
        /// target="_blank">Amazon Cognito Authentication for Kibana</a>.
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
        /// The domain creation status. <c>True</c> if the creation of an Elasticsearch domain
        /// is complete. <c>False</c> if domain creation is still in progress.
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
        /// The domain deletion status. <c>True</c> if a delete request has been received for
        /// the domain but resource cleanup is still in progress. <c>False</c> if the domain has
        /// not been deleted. Once domain deletion is complete, the status of the domain is no
        /// longer returned.
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
        /// The current status of the Elasticsearch domain's deployment strategy options.
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
        /// The current status of the Elasticsearch domain's endpoint options.
        /// </para>
        /// </summary>
        public DomainEndpointOptions DomainEndpointOptions { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpointOptions property is set.
        /// </summary>
        internal bool IsSetDomainEndpointOptions() => this.DomainEndpointOptions != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier for the specified Elasticsearch domain.
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
        /// The name of an Elasticsearch domain. Domain names are unique across the domains owned
        /// by an account within an AWS region. Domain names start with a letter or number and
        /// can contain the following characters: a-z (lowercase), 0-9, and - (hyphen).
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
        /// The <c>EBSOptions</c> for the specified domain. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-ebs"
        /// target="_blank">Configuring EBS-based Storage</a> for more information.
        /// </para>
        /// </summary>
        public EBSOptions EBSOptions { get; set; }

        /// <summary>
        /// Checks to see if the EBSOptions property is set.
        /// </summary>
        internal bool IsSetEBSOptions() => this.EBSOptions != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchClusterConfig. 
        /// <para>
        /// The type and number of instances in the domain cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ElasticsearchClusterConfig ElasticsearchClusterConfig { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchClusterConfig property is set.
        /// </summary>
        internal bool IsSetElasticsearchClusterConfig() => this.ElasticsearchClusterConfig != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchVersion.
        /// </summary>
        public string ElasticsearchVersion { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchVersion property is set.
        /// </summary>
        internal bool IsSetElasticsearchVersion() => this.ElasticsearchVersion != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        ///  Specifies the status of the <c>EncryptionAtRestOptions</c>.
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
        /// The Elasticsearch domain endpoint that you use to submit index and search requests.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// Map containing the Elasticsearch domain endpoints used to submit index and search
        /// requests. Example <c>key, value</c>: <c>'vpc','vpc-endpoint-h2dsd34efgyghrtguk5gt6j2foh4.us-east-1.es.amazonaws.com'</c>.
        /// </para>
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
        public DomainEngineMode EngineMode { get; set; }

        /// <summary>
        /// Checks to see if the EngineMode property is set.
        /// </summary>
        internal bool IsSetEngineMode() => this.EngineMode != null;

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Log publishing options for the given domain.
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
        /// Specifies the status of the <c>NodeToNodeEncryptionOptions</c>.
        /// </para>
        /// </summary>
        public NodeToNodeEncryptionOptions NodeToNodeEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the NodeToNodeEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetNodeToNodeEncryptionOptions() => this.NodeToNodeEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property Processing. 
        /// <para>
        /// The status of the Elasticsearch domain configuration. <c>True</c> if Amazon Elasticsearch
        /// Service is processing configuration changes. <c>False</c> if the configuration is
        /// active.
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
        /// The current status of the Elasticsearch domain's service software.
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
        /// Specifies the status of the <c>SnapshotOptions</c>
        /// </para>
        /// </summary>
        public SnapshotOptions SnapshotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOptions property is set.
        /// </summary>
        internal bool IsSetSnapshotOptions() => this.SnapshotOptions != null;

        /// <summary>
        /// Gets and sets the property UpgradeProcessing. 
        /// <para>
        /// The status of an Elasticsearch domain version upgrade. <c>True</c> if Amazon Elasticsearch
        /// Service is undergoing a version upgrade. <c>False</c> if the configuration is active.
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
        /// The <c>VPCOptions</c> for the specified domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html"
        /// target="_blank">VPC Endpoints for Amazon Elasticsearch Service Domains</a>.
        /// </para>
        /// </summary>
        public VPCDerivedInfo VPCOptions { get; set; }

        /// <summary>
        /// Checks to see if the VPCOptions property is set.
        /// </summary>
        internal bool IsSetVPCOptions() => this.VPCOptions != null;
    }
}
