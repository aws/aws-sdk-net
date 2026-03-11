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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// An endpoint available for interaction with the scheduler.
    /// </summary>
    public partial class Endpoint
    {
        private string _ipv6Address;
        private string _port;
        private string _privateIpAddress;
        private string _publicIpAddress;
        private EndpointType _type;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The endpoint's IPv6 address.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>2001:db8::1</c> 
        /// </para>
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The endpoint's connection port number.
        /// </para>
        ///  
        /// <para>
        ///  Example: <c>1234</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// For clusters that use IPv4, this is the endpoint's private IP address.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>10.1.2.3</c> 
        /// </para>
        ///  
        /// <para>
        /// For clusters configured to use IPv6, this is an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The endpoint's public IP address.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>192.0.2.1</c> 
        /// </para>
        /// </summary>
        public string PublicIpAddress
        {
            get { return this._publicIpAddress; }
            set { this._publicIpAddress = value; }
        }

        // Check to see if PublicIpAddress property is set
        internal bool IsSetPublicIpAddress()
        {
            return this._publicIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates the type of endpoint running at the specific IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}