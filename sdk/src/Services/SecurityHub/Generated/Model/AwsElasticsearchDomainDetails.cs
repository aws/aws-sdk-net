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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Elasticsearch domain.
    /// </summary>
    public partial class AwsElasticsearchDomainDetails
    {
        private string _accessPolicies;
        private AwsElasticsearchDomainDomainEndpointOptions _domainEndpointOptions;
        private string _domainId;
        private string _domainName;
        private AwsElasticsearchDomainElasticsearchClusterConfigDetails _elasticsearchClusterConfig;
        private string _elasticsearchVersion;
        private AwsElasticsearchDomainEncryptionAtRestOptions _encryptionAtRestOptions;
        private string _endpoint;
        private Dictionary<string, string> _endpoints = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AwsElasticsearchDomainLogPublishingOptions _logPublishingOptions;
        private AwsElasticsearchDomainNodeToNodeEncryptionOptions _nodeToNodeEncryptionOptions;
        private AwsElasticsearchDomainServiceSoftwareOptions _serviceSoftwareOptions;
        private AwsElasticsearchDomainVPCOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM policy document specifying the access policies for the new Elasticsearch domain.
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
        /// Gets and sets the property DomainEndpointOptions. 
        /// <para>
        /// Additional options for the domain endpoint.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainDomainEndpointOptions DomainEndpointOptions
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
        /// Unique identifier for an Elasticsearch domain.
        /// </para>
        /// </summary>
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
        /// Name of an Elasticsearch domain.
        /// </para>
        ///  
        /// <para>
        /// Domain names are unique across all domains owned by the same account within an Amazon
        /// Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Domain names must start with a lowercase letter and must be between 3 and 28 characters.
        /// </para>
        ///  
        /// <para>
        /// Valid characters are a-z (lowercase only), 0-9, and – (hyphen). 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ElasticsearchClusterConfig. 
        /// <para>
        /// Information about an OpenSearch cluster configuration.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainElasticsearchClusterConfigDetails ElasticsearchClusterConfig
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
        /// OpenSearch version.
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
        /// Details about the configuration for encryption at rest.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainEncryptionAtRestOptions EncryptionAtRestOptions
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
        /// an Elasticsearch domain.
        /// </para>
        ///  
        /// <para>
        /// The endpoint is a service URL. 
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
        /// The key-value pair that exists if the Elasticsearch domain uses VPC endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Configures the CloudWatch Logs to publish for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainLogPublishingOptions LogPublishingOptions
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
        /// Details about the configuration for node-to-node encryption.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainNodeToNodeEncryptionOptions NodeToNodeEncryptionOptions
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
        /// Gets and sets the property ServiceSoftwareOptions. 
        /// <para>
        /// Information about the status of a domain relative to the latest service software.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainServiceSoftwareOptions ServiceSoftwareOptions
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
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// Information that OpenSearch derives based on <c>VPCOptions</c> for the domain.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainVPCOptions VPCOptions
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