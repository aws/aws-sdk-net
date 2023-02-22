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
    /// Container for the parameters to the CreateDomain operation.
    /// Creates an Amazon OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html">Creating
    /// and managing Amazon OpenSearch Service domains</a>.
    /// </summary>
    public partial class CreateDomainRequest : AmazonOpenSearchServiceRequest
    {
        private string _accessPolicies;
        private Dictionary<string, string> _advancedOptions = new Dictionary<string, string>();
        private AdvancedSecurityOptionsInput _advancedSecurityOptions;
        private AutoTuneOptionsInput _autoTuneOptions;
        private ClusterConfig _clusterConfig;
        private CognitoOptions _cognitoOptions;
        private DomainEndpointOptions _domainEndpointOptions;
        private string _domainName;
        private EBSOptions _ebsOptions;
        private EncryptionAtRestOptions _encryptionAtRestOptions;
        private string _engineVersion;
        private Dictionary<string, LogPublishingOption> _logPublishingOptions = new Dictionary<string, LogPublishingOption>();
        private NodeToNodeEncryptionOptions _nodeToNodeEncryptionOptions;
        private OffPeakWindowOptions _offPeakWindowOptions;
        private SnapshotOptions _snapshotOptions;
        private SoftwareUpdateOptions _softwareUpdateOptions;
        private List<Tag> _tagList = new List<Tag>();
        private VPCOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// Identity and Access Management (IAM) policy document specifying the access policies
        /// for the new domain.
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
        /// Key-value pairs to specify advanced configuration options. The following key-value
        /// pairs are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>"rest.action.multi.allow_explicit_index": "true" | "false"</code> - Note the
        /// use of a string rather than a boolean. Specifies whether explicit references to indexes
        /// are allowed inside the body of HTTP requests. If you want to configure access policies
        /// for domain sub-resources, such as specific indexes and domain APIs, you must disable
        /// this property. Default is true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"indices.fielddata.cache.size": "80" </code> - Note the use of a string rather
        /// than a boolean. Specifies the percentage of heap space allocated to field data. Default
        /// is unbounded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"indices.query.bool.max_clause_count": "1024"</code> - Note the use of a string
        /// rather than a boolean. Specifies the maximum number of clauses allowed in a Lucene
        /// boolean query. Default is 1,024. Queries with more than the permitted number of clauses
        /// result in a <code>TooManyClauses</code> error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"override_main_response_version": "true" | "false"</code> - Note the use of
        /// a string rather than a boolean. Specifies whether the domain reports its version as
        /// 7.10 to allow Elasticsearch OSS clients and plugins to continue working with it. Default
        /// is false when creating a domain and true when upgrading a domain.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options">Advanced
        /// cluster parameters</a>.
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
        /// Options for fine-grained access control.
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
        /// Options for Auto-Tune.
        /// </para>
        /// </summary>
        public AutoTuneOptionsInput AutoTuneOptions
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
        /// Container for the cluster configuration of a domain.
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
        /// Key-value pairs to configure Amazon Cognito authentication. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cognito-auth.html">Configuring
        /// Amazon Cognito authentication for OpenSearch Dashboards</a>.
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the OpenSearch Service domain to create. Domain names are unique across the
        /// domains owned by an account within an Amazon Web Services Region.
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
        /// Container for the parameters required to enable EBS-based storage for an OpenSearch
        /// Service domain.
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
        /// Key-value pairs to enable encryption at rest.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// String of format Elasticsearch_X.Y or OpenSearch_X.Y to specify the engine version
        /// for the OpenSearch Service domain. For example, <code>OpenSearch_1.0</code> or <code>Elasticsearch_7.9</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomains">Creating
        /// and managing Amazon OpenSearch Service domains</a>.
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
        /// Key-value pairs to configure slow log publishing.
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
        /// Enables node-to-node encryption.
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
        /// Specifies a daily 10-hour time block during which OpenSearch Service can perform configuration
        /// changes on the domain, including service software updates and Auto-Tune enhancements
        /// that require a blue/green deployment. If no options are specified, the default start
        /// time of 10:00 P.M. local time (for the Region that the domain is created in) is used.
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
        /// Gets and sets the property SnapshotOptions. 
        /// <para>
        /// DEPRECATED. Container for the parameters required to configure automated snapshots
        /// of domain indexes.
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
        /// Software update options for the domain.
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
        /// Gets and sets the property TagList. 
        /// <para>
        /// List of tags to add to the domain upon creation.
        /// </para>
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// Container for the values required to configure VPC access domains. If you don't specify
        /// these values, OpenSearch Service creates the domain with a public endpoint. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html">Launching
        /// your Amazon OpenSearch Service domains using a VPC</a>.
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