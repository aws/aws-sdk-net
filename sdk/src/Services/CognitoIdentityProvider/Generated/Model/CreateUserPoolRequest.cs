/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUserPool operation.
    /// Creates a new Amazon Cognito user pool and sets the password policy for the pool.
    /// </summary>
    public partial class CreateUserPoolRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<string> _aliasAttributes = new List<string>();
        private List<string> _autoVerifiedAttributes = new List<string>();
        private DeviceConfigurationType _deviceConfiguration;
        private EmailConfigurationType _emailConfiguration;
        private string _emailVerificationMessage;
        private string _emailVerificationSubject;
        private LambdaConfigType _lambdaConfig;
        private UserPoolMfaType _mfaConfiguration;
        private UserPoolPolicyType _policies;
        private string _poolName;
        private string _smsAuthenticationMessage;
        private SmsConfigurationType _smsConfiguration;
        private string _smsVerificationMessage;

        /// <summary>
        /// Gets and sets the property AliasAttributes. 
        /// <para>
        /// Attributes supported as an alias for this user pool. Possible values: <b>phone_number</b>,
        /// <b>email</b>, or <b>preferred_username</b>.
        /// </para>
        /// </summary>
        public List<string> AliasAttributes
        {
            get { return this._aliasAttributes; }
            set { this._aliasAttributes = value; }
        }

        // Check to see if AliasAttributes property is set
        internal bool IsSetAliasAttributes()
        {
            return this._aliasAttributes != null && this._aliasAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoVerifiedAttributes. 
        /// <para>
        /// The attributes to be auto-verified. Possible values: <b>email</b>, <b>phone_number</b>.
        /// </para>
        /// </summary>
        public List<string> AutoVerifiedAttributes
        {
            get { return this._autoVerifiedAttributes; }
            set { this._autoVerifiedAttributes = value; }
        }

        // Check to see if AutoVerifiedAttributes property is set
        internal bool IsSetAutoVerifiedAttributes()
        {
            return this._autoVerifiedAttributes != null && this._autoVerifiedAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceConfiguration. 
        /// <para>
        /// The device configuration.
        /// </para>
        /// </summary>
        public DeviceConfigurationType DeviceConfiguration
        {
            get { return this._deviceConfiguration; }
            set { this._deviceConfiguration = value; }
        }

        // Check to see if DeviceConfiguration property is set
        internal bool IsSetDeviceConfiguration()
        {
            return this._deviceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EmailConfiguration. 
        /// <para>
        /// The email configuration.
        /// </para>
        /// </summary>
        public EmailConfigurationType EmailConfiguration
        {
            get { return this._emailConfiguration; }
            set { this._emailConfiguration = value; }
        }

        // Check to see if EmailConfiguration property is set
        internal bool IsSetEmailConfiguration()
        {
            return this._emailConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EmailVerificationMessage. 
        /// <para>
        /// A string representing the email verification message.
        /// </para>
        /// </summary>
        public string EmailVerificationMessage
        {
            get { return this._emailVerificationMessage; }
            set { this._emailVerificationMessage = value; }
        }

        // Check to see if EmailVerificationMessage property is set
        internal bool IsSetEmailVerificationMessage()
        {
            return this._emailVerificationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EmailVerificationSubject. 
        /// <para>
        /// A string representing the email verification subject.
        /// </para>
        /// </summary>
        public string EmailVerificationSubject
        {
            get { return this._emailVerificationSubject; }
            set { this._emailVerificationSubject = value; }
        }

        // Check to see if EmailVerificationSubject property is set
        internal bool IsSetEmailVerificationSubject()
        {
            return this._emailVerificationSubject != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaConfig. 
        /// <para>
        /// The Lambda trigger configuration information for the new user pool.
        /// </para>
        /// </summary>
        public LambdaConfigType LambdaConfig
        {
            get { return this._lambdaConfig; }
            set { this._lambdaConfig = value; }
        }

        // Check to see if LambdaConfig property is set
        internal bool IsSetLambdaConfig()
        {
            return this._lambdaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MfaConfiguration. 
        /// <para>
        /// Specifies MFA configuration details.
        /// </para>
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
        /// Gets and sets the property Policies. 
        /// <para>
        /// The policies associated with the new user pool.
        /// </para>
        /// </summary>
        public UserPoolPolicyType Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null;
        }

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// A string used to name the user pool.
        /// </para>
        /// </summary>
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property SmsAuthenticationMessage. 
        /// <para>
        /// A string representing the SMS authentication message.
        /// </para>
        /// </summary>
        public string SmsAuthenticationMessage
        {
            get { return this._smsAuthenticationMessage; }
            set { this._smsAuthenticationMessage = value; }
        }

        // Check to see if SmsAuthenticationMessage property is set
        internal bool IsSetSmsAuthenticationMessage()
        {
            return this._smsAuthenticationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SmsConfiguration. 
        /// <para>
        /// The SMS configuration.
        /// </para>
        /// </summary>
        public SmsConfigurationType SmsConfiguration
        {
            get { return this._smsConfiguration; }
            set { this._smsConfiguration = value; }
        }

        // Check to see if SmsConfiguration property is set
        internal bool IsSetSmsConfiguration()
        {
            return this._smsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SmsVerificationMessage. 
        /// <para>
        /// A string representing the SMS verification message.
        /// </para>
        /// </summary>
        public string SmsVerificationMessage
        {
            get { return this._smsVerificationMessage; }
            set { this._smsVerificationMessage = value; }
        }

        // Check to see if SmsVerificationMessage property is set
        internal bool IsSetSmsVerificationMessage()
        {
            return this._smsVerificationMessage != null;
        }

    }
}