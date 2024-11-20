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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html">CreateResolverRule</a>
    /// request, an array of the IPs that you want to forward DNS queries to.
    /// </summary>
    public partial class TargetAddress
    {
        private string _ip;
        private string _ipv6;
        private int? _port;
        private Protocol _protocol;
        private string _serverNameIndication;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// One IPv4 address that you want to forward DNS queries to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=36)]
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6. 
        /// <para>
        ///  One IPv6 address that you want to forward DNS queries to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=39)]
        public string Ipv6
        {
            get { return this._ipv6; }
            set { this._ipv6 = value; }
        }

        // Check to see if Ipv6 property is set
        internal bool IsSetIpv6()
        {
            return this._ipv6 != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port at <c>Ip</c> that you want to forward DNS queries to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        ///  The protocols for the target address. The protocol you choose needs to be supported
        /// by the outbound endpoint of the Resolver rule.
        /// </para>
        /// </summary>
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ServerNameIndication. 
        /// <para>
        ///  The Server Name Indication of the DoH server that you want to forward queries to.
        /// This is only used if the Protocol of the <c>TargetAddress</c> is <c>DoH</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string ServerNameIndication
        {
            get { return this._serverNameIndication; }
            set { this._serverNameIndication = value; }
        }

        // Check to see if ServerNameIndication property is set
        internal bool IsSetServerNameIndication()
        {
            return this._serverNameIndication != null;
        }

    }
}