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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// This is the response object from the CreateMeetingWithAttendees operation.
    /// </summary>
    public partial class CreateMeetingWithAttendeesResponse : AmazonWebServiceResponse
    {
        private List<Attendee> _attendees = AWSConfigs.InitializeCollections ? new List<Attendee>() : null;
        private List<CreateAttendeeError> _errors = AWSConfigs.InitializeCollections ? new List<CreateAttendeeError>() : null;
        private Meeting _meeting;

        /// <summary>
        /// Gets and sets the property Attendees. 
        /// <para>
        /// The attendee information, including attendees' IDs and join tokens.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attendee> Attendees
        {
            get { return this._attendees; }
            set { this._attendees = value; }
        }

        // Check to see if Attendees property is set
        internal bool IsSetAttendees()
        {
            return this._attendees != null && (this._attendees.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// If the action fails for one or more of the attendees in the request, a list of the
        /// attendees is returned, along with error codes and error messages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateAttendeeError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Meeting. 
        /// <para>
        /// The meeting information, including the meeting ID and <c>MediaPlacement</c>.
        /// </para>
        /// </summary>
        public Meeting Meeting
        {
            get { return this._meeting; }
            set { this._meeting = value; }
        }

        // Check to see if Meeting property is set
        internal bool IsSetMeeting()
        {
            return this._meeting != null;
        }

    }
}