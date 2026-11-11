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
        public double? Average { get; set; }

        /// <summary>
        /// Checks to see if the Average property is set.
        /// </summary>
        internal bool IsSetAverage() => this.Average.HasValue;

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
        public double? MaxContributorValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxContributorValue property is set.
        /// </summary>
        internal bool IsSetMaxContributorValue() => this.MaxContributorValue.HasValue;

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
        public double? Maximum { get; set; }

        /// <summary>
        /// Checks to see if the Maximum property is set.
        /// </summary>
        internal bool IsSetMaximum() => this.Maximum.HasValue;

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
        public double? Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum.HasValue;

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
        public double? SampleCount { get; set; }

        /// <summary>
        /// Checks to see if the SampleCount property is set.
        /// </summary>
        internal bool IsSetSampleCount() => this.SampleCount.HasValue;

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
        public double? Sum { get; set; }

        /// <summary>
        /// Checks to see if the Sum property is set.
        /// </summary>
        internal bool IsSetSum() => this.Sum.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the data point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

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
        public double? UniqueContributors { get; set; }

        /// <summary>
        /// Checks to see if the UniqueContributors property is set.
        /// </summary>
        internal bool IsSetUniqueContributors() => this.UniqueContributors.HasValue;
    }
}
