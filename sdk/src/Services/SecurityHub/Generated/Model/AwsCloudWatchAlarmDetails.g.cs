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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies an alarm and associates it with the specified metric or metric math expression.
    /// </summary>
    public partial class AwsCloudWatchAlarmDetails
    {
        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether actions should be executed during any changes to the alarm state.
        /// 
        /// </para>
        /// </summary>
        public bool? ActionsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ActionsEnabled property is set.
        /// </summary>
        internal bool IsSetActionsEnabled() => this.ActionsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AlarmActions. 
        /// <para>
        /// The list of actions, specified as Amazon Resource Names (ARNs) to execute when this
        /// alarm transitions into an <c>ALARM</c> state from any other state. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlarmActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AlarmActions property is set.
        /// </summary>
        internal bool IsSetAlarmActions() => this.AlarmActions != null && (this.AlarmActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AlarmArn. 
        /// <para>
        /// The ARN of the alarm. 
        /// </para>
        /// </summary>
        public string AlarmArn { get; set; }

        /// <summary>
        /// Checks to see if the AlarmArn property is set.
        /// </summary>
        internal bool IsSetAlarmArn() => this.AlarmArn != null;

        /// <summary>
        /// Gets and sets the property AlarmConfigurationUpdatedTimestamp. 
        /// <para>
        /// The time stamp of the last update to the alarm configuration. 
        /// </para>
        /// </summary>
        public string AlarmConfigurationUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfigurationUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetAlarmConfigurationUpdatedTimestamp() => this.AlarmConfigurationUpdatedTimestamp != null;

        /// <summary>
        /// Gets and sets the property AlarmDescription. 
        /// <para>
        /// The description of the alarm. 
        /// </para>
        /// </summary>
        public string AlarmDescription { get; set; }

        /// <summary>
        /// Checks to see if the AlarmDescription property is set.
        /// </summary>
        internal bool IsSetAlarmDescription() => this.AlarmDescription != null;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm. If you don't specify a name, CloudFront generates a unique
        /// physical ID and uses that ID for the alarm name. 
        /// </para>
        /// </summary>
        public string AlarmName { get; set; }

        /// <summary>
        /// Checks to see if the AlarmName property is set.
        /// </summary>
        internal bool IsSetAlarmName() => this.AlarmName != null;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The arithmetic operation to use when comparing the specified statistic and threshold.
        /// The specified statistic value is used as the first operand. 
        /// </para>
        /// </summary>
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property DatapointsToAlarm. 
        /// <para>
        /// The number of datapoints that must be breaching to trigger the alarm. 
        /// </para>
        /// </summary>
        public int? DatapointsToAlarm { get; set; }

        /// <summary>
        /// Checks to see if the DatapointsToAlarm property is set.
        /// </summary>
        internal bool IsSetDatapointsToAlarm() => this.DatapointsToAlarm.HasValue;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions for the metric associated with the alarm. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCloudWatchAlarmDimensionsDetails> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCloudWatchAlarmDimensionsDetails>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluateLowSampleCountPercentile. 
        /// <para>
        /// Used only for alarms based on percentiles. If <c>ignore</c>, the alarm state does
        /// not change during periods with too few data points to be statistically significant.
        /// If <c>evaluate</c> or this parameter is not used, the alarm is always evaluated and
        /// possibly changes state no matter how many data points are available. 
        /// </para>
        /// </summary>
        public string EvaluateLowSampleCountPercentile { get; set; }

        /// <summary>
        /// Checks to see if the EvaluateLowSampleCountPercentile property is set.
        /// </summary>
        internal bool IsSetEvaluateLowSampleCountPercentile() => this.EvaluateLowSampleCountPercentile != null;

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// The number of periods over which data is compared to the specified threshold. 
        /// </para>
        /// </summary>
        public int? EvaluationPeriods { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationPeriods property is set.
        /// </summary>
        internal bool IsSetEvaluationPeriods() => this.EvaluationPeriods.HasValue;

        /// <summary>
        /// Gets and sets the property ExtendedStatistic. 
        /// <para>
        /// The percentile statistic for the metric associated with the alarm. 
        /// </para>
        /// </summary>
        public string ExtendedStatistic { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedStatistic property is set.
        /// </summary>
        internal bool IsSetExtendedStatistic() => this.ExtendedStatistic != null;

        /// <summary>
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>INSUFFICIENT_DATA</c>
        /// state from any other state. Each action is specified as an ARN. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InsufficientDataActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InsufficientDataActions property is set.
        /// </summary>
        internal bool IsSetInsufficientDataActions() => this.InsufficientDataActions != null && (this.InsufficientDataActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric associated with the alarm. This is required for an alarm based
        /// on a metric. For an alarm based on a math expression, you use <c>Metrics</c> instead
        /// and you can't specify <c>MetricName</c>. 
        /// </para>
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric associated with the alarm. This is required for an alarm
        /// based on a metric. For an alarm based on a math expression, you can't specify <c>Namespace</c>
        /// and you use <c>Metrics</c> instead. 
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property OkActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>OK</c> state from any
        /// other state. Each action is specified as an ARN. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OkActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OkActions property is set.
        /// </summary>
        internal bool IsSetOkActions() => this.OkActions != null && (this.OkActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period, in seconds, over which the statistic is applied. This is required for
        /// an alarm based on a metric. 
        /// </para>
        /// </summary>
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic for the metric associated with the alarm, other than percentile. For
        /// percentile statistics, use <c>ExtendedStatistic</c>.
        /// </para>
        ///  
        /// <para>
        /// For an alarm based on a metric, you must specify either <c>Statistic</c> or <c>ExtendedStatistic</c>
        /// but not both.
        /// </para>
        ///  
        /// <para>
        /// For an alarm based on a math expression, you can't specify <c>Statistic</c>. Instead,
        /// you use <c>Metrics</c>.
        /// </para>
        /// </summary>
        public string Statistic { get; set; }

        /// <summary>
        /// Checks to see if the Statistic property is set.
        /// </summary>
        internal bool IsSetStatistic() => this.Statistic != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value to compare with the specified statistic. 
        /// </para>
        /// </summary>
        public double? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property ThresholdMetricId. 
        /// <para>
        /// n an alarm based on an anomaly detection model, this is the ID of the <c>ANOMALY_DETECTION_BAND</c>
        /// function used as the threshold for the alarm. 
        /// </para>
        /// </summary>
        public string ThresholdMetricId { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdMetricId property is set.
        /// </summary>
        internal bool IsSetThresholdMetricId() => this.ThresholdMetricId != null;

        /// <summary>
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        /// Sets how this alarm is to handle missing data points. 
        /// </para>
        /// </summary>
        public string TreatMissingData { get; set; }

        /// <summary>
        /// Checks to see if the TreatMissingData property is set.
        /// </summary>
        internal bool IsSetTreatMissingData() => this.TreatMissingData != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the metric associated with the alarm. 
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
