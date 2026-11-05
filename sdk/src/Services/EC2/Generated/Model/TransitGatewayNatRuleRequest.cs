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
    /// Describes a NAT gateway rule to apply to a transit gateway attachment. A NAT gateway
    /// rule translates source addresses in the <c>MatchSourceCidr</c> range to the corresponding
    /// addresses in the <c>NatCidr</c> range.
    /// </summary>
    public partial class TransitGatewayNatRuleRequest
    {
        private string _matchSourceCidr;
        private string _natCidr;
        private int? _ruleNumber;

        /// <summary>
        /// Gets and sets the property MatchSourceCidr. 
        /// <para>
        /// The IPv4 CIDR block of the source addresses to translate. The CIDR block can't overlap
        /// the multicast range (<c>224.0.0.0/4</c>) or the link-local range (<c>169.254.0.0/16</c>).
        /// </para>
        /// </summary>
        public string MatchSourceCidr
        {
            get { return this._matchSourceCidr; }
            set { this._matchSourceCidr = value; }
        }

        // Check to see if MatchSourceCidr property is set
        internal bool IsSetMatchSourceCidr()
        {
            return this._matchSourceCidr != null;
        }

        /// <summary>
        /// Gets and sets the property NatCidr. 
        /// <para>
        /// The IPv4 CIDR block to translate the source addresses to. The CIDR block must be in
        /// a private (RFC 1918) or shared address space (RFC 6598) range, and must have the same
        /// prefix length as <c>MatchSourceCidr</c>. The CIDR blocks in the rules for an attachment
        /// can't overlap each other.
        /// </para>
        /// </summary>
        public string NatCidr
        {
            get { return this._natCidr; }
            set { this._natCidr = value; }
        }

        // Check to see if NatCidr property is set
        internal bool IsSetNatCidr()
        {
            return this._natCidr != null;
        }

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number. Valid values are 1 to 32766. Each rule number must be unique within
        /// the request.
        /// </para>
        /// </summary>
        public int? RuleNumber
        {
            get { return this._ruleNumber; }
            set { this._ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this._ruleNumber.HasValue; 
        }

    }
}