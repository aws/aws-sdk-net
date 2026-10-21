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
    /// Describes the Amazon Cognito user pool configuration for the authorization resource
    /// to be configured for your Amplify project on an update.
    /// </summary>
    public partial class UpdateBackendAuthUserPoolConfig
    {
        /// <summary>
        /// Gets and sets the property ForgotPassword. 
        /// <para>
        /// <b>(DEPRECATED)</b> Describes the forgot password policy for your Amazon Cognito user
        /// pool, configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthForgotPasswordConfig ForgotPassword { get; set; }

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
        public UpdateBackendAuthMFAConfig Mfa { get; set; }

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
        public UpdateBackendAuthOAuthConfig OAuth { get; set; }

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
        public UpdateBackendAuthPasswordPolicyConfig PasswordPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PasswordPolicy property is set.
        /// </summary>
        internal bool IsSetPasswordPolicy() => this.PasswordPolicy != null;

        /// <summary>
        /// Gets and sets the property VerificationMessage. 
        /// <para>
        /// Describes the email or SMS verification message for your Amazon Cognito user pool,
        /// configured as a part of your Amplify project.
        /// </para>
        /// </summary>
        public UpdateBackendAuthVerificationMessageConfig VerificationMessage { get; set; }

        /// <summary>
        /// Checks to see if the VerificationMessage property is set.
        /// </summary>
        internal bool IsSetVerificationMessage() => this.VerificationMessage != null;
    }
}
