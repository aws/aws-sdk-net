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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricAlarm operation.
    /// Creates or updates an alarm and associates it with the specified metric, metric math
    /// expression, anomaly detection model, or Metrics Insights query. For more information
    /// about using a Metrics Insights query for an alarm, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Create_Metrics_Insights_Alarm.html">Create
    /// alarms on Metrics Insights queries</a>.
    /// 
    ///  
    /// <para>
    /// Alarms based on anomaly detection models cannot have Auto Scaling actions.
    /// </para>
    ///  
    /// <para>
    /// When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
    /// The alarm is then evaluated and its state is set appropriately. Any actions associated
    /// with the new state are then executed.
    /// </para>
    ///  
    /// <para>
    /// When you update an existing alarm, its state is left unchanged, but the update completely
    /// overwrites the previous configuration of the alarm.
    /// </para>
    ///  
    /// <para>
    /// If you are an IAM user, you must have Amazon EC2 permissions for some alarm operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <code>iam:CreateServiceLinkedRole</code> for all alarms with EC2 actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>iam:CreateServiceLinkedRole</code> to create an alarm with Systems Manager
    /// OpsItem actions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The first time you create an alarm in the Amazon Web Services Management Console,
    /// the CLI, or by using the PutMetricAlarm API, CloudWatch creates the necessary service-linked
    /// role for you. The service-linked roles are called <code>AWSServiceRoleForCloudWatchEvents</code>
    /// and <code>AWSServiceRoleForCloudWatchAlarms_ActionSSM</code>. For more information,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html#iam-term-service-linked-role">Amazon
    /// Web Services service-linked role</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account alarms</b> 
    /// </para>
    ///  
    /// <para>
    /// You can set an alarm on metrics in the current account, or in another account. To
    /// create a cross-account alarm that watches a metric in a different account, you must
    /// have completed the following pre-requisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The account where the metrics are located (the <i>sharing account</i>) must already
    /// have a sharing role named <b>CloudWatch-CrossAccountSharingRole</b>. If it does not
    /// already have this role, you must create it using the instructions in <b>Set up a sharing
    /// account</b> in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Cross-Account-Cross-Region.html#enable-cross-account-cross-Region">
    /// Cross-account cross-Region CloudWatch console</a>. The policy for that role must grant
    /// access to the ID of the account where you are creating the alarm. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The account where you are creating the alarm (the <i>monitoring account</i>) must
    /// already have a service-linked role named <b>AWSServiceRoleForCloudWatchCrossAccount</b>
    /// to allow CloudWatch to assume the sharing role in the sharing account. If it does
    /// not, you must create it following the directions in <b>Set up a monitoring account</b>
    /// in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Cross-Account-Cross-Region.html#enable-cross-account-cross-Region">
    /// Cross-account cross-Region CloudWatch console</a>.
    /// </para>
    ///  </li> </ul>
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
        private List<MetricDataQuery> _metrics = new List<MetricDataQuery>();
        private string _awsNamespace;
        private List<string> _okActions = new List<string>();
        private int? _period;
        private Statistic _statistic;
        private List<Tag> _tags = new List<Tag>();
        private double? _threshold;
        private string _thresholdMetricId;
        private string _treatMissingData;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether actions should be executed during any changes to the alarm state.
        /// The default is <code>TRUE</code>.
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
        /// Valid Values: <code>arn:aws:automate:<i>region</i>:ec2:stop</code> | <code>arn:aws:automate:<i>region</i>:ec2:terminate</code>
        /// | <code>arn:aws:automate:<i>region</i>:ec2:recover</code> | <code>arn:aws:automate:<i>region</i>:ec2:reboot</code>
        /// | <code>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </code>
        /// | <code>arn:aws:autoscaling:<i>region</i>:<i>account-id</i>:scalingPolicy:<i>policy-id</i>:autoScalingGroupName/<i>group-friendly-name</i>:policyName/<i>policy-friendly-name</i>
        /// </code> | <code>arn:aws:ssm:<i>region</i>:<i>account-id</i>:opsitem:<i>severity</i>
        /// </code> | <code>arn:aws:ssm-incidents::<i>account-id</i>:response-plan:<i>response-plan-name</i>
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Stop/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Terminate/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Reboot/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Recover/1.0</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
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
        [AWSProperty(Min=0, Max=1024)]
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
        /// The name for the alarm. This name must be unique within the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        ///  
        /// <para>
        /// The values <code>LessThanLowerOrGreaterThanUpperThreshold</code>, <code>LessThanLowerThreshold</code>,
        /// and <code>GreaterThanUpperThreshold</code> are used only for alarms based on anomaly
        /// detection models.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The number of data points that must be breaching to trigger the alarm. This is used
        /// only if you are setting an "M out of N" alarm. In that case, this value is the M.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#alarm-evaluation">Evaluating
        /// an Alarm</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The dimensions for the metric specified in <code>MetricName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
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
        /// available. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#percentiles-with-low-samples">Percentile-Based
        /// CloudWatch Alarms and Low Data Samples</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>evaluate | ignore</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// are setting an alarm that requires that a number of consecutive data points be breaching
        /// to trigger the alarm, this value specifies that number. If you are setting an "M out
        /// of N" alarm, this value is the N.
        /// </para>
        ///  
        /// <para>
        /// An alarm's total current evaluation period can be no longer than one day, so this
        /// number multiplied by <code>Period</code> cannot be more than 86,400 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The percentile statistic for the metric specified in <code>MetricName</code>. Specify
        /// a value between p0.0 and p100. When you call <code>PutMetricAlarm</code> and specify
        /// a <code>MetricName</code>, you must specify either <code>Statistic</code> or <code>ExtendedStatistic,</code>
        /// but not both.
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
        /// Valid Values: <code>arn:aws:automate:<i>region</i>:ec2:stop</code> | <code>arn:aws:automate:<i>region</i>:ec2:terminate</code>
        /// | <code>arn:aws:automate:<i>region</i>:ec2:recover</code> | <code>arn:aws:automate:<i>region</i>:ec2:reboot</code>
        /// | <code>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </code>
        /// | <code>arn:aws:autoscaling:<i>region</i>:<i>account-id</i>:scalingPolicy:<i>policy-id</i>:autoScalingGroupName/<i>group-friendly-name</i>:policyName/<i>policy-friendly-name</i>
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): <code>&gt;arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Stop/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Terminate/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Reboot/1.0</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
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
        /// The name for the metric associated with the alarm. For each <code>PutMetricAlarm</code>
        /// operation, you must specify either <code>MetricName</code> or a <code>Metrics</code>
        /// array.
        /// </para>
        ///  
        /// <para>
        /// If you are creating an alarm based on a math expression, you cannot specify this parameter,
        /// or any of the <code>Dimensions</code>, <code>Period</code>, <code>Namespace</code>,
        /// <code>Statistic</code>, or <code>ExtendedStatistic</code> parameters. Instead, you
        /// specify all this information in the <code>Metrics</code> array.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// An array of <code>MetricDataQuery</code> structures that enable you to create an alarm
        /// based on the result of a metric math expression. For each <code>PutMetricAlarm</code>
        /// operation, you must specify either <code>MetricName</code> or a <code>Metrics</code>
        /// array.
        /// </para>
        ///  
        /// <para>
        /// Each item in the <code>Metrics</code> array either retrieves a metric or performs
        /// a math expression.
        /// </para>
        ///  
        /// <para>
        /// One item in the <code>Metrics</code> array is the expression that the alarm watches.
        /// You designate this expression by setting <code>ReturnData</code> to true for this
        /// object in the array. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_MetricDataQuery.html">MetricDataQuery</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use the <code>Metrics</code> parameter, you cannot include the <code>MetricName</code>,
        /// <code>Dimensions</code>, <code>Period</code>, <code>Namespace</code>, <code>Statistic</code>,
        /// or <code>ExtendedStatistic</code> parameters of <code>PutMetricAlarm</code> in the
        /// same operation. Instead, you retrieve the metrics you are using in your math expression
        /// as part of the <code>Metrics</code> array.
        /// </para>
        /// </summary>
        public List<MetricDataQuery> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace for the metric associated specified in <code>MetricName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Valid Values: <code>arn:aws:automate:<i>region</i>:ec2:stop</code> | <code>arn:aws:automate:<i>region</i>:ec2:terminate</code>
        /// | <code>arn:aws:automate:<i>region</i>:ec2:recover</code> | <code>arn:aws:automate:<i>region</i>:ec2:reboot</code>
        /// | <code>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </code>
        /// | <code>arn:aws:autoscaling:<i>region</i>:<i>account-id</i>:scalingPolicy:<i>policy-id</i>:autoScalingGroupName/<i>group-friendly-name</i>:policyName/<i>policy-friendly-name</i>
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for use with IAM roles): <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Stop/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Terminate/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Reboot/1.0</code>
        /// | <code>arn:aws:swf:<i>region</i>:<i>account-id</i>:action/actions/AWS_EC2.InstanceId.Recover/1.0</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
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
        /// The length, in seconds, used each time the metric specified in <code>MetricName</code>
        /// is evaluated. Valid values are 10, 30, and any multiple of 60.
        /// </para>
        ///  
        /// <para>
        ///  <code>Period</code> is required for alarms based on static thresholds. If you are
        /// creating an alarm based on a metric math expression, you specify the period for each
        /// metric within the objects in the <code>Metrics</code> array.
        /// </para>
        ///  
        /// <para>
        /// Be sure to specify 10 or 30 only for metrics that are stored by a <code>PutMetricData</code>
        /// call with a <code>StorageResolution</code> of 1. If you specify a period of 10 or
        /// 30 for a metric that does not have sub-minute resolution, the alarm still attempts
        /// to gather data at the period rate that you specify. In this case, it does not receive
        /// data for the attempts that do not correspond to a one-minute data resolution, and
        /// the alarm might often lapse into INSUFFICENT_DATA status. Specifying 10 or 30 also
        /// sets this alarm as a high-resolution alarm, which has a higher charge than other alarms.
        /// For more information about pricing, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// An alarm's total current evaluation period can be no longer than one day, so <code>Period</code>
        /// multiplied by <code>EvaluationPeriods</code> cannot be more than 86,400 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The statistic for the metric specified in <code>MetricName</code>, other than percentile.
        /// For percentile statistics, use <code>ExtendedStatistic</code>. When you call <code>PutMetricAlarm</code>
        /// and specify a <code>MetricName</code>, you must specify either <code>Statistic</code>
        /// or <code>ExtendedStatistic,</code> but not both.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the alarm. You can associate as many as
        /// 50 tags with an alarm.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// If you are using this operation to update an existing alarm, any tags you specify
        /// in this parameter are ignored. To change the tags of an existing alarm, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_TagResource.html">TagResource</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value against which the specified statistic is compared.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for alarms based on static thresholds, but should not be
        /// used for alarms based on anomaly detection models.
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
        /// Gets and sets the property ThresholdMetricId. 
        /// <para>
        /// If this is an alarm based on an anomaly detection model, make this value match the
        /// ID of the <code>ANOMALY_DETECTION_BAND</code> function.
        /// </para>
        ///  
        /// <para>
        /// For an example of how to use this parameter, see the <b>Anomaly Detection Model Alarm</b>
        /// example on this page.
        /// </para>
        ///  
        /// <para>
        /// If your alarm uses this parameter, it cannot have Auto Scaling actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        ///  Sets how this alarm is to handle missing data points. If <code>TreatMissingData</code>
        /// is omitted, the default behavior of <code>missing</code> is used. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#alarms-and-missing-data">Configuring
        /// How CloudWatch Alarms Treats Missing Data</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>breaching | notBreaching | ignore | missing</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Alarms that evaluate metrics in the <code>AWS/DynamoDB</code> namespace always <code>ignore</code>
        /// missing data even if you choose a different option for <code>TreatMissingData</code>.
        /// When an <code>AWS/DynamoDB</code> metric has missing data, alarms that evaluate that
        /// metric remain in their current state.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// If you don't specify <code>Unit</code>, CloudWatch retrieves all unit types that have
        /// been published for the metric and attempts to evaluate the alarm. Usually, metrics
        /// are published with only one unit, so the alarm works as intended.
        /// </para>
        ///  
        /// <para>
        /// However, if the metric is published with multiple types of units and you don't specify
        /// a unit, the alarm's behavior is not defined and it behaves unpredictably.
        /// </para>
        ///  
        /// <para>
        /// We recommend omitting <code>Unit</code> so that you don't inadvertently specify an
        /// incorrect unit that is not published for this metric. Doing so causes the alarm to
        /// be stuck in the <code>INSUFFICIENT DATA</code> state.
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