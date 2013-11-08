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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricAlarm operation.
    /// <para> Creates or updates an alarm and associates it with the specified Amazon CloudWatch metric. Optionally, this operation can associate
    /// one or more Amazon Simple Notification Service resources with the alarm. </para> <para> When this operation creates an alarm, the alarm
    /// state is immediately set to <c>INSUFFICIENT_DATA</c> . The alarm is evaluated and its <c>StateValue</c> is set appropriately. Any actions
    /// associated with the <c>StateValue</c> is then executed. </para> <para><b>NOTE:</b> When updating an existing alarm, its StateValue is left
    /// unchanged. </para>
    /// </summary>
    public partial class PutMetricAlarmRequest : AmazonWebServiceRequest
    {
        private string alarmName;
        private string alarmDescription;
        private bool? actionsEnabled;
        private List<string> oKActions = new List<string>();
        private List<string> alarmActions = new List<string>();
        private List<string> insufficientDataActions = new List<string>();
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
        /// The descriptive name for the alarm. This name must be unique within the user's AWS account
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
        /// Indicates whether or not actions should be executed during any changes to the alarm's state.
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
        /// Amazon Resource Number (ARN). Currently the only action supported is publishing to an Amazon SNS topic or an Amazon Auto Scaling policy.
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
        /// Amazon Resource Number (ARN). Currently the only action supported is publishing to an Amazon SNS topic or an Amazon Auto Scaling policy.
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
        /// specified as an Amazon Resource Number (ARN). Currently the only action supported is publishing to an Amazon SNS topic or an Amazon Auto
        /// Scaling policy.
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
        /// The name for the alarm's associated metric.
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
        /// The namespace for the alarm's associated metric.
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
        /// The dimensions for the alarm's associated metric.
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
        /// The period in seconds over which the specified statistic is applied.
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
        /// The unit for the alarm's associated metric.
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
    
