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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The response from GetIdentityCenterAuthToken containing the encrypted authentication
    /// token and expiration time.
    /// </summary>
    public partial class GetIdentityCenterAuthTokenResponse : AmazonWebServiceResponse
    {
        private DateTime? _expirationTime;
        private string _token;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time (UTC) when the token expires. After this timestamp, the token will no longer
        /// be valid for authentication.
        /// </para>
        /// </summary>
        public DateTime ExpirationTime
        {
            get { return this._expirationTime.GetValueOrDefault(); }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The encrypted authentication token containing the caller's Amazon Web Services IAM
        /// Identity Center identity information. This token is encrypted using Key Management
        /// Service and can only be decrypted by the specified Amazon Redshift clusters. Use this
        /// token with Amazon Redshift drivers to authenticate using your Amazon Web Services
        /// IAM Identity Center identity.
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

    }
}