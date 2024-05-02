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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Describes the Amazon Cognito user pool configuration for the authorization resource
    /// to be configured for your Amplify project on an update.
    /// </summary>
    public partial class UpdateBackendAuthUserPoolConfig
    {
        private UpdateBackendAuthForgotPasswordConfig _forgotPassword;
        private UpdateBackendAuthMFAConfig _mfa;
        private UpdateBackendAuthOAuthConfig _oAuth;
        private UpdateBackendAuthPasswordPolicyConfig _passwordPolicy;
        private UpdateBackendAuthVerificationMessageConfig _verificationMessage;

        /// <summary>
        /// Gets and sets the property ForgotPassword. 
        /// <para>
        /// <b>(DEPRECATED)</b> Describes the forgot password policy for your Amazon Cognito user
        /// pool, configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthForgotPasswordConfig ForgotPassword
        {
            get { return this._forgotPassword; }
            set { this._forgotPassword = value; }
        }

        // Check to see if ForgotPassword property is set
        internal bool IsSetForgotPassword()
        {
            return this._forgotPassword != null;
        }

        /// <summary>
        /// Gets and sets the property Mfa. 
        /// <para>
        /// Describes whether to apply multi-factor authentication policies for your Amazon Cognito
        /// user pool configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthMFAConfig Mfa
        {
            get { return this._mfa; }
            set { this._mfa = value; }
        }

        // Check to see if Mfa property is set
        internal bool IsSetMfa()
        {
            return this._mfa != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth. 
        /// <para>
        /// Describes the OAuth policy and rules for your Amazon Cognito user pool, configured
        /// as a part of your Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthOAuthConfig OAuth
        {
            get { return this._oAuth; }
            set { this._oAuth = value; }
        }

        // Check to see if OAuth property is set
        internal bool IsSetOAuth()
        {
            return this._oAuth != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordPolicy. 
        /// <para>
        /// Describes the password policy for your Amazon Cognito user pool, configured as a part
        /// of your Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthPasswordPolicyConfig PasswordPolicy
        {
            get { return this._passwordPolicy; }
            set { this._passwordPolicy = value; }
        }

        // Check to see if PasswordPolicy property is set
        internal bool IsSetPasswordPolicy()
        {
            return this._passwordPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationMessage. 
        /// <para>
        /// Describes the email or SMS verification message for your Amazon Cognito user pool,
        /// configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthVerificationMessageConfig VerificationMessage
        {
            get { return this._verificationMessage; }
            set { this._verificationMessage = value; }
        }

        // Check to see if VerificationMessage property is set
        internal bool IsSetVerificationMessage()
        {
            return this._verificationMessage != null;
        }

    }
}