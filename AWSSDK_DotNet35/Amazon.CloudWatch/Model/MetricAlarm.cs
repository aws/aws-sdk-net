/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The <a>MetricAlarm</a> data type represents an alarm. You can use <a>PutMetricAlarm</a>
    /// to create or update an alarm.
    /// </summary>
    public partial class MetricAlarm
    {
        private bool? _actionsEnabled;
        private List<string> _alarmActions = new List<string>();
        private string _alarmArn;
        private DateTime? _alarmConfigurationUpdatedTimestamp;
        private string _alarmDescription;
        private string _alarmName;
        private ComparisonOperator _comparisonOperator;
        private List<Dimension> _dimensions = new List<Dimension>();
        private int? _evaluationPeriods;
        private List<string> _insufficientDataActions = new List<string>();
        private string _metricName;
        private string _awsNamespace;
        private List<string> _okActions = new List<string>();
        private int? _period;
        private string _stateReason;
        private string _stateReasonData;
        private DateTime? _stateUpdatedTimestamp;
        private StateValue _stateValue;
        private Statistic _statistic;
        private double? _threshold;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        ///  Indicates whether actions should be executed during any changes to the alarm's state.
        /// 
        /// </para>
        /// </summary>
        public bool ActionsEnabled
        {
            get { return this._actionsEnabled.GetValueOrDefault(); }
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
        ///  The list of actions to execute when this alarm transitions into an <code>ALARM</code>
        /// state from any other state. Each action is specified as an Amazon Resource Number
        /// (ARN). Currently the only actions supported are publishing to an Amazon SNS topic
        /// and triggering an Auto Scaling policy. 
        /// </para>
        /// </summary>
        public List<string> AlarmActions
        {
            get { return this._alarmActions; }
            set { this._alarmActions = value; }
        }

        // Check to see if AlarmActions property is set
        internal bool IsSetAlarmActions()
        {
            return this._alarmActions != null && this._alarmActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AlarmArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the alarm. 
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
        ///  The time stamp of the last update to the alarm configuration. Amazon CloudWatch uses
        /// Coordinated Universal Time (UTC) when returning time stamps, which do not accommodate
        /// seasonal adjustments such as daylight savings time. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Time
        /// stamps</a> in the <i>Amazon CloudWatch Developer Guide</i>. 
        /// </para>
        /// </summary>
        public DateTime AlarmConfigurationUpdatedTimestamp
        {
            get { return this._alarmConfigurationUpdatedTimestamp.GetValueOrDefault(); }
            set { this._alarmConfigurationUpdatedTimestamp = value; }
        }

        // Check to see if AlarmConfigurationUpdatedTimestamp property is set
        internal bool IsSetAlarmConfigurationUpdatedTimestamp()
        {
            return this._alarmConfigurationUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlarmDescription. 
        /// <para>
        ///  The description for the alarm. 
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
        ///  The name of the alarm. 
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
        ///  The arithmetic operation to use when comparing the specified <code>Statistic</code>
        /// and <code>Threshold</code>. The specified <code>Statistic</code> value is used as
        /// the first operand. 
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
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
        /// Gets and sets the property Dimensions. 
        /// <para>
        ///  The list of dimensions associated with the alarm's associated metric. 
        /// </para>
        /// </summary>
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        ///  The number of periods over which data is compared to the specified threshold. 
        /// </para>
        /// </summary>
        public int EvaluationPeriods
        {
            get { return this._evaluationPeriods.GetValueOrDefault(); }
            set { this._evaluationPeriods = value; }
        }

        // Check to see if EvaluationPeriods property is set
        internal bool IsSetEvaluationPeriods()
        {
            return this._evaluationPeriods.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        ///  The list of actions to execute when this alarm transitions into an <code>INSUFFICIENT_DATA</code>
        /// state from any other state. Each action is specified as an Amazon Resource Number
        /// (ARN). Currently the only actions supported are publishing to an Amazon SNS topic
        /// or triggering an Auto Scaling policy. 
        /// </para>
        ///  <important>The current WSDL lists this attribute as <code>UnknownActions</code>.</important>
        /// </summary>
        public List<string> InsufficientDataActions
        {
            get { return this._insufficientDataActions; }
            set { this._insufficientDataActions = value; }
        }

        // Check to see if InsufficientDataActions property is set
        internal bool IsSetInsufficientDataActions()
        {
            return this._insufficientDataActions != null && this._insufficientDataActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  The name of the alarm's metric. 
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
        ///  The namespace of alarm's associated metric. 
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
        /// Gets and sets the property OKActions. 
        /// <para>
        ///  The list of actions to execute when this alarm transitions into an <code>OK</code>
        /// state from any other state. Each action is specified as an Amazon Resource Number
        /// (ARN). Currently the only actions supported are publishing to an Amazon SNS topic
        /// and triggering an Auto Scaling policy. 
        /// </para>
        /// </summary>
        public List<string> OKActions
        {
            get { return this._okActions; }
            set { this._okActions = value; }
        }

        // Check to see if OKActions property is set
        internal bool IsSetOKActions()
        {
            return this._okActions != null && this._okActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        ///  The period in seconds over which the statistic is applied. 
        /// </para>
        /// </summary>
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        ///  A human-readable explanation for the alarm's state. 
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property StateReasonData. 
        /// <para>
        ///  An explanation for the alarm's state in machine-readable JSON format 
        /// </para>
        /// </summary>
        public string StateReasonData
        {
            get { return this._stateReasonData; }
            set { this._stateReasonData = value; }
        }

        // Check to see if StateReasonData property is set
        internal bool IsSetStateReasonData()
        {
            return this._stateReasonData != null;
        }

        /// <summary>
        /// Gets and sets the property StateUpdatedTimestamp. 
        /// <para>
        ///  The time stamp of the last update to the alarm's state. Amazon CloudWatch uses Coordinated
        /// Universal Time (UTC) when returning time stamps, which do not accommodate seasonal
        /// adjustments such as daylight savings time. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Time
        /// stamps</a> in the <i>Amazon CloudWatch Developer Guide</i>. 
        /// </para>
        /// </summary>
        public DateTime StateUpdatedTimestamp
        {
            get { return this._stateUpdatedTimestamp.GetValueOrDefault(); }
            set { this._stateUpdatedTimestamp = value; }
        }

        // Check to see if StateUpdatedTimestamp property is set
        internal bool IsSetStateUpdatedTimestamp()
        {
            return this._stateUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        ///  The state value for the alarm. 
        /// </para>
        /// </summary>
        public StateValue StateValue
        {
            get { return this._stateValue; }
            set { this._stateValue = value; }
        }

        // Check to see if StateValue property is set
        internal bool IsSetStateValue()
        {
            return this._stateValue != null;
        }

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        ///  The statistic to apply to the alarm's associated metric. 
        /// </para>
        /// </summary>
        public Statistic Statistic
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
        ///  The value against which the specified statistic is compared. 
        /// </para>
        /// </summary>
        public double Threshold
        {
            get { return this._threshold.GetValueOrDefault(); }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The unit of the alarm's associated metric. 
        /// </para>
        /// </summary>
        public StandardUnit Unit
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