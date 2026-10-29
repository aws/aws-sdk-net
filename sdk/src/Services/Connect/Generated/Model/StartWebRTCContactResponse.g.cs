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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the StartWebRTCContact operation.
    /// </summary>
    public partial class StartWebRTCContactResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectionData. 
        /// <para>
        /// Information required for the client application (mobile application or website) to
        /// connect to the call.
        /// </para>
        /// </summary>
        public ConnectionData ConnectionData { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionData property is set.
        /// </summary>
        internal bool IsSetConnectionData() => this.ConnectionData != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier for a contact participant. The <c>ParticipantId</c> for a contact participant
        /// is the same throughout the contact lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property ParticipantToken. 
        /// <para>
        /// The token used by the contact participant to call the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// API. The participant token is valid for the lifetime of a contact participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string ParticipantToken { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantToken property is set.
        /// </summary>
        internal bool IsSetParticipantToken() => this.ParticipantToken != null;
    }
}
