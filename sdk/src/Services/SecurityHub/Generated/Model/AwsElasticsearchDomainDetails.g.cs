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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Elasticsearch domain.
    /// </summary>
    public partial class AwsElasticsearchDomainDetails
    {
        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM policy document specifying the access policies for the new Elasticsearch domain.
        /// </para>
        /// </summary>
        public string AccessPolicies { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicies property is set.
        /// </summary>
        internal bool IsSetAccessPolicies() => this.AccessPolicies != null;

        /// <summary>
        /// Gets and sets the property DomainEndpointOptions. 
        /// <para>
        /// Additional options for the domain endpoint.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainDomainEndpointOptions DomainEndpointOptions { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpointOptions property is set.
        /// </summary>
        internal bool IsSetDomainEndpointOptions() => this.DomainEndpointOptions != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// Unique identifier for an Elasticsearch domain.
        /// </para>
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

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
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchClusterConfig. 
        /// <para>
        /// Information about an OpenSearch cluster configuration.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainElasticsearchClusterConfigDetails ElasticsearchClusterConfig { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchClusterConfig property is set.
        /// </summary>
        internal bool IsSetElasticsearchClusterConfig() => this.ElasticsearchClusterConfig != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchVersion. 
        /// <para>
        /// OpenSearch version.
        /// </para>
        /// </summary>
        public string ElasticsearchVersion { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchVersion property is set.
        /// </summary>
        internal bool IsSetElasticsearchVersion() => this.ElasticsearchVersion != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Details about the configuration for encryption at rest.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainEncryptionAtRestOptions EncryptionAtRestOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRestOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRestOptions() => this.EncryptionAtRestOptions != null;

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
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The key-value pair that exists if the Elasticsearch domain uses VPC endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Configures the CloudWatch Logs to publish for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainLogPublishingOptions LogPublishingOptions { get; set; }

        /// <summary>
        /// Checks to see if the LogPublishingOptions property is set.
        /// </summary>
        internal bool IsSetLogPublishingOptions() => this.LogPublishingOptions != null;

        /// <summary>
        /// Gets and sets the property NodeToNodeEncryptionOptions. 
        /// <para>
        /// Details about the configuration for node-to-node encryption.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainNodeToNodeEncryptionOptions NodeToNodeEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the NodeToNodeEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetNodeToNodeEncryptionOptions() => this.NodeToNodeEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property ServiceSoftwareOptions. 
        /// <para>
        /// Information about the status of a domain relative to the latest service software.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainServiceSoftwareOptions ServiceSoftwareOptions { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSoftwareOptions property is set.
        /// </summary>
        internal bool IsSetServiceSoftwareOptions() => this.ServiceSoftwareOptions != null;

        /// <summary>
        /// Gets and sets the property VPCOptions. 
        /// <para>
        /// Information that OpenSearch derives based on <c>VPCOptions</c> for the domain.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainVPCOptions VPCOptions { get; set; }

        /// <summary>
        /// Checks to see if the VPCOptions property is set.
        /// </summary>
        internal bool IsSetVPCOptions() => this.VPCOptions != null;
    }
}
