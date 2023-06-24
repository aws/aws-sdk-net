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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the ConfirmDevice operation.
    /// Confirms tracking of the device. This API call is the call that begins device tracking.
    /// </summary>
    public partial class ConfirmDeviceRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private string _deviceKey;
        private string _deviceName;
        private DeviceSecretVerifierConfigType _deviceSecretVerifierConfig;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user whose device you want
        /// to confirm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceKey. 
        /// <para>
        /// The device key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string DeviceKey
        {
            get { return this._deviceKey; }
            set { this._deviceKey = value; }
        }

        // Check to see if DeviceKey property is set
        internal bool IsSetDeviceKey()
        {
            return this._deviceKey != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceSecretVerifierConfig. 
        /// <para>
        /// The configuration of the device secret verifier.
        /// </para>
        /// </summary>
        public DeviceSecretVerifierConfigType DeviceSecretVerifierConfig
        {
            get { return this._deviceSecretVerifierConfig; }
            set { this._deviceSecretVerifierConfig = value; }
        }

        // Check to see if DeviceSecretVerifierConfig property is set
        internal bool IsSetDeviceSecretVerifierConfig()
        {
            return this._deviceSecretVerifierConfig != null;
        }

    }
}