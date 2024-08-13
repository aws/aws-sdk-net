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
    /// Contains a summary of an alarm.
    /// </summary>
    public partial class AlarmSummary
    {
        private string _alarmModelName;
        private string _alarmModelVersion;
        private DateTime? _creationTime;
        private string _keyValue;
        private DateTime? _lastUpdateTime;
        private AlarmStateName _stateName;

        /// <summary>
        /// Gets and sets the property AlarmModelName. 
        /// <para>
        /// The name of the alarm model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AlarmModelName
        {
            get { return this._alarmModelName; }
            set { this._alarmModelName = value; }
        }

        // Check to see if AlarmModelName property is set
        internal bool IsSetAlarmModelName()
        {
            return this._alarmModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmModelVersion. 
        /// <para>
        /// The version of the alarm model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AlarmModelVersion
        {
            get { return this._alarmModelVersion; }
            set { this._alarmModelVersion = value; }
        }

        // Check to see if AlarmModelVersion property is set
        internal bool IsSetAlarmModelVersion()
        {
            return this._alarmModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the alarm was created, in the Unix epoch format.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyValue. 
        /// <para>
        /// The value of the key used as a filter to select only the alarms associated with the
        /// <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_CreateAlarmModel.html#iotevents-CreateAlarmModel-request-key">key</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string KeyValue
        {
            get { return this._keyValue; }
            set { this._keyValue = value; }
        }

        // Check to see if KeyValue property is set
        internal bool IsSetKeyValue()
        {
            return this._keyValue != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time the alarm was last updated, in the Unix epoch format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
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

    }
}