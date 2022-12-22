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
    /// Configuration information for the chat participant role.
    /// </summary>
    public partial class ChatParticipantRoleConfig
    {
        private List<ParticipantTimerConfiguration> _participantTimerConfigList = new List<ParticipantTimerConfiguration>();

        /// <summary>
        /// Gets and sets the property ParticipantTimerConfigList. 
        /// <para>
        /// A list of participant timers. You can specify any unique combination of role and timer
        /// type. Duplicate entries error out the request with a 400.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6)]
        public List<ParticipantTimerConfiguration> ParticipantTimerConfigList
        {
            get { return this._participantTimerConfigList; }
            set { this._participantTimerConfigList = value; }
        }

        // Check to see if ParticipantTimerConfigList property is set
        internal bool IsSetParticipantTimerConfigList()
        {
            return this._participantTimerConfigList != null && this._participantTimerConfigList.Count > 0; 
        }

    }
}