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
    /// A gateway connector that attaches an Amazon ECS service to a gateway ingress path.
    /// The connector specifies the service port that receives gateway-managed ingress traffic,
    /// along with the health check and traffic filters that the gateway applies. A service
    /// can have at most one gateway connector.
    /// </summary>
    public partial class GatewayConnector
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters that control which gateway ingress paths the connector applies to.
        /// </para>
        /// </summary>
        public GatewayConnectorFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The health check that the gateway uses to determine whether the targets for this connector
        /// are healthy.
        /// </para>
        /// </summary>
        public GatewayConnectorHealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

        /// <summary>
        /// Gets and sets the property PortName. 
        /// <para>
        /// The name of the service port that the gateway routes ingress traffic to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PortName { get; set; }

        /// <summary>
        /// Checks to see if the PortName property is set.
        /// </summary>
        internal bool IsSetPortName() => this.PortName != null;
    }
}
