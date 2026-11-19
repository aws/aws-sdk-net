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
    /// Contains information about a NAT gateway rule for a transit gateway attachment, including
    /// the rule number, the source CIDR block, the translated CIDR block, and the state of
    /// the rule.
    /// </summary>
    public partial class TransitGatewayNatRule
    {
        /// <summary>
        /// Gets and sets the property MatchSourceCidr. 
        /// <para>
        /// The IPv4 CIDR block of the source addresses to translate.
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
        /// The IPv4 CIDR block that the transit gateway translates the source addresses to.
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
        /// The rule number.
        /// </para>
        /// </summary>
        public int? RuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the RuleNumber property is set.
        /// </summary>
        internal bool IsSetRuleNumber() => this.RuleNumber.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the NAT gateway rule. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pending</c> - The transit gateway is applying a change to the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>activated</c> - The rule is in effect because NAT gateway support is enabled for
        /// the attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deactivated</c> - The rule isn't in effect because NAT gateway support is disabled
        /// for the attachment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TransitGatewayNatRuleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
