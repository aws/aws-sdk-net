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
        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the participant in the chat conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimerEligibleParticipantRoles ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;

        /// <summary>
        /// Gets and sets the property TimerType. 
        /// <para>
        /// The type of timer. <c>IDLE</c> indicates the timer applies for considering a human
        /// chat participant as idle. <c>DISCONNECT_NONCUSTOMER</c> indicates the timer applies
        /// to automatically disconnecting a chat participant due to idleness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantTimerType TimerType { get; set; }

        /// <summary>
        /// Checks to see if the TimerType property is set.
        /// </summary>
        internal bool IsSetTimerType() => this.TimerType != null;

        /// <summary>
        /// Gets and sets the property TimerValue. 
        /// <para>
        /// The value of the timer. Either the timer action (Unset to delete the timer), or the
        /// duration of the timer in minutes. Only one value can be set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantTimerValue TimerValue { get; set; }

        /// <summary>
        /// Checks to see if the TimerValue property is set.
        /// </summary>
        internal bool IsSetTimerValue() => this.TimerValue != null;
    }
}
