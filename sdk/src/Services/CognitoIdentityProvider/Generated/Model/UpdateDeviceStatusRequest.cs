/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeviceStatus operation.
    /// Updates the device status.
    /// </summary>
    public partial class UpdateDeviceStatusRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private string _deviceKey;
        private DeviceRememberedStatusType _deviceRememberedStatus;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The access token.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeviceRememberedStatus. 
        /// <para>
        /// The status of whether a device is remembered.
        /// </para>
        /// </summary>
        public DeviceRememberedStatusType DeviceRememberedStatus
        {
            get { return this._deviceRememberedStatus; }
            set { this._deviceRememberedStatus = value; }
        }

        // Check to see if DeviceRememberedStatus property is set
        internal bool IsSetDeviceRememberedStatus()
        {
            return this._deviceRememberedStatus != null;
        }

    }
}