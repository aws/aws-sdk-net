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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEndpoint operation. Creates a global endpoint.
    /// Global endpoints improve your application's availability by making it regional-fault
    /// tolerant. To do this, you define a primary and secondary Region with event buses in
    /// each Region. You also create a Amazon Route 53 health check that will tell EventBridge
    /// to route events to the secondary Region when an "unhealthy" state is encountered and
    /// events will be routed back to the primary Region when the health check reports a "healthy"
    /// state.
    /// </summary>
    public partial class CreateEndpointRequest : AmazonEventBridgeRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the global endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBuses. 
        /// <para>
        /// Define the event buses used. 
        /// </para>
        ///  <important> 
        /// <para>
        /// The names of the event buses must be identical in each Region.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public List<EndpointEventBus> EventBuses { get; set; } = AWSConfigs.InitializeCollections ? new List<EndpointEventBus>() : null;

        /// <summary>
        /// Checks to see if the EventBuses property is set.
        /// </summary>
        internal bool IsSetEventBuses() => this.EventBuses != null && (this.EventBuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the global endpoint. For example, <c>"Name":"us-east-2-custom_bus_A-endpoint"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfig. 
        /// <para>
        /// Enable or disable event replication. The default state is <c>ENABLED</c> which means
        /// you must supply a <c>RoleArn</c>. If you don't have a <c>RoleArn</c> or you don't
        /// want event replication enabled, set the state to <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ReplicationConfig ReplicationConfig { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfig property is set.
        /// </summary>
        internal bool IsSetReplicationConfig() => this.ReplicationConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role used for replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RoutingConfig. 
        /// <para>
        /// Configure the routing policy, including the health check and secondary Region..
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutingConfig RoutingConfig { get; set; }

        /// <summary>
        /// Checks to see if the RoutingConfig property is set.
        /// </summary>
        internal bool IsSetRoutingConfig() => this.RoutingConfig != null;
    }
}
