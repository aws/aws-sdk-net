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
    /// Container for the parameters to the PutSipMediaApplicationLoggingConfiguration operation.
    /// Updates the logging configuration for the specified SIP media application.
    /// </summary>
    public partial class PutSipMediaApplicationLoggingConfigurationRequest : AmazonChimeSDKVoiceRequest
    {
        private string _sipMediaApplicationId;
        private SipMediaApplicationLoggingConfiguration _sipMediaApplicationLoggingConfiguration;

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId. 
        /// <para>
        /// The SIP media application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SipMediaApplicationId
        {
            get { return this._sipMediaApplicationId; }
            set { this._sipMediaApplicationId = value; }
        }

        // Check to see if SipMediaApplicationId property is set
        internal bool IsSetSipMediaApplicationId()
        {
            return this._sipMediaApplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property SipMediaApplicationLoggingConfiguration. 
        /// <para>
        /// The logging configuration for the specified SIP media application.
        /// </para>
        /// </summary>
        public SipMediaApplicationLoggingConfiguration SipMediaApplicationLoggingConfiguration
        {
            get { return this._sipMediaApplicationLoggingConfiguration; }
            set { this._sipMediaApplicationLoggingConfiguration = value; }
        }

        // Check to see if SipMediaApplicationLoggingConfiguration property is set
        internal bool IsSetSipMediaApplicationLoggingConfiguration()
        {
            return this._sipMediaApplicationLoggingConfiguration != null;
        }

    }
}