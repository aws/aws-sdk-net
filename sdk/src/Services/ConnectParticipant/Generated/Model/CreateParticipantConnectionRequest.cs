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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the CreateParticipantConnection operation.
    /// Creates the participant's connection. Note that ParticipantToken is used for invoking
    /// this API instead of ConnectionToken.
    /// 
    ///  
    /// <para>
    /// The participant token is valid for the lifetime of the participant – until they are
    /// part of a contact.
    /// </para>
    ///  
    /// <para>
    /// The response URL for <code>WEBSOCKET</code> Type has a connect expiry timeout of 100s.
    /// Clients must manually connect to the returned websocket URL and subscribe to the desired
    /// topic. 
    /// </para>
    ///  
    /// <para>
    /// For chat, you need to publish the following on the established websocket connection:
    /// </para>
    ///  
    /// <para>
    ///  <code>{"topic":"aws/subscribe","content":{"topics":["aws/chat"]}}</code> 
    /// </para>
    ///  
    /// <para>
    /// Upon websocket URL expiry, as specified in the response ConnectionExpiry parameter,
    /// clients need to call this API again to obtain a new websocket URL and perform the
    /// same steps as before.
    /// </para>
    ///  <note> 
    /// <para>
    /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateParticipantConnectionRequest : AmazonConnectParticipantRequest
    {
        private string _participantToken;
        private List<string> _type = new List<string>();

        /// <summary>
        /// Gets and sets the property ParticipantToken. 
        /// <para>
        /// This is a header parameter.
        /// </para>
        ///  
        /// <para>
        /// The Participant Token as obtained from <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartChatContact.html">StartChatContact</a>
        /// API response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string ParticipantToken
        {
            get { return this._participantToken; }
            set { this._participantToken = value; }
        }

        // Check to see if ParticipantToken property is set
        internal bool IsSetParticipantToken()
        {
            return this._participantToken != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of connection information required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null && this._type.Count > 0; 
        }

    }
}