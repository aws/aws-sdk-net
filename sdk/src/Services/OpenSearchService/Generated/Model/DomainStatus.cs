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
    /// The current status of a domain.
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
        private bool? _processing;
        private ServiceSoftwareOptions _serviceSoftwareOptions;
        private SnapshotOptions _snapshotOptions;
        private bool? _upgradeProcessing;
        private VPCDerivedInfo _vpcOptions;

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
        /// The status of the <code>AdvancedOptions</code>. 
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
        /// The current status of the domain's advanced security options.
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
        /// The Amazon Resource Name (ARN) of a domain. See <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html"
        /// target="_blank">IAM identifiers </a> in the <i>AWS Identity and Access Management
        /// User Guide</i> for more information. 
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
        /// The current status of the domain's Auto-Tune options.
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
        /// Specifies change details of the domain configuration change.
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
        /// The type and number of instances in the domain.
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
        /// The <code>CognitoOptions</code> for the specified domain. For more information, see
        /// <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/cognito-auth.html"
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
        /// Gets and sets the property Created. 
        /// <para>
        /// The domain creation status. <code>True</code> if the creation of a domain is complete.
        /// <code> False </code> if domain creation is still in progress. 
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
        /// The domain deletion status. <code>True</code> if a delete request has been received
        /// for the domain but resource cleanup is still in progress. <code>False</code> if the
        /// domain has not been deleted. Once domain deletion is complete, the status of the domain
        /// is no longer returned. 
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
        /// The current status of the domain's endpoint options.
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
        /// The unique identifier for the specified domain.
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
        /// The name of a domain. Domain names are unique across the domains owned by an account
        /// within an AWS region. Domain names start with a letter or number and can contain the
        /// following characters: a-z (lowercase), 0-9, and - (hyphen). 
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
        /// The <code>EBSOptions</code> for the specified domain. 
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
        /// The status of the <code>EncryptionAtRestOptions</code>. 
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
        /// The domain endpoint that you use to submit index and search requests.
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
        /// Map containing the domain endpoints used to submit index and search requests. Example
        /// <code>key, value</code>: <code>'vpc','vpc-endpoint-h2dsd34efgyghrtguk5gt6j2foh4.us-east-1.es.amazonaws.com'</code>.
        /// 
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
        /// Log publishing options for the given domain.
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
        /// The status of the <code>NodeToNodeEncryptionOptions</code>. 
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
        /// Gets and sets the property Processing. 
        /// <para>
        /// The status of the domain configuration. <code>True</code> if Amazon OpenSearch Service
        /// is processing configuration changes. <code>False</code> if the configuration is active.
        /// 
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
        /// The status of the <code>SnapshotOptions</code>. 
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
        /// Gets and sets the property UpgradeProcessing. 
        /// <para>
        /// The status of a domain version upgrade. <code>True</code> if Amazon OpenSearch Service
        /// is undergoing a version upgrade. <code>False</code> if the configuration is active.
        /// 
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
        /// The <code>VPCOptions</code> for the specified domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html"
        /// target="_blank"> Launching your Amazon OpenSearch Service domains using a VPC</a>.
        /// 
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