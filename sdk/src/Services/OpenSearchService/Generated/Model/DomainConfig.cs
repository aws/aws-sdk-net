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
    /// The configuration of a domain.
    /// </summary>
    public partial class DomainConfig
    {
        private AccessPoliciesStatus _accessPolicies;
        private AdvancedOptionsStatus _advancedOptions;
        private AdvancedSecurityOptionsStatus _advancedSecurityOptions;
        private AutoTuneOptionsStatus _autoTuneOptions;
        private ClusterConfigStatus _clusterConfig;
        private CognitoOptionsStatus _cognitoOptions;
        private DomainEndpointOptionsStatus _domainEndpointOptions;
        private EBSOptionsStatus _ebsOptions;
        private EncryptionAtRestOptionsStatus _encryptionAtRestOptions;
        private VersionStatus _engineVersion;
        private LogPublishingOptionsStatus _logPublishingOptions;
        private NodeToNodeEncryptionOptionsStatus _nodeToNodeEncryptionOptions;
        private SnapshotOptionsStatus _snapshotOptions;
        private VPCDerivedInfoStatus _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM access policy as a JSON-formatted string.
        /// </para>
        /// </summary>
        public AccessPoliciesStatus AccessPolicies
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
        /// The <code>AdvancedOptions</code> for the domain. See <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options"
        /// target="_blank">Advanced options </a> for more information. 
        /// </para>
        /// </summary>
        public AdvancedOptionsStatus AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null;
        }

        /// <summary>
        /// Gets and sets the property AdvancedSecurityOptions. 
        /// <para>
        /// Specifies <code>AdvancedSecurityOptions</code> for the domain. 
        /// </para>
        /// </summary>
        public AdvancedSecurityOptionsStatus AdvancedSecurityOptions
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
        /// Specifies <code>AutoTuneOptions</code> for the domain. 
        /// </para>
        /// </summary>
        public AutoTuneOptionsStatus AutoTuneOptions
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
        /// The <code>ClusterConfig</code> for the domain. 
        /// </para>
        /// </summary>
        public ClusterConfigStatus ClusterConfig
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
        /// The <code>CognitoOptions</code> for the specified domain. For more information, see
        /// <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/cognito-auth.html"
        /// target="_blank">Configuring Amazon Cognito authentication for OpenSearch Dashboards</a>.
        /// 
        /// </para>
        /// </summary>
        public CognitoOptionsStatus CognitoOptions
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
        /// The <code>DomainEndpointOptions</code> for the domain. 
        /// </para>
        /// </summary>
        public DomainEndpointOptionsStatus DomainEndpointOptions
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
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// The <code>EBSOptions</code> for the domain. 
        /// </para>
        /// </summary>
        public EBSOptionsStatus EBSOptions
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
        /// The <code>EncryptionAtRestOptions</code> for the domain. 
        /// </para>
        /// </summary>
        public EncryptionAtRestOptionsStatus EncryptionAtRestOptions
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// String of format Elasticsearch_X.Y or OpenSearch_X.Y to specify the engine version
        /// for the OpenSearch or Elasticsearch domain.
        /// </para>
        /// </summary>
        public VersionStatus EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Log publishing options for the given domain.
        /// </para>
        /// </summary>
        public LogPublishingOptionsStatus LogPublishingOptions
        {
            get { return this._logPublishingOptions; }
            set { this._logPublishingOptions = value; }
        }

        // Check to see if LogPublishingOptions property is set
        internal bool IsSetLogPublishingOptions()
        {
            return this._logPublishingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property NodeToNodeEncryptionOptions. 
        /// <para>
        /// The <code>NodeToNodeEncryptionOptions</code> for the domain. 
        /// </para>
        /// </summary>
        public NodeToNodeEncryptionOptionsStatus NodeToNodeEncryptionOptions
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
        /// The <code>SnapshotOptions</code> for the domain. 
        /// </para>
        /// </summary>
        public SnapshotOptionsStatus SnapshotOptions
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
        /// The <code>VPCOptions</code> for the specified domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html"
        /// target="_blank"> Launching your Amazon OpenSearch Service domains using a VPC</a>.
        /// 
        /// </para>
        /// </summary>
        public VPCDerivedInfoStatus VPCOptions
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