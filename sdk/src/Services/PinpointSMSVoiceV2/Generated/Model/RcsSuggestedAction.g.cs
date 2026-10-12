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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// A suggested action displayed to the RCS message recipient. Can be a reply, open URL,
    /// dial phone, show location, request location, or create calendar event.
    /// </summary>
    public partial class RcsSuggestedAction
    {
        /// <summary>
        /// Gets and sets the property CreateCalendarEvent. 
        /// <para>
        /// A suggested action that creates a calendar event on the user's device.
        /// </para>
        /// </summary>
        public RcsCreateCalendarEventAction CreateCalendarEvent { get; set; }

        /// <summary>
        /// Checks to see if the CreateCalendarEvent property is set.
        /// </summary>
        internal bool IsSetCreateCalendarEvent() => this.CreateCalendarEvent != null;

        /// <summary>
        /// Gets and sets the property DialPhone. 
        /// <para>
        /// A suggested action that initiates a phone call to the specified number.
        /// </para>
        /// </summary>
        public RcsDialPhoneAction DialPhone { get; set; }

        /// <summary>
        /// Checks to see if the DialPhone property is set.
        /// </summary>
        internal bool IsSetDialPhone() => this.DialPhone != null;

        /// <summary>
        /// Gets and sets the property OpenUrl. 
        /// <para>
        /// A suggested action that opens a URL in the user's browser or a webview.
        /// </para>
        /// </summary>
        public RcsOpenUrlAction OpenUrl { get; set; }

        /// <summary>
        /// Checks to see if the OpenUrl property is set.
        /// </summary>
        internal bool IsSetOpenUrl() => this.OpenUrl != null;

        /// <summary>
        /// Gets and sets the property Reply. 
        /// <para>
        /// A suggested reply that sends predefined text and postback data when tapped.
        /// </para>
        /// </summary>
        public RcsReplyAction Reply { get; set; }

        /// <summary>
        /// Checks to see if the Reply property is set.
        /// </summary>
        internal bool IsSetReply() => this.Reply != null;

        /// <summary>
        /// Gets and sets the property RequestLocation. 
        /// <para>
        /// A suggested action that requests the user's current location.
        /// </para>
        /// </summary>
        public RcsRequestLocationAction RequestLocation { get; set; }

        /// <summary>
        /// Checks to see if the RequestLocation property is set.
        /// </summary>
        internal bool IsSetRequestLocation() => this.RequestLocation != null;

        /// <summary>
        /// Gets and sets the property ShowLocation. 
        /// <para>
        /// A suggested action that shows a location on a map.
        /// </para>
        /// </summary>
        public RcsShowLocationAction ShowLocation { get; set; }

        /// <summary>
        /// Checks to see if the ShowLocation property is set.
        /// </summary>
        internal bool IsSetShowLocation() => this.ShowLocation != null;
    }
}
