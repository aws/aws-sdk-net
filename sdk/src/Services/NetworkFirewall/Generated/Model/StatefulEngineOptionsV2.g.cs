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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Configuration settings for the handling of stateful traffic in a Next Generation policy.
    /// </summary>
    public partial class StatefulEngineOptionsV2
    {
        /// <summary>
        /// Gets and sets the property FlowTimeouts. 
        /// <para>
        /// The amount of time that can pass without any traffic sent through the firewall before
        /// the firewall determines that the connection is idle.
        /// </para>
        /// </summary>
        public FlowTimeouts FlowTimeouts { get; set; }

        /// <summary>
        /// Checks to see if the FlowTimeouts property is set.
        /// </summary>
        internal bool IsSetFlowTimeouts() => this.FlowTimeouts != null;

        /// <summary>
        /// Gets and sets the property StreamExceptionPolicy. 
        /// <para>
        /// How Network Firewall handles traffic on a network connection that breaks midstream.
        /// A Next Generation policy supports <c>DROP</c> and <c>REJECT</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/stream-exception-policy.html">Stream
        /// exception policy options in your firewall policy</a> in the <i>Network Firewall Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public StreamExceptionPolicyV2 StreamExceptionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the StreamExceptionPolicy property is set.
        /// </summary>
        internal bool IsSetStreamExceptionPolicy() => this.StreamExceptionPolicy != null;
    }
}
