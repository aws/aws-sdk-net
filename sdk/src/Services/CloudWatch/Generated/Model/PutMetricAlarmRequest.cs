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
    /// Creates or updates an alarm and associates it with the specified Amazon CloudWatch
    /// metric. Optionally, this operation can associate one or more Amazon SNS resources
    /// with the alarm.
    /// 
    ///  
    /// <para>
    ///  When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
    /// The alarm is evaluated and its <code>StateValue</code> is set appropriately. Any actions
    /// associated with the <code>StateValue</code> are then executed. 
    /// </para>
    ///  <note> 
    /// <para>
    /// When updating an existing alarm, its <code>StateValue</code> is left unchanged, but
    /// it completely overwrites the alarm's previous configuration.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// If you are using an AWS Identity and Access Management (IAM) account to create or
    /// modify an alarm, you must have the following Amazon EC2 permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>ec2:DescribeInstanceStatus</code> and <code>ec2:DescribeInstances</code> for
    /// all alarms on Amazon EC2 instance status metrics.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:StopInstances</code> for alarms with stop actions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:TerminateInstances</code> for alarms with terminate actions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ec2:DescribeInstanceRecoveryAttribute</code>, and <code>ec2:RecoverInstances</code>
    /// for alarms with recover actions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you have read/write permissions for Amazon CloudWatch but not for Amazon EC2, you
    /// can still create an alarm but the stop or terminate actions won't be performed on
    /// the Amazon EC2 instance. However, if you are later granted permission to use the associated
    /// Amazon EC2 APIs, the alarm actions you created earlier will be performed. For more
    /// information about IAM permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html">Permissions
    /// and Policies</a> in <i>Using IAM</i>.
    /// </para>
    ///  
    /// <para>
    /// If you are using an IAM role (e.g., an Amazon EC2 instance profile), you cannot stop
    /// or terminate the instance using alarm actions. However, you can still see the alarm
    /// state and perform any other actions such as Amazon SNS notifications or Auto Scaling
    /// policies.
    /// </para>
    ///  
    /// <para>
    /// If you are using temporary security credentials granted using the AWS Security Token
    /// Service (AWS STS), you cannot stop or terminate an Amazon EC2 instance using alarm
    /// actions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutMetricAlarmRequest : AmazonCloudWatchRequest
    {
        private bool? _actionsEnabled;
        private List<string> _alarmActions = new List<string>();
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
        private Statistic _statistic;
        private double? _threshold;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether or not actions should be executed during any changes to the alarm's
        /// state.
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
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: arn:aws:automate:<i>region (e.g., us-east-1)</i>:ec2:stop | arn:aws:automate:<i>region
        /// (e.g., us-east-1)</i>:ec2:terminate | arn:aws:automate:<i>region (e.g., us-east-1)</i>:ec2:recover
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Stop/1.0
        /// | arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Terminate/1.0
        /// | arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Reboot/1.0
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> You must create at least one stop, terminate, or reboot alarm using
        /// the Amazon EC2 or CloudWatch console to create the <b>EC2ActionsAccess</b> IAM role
        /// for the first time. After this IAM role is created, you can create stop, terminate,
        /// or reboot alarms using the CLI.
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
        /// The descriptive name for the alarm. This name must be unique within the user's AWS
        /// account
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
        /// The dimensions for the alarm's associated metric.
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
        /// The number of periods over which data is compared to the specified threshold.
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
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: arn:aws:automate:<i>region (e.g., us-east-1)</i>:ec2:stop | arn:aws:automate:<i>region
        /// (e.g., us-east-1)</i>:ec2:terminate | arn:aws:automate:<i>region (e.g., us-east-1)</i>:ec2:recover
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Stop/1.0
        /// | arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Terminate/1.0
        /// | arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Reboot/1.0
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> You must create at least one stop, terminate, or reboot alarm using
        /// the Amazon EC2 or CloudWatch console to create the <b>EC2ActionsAccess</b> IAM role
        /// for the first time. After this IAM role is created, you can create stop, terminate,
        /// or reboot alarms using the CLI.
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
        /// The name for the alarm's associated metric.
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
        /// The namespace for the alarm's associated metric.
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
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: arn:aws:automate:<i>region (e.g., us-east-1)</i>:ec2:stop | arn:aws:automate:<i>region
        /// (e.g., us-east-1)</i>:ec2:terminate | arn:aws:automate:<i>region (e.g., us-east-1)</i>:ec2:recover
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Stop/1.0
        /// | arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Terminate/1.0
        /// | arn:aws:swf:us-east-1:{<i>customer-account</i>}:action/actions/AWS_EC2.InstanceId.Reboot/1.0
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> You must create at least one stop, terminate, or reboot alarm using
        /// the Amazon EC2 or CloudWatch console to create the <b>EC2ActionsAccess</b> IAM role
        /// for the first time. After this IAM role is created, you can create stop, terminate,
        /// or reboot alarms using the CLI.
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
        /// The period in seconds over which the specified statistic is applied.
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
        /// The statistic to apply to the alarm's associated metric.
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
        /// Gets and sets the property Unit. 
        /// <para>
        /// The statistic's unit of measure. For example, the units for the Amazon EC2 NetworkIn
        /// metric are Bytes because NetworkIn tracks the number of bytes that an instance receives
        /// on all network interfaces. You can also specify a unit when you create a custom metric.
        /// Units help provide conceptual meaning to your data. Metric data points that specify
        /// a unit of measure, such as Percent, are aggregated separately.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> If you specify a unit, you must use a unit that is appropriate for the
        /// metric. Otherwise, this can cause an Amazon CloudWatch alarm to get stuck in the INSUFFICIENT
        /// DATA state. 
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