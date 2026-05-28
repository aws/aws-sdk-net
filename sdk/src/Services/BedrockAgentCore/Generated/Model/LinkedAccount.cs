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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Represents different linked accounts that can be linked to an embedded wallet. Supports
    /// email, SMS, JWT, and OAuth2 approaches.
    /// </summary>
    public partial class LinkedAccount
    {
        private LinkedAccountDeveloperJwt _developerJwt;
        private LinkedAccountEmail _email;
        private LinkedAccountOAuth2 _oAuth2;
        private LinkedAccountSms _sms;

        /// <summary>
        /// Gets and sets the property DeveloperJwt. 
        /// <para>
        /// Developer JWT linked account with key ID and subject.
        /// </para>
        /// </summary>
        public LinkedAccountDeveloperJwt DeveloperJwt
        {
            get { return this._developerJwt; }
            set { this._developerJwt = value; }
        }

        // Check to see if DeveloperJwt property is set
        internal bool IsSetDeveloperJwt()
        {
            return this._developerJwt != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Email-based linked account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public LinkedAccountEmail Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2. 
        /// <para>
        /// OAuth2 provider linked account (Google, Apple, X, Telegram, GitHub).
        /// </para>
        /// </summary>
        public LinkedAccountOAuth2 OAuth2
        {
            get { return this._oAuth2; }
            set { this._oAuth2 = value; }
        }

        // Check to see if OAuth2 property is set
        internal bool IsSetOAuth2()
        {
            return this._oAuth2 != null;
        }

        /// <summary>
        /// Gets and sets the property Sms. 
        /// <para>
        /// SMS-based linked account using phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public LinkedAccountSms Sms
        {
            get { return this._sms; }
            set { this._sms = value; }
        }

        // Check to see if Sms property is set
        internal bool IsSetSms()
        {
            return this._sms != null;
        }

    }
}