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
    /// Container for the parameters to the SetUserMFAPreference operation.
    /// Set the user's multi-factor authentication (MFA) method preference, including which
    /// MFA factors are activated and if any are preferred. Only one factor can be set as
    /// preferred. The preferred MFA factor will be used to authenticate a user if multiple
    /// factors are activated. If multiple options are activated and no preference is set,
    /// a challenge to choose an MFA option will be returned during sign-in. If an MFA type
    /// is activated for a user, the user will be prompted for MFA during all sign-in attempts
    /// unless device tracking is turned on and the device has been trusted. If you want MFA
    /// to be applied selectively based on the assessed risk level of sign-in attempts, deactivate
    /// MFA for users and turn on Adaptive Authentication for the user pool.
    /// </summary>
    public partial class SetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private SMSMfaSettingsType _smsMfaSettings;
        private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user whose MFA preference you
        /// want to set.
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
        /// Gets and sets the property SMSMfaSettings. 
        /// <para>
        /// The SMS text message multi-factor authentication (MFA) settings.
        /// </para>
        /// </summary>
        public SMSMfaSettingsType SMSMfaSettings
        {
            get { return this._smsMfaSettings; }
            set { this._smsMfaSettings = value; }
        }

        // Check to see if SMSMfaSettings property is set
        internal bool IsSetSMSMfaSettings()
        {
            return this._smsMfaSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareTokenMfaSettings. 
        /// <para>
        /// The time-based one-time password (TOTP) software token MFA settings.
        /// </para>
        /// </summary>
        public SoftwareTokenMfaSettingsType SoftwareTokenMfaSettings
        {
            get { return this._softwareTokenMfaSettings; }
            set { this._softwareTokenMfaSettings = value; }
        }

        // Check to see if SoftwareTokenMfaSettings property is set
        internal bool IsSetSoftwareTokenMfaSettings()
        {
            return this._softwareTokenMfaSettings != null;
        }

    }
}