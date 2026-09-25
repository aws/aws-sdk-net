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
    /// Container for the parameters to the UpdateDomainConfig operation. Modifies the cluster
    /// configuration of the specified Amazon OpenSearch Service domain.
    /// </summary>
    public partial class UpdateDomainConfigRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AIMLOptions. 
        /// <para>
        /// Options for all machine learning features for the specified domain.
        /// </para>
        /// </summary>
        public AIMLOptionsInput AIMLOptions { get; set; }

        /// <summary>
        /// Checks to see if the AIMLOptions property is set.
        /// </summary>
        internal bool IsSetAIMLOptions() => this.AIMLOptions != null;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// Identity and Access Management (IAM) access policy as a JSON-formatted string.
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
        /// Key-value pairs to specify advanced configuration options. The following key-value
        /// pairs are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"rest.action.multi.allow_explicit_index": "true" | "false"</c> - Note the use
        /// of a string rather than a boolean. Specifies whether explicit references to indexes
        /// are allowed inside the body of HTTP requests. If you want to configure access policies
        /// for domain sub-resources, such as specific indexes and domain APIs, you must disable
        /// this property. Default is true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"indices.fielddata.cache.size": "80" </c> - Note the use of a string rather than
        /// a boolean. Specifies the percentage of heap space allocated to field data. Default
        /// is unbounded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"indices.query.bool.max_clause_count": "1024"</c> - Note the use of a string rather
        /// than a boolean. Specifies the maximum number of clauses allowed in a Lucene boolean
        /// query. Default is 1,024. Queries with more than the permitted number of clauses result
        /// in a <c>TooManyClauses</c> error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options">Advanced
        /// cluster parameters</a>.
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
        /// Options for fine-grained access control.
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
        /// Options for Auto-Tune.
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
        /// Gets and sets the property ClusterConfig. 
        /// <para>
        /// Changes that you want to make to the cluster configuration, such as the instance type
        /// and number of EC2 instances.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeploymentStrategyOptions. 
        /// <para>
        /// Specifies the deployment strategy options for the domain.
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you're updating.
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
        /// This flag, when set to True, specifies whether the <c>UpdateDomain</c> request should
        /// return the results of a dry run analysis without actually applying the change. A dry
        /// run determines what type of deployment the update will cause.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property DryRunMode. 
        /// <para>
        /// The type of dry run to perform.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Basic</c> only returns the type of deployment (blue/green or dynamic) that the
        /// update will cause.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Verbose</c> runs an additional check to validate the changes you're making. For
        /// more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-configuration-changes#validation-check">Validating
        /// a domain update</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DryRunMode DryRunMode { get; set; }

        /// <summary>
        /// Checks to see if the DryRunMode property is set.
        /// </summary>
        internal bool IsSetDryRunMode() => this.DryRunMode != null;

        /// <summary>
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// The type and size of the EBS volume to attach to instances in the domain.
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
        /// Encryption at rest options for the domain.
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
        /// The engine mode for the domain. The engine mode can't be changed after the domain
        /// is created. For valid values, see <c>EngineMode</c>.
        /// </para>
        /// </summary>
        public EngineMode EngineMode { get; set; }

        /// <summary>
        /// Checks to see if the EngineMode property is set.
        /// </summary>
        internal bool IsSetEngineMode() => this.EngineMode != null;

        /// <summary>
        /// Gets and sets the property IPAddressType. 
        /// <para>
        /// Specify either dual stack or IPv4 as your IP address type. Dual stack allows you to
        /// share domain resources across IPv4 and IPv6 address types, and is the recommended
        /// option. If your IP address type is currently set to dual stack, you can't change it.
        /// 
        /// </para>
        /// </summary>
        public IPAddressType IPAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IPAddressType property is set.
        /// </summary>
        internal bool IsSetIPAddressType() => this.IPAddressType != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterOptions.
        /// </summary>
        public IdentityCenterOptionsInput IdentityCenterOptions { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterOptions property is set.
        /// </summary>
        internal bool IsSetIdentityCenterOptions() => this.IdentityCenterOptions != null;

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Options to publish OpenSearch logs to Amazon CloudWatch Logs.
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
        /// Node-to-node encryption options for the domain.
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
        /// Off-peak window options for the domain.
        /// </para>
        /// </summary>
        public OffPeakWindowOptions OffPeakWindowOptions { get; set; }

        /// <summary>
        /// Checks to see if the OffPeakWindowOptions property is set.
        /// </summary>
        internal bool IsSetOffPeakWindowOptions() => this.OffPeakWindowOptions != null;

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
        /// Options to specify the subnets and security groups for a VPC endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html">Launching
        /// your Amazon OpenSearch Service domains using a VPC</a>.
        /// </para>
        /// </summary>
        public VPCOptions VPCOptions { get; set; }

        /// <summary>
        /// Checks to see if the VPCOptions property is set.
        /// </summary>
        internal bool IsSetVPCOptions() => this.VPCOptions != null;
    }
}
