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
    /// This is the response object from the CreateStage operation.
    /// </summary>
    public partial class CreateStageResponse : AmazonWebServiceResponse
    {
        private List<ParticipantToken> _participantTokens = new List<ParticipantToken>();
        private Stage _stage;

        /// <summary>
        /// Gets and sets the property ParticipantTokens. 
        /// <para>
        /// Participant tokens attached to the stage. These correspond to the <code>participants</code>
        /// in the request.
        /// </para>
        /// </summary>
        public List<ParticipantToken> ParticipantTokens
        {
            get { return this._participantTokens; }
            set { this._participantTokens = value; }
        }

        // Check to see if ParticipantTokens property is set
        internal bool IsSetParticipantTokens()
        {
            return this._participantTokens != null && this._participantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage that was created.
        /// </para>
        /// </summary>
        public Stage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}