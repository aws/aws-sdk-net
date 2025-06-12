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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Information about the CloudWatch metric that reflects quota usage.
    /// </summary>
    public partial class MetricInfo
    {
        private Dictionary<string, string> _metricDimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _metricName;
        private string _metricNamespace;
        private string _metricStatisticRecommendation;

        /// <summary>
        /// Gets and sets the property MetricDimensions. 
        /// <para>
        /// The metric dimension. This is a name/value pair that is part of the identity of a
        /// metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public Dictionary<string, string> MetricDimensions
        {
            get { return this._metricDimensions; }
            set { this._metricDimensions = value; }
        }

        // Check to see if MetricDimensions property is set
        internal bool IsSetMetricDimensions()
        {
            return this._metricDimensions != null && (this._metricDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// The namespace of the metric.
        /// </para>
        /// </summary>
        public string MetricNamespace
        {
            get { return this._metricNamespace; }
            set { this._metricNamespace = value; }
        }

        // Check to see if MetricNamespace property is set
        internal bool IsSetMetricNamespace()
        {
            return this._metricNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property MetricStatisticRecommendation. 
        /// <para>
        /// The metric statistic that we recommend you use when determining quota usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MetricStatisticRecommendation
        {
            get { return this._metricStatisticRecommendation; }
            set { this._metricStatisticRecommendation = value; }
        }

        // Check to see if MetricStatisticRecommendation property is set
        internal bool IsSetMetricStatisticRecommendation()
        {
            return this._metricStatisticRecommendation != null;
        }

    }
}