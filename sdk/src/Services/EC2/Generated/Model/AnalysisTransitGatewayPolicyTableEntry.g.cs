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
    /// Describes an entry in a transit gateway policy table.
    /// </summary>
    public partial class AnalysisTransitGatewayPolicyTableEntry
    {
        /// <summary>
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The destination CIDR block. If this value is not present, the entry matches any destination
        /// address.
        /// </para>
        /// </summary>
        public string DestinationCidr { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidr property is set.
        /// </summary>
        internal bool IsSetDestinationCidr() => this.DestinationCidr != null;

        /// <summary>
        /// Gets and sets the property DestinationPortRange. 
        /// <para>
        /// The destination port range. If this value is not present, the entry matches any destination
        /// port.
        /// </para>
        /// </summary>
        public PortRange DestinationPortRange { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPortRange property is set.
        /// </summary>
        internal bool IsSetDestinationPortRange() => this.DestinationPortRange != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol number. A value of <c>-1</c> means that the entry matches all protocols.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number for the policy table entry. Entries are evaluated in ascending order
        /// of rule number.
        /// </para>
        /// </summary>
        public int? RuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the RuleNumber property is set.
        /// </summary>
        internal bool IsSetRuleNumber() => this.RuleNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SourceCidr. 
        /// <para>
        /// The source CIDR block. If this value is not present, the entry matches any source
        /// address.
        /// </para>
        /// </summary>
        public string SourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the SourceCidr property is set.
        /// </summary>
        internal bool IsSetSourceCidr() => this.SourceCidr != null;

        /// <summary>
        /// Gets and sets the property SourcePortRange. 
        /// <para>
        /// The source port range. If this value is not present, the entry matches any source
        /// port.
        /// </para>
        /// </summary>
        public PortRange SourcePortRange { get; set; }

        /// <summary>
        /// Checks to see if the SourcePortRange property is set.
        /// </summary>
        internal bool IsSetSourcePortRange() => this.SourcePortRange != null;

        /// <summary>
        /// Gets and sets the property TargetRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table to which the entry routes matching traffic.
        /// </para>
        /// </summary>
        public string TargetRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the TargetRouteTableId property is set.
        /// </summary>
        internal bool IsSetTargetRouteTableId() => this.TargetRouteTableId != null;
    }
}
