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
    /// The details about a log alarm.
    /// </summary>
    public partial class LogAlarm
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
        /// Gets and sets the property ActionLogLineCount. 
        /// <para>
        /// The number of log lines from the most recent scheduled query execution that are included
        /// in alarm action notifications. Valid range is 0 through 50. A value of 0 means no
        /// log lines are included.
        /// </para>
        /// </summary>
        public int? ActionLogLineCount { get; set; }

        /// <summary>
        /// Checks to see if the ActionLogLineCount property is set.
        /// </summary>
        internal bool IsSetActionLogLineCount() => this.ActionLogLineCount.HasValue;

        /// <summary>
        /// Gets and sets the property ActionLogLineRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that CloudWatch assumes to retrieve
        /// log events for inclusion in alarm action notifications. Set when <c>ActionLogLineCount</c>
        /// is greater than 0.
        /// </para>
        /// </summary>
        public string ActionLogLineRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ActionLogLineRoleArn property is set.
        /// </summary>
        internal bool IsSetActionLogLineRoleArn() => this.ActionLogLineRoleArn != null;

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
        /// The arithmetic operation to use when comparing the aggregated query result and the
        /// threshold. The aggregated query result is used as the first operand.
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

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
        public EvaluationState EvaluationState { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationState property is set.
        /// </summary>
        internal bool IsSetEvaluationState() => this.EvaluationState != null;

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
        /// Gets and sets the property QueryResultsToAlarm. 
        /// <para>
        /// The number of query results, out of the most recent <c>QueryResultsToEvaluate</c>
        /// results, that must breach the threshold to trigger the alarm to transition to <c>ALARM</c>
        /// (the M in M-of-N evaluation).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? QueryResultsToAlarm { get; set; }

        /// <summary>
        /// Checks to see if the QueryResultsToAlarm property is set.
        /// </summary>
        internal bool IsSetQueryResultsToAlarm() => this.QueryResultsToAlarm.HasValue;

        /// <summary>
        /// Gets and sets the property QueryResultsToEvaluate. 
        /// <para>
        /// The number of most recent scheduled query results that the alarm evaluates against
        /// the threshold (the N in M-of-N evaluation).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? QueryResultsToEvaluate { get; set; }

        /// <summary>
        /// Checks to see if the QueryResultsToEvaluate property is set.
        /// </summary>
        internal bool IsSetQueryResultsToEvaluate() => this.QueryResultsToEvaluate.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduledQueryConfiguration. 
        /// <para>
        /// The configuration of the underlying CloudWatch Logs scheduled query, including the
        /// query string, log groups, schedule, aggregation expression, and the ARN of the managed
        /// scheduled query.
        /// </para>
        /// </summary>
        public ScheduledQueryConfiguration ScheduledQueryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledQueryConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduledQueryConfiguration() => this.ScheduledQueryConfiguration != null;

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
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value to compare with the aggregated query result.
        /// </para>
        /// </summary>
        public double? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        /// How this alarm handles missing data points. Valid values are <c>breaching</c>, <c>notBreaching</c>,
        /// <c>ignore</c>, and <c>missing</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TreatMissingData { get; set; }

        /// <summary>
        /// Checks to see if the TreatMissingData property is set.
        /// </summary>
        internal bool IsSetTreatMissingData() => this.TreatMissingData != null;

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
