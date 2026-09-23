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
    /// Response statistics for a service.
    /// </summary>
    public partial class ServiceStatistics
    {
        /// <summary>
        /// Gets and sets the property ErrorStatistics. 
        /// <para>
        /// Information about requests that failed with a 4xx Client Error status code.
        /// </para>
        /// </summary>
        public ErrorStatistics ErrorStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ErrorStatistics property is set.
        /// </summary>
        internal bool IsSetErrorStatistics() => this.ErrorStatistics != null;

        /// <summary>
        /// Gets and sets the property FaultStatistics. 
        /// <para>
        /// Information about requests that failed with a 5xx Server Error status code.
        /// </para>
        /// </summary>
        public FaultStatistics FaultStatistics { get; set; }

        /// <summary>
        /// Checks to see if the FaultStatistics property is set.
        /// </summary>
        internal bool IsSetFaultStatistics() => this.FaultStatistics != null;

        /// <summary>
        /// Gets and sets the property OkCount. 
        /// <para>
        /// The number of requests that completed with a 2xx Success status code.
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
        /// The total number of completed requests.
        /// </para>
        /// </summary>
        public long? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResponseTime. 
        /// <para>
        /// The aggregate response time of completed requests.
        /// </para>
        /// </summary>
        public double? TotalResponseTime { get; set; }

        /// <summary>
        /// Checks to see if the TotalResponseTime property is set.
        /// </summary>
        internal bool IsSetTotalResponseTime() => this.TotalResponseTime.HasValue;
    }
}
