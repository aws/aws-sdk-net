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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Indicates how to transform ingested log events to metric data in a CloudWatch metric.
    /// </summary>
    public partial class MetricTransformation
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// (Optional) The value to emit when a filter pattern does not match a log event. This
        /// value can be null.
        /// </para>
        /// </summary>
        public double? DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue.HasValue;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The fields to use as dimensions for the metric. One metric filter can include as many
        /// as three dimensions.
        /// </para>
        ///  <important> 
        /// <para>
        /// Metrics extracted from log events are charged as custom metrics. To prevent unexpected
        /// high charges, do not specify high-cardinality fields such as <c>IPAddress</c> or <c>requestID</c>
        /// as dimensions. Each different value found for a dimension is treated as a separate
        /// metric and accrues charges as a separate custom metric. 
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs disables a metric filter if it generates 1000 different name/value
        /// pairs for your specified dimensions within a certain amount of time. This helps to
        /// prevent accidental high charges.
        /// </para>
        ///  
        /// <para>
        /// You can also set up a billing alarm to alert you if your charges are higher than expected.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/monitor_estimated_charges_with_cloudwatch.html">
        /// Creating a Billing Alarm to Monitor Your Estimated Amazon Web Services Charges</a>.
        /// 
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the CloudWatch metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// A custom namespace to contain your metric in CloudWatch. Use namespaces to group together
        /// metrics that are similar. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html#Namespace">Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string MetricNamespace { get; set; }

        /// <summary>
        /// Checks to see if the MetricNamespace property is set.
        /// </summary>
        internal bool IsSetMetricNamespace() => this.MetricNamespace != null;

        /// <summary>
        /// Gets and sets the property MetricValue. 
        /// <para>
        /// The value to publish to the CloudWatch metric when a filter pattern matches a log
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public string MetricValue { get; set; }

        /// <summary>
        /// Checks to see if the MetricValue property is set.
        /// </summary>
        internal bool IsSetMetricValue() => this.MetricValue != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit to assign to the metric. If you omit this, the unit is set as <c>None</c>.
        /// </para>
        /// </summary>
        public StandardUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
