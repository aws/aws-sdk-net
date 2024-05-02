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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// One data point from the metric time series returned in a Contributor Insights rule
    /// report.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetInsightRuleReport.html">GetInsightRuleReport</a>.
    /// </para>
    /// </summary>
    public partial class InsightRuleMetricDatapoint
    {
        private double? _average;
        private double? _maxContributorValue;
        private double? _maximum;
        private double? _minimum;
        private double? _sampleCount;
        private double? _sum;
        private DateTime? _timestamp;
        private double? _uniqueContributors;

        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The average value from all contributors during the time period represented by that
        /// data point.
        /// </para>
        ///  
        /// <para>
        /// This statistic is returned only if you included it in the <c>Metrics</c> array in
        /// your request.
        /// </para>
        /// </summary>
        public double? Average
        {
            get { return this._average; }
            set { this._average = value; }
        }

        // Check to see if Average property is set
        internal bool IsSetAverage()
        {
            return this._average.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxContributorValue. 
        /// <para>
        /// The maximum value provided by one contributor during this timestamp. Each timestamp
        /// is evaluated separately, so the identity of the max contributor could be different
        /// for each timestamp.
        /// </para>
        ///  
        /// <para>
        /// This statistic is returned only if you included it in the <c>Metrics</c> array in
        /// your request.
        /// </para>
        /// </summary>
        public double? MaxContributorValue
        {
            get { return this._maxContributorValue; }
            set { this._maxContributorValue = value; }
        }

        // Check to see if MaxContributorValue property is set
        internal bool IsSetMaxContributorValue()
        {
            return this._maxContributorValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum value from a single occurence from a single contributor during the time
        /// period represented by that data point.
        /// </para>
        ///  
        /// <para>
        /// This statistic is returned only if you included it in the <c>Metrics</c> array in
        /// your request.
        /// </para>
        /// </summary>
        public double? Maximum
        {
            get { return this._maximum; }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum value from a single contributor during the time period represented by
        /// that data point.
        /// </para>
        ///  
        /// <para>
        /// This statistic is returned only if you included it in the <c>Metrics</c> array in
        /// your request.
        /// </para>
        /// </summary>
        public double? Minimum
        {
            get { return this._minimum; }
            set { this._minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this._minimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleCount. 
        /// <para>
        /// The number of occurrences that matched the rule during this data point.
        /// </para>
        ///  
        /// <para>
        /// This statistic is returned only if you included it in the <c>Metrics</c> array in
        /// your request.
        /// </para>
        /// </summary>
        public double? SampleCount
        {
            get { return this._sampleCount; }
            set { this._sampleCount = value; }
        }

        // Check to see if SampleCount property is set
        internal bool IsSetSampleCount()
        {
            return this._sampleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the values from all contributors during the time period represented by
        /// that data point.
        /// </para>
        ///  
        /// <para>
        /// This statistic is returned only if you included it in the <c>Metrics</c> array in
        /// your request.
        /// </para>
        /// </summary>
        public double? Sum
        {
            get { return this._sum; }
            set { this._sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this._sum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the data point.
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
        /// Gets and sets the property UniqueContributors. 
        /// <para>
        /// The number of unique contributors who published data during this timestamp.
        /// </para>
        ///  
        /// <para>
        /// This statistic is returned only if you included it in the <c>Metrics</c> array in
        /// your request.
        /// </para>
        /// </summary>
        public double? UniqueContributors
        {
            get { return this._uniqueContributors; }
            set { this._uniqueContributors = value; }
        }

        // Check to see if UniqueContributors property is set
        internal bool IsSetUniqueContributors()
        {
            return this._uniqueContributors.HasValue; 
        }

    }
}