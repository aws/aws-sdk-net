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
    /// The value of the timer. Either the timer action (<c>Unset</c> to delete the timer),
    /// or the duration of the timer in minutes. Only one value can be set.
    /// 
    ///  
    /// <para>
    /// For more information about how chat timeouts work, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-chat-timeouts.html">Set
    /// up chat timeouts for human participants</a>. 
    /// </para>
    /// </summary>
    public partial class ParticipantTimerValue
    {
        /// <summary>
        /// Gets and sets the property ParticipantTimerAction. 
        /// <para>
        /// The timer action. Currently only one value is allowed: <c>Unset</c>. It deletes a
        /// timer.
        /// </para>
        /// </summary>
        public ParticipantTimerAction ParticipantTimerAction { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantTimerAction property is set.
        /// </summary>
        internal bool IsSetParticipantTimerAction() => this.ParticipantTimerAction != null;

        /// <summary>
        /// Gets and sets the property ParticipantTimerDurationInMinutes. 
        /// <para>
        /// The duration of a timer, in minutes. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 480)]
        public int? ParticipantTimerDurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantTimerDurationInMinutes property is set.
        /// </summary>
        internal bool IsSetParticipantTimerDurationInMinutes() => this.ParticipantTimerDurationInMinutes.HasValue;
    }
}
