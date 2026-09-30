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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Creates the participant’s WebRTC connection data required for the client application
    /// (mobile or web) to connect to the call.
    /// </summary>
    public partial class WebRTCConnection
    {
        /// <summary>
        /// Gets and sets the property Attendee.
        /// </summary>
        public Attendee Attendee { get; set; }

        /// <summary>
        /// Checks to see if the Attendee property is set.
        /// </summary>
        internal bool IsSetAttendee() => this.Attendee != null;

        /// <summary>
        /// Gets and sets the property Meeting. 
        /// <para>
        /// A meeting created using the Amazon Chime SDK.
        /// </para>
        /// </summary>
        public WebRTCMeeting Meeting { get; set; }

        /// <summary>
        /// Checks to see if the Meeting property is set.
        /// </summary>
        internal bool IsSetMeeting() => this.Meeting != null;
    }
}
