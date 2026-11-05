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
    /// The details about a composite alarm.
    /// </summary>
    public partial class CompositeAlarm
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
        /// Gets and sets the property ActionsSuppressedBy. 
        /// <para>
        ///  When the value is <c>ALARM</c>, it means that the actions are suppressed because
        /// the suppressor alarm is in <c>ALARM</c> When the value is <c>WaitPeriod</c>, it means
        /// that the actions are suppressed because the composite alarm is waiting for the suppressor
        /// alarm to go into into the <c>ALARM</c> state. The maximum waiting time is as specified
        /// in <c>ActionsSuppressorWaitPeriod</c>. After this time, the composite alarm performs
        /// its actions. When the value is <c>ExtensionPeriod</c>, it means that the actions are
        /// suppressed because the composite alarm is waiting after the suppressor alarm went
        /// out of the <c>ALARM</c> state. The maximum waiting time is as specified in <c>ActionsSuppressorExtensionPeriod</c>.
        /// After this time, the composite alarm performs its actions. 
        /// </para>
        /// </summary>
        public ActionsSuppressedBy ActionsSuppressedBy { get; set; }

        /// <summary>
        /// Checks to see if the ActionsSuppressedBy property is set.
        /// </summary>
        internal bool IsSetActionsSuppressedBy() => this.ActionsSuppressedBy != null;

        /// <summary>
        /// Gets and sets the property ActionsSuppressedReason. 
        /// <para>
        ///  Captures the reason for action suppression. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ActionsSuppressedReason { get; set; }

        /// <summary>
        /// Checks to see if the ActionsSuppressedReason property is set.
        /// </summary>
        internal bool IsSetActionsSuppressedReason() => this.ActionsSuppressedReason != null;

        /// <summary>
        /// Gets and sets the property ActionsSuppressor. 
        /// <para>
        ///  Actions will be suppressed if the suppressor alarm is in the <c>ALARM</c> state.
        /// <c>ActionsSuppressor</c> can be an AlarmName or an Amazon Resource Name (ARN) from
        /// an existing alarm. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ActionsSuppressor { get; set; }

        /// <summary>
        /// Checks to see if the ActionsSuppressor property is set.
        /// </summary>
        internal bool IsSetActionsSuppressor() => this.ActionsSuppressor != null;

        /// <summary>
        /// Gets and sets the property ActionsSuppressorExtensionPeriod. 
        /// <para>
        ///  The maximum time in seconds that the composite alarm waits after suppressor alarm
        /// goes out of the <c>ALARM</c> state. After this time, the composite alarm performs
        /// its actions. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>ExtensionPeriod</c> is required only when <c>ActionsSuppressor</c> is specified.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        public int? ActionsSuppressorExtensionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ActionsSuppressorExtensionPeriod property is set.
        /// </summary>
        internal bool IsSetActionsSuppressorExtensionPeriod() => this.ActionsSuppressorExtensionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property ActionsSuppressorWaitPeriod. 
        /// <para>
        ///  The maximum time in seconds that the composite alarm waits for the suppressor alarm
        /// to go into the <c>ALARM</c> state. After this time, the composite alarm performs its
        /// actions. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>WaitPeriod</c> is required only when <c>ActionsSuppressor</c> is specified. 
        /// </para>
        ///  </important>
        /// </summary>
        public int? ActionsSuppressorWaitPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ActionsSuppressorWaitPeriod property is set.
        /// </summary>
        internal bool IsSetActionsSuppressorWaitPeriod() => this.ActionsSuppressorWaitPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property AlarmActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the ALARM state from any other
        /// state. Each action is specified as an Amazon Resource Name (ARN).
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
        /// Gets and sets the property AlarmRule. 
        /// <para>
        /// The rule that this alarm uses to evaluate its alarm state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string AlarmRule { get; set; }

        /// <summary>
        /// Checks to see if the AlarmRule property is set.
        /// </summary>
        internal bool IsSetAlarmRule() => this.AlarmRule != null;

        /// <summary>
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the INSUFFICIENT_DATA state
        /// from any other state. Each action is specified as an Amazon Resource Name (ARN).
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
        /// The actions to execute when this alarm transitions to the OK state from any other
        /// state. Each action is specified as an Amazon Resource Name (ARN).
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
        ///  The timestamp of the last change to the alarm's <c>StateValue</c>. 
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
        /// Tracks the timestamp of any state update, even if <c>StateValue</c> doesn't change.
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
    }
}
