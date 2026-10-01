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

namespace Amazon.NetworkMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMonitor operation. Creates a monitor between
    /// a source subnet and destination IP address. Within a monitor you'll create one or
    /// more probes that monitor network traffic between your source Amazon Web Services VPC
    /// subnets and your destination IP addresses. Each probe then aggregates and sends metrics
    /// to Amazon CloudWatch. <para> You can also create a monitor with probes using this
    /// command. For each probe, you define the following: </para> <ul> <li> <para> <c>source</c>—The
    /// subnet IDs where the probes will be created. </para> </li> <li> <para> <c>destination</c>—
    /// The target destination IP address for the probe. </para> </li> <li> <para> <c>destinationPort</c>—Required
    /// only if the protocol is <c>TCP</c>. </para> </li> <li> <para> <c>protocol</c>—The
    /// communication protocol between the source and destination. This will be either <c>TCP</c>
    /// or <c>ICMP</c>. </para> </li> <li> <para> <c>packetSize</c>—The size of the packets.
    /// This must be a number between <c>56</c> and <c>8500</c>. </para> </li> <li> <para>
    /// (Optional) <c>tags</c> —Key-value pairs created and assigned to the probe. </para>
    /// </li> </ul>
    /// </summary>
    public partial class CreateMonitorRequest : AmazonNetworkMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property AggregationPeriod. 
        /// <para>
        /// The time, in seconds, that metrics are aggregated and sent to Amazon CloudWatch. Valid
        /// values are either <c>30</c> or <c>60</c>. <c>60</c> is the default if no period is
        /// chosen.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30)]
        public long? AggregationPeriod { get; set; }

        /// <summary>
        /// Checks to see if the AggregationPeriod property is set.
        /// </summary>
        internal bool IsSetAggregationPeriod() => this.AggregationPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure the idempotency of the request. Only returned
        /// if a client token was provided in the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name identifying the monitor. It can contain only letters, underscores (_), or
        /// dashes (-), and can be up to 200 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;

        /// <summary>
        /// Gets and sets the property Probes. 
        /// <para>
        /// Displays a list of all of the probes created for a monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateMonitorProbeInput> Probes { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateMonitorProbeInput>() : null;

        /// <summary>
        /// Checks to see if the Probes property is set.
        /// </summary>
        internal bool IsSetProbes() => this.Probes != null && (this.Probes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs created and assigned to the monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
