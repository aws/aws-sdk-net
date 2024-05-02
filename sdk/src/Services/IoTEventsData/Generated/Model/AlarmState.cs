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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Contains information about the current state of the alarm.
    /// </summary>
    public partial class AlarmState
    {
        private CustomerAction _customerAction;
        private RuleEvaluation _ruleEvaluation;
        private AlarmStateName _stateName;
        private SystemEvent _systemEvent;

        /// <summary>
        /// Gets and sets the property CustomerAction. 
        /// <para>
        /// Contains information about the action that you can take to respond to the alarm.
        /// </para>
        /// </summary>
        public CustomerAction CustomerAction
        {
            get { return this._customerAction; }
            set { this._customerAction = value; }
        }

        // Check to see if CustomerAction property is set
        internal bool IsSetCustomerAction()
        {
            return this._customerAction != null;
        }

        /// <summary>
        /// Gets and sets the property RuleEvaluation. 
        /// <para>
        /// Information needed to evaluate data.
        /// </para>
        /// </summary>
        public RuleEvaluation RuleEvaluation
        {
            get { return this._ruleEvaluation; }
            set { this._ruleEvaluation = value; }
        }

        // Check to see if RuleEvaluation property is set
        internal bool IsSetRuleEvaluation()
        {
            return this._ruleEvaluation != null;
        }

        /// <summary>
        /// Gets and sets the property StateName. 
        /// <para>
        /// The name of the alarm state. The state name can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DISABLED</c> - When the alarm is in the <c>DISABLED</c> state, it isn't ready
        /// to evaluate data. To enable the alarm, you must change the alarm to the <c>NORMAL</c>
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NORMAL</c> - When the alarm is in the <c>NORMAL</c> state, it's ready to evaluate
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - If the alarm is in the <c>ACTIVE</c> state, the alarm is invoked.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACKNOWLEDGED</c> - When the alarm is in the <c>ACKNOWLEDGED</c> state, the alarm
        /// was invoked and you acknowledged the alarm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SNOOZE_DISABLED</c> - When the alarm is in the <c>SNOOZE_DISABLED</c> state, the
        /// alarm is disabled for a specified period of time. After the snooze time, the alarm
        /// automatically changes to the <c>NORMAL</c> state. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LATCHED</c> - When the alarm is in the <c>LATCHED</c> state, the alarm was invoked.
        /// However, the data that the alarm is currently evaluating is within the specified range.
        /// To change the alarm to the <c>NORMAL</c> state, you must acknowledge the alarm.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AlarmStateName StateName
        {
            get { return this._stateName; }
            set { this._stateName = value; }
        }

        // Check to see if StateName property is set
        internal bool IsSetStateName()
        {
            return this._stateName != null;
        }

        /// <summary>
        /// Gets and sets the property SystemEvent. 
        /// <para>
        /// Contains information about alarm state changes.
        /// </para>
        /// </summary>
        public SystemEvent SystemEvent
        {
            get { return this._systemEvent; }
            set { this._systemEvent = value; }
        }

        // Check to see if SystemEvent property is set
        internal bool IsSetSystemEvent()
        {
            return this._systemEvent != null;
        }

    }
}