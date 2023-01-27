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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcEndpoint operation.
    /// Creates a VPC endpoint for a specified service. An endpoint enables you to create
    /// a private connection between your VPC and the service. The service may be provided
    /// by Amazon Web Services, an Amazon Web Services Marketplace Partner, or another Amazon
    /// Web Services account. For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/">Amazon
    /// Web Services PrivateLink Guide</a>.
    /// </summary>
    public partial class CreateVpcEndpointRequest : AmazonEC2Request
    {
        private string _clientToken;
        private DnsOptionsSpecification _dnsOptions;
        private IpAddressType _ipAddressType;
        private string _policyDocument;
        private bool? _privateDnsEnabled;
        private List<string> _routeTableIds = new List<string>();
        private List<string> _securityGroupIds = new List<string>();
        private string _serviceName;
        private List<string> _subnetIds = new List<string>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private VpcEndpointType _vpcEndpointType;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">How
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
        /// DNS name for the service for the Region (for example, <code>kinesis.us-east-1.amazonaws.com</code>),
        /// which resolves to the private IP addresses of the endpoint network interfaces in the
        /// VPC. This enables you to make requests to the default public DNS name for the service
        /// instead of the public DNS names that are automatically generated by the VPC endpoint
        /// service.
        /// </para>
        ///  
        /// <para>
        /// To use a private hosted zone, you must set the following VPC attributes to <code>true</code>:
        /// <code>enableDnsHostnames</code> and <code>enableDnsSupport</code>. Use <a>ModifyVpcAttribute</a>
        /// to set the VPC attributes.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool PrivateDnsEnabled
        {
            get { return this._privateDnsEnabled.GetValueOrDefault(); }
            set { this._privateDnsEnabled = value; }
        }

        // Check to see if PrivateDnsEnabled property is set
        internal bool IsSetPrivateDnsEnabled()
        {
            return this._privateDnsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Gateway endpoint) The route table IDs.
        /// </para>
        /// </summary>
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && this._routeTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// (Interface endpoint) The IDs of the security groups to associate with the endpoint
        /// network interface. If this parameter is not specified, we use the default security
        /// group for the VPC.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The service name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// (Interface and Gateway Load Balancer endpoints) The IDs of the subnets in which to
        /// create an endpoint network interface. For a Gateway Load Balancer endpoint, you can
        /// specify only one subnet.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to associate with the endpoint.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
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
        /// The ID of the VPC for the endpoint.
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