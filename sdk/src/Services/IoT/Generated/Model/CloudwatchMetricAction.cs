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
    /// Describes an action that captures a CloudWatch metric.
    /// </summary>
    public partial class CloudwatchMetricAction
    {
        private string _metricName;
        private string _metricNamespace;
        private string _metricTimestamp;
        private string _metricUnit;
        private string _metricValue;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The CloudWatch metric name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The CloudWatch metric namespace name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MetricTimestamp. 
        /// <para>
        /// An optional <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Unix
        /// timestamp</a>.
        /// </para>
        /// </summary>
        public string MetricTimestamp
        {
            get { return this._metricTimestamp; }
            set { this._metricTimestamp = value; }
        }

        // Check to see if MetricTimestamp property is set
        internal bool IsSetMetricTimestamp()
        {
            return this._metricTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property MetricUnit. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit">metric
        /// unit</a> supported by CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetricUnit
        {
            get { return this._metricUnit; }
            set { this._metricUnit = value; }
        }

        // Check to see if MetricUnit property is set
        internal bool IsSetMetricUnit()
        {
            return this._metricUnit != null;
        }

        /// <summary>
        /// Gets and sets the property MetricValue. 
        /// <para>
        /// The CloudWatch metric value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that allows access to the CloudWatch metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}