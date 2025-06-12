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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
    /// Container for the parameters to the CreateElasticsearchDomain operation.
    /// Creates a new Elasticsearch domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
    /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
    /// Service Developer Guide</i>.
    /// </summary>
    public partial class CreateElasticsearchDomainRequest : AmazonElasticsearchRequest
    {
        private string _accessPolicies;
        private Dictionary<string, string> _advancedOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AdvancedSecurityOptionsInput _advancedSecurityOptions;
        private AutoTuneOptionsInput _autoTuneOptions;
        private CognitoOptions _cognitoOptions;
        private DomainEndpointOptions _domainEndpointOptions;
        private string _domainName;
        private EBSOptions _ebsOptions;
        private ElasticsearchClusterConfig _elasticsearchClusterConfig;
        private string _elasticsearchVersion;
        private EncryptionAtRestOptions _encryptionAtRestOptions;
        private Dictionary<string, LogPublishingOption> _logPublishingOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, LogPublishingOption>() : null;
        private NodeToNodeEncryptionOptions _nodeToNodeEncryptionOptions;
        private SnapshotOptions _snapshotOptions;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private VPCOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        ///  IAM access policy as a JSON-formatted string.
        /// </para>
        /// </summary>
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
        ///  Option to allow references to indices in an HTTP request body. Must be <c>false</c>
        /// when configuring access to individual sub-resources. By default, the value is <c>true</c>.
        /// See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-advanced-options"
        /// target="_blank">Configuration Advanced Options</a> for more information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null && (this._advancedOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property CognitoOptions. 
        /// <para>
        /// Options to specify the Cognito user and identity pools for Kibana authentication.
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-cognito-auth.html"
        /// target="_blank">Amazon Cognito Authentication for Kibana</a>.
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
        /// The name of the Elasticsearch domain that you are creating. Domain names are unique
        /// across the domains owned by an account within an AWS region. Domain names must start
        /// with a lowercase letter and can contain the following characters: a-z (lowercase),
        /// 0-9, and - (hyphen).
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
        /// Options to enable, disable and specify the type and size of EBS storage volumes. 
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
        /// Gets and sets the property ElasticsearchClusterConfig. 
        /// <para>
        /// Configuration options for an Elasticsearch domain. Specifies the instance type and
        /// number of instances in the domain cluster. 
        /// </para>
        /// </summary>
        public ElasticsearchClusterConfig ElasticsearchClusterConfig
        {
            get { return this._elasticsearchClusterConfig; }
            set { this._elasticsearchClusterConfig = value; }
        }

        // Check to see if ElasticsearchClusterConfig property is set
        internal bool IsSetElasticsearchClusterConfig()
        {
            return this._elasticsearchClusterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchVersion. 
        /// <para>
        /// String of format X.Y to specify version for the Elasticsearch domain eg. "1.5" or
        /// "2.3". For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
        /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
        /// Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ElasticsearchVersion
        {
            get { return this._elasticsearchVersion; }
            set { this._elasticsearchVersion = value; }
        }

        // Check to see if ElasticsearchVersion property is set
        internal bool IsSetElasticsearchVersion()
        {
            return this._elasticsearchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Specifies the Encryption At Rest Options.
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
        /// Map of <c>LogType</c> and <c>LogPublishingOption</c>, each containing options to publish
        /// a given type of Elasticsearch log.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, LogPublishingOption> LogPublishingOptions
        {
            get { return this._logPublishingOptions; }
            set { this._logPublishingOptions = value; }
        }

        // Check to see if LogPublishingOptions property is set
        internal bool IsSetLogPublishingOptions()
        {
            return this._logPublishingOptions != null && (this._logPublishingOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeToNodeEncryptionOptions. 
        /// <para>
        /// Specifies the NodeToNodeEncryptionOptions.
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
        /// Option to set time, in UTC format, of the daily automated snapshot. Default value
        /// is 0 hours. 
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
        /// Gets and sets the property TagList. 
        /// <para>
        /// A list of <c>Tag</c> added during domain creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// Options to specify the subnets and security groups for VPC endpoint. For more information,
        /// see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html#es-creating-vpc"
        /// target="_blank">Creating a VPC</a> in <i>VPC Endpoints for Amazon Elasticsearch Service
        /// Domains</i>
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