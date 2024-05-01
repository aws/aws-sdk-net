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
    /// Describes an address range of an IPv4 address pool.
    /// </summary>
    public partial class PublicIpv4PoolRange
    {
        private int? _addressCount;
        private int? _availableAddressCount;
        private string _firstAddress;
        private string _lastAddress;

        /// <summary>
        /// Gets and sets the property AddressCount. 
        /// <para>
        /// The number of addresses in the range.
        /// </para>
        /// </summary>
        public int? AddressCount
        {
            get { return this._addressCount; }
            set { this._addressCount = value; }
        }

        // Check to see if AddressCount property is set
        internal bool IsSetAddressCount()
        {
            return this._addressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableAddressCount. 
        /// <para>
        /// The number of available addresses in the range.
        /// </para>
        /// </summary>
        public int? AvailableAddressCount
        {
            get { return this._availableAddressCount; }
            set { this._availableAddressCount = value; }
        }

        // Check to see if AvailableAddressCount property is set
        internal bool IsSetAvailableAddressCount()
        {
            return this._availableAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstAddress. 
        /// <para>
        /// The first IP address in the range.
        /// </para>
        /// </summary>
        public string FirstAddress
        {
            get { return this._firstAddress; }
            set { this._firstAddress = value; }
        }

        // Check to see if FirstAddress property is set
        internal bool IsSetFirstAddress()
        {
            return this._firstAddress != null;
        }

        /// <summary>
        /// Gets and sets the property LastAddress. 
        /// <para>
        /// The last IP address in the range.
        /// </para>
        /// </summary>
        public string LastAddress
        {
            get { return this._lastAddress; }
            set { this._lastAddress = value; }
        }

        // Check to see if LastAddress property is set
        internal bool IsSetLastAddress()
        {
            return this._lastAddress != null;
        }

    }
}