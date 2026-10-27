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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Describes a set of permissions for a security group rule.
    /// </summary>
    public partial class SecurityGroupRuleDescription
    {
        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The start of the port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type
        /// number. A value of <c>-1</c> indicates all ICMP/ICMPv6 types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public long? FromPort { get; set; }

        /// <summary>
        /// Checks to see if the FromPort property is set.
        /// </summary>
        internal bool IsSetFromPort() => this.FromPort.HasValue;

        /// <summary>
        /// Gets and sets the property IPV4Range. 
        /// <para>
        /// The IPv4 ranges for the security group rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IPV4Range { get; set; }

        /// <summary>
        /// Checks to see if the IPV4Range property is set.
        /// </summary>
        internal bool IsSetIPV4Range() => this.IPV4Range != null;

        /// <summary>
        /// Gets and sets the property IPV6Range. 
        /// <para>
        /// The IPv6 ranges for the security group rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IPV6Range { get; set; }

        /// <summary>
        /// Checks to see if the IPV6Range property is set.
        /// </summary>
        internal bool IsSetIPV6Range() => this.IPV6Range != null;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list for the security group rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IP protocol name (<c>tcp</c>, <c>udp</c>, <c>icmp</c>, <c>icmpv6</c>) or number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The end of the port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code. A
        /// value of <c>-1</c> indicates all ICMP/ICMPv6 codes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public long? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;
    }
}
