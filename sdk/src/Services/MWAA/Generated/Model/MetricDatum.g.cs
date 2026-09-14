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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// <b>Internal only</b>. Collects Apache Airflow metrics. To learn more about the metrics
    /// published to Amazon CloudWatch, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/cw-metrics.html">Amazon
    /// MWAA performance metrics in Amazon CloudWatch</a>.
    /// </summary>
    [Obsolete("This type is for internal use and not meant for public use. Data set for this type will be ignored.")]
    public partial class MetricDatum
    {
        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        ///  <b>Internal only</b>. The dimensions associated with the metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  <b>Internal only</b>. The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property StatisticValues. 
        /// <para>
        ///  <b>Internal only</b>. The statistical values for the metric.
        /// </para>
        /// </summary>
        public StatisticSet StatisticValues { get; set; }

        /// <summary>
        /// Checks to see if the StatisticValues property is set.
        /// </summary>
        internal bool IsSetStatisticValues() => this.StatisticValues != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        ///  <b>Internal only</b>. The time the metric data was received, expressed as an ISO
        /// 8601 datetime string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  <b>Internal only</b>. The unit used to store the metric.
        /// </para>
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  <b>Internal only</b>. The value for the metric.
        /// </para>
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
