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
    /// 
    ///  
    /// <para>
    /// Authorize this action with a signed-in user's access token. It must include the scope
    /// <c>aws.cognito.signin.user.admin</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private EmailMfaSettingsType _emailMfaSettings;
        private SMSMfaSettingsType _smsMfaSettings;
        private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the currently signed-in user. Must
        /// include a scope claim for <c>aws.cognito.signin.user.admin</c>.
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
        /// Gets and sets the property EmailMfaSettings. 
        /// <para>
        /// User preferences for email message MFA. Activates or deactivates email MFA and sets
        /// it as the preferred MFA method when multiple methods are available. To activate this
        /// setting, your user pool must be in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
        /// Essentials tier</a> or higher.
        /// </para>
        /// </summary>
        public EmailMfaSettingsType EmailMfaSettings
        {
            get { return this._emailMfaSettings; }
            set { this._emailMfaSettings = value; }
        }

        // Check to see if EmailMfaSettings property is set
        internal bool IsSetEmailMfaSettings()
        {
            return this._emailMfaSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SMSMfaSettings. 
        /// <para>
        /// User preferences for SMS message MFA. Activates or deactivates SMS MFA and sets it
        /// as the preferred MFA method when multiple methods are available.
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
        /// User preferences for time-based one-time password (TOTP) MFA. Activates or deactivates
        /// TOTP MFA and sets it as the preferred MFA method when multiple methods are available.
        /// Users must register a TOTP authenticator before they set this as their preferred MFA
        /// method.
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