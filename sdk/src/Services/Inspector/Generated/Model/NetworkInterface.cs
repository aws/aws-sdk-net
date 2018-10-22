/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about the network interfaces interacting with an EC2 instance.
    /// This data type is used as one of the elements of the <a>AssetAttributes</a> data type.
    /// </summary>
    public partial class NetworkInterface
    {
        private List<string> _ipv6Addresses = new List<string>();
        private string _networkInterfaceId;
        private string _privateDnsName;
        private string _privateIpAddress;
        private List<PrivateIp> _privateIpAddresses = new List<PrivateIp>();
        private string _publicDnsName;
        private string _publicIp;
        private List<SecurityGroup> _securityGroups = new List<SecurityGroup>();
        private string _subnetId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IP addresses associated with the network interface.
        /// </para>
        /// </summary>
        public List<string> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && this._ipv6Addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// The name of a private DNS associated with the network interface.
        /// </para>
        /// </summary>
        public string PrivateDnsName
        {
            get { return this._privateDnsName; }
            set { this._privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this._privateDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address associated with the network interface.
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
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// A list of the private IP addresses associated with the network interface. Includes
        /// the privateDnsName and privateIpAddress.
        /// </para>
        /// </summary>
        public List<PrivateIp> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && this._privateIpAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// The name of a public DNS associated with the network interface.
        /// </para>
        /// </summary>
        public string PublicDnsName
        {
            get { return this._publicDnsName; }
            set { this._publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this._publicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The public IP address from which the network interface is reachable.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of the security groups associated with the network interface. Includes the
        /// groupId and groupName.
        /// </para>
        /// </summary>
        public List<SecurityGroup> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of a subnet associated with the network interface.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of a VPC associated with the network interface.
        /// </para>
        /// </summary>
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