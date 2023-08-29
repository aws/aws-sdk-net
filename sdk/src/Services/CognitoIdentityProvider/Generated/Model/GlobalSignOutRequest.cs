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
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the GlobalSignOut operation.
    /// Signs out a user from all devices. <code>GlobalSignOut</code> invalidates all identity,
    /// access and refresh tokens that Amazon Cognito has issued to a user. A user can still
    /// use a hosted UI cookie to retrieve new tokens for the duration of the 1-hour cookie
    /// validity period.
    /// 
    ///  
    /// <para>
    /// Your app isn't aware that a user's access token is revoked unless it attempts to authorize
    /// a user pools API request with an access token that contains the scope <code>aws.cognito.signin.user.admin</code>.
    /// Your app might otherwise accept access tokens until they expire.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito native and OIDC APIs</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GlobalSignOutRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user who you want to sign out.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}