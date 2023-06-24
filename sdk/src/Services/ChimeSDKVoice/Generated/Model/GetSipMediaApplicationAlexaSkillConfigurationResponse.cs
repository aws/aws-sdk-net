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
    /// This is the response object from the GetSipMediaApplicationAlexaSkillConfiguration operation.
    /// </summary>
    public partial class GetSipMediaApplicationAlexaSkillConfigurationResponse : AmazonWebServiceResponse
    {
        private SipMediaApplicationAlexaSkillConfiguration _sipMediaApplicationAlexaSkillConfiguration;

        /// <summary>
        /// Gets and sets the property SipMediaApplicationAlexaSkillConfiguration. 
        /// <para>
        /// Returns the Alexa Skill configuration.
        /// </para>
        /// </summary>
        public SipMediaApplicationAlexaSkillConfiguration SipMediaApplicationAlexaSkillConfiguration
        {
            get { return this._sipMediaApplicationAlexaSkillConfiguration; }
            set { this._sipMediaApplicationAlexaSkillConfiguration = value; }
        }

        // Check to see if SipMediaApplicationAlexaSkillConfiguration property is set
        internal bool IsSetSipMediaApplicationAlexaSkillConfiguration()
        {
            return this._sipMediaApplicationAlexaSkillConfiguration != null;
        }

    }
}