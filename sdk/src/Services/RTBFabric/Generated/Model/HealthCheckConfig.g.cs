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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// The health check configuration for a managed endpoint. Defines how the service probes
    /// instances in the Auto Scaling group to determine their health status.
    /// </summary>
    public partial class HealthCheckConfig
    {
        /// <summary>
        /// Gets and sets the property HealthyThresholdCount. 
        /// <para>
        /// The number of consecutive successful health checks required before an instance is
        /// considered healthy. Valid range is 2 to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public int? HealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the HealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetHealthyThresholdCount() => this.HealthyThresholdCount.HasValue;

        /// <summary>
        /// Gets and sets the property IntervalSeconds. 
        /// <para>
        /// The interval between health check probes, in seconds. Valid range is 5 to 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 60)]
        public int? IntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IntervalSeconds property is set.
        /// </summary>
        internal bool IsSetIntervalSeconds() => this.IntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The destination path for the health check request. Must start with <c>/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port to use for health check probes. Valid range is 80 to 65535.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 80, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use for health check probes.
        /// </para>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property StatusCodeMatcher. 
        /// <para>
        /// The expected HTTP status code or status code pattern from healthy instances. Supports
        /// a single code (for example, <c>200</c>), a range (for example, <c>200-299</c>), or
        /// a comma-separated list (for example, <c>200,204</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string StatusCodeMatcher { get; set; }

        /// <summary>
        /// Checks to see if the StatusCodeMatcher property is set.
        /// </summary>
        internal bool IsSetStatusCodeMatcher() => this.StatusCodeMatcher != null;

        /// <summary>
        /// Gets and sets the property TimeoutMs. 
        /// <para>
        /// The timeout for each health check probe, in milliseconds. Valid range is 100 to 5000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 5000)]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMs property is set.
        /// </summary>
        internal bool IsSetTimeoutMs() => this.TimeoutMs.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyThresholdCount. 
        /// <para>
        /// The number of consecutive failed health checks required before an instance is considered
        /// unhealthy. Valid range is 2 to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public int? UnhealthyThresholdCount { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyThresholdCount property is set.
        /// </summary>
        internal bool IsSetUnhealthyThresholdCount() => this.UnhealthyThresholdCount.HasValue;
    }
}
