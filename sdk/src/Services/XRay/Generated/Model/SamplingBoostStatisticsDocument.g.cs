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
    /// Request anomaly stats for a single rule from a service. Results are for the last 10
    /// seconds unless the service has been assigned a longer reporting interval after a previous
    /// call to <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingTargets.html">GetSamplingTargets</a>.
    /// </summary>
    public partial class SamplingBoostStatisticsDocument
    {
        /// <summary>
        /// Gets and sets the property AnomalyCount. 
        /// <para>
        /// The number of requests with anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? AnomalyCount { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyCount property is set.
        /// </summary>
        internal bool IsSetAnomalyCount() => this.AnomalyCount.HasValue;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property SampledAnomalyCount. 
        /// <para>
        /// The number of requests with anomaly recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? SampledAnomalyCount { get; set; }

        /// <summary>
        /// Checks to see if the SampledAnomalyCount property is set.
        /// </summary>
        internal bool IsSetSampledAnomalyCount() => this.SampledAnomalyCount.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Matches the <c>name</c> that the service uses to identify itself in segments.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The current time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The number of requests that associated to the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
