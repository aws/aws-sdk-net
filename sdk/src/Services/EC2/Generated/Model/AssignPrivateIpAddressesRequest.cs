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
    /// Container for the parameters to the AssignPrivateIpAddresses operation.
    /// Assigns the specified secondary private IP addresses to the specified network interface.
    /// 
    ///  
    /// <para>
    /// You can specify specific secondary IP addresses, or you can specify the number of
    /// secondary IP addresses to be automatically assigned from the subnet's CIDR block range.
    /// The number of secondary IP addresses that you can assign to an instance varies by
    /// instance type. For more information about Elastic IP addresses, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP Addresses</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you move a secondary private IP address to another network interface, any Elastic
    /// IP address that is associated with the IP address is also moved.
    /// </para>
    ///  
    /// <para>
    /// Remapping an IP address is an asynchronous operation. When you move an IP address
    /// from one network interface to another, check <c>network/interfaces/macs/mac/local-ipv4s</c>
    /// in the instance metadata to confirm that the remapping is complete.
    /// </para>
    ///  
    /// <para>
    /// You must specify either the IP addresses or the IP address count in the request.
    /// </para>
    ///  
    /// <para>
    /// You can optionally use Prefix Delegation on the network interface. You must specify
    /// either the IPv4 Prefix Delegation prefixes, or the IPv4 Prefix Delegation count. For
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-prefix-eni.html">
    /// Assigning prefixes to network interfaces</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssignPrivateIpAddressesRequest : AmazonEC2Request
    {
        private bool? _allowReassignment;
        private int? _ipv4PrefixCount;
        private List<string> _ipv4Prefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _networkInterfaceId;
        private List<string> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _secondaryPrivateIpAddressCount;

        /// <summary>
        /// Gets and sets the property AllowReassignment. 
        /// <para>
        /// Indicates whether to allow an IP address that is already assigned to another network
        /// interface or instance to be reassigned to the specified network interface.
        /// </para>
        /// </summary>
        public bool? AllowReassignment
        {
            get { return this._allowReassignment; }
            set { this._allowReassignment = value; }
        }

        // Check to see if AllowReassignment property is set
        internal bool IsSetAllowReassignment()
        {
            return this._allowReassignment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv4PrefixCount. 
        /// <para>
        /// The number of IPv4 prefixes that Amazon Web Services automatically assigns to the
        /// network interface. You can't use this option if you use the <c>Ipv4 Prefixes</c> option.
        /// </para>
        /// </summary>
        public int? Ipv4PrefixCount
        {
            get { return this._ipv4PrefixCount; }
            set { this._ipv4PrefixCount = value; }
        }

        // Check to see if Ipv4PrefixCount property is set
        internal bool IsSetIpv4PrefixCount()
        {
            return this._ipv4PrefixCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        /// One or more IPv4 prefixes assigned to the network interface. You can't use this option
        /// if you use the <c>Ipv4PrefixCount</c> option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv4Prefixes
        {
            get { return this._ipv4Prefixes; }
            set { this._ipv4Prefixes = value; }
        }

        // Check to see if Ipv4Prefixes property is set
        internal bool IsSetIpv4Prefixes()
        {
            return this._ipv4Prefixes != null && (this._ipv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The IP addresses to be assigned as a secondary private IP address to the network interface.
        /// You can't specify this parameter when also specifying a number of secondary IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an IP address, Amazon EC2 automatically selects an IP address
        /// within the subnet range.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && (this._privateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        /// The number of secondary IP addresses to assign to the network interface. You can't
        /// specify this parameter when also specifying private IP addresses.
        /// </para>
        /// </summary>
        public int? SecondaryPrivateIpAddressCount
        {
            get { return this._secondaryPrivateIpAddressCount; }
            set { this._secondaryPrivateIpAddressCount = value; }
        }

        // Check to see if SecondaryPrivateIpAddressCount property is set
        internal bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this._secondaryPrivateIpAddressCount.HasValue; 
        }

    }
}