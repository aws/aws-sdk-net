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
    /// Container for the parameters to the SetAlarmState operation.
    /// Temporarily sets the state of an alarm. When the updated <code>StateValue</code>
    /// differs from the previous value, the action configured for the appropriate state is
    /// invoked. This is not a permanent change. The next periodic alarm check (in about a
    /// minute) will set the alarm to its actual state.
    /// </summary>
    public partial class SetAlarmStateRequest : AmazonCloudWatchRequest
    {
        private string _alarmName;
        private string _stateReason;
        private string _stateReasonData;
        private StateValue _stateValue;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        ///  The descriptive name for the alarm. This name must be unique within the user's AWS
        /// account. The maximum length is 255 characters. 
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
        /// Gets and sets the property StateReason. 
        /// <para>
        ///  The reason that this alarm is set to this specific state (in human-readable text
        /// format) 
        /// </para>
        /// </summary>
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
        ///  The reason that this alarm is set to this specific state (in machine-readable JSON
        /// format) 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StateValue. 
        /// <para>
        ///  The value of the state. 
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