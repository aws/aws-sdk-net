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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// The attendee information, including attendee ID and join token.
    /// </summary>
    public partial class Attendee
    {
        private string _attendeeId;
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
        /// Gets and sets the property JoinToken. 
        /// <para>
        /// The join token used by the Amazon Chime SDK attendee.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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