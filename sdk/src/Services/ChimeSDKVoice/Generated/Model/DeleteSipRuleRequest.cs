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
    /// Container for the parameters to the DeleteSipRule operation.
    /// Deletes a SIP rule.
    /// </summary>
    public partial class DeleteSipRuleRequest : AmazonChimeSDKVoiceRequest
    {
        private string _sipRuleId;

        /// <summary>
        /// Gets and sets the property SipRuleId. 
        /// <para>
        /// The SIP rule ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SipRuleId
        {
            get { return this._sipRuleId; }
            set { this._sipRuleId = value; }
        }

        // Check to see if SipRuleId property is set
        internal bool IsSetSipRuleId()
        {
            return this._sipRuleId != null;
        }

    }
}