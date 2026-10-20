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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// A summary of a gateway route that is returned by the <c>ListGatewayRoutes</c> operation.
    /// </summary>
    public partial class GatewayRouteSummary
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway.
        /// </para>
        /// </summary>
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property GatewayRouteArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway route.
        /// </para>
        /// </summary>
        public string GatewayRouteArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayRouteArn property is set.
        /// </summary>
        internal bool IsSetGatewayRouteArn() => this.GatewayRouteArn != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service.
        /// </para>
        /// </summary>
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceContainerPortName. 
        /// <para>
        /// The task definition container port name that the route targets on the service.
        /// </para>
        /// </summary>
        public string ServiceContainerPortName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceContainerPortName property is set.
        /// </summary>
        internal bool IsSetServiceContainerPortName() => this.ServiceContainerPortName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the gateway route.
        /// </para>
        /// </summary>
        public GatewayRouteStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
