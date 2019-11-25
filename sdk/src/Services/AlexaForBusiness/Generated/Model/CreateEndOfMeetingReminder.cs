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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Creates settings for the end of meeting reminder feature that are applied to a room
    /// profile. The end of meeting reminder enables Alexa to remind users when a meeting
    /// is ending.
    /// </summary>
    public partial class CreateEndOfMeetingReminder
    {
        private bool? _enabled;
        private List<int> _reminderAtMinutes = new List<int>();
        private EndOfMeetingReminderType _reminderType;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether an end of meeting reminder is enabled or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReminderAtMinutes. 
        /// <para>
        ///  A range of 3 to 15 minutes that determines when the reminder begins.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<int> ReminderAtMinutes
        {
            get { return this._reminderAtMinutes; }
            set { this._reminderAtMinutes = value; }
        }

        // Check to see if ReminderAtMinutes property is set
        internal bool IsSetReminderAtMinutes()
        {
            return this._reminderAtMinutes != null && this._reminderAtMinutes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReminderType. 
        /// <para>
        /// The type of sound that users hear during the end of meeting reminder. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndOfMeetingReminderType ReminderType
        {
            get { return this._reminderType; }
            set { this._reminderType = value; }
        }

        // Check to see if ReminderType property is set
        internal bool IsSetReminderType()
        {
            return this._reminderType != null;
        }

    }
}