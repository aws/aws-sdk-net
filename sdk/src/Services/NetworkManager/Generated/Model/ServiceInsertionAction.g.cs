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
    /// Describes the action that the service insertion will take for any segments associated
    /// with it.
    /// </summary>
    public partial class ServiceInsertionAction
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action the service insertion takes for traffic. <c>send-via</c> sends east-west
        /// traffic between attachments. <c>send-to</c> sends north-south traffic to the security
        /// appliance, and then from that to either the Internet or to an on-premesis location.
        /// 
        /// </para>
        /// </summary>
        public SegmentActionServiceInsertion Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Describes the mode packets take for the <c>send-via</c> action. This is not used when
        /// the action is <c>send-to</c>. <c>dual-hop</c> packets traverse attachments in both
        /// the source to the destination core network edges. This mode requires that an inspection
        /// attachment must be present in all Regions of the service insertion-enabled segments.
        /// For <c>single-hop</c>, packets traverse a single intermediate inserted attachment.
        /// You can use <c>EdgeOverride</c> to specify a specific edge to use. 
        /// </para>
        /// </summary>
        public SendViaMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Via. 
        /// <para>
        /// The list of network function groups and any edge overrides for the chosen service
        /// insertion action. Used for both <c>send-to</c> or <c>send-via</c>.
        /// </para>
        /// </summary>
        public Via Via { get; set; }

        /// <summary>
        /// Checks to see if the Via property is set.
        /// </summary>
        internal bool IsSetVia() => this.Via != null;

        /// <summary>
        /// Gets and sets the property WhenSentTo. 
        /// <para>
        /// The list of destination segments if the service insertion action is <c>send-via</c>.
        /// </para>
        /// </summary>
        public WhenSentTo WhenSentTo { get; set; }

        /// <summary>
        /// Checks to see if the WhenSentTo property is set.
        /// </summary>
        internal bool IsSetWhenSentTo() => this.WhenSentTo != null;
    }
}
