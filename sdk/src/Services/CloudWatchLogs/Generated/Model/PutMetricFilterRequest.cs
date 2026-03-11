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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricFilter operation.
    /// Creates or updates a metric filter and associates it with the specified log group.
    /// With metric filters, you can configure rules to extract metric data from log events
    /// ingested through <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>.
    /// 
    ///  
    /// <para>
    /// The maximum number of metric filters that can be associated with a log group is 100.
    /// </para>
    ///  
    /// <para>
    /// Using regular expressions in filter patterns is supported. For these filters, there
    /// is a quota of two regular expression patterns within a single filter pattern. There
    /// is also a quota of five regular expression patterns per log group. For more information
    /// about using regular expressions in filter patterns, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">
    /// Filter pattern syntax for metric filters, subscription filters, filter log events,
    /// and Live Tail</a>.
    /// </para>
    ///  
    /// <para>
    /// When you create a metric filter, you can also optionally assign a unit and dimensions
    /// to the metric that is created.
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
    /// CloudWatch Logs might disable a metric filter if it generates 1,000 different name/value
    /// pairs for your specified dimensions within one hour.
    /// </para>
    ///  
    /// <para>
    /// You can also set up a billing alarm to alert you if your charges are higher than expected.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/monitor_estimated_charges_with_cloudwatch.html">
    /// Creating a Billing Alarm to Monitor Your Estimated Amazon Web Services Charges</a>.
    /// 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutMetricFilterRequest : AmazonCloudWatchLogsRequest
    {
        private bool? _applyOnTransformedLogs;
        private List<string> _emitSystemFieldDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _fieldSelectionCriteria;
        private string _filterName;
        private string _filterPattern;
        private string _logGroupName;
        private List<MetricTransformation> _metricTransformations = AWSConfigs.InitializeCollections ? new List<MetricTransformation>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutMetricFilterRequest() { }

        /// <summary>
        /// Instantiates PutMetricFilterRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        /// <param name="filterName">A name for the metric filter.</param>
        /// <param name="filterPattern">A filter pattern for extracting metric data out of ingested log events.</param>
        /// <param name="metricTransformations">A collection of information that defines how metric data gets emitted.</param>
        public PutMetricFilterRequest(string logGroupName, string filterName, string filterPattern, List<MetricTransformation> metricTransformations)
        {
            _logGroupName = logGroupName;
            _filterName = filterName;
            _filterPattern = filterPattern;
            _metricTransformations = metricTransformations;
        }

        /// <summary>
        /// Gets and sets the property ApplyOnTransformedLogs. 
        /// <para>
        /// This parameter is valid only for log groups that have an active log transformer. For
        /// more information about log transformers, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
        /// </para>
        ///  
        /// <para>
        /// If the log group uses either a log-group level or account-level transformer, and you
        /// specify <c>true</c>, the metric filter will be applied on the transformed version
        /// of the log events instead of the original ingested log events.
        /// </para>
        /// </summary>
        public bool? ApplyOnTransformedLogs
        {
            get { return this._applyOnTransformedLogs; }
            set { this._applyOnTransformedLogs = value; }
        }

        // Check to see if ApplyOnTransformedLogs property is set
        internal bool IsSetApplyOnTransformedLogs()
        {
            return this._applyOnTransformedLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmitSystemFieldDimensions. 
        /// <para>
        /// A list of system fields to emit as additional dimensions in the generated metrics.
        /// Valid values are <c>@aws.account</c> and <c>@aws.region</c>. These dimensions help
        /// identify the source of centralized log data and count toward the total dimension limit
        /// for metric filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EmitSystemFieldDimensions
        {
            get { return this._emitSystemFieldDimensions; }
            set { this._emitSystemFieldDimensions = value; }
        }

        // Check to see if EmitSystemFieldDimensions property is set
        internal bool IsSetEmitSystemFieldDimensions()
        {
            return this._emitSystemFieldDimensions != null && (this._emitSystemFieldDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldSelectionCriteria. 
        /// <para>
        /// A filter expression that specifies which log events should be processed by this metric
        /// filter based on system fields such as source account and source region. Uses selection
        /// criteria syntax with operators like <c>=</c>, <c>!=</c>, <c>AND</c>, <c>OR</c>, <c>IN</c>,
        /// <c>NOT IN</c>. Example: <c>@aws.region = "us-east-1"</c> or <c>@aws.account IN ["123456789012",
        /// "987654321098"]</c>. Maximum length: 2000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string FieldSelectionCriteria
        {
            get { return this._fieldSelectionCriteria; }
            set { this._fieldSelectionCriteria = value; }
        }

        // Check to see if FieldSelectionCriteria property is set
        internal bool IsSetFieldSelectionCriteria()
        {
            return this._fieldSelectionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// A name for the metric filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterPattern. 
        /// <para>
        /// A filter pattern for extracting metric data out of ingested log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricTransformations. 
        /// <para>
        /// A collection of information that defines how metric data gets emitted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<MetricTransformation> MetricTransformations
        {
            get { return this._metricTransformations; }
            set { this._metricTransformations = value; }
        }

        // Check to see if MetricTransformations property is set
        internal bool IsSetMetricTransformations()
        {
            return this._metricTransformations != null && (this._metricTransformations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}