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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// This is the response object from the CreateParticipantToken operation.
    /// </summary>
    public partial class CreateParticipantTokenResponse : AmazonWebServiceResponse
    {
        private ParticipantToken _participantToken;

        /// <summary>
        /// Gets and sets the property ParticipantToken. 
        /// <para>
        /// The participant token that was created.
        /// </para>
        /// </summary>
        public ParticipantToken ParticipantToken
        {
            get { return this._participantToken; }
            set { this._participantToken = value; }
        }

        // Check to see if ParticipantToken property is set
        internal bool IsSetParticipantToken()
        {
            return this._participantToken != null;
        }

    }
}