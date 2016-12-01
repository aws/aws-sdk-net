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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the ModifySubnetAttribute operation.
    /// Modifies a subnet attribute. You can only modify one attribute at a time.
    /// </summary>
    public partial class ModifySubnetAttributeRequest : AmazonEC2Request
    {
        private bool? _assignIpv6AddressOnCreation;
        private bool? _mapPublicIpOnLaunch;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AssignIpv6AddressOnCreation. 
        /// <para>
        /// Specify <code>true</code> to indicate that network interfaces created in the specified
        /// subnet should be assigned an IPv6 address. This includes a network interface that's
        /// created when launching an instance into the subnet (the instance therefore receives
        /// an IPv6 address).
        /// </para>
        /// </summary>
        public bool AssignIpv6AddressOnCreation
        {
            get { return this._assignIpv6AddressOnCreation.GetValueOrDefault(); }
            set { this._assignIpv6AddressOnCreation = value; }
        }

        // Check to see if AssignIpv6AddressOnCreation property is set
        internal bool IsSetAssignIpv6AddressOnCreation()
        {
            return this._assignIpv6AddressOnCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapPublicIpOnLaunch. 
        /// <para>
        /// Specify <code>true</code> to indicate that network interfaces created in the specified
        /// subnet should be assigned a public IPv4 address. This includes a network interface
        /// that's created when launching an instance into the subnet (the instance therefore
        /// receives a public IPv4 address).
        /// </para>
        /// </summary>
        public bool MapPublicIpOnLaunch
        {
            get { return this._mapPublicIpOnLaunch.GetValueOrDefault(); }
            set { this._mapPublicIpOnLaunch = value; }
        }

        // Check to see if MapPublicIpOnLaunch property is set
        internal bool IsSetMapPublicIpOnLaunch()
        {
            return this._mapPublicIpOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
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

    }
}