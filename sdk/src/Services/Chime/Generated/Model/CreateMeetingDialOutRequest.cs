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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMeetingDialOut operation.
    /// Uses the join token and call metadata in a meeting request (From number, To number,
    /// and so forth) to initiate an outbound call to a public switched telephone network
    /// (PSTN) and join them into a Chime meeting. Also ensures that the From number belongs
    /// to the customer.
    /// 
    ///  
    /// <para>
    /// To play welcome audio or implement an interactive voice response (IVR), use the <code>CreateSipMediaApplicationCall</code>
    /// action with the corresponding SIP media application ID.
    /// </para>
    /// </summary>
    public partial class CreateMeetingDialOutRequest : AmazonChimeRequest
    {
        private string _fromPhoneNumber;
        private string _joinToken;
        private string _meetingId;
        private string _toPhoneNumber;

        /// <summary>
        /// Gets and sets the property FromPhoneNumber. 
        /// <para>
        /// Phone number used as the caller ID when the remote party receives a call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string FromPhoneNumber
        {
            get { return this._fromPhoneNumber; }
            set { this._fromPhoneNumber = value; }
        }

        // Check to see if FromPhoneNumber property is set
        internal bool IsSetFromPhoneNumber()
        {
            return this._fromPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property JoinToken. 
        /// <para>
        /// Token used by the Amazon Chime SDK attendee. Call the <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_CreateAttendee.html">CreateAttendee</a>
        /// action to get a join token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2048)]
        public string JoinToken
        {
            get { return this._joinToken; }
            set { this._joinToken = value; }
        }

        // Check to see if JoinToken property is set
        internal bool IsSetJoinToken()
        {
            return this._joinToken != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MeetingId
        {
            get { return this._meetingId; }
            set { this._meetingId = value; }
        }

        // Check to see if MeetingId property is set
        internal bool IsSetMeetingId()
        {
            return this._meetingId != null;
        }

        /// <summary>
        /// Gets and sets the property ToPhoneNumber. 
        /// <para>
        /// Phone number called when inviting someone to a meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string ToPhoneNumber
        {
            get { return this._toPhoneNumber; }
            set { this._toPhoneNumber = value; }
        }

        // Check to see if ToPhoneNumber property is set
        internal bool IsSetToPhoneNumber()
        {
            return this._toPhoneNumber != null;
        }

    }
}