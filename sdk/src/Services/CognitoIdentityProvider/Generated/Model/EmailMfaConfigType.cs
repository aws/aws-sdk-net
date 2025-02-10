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
    /// Sets or shows user pool email message configuration for MFA. Includes the subject
    /// and body of the email message template for MFA messages. To activate this setting,
    /// <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html">
    /// advanced security features</a> must be active in your user pool.
    /// 
    ///  
    /// <para>
    /// This data type is a request parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SetUserPoolMfaConfig.html">SetUserPoolMfaConfig</a>
    /// and a response parameter of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_GetUserPoolMfaConfig.html">GetUserPoolMfaConfig</a>.
    /// </para>
    /// </summary>
    public partial class EmailMfaConfigType
    {
        private string _message;
        private string _subject;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The template for the email message that your user pool sends to users with a code
        /// for MFA and sign-in with an email OTP. The message must contain the <c>{####}</c>
        /// placeholder. In the message, Amazon Cognito replaces this placeholder with the code.
        /// If you don't provide this parameter, Amazon Cognito sends messages in the default
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=20000)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject of the email message that your user pool sends to users with a code for
        /// MFA and email OTP sign-in.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}