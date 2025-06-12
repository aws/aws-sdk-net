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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
    /// Container for the parameters to the CreateEndpointGroup operation.
    /// Create an endpoint group for the specified listener. An endpoint group is a collection
    /// of endpoints in one Amazon Web Services Region. A resource must be valid and active
    /// when you add it as an endpoint.
    /// 
    ///  
    /// <para>
    /// For more information about endpoint types and requirements for endpoints that you
    /// can add to Global Accelerator, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/about-endpoints.html">
    /// Endpoints for standard accelerators</a> in the <i>Global Accelerator Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateEndpointGroupRequest : AmazonGlobalAcceleratorRequest
    {
        private List<EndpointConfiguration> _endpointConfigurations = AWSConfigs.InitializeCollections ? new List<EndpointConfiguration>() : null;
        private string _endpointGroupRegion;
        private int? _healthCheckIntervalSeconds;
        private string _healthCheckPath;
        private int? _healthCheckPort;
        private HealthCheckProtocol _healthCheckProtocol;
        private string _idempotencyToken;
        private string _listenerArn;
        private List<PortOverride> _portOverrides = AWSConfigs.InitializeCollections ? new List<PortOverride>() : null;
        private int? _thresholdCount;
        private float? _trafficDialPercentage;

        /// <summary>
        /// Gets and sets the property EndpointConfigurations. 
        /// <para>
        /// The list of endpoint objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<EndpointConfiguration> EndpointConfigurations
        {
            get { return this._endpointConfigurations; }
            set { this._endpointConfigurations = value; }
        }

        // Check to see if EndpointConfigurations property is set
        internal bool IsSetEndpointConfigurations()
        {
            return this._endpointConfigurations != null && (this._endpointConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The Amazon Web Services Region where the endpoint group is located. A listener can
        /// have only one endpoint group in a specific Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string EndpointGroupRegion
        {
            get { return this._endpointGroupRegion; }
            set { this._endpointGroupRegion = value; }
        }

        // Check to see if EndpointGroupRegion property is set
        internal bool IsSetEndpointGroupRegion()
        {
            return this._endpointGroupRegion != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckIntervalSeconds. 
        /// <para>
        /// The time—10 seconds or 30 seconds—between each health check for an endpoint. The default
        /// value is 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=30)]
        public int? HealthCheckIntervalSeconds
        {
            get { return this._healthCheckIntervalSeconds; }
            set { this._healthCheckIntervalSeconds = value; }
        }

        // Check to see if HealthCheckIntervalSeconds property is set
        internal bool IsSetHealthCheckIntervalSeconds()
        {
            return this._healthCheckIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// If the protocol is HTTP/S, then this specifies the path that is the destination for
        /// health check targets. The default value is slash (/).
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string HealthCheckPath
        {
            get { return this._healthCheckPath; }
            set { this._healthCheckPath = value; }
        }

        // Check to see if HealthCheckPath property is set
        internal bool IsSetHealthCheckPath()
        {
            return this._healthCheckPath != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckPort. 
        /// <para>
        /// The port that Global Accelerator uses to check the health of endpoints that are part
        /// of this endpoint group. The default port is the listener port that this endpoint group
        /// is associated with. If listener port is a list of ports, Global Accelerator uses the
        /// first port in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? HealthCheckPort
        {
            get { return this._healthCheckPort; }
            set { this._healthCheckPort = value; }
        }

        // Check to see if HealthCheckPort property is set
        internal bool IsSetHealthCheckPort()
        {
            return this._healthCheckPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckProtocol. 
        /// <para>
        /// The protocol that Global Accelerator uses to check the health of endpoints that are
        /// part of this endpoint group. The default value is TCP.
        /// </para>
        /// </summary>
        public HealthCheckProtocol HealthCheckProtocol
        {
            get { return this._healthCheckProtocol; }
            set { this._healthCheckProtocol = value; }
        }

        // Check to see if HealthCheckProtocol property is set
        internal bool IsSetHealthCheckProtocol()
        {
            return this._healthCheckProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency—that
        /// is, the uniqueness—of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortOverrides. 
        /// <para>
        /// Override specific listener ports used to route traffic to endpoints that are part
        /// of this endpoint group. For example, you can create a port override in which the listener
        /// receives user traffic on ports 80 and 443, but your accelerator routes that traffic
        /// to ports 1080 and 1443, respectively, on the endpoints.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/about-endpoint-groups-port-override.html">
        /// Overriding listener ports</a> in the <i>Global Accelerator Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<PortOverride> PortOverrides
        {
            get { return this._portOverrides; }
            set { this._portOverrides = value; }
        }

        // Check to see if PortOverrides property is set
        internal bool IsSetPortOverrides()
        {
            return this._portOverrides != null && (this._portOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThresholdCount. 
        /// <para>
        /// The number of consecutive health checks required to set the state of a healthy endpoint
        /// to unhealthy, or to set an unhealthy endpoint to healthy. The default value is 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? ThresholdCount
        {
            get { return this._thresholdCount; }
            set { this._thresholdCount = value; }
        }

        // Check to see if ThresholdCount property is set
        internal bool IsSetThresholdCount()
        {
            return this._thresholdCount.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=100)]
        public float? TrafficDialPercentage
        {
            get { return this._trafficDialPercentage; }
            set { this._trafficDialPercentage = value; }
        }

        // Check to see if TrafficDialPercentage property is set
        internal bool IsSetTrafficDialPercentage()
        {
            return this._trafficDialPercentage.HasValue; 
        }

    }
}