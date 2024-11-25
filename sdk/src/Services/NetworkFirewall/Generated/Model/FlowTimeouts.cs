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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
    /// Describes the amount of time that can pass without any traffic sent through the firewall
    /// before the firewall determines that the connection is idle and Network Firewall removes
    /// the flow entry from its flow table. Existing connections and flows are not impacted
    /// when you update this value. Only new connections after you update this value are impacted.
    /// </summary>
    public partial class FlowTimeouts
    {
        private int? _tcpIdleTimeoutSeconds;

        /// <summary>
        /// Gets and sets the property TcpIdleTimeoutSeconds. 
        /// <para>
        /// The number of seconds that can pass without any TCP traffic sent through the firewall
        /// before the firewall determines that the connection is idle. After the idle timeout
        /// passes, data packets are dropped, however, the next TCP SYN packet is considered a
        /// new flow and is processed by the firewall. Clients or targets can use TCP keepalive
        /// packets to reset the idle timeout. 
        /// </para>
        ///  
        /// <para>
        /// You can define the <c>TcpIdleTimeoutSeconds</c> value to be between 60 and 6000 seconds.
        /// If no value is provided, it defaults to 350 seconds. 
        /// </para>
        /// </summary>
        public int? TcpIdleTimeoutSeconds
        {
            get { return this._tcpIdleTimeoutSeconds; }
            set { this._tcpIdleTimeoutSeconds = value; }
        }

        // Check to see if TcpIdleTimeoutSeconds property is set
        internal bool IsSetTcpIdleTimeoutSeconds()
        {
            return this._tcpIdleTimeoutSeconds.HasValue; 
        }

    }
}