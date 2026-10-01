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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The inspection criteria for a stateful rule.
    /// </summary>
    public partial class RuleGroupSourceStatefulRulesHeaderDetails
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination IP address or address range to inspect for, in CIDR notation. To match
        /// with any address, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port to inspect for. You can specify an individual port, such as <c>1994</c>.
        /// You also can specify a port range, such as <c>1990:1994</c>. To match with any port,
        /// specify <c>ANY</c>.
        /// </para>
        /// </summary>
        public string DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of traffic flow to inspect. If set to <c>ANY</c>, the inspection matches
        /// bidirectional traffic, both from the source to the destination and from the destination
        /// to the source. If set to <c>FORWARD</c>, the inspection only matches traffic going
        /// from the source to the destination.
        /// </para>
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to inspect for. To inspector for all protocols, use <c>IP</c>.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source IP address or address range to inspect for, in CIDR notation. To match
        /// with any address, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port to inspect for. You can specify an individual port, such as <c>1994</c>.
        /// You also can specify a port range, such as <c>1990:1994</c>. To match with any port,
        /// specify <c>ANY</c>.
        /// </para>
        /// </summary>
        public string SourcePort { get; set; }

        /// <summary>
        /// Checks to see if the SourcePort property is set.
        /// </summary>
        internal bool IsSetSourcePort() => this.SourcePort != null;
    }
}
