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
    /// This is the response object from the BatchCreateAttendee operation.
    /// </summary>
    public partial class BatchCreateAttendeeResponse : AmazonWebServiceResponse
    {
        private List<Attendee> _attendees = new List<Attendee>();
        private List<CreateAttendeeError> _errors = new List<CreateAttendeeError>();

        /// <summary>
        /// Gets and sets the property Attendees. 
        /// <para>
        /// The attendee information, including attendees IDs and join tokens.
        /// </para>
        /// </summary>
        public List<Attendee> Attendees
        {
            get { return this._attendees; }
            set { this._attendees = value; }
        }

        // Check to see if Attendees property is set
        internal bool IsSetAttendees()
        {
            return this._attendees != null && this._attendees.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// If the action fails for one or more of the attendees in the request, a list of the
        /// attendees is returned, along with error codes and error messages.
        /// </para>
        /// </summary>
        public List<CreateAttendeeError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

    }
}