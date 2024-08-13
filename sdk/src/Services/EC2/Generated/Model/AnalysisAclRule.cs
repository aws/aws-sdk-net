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
    /// Describes a network access control (ACL) rule.
    /// </summary>
    public partial class AnalysisAclRule
    {
        private string _cidr;
        private bool? _egress;
        private PortRange _portRange;
        private string _protocol;
        private string _ruleAction;
        private int? _ruleNumber;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation.
        /// </para>
        /// </summary>
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property Egress. 
        /// <para>
        /// Indicates whether the rule is an outbound rule.
        /// </para>
        /// </summary>
        public bool? Egress
        {
            get { return this._egress; }
            set { this._egress = value; }
        }

        // Check to see if Egress property is set
        internal bool IsSetEgress()
        {
            return this._egress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortRange. 
        /// <para>
        /// The range of ports.
        /// </para>
        /// </summary>
        public PortRange PortRange
        {
            get { return this._portRange; }
            set { this._portRange = value; }
        }

        // Check to see if PortRange property is set
        internal bool IsSetPortRange()
        {
            return this._portRange != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RuleAction. 
        /// <para>
        /// Indicates whether to allow or deny traffic that matches the rule.
        /// </para>
        /// </summary>
        public string RuleAction
        {
            get { return this._ruleAction; }
            set { this._ruleAction = value; }
        }

        // Check to see if RuleAction property is set
        internal bool IsSetRuleAction()
        {
            return this._ruleAction != null;
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

    }
}