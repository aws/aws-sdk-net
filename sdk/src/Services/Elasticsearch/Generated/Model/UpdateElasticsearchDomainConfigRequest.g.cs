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
    /// Container for the parameters to the UpdateElasticsearchDomainConfig operation. Modifies
    /// the cluster configuration of the specified Elasticsearch domain, setting as setting
    /// the instance type and the number of instances.
    /// </summary>
    public partial class UpdateElasticsearchDomainConfigRequest : AmazonElasticsearchRequest
    {
        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM access policy as a JSON-formatted string.
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
        /// Modifies the advanced option to allow references to indices in an HTTP request body.
        /// Must be <c>false</c> when configuring access to individual sub-resources. By default,
        /// the value is <c>true</c>. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-advanced-options"
        /// target="_blank">Configuration Advanced Options</a> for more information.
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
        /// Specifies advanced security options.
        /// </para>
        /// </summary>
        public AdvancedSecurityOptionsInput AdvancedSecurityOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedSecurityOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedSecurityOptions() => this.AdvancedSecurityOptions != null;

        /// <summary>
        /// Gets and sets the property AutoTuneOptions. 
        /// <para>
        /// Specifies Auto-Tune options.
        /// </para>
        /// </summary>
        public AutoTuneOptions AutoTuneOptions { get; set; }

        /// <summary>
        /// Checks to see if the AutoTuneOptions property is set.
        /// </summary>
        internal bool IsSetAutoTuneOptions() => this.AutoTuneOptions != null;

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotPauseOptions. 
        /// <para>
        /// Specifies the automated snapshot pause options for the domain.
        /// </para>
        ///  <important> 
        /// <para>
        /// Suspending snapshots reduces data protection. You cannot restore your domain to points
        /// in time when snapshots are suspended. Use this feature only for short-term operational
        /// needs such as migrations or maintenance windows.
        /// </para>
        ///  </important> 
        /// <para>
        /// Maximum suspension duration: 3 days.
        /// </para>
        /// </summary>
        public AutomatedSnapshotPauseRequestOptions AutomatedSnapshotPauseOptions { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedSnapshotPauseOptions property is set.
        /// </summary>
        internal bool IsSetAutomatedSnapshotPauseOptions() => this.AutomatedSnapshotPauseOptions != null;

        /// <summary>
        /// Gets and sets the property CognitoOptions. 
        /// <para>
        /// Options to specify the Cognito user and identity pools for Kibana authentication.
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-cognito-auth.html"
        /// target="_blank">Amazon Cognito Authentication for Kibana</a>.
        /// </para>
        /// </summary>
        public CognitoOptions CognitoOptions { get; set; }

        /// <summary>
        /// Checks to see if the CognitoOptions property is set.
        /// </summary>
        internal bool IsSetCognitoOptions() => this.CognitoOptions != null;

        /// <summary>
        /// Gets and sets the property DeploymentStrategyOptions. 
        /// <para>
        /// Specifies the deployment strategy options.
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
        /// Options to specify configuration that will be applied to the domain endpoint.
        /// </para>
        /// </summary>
        public DomainEndpointOptions DomainEndpointOptions { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpointOptions property is set.
        /// </summary>
        internal bool IsSetDomainEndpointOptions() => this.DomainEndpointOptions != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the Elasticsearch domain that you are updating. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        ///  This flag, when set to True, specifies whether the <c>UpdateElasticsearchDomain</c>
        /// request should return the results of validation checks without actually applying the
        /// change. This flag, when set to True, specifies the deployment mechanism through which
        /// the update shall be applied on the domain. This will not actually perform the Update.
        /// 
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// Specify the type and size of the EBS volume that you want to use. 
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
        /// The type and number of instances to instantiate for the domain cluster.
        /// </para>
        /// </summary>
        public ElasticsearchClusterConfig ElasticsearchClusterConfig { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchClusterConfig property is set.
        /// </summary>
        internal bool IsSetElasticsearchClusterConfig() => this.ElasticsearchClusterConfig != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Specifies the Encryption At Rest Options.
        /// </para>
        /// </summary>
        public EncryptionAtRestOptions EncryptionAtRestOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRestOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRestOptions() => this.EncryptionAtRestOptions != null;

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The engine mode for the domain. For valid values and requirements, see <c>DomainEngineMode</c>.
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
        /// Map of <c>LogType</c> and <c>LogPublishingOption</c>, each containing options to publish
        /// a given type of Elasticsearch log.
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
        /// Gets and sets the property NodeToNodeEncryptionOptions. 
        /// <para>
        /// Specifies the NodeToNodeEncryptionOptions.
        /// </para>
        /// </summary>
        public NodeToNodeEncryptionOptions NodeToNodeEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the NodeToNodeEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetNodeToNodeEncryptionOptions() => this.NodeToNodeEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// Option to set the time, in UTC format, for the daily automated snapshot. Default value
        /// is <c>0</c> hours. 
        /// </para>
        /// </summary>
        public SnapshotOptions SnapshotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOptions property is set.
        /// </summary>
        internal bool IsSetSnapshotOptions() => this.SnapshotOptions != null;

        /// <summary>
        /// Gets and sets the property UseCase. 
        /// <para>
        /// The primary use case for the domain. For valid values, see <c>DomainUseCase</c>.
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
        /// Options to specify the subnets and security groups for VPC endpoint. For more information,
        /// see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html#es-creating-vpc"
        /// target="_blank">Creating a VPC</a> in <i>VPC Endpoints for Amazon Elasticsearch Service
        /// Domains</i>
        /// </para>
        /// </summary>
        public VPCOptions VPCOptions { get; set; }

        /// <summary>
        /// Checks to see if the VPCOptions property is set.
        /// </summary>
        internal bool IsSetVPCOptions() => this.VPCOptions != null;
    }
}
