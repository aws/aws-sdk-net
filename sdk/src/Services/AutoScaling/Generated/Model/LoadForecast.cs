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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// A <c>GetPredictiveScalingForecast</c> call returns the load forecast for a predictive
    /// scaling policy. This structure includes the data points for that load forecast, along
    /// with the timestamps of those data points and the metric specification.
    /// </summary>
    public partial class LoadForecast
    {
        private PredictiveScalingMetricSpecification _metricSpecification;
        private List<DateTime> _timestamps = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;
        private List<double> _values = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property MetricSpecification. 
        /// <para>
        /// The metric specification for the load forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PredictiveScalingMetricSpecification MetricSpecification
        {
            get { return this._metricSpecification; }
            set { this._metricSpecification = value; }
        }

        // Check to see if MetricSpecification property is set
        internal bool IsSetMetricSpecification()
        {
            return this._metricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        /// The timestamps for the data points, in UTC format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && (this._timestamps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the data points.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}