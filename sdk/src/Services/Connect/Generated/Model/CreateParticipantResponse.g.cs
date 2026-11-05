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
    /// This is the response object from the CreateParticipant operation.
    /// </summary>
    public partial class CreateParticipantResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ParticipantCredentials. 
        /// <para>
        /// The token used by the chat participant to call <c>CreateParticipantConnection</c>.
        /// The participant token is valid for the lifetime of a chat participant.
        /// </para>
        /// </summary>
        public ParticipantTokenCredentials ParticipantCredentials { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantCredentials property is set.
        /// </summary>
        internal bool IsSetParticipantCredentials() => this.ParticipantCredentials != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier for a chat participant. The participantId for a chat participant is
        /// the same throughout the chat lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;
    }
}
