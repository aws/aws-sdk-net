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
    /// Container for the parameters to the AdminSetUserMFAPreference operation.
    /// Sets the user's multi-factor authentication (MFA) preference, including which MFA
    /// options are enabled and if any are preferred. Only one factor can be set as preferred.
    /// The preferred MFA factor will be used to authenticate a user if multiple factors are
    /// enabled. If multiple options are enabled and no preference is set, a challenge to
    /// choose an MFA option will be returned during sign in.
    /// </summary>
    public partial class AdminSetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
    {
        private SMSMfaSettingsType _smsMfaSettings;
        private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;
        private string _username;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property SMSMfaSettings. 
        /// <para>
        /// The SMS text message MFA settings.
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
        /// The time-based one-time password software token MFA settings.
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

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user pool username or alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}