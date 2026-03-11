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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Contains the <c>accessToken</c> provided by Meta during signup.
    /// </summary>
    public partial class WhatsAppSignupCallback
    {
        private string _accessToken;
        private string _callbackUrl;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The access token for your WhatsApp Business Account. The <c>accessToken</c> value
        /// is provided by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property CallbackUrl. 
        /// <para>
        /// The URL where WhatsApp will send callback notifications for this account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string CallbackUrl
        {
            get { return this._callbackUrl; }
            set { this._callbackUrl = value; }
        }

        // Check to see if CallbackUrl property is set
        internal bool IsSetCallbackUrl()
        {
            return this._callbackUrl != null;
        }

    }
}