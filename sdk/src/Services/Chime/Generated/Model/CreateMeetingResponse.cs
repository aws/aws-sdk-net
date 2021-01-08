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
    /// This is the response object from the CreateMeeting operation.
    /// </summary>
    public partial class CreateMeetingResponse : AmazonWebServiceResponse
    {
        private Meeting _meeting;

        /// <summary>
        /// Gets and sets the property Meeting. 
        /// <para>
        /// The meeting information, including the meeting ID and <code>MediaPlacement</code>.
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