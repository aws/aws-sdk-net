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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The Alexa Skill configuration of a SIP media application.
    /// </summary>
    public partial class SipMediaApplicationAlexaSkillConfiguration
    {
        private List<string> _alexaSkillIds = new List<string>();
        private AlexaSkillStatus _alexaSkillStatus;

        /// <summary>
        /// Gets and sets the property AlexaSkillIds. 
        /// <para>
        /// The ID of the Alexa Skill configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> AlexaSkillIds
        {
            get { return this._alexaSkillIds; }
            set { this._alexaSkillIds = value; }
        }

        // Check to see if AlexaSkillIds property is set
        internal bool IsSetAlexaSkillIds()
        {
            return this._alexaSkillIds != null && this._alexaSkillIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AlexaSkillStatus. 
        /// <para>
        /// The status of the Alexa Skill configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlexaSkillStatus AlexaSkillStatus
        {
            get { return this._alexaSkillStatus; }
            set { this._alexaSkillStatus = value; }
        }

        // Check to see if AlexaSkillStatus property is set
        internal bool IsSetAlexaSkillStatus()
        {
            return this._alexaSkillStatus != null;
        }

    }
}