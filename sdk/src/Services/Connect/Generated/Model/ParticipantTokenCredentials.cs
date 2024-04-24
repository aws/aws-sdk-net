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
    /// The credentials used by the participant.
    /// </summary>
    public partial class ParticipantTokenCredentials
    {
        private string _expiry;
        private string _participantToken;

        /// <summary>
        /// Gets and sets the property Expiry. 
        /// <para>
        /// The expiration of the token. It's specified in ISO 8601 format: yyyy-MM-ddThh:mm:ss.SSSZ.
        /// For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        public string Expiry
        {
            get { return this._expiry; }
            set { this._expiry = value; }
        }

        // Check to see if Expiry property is set
        internal bool IsSetExpiry()
        {
            return this._expiry != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantToken. 
        /// <para>
        /// The token used by the chat participant to call <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>.
        /// The participant token is valid for the lifetime of a chat participant. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ParticipantToken
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