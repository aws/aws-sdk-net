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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private BehaviorCriteria _criteria;
        private bool? _exportMetric;
        private string _metric;
        private MetricDimension _metricDimension;
        private string _name;
        private bool? _suppressAlerts;

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
        public BehaviorCriteria Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null;
        }

        /// <summary>
        /// Gets and sets the property ExportMetric. 
        /// <para>
        /// Value indicates exporting metrics related to the behavior when it is true.
        /// </para>
        /// </summary>
        public bool? ExportMetric
        {
            get { return this._exportMetric; }
            set { this._exportMetric = value; }
        }

        // Check to see if ExportMetric property is set
        internal bool IsSetExportMetric()
        {
            return this._exportMetric.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// What is measured by the behavior.
        /// </para>
        /// </summary>
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDimension. 
        /// <para>
        /// The dimension for a metric in your behavior. For example, using a <c>TOPIC_FILTER</c>
        /// dimension, you can narrow down the scope of the metric to only MQTT topics where the
        /// name matches the pattern specified in the dimension. This can't be used with custom
        /// metrics.
        /// </para>
        /// </summary>
        public MetricDimension MetricDimension
        {
            get { return this._metricDimension; }
            set { this._metricDimension = value; }
        }

        // Check to see if MetricDimension property is set
        internal bool IsSetMetricDimension()
        {
            return this._metricDimension != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name you've given to the behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SuppressAlerts. 
        /// <para>
        ///  Suppresses alerts. 
        /// </para>
        /// </summary>
        public bool? SuppressAlerts
        {
            get { return this._suppressAlerts; }
            set { this._suppressAlerts = value; }
        }

        // Check to see if SuppressAlerts property is set
        internal bool IsSetSuppressAlerts()
        {
            return this._suppressAlerts.HasValue; 
        }

    }
}