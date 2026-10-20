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
    /// The health check configuration that a gateway uses to evaluate the targets associated
    /// with a gateway connector.
    /// </summary>
    public partial class GatewayConnectorHealthCheck
    {
        /// <summary>
        /// Gets and sets the property HealthCheckIntervalSeconds. 
        /// <para>
        /// The approximate amount of time, in seconds, between health checks of an individual
        /// target.
        /// </para>
        /// </summary>
        public int? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckIntervalSeconds() => this.HealthCheckIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// The destination path for health check requests.
        /// </para>
        /// </summary>
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPath property is set.
        /// </summary>
        internal bool IsSetHealthCheckPath() => this.HealthCheckPath != null;

        /// <summary>
        /// Gets and sets the property HealthCheckPort. 
        /// <para>
        /// The port that the gateway uses to perform health checks on the targets.
        /// </para>
        /// </summary>
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPort property is set.
        /// </summary>
        internal bool IsSetHealthCheckPort() => this.HealthCheckPort.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckProtocol. 
        /// <para>
        /// The protocol that the gateway uses to perform health checks.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HTTP</c> - Health checks are performed over HTTP.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTPS</c> - Health checks are performed over HTTPS.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GatewayConnectorHealthCheckProtocol HealthCheckProtocol { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckProtocol property is set.
        /// </summary>
        internal bool IsSetHealthCheckProtocol() => this.HealthCheckProtocol != null;

        /// <summary>
        /// Gets and sets the property HealthCheckTimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, during which no response from a target means a failed
        /// health check.
        /// </para>
        /// </summary>
        public int? HealthCheckTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckTimeoutSeconds() => this.HealthCheckTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HealthyThresholdCount. 
        /// <para>
        /// The number of consecutive successful health checks that a target must pass before
        /// the gateway considers it healthy.
        /// </para>
        /// </summary>
        public int? HealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the HealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetHealthyThresholdCount() => this.HealthyThresholdCount.HasValue;

        /// <summary>
        /// Gets and sets the property Matcher. 
        /// <para>
        /// The HTTP or gRPC codes that indicate a successful health check response from a target.
        /// </para>
        /// </summary>
        public GatewayConnectorHealthCheckMatcher Matcher { get; set; }

        /// <summary>
        /// Checks to see if the Matcher property is set.
        /// </summary>
        internal bool IsSetMatcher() => this.Matcher != null;

        /// <summary>
        /// Gets and sets the property UnhealthyThresholdCount. 
        /// <para>
        /// The number of consecutive failed health checks that a target must fail before the
        /// gateway considers it unhealthy.
        /// </para>
        /// </summary>
        public int? UnhealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetUnhealthyThresholdCount() => this.UnhealthyThresholdCount.HasValue;
    }
}
