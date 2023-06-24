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
    /// Container for the parameters to the UpdatePhoneNumberSettings operation.
    /// Updates the phone number settings for the administrator's AWS account, such as the
    /// default outbound calling name. You can update the default outbound calling name once
    /// every seven days. Outbound calling names can take up to 72 hours to update.
    /// </summary>
    public partial class UpdatePhoneNumberSettingsRequest : AmazonChimeSDKVoiceRequest
    {
        private string _callingName;

        /// <summary>
        /// Gets and sets the property CallingName. 
        /// <para>
        /// The default outbound calling name for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string CallingName
        {
            get { return this._callingName; }
            set { this._callingName = value; }
        }

        // Check to see if CallingName property is set
        internal bool IsSetCallingName()
        {
            return this._callingName != null;
        }

    }
}