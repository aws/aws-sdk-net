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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The value of the timer. Either the timer action (<code>Unset</code> to delete the
    /// timer), or the duration of the timer in minutes. Only one value can be set.
    /// 
    ///  
    /// <para>
    /// For more information about how chat timeouts work, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-chat-timeouts.html">Set
    /// up chat timeouts for human participants</a>. 
    /// </para>
    /// </summary>
    public partial class ParticipantTimerValue
    {
        private ParticipantTimerAction _participantTimerAction;
        private int? _participantTimerDurationInMinutes;

        /// <summary>
        /// Gets and sets the property ParticipantTimerAction. 
        /// <para>
        /// The timer action. Currently only one value is allowed: <code>Unset</code>. It deletes
        /// a timer.
        /// </para>
        /// </summary>
        public ParticipantTimerAction ParticipantTimerAction
        {
            get { return this._participantTimerAction; }
            set { this._participantTimerAction = value; }
        }

        // Check to see if ParticipantTimerAction property is set
        internal bool IsSetParticipantTimerAction()
        {
            return this._participantTimerAction != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantTimerDurationInMinutes. 
        /// <para>
        /// The duration of a timer, in minutes. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=480)]
        public int ParticipantTimerDurationInMinutes
        {
            get { return this._participantTimerDurationInMinutes.GetValueOrDefault(); }
            set { this._participantTimerDurationInMinutes = value; }
        }

        // Check to see if ParticipantTimerDurationInMinutes property is set
        internal bool IsSetParticipantTimerDurationInMinutes()
        {
            return this._participantTimerDurationInMinutes.HasValue; 
        }

    }
}