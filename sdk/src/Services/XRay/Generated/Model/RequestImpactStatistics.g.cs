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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Statistics that describe how the incident has impacted a service.
    /// </summary>
    public partial class RequestImpactStatistics
    {
        /// <summary>
        /// Gets and sets the property FaultCount. 
        /// <para>
        /// The number of requests that have resulted in a fault,
        /// </para>
        /// </summary>
        public long? FaultCount { get; set; }

        /// <summary>
        /// Checks to see if the FaultCount property is set.
        /// </summary>
        internal bool IsSetFaultCount() => this.FaultCount.HasValue;

        /// <summary>
        /// Gets and sets the property OkCount. 
        /// <para>
        /// The number of successful requests.
        /// </para>
        /// </summary>
        public long? OkCount { get; set; }

        /// <summary>
        /// Checks to see if the OkCount property is set.
        /// </summary>
        internal bool IsSetOkCount() => this.OkCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of requests to the service.
        /// </para>
        /// </summary>
        public long? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
