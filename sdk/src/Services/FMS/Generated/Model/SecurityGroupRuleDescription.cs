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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Describes a set of permissions for a security group rule.
    /// </summary>
    public partial class SecurityGroupRuleDescription
    {
        private long? _fromPort;
        private string _ipv4Range;
        private string _ipv6Range;
        private string _prefixListId;
        private string _protocol;
        private long? _toPort;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The start of the port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type
        /// number. A value of <c>-1</c> indicates all ICMP/ICMPv6 types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public long? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IPV4Range. 
        /// <para>
        /// The IPv4 ranges for the security group rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IPV4Range
        {
            get { return this._ipv4Range; }
            set { this._ipv4Range = value; }
        }

        // Check to see if IPV4Range property is set
        internal bool IsSetIPV4Range()
        {
            return this._ipv4Range != null;
        }

        /// <summary>
        /// Gets and sets the property IPV6Range. 
        /// <para>
        /// The IPv6 ranges for the security group rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IPV6Range
        {
            get { return this._ipv6Range; }
            set { this._ipv6Range = value; }
        }

        // Check to see if IPV6Range property is set
        internal bool IsSetIPV6Range()
        {
            return this._ipv6Range != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list for the security group rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IP protocol name (<c>tcp</c>, <c>udp</c>, <c>icmp</c>, <c>icmpv6</c>) or number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Protocol
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
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The end of the port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code. A
        /// value of <c>-1</c> indicates all ICMP/ICMPv6 codes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public long? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}