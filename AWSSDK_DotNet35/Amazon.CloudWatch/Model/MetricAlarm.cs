/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// <para> The MetricAlarm data type represents an alarm. You can use PutMetricAlarm to create or update an alarm. </para>
    /// </summary>
    public class MetricAlarm
    {
        
        private string alarmName;
        private string alarmArn;
        private string alarmDescription;
        private DateTime? alarmConfigurationUpdatedTimestamp;
        private bool? actionsEnabled;
        private List<string> oKActions = new List<string>();
        private List<string> alarmActions = new List<string>();
        private List<string> insufficientDataActions = new List<string>();
        private StateValue stateValue;
        private string stateReason;
        private string stateReasonData;
        private DateTime? stateUpdatedTimestamp;
        private string metricName;
        private string namespaceValue;
        private Statistic statistic;
        private List<Dimension> dimensions = new List<Dimension>();
        private int? period;
        private StandardUnit unit;
        private int? evaluationPeriods;
        private double? threshold;
        private ComparisonOperator comparisonOperator;

        /// <summary>
        /// The name of the alarm.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this.alarmName; }
            set { this.alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this.alarmName != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the alarm.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmArn
        {
            get { return this.alarmArn; }
            set { this.alarmArn = value; }
        }

        // Check to see if AlarmArn property is set
        internal bool IsSetAlarmArn()
        {
            return this.alarmArn != null;
        }

        /// <summary>
        /// The description for the alarm.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmDescription
        {
            get { return this.alarmDescription; }
            set { this.alarmDescription = value; }
        }

        // Check to see if AlarmDescription property is set
        internal bool IsSetAlarmDescription()
        {
            return this.alarmDescription != null;
        }

        /// <summary>
        /// The time stamp of the last update to the alarm configuration. Amazon CloudWatch uses Coordinated Universal Time (UTC) when returning time
        /// stamps, which do not accommodate seasonal adjustments such as daylight savings time. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Time stamps</a> in the
        /// <i>Amazon CloudWatch Developer Guide</i>.
        ///  
        /// </summary>
        public DateTime AlarmConfigurationUpdatedTimestamp
        {
            get { return this.alarmConfigurationUpdatedTimestamp ?? default(DateTime); }
            set { this.alarmConfigurationUpdatedTimestamp = value; }
        }

        // Check to see if AlarmConfigurationUpdatedTimestamp property is set
        internal bool IsSetAlarmConfigurationUpdatedTimestamp()
        {
            return this.alarmConfigurationUpdatedTimestamp.HasValue;
        }

        /// <summary>
        /// Indicates whether actions should be executed during any changes to the alarm's state.
        ///  
        /// </summary>
        public bool ActionsEnabled
        {
            get { return this.actionsEnabled ?? default(bool); }
            set { this.actionsEnabled = value; }
        }

        // Check to see if ActionsEnabled property is set
        internal bool IsSetActionsEnabled()
        {
            return this.actionsEnabled.HasValue;
        }

        /// <summary>
        /// The list of actions to execute when this alarm transitions into an <c>OK</c> state from any other state. Each action is specified as an
        /// Amazon Resource Number (ARN). Currently the only actions supported are publishing to an Amazon SNS topic and triggering an Auto Scaling
        /// policy.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> OKActions
        {
            get { return this.oKActions; }
            set { this.oKActions = value; }
        }

        // Check to see if OKActions property is set
        internal bool IsSetOKActions()
        {
            return this.oKActions.Count > 0;
        }

        /// <summary>
        /// The list of actions to execute when this alarm transitions into an <c>ALARM</c> state from any other state. Each action is specified as an
        /// Amazon Resource Number (ARN). Currently the only actions supported are publishing to an Amazon SNS topic and triggering an Auto Scaling
        /// policy.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AlarmActions
        {
            get { return this.alarmActions; }
            set { this.alarmActions = value; }
        }

        // Check to see if AlarmActions property is set
        internal bool IsSetAlarmActions()
        {
            return this.alarmActions.Count > 0;
        }

        /// <summary>
        /// The list of actions to execute when this alarm transitions into an <c>INSUFFICIENT_DATA</c> state from any other state. Each action is
        /// specified as an Amazon Resource Number (ARN). Currently the only actions supported are publishing to an Amazon SNS topic or triggering an
        /// Auto Scaling policy. <important>The current WSDL lists this attribute as <c>UnknownActions</c>.</important>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> InsufficientDataActions
        {
            get { return this.insufficientDataActions; }
            set { this.insufficientDataActions = value; }
        }

        // Check to see if InsufficientDataActions property is set
        internal bool IsSetInsufficientDataActions()
        {
            return this.insufficientDataActions.Count > 0;
        }

        /// <summary>
        /// The state value for the alarm.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>OK, ALARM, INSUFFICIENT_DATA</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StateValue StateValue
        {
            get { return this.stateValue; }
            set { this.stateValue = value; }
        }

        // Check to see if StateValue property is set
        internal bool IsSetStateValue()
        {
            return this.stateValue != null;
        }

        /// <summary>
        /// A human-readable explanation for the alarm's state.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1023</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this.stateReason; }
            set { this.stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this.stateReason != null;
        }

        /// <summary>
        /// An explanation for the alarm's state in machine-readable JSON format
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 4000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StateReasonData
        {
            get { return this.stateReasonData; }
            set { this.stateReasonData = value; }
        }

        // Check to see if StateReasonData property is set
        internal bool IsSetStateReasonData()
        {
            return this.stateReasonData != null;
        }

        /// <summary>
        /// The time stamp of the last update to the alarm's state. Amazon CloudWatch uses Coordinated Universal Time (UTC) when returning time stamps,
        /// which do not accommodate seasonal adjustments such as daylight savings time. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Time stamps</a> in the
        /// <i>Amazon CloudWatch Developer Guide</i>.
        ///  
        /// </summary>
        public DateTime StateUpdatedTimestamp
        {
            get { return this.stateUpdatedTimestamp ?? default(DateTime); }
            set { this.stateUpdatedTimestamp = value; }
        }

        // Check to see if StateUpdatedTimestamp property is set
        internal bool IsSetStateUpdatedTimestamp()
        {
            return this.stateUpdatedTimestamp.HasValue;
        }

        /// <summary>
        /// The name of the alarm's metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this.metricName; }
            set { this.metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this.metricName != null;
        }

        /// <summary>
        /// The namespace of alarm's associated metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[^:].*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this.namespaceValue; }
            set { this.namespaceValue = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this.namespaceValue != null;
        }

        /// <summary>
        /// The statistic to apply to the alarm's associated metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>SampleCount, Average, Sum, Minimum, Maximum</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Statistic Statistic
        {
            get { return this.statistic; }
            set { this.statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this.statistic != null;
        }

        /// <summary>
        /// The list of dimensions associated with the alarm's associated metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<Dimension> Dimensions
        {
            get { return this.dimensions; }
            set { this.dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this.dimensions.Count > 0;
        }

        /// <summary>
        /// The period in seconds over which the statistic is applied.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>60 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Period
        {
            get { return this.period ?? default(int); }
            set { this.period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this.period.HasValue;
        }

        /// <summary>
        /// The unit of the alarm's associated metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Seconds, Microseconds, Milliseconds, Bytes, Kilobytes, Megabytes, Gigabytes, Terabytes, Bits, Kilobits, Megabits, Gigabits, Terabits, Percent, Count, Bytes/Second, Kilobytes/Second, Megabytes/Second, Gigabytes/Second, Terabytes/Second, Bits/Second, Kilobits/Second, Megabits/Second, Gigabits/Second, Terabits/Second, Count/Second, None</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StandardUnit Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this.unit != null;
        }

        /// <summary>
        /// The number of periods over which data is compared to the specified threshold.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int EvaluationPeriods
        {
            get { return this.evaluationPeriods ?? default(int); }
            set { this.evaluationPeriods = value; }
        }

        // Check to see if EvaluationPeriods property is set
        internal bool IsSetEvaluationPeriods()
        {
            return this.evaluationPeriods.HasValue;
        }

        /// <summary>
        /// The value against which the specified statistic is compared.
        ///  
        /// </summary>
        public double Threshold
        {
            get { return this.threshold ?? default(double); }
            set { this.threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this.threshold.HasValue;
        }

        /// <summary>
        /// The arithmetic operation to use when comparing the specified <c>Statistic</c> and <c>Threshold</c>. The specified <c>Statistic</c> value is
        /// used as the first operand.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>GreaterThanOrEqualToThreshold, GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this.comparisonOperator; }
            set { this.comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this.comparisonOperator != null;
        }
    }
}
