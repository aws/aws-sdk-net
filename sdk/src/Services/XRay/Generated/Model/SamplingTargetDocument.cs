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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
        private double? _fixedRate;
        private int? _interval;
        private int? _reservoirQuota;
        private DateTime? _reservoirQuotaTTL;
        private string _ruleName;
        private SamplingBoost _samplingBoost;

        /// <summary>
        /// Gets and sets the property FixedRate. 
        /// <para>
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// </para>
        /// </summary>
        public double? FixedRate
        {
            get { return this._fixedRate; }
            set { this._fixedRate = value; }
        }

        // Check to see if FixedRate property is set
        internal bool IsSetFixedRate()
        {
            return this._fixedRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The number of seconds for the service to wait before getting sampling targets again.
        /// </para>
        /// </summary>
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservoirQuota. 
        /// <para>
        /// The number of requests per second that X-Ray allocated for this service.
        /// </para>
        /// </summary>
        public int? ReservoirQuota
        {
            get { return this._reservoirQuota; }
            set { this._reservoirQuota = value; }
        }

        // Check to see if ReservoirQuota property is set
        internal bool IsSetReservoirQuota()
        {
            return this._reservoirQuota.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservoirQuotaTTL. 
        /// <para>
        /// When the reservoir quota expires.
        /// </para>
        /// </summary>
        public DateTime? ReservoirQuotaTTL
        {
            get { return this._reservoirQuotaTTL; }
            set { this._reservoirQuotaTTL = value; }
        }

        // Check to see if ReservoirQuotaTTL property is set
        internal bool IsSetReservoirQuotaTTL()
        {
            return this._reservoirQuotaTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule.
        /// </para>
        /// </summary>
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property SamplingBoost. 
        /// <para>
        /// The sampling boost that X-Ray allocated for this service.
        /// </para>
        /// </summary>
        public SamplingBoost SamplingBoost
        {
            get { return this._samplingBoost; }
            set { this._samplingBoost = value; }
        }

        // Check to see if SamplingBoost property is set
        internal bool IsSetSamplingBoost()
        {
            return this._samplingBoost != null;
        }

    }
}