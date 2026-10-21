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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes the Amazon Cognito user pool configuration for the auth resource to be configured
    /// for your Amplify project.
    /// </summary>
    public partial class CreateBackendAuthUserPoolConfig
    {
        /// <summary>
        /// Gets and sets the property ForgotPassword. 
        /// <para>
        /// <b>(DEPRECATED)</b> Describes the forgotten password policy for your Amazon Cognito
        /// user pool, configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthForgotPasswordConfig ForgotPassword { get; set; }

        /// <summary>
        /// Checks to see if the ForgotPassword property is set.
        /// </summary>
        internal bool IsSetForgotPassword() => this.ForgotPassword != null;

        /// <summary>
        /// Gets and sets the property Mfa. 
        /// <para>
        /// Describes whether to apply multi-factor authentication policies for your Amazon Cognito
        /// user pool configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthMFAConfig Mfa { get; set; }

        /// <summary>
        /// Checks to see if the Mfa property is set.
        /// </summary>
        internal bool IsSetMfa() => this.Mfa != null;

        /// <summary>
        /// Gets and sets the property OAuth. 
        /// <para>
        /// Describes the OAuth policy and rules for your Amazon Cognito user pool, configured
        /// as a part of your Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthOAuthConfig OAuth { get; set; }

        /// <summary>
        /// Checks to see if the OAuth property is set.
        /// </summary>
        internal bool IsSetOAuth() => this.OAuth != null;

        /// <summary>
        /// Gets and sets the property PasswordPolicy. 
        /// <para>
        /// Describes the password policy for your Amazon Cognito user pool, configured as a part
        /// of your Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthPasswordPolicyConfig PasswordPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PasswordPolicy property is set.
        /// </summary>
        internal bool IsSetPasswordPolicy() => this.PasswordPolicy != null;

        /// <summary>
        /// Gets and sets the property RequiredSignUpAttributes. 
        /// <para>
        /// The required attributes to sign up new users in the user pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> RequiredSignUpAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiredSignUpAttributes property is set.
        /// </summary>
        internal bool IsSetRequiredSignUpAttributes() => this.RequiredSignUpAttributes != null && (this.RequiredSignUpAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SignInMethod. 
        /// <para>
        /// Describes the sign-in methods that your Amplify app users use to log in using the
        /// Amazon Cognito user pool, configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SignInMethod SignInMethod { get; set; }

        /// <summary>
        /// Checks to see if the SignInMethod property is set.
        /// </summary>
        internal bool IsSetSignInMethod() => this.SignInMethod != null;

        /// <summary>
        /// Gets and sets the property UserPoolName. 
        /// <para>
        /// The Amazon Cognito user pool name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserPoolName { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolName property is set.
        /// </summary>
        internal bool IsSetUserPoolName() => this.UserPoolName != null;

        /// <summary>
        /// Gets and sets the property VerificationMessage. 
        /// <para>
        /// Describes the email or SMS verification message for your Amazon Cognito user pool,
        /// configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public CreateBackendAuthVerificationMessageConfig VerificationMessage { get; set; }

        /// <summary>
        /// Checks to see if the VerificationMessage property is set.
        /// </summary>
        internal bool IsSetVerificationMessage() => this.VerificationMessage != null;
    }
}
