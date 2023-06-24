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
    /// This is the response object from the ListVoiceConnectorGroups operation.
    /// </summary>
    public partial class ListVoiceConnectorGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VoiceConnectorGroup> _voiceConnectorGroups = new List<VoiceConnectorGroup>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to return the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorGroups. 
        /// <para>
        /// The details of the Voice Connector groups.
        /// </para>
        /// </summary>
        public List<VoiceConnectorGroup> VoiceConnectorGroups
        {
            get { return this._voiceConnectorGroups; }
            set { this._voiceConnectorGroups = value; }
        }

        // Check to see if VoiceConnectorGroups property is set
        internal bool IsSetVoiceConnectorGroups()
        {
            return this._voiceConnectorGroups != null && this._voiceConnectorGroups.Count > 0; 
        }

    }
}