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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateSoftwareToken operation.
    /// Begins setup of time-based one-time password (TOTP) multi-factor authentication (MFA)
    /// for a user, with a unique private key that Amazon Cognito generates and returns in
    /// the API response. You can authorize an <c>AssociateSoftwareToken</c> request with
    /// either the user's access token, or a session string from a challenge response that
    /// you received from Amazon Cognito.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito disassociates an existing software token when you verify the new token
    /// in a <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerifySoftwareToken.html">
    /// VerifySoftwareToken</a> API request. If you don't verify the software token and your
    /// user pool doesn't require MFA, the user can then authenticate with user name and password
    /// credentials alone. If your user pool requires TOTP MFA, Amazon Cognito generates an
    /// <c>MFA_SETUP</c> or <c>SOFTWARE_TOKEN_SETUP</c> challenge each time your user signs.
    /// Complete setup with <c>AssociateSoftwareToken</c> and <c>VerifySoftwareToken</c>.
    /// </para>
    ///  
    /// <para>
    /// After you set up software token MFA for your user, Amazon Cognito generates a <c>SOFTWARE_TOKEN_MFA</c>
    /// challenge when they authenticate. Respond to this challenge with your user's TOTP.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateSoftwareTokenRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private string _session;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user whose software token you
        /// want to generate.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property Session. 
        /// <para>
        /// The session that should be passed both ways in challenge-response calls to the service.
        /// This allows authentication of the user as part of the MFA setup process.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2048)]
        public string Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
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