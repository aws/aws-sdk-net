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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a gateway's network interface.
    /// </summary>
    public partial class NetworkInterface
    {
        private string _ipv4Address;
        private string _ipv6Address;
        private string _macAddress;

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// The Internet Protocol version 4 (IPv4) address of the interface.
        /// </para>
        /// </summary>
        public string Ipv4Address
        {
            get { return this._ipv4Address; }
            set { this._ipv4Address = value; }
        }

        // Check to see if Ipv4Address property is set
        internal bool IsSetIpv4Address()
        {
            return this._ipv4Address != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The Internet Protocol version 6 (IPv6) address of the interface.
        /// </para>
        ///  <note> 
        /// <para>
        /// This element returns IPv6 addresses for all gateway types except FSx File Gateway.
        /// </para>
        ///  </note>
        /// </summary>
        public string Ipv6Address
        {
            get { return this._ipv6Address; }
            set { this._ipv6Address = value; }
        }

        // Check to see if Ipv6Address property is set
        internal bool IsSetIpv6Address()
        {
            return this._ipv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The Media Access Control (MAC) address of the interface.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is currently unsupported and will not be returned in output.
        /// </para>
        ///  </note>
        /// </summary>
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
        }

    }
}