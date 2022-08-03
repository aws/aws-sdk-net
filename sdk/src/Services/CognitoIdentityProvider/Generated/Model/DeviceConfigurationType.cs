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
    /// The device-remembering configuration for a user pool. A null value indicates that
    /// you have deactivated device remembering in your user pool.
    /// 
    ///  <note> 
    /// <para>
    /// When you provide a value for any <code>DeviceConfiguration</code> field, you activate
    /// the Amazon Cognito device-remembering feature.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeviceConfigurationType
    {
        private bool? _challengeRequiredOnNewDevice;
        private bool? _deviceOnlyRememberedOnUserPrompt;

        /// <summary>
        /// Gets and sets the property ChallengeRequiredOnNewDevice. 
        /// <para>
        /// When true, device authentication can replace SMS and time-based one-time password
        /// (TOTP) factors for multi-factor authentication (MFA).
        /// </para>
        ///  <note> 
        /// <para>
        /// Regardless of the value of this field, users that sign in with new devices that have
        /// not been confirmed or remembered must provide a second factor if your user pool requires
        /// MFA.
        /// </para>
        ///  </note>
        /// </summary>
        public bool ChallengeRequiredOnNewDevice
        {
            get { return this._challengeRequiredOnNewDevice.GetValueOrDefault(); }
            set { this._challengeRequiredOnNewDevice = value; }
        }

        // Check to see if ChallengeRequiredOnNewDevice property is set
        internal bool IsSetChallengeRequiredOnNewDevice()
        {
            return this._challengeRequiredOnNewDevice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceOnlyRememberedOnUserPrompt. 
        /// <para>
        /// When true, Amazon Cognito doesn't remember newly-confirmed devices. Users who want
        /// to authenticate with their device can instead opt in to remembering their device.
        /// To collect a choice from your user, create an input prompt in your app and return
        /// the value that the user chooses in an <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateDeviceStatus.html">UpdateDeviceStatus</a>
        /// API request.
        /// </para>
        /// </summary>
        public bool DeviceOnlyRememberedOnUserPrompt
        {
            get { return this._deviceOnlyRememberedOnUserPrompt.GetValueOrDefault(); }
            set { this._deviceOnlyRememberedOnUserPrompt = value; }
        }

        // Check to see if DeviceOnlyRememberedOnUserPrompt property is set
        internal bool IsSetDeviceOnlyRememberedOnUserPrompt()
        {
            return this._deviceOnlyRememberedOnUserPrompt.HasValue; 
        }

    }
}