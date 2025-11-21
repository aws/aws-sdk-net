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
    /// Request anomaly stats for a single rule from a service. Results are for the last 10
    /// seconds unless the service has been assigned a longer reporting interval after a previous
    /// call to <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingTargets.html">GetSamplingTargets</a>.
    /// </summary>
    public partial class SamplingBoostStatisticsDocument
    {
        private int? _anomalyCount;
        private string _ruleName;
        private int? _sampledAnomalyCount;
        private string _serviceName;
        private DateTime? _timestamp;
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property AnomalyCount. 
        /// <para>
        /// The number of requests with anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? AnomalyCount
        {
            get { return this._anomalyCount; }
            set { this._anomalyCount = value; }
        }

        // Check to see if AnomalyCount property is set
        internal bool IsSetAnomalyCount()
        {
            return this._anomalyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property SampledAnomalyCount. 
        /// <para>
        /// The number of requests with anomaly recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? SampledAnomalyCount
        {
            get { return this._sampledAnomalyCount; }
            set { this._sampledAnomalyCount = value; }
        }

        // Check to see if SampledAnomalyCount property is set
        internal bool IsSetSampledAnomalyCount()
        {
            return this._sampledAnomalyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Matches the <c>name</c> that the service uses to identify itself in segments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The current time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The number of requests that associated to the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? TotalCount
        {
            get { return this._totalCount; }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}