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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The network field that contains a list of network metrics that are associated with
    /// the current instance.
    /// </summary>
    public partial class NetworkResourceUtilization
    {
        /// <summary>
        /// Gets and sets the property NetworkInBytesPerSecond. 
        /// <para>
        /// The network inbound throughput utilization measured in Bytes per second (Bps). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NetworkInBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetNetworkInBytesPerSecond() => this.NetworkInBytesPerSecond != null;

        /// <summary>
        /// Gets and sets the property NetworkOutBytesPerSecond. 
        /// <para>
        /// The network outbound throughput utilization measured in Bytes per second (Bps). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NetworkOutBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the NetworkOutBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetNetworkOutBytesPerSecond() => this.NetworkOutBytesPerSecond != null;

        /// <summary>
        /// Gets and sets the property NetworkPacketsInPerSecond. 
        /// <para>
        /// The network inbound packets that are measured in packets per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NetworkPacketsInPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPacketsInPerSecond property is set.
        /// </summary>
        internal bool IsSetNetworkPacketsInPerSecond() => this.NetworkPacketsInPerSecond != null;

        /// <summary>
        /// Gets and sets the property NetworkPacketsOutPerSecond. 
        /// <para>
        /// The network outbound packets that are measured in packets per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NetworkPacketsOutPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPacketsOutPerSecond property is set.
        /// </summary>
        internal bool IsSetNetworkPacketsOutPerSecond() => this.NetworkPacketsOutPerSecond != null;
    }
}
