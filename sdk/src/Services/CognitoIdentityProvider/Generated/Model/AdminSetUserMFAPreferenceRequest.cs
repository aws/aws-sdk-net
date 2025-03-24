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
    /// Container for the parameters to the AdminSetUserMFAPreference operation.
    /// Sets the user's multi-factor authentication (MFA) preference, including which MFA
    /// options are activated, and if any are preferred. Only one factor can be set as preferred.
    /// The preferred MFA factor will be used to authenticate a user if multiple factors are
    /// activated. If multiple options are activated and no preference is set, a challenge
    /// to choose an MFA option will be returned during sign-in.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AdminSetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
    {
        private EmailMfaSettingsType _emailMfaSettings;
        private SMSMfaSettingsType _smsMfaSettings;
        private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;
        private string _username;
        private string _userPoolId;

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
        /// This operation can set TOTP as a user's preferred MFA method before they register
        /// a TOTP authenticator.
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
        /// The name of the user that you want to query or modify. The value of this parameter
        /// is typically your user's username, but it can be any of their alias attributes. If
        /// <c>username</c> isn't an alias attribute in your user pool, this value must be the
        /// <c>sub</c> of a local user or the username of a user from a third-party IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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
        /// The ID of the user pool where you want to set a user's MFA preferences.
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