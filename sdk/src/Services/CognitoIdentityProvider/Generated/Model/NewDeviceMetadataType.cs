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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Information that your user pool responds with in <c>AuthenticationResult</c>when you
    /// configure it to remember devices and a user signs in with an unrecognized device.
    /// Amazon Cognito presents a new device key that you can use to set up <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">device
    /// authentication</a> in a "Remember me on this device" authentication model.
    /// </summary>
    public partial class NewDeviceMetadataType
    {
        private string _deviceGroupKey;
        private string _deviceKey;

        /// <summary>
        /// Gets and sets the property DeviceGroupKey. 
        /// <para>
        /// The device group key, an identifier used in generating the <c>DEVICE_PASSWORD_VERIFIER</c>
        /// for device SRP authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string DeviceGroupKey
        {
            get { return this._deviceGroupKey; }
            set { this._deviceGroupKey = value; }
        }

        // Check to see if DeviceGroupKey property is set
        internal bool IsSetDeviceGroupKey()
        {
            return this._deviceGroupKey != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceKey. 
        /// <para>
        /// The device key, an identifier used in generating the <c>DEVICE_PASSWORD_VERIFIER</c>
        /// for device SRP authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
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

    }
}