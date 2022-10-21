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
    /// Container for the parameters to the SetUserPoolMfaConfig operation.
    /// Sets the user pool multi-factor authentication (MFA) configuration.
    /// 
    ///  <note> 
    /// <para>
    /// This action might generate an SMS text message. Starting June 1, 2021, US telecom
    /// carriers require you to register an origination phone number before you can send SMS
    /// messages to US phone numbers. If you use SMS text messages in Amazon Cognito, you
    /// must register a phone number with <a href="https://console.aws.amazon.com/pinpoint/home/">Amazon
    /// Pinpoint</a>. Amazon Cognito uses the registered number automatically. Otherwise,
    /// Amazon Cognito users who must receive SMS messages might not be able to sign up, activate
    /// their accounts, or sign in.
    /// </para>
    ///  
    /// <para>
    /// If you have never used SMS text messages with Amazon Cognito or any other Amazon Web
    /// Service, Amazon Simple Notification Service might place your account in the SMS sandbox.
    /// In <i> <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">sandbox
    /// mode</a> </i>, you can send messages only to verified phone numbers. After you test
    /// your app while in the sandbox environment, you can move out of the sandbox and into
    /// production. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-sms-userpool-settings.html">
    /// SMS message settings for Amazon Cognito user pools</a> in the <i>Amazon Cognito Developer
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SetUserPoolMfaConfigRequest : AmazonCognitoIdentityProviderRequest
    {
        private UserPoolMfaType _mfaConfiguration;
        private SmsMfaConfigType _smsMfaConfiguration;
        private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// The MFA configuration. If you set the MfaConfiguration value to ‘ON’, only users who
        /// have set up an MFA factor can sign in. To learn more, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-mfa.html">Adding
        /// Multi-Factor Authentication (MFA) to a user pool</a>. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>OFF</code> MFA won't be used for any users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ON</code> MFA is required for all users to sign in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OPTIONAL</code> MFA will be required only for individual users who have an
        /// MFA factor activated.
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
        /// The SMS text message MFA configuration.
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
        /// The software token MFA configuration.
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