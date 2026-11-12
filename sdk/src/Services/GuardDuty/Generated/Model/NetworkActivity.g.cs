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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about network activity.
    /// </summary>
    public partial class NetworkActivity
    {
        /// <summary>
        /// Gets and sets the property Anomaly. 
        /// <para>
        /// Details about how the network activity deviates from normal behavior.
        /// </para>
        /// </summary>
        public NetworkAnomaly Anomaly { get; set; }

        /// <summary>
        /// Checks to see if the Anomaly property is set.
        /// </summary>
        internal bool IsSetAnomaly() => this.Anomaly != null;

        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether the network connection was blocked.
        /// </para>
        /// </summary>
        public string Blocked { get; set; }

        /// <summary>
        /// Checks to see if the Blocked property is set.
        /// </summary>
        internal bool IsSetBlocked() => this.Blocked != null;

        /// <summary>
        /// Gets and sets the property Counts. 
        /// <para>
        /// Counts that describe the network activity, such as the number of requests or connection
        /// attempts.
        /// </para>
        /// </summary>
        public NetworkCounts Counts { get; set; }

        /// <summary>
        /// Checks to see if the Counts property is set.
        /// </summary>
        internal bool IsSetCounts() => this.Counts != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of the network connection, such as inbound or outbound.
        /// </para>
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property Dns. 
        /// <para>
        /// DNS details about the network activity.
        /// </para>
        /// </summary>
        public DnsContext Dns { get; set; }

        /// <summary>
        /// Checks to see if the Dns property is set.
        /// </summary>
        internal bool IsSetDns() => this.Dns != null;

        /// <summary>
        /// Gets and sets the property Enrichment. 
        /// <para>
        /// Additional context about the network activity, such as geolocation and threat intelligence
        /// information.
        /// </para>
        /// </summary>
        public Enrichment Enrichment { get; set; }

        /// <summary>
        /// Checks to see if the Enrichment property is set.
        /// </summary>
        internal bool IsSetEnrichment() => this.Enrichment != null;

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The method that the network activity used.
        /// </para>
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform on which the network activity was observed.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// The ports that the network activity involved.
        /// </para>
        /// </summary>
        public NetworkPorts Ports { get; set; }

        /// <summary>
        /// Checks to see if the Ports property is set.
        /// </summary>
        internal bool IsSetPorts() => this.Ports != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network protocol of the activity.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// The amount of data that the network activity transferred.
        /// </para>
        /// </summary>
        public NetworkTraffic Traffic { get; set; }

        /// <summary>
        /// Checks to see if the Traffic property is set.
        /// </summary>
        internal bool IsSetTraffic() => this.Traffic != null;
    }
}
