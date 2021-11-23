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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainConfig operation.
    /// Modifies the cluster configuration of the specified domain, such as setting the instance
    /// type and the number of instances.
    /// </summary>
    public partial class UpdateDomainConfigRequest : AmazonOpenSearchServiceRequest
    {
        private string _accessPolicies;
        private Dictionary<string, string> _advancedOptions = new Dictionary<string, string>();
        private AdvancedSecurityOptionsInput _advancedSecurityOptions;
        private AutoTuneOptions _autoTuneOptions;
        private ClusterConfig _clusterConfig;
        private CognitoOptions _cognitoOptions;
        private DomainEndpointOptions _domainEndpointOptions;
        private string _domainName;
        private bool? _dryRun;
        private EBSOptions _ebsOptions;
        private EncryptionAtRestOptions _encryptionAtRestOptions;
        private Dictionary<string, LogPublishingOption> _logPublishingOptions = new Dictionary<string, LogPublishingOption>();
        private NodeToNodeEncryptionOptions _nodeToNodeEncryptionOptions;
        private SnapshotOptions _snapshotOptions;
        private VPCOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM access policy as a JSON-formatted string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=102400)]
        public string AccessPolicies
        {
            get { return this._accessPolicies; }
            set { this._accessPolicies = value; }
        }

        // Check to see if AccessPolicies property is set
        internal bool IsSetAccessPolicies()
        {
            return this._accessPolicies != null;
        }

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Modifies the advanced option to allow references to indices in an HTTP request body.
        /// Must be <code>false</code> when configuring access to individual sub-resources. By
        /// default, the value is <code>true</code>. See <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options"
        /// target="_blank">Advanced options </a> for more information. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null && this._advancedOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AdvancedSecurityOptions. 
        /// <para>
        /// Specifies advanced security options.
        /// </para>
        /// </summary>
        public AdvancedSecurityOptionsInput AdvancedSecurityOptions
        {
            get { return this._advancedSecurityOptions; }
            set { this._advancedSecurityOptions = value; }
        }

        // Check to see if AdvancedSecurityOptions property is set
        internal bool IsSetAdvancedSecurityOptions()
        {
            return this._advancedSecurityOptions != null;
        }

        /// <summary>
        /// Gets and sets the property AutoTuneOptions. 
        /// <para>
        /// Specifies Auto-Tune options.
        /// </para>
        /// </summary>
        public AutoTuneOptions AutoTuneOptions
        {
            get { return this._autoTuneOptions; }
            set { this._autoTuneOptions = value; }
        }

        // Check to see if AutoTuneOptions property is set
        internal bool IsSetAutoTuneOptions()
        {
            return this._autoTuneOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterConfig. 
        /// <para>
        /// The type and number of instances to instantiate for the domain cluster.
        /// </para>
        /// </summary>
        public ClusterConfig ClusterConfig
        {
            get { return this._clusterConfig; }
            set { this._clusterConfig = value; }
        }

        // Check to see if ClusterConfig property is set
        internal bool IsSetClusterConfig()
        {
            return this._clusterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CognitoOptions. 
        /// <para>
        /// Options to specify the Cognito user and identity pools for OpenSearch Dashboards authentication.
        /// For more information, see <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/cognito-auth.html"
        /// target="_blank">Configuring Amazon Cognito authentication for OpenSearch Dashboards</a>.
        /// 
        /// </para>
        /// </summary>
        public CognitoOptions CognitoOptions
        {
            get { return this._cognitoOptions; }
            set { this._cognitoOptions = value; }
        }

        // Check to see if CognitoOptions property is set
        internal bool IsSetCognitoOptions()
        {
            return this._cognitoOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DomainEndpointOptions. 
        /// <para>
        /// Options to specify configuration that will be applied to the domain endpoint.
        /// </para>
        /// </summary>
        public DomainEndpointOptions DomainEndpointOptions
        {
            get { return this._domainEndpointOptions; }
            set { this._domainEndpointOptions = value; }
        }

        // Check to see if DomainEndpointOptions property is set
        internal bool IsSetDomainEndpointOptions()
        {
            return this._domainEndpointOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// This flag, when set to True, specifies whether the <code>UpdateDomain</code> request
        /// should return the results of validation checks (DryRunResults) without actually applying
        /// the change.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// Specify the type and size of the EBS volume to use.
        /// </para>
        /// </summary>
        public EBSOptions EBSOptions
        {
            get { return this._ebsOptions; }
            set { this._ebsOptions = value; }
        }

        // Check to see if EBSOptions property is set
        internal bool IsSetEBSOptions()
        {
            return this._ebsOptions != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Specifies encryption of data at rest options.
        /// </para>
        /// </summary>
        public EncryptionAtRestOptions EncryptionAtRestOptions
        {
            get { return this._encryptionAtRestOptions; }
            set { this._encryptionAtRestOptions = value; }
        }

        // Check to see if EncryptionAtRestOptions property is set
        internal bool IsSetEncryptionAtRestOptions()
        {
            return this._encryptionAtRestOptions != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Map of <code>LogType</code> and <code>LogPublishingOption</code>, each containing
        /// options to publish a given type of OpenSearch log. 
        /// </para>
        /// </summary>
        public Dictionary<string, LogPublishingOption> LogPublishingOptions
        {
            get { return this._logPublishingOptions; }
            set { this._logPublishingOptions = value; }
        }

        // Check to see if LogPublishingOptions property is set
        internal bool IsSetLogPublishingOptions()
        {
            return this._logPublishingOptions != null && this._logPublishingOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NodeToNodeEncryptionOptions. 
        /// <para>
        /// Specifies node-to-node encryption options.
        /// </para>
        /// </summary>
        public NodeToNodeEncryptionOptions NodeToNodeEncryptionOptions
        {
            get { return this._nodeToNodeEncryptionOptions; }
            set { this._nodeToNodeEncryptionOptions = value; }
        }

        // Check to see if NodeToNodeEncryptionOptions property is set
        internal bool IsSetNodeToNodeEncryptionOptions()
        {
            return this._nodeToNodeEncryptionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// Option to set the time, in UTC format, for the daily automated snapshot. Default value
        /// is <code>0</code> hours. 
        /// </para>
        /// </summary>
        public SnapshotOptions SnapshotOptions
        {
            get { return this._snapshotOptions; }
            set { this._snapshotOptions = value; }
        }

        // Check to see if SnapshotOptions property is set
        internal bool IsSetSnapshotOptions()
        {
            return this._snapshotOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// Options to specify the subnets and security groups for the VPC endpoint. For more
        /// information, see <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html"
        /// target="_blank">Launching your Amazon OpenSearch Service domains using a VPC </a>.
        /// 
        /// </para>
        /// </summary>
        public VPCOptions VPCOptions
        {
            get { return this._vpcOptions; }
            set { this._vpcOptions = value; }
        }

        // Check to see if VPCOptions property is set
        internal bool IsSetVPCOptions()
        {
            return this._vpcOptions != null;
        }

    }
}