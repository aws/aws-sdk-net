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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// This is the response object from the GetWebIdentityToken operation.
    /// </summary>
    public partial class GetWebIdentityTokenResponse : AmazonWebServiceResponse
    {
        private DateTime? _expiration;
        private string _webIdentityToken;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date and time when the web identity token expires, in UTC. The expiration is determined
        /// by adding the <c>DurationSeconds</c> value to the time the token was issued. After
        /// this time, the token should no longer be considered valid.
        /// </para>
        /// </summary>
        public DateTime? Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebIdentityToken. 
        /// <para>
        /// A signed JSON Web Token (JWT) that represents the caller's Amazon Web Services identity.
        /// The token contains standard JWT claims such as subject, audience, expiration time,
        /// and additional identity attributes added by STS as custom claims. You can also add
        /// your own custom claims to the token by passing tags as request parameters to the <c>GetWebIdentityToken</c>
        /// API. The token is signed using the specified signing algorithm and can be verified
        /// using the verification keys available at the issuer's JWKS endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string WebIdentityToken
        {
            get { return this._webIdentityToken; }
            set { this._webIdentityToken = value; }
        }

        // Check to see if WebIdentityToken property is set
        internal bool IsSetWebIdentityToken()
        {
            return this._webIdentityToken != null;
        }

    }
}