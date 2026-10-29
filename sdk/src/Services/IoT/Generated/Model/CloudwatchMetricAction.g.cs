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
    /// Describes an action that captures a CloudWatch metric.
    /// </summary>
    public partial class CloudwatchMetricAction
    {
        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The CloudWatch metric name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// The CloudWatch metric namespace name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetricNamespace { get; set; }

        /// <summary>
        /// Checks to see if the MetricNamespace property is set.
        /// </summary>
        internal bool IsSetMetricNamespace() => this.MetricNamespace != null;

        /// <summary>
        /// Gets and sets the property MetricTimestamp. 
        /// <para>
        /// An optional <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Unix
        /// timestamp</a>.
        /// </para>
        /// </summary>
        public string MetricTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the MetricTimestamp property is set.
        /// </summary>
        internal bool IsSetMetricTimestamp() => this.MetricTimestamp != null;

        /// <summary>
        /// Gets and sets the property MetricUnit. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Unit">metric
        /// unit</a> supported by CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetricUnit { get; set; }

        /// <summary>
        /// Checks to see if the MetricUnit property is set.
        /// </summary>
        internal bool IsSetMetricUnit() => this.MetricUnit != null;

        /// <summary>
        /// Gets and sets the property MetricValue. 
        /// <para>
        /// The CloudWatch metric value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetricValue { get; set; }

        /// <summary>
        /// Checks to see if the MetricValue property is set.
        /// </summary>
        internal bool IsSetMetricValue() => this.MetricValue != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that allows access to the CloudWatch metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
