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
    /// An Amazon Chime SDK meeting attendee. Includes a unique <code>AttendeeId</code> and
    /// <code>JoinToken</code> . The <code>JoinToken</code> allows a client to authenticate
    /// and join as the specified attendee. The <code>JoinToken</code> expires when the meeting
    /// ends or when <a>DeleteAttendee</a> is called. After that, the attendee is unable to
    /// join the meeting. 
    /// 
    ///  
    /// <para>
    /// We recommend securely transferring each <code>JoinToken</code> from your server application
    /// to the client so that no other client has access to the token except for the one authorized
    /// to represent the attendee.
    /// </para>
    /// </summary>
    public partial class Attendee
    {
        private string _attendeeId;
        private string _externalUserId;
        private string _joinToken;

        /// <summary>
        /// Gets and sets the property AttendeeId. 
        /// <para>
        /// The Amazon Chime SDK attendee ID.
        /// </para>
        /// </summary>
        public string AttendeeId
        {
            get { return this._attendeeId; }
            set { this._attendeeId = value; }
        }

        // Check to see if AttendeeId property is set
        internal bool IsSetAttendeeId()
        {
            return this._attendeeId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalUserId. 
        /// <para>
        /// The Amazon Chime SDK external user ID. An idempotency token. Links the attendee to
        /// an identity managed by a builder application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string ExternalUserId
        {
            get { return this._externalUserId; }
            set { this._externalUserId = value; }
        }

        // Check to see if ExternalUserId property is set
        internal bool IsSetExternalUserId()
        {
            return this._externalUserId != null;
        }

        /// <summary>
        /// Gets and sets the property JoinToken. 
        /// <para>
        /// The join token used by the Amazon Chime SDK attendee.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2048)]
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

    }
}