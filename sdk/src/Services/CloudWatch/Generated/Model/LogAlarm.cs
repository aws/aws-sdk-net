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
    /// The details about a log alarm.
    /// </summary>
    public partial class LogAlarm
    {
        private int? _actionLogLineCount;
        private string _actionLogLineRoleArn;
        private bool? _actionsEnabled;
        private List<string> _alarmActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _alarmArn;
        private DateTime? _alarmConfigurationUpdatedTimestamp;
        private string _alarmDescription;
        private string _alarmName;
        private ComparisonOperator _comparisonOperator;
        private EvaluationState _evaluationState;
        private List<string> _insufficientDataActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _okActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _queryResultsToAlarm;
        private int? _queryResultsToEvaluate;
        private ScheduledQueryConfiguration _scheduledQueryConfiguration;
        private string _stateReason;
        private string _stateReasonData;
        private DateTime? _stateTransitionedTimestamp;
        private DateTime? _stateUpdatedTimestamp;
        private StateValue _stateValue;
        private double? _threshold;
        private string _treatMissingData;

        /// <summary>
        /// Gets and sets the property ActionLogLineCount. 
        /// <para>
        /// The number of log lines from the most recent scheduled query execution that are included
        /// in alarm action notifications. Valid range is 0 through 50. A value of 0 means no
        /// log lines are included.
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
        /// The Amazon Resource Name (ARN) of the IAM role that CloudWatch assumes to retrieve
        /// log events for inclusion in alarm action notifications. Set when <c>ActionLogLineCount</c>
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
        /// Gets and sets the property AlarmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        public DateTime? AlarmConfigurationUpdatedTimestamp
        {
            get { return this._alarmConfigurationUpdatedTimestamp; }
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
        /// The description of the alarm.
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
        /// The name of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// threshold. The aggregated query result is used as the first operand.
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
        /// Gets and sets the property EvaluationState. 
        /// <para>
        /// If the value of this field is <c>EVALUATION_ERROR</c>, it indicates configuration
        /// errors in the alarm setup that require review and correction. Refer to the <c>StateReason</c>
        /// field of the alarm for more details.
        /// </para>
        ///  
        /// <para>
        /// If the value of this field is <c>EVALUATION_FAILURE</c>, it indicates temporary CloudWatch
        /// issues. We recommend manual monitoring until the issue is resolved.
        /// </para>
        ///  
        /// <para>
        /// If the value of this field is <c>PARTIAL_DATA</c>, it indicates that the query returned
        /// the maximum 500 contributor groups but more matched. The alarm evaluates the available
        /// contributors, but results might be incomplete.
        /// </para>
        /// </summary>
        public EvaluationState EvaluationState
        {
            get { return this._evaluationState; }
            set { this._evaluationState = value; }
        }

        // Check to see if EvaluationState property is set
        internal bool IsSetEvaluationState()
        {
            return this._evaluationState != null;
        }

        /// <summary>
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>INSUFFICIENT_DATA</c>
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
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
        /// (the M in M-of-N evaluation).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The number of most recent scheduled query results that the alarm evaluates against
        /// the threshold (the N in M-of-N evaluation).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The configuration of the underlying CloudWatch Logs scheduled query, including the
        /// query string, log groups, schedule, aggregation expression, and the ARN of the managed
        /// scheduled query.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StateReason. 
        /// <para>
        /// An explanation for the alarm state, in text format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1023)]
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
        /// An explanation for the alarm state, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4000)]
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
        /// Gets and sets the property StateTransitionedTimestamp. 
        /// <para>
        /// The date and time that the alarm's <c>StateValue</c> most recently changed.
        /// </para>
        /// </summary>
        public DateTime? StateTransitionedTimestamp
        {
            get { return this._stateTransitionedTimestamp; }
            set { this._stateTransitionedTimestamp = value; }
        }

        // Check to see if StateTransitionedTimestamp property is set
        internal bool IsSetStateTransitionedTimestamp()
        {
            return this._stateTransitionedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateUpdatedTimestamp. 
        /// <para>
        /// The time stamp of the last update to the value of either the <c>StateValue</c> or
        /// <c>EvaluationState</c> parameters.
        /// </para>
        /// </summary>
        public DateTime? StateUpdatedTimestamp
        {
            get { return this._stateUpdatedTimestamp; }
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
        /// The state value for the alarm.
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
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value to compare with the aggregated query result.
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
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        /// How this alarm handles missing data points. Valid values are <c>breaching</c>, <c>notBreaching</c>,
        /// <c>ignore</c>, and <c>missing</c>.
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