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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a NAT rule to configure on an attachment. Source addresses in the source
    /// CIDR block of traffic from the attachment are translated to the same host addresses
    /// in the NAT CIDR block. Traffic to an address in the NAT CIDR block is translated back
    /// to the matching address in the source CIDR block.
    /// </summary>
    public partial class NatRuleRequest
    {
        /// <summary>
        /// Gets and sets the property MatchSourceCidr. 
        /// <para>
        /// The IPv4 CIDR block to match against the source address of traffic from the attachment.
        /// The CIDR block can't overlap with the multicast range (224.0.0.0/4).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string MatchSourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the MatchSourceCidr property is set.
        /// </summary>
        internal bool IsSetMatchSourceCidr() => this.MatchSourceCidr != null;

        /// <summary>
        /// Gets and sets the property NatCidr. 
        /// <para>
        /// The IPv4 CIDR block to translate matching source addresses to. The prefix length must
        /// be the same as the prefix length of <c>MatchSourceCidr</c>. The CIDR block must be
        /// within a private (RFC 1918) or shared address space (RFC 6598) range. The CIDR blocks
        /// of the NAT rules of an attachment can't overlap with each other.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string NatCidr { get; set; }

        /// <summary>
        /// Checks to see if the NatCidr property is set.
        /// </summary>
        internal bool IsSetNatCidr() => this.NatCidr != null;

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number, from 1 to 32766. Each rule number must be unique for the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32766)]
        public int? RuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the RuleNumber property is set.
        /// </summary>
        internal bool IsSetRuleNumber() => this.RuleNumber.HasValue;
    }
}
