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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that displays the definition of one extended metric that RUM sends to
    /// CloudWatch or CloudWatch Evidently. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-vended-metrics.html">
    /// Additional metrics that you can send to CloudWatch and CloudWatch Evidently</a>.
    /// </summary>
    public partial class MetricDefinition
    {
        /// <summary>
        /// Gets and sets the property DimensionKeys. 
        /// <para>
        /// This field is a map of field paths to dimension names. It defines the dimensions to
        /// associate with this metric in CloudWatch The value of this field is used only if the
        /// metric destination is <c>CloudWatch</c>. If the metric destination is <c>Evidently</c>,
        /// the value of <c>DimensionKeys</c> is ignored.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 29)]
        public Dictionary<string, string> DimensionKeys { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DimensionKeys property is set.
        /// </summary>
        internal bool IsSetDimensionKeys() => this.DimensionKeys != null && (this.DimensionKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The pattern that defines the metric. RUM checks events that happen in a user's session
        /// against the pattern, and events that match the pattern are sent to the metric destination.
        /// </para>
        ///  
        /// <para>
        /// If the metrics destination is <c>CloudWatch</c> and the event also matches a value
        /// in <c>DimensionKeys</c>, then the metric is published with the specified dimensions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4000)]
        public string EventPattern { get; set; }

        /// <summary>
        /// Checks to see if the EventPattern property is set.
        /// </summary>
        internal bool IsSetEventPattern() => this.EventPattern != null;

        /// <summary>
        /// Gets and sets the property MetricDefinitionId. 
        /// <para>
        /// The ID of this metric definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MetricDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the MetricDefinitionId property is set.
        /// </summary>
        internal bool IsSetMetricDefinitionId() => this.MetricDefinitionId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric that is defined in this structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// If this metric definition is for a custom metric instead of an extended metric, this
        /// field displays the metric namespace that the custom metric is published to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 237)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property UnitLabel. 
        /// <para>
        /// Use this field only if you are sending this metric to CloudWatch. It defines the CloudWatch
        /// metric unit that this metric is measured in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UnitLabel { get; set; }

        /// <summary>
        /// Checks to see if the UnitLabel property is set.
        /// </summary>
        internal bool IsSetUnitLabel() => this.UnitLabel != null;

        /// <summary>
        /// Gets and sets the property ValueKey. 
        /// <para>
        /// The field within the event object that the metric value is sourced from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 280)]
        public string ValueKey { get; set; }

        /// <summary>
        /// Checks to see if the ValueKey property is set.
        /// </summary>
        internal bool IsSetValueKey() => this.ValueKey != null;
    }
}
