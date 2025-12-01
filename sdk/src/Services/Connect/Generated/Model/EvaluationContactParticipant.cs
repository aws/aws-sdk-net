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
    /// Information about a contact participant in the evaluation.
    /// </summary>
    public partial class EvaluationContactParticipant
    {
        private string _contactParticipantId;
        private ContactParticipantRole _contactParticipantRole;

        /// <summary>
        /// Gets and sets the property ContactParticipantId. 
        /// <para>
        /// The identifier for the contact participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ContactParticipantId
        {
            get { return this._contactParticipantId; }
            set { this._contactParticipantId = value; }
        }

        // Check to see if ContactParticipantId property is set
        internal bool IsSetContactParticipantId()
        {
            return this._contactParticipantId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactParticipantRole. 
        /// <para>
        /// The role of the contact participant.
        /// </para>
        /// </summary>
        public ContactParticipantRole ContactParticipantRole
        {
            get { return this._contactParticipantRole; }
            set { this._contactParticipantRole = value; }
        }

        // Check to see if ContactParticipantRole property is set
        internal bool IsSetContactParticipantRole()
        {
            return this._contactParticipantRole != null;
        }

    }
}