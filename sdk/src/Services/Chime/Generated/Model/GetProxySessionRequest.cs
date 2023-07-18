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
    /// Container for the parameters to the GetProxySession operation.
    /// Gets the specified proxy session details for the specified Amazon Chime Voice Connector.
    /// 
    ///  <important> 
    /// <para>
    ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
    /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_voice-chime_GetProxySession.html">GetProxySession</a>,
    /// in the Amazon Chime SDK.
    /// </para>
    ///  
    /// <para>
    /// Using the latest version requires migrating to a dedicated namespace. For more information,
    /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
    /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetProxySessionRequest : AmazonChimeRequest
    {
        private string _proxySessionId;
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property ProxySessionId. 
        /// <para>
        /// The proxy session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ProxySessionId
        {
            get { return this._proxySessionId; }
            set { this._proxySessionId = value; }
        }

        // Check to see if ProxySessionId property is set
        internal bool IsSetProxySessionId()
        {
            return this._proxySessionId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Amazon Chime voice connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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