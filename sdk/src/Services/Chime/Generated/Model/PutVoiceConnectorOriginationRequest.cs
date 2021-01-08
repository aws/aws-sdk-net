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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the PutVoiceConnectorOrigination operation.
    /// Adds origination settings for the specified Amazon Chime Voice Connector.
    /// 
    ///  <note> 
    /// <para>
    /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
    /// deleted prior to turning off origination settings.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutVoiceConnectorOriginationRequest : AmazonChimeRequest
    {
        private Origination _origination;
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property Origination. 
        /// <para>
        /// The origination setting details to add.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Origination Origination
        {
            get { return this._origination; }
            set { this._origination = value; }
        }

        // Check to see if Origination property is set
        internal bool IsSetOrigination()
        {
            return this._origination != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Amazon Chime Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VoiceConnectorId
        {
            get { return this._voiceConnectorId; }
            set { this._voiceConnectorId = value; }
        }

        // Check to see if VoiceConnectorId property is set
        internal bool IsSetVoiceConnectorId()
        {
            return this._voiceConnectorId != null;
        }

    }
}