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
    /// Container for the parameters to the PutMetricAlarm operation.
    /// Creates or updates an alarm and associates it with the specified metric. Optionally,
    /// this operation can associate one or more Amazon SNS resources with the alarm.
    /// 
    ///  
    /// <para>
    /// When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
    /// The alarm is evaluated and its state is set appropriately. Any actions associated
    /// with the state are then executed.
    /// </para>
    ///  
    /// <para>
    /// When you update an existing alarm, its state is left unchanged, but the update completely
    /// overwrites the previous configuration of the alarm.
    /// </para>
    ///  
    /// <para>
    /// If you are an IAM user, you must have Amazon EC2 permissions for some operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>iam:CreateServiceLinkedRole</code> for all alarms with EC2 actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:DescribeInstanceStatus</code> and <code>ec2:DescribeInstances</code> for
    /// all alarms on EC2 instance status metrics
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:StopInstances</code> for alarms with stop actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:TerminateInstances</code> for alarms with terminate actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:DescribeInstanceRecoveryAttribute</code> and <code>ec2:RecoverInstances</code>
    /// for alarms with recover actions
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you have read/write permissions for Amazon CloudWatch but not for Amazon EC2, you
    /// can still create an alarm, but the stop or terminate actions are not performed. However,
    /// if you are later granted the required permissions, the alarm actions that you created
    /// earlier are performed.
    /// </para>
    ///  
    /// <para>
    /// If you are using an IAM role (for example, an EC2 instance profile), you cannot stop
    /// or terminate the instance using alarm actions. However, you can still see the alarm
    /// state and perform any other actions such as Amazon SNS notifications or Auto Scaling
    /// policies.
    /// </para>
    ///  
    /// <para>
    /// If you are using temporary security credentials granted using AWS STS, you cannot
    /// stop or terminate an EC2 instance using alarm actions.
    /// </para>
    ///  
    /// <para>
    /// You must create at least one stop, terminate, or reboot alarm using either the Amazon
    /// EC2 or CloudWatch consoles to create the <b>EC2ActionsAccess</b> IAM role. After this
    /// IAM role is created, you can create stop, terminate, or reboot alarms using a command-line
    /// interface or API.
    /// </para>
    /// </summary>
    public partial class PutMetricAlarmRequest : AmazonCloudWatchRequest
    {
        private bool? _actionsEnabled;
        private List<string> _alarmActions = new List<string>();
        private string _alarmDescription;
        private string _alarmName;
        private ComparisonOperator _comparisonOperator;
        private int? _datapointsToAlarm;
        private List<Dimension> _dimensions = new List<Dimension>();
        private string _evaluateLowSampleCountPercentile;
        private int? _evaluationPeriods;
        private string _extendedStatistic;
        private List<string> _insufficientDataActions = new List<string>();
        private string _metricName;
        private string _awsNamespace;
        private List<string> _okActions = new List<string>();
        private int? _period;
        private Statistic _statistic;
        private double? _threshold;
        private string _treatMissingData;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether actions should be executed during any changes to the alarm state.
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
        /// The actions to execute when this alarm transitions to the <code>ALARM</code> state
        /// from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values: arn:aws:automate:<i>region</i>:ec2:stop | arn:aws:automate:<i>region</i>:ec2:terminate
        /// | arn:aws:automate:<i>region</i>:ec2:recover | arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i>
        /// | arn:aws:autoscaling:<i>region</i>:<i>account-id</i>:scalingPolicy:<i>policy-id</i>
        /// autoScalingGroupName/<i>group-friendly-name</i>:policyName/<i>policy-friendly-name</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Stop/1.0
        /// | arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Terminate/1.0
        /// | arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Reboot/1.0
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
        /// Gets and sets the property AlarmDescription. 
        /// <para>
        /// The description for the alarm.
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
        /// The name for the alarm. This name must be unique within the AWS account.
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
        ///  The arithmetic operation to use when comparing the specified statistic and threshold.
        /// The specified statistic value is used as the first operand.
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
        /// Gets and sets the property DatapointsToAlarm. 
        /// <para>
        /// The number of datapoints that must be breaching to trigger the alarm. This is used
        /// only if you are setting an "M out of N" alarm. In that case, this value is the M.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#alarm-evaluation">Evaluating
        /// an Alarm</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        public int DatapointsToAlarm
        {
            get { return this._datapointsToAlarm.GetValueOrDefault(); }
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
        /// Gets and sets the property EvaluateLowSampleCountPercentile. 
        /// <para>
        ///  Used only for alarms based on percentiles. If you specify <code>ignore</code>, the
        /// alarm state does not change during periods with too few data points to be statistically
        /// significant. If you specify <code>evaluate</code> or omit this parameter, the alarm
        /// is always evaluated and possibly changes state no matter how many data points are
        /// available. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#percentiles-with-low-samples">Percentile-Based
        /// CloudWatch Alarms and Low Data Samples</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>evaluate | ignore</code> 
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
        /// The number of periods over which data is compared to the specified threshold. If you
        /// are setting an alarm which requires that a number of consecutive data points be breaching
        /// to trigger the alarm, this value specifies that number. If you are setting an "M out
        /// of N" alarm, this value is the N.
        /// </para>
        ///  
        /// <para>
        /// An alarm's total current evaluation period can be no longer than one day, so this
        /// number multiplied by <code>Period</code> cannot be more than 86,400 seconds.
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
        /// Gets and sets the property ExtendedStatistic. 
        /// <para>
        /// The percentile statistic for the metric associated with the alarm. Specify a value
        /// between p0.0 and p100. When you call <code>PutMetricAlarm</code>, you must specify
        /// either <code>Statistic</code> or <code>ExtendedStatistic,</code> but not both.
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
        /// The actions to execute when this alarm transitions to the <code>INSUFFICIENT_DATA</code>
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values: arn:aws:automate:<i>region</i>:ec2:stop | arn:aws:automate:<i>region</i>:ec2:terminate
        /// | arn:aws:automate:<i>region</i>:ec2:recover | arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i>
        /// | arn:aws:autoscaling:<i>region</i>:<i>account-id</i>:scalingPolicy:<i>policy-id</i>
        /// autoScalingGroupName/<i>group-friendly-name</i>:policyName/<i>policy-friendly-name</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Stop/1.0
        /// | arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Terminate/1.0
        /// | arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Reboot/1.0
        /// </para>
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
        /// The name for the metric associated with the alarm.
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
        /// The namespace for the metric associated with the alarm.
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
        /// The actions to execute when this alarm transitions to an <code>OK</code> state from
        /// any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values: arn:aws:automate:<i>region</i>:ec2:stop | arn:aws:automate:<i>region</i>:ec2:terminate
        /// | arn:aws:automate:<i>region</i>:ec2:recover | arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i>
        /// | arn:aws:autoscaling:<i>region</i>:<i>account-id</i>:scalingPolicy:<i>policy-id</i>
        /// autoScalingGroupName/<i>group-friendly-name</i>:policyName/<i>policy-friendly-name</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Stop/1.0
        /// | arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Terminate/1.0
        /// | arn:aws:swf:<i>region</i>:{<i>account-id</i>}:action/actions/AWS_EC2.InstanceId.Reboot/1.0
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
        /// The period, in seconds, over which the specified statistic is applied. Valid values
        /// are 10, 30, and any multiple of 60.
        /// </para>
        ///  
        /// <para>
        /// Be sure to specify 10 or 30 only for metrics that are stored by a <code>PutMetricData</code>
        /// call with a <code>StorageResolution</code> of 1. If you specify a period of 10 or
        /// 30 for a metric that does not have sub-minute resolution, the alarm still attempts
        /// to gather data at the period rate that you specify. In this case, it does not receive
        /// data for the attempts that do not correspond to a one-minute data resolution, and
        /// the alarm may often lapse into INSUFFICENT_DATA status. Specifying 10 or 30 also sets
        /// this alarm as a high-resolution alarm, which has a higher charge than other alarms.
        /// For more information about pricing, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// An alarm's total current evaluation period can be no longer than one day, so <code>Period</code>
        /// multiplied by <code>EvaluationPeriods</code> cannot be more than 86,400 seconds.
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic for the metric associated with the alarm, other than percentile. For
        /// percentile statistics, use <code>ExtendedStatistic</code>. When you call <code>PutMetricAlarm</code>,
        /// you must specify either <code>Statistic</code> or <code>ExtendedStatistic,</code>
        /// but not both.
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
        /// The value against which the specified statistic is compared.
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
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        ///  Sets how this alarm is to handle missing data points. If <code>TreatMissingData</code>
        /// is omitted, the default behavior of <code>missing</code> is used. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#alarms-and-missing-data">Configuring
        /// How CloudWatch Alarms Treats Missing Data</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>breaching | notBreaching | ignore | missing</code> 
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
        /// The unit of measure for the statistic. For example, the units for the Amazon EC2 NetworkIn
        /// metric are Bytes because NetworkIn tracks the number of bytes that an instance receives
        /// on all network interfaces. You can also specify a unit when you create a custom metric.
        /// Units help provide conceptual meaning to your data. Metric data points that specify
        /// a unit of measure, such as Percent, are aggregated separately.
        /// </para>
        ///  
        /// <para>
        /// If you specify a unit, you must use a unit that is appropriate for the metric. Otherwise,
        /// the CloudWatch alarm can get stuck in the <code>INSUFFICIENT DATA</code> state. 
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