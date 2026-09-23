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
    /// Temporary changes to a sampling rule configuration. To meet the global sampling target
    /// for a rule, X-Ray calculates a new reservoir for each service based on the recent
    /// sampling results of all services that called <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingTargets.html">GetSamplingTargets</a>.
    /// </summary>
    public partial class SamplingTargetDocument
    {
        /// <summary>
        /// Gets and sets the property FixedRate. 
        /// <para>
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// </para>
        /// </summary>
        public double? FixedRate { get; set; }

        /// <summary>
        /// Checks to see if the FixedRate property is set.
        /// </summary>
        internal bool IsSetFixedRate() => this.FixedRate.HasValue;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The number of seconds for the service to wait before getting sampling targets again.
        /// </para>
        /// </summary>
        public int? Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval.HasValue;

        /// <summary>
        /// Gets and sets the property ReservoirQuota. 
        /// <para>
        /// The number of requests per second that X-Ray allocated for this service.
        /// </para>
        /// </summary>
        public int? ReservoirQuota { get; set; }

        /// <summary>
        /// Checks to see if the ReservoirQuota property is set.
        /// </summary>
        internal bool IsSetReservoirQuota() => this.ReservoirQuota.HasValue;

        /// <summary>
        /// Gets and sets the property ReservoirQuotaTTL. 
        /// <para>
        /// When the reservoir quota expires.
        /// </para>
        /// </summary>
        public DateTime? ReservoirQuotaTTL { get; set; }

        /// <summary>
        /// Checks to see if the ReservoirQuotaTTL property is set.
        /// </summary>
        internal bool IsSetReservoirQuotaTTL() => this.ReservoirQuotaTTL.HasValue;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule.
        /// </para>
        /// </summary>
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property SamplingBoost. 
        /// <para>
        /// The sampling boost that X-Ray allocated for this service.
        /// </para>
        /// </summary>
        public SamplingBoost SamplingBoost { get; set; }

        /// <summary>
        /// Checks to see if the SamplingBoost property is set.
        /// </summary>
        internal bool IsSetSamplingBoost() => this.SamplingBoost != null;
    }
}
