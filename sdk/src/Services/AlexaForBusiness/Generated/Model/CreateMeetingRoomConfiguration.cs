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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Creates meeting room settings of a room profile.
    /// </summary>
    public partial class CreateMeetingRoomConfiguration
    {
        private CreateEndOfMeetingReminder _endOfMeetingReminder;
        private CreateInstantBooking _instantBooking;
        private CreateProactiveJoin _proactiveJoin;
        private CreateRequireCheckIn _requireCheckIn;
        private bool? _roomUtilizationMetricsEnabled;

        /// <summary>
        /// Gets and sets the property EndOfMeetingReminder.
        /// </summary>
        public CreateEndOfMeetingReminder EndOfMeetingReminder
        {
            get { return this._endOfMeetingReminder; }
            set { this._endOfMeetingReminder = value; }
        }

        // Check to see if EndOfMeetingReminder property is set
        internal bool IsSetEndOfMeetingReminder()
        {
            return this._endOfMeetingReminder != null;
        }

        /// <summary>
        /// Gets and sets the property InstantBooking. 
        /// <para>
        /// Settings to automatically book a room for a configured duration if it's free when
        /// joining a meeting with Alexa.
        /// </para>
        /// </summary>
        public CreateInstantBooking InstantBooking
        {
            get { return this._instantBooking; }
            set { this._instantBooking = value; }
        }

        // Check to see if InstantBooking property is set
        internal bool IsSetInstantBooking()
        {
            return this._instantBooking != null;
        }

        /// <summary>
        /// Gets and sets the property ProactiveJoin.
        /// </summary>
        public CreateProactiveJoin ProactiveJoin
        {
            get { return this._proactiveJoin; }
            set { this._proactiveJoin = value; }
        }

        // Check to see if ProactiveJoin property is set
        internal bool IsSetProactiveJoin()
        {
            return this._proactiveJoin != null;
        }

        /// <summary>
        /// Gets and sets the property RequireCheckIn. 
        /// <para>
        /// Settings for requiring a check in when a room is reserved. Alexa can cancel a room
        /// reservation if it's not checked into to make the room available for others. Users
        /// can check in by joining the meeting with Alexa or an AVS device, or by saying “Alexa,
        /// check in.”
        /// </para>
        /// </summary>
        public CreateRequireCheckIn RequireCheckIn
        {
            get { return this._requireCheckIn; }
            set { this._requireCheckIn = value; }
        }

        // Check to see if RequireCheckIn property is set
        internal bool IsSetRequireCheckIn()
        {
            return this._requireCheckIn != null;
        }

        /// <summary>
        /// Gets and sets the property RoomUtilizationMetricsEnabled. 
        /// <para>
        /// Whether room utilization metrics are enabled or not.
        /// </para>
        /// </summary>
        public bool RoomUtilizationMetricsEnabled
        {
            get { return this._roomUtilizationMetricsEnabled.GetValueOrDefault(); }
            set { this._roomUtilizationMetricsEnabled = value; }
        }

        // Check to see if RoomUtilizationMetricsEnabled property is set
        internal bool IsSetRoomUtilizationMetricsEnabled()
        {
            return this._roomUtilizationMetricsEnabled.HasValue; 
        }

    }
}