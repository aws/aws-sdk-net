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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

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
        [AWSProperty(Required = true)]
        public string Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port != null;

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
        [AWSProperty(Required = true)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

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
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpAddress property is set.
        /// </summary>
        internal bool IsSetPublicIpAddress() => this.PublicIpAddress != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates the type of endpoint running at the specific IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
