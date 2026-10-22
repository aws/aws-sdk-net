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
    /// Contains information about a NAT gateway rule for a transit gateway attachment, including
    /// the rule number, the source CIDR block, the translated CIDR block, and the state of
    /// the rule.
    /// </summary>
    public partial class TransitGatewayNatRule
    {
        private string _matchSourceCidr;
        private string _natCidr;
        private int? _ruleNumber;
        private TransitGatewayNatRuleState _state;

        /// <summary>
        /// Gets and sets the property MatchSourceCidr. 
        /// <para>
        /// The IPv4 CIDR block of the source addresses to translate.
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
        /// The IPv4 CIDR block that the transit gateway translates the source addresses to.
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
        /// The rule number.
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
        public TransitGatewayNatRuleState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}