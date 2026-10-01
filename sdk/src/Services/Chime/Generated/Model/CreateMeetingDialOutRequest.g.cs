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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMeetingDialOut operation. Uses the join
    /// token and call metadata in a meeting request (From number, To number, and so forth)
    /// to initiate an outbound call to a public switched telephone network (PSTN) and join
    /// them into a Chime meeting. Also ensures that the From number belongs to the customer.
    /// <para> To play welcome audio or implement an interactive voice response (IVR), use
    /// the <c>CreateSipMediaApplicationCall</c> action with the corresponding SIP media application
    /// ID. </para> <important> <para> <b>This API is not available in a dedicated namespace.</b>
    /// </para> </important>
    /// </summary>
    public partial class CreateMeetingDialOutRequest : AmazonChimeRequest
    {
        /// <summary>
        /// Gets and sets the property FromPhoneNumber. 
        /// <para>
        /// Phone number used as the caller ID when the remote party receives a call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string FromPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the FromPhoneNumber property is set.
        /// </summary>
        internal bool IsSetFromPhoneNumber() => this.FromPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property JoinToken. 
        /// <para>
        /// Token used by the Amazon Chime SDK attendee. Call the <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_CreateAttendee.html">CreateAttendee</a>
        /// action to get a join token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2048)]
        public string JoinToken { get; set; }

        /// <summary>
        /// Checks to see if the JoinToken property is set.
        /// </summary>
        internal bool IsSetJoinToken() => this.JoinToken != null;

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MeetingId { get; set; }

        /// <summary>
        /// Checks to see if the MeetingId property is set.
        /// </summary>
        internal bool IsSetMeetingId() => this.MeetingId != null;

        /// <summary>
        /// Gets and sets the property ToPhoneNumber. 
        /// <para>
        /// Phone number called when inviting someone to a meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string ToPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the ToPhoneNumber property is set.
        /// </summary>
        internal bool IsSetToPhoneNumber() => this.ToPhoneNumber != null;
    }
}
