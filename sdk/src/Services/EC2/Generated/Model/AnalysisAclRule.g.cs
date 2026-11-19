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
    /// Describes a network access control (ACL) rule.
    /// </summary>
    public partial class AnalysisAclRule
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
        /// Gets and sets the property Egress. 
        /// <para>
        /// Indicates whether the rule is an outbound rule.
        /// </para>
        /// </summary>
        public bool? Egress { get; set; }

        /// <summary>
        /// Checks to see if the Egress property is set.
        /// </summary>
        internal bool IsSetEgress() => this.Egress.HasValue;

        /// <summary>
        /// Gets and sets the property PortRange. 
        /// <para>
        /// The range of ports.
        /// </para>
        /// </summary>
        public PortRange PortRange { get; set; }

        /// <summary>
        /// Checks to see if the PortRange property is set.
        /// </summary>
        internal bool IsSetPortRange() => this.PortRange != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RuleAction. 
        /// <para>
        /// Indicates whether to allow or deny traffic that matches the rule.
        /// </para>
        /// </summary>
        public string RuleAction { get; set; }

        /// <summary>
        /// Checks to see if the RuleAction property is set.
        /// </summary>
        internal bool IsSetRuleAction() => this.RuleAction != null;

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
    }
}
