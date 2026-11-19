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
    /// Describes a NAT gateway rule to apply to a transit gateway attachment. A NAT gateway
    /// rule translates source addresses in the <c>MatchSourceCidr</c> range to the corresponding
    /// addresses in the <c>NatCidr</c> range.
    /// </summary>
    public partial class TransitGatewayNatRuleRequest
    {
        /// <summary>
        /// Gets and sets the property MatchSourceCidr. 
        /// <para>
        /// The IPv4 CIDR block of the source addresses to translate. The CIDR block can't overlap
        /// the multicast range (<c>224.0.0.0/4</c>) or the link-local range (<c>169.254.0.0/16</c>).
        /// </para>
        /// </summary>
        public string MatchSourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the MatchSourceCidr property is set.
        /// </summary>
        internal bool IsSetMatchSourceCidr() => this.MatchSourceCidr != null;

        /// <summary>
        /// Gets and sets the property NatCidr. 
        /// <para>
        /// The IPv4 CIDR block to translate the source addresses to. The CIDR block must be in
        /// a private (RFC 1918) or shared address space (RFC 6598) range, and must have the same
        /// prefix length as <c>MatchSourceCidr</c>. The CIDR blocks in the rules for an attachment
        /// can't overlap each other.
        /// </para>
        /// </summary>
        public string NatCidr { get; set; }

        /// <summary>
        /// Checks to see if the NatCidr property is set.
        /// </summary>
        internal bool IsSetNatCidr() => this.NatCidr != null;

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number. Valid values are 1 to 32766. Each rule number must be unique within
        /// the request.
        /// </para>
        /// </summary>
        public int? RuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the RuleNumber property is set.
        /// </summary>
        internal bool IsSetRuleNumber() => this.RuleNumber.HasValue;
    }
}
