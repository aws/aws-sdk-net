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
    /// The device tracking configuration for a user pool. A user pool with device tracking
    /// deactivated returns a null value.
    /// 
    ///  <note> 
    /// <para>
    /// When you provide values for any DeviceConfiguration field, you activate device tracking.
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
        /// Users that sign in with devices that have not been confirmed or remembered will still
        /// have to provide a second factor, whether or not ChallengeRequiredOnNewDevice is true,
        /// when your user pool requires MFA.
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
        /// When true, users can opt in to remembering their device. Your app code must use callback
        /// functions to return the user's choice.
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