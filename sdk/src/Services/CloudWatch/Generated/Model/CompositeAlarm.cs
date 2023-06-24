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
    /// The details about a composite alarm.
    /// </summary>
    public partial class CompositeAlarm
    {
        private bool? _actionsEnabled;
        private ActionsSuppressedBy _actionsSuppressedBy;
        private string _actionsSuppressedReason;
        private string _actionsSuppressor;
        private int? _actionsSuppressorExtensionPeriod;
        private int? _actionsSuppressorWaitPeriod;
        private List<string> _alarmActions = new List<string>();
        private string _alarmArn;
        private DateTime? _alarmConfigurationUpdatedTimestamp;
        private string _alarmDescription;
        private string _alarmName;
        private string _alarmRule;
        private List<string> _insufficientDataActions = new List<string>();
        private List<string> _okActions = new List<string>();
        private string _stateReason;
        private string _stateReasonData;
        private DateTime? _stateTransitionedTimestamp;
        private DateTime? _stateUpdatedTimestamp;
        private StateValue _stateValue;

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
        /// Gets and sets the property ActionsSuppressedBy. 
        /// <para>
        ///  When the value is <code>ALARM</code>, it means that the actions are suppressed because
        /// the suppressor alarm is in <code>ALARM</code> When the value is <code>WaitPeriod</code>,
        /// it means that the actions are suppressed because the composite alarm is waiting for
        /// the suppressor alarm to go into into the <code>ALARM</code> state. The maximum waiting
        /// time is as specified in <code>ActionsSuppressorWaitPeriod</code>. After this time,
        /// the composite alarm performs its actions. When the value is <code>ExtensionPeriod</code>,
        /// it means that the actions are suppressed because the composite alarm is waiting after
        /// the suppressor alarm went out of the <code>ALARM</code> state. The maximum waiting
        /// time is as specified in <code>ActionsSuppressorExtensionPeriod</code>. After this
        /// time, the composite alarm performs its actions. 
        /// </para>
        /// </summary>
        public ActionsSuppressedBy ActionsSuppressedBy
        {
            get { return this._actionsSuppressedBy; }
            set { this._actionsSuppressedBy = value; }
        }

        // Check to see if ActionsSuppressedBy property is set
        internal bool IsSetActionsSuppressedBy()
        {
            return this._actionsSuppressedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ActionsSuppressedReason. 
        /// <para>
        ///  Captures the reason for action suppression. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ActionsSuppressedReason
        {
            get { return this._actionsSuppressedReason; }
            set { this._actionsSuppressedReason = value; }
        }

        // Check to see if ActionsSuppressedReason property is set
        internal bool IsSetActionsSuppressedReason()
        {
            return this._actionsSuppressedReason != null;
        }

        /// <summary>
        /// Gets and sets the property ActionsSuppressor. 
        /// <para>
        ///  Actions will be suppressed if the suppressor alarm is in the <code>ALARM</code> state.
        /// <code>ActionsSuppressor</code> can be an AlarmName or an Amazon Resource Name (ARN)
        /// from an existing alarm. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ActionsSuppressor
        {
            get { return this._actionsSuppressor; }
            set { this._actionsSuppressor = value; }
        }

        // Check to see if ActionsSuppressor property is set
        internal bool IsSetActionsSuppressor()
        {
            return this._actionsSuppressor != null;
        }

        /// <summary>
        /// Gets and sets the property ActionsSuppressorExtensionPeriod. 
        /// <para>
        ///  The maximum time in seconds that the composite alarm waits after suppressor alarm
        /// goes out of the <code>ALARM</code> state. After this time, the composite alarm performs
        /// its actions. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  <code>ExtensionPeriod</code> is required only when <code>ActionsSuppressor</code>
        /// is specified. 
        /// </para>
        ///  </important>
        /// </summary>
        public int ActionsSuppressorExtensionPeriod
        {
            get { return this._actionsSuppressorExtensionPeriod.GetValueOrDefault(); }
            set { this._actionsSuppressorExtensionPeriod = value; }
        }

        // Check to see if ActionsSuppressorExtensionPeriod property is set
        internal bool IsSetActionsSuppressorExtensionPeriod()
        {
            return this._actionsSuppressorExtensionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActionsSuppressorWaitPeriod. 
        /// <para>
        ///  The maximum time in seconds that the composite alarm waits for the suppressor alarm
        /// to go into the <code>ALARM</code> state. After this time, the composite alarm performs
        /// its actions. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  <code>WaitPeriod</code> is required only when <code>ActionsSuppressor</code> is specified.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        public int ActionsSuppressorWaitPeriod
        {
            get { return this._actionsSuppressorWaitPeriod.GetValueOrDefault(); }
            set { this._actionsSuppressorWaitPeriod = value; }
        }

        // Check to see if ActionsSuppressorWaitPeriod property is set
        internal bool IsSetActionsSuppressorWaitPeriod()
        {
            return this._actionsSuppressorWaitPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlarmActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the ALARM state from any other
        /// state. Each action is specified as an Amazon Resource Name (ARN).
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
        /// Gets and sets the property AlarmRule. 
        /// <para>
        /// The rule that this alarm uses to evaluate its alarm state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string AlarmRule
        {
            get { return this._alarmRule; }
            set { this._alarmRule = value; }
        }

        // Check to see if AlarmRule property is set
        internal bool IsSetAlarmRule()
        {
            return this._alarmRule != null;
        }

        /// <summary>
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the INSUFFICIENT_DATA state
        /// from any other state. Each action is specified as an Amazon Resource Name (ARN).
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
        /// Gets and sets the property OKActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the OK state from any other
        /// state. Each action is specified as an Amazon Resource Name (ARN).
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
        ///  The timestamp of the last change to the alarm's <code>StateValue</code>. 
        /// </para>
        /// </summary>
        public DateTime StateTransitionedTimestamp
        {
            get { return this._stateTransitionedTimestamp.GetValueOrDefault(); }
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
        /// Tracks the timestamp of any state update, even if <code>StateValue</code> doesn't
        /// change.
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

    }
}