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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the configuration of an OpenSearch Service domain.
    /// </summary>
    public partial class DomainConfig
    {
        private AccessPoliciesStatus _accessPolicies;
        private AdvancedOptionsStatus _advancedOptions;
        private AdvancedSecurityOptionsStatus _advancedSecurityOptions;
        private AIMLOptionsStatus _aimlOptions;
        private AutoTuneOptionsStatus _autoTuneOptions;
        private ChangeProgressDetails _changeProgressDetails;
        private ClusterConfigStatus _clusterConfig;
        private CognitoOptionsStatus _cognitoOptions;
        private DomainEndpointOptionsStatus _domainEndpointOptions;
        private EBSOptionsStatus _ebsOptions;
        private EncryptionAtRestOptionsStatus _encryptionAtRestOptions;
        private VersionStatus _engineVersion;
        private IdentityCenterOptionsStatus _identityCenterOptions;
        private IPAddressTypeStatus _ipAddressType;
        private LogPublishingOptionsStatus _logPublishingOptions;
        private List<ModifyingProperties> _modifyingProperties = AWSConfigs.InitializeCollections ? new List<ModifyingProperties>() : null;
        private NodeToNodeEncryptionOptionsStatus _nodeToNodeEncryptionOptions;
        private OffPeakWindowOptionsStatus _offPeakWindowOptions;
        private SnapshotOptionsStatus _snapshotOptions;
        private SoftwareUpdateOptionsStatus _softwareUpdateOptions;
        private VPCDerivedInfoStatus _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// Specifies the access policies for the domain.
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
        /// Key-value pairs to specify advanced configuration options. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options">Advanced
        /// options</a>.
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
        /// Container for fine-grained access control settings for the domain.
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
        /// Gets and sets the property AIMLOptions. 
        /// <para>
        /// Container for parameters required to enable all machine learning features.
        /// </para>
        /// </summary>
        public AIMLOptionsStatus AIMLOptions
        {
            get { return this._aimlOptions; }
            set { this._aimlOptions = value; }
        }

        // Check to see if AIMLOptions property is set
        internal bool IsSetAIMLOptions()
        {
            return this._aimlOptions != null;
        }

        /// <summary>
        /// Gets and sets the property AutoTuneOptions. 
        /// <para>
        /// Container for Auto-Tune settings for the domain.
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
        /// Gets and sets the property ChangeProgressDetails. 
        /// <para>
        /// Container for information about the progress of an existing configuration change.
        /// </para>
        /// </summary>
        public ChangeProgressDetails ChangeProgressDetails
        {
            get { return this._changeProgressDetails; }
            set { this._changeProgressDetails = value; }
        }

        // Check to see if ChangeProgressDetails property is set
        internal bool IsSetChangeProgressDetails()
        {
            return this._changeProgressDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterConfig. 
        /// <para>
        /// Container for the cluster configuration of a the domain.
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
        /// Container for Amazon Cognito options for the domain.
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
        /// Additional options for the domain endpoint, such as whether to require HTTPS for all
        /// traffic.
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
        /// Container for EBS options configured for the domain.
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
        /// Key-value pairs to enable encryption at rest.
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
        /// The OpenSearch or Elasticsearch version that the domain is running.
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
        /// Gets and sets the property IdentityCenterOptions. 
        /// <para>
        /// Configuration options for enabling and managing IAM Identity Center integration within
        /// a domain.
        /// </para>
        /// </summary>
        public IdentityCenterOptionsStatus IdentityCenterOptions
        {
            get { return this._identityCenterOptions; }
            set { this._identityCenterOptions = value; }
        }

        // Check to see if IdentityCenterOptions property is set
        internal bool IsSetIdentityCenterOptions()
        {
            return this._identityCenterOptions != null;
        }

        /// <summary>
        /// Gets and sets the property IPAddressType. 
        /// <para>
        /// Choose either dual stack or IPv4 as your IP address type. Dual stack allows you to
        /// share domain resources across IPv4 and IPv6 address types, and is the recommended
        /// option. If you set your IP address type to dual stack, you can't change your address
        /// type later.
        /// </para>
        /// </summary>
        public IPAddressTypeStatus IPAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IPAddressType property is set
        internal bool IsSetIPAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Key-value pairs to configure log publishing.
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
        /// Gets and sets the property ModifyingProperties. 
        /// <para>
        /// Information about the domain properties that are currently being modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModifyingProperties> ModifyingProperties
        {
            get { return this._modifyingProperties; }
            set { this._modifyingProperties = value; }
        }

        // Check to see if ModifyingProperties property is set
        internal bool IsSetModifyingProperties()
        {
            return this._modifyingProperties != null && (this._modifyingProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeToNodeEncryptionOptions. 
        /// <para>
        /// Whether node-to-node encryption is enabled or disabled.
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
        /// Gets and sets the property OffPeakWindowOptions. 
        /// <para>
        /// Container for off-peak window options for the domain.
        /// </para>
        /// </summary>
        public OffPeakWindowOptionsStatus OffPeakWindowOptions
        {
            get { return this._offPeakWindowOptions; }
            set { this._offPeakWindowOptions = value; }
        }

        // Check to see if OffPeakWindowOptions property is set
        internal bool IsSetOffPeakWindowOptions()
        {
            return this._offPeakWindowOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// DEPRECATED. Container for parameters required to configure automated snapshots of
        /// domain indexes.
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
        /// Gets and sets the property SoftwareUpdateOptions. 
        /// <para>
        /// Software update options for the domain.
        /// </para>
        /// </summary>
        public SoftwareUpdateOptionsStatus SoftwareUpdateOptions
        {
            get { return this._softwareUpdateOptions; }
            set { this._softwareUpdateOptions = value; }
        }

        // Check to see if SoftwareUpdateOptions property is set
        internal bool IsSetSoftwareUpdateOptions()
        {
            return this._softwareUpdateOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// The current VPC options for the domain and the status of any updates to their configuration.
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