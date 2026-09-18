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
    /// Information about an Amazon OpenSearch Service domain.
    /// </summary>
    public partial class AwsOpenSearchServiceDomainDetails
    {
        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM policy document that specifies the access policies for the OpenSearch Service
        /// domain.
        /// </para>
        /// </summary>
        public string AccessPolicies { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicies property is set.
        /// </summary>
        internal bool IsSetAccessPolicies() => this.AccessPolicies != null;

        /// <summary>
        /// Gets and sets the property AdvancedSecurityOptions. 
        /// <para>
        /// Specifies options for fine-grained access control. 
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetails AdvancedSecurityOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedSecurityOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedSecurityOptions() => this.AdvancedSecurityOptions != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the OpenSearch Service domain.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClusterConfig. 
        /// <para>
        /// Details about the configuration of an OpenSearch cluster.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainClusterConfigDetails ClusterConfig { get; set; }

        /// <summary>
        /// Checks to see if the ClusterConfig property is set.
        /// </summary>
        internal bool IsSetClusterConfig() => this.ClusterConfig != null;

        /// <summary>
        /// Gets and sets the property DomainEndpoint. 
        /// <para>
        /// The domain endpoint.
        /// </para>
        /// </summary>
        public string DomainEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpoint property is set.
        /// </summary>
        internal bool IsSetDomainEndpoint() => this.DomainEndpoint != null;

        /// <summary>
        /// Gets and sets the property DomainEndpointOptions. 
        /// <para>
        /// Additional options for the domain endpoint.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainDomainEndpointOptionsDetails DomainEndpointOptions { get; set; }

        /// <summary>
        /// Checks to see if the DomainEndpointOptions property is set.
        /// </summary>
        internal bool IsSetDomainEndpointOptions() => this.DomainEndpointOptions != null;

        /// <summary>
        /// Gets and sets the property DomainEndpoints. 
        /// <para>
        /// The domain endpoints. Used if the OpenSearch domain resides in a VPC.
        /// </para>
        ///  
        /// <para>
        /// This is a map of key-value pairs. The key is always <c>vpc</c>. The value is the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DomainEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DomainEndpoints property is set.
        /// </summary>
        internal bool IsSetDomainEndpoints() => this.DomainEndpoints != null && (this.DomainEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Details about the configuration for encryption at rest.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainEncryptionAtRestOptionsDetails EncryptionAtRestOptions { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRestOptions property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRestOptions() => this.EncryptionAtRestOptions != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the domain engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the domain.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Configures the CloudWatch Logs to publish for the OpenSearch domain.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainLogPublishingOptionsDetails LogPublishingOptions { get; set; }

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
        public AwsOpenSearchServiceDomainNodeToNodeEncryptionOptionsDetails NodeToNodeEncryptionOptions { get; set; }

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
        public AwsOpenSearchServiceDomainServiceSoftwareOptionsDetails ServiceSoftwareOptions { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSoftwareOptions property is set.
        /// </summary>
        internal bool IsSetServiceSoftwareOptions() => this.ServiceSoftwareOptions != null;

        /// <summary>
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Information that OpenSearch Service derives based on <c>VPCOptions</c> for the domain.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainVpcOptionsDetails VpcOptions { get; set; }

        /// <summary>
        /// Checks to see if the VpcOptions property is set.
        /// </summary>
        internal bool IsSetVpcOptions() => this.VpcOptions != null;
    }
}
