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
    /// Container for the parameters to the CreateVoiceConnectorGroup operation.
    /// Creates an Amazon Chime SDK Voice Connector group under the administrator's AWS account.
    /// You can associate Amazon Chime SDK Voice Connectors with the Voice Connector group
    /// by including <code>VoiceConnectorItems</code> in the request. 
    /// 
    ///  
    /// <para>
    /// You can include Voice Connectors from different AWS Regions in your group. This creates
    /// a fault tolerant mechanism for fallback in case of availability events.
    /// </para>
    /// </summary>
    public partial class CreateVoiceConnectorGroupRequest : AmazonChimeSDKVoiceRequest
    {
        private string _name;
        private List<VoiceConnectorItem> _voiceConnectorItems = new List<VoiceConnectorItem>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Voice Connector group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorItems. 
        /// <para>
        /// Lists the Voice Connectors that inbound calls are routed to.
        /// </para>
        /// </summary>
        public List<VoiceConnectorItem> VoiceConnectorItems
        {
            get { return this._voiceConnectorItems; }
            set { this._voiceConnectorItems = value; }
        }

        // Check to see if VoiceConnectorItems property is set
        internal bool IsSetVoiceConnectorItems()
        {
            return this._voiceConnectorItems != null && this._voiceConnectorItems.Count > 0; 
        }

    }
}