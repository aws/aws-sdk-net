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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the StartChatContact operation.
    /// </summary>
    public partial class StartChatContactResponse : AmazonWebServiceResponse
    {
        private string _contactId;
        private string _continuedFromContactId;
        private string _participantId;
        private string _participantToken;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of this contact within the Amazon Connect instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuedFromContactId. 
        /// <para>
        /// The contactId from which a persistent chat session is started. This field is populated
        /// only for persistent chats.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContinuedFromContactId
        {
            get { return this._continuedFromContactId; }
            set { this._continuedFromContactId = value; }
        }

        // Check to see if ContinuedFromContactId property is set
        internal bool IsSetContinuedFromContactId()
        {
            return this._continuedFromContactId != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier for a chat participant. The participantId for a chat participant is
        /// the same throughout the chat lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
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