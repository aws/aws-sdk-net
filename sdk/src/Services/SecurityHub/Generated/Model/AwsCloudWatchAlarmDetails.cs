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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private bool? _actionsEnabled;
        private List<string> _alarmActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _alarmArn;
        private string _alarmConfigurationUpdatedTimestamp;
        private string _alarmDescription;
        private string _alarmName;
        private string _comparisonOperator;
        private int? _datapointsToAlarm;
        private List<AwsCloudWatchAlarmDimensionsDetails> _dimensions = AWSConfigs.InitializeCollections ? new List<AwsCloudWatchAlarmDimensionsDetails>() : null;
        private string _evaluateLowSampleCountPercentile;
        private int? _evaluationPeriods;
        private string _extendedStatistic;
        private List<string> _insufficientDataActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _metricName;
        private string _awsNamespace;
        private List<string> _okActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _period;
        private string _statistic;
        private double? _threshold;
        private string _thresholdMetricId;
        private string _treatMissingData;
        private string _unit;

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether actions should be executed during any changes to the alarm state.
        /// 
        /// </para>
        /// </summary>
        public bool? ActionsEnabled
        {
            get { return this._actionsEnabled; }
            set { this._actionsEnabled = value; }
        }

        // Check to see if ActionsEnabled property is set
        internal bool IsSetActionsEnabled()
        {
            return this._actionsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlarmActions. 
        /// <para>
        /// The list of actions, specified as Amazon Resource Names (ARNs) to execute when this
        /// alarm transitions into an <c>ALARM</c> state from any other state. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlarmActions
        {
            get { return this._alarmActions; }
            set { this._alarmActions = value; }
        }

        // Check to see if AlarmActions property is set
        internal bool IsSetAlarmActions()
        {
            return this._alarmActions != null && (this._alarmActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AlarmArn. 
        /// <para>
        /// The ARN of the alarm. 
        /// </para>
        /// </summary>
        public string AlarmArn
        {
            get { return this._alarmArn; }
            set { this._alarmArn = value; }
        }

        // Check to see if AlarmArn property is set
        internal bool IsSetAlarmArn()
        {
            return this._alarmArn != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmConfigurationUpdatedTimestamp. 
        /// <para>
        /// The time stamp of the last update to the alarm configuration. 
        /// </para>
        /// </summary>
        public string AlarmConfigurationUpdatedTimestamp
        {
            get { return this._alarmConfigurationUpdatedTimestamp; }
            set { this._alarmConfigurationUpdatedTimestamp = value; }
        }

        // Check to see if AlarmConfigurationUpdatedTimestamp property is set
        internal bool IsSetAlarmConfigurationUpdatedTimestamp()
        {
            return this._alarmConfigurationUpdatedTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmDescription. 
        /// <para>
        /// The description of the alarm. 
        /// </para>
        /// </summary>
        public string AlarmDescription
        {
            get { return this._alarmDescription; }
            set { this._alarmDescription = value; }
        }

        // Check to see if AlarmDescription property is set
        internal bool IsSetAlarmDescription()
        {
            return this._alarmDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm. If you don't specify a name, CloudFront generates a unique
        /// physical ID and uses that ID for the alarm name. 
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this._alarmName; }
            set { this._alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this._alarmName != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The arithmetic operation to use when comparing the specified statistic and threshold.
        /// The specified statistic value is used as the first operand. 
        /// </para>
        /// </summary>
        public string ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property DatapointsToAlarm. 
        /// <para>
        /// The number of datapoints that must be breaching to trigger the alarm. 
        /// </para>
        /// </summary>
        public int? DatapointsToAlarm
        {
            get { return this._datapointsToAlarm; }
            set { this._datapointsToAlarm = value; }
        }

        // Check to see if DatapointsToAlarm property is set
        internal bool IsSetDatapointsToAlarm()
        {
            return this._datapointsToAlarm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions for the metric associated with the alarm. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCloudWatchAlarmDimensionsDetails> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluateLowSampleCountPercentile. 
        /// <para>
        /// Used only for alarms based on percentiles. If <c>ignore</c>, the alarm state does
        /// not change during periods with too few data points to be statistically significant.
        /// If <c>evaluate</c> or this parameter is not used, the alarm is always evaluated and
        /// possibly changes state no matter how many data points are available. 
        /// </para>
        /// </summary>
        public string EvaluateLowSampleCountPercentile
        {
            get { return this._evaluateLowSampleCountPercentile; }
            set { this._evaluateLowSampleCountPercentile = value; }
        }

        // Check to see if EvaluateLowSampleCountPercentile property is set
        internal bool IsSetEvaluateLowSampleCountPercentile()
        {
            return this._evaluateLowSampleCountPercentile != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// The number of periods over which data is compared to the specified threshold. 
        /// </para>
        /// </summary>
        public int? EvaluationPeriods
        {
            get { return this._evaluationPeriods; }
            set { this._evaluationPeriods = value; }
        }

        // Check to see if EvaluationPeriods property is set
        internal bool IsSetEvaluationPeriods()
        {
            return this._evaluationPeriods.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtendedStatistic. 
        /// <para>
        /// The percentile statistic for the metric associated with the alarm. 
        /// </para>
        /// </summary>
        public string ExtendedStatistic
        {
            get { return this._extendedStatistic; }
            set { this._extendedStatistic = value; }
        }

        // Check to see if ExtendedStatistic property is set
        internal bool IsSetExtendedStatistic()
        {
            return this._extendedStatistic != null;
        }

        /// <summary>
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>INSUFFICIENT_DATA</c>
        /// state from any other state. Each action is specified as an ARN. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InsufficientDataActions
        {
            get { return this._insufficientDataActions; }
            set { this._insufficientDataActions = value; }
        }

        // Check to see if InsufficientDataActions property is set
        internal bool IsSetInsufficientDataActions()
        {
            return this._insufficientDataActions != null && (this._insufficientDataActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric associated with the alarm. This is required for an alarm based
        /// on a metric. For an alarm based on a math expression, you use <c>Metrics</c> instead
        /// and you can't specify <c>MetricName</c>. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric associated with the alarm. This is required for an alarm
        /// based on a metric. For an alarm based on a math expression, you can't specify <c>Namespace</c>
        /// and you use <c>Metrics</c> instead. 
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property OkActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>OK</c> state from any
        /// other state. Each action is specified as an ARN. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OkActions
        {
            get { return this._okActions; }
            set { this._okActions = value; }
        }

        // Check to see if OkActions property is set
        internal bool IsSetOkActions()
        {
            return this._okActions != null && (this._okActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period, in seconds, over which the statistic is applied. This is required for
        /// an alarm based on a metric. 
        /// </para>
        /// </summary>
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

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
        public string Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value to compare with the specified statistic. 
        /// </para>
        /// </summary>
        public double? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdMetricId. 
        /// <para>
        /// n an alarm based on an anomaly detection model, this is the ID of the <c>ANOMALY_DETECTION_BAND</c>
        /// function used as the threshold for the alarm. 
        /// </para>
        /// </summary>
        public string ThresholdMetricId
        {
            get { return this._thresholdMetricId; }
            set { this._thresholdMetricId = value; }
        }

        // Check to see if ThresholdMetricId property is set
        internal bool IsSetThresholdMetricId()
        {
            return this._thresholdMetricId != null;
        }

        /// <summary>
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        /// Sets how this alarm is to handle missing data points. 
        /// </para>
        /// </summary>
        public string TreatMissingData
        {
            get { return this._treatMissingData; }
            set { this._treatMissingData = value; }
        }

        // Check to see if TreatMissingData property is set
        internal bool IsSetTreatMissingData()
        {
            return this._treatMissingData != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the metric associated with the alarm. 
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}