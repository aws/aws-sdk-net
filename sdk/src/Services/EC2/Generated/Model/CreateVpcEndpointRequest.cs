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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcEndpoint operation.
    /// Creates a VPC endpoint. A VPC endpoint provides a private connection between the specified
    /// VPC and the specified endpoint service. You can use an endpoint service provided by
    /// Amazon Web Services, an Amazon Web Services Marketplace Partner, or another Amazon
    /// Web Services account. For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/">Amazon
    /// Web Services PrivateLink User Guide</a>.
    /// </summary>
    public partial class CreateVpcEndpointRequest : AmazonEC2Request
    {
        private string _clientToken;
        private DnsOptionsSpecification _dnsOptions;
        private bool? _dryRun;
        private IpAddressType _ipAddressType;
        private string _policyDocument;
        private bool? _privateDnsEnabled;
        private string _resourceConfigurationArn;
        private List<string> _routeTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceName;
        private string _serviceNetworkArn;
        private string _serviceRegion;
        private List<SubnetConfiguration> _subnetConfigurations = AWSConfigs.InitializeCollections ? new List<SubnetConfiguration>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private VpcEndpointType _vpcEndpointType;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DnsOptions. 
        /// <para>
        /// The DNS options for the endpoint.
        /// </para>
        /// </summary>
        public DnsOptionsSpecification DnsOptions
        {
            get { return this._dnsOptions; }
            set { this._dnsOptions = value; }
        }

        // Check to see if DnsOptions property is set
        internal bool IsSetDnsOptions()
        {
            return this._dnsOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the endpoint.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// (Interface and gateway endpoints) A policy to attach to the endpoint that controls
        /// access to the service. The policy must be in valid JSON format. If this parameter
        /// is not specified, we attach a default policy that allows full access to the service.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsEnabled. 
        /// <para>
        /// (Interface endpoint) Indicates whether to associate a private hosted zone with the
        /// specified VPC. The private hosted zone contains a record set for the default public
        /// DNS name for the service for the Region (for example, <c>kinesis.us-east-1.amazonaws.com</c>),
        /// which resolves to the private IP addresses of the endpoint network interfaces in the
        /// VPC. This enables you to make requests to the default public DNS name for the service
        /// instead of the public DNS names that are automatically generated by the VPC endpoint
        /// service.
        /// </para>
        ///  
        /// <para>
        /// To use a private hosted zone, you must set the following VPC attributes to <c>true</c>:
        /// <c>enableDnsHostnames</c> and <c>enableDnsSupport</c>. Use <a>ModifyVpcAttribute</a>
        /// to set the VPC attributes.
        /// </para>
        /// </summary>
        public bool? PrivateDnsEnabled
        {
            get { return this._privateDnsEnabled; }
            set { this._privateDnsEnabled = value; }
        }

        // Check to see if PrivateDnsEnabled property is set
        internal bool IsSetPrivateDnsEnabled()
        {
            return this._privateDnsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a resource configuration that will be associated
        /// with the VPC endpoint of type resource.
        /// </para>
        /// </summary>
        public string ResourceConfigurationArn
        {
            get { return this._resourceConfigurationArn; }
            set { this._resourceConfigurationArn = value; }
        }

        // Check to see if ResourceConfigurationArn property is set
        internal bool IsSetResourceConfigurationArn()
        {
            return this._resourceConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Gateway endpoint) The route table IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && (this._routeTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// (Interface endpoint) The IDs of the security groups to associate with the endpoint
        /// network interfaces. If this parameter is not specified, we use the default security
        /// group for the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the endpoint service.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a service network that will be associated with the
        /// VPC endpoint of type service-network.
        /// </para>
        /// </summary>
        public string ServiceNetworkArn
        {
            get { return this._serviceNetworkArn; }
            set { this._serviceNetworkArn = value; }
        }

        // Check to see if ServiceNetworkArn property is set
        internal bool IsSetServiceNetworkArn()
        {
            return this._serviceNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRegion. 
        /// <para>
        /// The Region where the service is hosted. The default is the current Region.
        /// </para>
        /// </summary>
        public string ServiceRegion
        {
            get { return this._serviceRegion; }
            set { this._serviceRegion = value; }
        }

        // Check to see if ServiceRegion property is set
        internal bool IsSetServiceRegion()
        {
            return this._serviceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetConfigurations. 
        /// <para>
        /// The subnet configurations for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetConfiguration> SubnetConfigurations
        {
            get { return this._subnetConfigurations; }
            set { this._subnetConfigurations = value; }
        }

        // Check to see if SubnetConfigurations property is set
        internal bool IsSetSubnetConfigurations()
        {
            return this._subnetConfigurations != null && (this._subnetConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// (Interface and Gateway Load Balancer endpoints) The IDs of the subnets in which to
        /// create endpoint network interfaces. For a Gateway Load Balancer endpoint, you can
        /// specify only one subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to associate with the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointType. 
        /// <para>
        /// The type of endpoint.
        /// </para>
        ///  
        /// <para>
        /// Default: Gateway
        /// </para>
        /// </summary>
        public VpcEndpointType VpcEndpointType
        {
            get { return this._vpcEndpointType; }
            set { this._vpcEndpointType = value; }
        }

        // Check to see if VpcEndpointType property is set
        internal bool IsSetVpcEndpointType()
        {
            return this._vpcEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}