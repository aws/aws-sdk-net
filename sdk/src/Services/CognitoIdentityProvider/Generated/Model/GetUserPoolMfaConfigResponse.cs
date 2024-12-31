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
    /// This is the response object from the GetUserPoolMfaConfig operation.
    /// </summary>
    public partial class GetUserPoolMfaConfigResponse : AmazonWebServiceResponse
    {
        private EmailMfaConfigType _emailMfaConfiguration;
        private UserPoolMfaType _mfaConfiguration;
        private SmsMfaConfigType _smsMfaConfiguration;
        private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;
        private WebAuthnConfigurationType _webAuthnConfiguration;

        /// <summary>
        /// Gets and sets the property EmailMfaConfiguration. 
        /// <para>
        /// Shows user pool email message configuration for MFA. Includes the subject and body
        /// of the email message template for MFA messages. To activate this setting, <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html">
        /// advanced security features</a> must be active in your user pool.
        /// </para>
        /// </summary>
        public EmailMfaConfigType EmailMfaConfiguration
        {
            get { return this._emailMfaConfiguration; }
            set { this._emailMfaConfiguration = value; }
        }

        // Check to see if EmailMfaConfiguration property is set
        internal bool IsSetEmailMfaConfiguration()
        {
            return this._emailMfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// The multi-factor authentication (MFA) configuration. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OFF</c> MFA won't be used for any users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ON</c> MFA is required for all users to sign in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIONAL</c> MFA will be required only for individual users who have an MFA factor
        /// activated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserPoolMfaType MfaConfiguration
        {
            get { return this._mfaConfiguration; }
            set { this._mfaConfiguration = value; }
        }

        // Check to see if MfaConfiguration property is set
        internal bool IsSetMfaConfiguration()
        {
            return this._mfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SmsMfaConfiguration. 
        /// <para>
        /// Shows user pool SMS message configuration for MFA. Includes the message template and
        /// the SMS message sending configuration for Amazon SNS.
        /// </para>
        /// </summary>
        public SmsMfaConfigType SmsMfaConfiguration
        {
            get { return this._smsMfaConfiguration; }
            set { this._smsMfaConfiguration = value; }
        }

        // Check to see if SmsMfaConfiguration property is set
        internal bool IsSetSmsMfaConfiguration()
        {
            return this._smsMfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareTokenMfaConfiguration. 
        /// <para>
        /// Shows user pool configuration for time-based one-time password (TOTP) MFA. Includes
        /// TOTP enabled or disabled state.
        /// </para>
        /// </summary>
        public SoftwareTokenMfaConfigType SoftwareTokenMfaConfiguration
        {
            get { return this._softwareTokenMfaConfiguration; }
            set { this._softwareTokenMfaConfiguration = value; }
        }

        // Check to see if SoftwareTokenMfaConfiguration property is set
        internal bool IsSetSoftwareTokenMfaConfiguration()
        {
            return this._softwareTokenMfaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WebAuthnConfiguration. 
        /// <para>
        /// Shows user pool configuration for MFA with passkeys from biometric devices and security
        /// keys.
        /// </para>
        /// </summary>
        public WebAuthnConfigurationType WebAuthnConfiguration
        {
            get { return this._webAuthnConfiguration; }
            set { this._webAuthnConfiguration = value; }
        }

        // Check to see if WebAuthnConfiguration property is set
        internal bool IsSetWebAuthnConfiguration()
        {
            return this._webAuthnConfiguration != null;
        }

    }
}