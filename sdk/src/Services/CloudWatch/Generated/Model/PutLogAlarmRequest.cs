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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the PutLogAlarm operation.
    /// Creates or updates a log alarm. A log alarm evaluates the results of a CloudWatch
    /// Logs scheduled query against the configured threshold and comparison operator to determine
    /// its state.
    /// 
    ///  
    /// <para>
    /// When you create a log alarm, the operation creates a service-managed CloudWatch Logs
    /// scheduled query that runs the query string you provide on the schedule you configure.
    /// Each scheduled query execution returns one or more aggregated values determined by
    /// the <c>AggregationExpression</c>, and each aggregated value is compared against the
    /// alarm <c>Threshold</c> to determine the alarm state. The alarm uses M-out-of-N evaluation:
    /// if <c>QueryResultsToAlarm</c> out of the most recent <c>QueryResultsToEvaluate</c>
    /// query results breach the threshold, the alarm transitions to <c>ALARM</c>.
    /// </para>
    ///  
    /// <para>
    /// Log alarms support the alarm states (<c>OK</c>, <c>ALARM</c>, <c>INSUFFICIENT_DATA</c>).
    /// Configure transition actions using <c>OKActions</c>, <c>AlarmActions</c>, and <c>InsufficientDataActions</c>.
    /// </para>
    ///  
    /// <para>
    /// If you call this operation with the name of an existing log alarm, the operation replaces
    /// the previous configuration of that alarm.
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To create or update a log alarm, you must have the <c>cloudwatch:PutLogAlarm</c> permission.
    /// The IAM role specified in <c>ScheduledQueryRoleARN</c> must grant the CloudWatch Alarms
    /// service permission to execute scheduled queries on the specified log groups. If you
    /// set <c>ActionLogLineCount</c>, the role specified in <c>ActionLogLineRoleArn</c> must
    /// grant permission to retrieve log events for inclusion in alarm notifications.
    /// </para>
    /// </summary>
    public partial class PutLogAlarmRequest : AmazonCloudWatchRequest
    {
        private int? _actionLogLineCount;
        private string _actionLogLineRoleArn;
        private bool? _actionsEnabled;
        private List<string> _alarmActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _alarmDescription;
        private string _alarmName;
        private ComparisonOperator _comparisonOperator;
        private List<string> _insufficientDataActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _okActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _queryResultsToAlarm;
        private int? _queryResultsToEvaluate;
        private ScheduledQueryConfiguration _scheduledQueryConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private double? _threshold;
        private string _treatMissingData;

        /// <summary>
        /// Gets and sets the property ActionLogLineCount. 
        /// <para>
        /// The number of log lines from the most recent scheduled query execution to include
        /// in alarm action notifications. Valid range is 0 through 50. The default is 0, which
        /// means no log lines are included.
        /// </para>
        /// </summary>
        public int? ActionLogLineCount
        {
            get { return this._actionLogLineCount; }
            set { this._actionLogLineCount = value; }
        }

        // Check to see if ActionLogLineCount property is set
        internal bool IsSetActionLogLineCount()
        {
            return this._actionLogLineCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActionLogLineRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that CloudWatch assumes to retrieve
        /// log events for inclusion in alarm action notifications. Required when <c>ActionLogLineCount</c>
        /// is greater than 0.
        /// </para>
        /// </summary>
        public string ActionLogLineRoleArn
        {
            get { return this._actionLogLineRoleArn; }
            set { this._actionLogLineRoleArn = value; }
        }

        // Check to see if ActionLogLineRoleArn property is set
        internal bool IsSetActionLogLineRoleArn()
        {
            return this._actionLogLineRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether actions should be executed during any changes to the alarm state.
        /// The default is <c>true</c>.
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
        /// The actions to execute when this alarm transitions to the <c>ALARM</c> state from
        /// any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon SNS actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda actions:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Invoke the latest version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a specific version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>version-number</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a function by using an alias Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>alias-name</i>
        /// </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Systems Manager actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:ssm:<i>region</i>:<i>account-id</i>:opsitem:<i>severity</i> </c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._alarmActions != null && (this._alarmActions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The name for the alarm. This name must be unique within the Amazon Web Services account
        /// and Region.
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
        /// The arithmetic operation to use when comparing the aggregated query result and the
        /// threshold. The aggregated query result is used as the first operand. Valid values
        /// are <c>GreaterThanThreshold</c>, <c>GreaterThanOrEqualToThreshold</c>, <c>LessThanThreshold</c>,
        /// and <c>LessThanOrEqualToThreshold</c>.
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
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>INSUFFICIENT_DATA</c>
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon SNS actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda actions:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Invoke the latest version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a specific version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>version-number</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a function by using an alias Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>alias-name</i>
        /// </c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._insufficientDataActions != null && (this._insufficientDataActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OKActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>OK</c> state from any
        /// other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon SNS actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda actions:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Invoke the latest version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a specific version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>version-number</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a function by using an alias Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>alias-name</i>
        /// </c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._okActions != null && (this._okActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryResultsToAlarm. 
        /// <para>
        /// The number of query results, out of the most recent <c>QueryResultsToEvaluate</c>
        /// results, that must breach the threshold to trigger the alarm to transition to <c>ALARM</c>
        /// (the M in M-of-N evaluation). Must be less than or equal to <c>QueryResultsToEvaluate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? QueryResultsToAlarm
        {
            get { return this._queryResultsToAlarm; }
            set { this._queryResultsToAlarm = value; }
        }

        // Check to see if QueryResultsToAlarm property is set
        internal bool IsSetQueryResultsToAlarm()
        {
            return this._queryResultsToAlarm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryResultsToEvaluate. 
        /// <para>
        /// The number of most recent scheduled query results to evaluate against the threshold
        /// (the N in M-of-N evaluation). Valid range is 1 through 100.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? QueryResultsToEvaluate
        {
            get { return this._queryResultsToEvaluate; }
            set { this._queryResultsToEvaluate = value; }
        }

        // Check to see if QueryResultsToEvaluate property is set
        internal bool IsSetQueryResultsToEvaluate()
        {
            return this._queryResultsToEvaluate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledQueryConfiguration. 
        /// <para>
        /// The configuration of the underlying CloudWatch Logs scheduled query that this alarm
        /// evaluates, including the query string, log groups, schedule, and aggregation expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledQueryConfiguration ScheduledQueryConfiguration
        {
            get { return this._scheduledQueryConfiguration; }
            set { this._scheduledQueryConfiguration = value; }
        }

        // Check to see if ScheduledQueryConfiguration property is set
        internal bool IsSetScheduledQueryConfiguration()
        {
            return this._scheduledQueryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the alarm. You can use tags to categorize
        /// and manage your alarms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value to compare with the aggregated query result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        /// Sets how this alarm is to handle missing data points. Valid values are <c>breaching</c>,
        /// <c>notBreaching</c>, <c>ignore</c>, and <c>missing</c>. If this parameter is omitted,
        /// the default behavior of <c>missing</c> is used.
        /// </para>
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

    }
}