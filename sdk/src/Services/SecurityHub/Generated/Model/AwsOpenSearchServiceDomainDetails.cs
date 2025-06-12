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
    /// Information about an Amazon OpenSearch Service domain.
    /// </summary>
    public partial class AwsOpenSearchServiceDomainDetails
    {
        private string _accessPolicies;
        private AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetails _advancedSecurityOptions;
        private string _arn;
        private AwsOpenSearchServiceDomainClusterConfigDetails _clusterConfig;
        private string _domainEndpoint;
        private AwsOpenSearchServiceDomainDomainEndpointOptionsDetails _domainEndpointOptions;
        private Dictionary<string, string> _domainEndpoints = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _domainName;
        private AwsOpenSearchServiceDomainEncryptionAtRestOptionsDetails _encryptionAtRestOptions;
        private string _engineVersion;
        private string _id;
        private AwsOpenSearchServiceDomainLogPublishingOptionsDetails _logPublishingOptions;
        private AwsOpenSearchServiceDomainNodeToNodeEncryptionOptionsDetails _nodeToNodeEncryptionOptions;
        private AwsOpenSearchServiceDomainServiceSoftwareOptionsDetails _serviceSoftwareOptions;
        private AwsOpenSearchServiceDomainVpcOptionsDetails _vpcOptions;

        /// <summary>
        /// Gets and sets the property AccessPolicies. 
        /// <para>
        /// IAM policy document that specifies the access policies for the OpenSearch Service
        /// domain.
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
        /// Gets and sets the property AdvancedSecurityOptions. 
        /// <para>
        /// Specifies options for fine-grained access control. 
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetails AdvancedSecurityOptions
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the OpenSearch Service domain.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterConfig. 
        /// <para>
        /// Details about the configuration of an OpenSearch cluster.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainClusterConfigDetails ClusterConfig
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
        /// Gets and sets the property DomainEndpoint. 
        /// <para>
        /// The domain endpoint.
        /// </para>
        /// </summary>
        public string DomainEndpoint
        {
            get { return this._domainEndpoint; }
            set { this._domainEndpoint = value; }
        }

        // Check to see if DomainEndpoint property is set
        internal bool IsSetDomainEndpoint()
        {
            return this._domainEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property DomainEndpointOptions. 
        /// <para>
        /// Additional options for the domain endpoint.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainDomainEndpointOptionsDetails DomainEndpointOptions
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
        /// Gets and sets the property DomainEndpoints. 
        /// <para>
        /// The domain endpoints. Used if the OpenSearch domain resides in a VPC.
        /// </para>
        ///  
        /// <para>
        /// This is a map of key-value pairs. The key is always <c>vpc</c>. The value is the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DomainEndpoints
        {
            get { return this._domainEndpoints; }
            set { this._domainEndpoints = value; }
        }

        // Check to see if DomainEndpoints property is set
        internal bool IsSetDomainEndpoints()
        {
            return this._domainEndpoints != null && (this._domainEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the endpoint.
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
        /// Gets and sets the property EncryptionAtRestOptions. 
        /// <para>
        /// Details about the configuration for encryption at rest.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainEncryptionAtRestOptionsDetails EncryptionAtRestOptions
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
        /// The version of the domain engine.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the domain.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Configures the CloudWatch Logs to publish for the OpenSearch domain.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainLogPublishingOptionsDetails LogPublishingOptions
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
        public AwsOpenSearchServiceDomainNodeToNodeEncryptionOptionsDetails NodeToNodeEncryptionOptions
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
        public AwsOpenSearchServiceDomainServiceSoftwareOptionsDetails ServiceSoftwareOptions
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
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Information that OpenSearch Service derives based on <c>VPCOptions</c> for the domain.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainVpcOptionsDetails VpcOptions
        {
            get { return this._vpcOptions; }
            set { this._vpcOptions = value; }
        }

        // Check to see if VpcOptions property is set
        internal bool IsSetVpcOptions()
        {
            return this._vpcOptions != null;
        }

    }
}