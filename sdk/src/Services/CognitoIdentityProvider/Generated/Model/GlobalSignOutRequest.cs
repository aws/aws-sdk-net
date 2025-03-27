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
    /// Container for the parameters to the GlobalSignOut operation.
    /// Invalidates the identity, access, and refresh tokens that Amazon Cognito issued to
    /// a user. Call this operation when your user signs out of your app. This results in
    /// the following behavior. 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Amazon Cognito no longer accepts <i>token-authorized</i> user operations that you
    /// authorize with a signed-out user's access tokens. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon Cognito returns an <c>Access Token has been revoked</c> error when your app
    /// attempts to authorize a user pools API request with a revoked access token that contains
    /// the scope <c>aws.cognito.signin.user.admin</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Cognito no longer accepts a signed-out user's ID token in a <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetId.html">GetId
    /// </a> request to an identity pool with <c>ServerSideTokenCheck</c> enabled for its
    /// user pool IdP configuration in <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_CognitoIdentityProvider.html">CognitoIdentityProvider</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Cognito no longer accepts a signed-out user's refresh tokens in refresh requests.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Other requests might be valid until your user's token expires. This operation doesn't
    /// clear the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html">managed
    /// login</a> session cookie. To clear the session for a user who signed in with managed
    /// login or the classic hosted UI, direct their browser session to the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/logout-endpoint.html">logout
    /// endpoint</a>.
    /// </para>
    ///  
    /// <para>
    /// Authorize this action with a signed-in user's access token. It must include the scope
    /// <c>aws.cognito.signin.user.admin</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GlobalSignOutRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the currently signed-in user. Must
        /// include a scope claim for <c>aws.cognito.signin.user.admin</c>.
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

    }
}