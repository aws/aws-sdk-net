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
    /// Metric filters express how CloudWatch Logs would extract metric observations from
    /// ingested log events and transform them into metric data in a CloudWatch metric.
    /// </summary>
    public partial class MetricFilter
    {
        /// <summary>
        /// Gets and sets the property ApplyOnTransformedLogs. 
        /// <para>
        /// This parameter is valid only for log groups that have an active log transformer. For
        /// more information about log transformers, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
        /// </para>
        ///  
        /// <para>
        /// If this value is <c>true</c>, the metric filter is applied on the transformed version
        /// of the log events instead of the original ingested log events.
        /// </para>
        /// </summary>
        public bool? ApplyOnTransformedLogs { get; set; }

        /// <summary>
        /// Checks to see if the ApplyOnTransformedLogs property is set.
        /// </summary>
        internal bool IsSetApplyOnTransformedLogs() => this.ApplyOnTransformedLogs.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the metric filter, expressed as the number of milliseconds after
        /// <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EmitSystemFieldDimensions. 
        /// <para>
        /// The list of system fields that are emitted as additional dimensions in the generated
        /// metrics. Returns the <c>emitSystemFieldDimensions</c> value if it was specified when
        /// the metric filter was created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EmitSystemFieldDimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EmitSystemFieldDimensions property is set.
        /// </summary>
        internal bool IsSetEmitSystemFieldDimensions() => this.EmitSystemFieldDimensions != null && (this.EmitSystemFieldDimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FieldSelectionCriteria. 
        /// <para>
        /// The filter expression that specifies which log events are processed by this metric
        /// filter based on system fields. Returns the <c>fieldSelectionCriteria</c> value if
        /// it was specified when the metric filter was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string FieldSelectionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FieldSelectionCriteria property is set.
        /// </summary>
        internal bool IsSetFieldSelectionCriteria() => this.FieldSelectionCriteria != null;

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The name of the metric filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FilterName { get; set; }

        /// <summary>
        /// Checks to see if the FilterName property is set.
        /// </summary>
        internal bool IsSetFilterName() => this.FilterName != null;

        /// <summary>
        /// Gets and sets the property FilterPattern.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// Checks to see if the FilterPattern property is set.
        /// </summary>
        internal bool IsSetFilterPattern() => this.FilterPattern != null;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property MetricTransformations. 
        /// <para>
        /// The metric transformations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<MetricTransformation> MetricTransformations { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricTransformation>() : null;

        /// <summary>
        /// Checks to see if the MetricTransformations property is set.
        /// </summary>
        internal bool IsSetMetricTransformations() => this.MetricTransformations != null && (this.MetricTransformations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
