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
    /// Configuration information for the timer. After the timer configuration is set, it
    /// persists for the duration of the chat. It persists across new contacts in the chain,
    /// for example, transfer contacts.
    /// 
    ///  
    /// <para>
    /// For more information about how chat timeouts work, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-chat-timeouts.html">Set
    /// up chat timeouts for human participants</a>. 
    /// </para>
    /// </summary>
    public partial class ParticipantTimerConfiguration
    {
        private TimerEligibleParticipantRoles _participantRole;
        private ParticipantTimerType _timerType;
        private ParticipantTimerValue _timerValue;

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the participant in the chat conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimerEligibleParticipantRoles ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

        /// <summary>
        /// Gets and sets the property TimerType. 
        /// <para>
        /// The type of timer. <code>IDLE</code> indicates the timer applies for considering a
        /// human chat participant as idle. <code>DISCONNECT_NONCUSTOMER</code> indicates the
        /// timer applies to automatically disconnecting a chat participant due to idleness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParticipantTimerType TimerType
        {
            get { return this._timerType; }
            set { this._timerType = value; }
        }

        // Check to see if TimerType property is set
        internal bool IsSetTimerType()
        {
            return this._timerType != null;
        }

        /// <summary>
        /// Gets and sets the property TimerValue. 
        /// <para>
        /// The value of the timer. Either the timer action (Unset to delete the timer), or the
        /// duration of the timer in minutes. Only one value can be set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParticipantTimerValue TimerValue
        {
            get { return this._timerValue; }
            set { this._timerValue = value; }
        }

        // Check to see if TimerValue property is set
        internal bool IsSetTimerValue()
        {
            return this._timerValue != null;
        }

    }
}