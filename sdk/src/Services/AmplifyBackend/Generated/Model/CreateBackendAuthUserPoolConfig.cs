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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Describes the Amazon Cognito user pool configuration for the auth resource to be configured
    /// for your Amplify project.
    /// </summary>
    public partial class CreateBackendAuthUserPoolConfig
    {
        private CreateBackendAuthForgotPasswordConfig _forgotPassword;
        private CreateBackendAuthMFAConfig _mfa;
        private CreateBackendAuthOAuthConfig _oAuth;
        private CreateBackendAuthPasswordPolicyConfig _passwordPolicy;
        private List<string> _requiredSignUpAttributes = new List<string>();
        private SignInMethod _signInMethod;
        private string _userPoolName;

        /// <summary>
        /// Gets and sets the property ForgotPassword. 
        /// <para>
        /// Describes the forgotten password policy for your Amazon Cognito user pool, configured
        /// as a part of your Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthForgotPasswordConfig ForgotPassword
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
        /// Describes whether to apply multi-factor authentication (MFA) policies for your Amazon
        /// Cognito user pool that's configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthMFAConfig Mfa
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
        public CreateBackendAuthOAuthConfig OAuth
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
        public CreateBackendAuthPasswordPolicyConfig PasswordPolicy
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
        /// Gets and sets the property RequiredSignUpAttributes. 
        /// <para>
        /// The required attributes to sign up new users in the Amazon Cognito user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RequiredSignUpAttributes
        {
            get { return this._requiredSignUpAttributes; }
            set { this._requiredSignUpAttributes = value; }
        }

        // Check to see if RequiredSignUpAttributes property is set
        internal bool IsSetRequiredSignUpAttributes()
        {
            return this._requiredSignUpAttributes != null && this._requiredSignUpAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SignInMethod. 
        /// <para>
        /// Describes the sign-in methods that your Amplify app users to log in using the Amazon
        /// Cognito user pool that's configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SignInMethod SignInMethod
        {
            get { return this._signInMethod; }
            set { this._signInMethod = value; }
        }

        // Check to see if SignInMethod property is set
        internal bool IsSetSignInMethod()
        {
            return this._signInMethod != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolName. 
        /// <para>
        /// The Amazon Cognito user pool name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserPoolName
        {
            get { return this._userPoolName; }
            set { this._userPoolName = value; }
        }

        // Check to see if UserPoolName property is set
        internal bool IsSetUserPoolName()
        {
            return this._userPoolName != null;
        }

    }
}