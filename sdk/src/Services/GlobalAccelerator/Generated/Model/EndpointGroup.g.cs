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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type for the endpoint group. An Amazon Web Services Region can have only
    /// one endpoint group for a specific listener.
    /// </summary>
    public partial class EndpointGroup
    {
        /// <summary>
        /// Gets and sets the property EndpointDescriptions. 
        /// <para>
        /// The list of endpoint objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EndpointDescription> EndpointDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<EndpointDescription>() : null;

        /// <summary>
        /// Checks to see if the EndpointDescriptions property is set.
        /// </summary>
        internal bool IsSetEndpointDescriptions() => this.EndpointDescriptions != null && (this.EndpointDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupArn property is set.
        /// </summary>
        internal bool IsSetEndpointGroupArn() => this.EndpointGroupArn != null;

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The Amazon Web Services Region where the endpoint group is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupRegion property is set.
        /// </summary>
        internal bool IsSetEndpointGroupRegion() => this.EndpointGroupRegion != null;

        /// <summary>
        /// Gets and sets the property HealthCheckIntervalSeconds. 
        /// <para>
        /// The time—10 seconds or 30 seconds—between health checks for each endpoint. The default
        /// value is 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 30)]
        public int? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckIntervalSeconds() => this.HealthCheckIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// If the protocol is HTTP/S, then this value provides the ping path that Global Accelerator
        /// uses for the destination on the endpoints for health checks. The default is slash
        /// (/).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPath property is set.
        /// </summary>
        internal bool IsSetHealthCheckPath() => this.HealthCheckPath != null;

        /// <summary>
        /// Gets and sets the property HealthCheckPort. 
        /// <para>
        /// The port that Global Accelerator uses to perform health checks on endpoints that are
        /// part of this endpoint group. 
        /// </para>
        ///  
        /// <para>
        /// The default port is the port for the listener that this endpoint group is associated
        /// with. If the listener port is a list, Global Accelerator uses the first specified
        /// port in the list of ports.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPort property is set.
        /// </summary>
        internal bool IsSetHealthCheckPort() => this.HealthCheckPort.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckProtocol. 
        /// <para>
        /// The protocol that Global Accelerator uses to perform health checks on endpoints that
        /// are part of this endpoint group. The default value is TCP.
        /// </para>
        /// </summary>
        public HealthCheckProtocol HealthCheckProtocol { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckProtocol property is set.
        /// </summary>
        internal bool IsSetHealthCheckProtocol() => this.HealthCheckProtocol != null;

        /// <summary>
        /// Gets and sets the property PortOverrides. 
        /// <para>
        /// Allows you to override the destination ports used to route traffic to an endpoint.
        /// Using a port override lets you map a list of external destination ports (that your
        /// users send traffic to) to a list of internal destination ports that you want an application
        /// endpoint to receive traffic on. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<PortOverride> PortOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<PortOverride>() : null;

        /// <summary>
        /// Checks to see if the PortOverrides property is set.
        /// </summary>
        internal bool IsSetPortOverrides() => this.PortOverrides != null && (this.PortOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThresholdCount. 
        /// <para>
        /// The number of consecutive health checks required to set the state of a healthy endpoint
        /// to unhealthy, or to set an unhealthy endpoint to healthy. The default value is 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? ThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdCount property is set.
        /// </summary>
        internal bool IsSetThresholdCount() => this.ThresholdCount.HasValue;

        /// <summary>
        /// Gets and sets the property TrafficDialPercentage. 
        /// <para>
        /// The percentage of traffic to send to an Amazon Web Services Region. Additional traffic
        /// is distributed to other endpoint groups for this listener. 
        /// </para>
        ///  
        /// <para>
        /// Use this action to increase (dial up) or decrease (dial down) traffic to a specific
        /// Region. The percentage is applied to the traffic that would otherwise have been routed
        /// to the Region based on optimal routing.
        /// </para>
        ///  
        /// <para>
        /// The default value is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? TrafficDialPercentage { get; set; }

        /// <summary>
        /// Checks to see if the TrafficDialPercentage property is set.
        /// </summary>
        internal bool IsSetTrafficDialPercentage() => this.TrafficDialPercentage.HasValue;
    }
}
