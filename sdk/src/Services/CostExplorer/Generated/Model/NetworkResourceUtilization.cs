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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
        private string _networkInBytesPerSecond;
        private string _networkOutBytesPerSecond;
        private string _networkPacketsInPerSecond;
        private string _networkPacketsOutPerSecond;

        /// <summary>
        /// Gets and sets the property NetworkInBytesPerSecond. 
        /// <para>
        /// The network inbound throughput utilization measured in Bytes per second (Bps). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string NetworkInBytesPerSecond
        {
            get { return this._networkInBytesPerSecond; }
            set { this._networkInBytesPerSecond = value; }
        }

        // Check to see if NetworkInBytesPerSecond property is set
        internal bool IsSetNetworkInBytesPerSecond()
        {
            return this._networkInBytesPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkOutBytesPerSecond. 
        /// <para>
        /// The network outbound throughput utilization measured in Bytes per second (Bps). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string NetworkOutBytesPerSecond
        {
            get { return this._networkOutBytesPerSecond; }
            set { this._networkOutBytesPerSecond = value; }
        }

        // Check to see if NetworkOutBytesPerSecond property is set
        internal bool IsSetNetworkOutBytesPerSecond()
        {
            return this._networkOutBytesPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkPacketsInPerSecond. 
        /// <para>
        /// The network inbound packets that are measured in packets per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string NetworkPacketsInPerSecond
        {
            get { return this._networkPacketsInPerSecond; }
            set { this._networkPacketsInPerSecond = value; }
        }

        // Check to see if NetworkPacketsInPerSecond property is set
        internal bool IsSetNetworkPacketsInPerSecond()
        {
            return this._networkPacketsInPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkPacketsOutPerSecond. 
        /// <para>
        /// The network outbound packets that are measured in packets per second. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string NetworkPacketsOutPerSecond
        {
            get { return this._networkPacketsOutPerSecond; }
            set { this._networkPacketsOutPerSecond = value; }
        }

        // Check to see if NetworkPacketsOutPerSecond property is set
        internal bool IsSetNetworkPacketsOutPerSecond()
        {
            return this._networkPacketsOutPerSecond != null;
        }

    }
}