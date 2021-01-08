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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Indicates how to transform ingested log events to metric data in a CloudWatch metric.
    /// </summary>
    public partial class MetricTransformation
    {
        private double? _defaultValue;
        private string _metricName;
        private string _metricNamespace;
        private string _metricValue;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// (Optional) The value to emit when a filter pattern does not match a log event. This
        /// value can be null.
        /// </para>
        /// </summary>
        public double DefaultValue
        {
            get { return this._defaultValue.GetValueOrDefault(); }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the CloudWatch metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// A custom namespace to contain your metric in CloudWatch. Use namespaces to group together
        /// metrics that are similar. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html#Namespace">Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// Gets and sets the property MetricValue. 
        /// <para>
        /// The value to publish to the CloudWatch metric when a filter pattern matches a log
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public string MetricValue
        {
            get { return this._metricValue; }
            set { this._metricValue = value; }
        }

        // Check to see if MetricValue property is set
        internal bool IsSetMetricValue()
        {
            return this._metricValue != null;
        }

    }
}