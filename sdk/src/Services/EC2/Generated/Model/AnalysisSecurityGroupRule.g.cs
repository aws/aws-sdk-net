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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a security group rule.
    /// </summary>
    public partial class AnalysisSecurityGroupRule
    {
        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// egress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ingress
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property PortRange. 
        /// <para>
        /// The port range.
        /// </para>
        /// </summary>
        public PortRange PortRange { get; set; }

        /// <summary>
        /// Checks to see if the PortRange property is set.
        /// </summary>
        internal bool IsSetPortRange() => this.PortRange != null;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The prefix list ID.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol name.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// The security group ID.
        /// </para>
        /// </summary>
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupId property is set.
        /// </summary>
        internal bool IsSetSecurityGroupId() => this.SecurityGroupId != null;
    }
}
