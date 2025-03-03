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
    /// The configuration of multi-factor authentication (MFA) with SMS messages in a user
    /// pool.
    /// </summary>
    public partial class SmsMfaConfigType
    {
        private string _smsAuthenticationMessage;
        private SmsConfigurationType _smsConfiguration;

        /// <summary>
        /// Gets and sets the property SmsAuthenticationMessage. 
        /// <para>
        /// The SMS authentication message that will be sent to users with the code they must
        /// sign in with. The message must contain the <c>{####}</c> placeholder. Your user pool
        /// replaces the placeholder with the MFA code. If this parameter isn't provided, your
        /// user pool sends a default message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=140)]
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
        /// User pool configuration for delivery of SMS messages with Amazon Simple Notification
        /// Service. To send SMS messages with Amazon SNS in the Amazon Web Services Region that
        /// you want, the Amazon Cognito user pool uses an Identity and Access Management (IAM)
        /// role in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// You can set <c>SmsConfiguration</c> in <c>CreateUserPool</c> and <c> UpdateUserPool</c>,
        /// or in <c>SetUserPoolMfaConfig</c>.
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

    }
}