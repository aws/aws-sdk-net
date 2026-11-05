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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the health check configuration of an Amazon Lightsail container service.
    /// </summary>
    public partial class ContainerServiceHealthCheckConfig
    {
        /// <summary>
        /// Gets and sets the property HealthyThreshold. 
        /// <para>
        /// The number of consecutive health checks successes required before moving the container
        /// to the <c>Healthy</c> state. The default value is <c>2</c>.
        /// </para>
        /// </summary>
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// Checks to see if the HealthyThreshold property is set.
        /// </summary>
        internal bool IsSetHealthyThreshold() => this.HealthyThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property IntervalSeconds. 
        /// <para>
        /// The approximate interval, in seconds, between health checks of an individual container.
        /// You can specify between 5 and 300 seconds. The default value is <c>5</c>.
        /// </para>
        /// </summary>
        public int? IntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IntervalSeconds property is set.
        /// </summary>
        internal bool IsSetIntervalSeconds() => this.IntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path on the container on which to perform the health check. The default value
        /// is <c>/</c>.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property SuccessCodes. 
        /// <para>
        /// The HTTP codes to use when checking for a successful response from a container. You
        /// can specify values between <c>200</c> and <c>499</c>. You can specify multiple values
        /// (for example, <c>200,202</c>) or a range of values (for example, <c>200-299</c>).
        /// </para>
        /// </summary>
        public string SuccessCodes { get; set; }

        /// <summary>
        /// Checks to see if the SuccessCodes property is set.
        /// </summary>
        internal bool IsSetSuccessCodes() => this.SuccessCodes != null;

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, during which no response means a failed health check.
        /// You can specify between 2 and 60 seconds. The default value is <c>2</c>.
        /// </para>
        /// </summary>
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyThreshold. 
        /// <para>
        /// The number of consecutive health check failures required before moving the container
        /// to the <c>Unhealthy</c> state. The default value is <c>2</c>.
        /// </para>
        /// </summary>
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyThreshold property is set.
        /// </summary>
        internal bool IsSetUnhealthyThreshold() => this.UnhealthyThreshold.HasValue;
    }
}
