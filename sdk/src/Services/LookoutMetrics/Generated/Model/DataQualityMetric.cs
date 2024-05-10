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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// An array that describes a data quality metric. Each <c>DataQualityMetric</c> object
    /// contains the data quality metric name, its value, a description of the metric, and
    /// the affected column.
    /// </summary>
    public partial class DataQualityMetric
    {
        private string _metricDescription;
        private DataQualityMetricType _metricType;
        private double? _metricValue;
        private string _relatedColumnName;

        /// <summary>
        /// Gets and sets the property MetricDescription. 
        /// <para>
        /// A description of the data quality metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MetricDescription
        {
            get { return this._metricDescription; }
            set { this._metricDescription = value; }
        }

        // Check to see if MetricDescription property is set
        internal bool IsSetMetricDescription()
        {
            return this._metricDescription != null;
        }

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// The name of the data quality metric.
        /// </para>
        /// </summary>
        public DataQualityMetricType MetricType
        {
            get { return this._metricType; }
            set { this._metricType = value; }
        }

        // Check to see if MetricType property is set
        internal bool IsSetMetricType()
        {
            return this._metricType != null;
        }

        /// <summary>
        /// Gets and sets the property MetricValue. 
        /// <para>
        /// The value of the data quality metric.
        /// </para>
        /// </summary>
        public double? MetricValue
        {
            get { return this._metricValue; }
            set { this._metricValue = value; }
        }

        // Check to see if MetricValue property is set
        internal bool IsSetMetricValue()
        {
            return this._metricValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedColumnName. 
        /// <para>
        /// The column that is being monitored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RelatedColumnName
        {
            get { return this._relatedColumnName; }
            set { this._relatedColumnName = value; }
        }

        // Check to see if RelatedColumnName property is set
        internal bool IsSetRelatedColumnName()
        {
            return this._relatedColumnName != null;
        }

    }
}