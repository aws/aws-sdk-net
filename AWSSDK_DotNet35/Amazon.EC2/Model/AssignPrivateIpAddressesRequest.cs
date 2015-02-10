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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssignPrivateIpAddresses operation.
    /// Assigns one or more secondary private IP addresses to the specified network interface.
    /// You can specify one or more specific secondary IP addresses, or you can specify the
    /// number of secondary IP addresses to be automatically assigned within the subnet's
    /// CIDR block range. The number of secondary IP addresses that you can assign to an instance
    /// varies by instance type. For information about instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
    /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>. For more
    /// information about Elastic IP addresses, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// 
    ///  
    /// <para>
    /// AssignPrivateIpAddresses is available only in EC2-VPC.
    /// </para>
    /// </summary>
    public partial class AssignPrivateIpAddressesRequest : AmazonEC2Request
    {
        private bool? _allowReassignment;
        private string _networkInterfaceId;
        private List<string> _privateIpAddresses = new List<string>();
        private int? _secondaryPrivateIpAddressCount;

        /// <summary>
        /// Gets and sets the property AllowReassignment. 
        /// <para>
        /// Indicates whether to allow an IP address that is already assigned to another network
        /// interface or instance to be reassigned to the specified network interface.
        /// </para>
        /// </summary>
        public bool AllowReassignment
        {
            get { return this._allowReassignment.GetValueOrDefault(); }
            set { this._allowReassignment = value; }
        }

        // Check to see if AllowReassignment property is set
        internal bool IsSetAllowReassignment()
        {
            return this._allowReassignment.HasValue; 
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
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// One or more IP addresses to be assigned as a secondary private IP address to the network
        /// interface. You can't specify this parameter when also specifying a number of secondary
        /// IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an IP address, Amazon EC2 automatically selects an IP address
        /// within the subnet range.
        /// </para>
        /// </summary>
        public List<string> PrivateIpAddresses
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
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        /// The number of secondary IP addresses to assign to the network interface. You can't
        /// specify this parameter when also specifying private IP addresses.
        /// </para>
        /// </summary>
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

    }
}