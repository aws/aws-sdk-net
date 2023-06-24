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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// The attributes of an <code>Endpoint</code>.
    /// </summary>
    public partial class EndpointAttributes
    {
        private string _deviceToken;
        private string _voipDeviceToken;

        /// <summary>
        /// Gets and sets the property DeviceToken. 
        /// <para>
        /// The device token for the GCM, APNS, and APNS_SANDBOX endpoint types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1600)]
        public string DeviceToken
        {
            get { return this._deviceToken; }
            set { this._deviceToken = value; }
        }

        // Check to see if DeviceToken property is set
        internal bool IsSetDeviceToken()
        {
            return this._deviceToken != null;
        }

        /// <summary>
        /// Gets and sets the property VoipDeviceToken. 
        /// <para>
        /// The VOIP device token for the APNS and APNS_SANDBOX endpoint types.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1600)]
        public string VoipDeviceToken
        {
            get { return this._voipDeviceToken; }
            set { this._voipDeviceToken = value; }
        }

        // Check to see if VoipDeviceToken property is set
        internal bool IsSetVoipDeviceToken()
        {
            return this._voipDeviceToken != null;
        }

    }
}