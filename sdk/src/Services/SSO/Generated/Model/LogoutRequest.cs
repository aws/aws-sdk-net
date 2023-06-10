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
 * Do not modify this file. This file is generated from the sso-2019-06-10.normal.json service model.
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

namespace Amazon.SSO.Model
{
    /// <summary>
    /// Container for the parameters to the Logout operation.
    /// Removes the locally stored SSO tokens from the client-side cache and sends an API
    /// call to the IAM Identity Center service to invalidate the corresponding server-side
    /// IAM Identity Center sign in session.
    /// 
    ///  <note> 
    /// <para>
    /// If a user uses IAM Identity Center to access the AWS CLI, the user’s IAM Identity
    /// Center sign in session is used to obtain an IAM session, as specified in the corresponding
    /// IAM Identity Center permission set. More specifically, IAM Identity Center assumes
    /// an IAM role in the target account on behalf of the user, and the corresponding temporary
    /// AWS credentials are returned to the client.
    /// </para>
    ///  
    /// <para>
    /// After user logout, any existing IAM role sessions that were created by using IAM Identity
    /// Center permission sets continue based on the duration configured in the permission
    /// set. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/authconcept.html">User
    /// authentications</a> in the <i>IAM Identity Center User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LogoutRequest : AmazonSSORequest
    {
        private string _accessToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The token issued by the <code>CreateToken</code> API call. For more information, see
        /// <a href="https://docs.aws.amazon.com/singlesignon/latest/OIDCAPIReference/API_CreateToken.html">CreateToken</a>
        /// in the <i>IAM Identity Center OIDC API Reference Guide</i>.
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