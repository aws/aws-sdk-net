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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// This is the response object from the GetUserPoolMfaConfig operation.
    /// </summary>
    public partial class GetUserPoolMfaConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EmailMfaConfiguration. 
        /// <para>
        /// Shows configuration for user pool email message MFA and sign-in with one-time passwords
        /// (OTPs). Includes the subject and body of the email message template for sign-in and
        /// MFA messages. To activate this setting, your user pool must be in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
        /// Essentials tier</a> or higher.
        /// </para>
        /// </summary>
        public EmailMfaConfigType EmailMfaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EmailMfaConfiguration property is set.
        /// </summary>
        internal bool IsSetEmailMfaConfiguration() => this.EmailMfaConfiguration != null;

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// Displays the state of multi-factor authentication (MFA) as on, off, or optional. When
        /// <c>ON</c>, all users must set up MFA before they can sign in. When <c>OPTIONAL</c>,
        /// your application must make a client-side determination of whether a user wants to
        /// register an MFA device. For user pools with adaptive authentication with threat protection,
        /// choose <c>OPTIONAL</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>MfaConfiguration</c> is <c>OPTIONAL</c>, managed login doesn't automatically
        /// prompt users to set up MFA. Amazon Cognito generates MFA prompts in API responses
        /// and in managed login for users who have chosen and configured a preferred MFA factor.
        /// </para>
        /// </summary>
        public UserPoolMfaType MfaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MfaConfiguration property is set.
        /// </summary>
        internal bool IsSetMfaConfiguration() => this.MfaConfiguration != null;

        /// <summary>
        /// Gets and sets the property SmsMfaConfiguration. 
        /// <para>
        /// Shows user pool configuration for SMS message MFA. Includes the message template and
        /// the SMS message sending configuration for Amazon SNS.
        /// </para>
        /// </summary>
        public SmsMfaConfigType SmsMfaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SmsMfaConfiguration property is set.
        /// </summary>
        internal bool IsSetSmsMfaConfiguration() => this.SmsMfaConfiguration != null;

        /// <summary>
        /// Gets and sets the property SoftwareTokenMfaConfiguration. 
        /// <para>
        /// Shows user pool configuration for time-based one-time password (TOTP) MFA. Includes
        /// TOTP enabled or disabled state.
        /// </para>
        /// </summary>
        public SoftwareTokenMfaConfigType SoftwareTokenMfaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareTokenMfaConfiguration property is set.
        /// </summary>
        internal bool IsSetSoftwareTokenMfaConfiguration() => this.SoftwareTokenMfaConfiguration != null;

        /// <summary>
        /// Gets and sets the property WebAuthnConfiguration. 
        /// <para>
        /// Shows user pool configuration for sign-in with passkey authenticators such as biometric
        /// devices and security keys. Includes relying-party configuration, user-verification
        /// requirements, and whether passkeys can satisfy MFA requirements.
        /// </para>
        /// </summary>
        public WebAuthnConfigurationType WebAuthnConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WebAuthnConfiguration property is set.
        /// </summary>
        internal bool IsSetWebAuthnConfiguration() => this.WebAuthnConfiguration != null;
    }
}
