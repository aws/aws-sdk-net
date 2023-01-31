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
    /// Container for the parameters to the CreateNatGateway operation.
    /// Creates a NAT gateway in the specified subnet. This action creates a network interface
    /// in the specified subnet with a private IP address from the IP address range of the
    /// subnet. You can create either a public NAT gateway or a private NAT gateway.
    /// 
    ///  
    /// <para>
    /// With a public NAT gateway, internet-bound traffic from a private subnet can be routed
    /// to the NAT gateway, so that instances in a private subnet can connect to the internet.
    /// </para>
    ///  
    /// <para>
    /// With a private NAT gateway, private communication is routed across VPCs and on-premises
    /// networks through a transit gateway or virtual private gateway. Common use cases include
    /// running large workloads behind a small pool of allowlisted IPv4 addresses, preserving
    /// private IPv4 addresses, and communicating between overlapping networks.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-nat-gateway.html">NAT
    /// gateways</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateNatGatewayRequest : AmazonEC2Request
    {
        private string _allocationId;
        private string _clientToken;
        private ConnectivityType _connectivityType;
        private string _privateIpAddress;
        private List<string> _secondaryAllocationIds = new List<string>();
        private int? _secondaryPrivateIpAddressCount;
        private List<string> _secondaryPrivateIpAddresses = new List<string>();
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// [Public NAT gateways only] The allocation ID of an Elastic IP address to associate
        /// with the NAT gateway. You cannot specify an Elastic IP address with a private NAT
        /// gateway. If the Elastic IP address is associated with another resource, you must first
        /// disassociate it.
        /// </para>
        /// </summary>
        public string AllocationId
        {
            get { return this._allocationId; }
            set { this._allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this._allocationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Maximum 64 ASCII characters.
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
        /// Gets and sets the property ConnectivityType. 
        /// <para>
        /// Indicates whether the NAT gateway supports public or private connectivity. The default
        /// is public connectivity.
        /// </para>
        /// </summary>
        public ConnectivityType ConnectivityType
        {
            get { return this._connectivityType; }
            set { this._connectivityType = value; }
        }

        // Check to see if ConnectivityType property is set
        internal bool IsSetConnectivityType()
        {
            return this._connectivityType != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IPv4 address to assign to the NAT gateway. If you don't provide an address,
        /// a private IPv4 address will be automatically assigned.
        /// </para>
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryAllocationIds. 
        /// <para>
        /// Secondary EIP allocation IDs. For more information about secondary addresses, see
        /// <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-nat-gateway.html#nat-gateway-creating">Create
        /// a NAT gateway</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> SecondaryAllocationIds
        {
            get { return this._secondaryAllocationIds; }
            set { this._secondaryAllocationIds = value; }
        }

        // Check to see if SecondaryAllocationIds property is set
        internal bool IsSetSecondaryAllocationIds()
        {
            return this._secondaryAllocationIds != null && this._secondaryAllocationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        /// [Private NAT gateway only] The number of secondary private IPv4 addresses you want
        /// to assign to the NAT gateway. For more information about secondary addresses, see
        /// <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-nat-gateway.html#nat-gateway-creating">Create
        /// a NAT gateway</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public int SecondaryPrivateIpAddressCount
        {
            get { return this._secondaryPrivateIpAddressCount.GetValueOrDefault(); }
            set { this._secondaryPrivateIpAddressCount = value; }
        }

        // Check to see if SecondaryPrivateIpAddressCount property is set
        internal bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this._secondaryPrivateIpAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddresses. 
        /// <para>
        /// Secondary private IPv4 addresses. For more information about secondary addresses,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-nat-gateway.html#nat-gateway-creating">Create
        /// a NAT gateway</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> SecondaryPrivateIpAddresses
        {
            get { return this._secondaryPrivateIpAddresses; }
            set { this._secondaryPrivateIpAddresses = value; }
        }

        // Check to see if SecondaryPrivateIpAddresses property is set
        internal bool IsSetSecondaryPrivateIpAddresses()
        {
            return this._secondaryPrivateIpAddresses != null && this._secondaryPrivateIpAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which to create the NAT gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the NAT gateway.
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

    }
}