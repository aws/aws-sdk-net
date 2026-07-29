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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// A suggested action displayed to the RCS message recipient. Can be a reply, open URL,
    /// dial phone, show location, request location, or create calendar event.
    /// </summary>
    public partial class RcsSuggestedAction
    {
        private RcsCreateCalendarEventAction _createCalendarEvent;
        private RcsDialPhoneAction _dialPhone;
        private RcsOpenUrlAction _openUrl;
        private RcsReplyAction _reply;
        private RcsRequestLocationAction _requestLocation;
        private RcsShowLocationAction _showLocation;

        /// <summary>
        /// Gets and sets the property CreateCalendarEvent. 
        /// <para>
        /// A suggested action that creates a calendar event on the user's device.
        /// </para>
        /// </summary>
        public RcsCreateCalendarEventAction CreateCalendarEvent
        {
            get { return this._createCalendarEvent; }
            set { this._createCalendarEvent = value; }
        }

        // Check to see if CreateCalendarEvent property is set
        internal bool IsSetCreateCalendarEvent()
        {
            return this._createCalendarEvent != null;
        }

        /// <summary>
        /// Gets and sets the property DialPhone. 
        /// <para>
        /// A suggested action that initiates a phone call to the specified number.
        /// </para>
        /// </summary>
        public RcsDialPhoneAction DialPhone
        {
            get { return this._dialPhone; }
            set { this._dialPhone = value; }
        }

        // Check to see if DialPhone property is set
        internal bool IsSetDialPhone()
        {
            return this._dialPhone != null;
        }

        /// <summary>
        /// Gets and sets the property OpenUrl. 
        /// <para>
        /// A suggested action that opens a URL in the user's browser or a webview.
        /// </para>
        /// </summary>
        public RcsOpenUrlAction OpenUrl
        {
            get { return this._openUrl; }
            set { this._openUrl = value; }
        }

        // Check to see if OpenUrl property is set
        internal bool IsSetOpenUrl()
        {
            return this._openUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Reply. 
        /// <para>
        /// A suggested reply that sends predefined text and postback data when tapped.
        /// </para>
        /// </summary>
        public RcsReplyAction Reply
        {
            get { return this._reply; }
            set { this._reply = value; }
        }

        // Check to see if Reply property is set
        internal bool IsSetReply()
        {
            return this._reply != null;
        }

        /// <summary>
        /// Gets and sets the property RequestLocation. 
        /// <para>
        /// A suggested action that requests the user's current location.
        /// </para>
        /// </summary>
        public RcsRequestLocationAction RequestLocation
        {
            get { return this._requestLocation; }
            set { this._requestLocation = value; }
        }

        // Check to see if RequestLocation property is set
        internal bool IsSetRequestLocation()
        {
            return this._requestLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ShowLocation. 
        /// <para>
        /// A suggested action that shows a location on a map.
        /// </para>
        /// </summary>
        public RcsShowLocationAction ShowLocation
        {
            get { return this._showLocation; }
            set { this._showLocation = value; }
        }

        // Check to see if ShowLocation property is set
        internal bool IsSetShowLocation()
        {
            return this._showLocation != null;
        }

    }
}