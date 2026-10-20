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
    /// A gateway-managed connection for a service revision. A connection represents the association
    /// between the service's gateway connector and a specific gateway, along with the infrastructure
    /// that the gateway created for it.
    /// </summary>
    public partial class GatewayConnection
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The access type of the gateway ingress path.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PUBLIC</c> - The ingress path is publicly accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRIVATE</c> - The ingress path is only accessible privately.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

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
        /// The Amazon Resource Name (ARN) of the gateway route for the connection.
        /// </para>
        /// </summary>
        public string GatewayRouteArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayRouteArn property is set.
        /// </summary>
        internal bool IsSetGatewayRouteArn() => this.GatewayRouteArn != null;

        /// <summary>
        /// Gets and sets the property PortName. 
        /// <para>
        /// The name of the service port that receives gateway-managed ingress traffic.
        /// </para>
        /// </summary>
        public string PortName { get; set; }

        /// <summary>
        /// Checks to see if the PortName property is set.
        /// </summary>
        internal bool IsSetPortName() => this.PortName != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The gateway-managed infrastructure resources for the connection.
        /// </para>
        /// </summary>
        public GatewayConnectionResources Resources { get; set; }

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null;

        /// <summary>
        /// Gets and sets the property ServiceUrl. 
        /// <para>
        /// The URL that the gateway uses to route ingress traffic to the service.
        /// </para>
        /// </summary>
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUrl property is set.
        /// </summary>
        internal bool IsSetServiceUrl() => this.ServiceUrl != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the gateway route for the connection.
        /// </para>
        /// </summary>
        public GatewayRouteStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
