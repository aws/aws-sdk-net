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
    /// Container for the parameters to the ModifyVpcEndpoint operation.
    /// Modifies attributes of a specified VPC endpoint. The attributes that you can modify
    /// depend on the type of VPC endpoint (interface, gateway, or Gateway Load Balancer).
    /// For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/">Amazon
    /// Web Services PrivateLink Guide</a>.
    /// </summary>
    public partial class ModifyVpcEndpointRequest : AmazonEC2Request
    {
        private List<string> _addRouteTableIds = new List<string>();
        private List<string> _addSecurityGroupIds = new List<string>();
        private List<string> _addSubnetIds = new List<string>();
        private DnsOptionsSpecification _dnsOptions;
        private IpAddressType _ipAddressType;
        private string _policyDocument;
        private bool? _privateDnsEnabled;
        private List<string> _removeRouteTableIds = new List<string>();
        private List<string> _removeSecurityGroupIds = new List<string>();
        private List<string> _removeSubnetIds = new List<string>();
        private bool? _resetPolicy;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property AddRouteTableIds. 
        /// <para>
        /// (Gateway endpoint) The IDs of the route tables to associate with the endpoint.
        /// </para>
        /// </summary>
        public List<string> AddRouteTableIds
        {
            get { return this._addRouteTableIds; }
            set { this._addRouteTableIds = value; }
        }

        // Check to see if AddRouteTableIds property is set
        internal bool IsSetAddRouteTableIds()
        {
            return this._addRouteTableIds != null && this._addRouteTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AddSecurityGroupIds. 
        /// <para>
        /// (Interface endpoint) The IDs of the security groups to associate with the network
        /// interface.
        /// </para>
        /// </summary>
        public List<string> AddSecurityGroupIds
        {
            get { return this._addSecurityGroupIds; }
            set { this._addSecurityGroupIds = value; }
        }

        // Check to see if AddSecurityGroupIds property is set
        internal bool IsSetAddSecurityGroupIds()
        {
            return this._addSecurityGroupIds != null && this._addSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AddSubnetIds. 
        /// <para>
        /// (Interface and Gateway Load Balancer endpoints) The IDs of the subnets in which to
        /// serve the endpoint. For a Gateway Load Balancer endpoint, you can specify only one
        /// subnet.
        /// </para>
        /// </summary>
        public List<string> AddSubnetIds
        {
            get { return this._addSubnetIds; }
            set { this._addSubnetIds = value; }
        }

        // Check to see if AddSubnetIds property is set
        internal bool IsSetAddSubnetIds()
        {
            return this._addSubnetIds != null && this._addSubnetIds.Count > 0; 
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
        /// access to the service. The policy must be in valid JSON format.
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
        /// (Interface endpoint) Indicates whether a private hosted zone is associated with the
        /// VPC.
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
        /// Gets and sets the property RemoveRouteTableIds. 
        /// <para>
        /// (Gateway endpoint) The IDs of the route tables to disassociate from the endpoint.
        /// </para>
        /// </summary>
        public List<string> RemoveRouteTableIds
        {
            get { return this._removeRouteTableIds; }
            set { this._removeRouteTableIds = value; }
        }

        // Check to see if RemoveRouteTableIds property is set
        internal bool IsSetRemoveRouteTableIds()
        {
            return this._removeRouteTableIds != null && this._removeRouteTableIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveSecurityGroupIds. 
        /// <para>
        /// (Interface endpoint) The IDs of the security groups to disassociate from the network
        /// interface.
        /// </para>
        /// </summary>
        public List<string> RemoveSecurityGroupIds
        {
            get { return this._removeSecurityGroupIds; }
            set { this._removeSecurityGroupIds = value; }
        }

        // Check to see if RemoveSecurityGroupIds property is set
        internal bool IsSetRemoveSecurityGroupIds()
        {
            return this._removeSecurityGroupIds != null && this._removeSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveSubnetIds. 
        /// <para>
        /// (Interface endpoint) The IDs of the subnets from which to remove the endpoint.
        /// </para>
        /// </summary>
        public List<string> RemoveSubnetIds
        {
            get { return this._removeSubnetIds; }
            set { this._removeSubnetIds = value; }
        }

        // Check to see if RemoveSubnetIds property is set
        internal bool IsSetRemoveSubnetIds()
        {
            return this._removeSubnetIds != null && this._removeSubnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResetPolicy. 
        /// <para>
        /// (Gateway endpoint) Specify <code>true</code> to reset the policy document to the default
        /// policy. The default policy allows full access to the service.
        /// </para>
        /// </summary>
        public bool ResetPolicy
        {
            get { return this._resetPolicy.GetValueOrDefault(); }
            set { this._resetPolicy = value; }
        }

        // Check to see if ResetPolicy property is set
        internal bool IsSetResetPolicy()
        {
            return this._resetPolicy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}