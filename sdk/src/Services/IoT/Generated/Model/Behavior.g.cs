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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// A Device Defender security profile behavior.
    /// </summary>
    public partial class Behavior
    {
        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The criteria that determine if a device is behaving normally in regard to the <c>metric</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the IoT console, you can choose to be sent an alert through Amazon SNS when IoT
        /// Device Defender detects that a device is behaving anomalously.
        /// </para>
        ///  </note>
        /// </summary>
        public BehaviorCriteria Criteria { get; set; }

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null;

        /// <summary>
        /// Gets and sets the property ExportMetric. 
        /// <para>
        /// Value indicates exporting metrics related to the behavior when it is true.
        /// </para>
        /// </summary>
        public bool? ExportMetric { get; set; }

        /// <summary>
        /// Checks to see if the ExportMetric property is set.
        /// </summary>
        internal bool IsSetExportMetric() => this.ExportMetric.HasValue;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// What is measured by the behavior.
        /// </para>
        /// </summary>
        public string Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property MetricDimension. 
        /// <para>
        /// The dimension for a metric in your behavior. For example, using a <c>TOPIC_FILTER</c>
        /// dimension, you can narrow down the scope of the metric to only MQTT topics where the
        /// name matches the pattern specified in the dimension. This can't be used with custom
        /// metrics.
        /// </para>
        /// </summary>
        public MetricDimension MetricDimension { get; set; }

        /// <summary>
        /// Checks to see if the MetricDimension property is set.
        /// </summary>
        internal bool IsSetMetricDimension() => this.MetricDimension != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name you've given to the behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SuppressAlerts. 
        /// <para>
        ///  Suppresses alerts. 
        /// </para>
        /// </summary>
        public bool? SuppressAlerts { get; set; }

        /// <summary>
        /// Checks to see if the SuppressAlerts property is set.
        /// </summary>
        internal bool IsSetSuppressAlerts() => this.SuppressAlerts.HasValue;
    }
}
