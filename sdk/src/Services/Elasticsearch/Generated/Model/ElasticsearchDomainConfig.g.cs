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
    /// The configuration of an Elasticsearch domain.
    /// </summary>
    public partial class ElasticsearchDomainConfig
    {
        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM access policy as a JSON-formatted string.
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
        /// Specifies the <c>AdvancedOptions</c> for the domain. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-advanced-options"
        /// target="_blank">Configuring Advanced Options</a> for more information.
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
        /// Specifies <c>AdvancedSecurityOptions</c> for the domain. 
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
        /// Specifies <c>AutoTuneOptions</c> for the domain. 
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
        /// Specifies the <c>DomainEndpointOptions</c> for the Elasticsearch domain.
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
        /// Specifies the <c>EBSOptions</c> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public EBSOptionsStatus EBSOptions { get; set; }

        /// <summary>
        /// Checks to see if the EBSOptions property is set.
        /// </summary>
        internal bool IsSetEBSOptions() => this.EBSOptions != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchClusterConfig. 
        /// <para>
        /// Specifies the <c>ElasticsearchClusterConfig</c> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public ElasticsearchClusterConfigStatus ElasticsearchClusterConfig { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchClusterConfig property is set.
        /// </summary>
        internal bool IsSetElasticsearchClusterConfig() => this.ElasticsearchClusterConfig != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchVersion. 
        /// <para>
        /// String of format X.Y to specify version for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public ElasticsearchVersionStatus ElasticsearchVersion { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchVersion property is set.
        /// </summary>
        internal bool IsSetElasticsearchVersion() => this.ElasticsearchVersion != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Specifies the <c>EncryptionAtRestOptions</c> for the Elasticsearch domain.
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
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Log publishing options for the given domain.
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
        /// Specifies the <c>NodeToNodeEncryptionOptions</c> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public NodeToNodeEncryptionOptionsStatus NodeToNodeEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the NodeToNodeEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetNodeToNodeEncryptionOptions() => this.NodeToNodeEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// Specifies the <c>SnapshotOptions</c> for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public SnapshotOptionsStatus SnapshotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOptions property is set.
        /// </summary>
        internal bool IsSetSnapshotOptions() => this.SnapshotOptions != null;

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
        /// The <c>VPCOptions</c> for the specified domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html"
        /// target="_blank">VPC Endpoints for Amazon Elasticsearch Service Domains</a>.
        /// </para>
        /// </summary>
        public VPCDerivedInfoStatus VPCOptions { get; set; }

        /// <summary>
        /// Checks to see if the VPCOptions property is set.
        /// </summary>
        internal bool IsSetVPCOptions() => this.VPCOptions != null;
    }
}
