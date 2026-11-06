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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the last failure reason as reported by one Amazon Route
    /// 53 health checker.
    /// </summary>
    public partial class HealthCheckObservation
    {
        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The region of the Amazon Route 53 health checker that provided the status in <c>StatusReport</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public HealthCheckRegion Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// The IP address of the Amazon Route 53 health checker that provided the failure reason
        /// in <c>StatusReport</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 45)]
        public string IPAddress { get; set; }

        /// <summary>
        /// Checks to see if the IPAddress property is set.
        /// </summary>
        internal bool IsSetIPAddress() => this.IPAddress != null;

        /// <summary>
        /// Gets and sets the property StatusReport. 
        /// <para>
        /// A complex type that contains the last failure reason as reported by one Amazon Route
        /// 53 health checker and the time of the failed health check.
        /// </para>
        /// </summary>
        public StatusReport StatusReport { get; set; }

        /// <summary>
        /// Checks to see if the StatusReport property is set.
        /// </summary>
        internal bool IsSetStatusReport() => this.StatusReport != null;
    }
}
