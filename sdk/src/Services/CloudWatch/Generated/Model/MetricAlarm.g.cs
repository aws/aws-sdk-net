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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The details about a metric alarm.
    /// </summary>
    public partial class MetricAlarm
    {
        /// <summary>
        /// Gets and sets the property ActionConfiguration. 
        /// <para>
        /// Settings that change the content of the notifications and events that the alarm sends
        /// when its state changes. These settings apply to the alarm's actions, whichever state
        /// triggers them.
        /// </para>
        /// </summary>
        public ActionConfiguration ActionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ActionConfiguration property is set.
        /// </summary>
        internal bool IsSetActionConfiguration() => this.ActionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether actions should be executed during any changes to the alarm state.
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
        /// The actions to execute when this alarm transitions to the <c>ALARM</c> state from
        /// any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> AlarmActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AlarmActions property is set.
        /// </summary>
        internal bool IsSetAlarmActions() => this.AlarmActions != null && (this.AlarmActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AlarmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
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
        public DateTime? AlarmConfigurationUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfigurationUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetAlarmConfigurationUpdatedTimestamp() => this.AlarmConfigurationUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property AlarmDescription. 
        /// <para>
        /// The description of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// Checks to see if the AlarmDescription property is set.
        /// </summary>
        internal bool IsSetAlarmDescription() => this.AlarmDescription != null;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
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
        public ComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property DatapointsToAlarm. 
        /// <para>
        /// The number of data points that must be breaching to trigger the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
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
        [AWSProperty(Min = 0, Max = 30)]
        public List<Dimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

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
        [AWSProperty(Min = 1, Max = 255)]
        public string EvaluateLowSampleCountPercentile { get; set; }

        /// <summary>
        /// Checks to see if the EvaluateLowSampleCountPercentile property is set.
        /// </summary>
        internal bool IsSetEvaluateLowSampleCountPercentile() => this.EvaluateLowSampleCountPercentile != null;

        /// <summary>
        /// Gets and sets the property EvaluationCriteria. 
        /// <para>
        /// The evaluation criteria for the alarm.
        /// </para>
        /// </summary>
        public EvaluationCriteria EvaluationCriteria { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationCriteria property is set.
        /// </summary>
        internal bool IsSetEvaluationCriteria() => this.EvaluationCriteria != null;

        /// <summary>
        /// Gets and sets the property EvaluationInterval. 
        /// <para>
        /// The frequency, in seconds, at which the alarm is evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 3600)]
        public int? EvaluationInterval { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationInterval property is set.
        /// </summary>
        internal bool IsSetEvaluationInterval() => this.EvaluationInterval.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// The number of periods over which data is compared to the specified threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? EvaluationPeriods { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationPeriods property is set.
        /// </summary>
        internal bool IsSetEvaluationPeriods() => this.EvaluationPeriods.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationState. 
        /// <para>
        /// If the value of this field is <c>PARTIAL_DATA</c>, it indicates that not all the available
        /// data was able to be retrieved due to quota limitations. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Create_Metrics_Insights_Alarm.html">Create
        /// alarms on Metrics Insights queries</a>.
        /// </para>
        ///  
        /// <para>
        /// If the value of this field is <c>EVALUATION_ERROR</c>, it indicates configuration
        /// errors in alarm setup that require review and correction. Refer to StateReason field
        /// of the alarm for more details.
        /// </para>
        ///  
        /// <para>
        /// If the value of this field is <c>EVALUATION_FAILURE</c>, it indicates temporary CloudWatch
        /// issues. We recommend manual monitoring until the issue is resolved 
        /// </para>
        /// </summary>
        public EvaluationState EvaluationState { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationState property is set.
        /// </summary>
        internal bool IsSetEvaluationState() => this.EvaluationState != null;

        /// <summary>
        /// Gets and sets the property EvaluationWindow. 
        /// <para>
        /// The evaluation window that the alarm uses to select the range of metric data that
        /// it evaluates. This is either a sliding window or a wall clock window. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/alarm-evaluation-window.html">Alarm
        /// evaluation windows</a> in the <i>CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        public EvaluationWindow EvaluationWindow { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationWindow property is set.
        /// </summary>
        internal bool IsSetEvaluationWindow() => this.EvaluationWindow != null;

        /// <summary>
        /// Gets and sets the property ExtendedStatistic. 
        /// <para>
        /// The percentile statistic for the metric associated with the alarm. Specify a value
        /// between p0.0 and p100.
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
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> InsufficientDataActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InsufficientDataActions property is set.
        /// </summary>
        internal bool IsSetInsufficientDataActions() => this.InsufficientDataActions != null && (this.InsufficientDataActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric associated with the alarm, if this is an alarm based on a single
        /// metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// An array of MetricDataQuery structures, used in an alarm based on a metric math expression.
        /// Each structure either retrieves a metric or performs a math expression. One item in
        /// the Metrics array is the math expression that the alarm watches. This expression by
        /// designated by having <c>ReturnData</c> set to true.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDataQuery> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric associated with the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property OKActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>OK</c> state from any
        /// other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> OKActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OKActions property is set.
        /// </summary>
        internal bool IsSetOKActions() => this.OKActions != null && (this.OKActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period, in seconds, over which the statistic is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// An explanation for the alarm state, in text format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1023)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StateReasonData. 
        /// <para>
        /// An explanation for the alarm state, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4000)]
        public string StateReasonData { get; set; }

        /// <summary>
        /// Checks to see if the StateReasonData property is set.
        /// </summary>
        internal bool IsSetStateReasonData() => this.StateReasonData != null;

        /// <summary>
        /// Gets and sets the property StateTransitionedTimestamp. 
        /// <para>
        /// The date and time that the alarm's <c>StateValue</c> most recently changed.
        /// </para>
        /// </summary>
        public DateTime? StateTransitionedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StateTransitionedTimestamp property is set.
        /// </summary>
        internal bool IsSetStateTransitionedTimestamp() => this.StateTransitionedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StateUpdatedTimestamp. 
        /// <para>
        /// The time stamp of the last update to the value of either the <c>StateValue</c> or
        /// <c>EvaluationState</c> parameters.
        /// </para>
        /// </summary>
        public DateTime? StateUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StateUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetStateUpdatedTimestamp() => this.StateUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        /// The state value for the alarm.
        /// </para>
        /// </summary>
        public StateValue StateValue { get; set; }

        /// <summary>
        /// Checks to see if the StateValue property is set.
        /// </summary>
        internal bool IsSetStateValue() => this.StateValue != null;

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic for the metric associated with the alarm, other than percentile. For
        /// percentile statistics, use <c>ExtendedStatistic</c>.
        /// </para>
        /// </summary>
        public Statistic Statistic { get; set; }

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
        /// In an alarm based on an anomaly detection model, this is the ID of the <c>ANOMALY_DETECTION_BAND</c>
        /// function used as the threshold for the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ThresholdMetricId { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdMetricId property is set.
        /// </summary>
        internal bool IsSetThresholdMetricId() => this.ThresholdMetricId != null;

        /// <summary>
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        /// Sets how this alarm is to handle missing data points. The valid values are <c>breaching</c>,
        /// <c>notBreaching</c>, <c>ignore</c>, and <c>missing</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#alarms-and-missing-data">Configuring
        /// how CloudWatch alarms treat missing data</a>.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is omitted, the default behavior of <c>missing</c> is used.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not applicable to PromQL alarms.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
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
        public StandardUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property WarmUpConfiguration. 
        /// <para>
        /// The warm-up configuration for the alarm. A warm-up period delays alarm evaluation
        /// after you create or update the alarm. During the warm-up period, the alarm stays in
        /// <c>INSUFFICIENT_DATA</c> and does not perform alarm actions.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/alarm-warm-up.html">Alarm
        /// warm-up periods</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        public WarmUpConfiguration WarmUpConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WarmUpConfiguration property is set.
        /// </summary>
        internal bool IsSetWarmUpConfiguration() => this.WarmUpConfiguration != null;
    }
}
