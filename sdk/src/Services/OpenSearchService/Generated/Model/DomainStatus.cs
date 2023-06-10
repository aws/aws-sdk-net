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
    /// The current status of an OpenSearch Service domain.
    /// </summary>
    public partial class DomainStatus
    {
        private string _accessPolicies;
        private Dictionary<string, string> _advancedOptions = new Dictionary<string, string>();
        private AdvancedSecurityOptions _advancedSecurityOptions;
        private string _arn;
        private AutoTuneOptionsOutput _autoTuneOptions;
        private ChangeProgressDetails _changeProgressDetails;
        private ClusterConfig _clusterConfig;
        private CognitoOptions _cognitoOptions;
        private bool? _created;
        private bool? _deleted;
        private DomainEndpointOptions _domainEndpointOptions;
        private string _domainId;
        private string _domainName;
        private EBSOptions _ebsOptions;
        private EncryptionAtRestOptions _encryptionAtRestOptions;
        private string _endpoint;
        private Dictionary<string, string> _endpoints = new Dictionary<string, string>();
        private string _engineVersion;
        private Dictionary<string, LogPublishingOption> _logPublishingOptions = new Dictionary<string, LogPublishingOption>();
        private NodeToNodeEncryptionOptions _nodeToNodeEncryptionOptions;
        private OffPeakWindowOptions _offPeakWindowOptions;
        private bool? _processing;
        private ServiceSoftwareOptions _serviceSoftwareOptions;
        private SnapshotOptions _snapshotOptions;
        private SoftwareUpdateOptions _softwareUpdateOptions;
        private bool? _upgradeProcessing;
        private VPCDerivedInfo _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// Identity and Access Management (IAM) policy document specifying the access policies
        /// for the domain.
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
        /// Key-value pairs that specify advanced configuration options.
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
        /// Settings for fine-grained access control.
        /// </para>
        /// </summary>
        public AdvancedSecurityOptions AdvancedSecurityOptions
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
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// identifiers </a> in the <i>AWS Identity and Access Management User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoTuneOptions. 
        /// <para>
        /// Auto-Tune settings for the domain.
        /// </para>
        /// </summary>
        public AutoTuneOptionsOutput AutoTuneOptions
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
        /// Information about a configuration change happening on the domain.
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
        /// Container for the cluster configuration of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Key-value pairs to configure Amazon Cognito authentication for OpenSearch Dashboards.
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
        /// Gets and sets the property Created. 
        /// <para>
        /// Creation status of an OpenSearch Service domain. True if domain creation is complete.
        /// False if domain creation is still in progress.
        /// </para>
        /// </summary>
        public bool Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Deletion status of an OpenSearch Service domain. True if domain deletion is complete.
        /// False if domain deletion is still in progress. Once deletion is complete, the status
        /// of the domain is no longer returned.
        /// </para>
        /// </summary>
        public bool Deleted
        {
            get { return this._deleted.GetValueOrDefault(); }
            set { this._deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this._deleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainEndpointOptions. 
        /// <para>
        /// Additional options for the domain endpoint, such as whether to require HTTPS for all
        /// traffic.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// Unique identifier for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the domain. Domain names are unique across all domains owned by the same account
        /// within an Amazon Web Services Region.
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
        /// Gets and sets the property EBSOptions. 
        /// <para>
        /// Container for EBS-based storage settings for the domain.
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
        /// Encryption at rest settings for the domain.
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
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Domain-specific endpoint used to submit index, search, and data upload requests to
        /// the domain.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The key-value pair that exists if the OpenSearch Service domain uses VPC endpoints..
        /// Example <code>key, value</code>: <code>'vpc','vpc-endpoint-h2dsd34efgyghrtguk5gt6j2foh4.us-east-1.es.amazonaws.com'</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && this._endpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Version of OpenSearch or Elasticsearch that the domain is running, in the format <code>Elasticsearch_X.Y</code>
        /// or <code>OpenSearch_X.Y</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=18)]
        public string EngineVersion
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
        /// Log publishing options for the domain.
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
        /// Whether node-to-node encryption is enabled or disabled.
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
        /// Gets and sets the property OffPeakWindowOptions. 
        /// <para>
        /// Options that specify a custom 10-hour window during which OpenSearch Service can perform
        /// configuration changes on the domain.
        /// </para>
        /// </summary>
        public OffPeakWindowOptions OffPeakWindowOptions
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
        /// Gets and sets the property Processing. 
        /// <para>
        /// The status of the domain configuration. True if OpenSearch Service is processing configuration
        /// changes. False if the configuration is active.
        /// </para>
        /// </summary>
        public bool Processing
        {
            get { return this._processing.GetValueOrDefault(); }
            set { this._processing = value; }
        }

        // Check to see if Processing property is set
        internal bool IsSetProcessing()
        {
            return this._processing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceSoftwareOptions. 
        /// <para>
        /// The current status of the domain's service software.
        /// </para>
        /// </summary>
        public ServiceSoftwareOptions ServiceSoftwareOptions
        {
            get { return this._serviceSoftwareOptions; }
            set { this._serviceSoftwareOptions = value; }
        }

        // Check to see if ServiceSoftwareOptions property is set
        internal bool IsSetServiceSoftwareOptions()
        {
            return this._serviceSoftwareOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// DEPRECATED. Container for parameters required to configure automated snapshots of
        /// domain indexes.
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
        /// Gets and sets the property SoftwareUpdateOptions. 
        /// <para>
        /// Service software update options for the domain.
        /// </para>
        /// </summary>
        public SoftwareUpdateOptions SoftwareUpdateOptions
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
        /// Gets and sets the property UpgradeProcessing. 
        /// <para>
        /// The status of a domain version upgrade to a new version of OpenSearch or Elasticsearch.
        /// True if OpenSearch Service is in the process of a version upgrade. False if the configuration
        /// is active.
        /// </para>
        /// </summary>
        public bool UpgradeProcessing
        {
            get { return this._upgradeProcessing.GetValueOrDefault(); }
            set { this._upgradeProcessing = value; }
        }

        // Check to see if UpgradeProcessing property is set
        internal bool IsSetUpgradeProcessing()
        {
            return this._upgradeProcessing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// The VPC configuration for the domain.
        /// </para>
        /// </summary>
        public VPCDerivedInfo VPCOptions
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