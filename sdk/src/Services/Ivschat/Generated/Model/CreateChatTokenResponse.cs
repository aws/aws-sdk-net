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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
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
namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// This is the response object from the CreateChatToken operation.
    /// </summary>
    public partial class CreateChatTokenResponse : AmazonWebServiceResponse
    {
        private DateTime? _sessionExpirationTime;
        private string _token;
        private DateTime? _tokenExpirationTime;

        /// <summary>
        /// Gets and sets the property SessionExpirationTime. 
        /// <para>
        /// Time after which an end user's session is no longer valid. This is an ISO 8601 timestamp;
        /// <i>note that this is returned as a string</i>.
        /// </para>
        /// </summary>
        public DateTime? SessionExpirationTime
        {
            get { return this._sessionExpirationTime; }
            set { this._sessionExpirationTime = value; }
        }

        // Check to see if SessionExpirationTime property is set
        internal bool IsSetSessionExpirationTime()
        {
            return this._sessionExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The issued client token, encrypted.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property TokenExpirationTime. 
        /// <para>
        /// Time after which the token is no longer valid and cannot be used to connect to a room.
        /// This is an ISO 8601 timestamp; <i>note that this is returned as a string</i>.
        /// </para>
        /// </summary>
        public DateTime? TokenExpirationTime
        {
            get { return this._tokenExpirationTime; }
            set { this._tokenExpirationTime = value; }
        }

        // Check to see if TokenExpirationTime property is set
        internal bool IsSetTokenExpirationTime()
        {
            return this._tokenExpirationTime.HasValue; 
        }

    }
}