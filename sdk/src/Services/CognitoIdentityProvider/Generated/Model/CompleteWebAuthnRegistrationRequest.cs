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
    /// Container for the parameters to the CompleteWebAuthnRegistration operation.
    /// Completes registration of a passkey authenticator for the currently signed-in user.
    /// 
    ///  
    /// <para>
    /// Authorize this action with a signed-in user's access token. It must include the scope
    /// <c>aws.cognito.signin.user.admin</c>.
    /// </para>
    /// </summary>
    public partial class CompleteWebAuthnRegistrationRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private Amazon.Runtime.Documents.Document _credential;

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

        /// <summary>
        /// Gets and sets the property Credential. 
        /// <para>
        /// A <a href="https://www.w3.org/TR/WebAuthn-3/#dictdef-registrationresponsejson">RegistrationResponseJSON</a>
        /// public-key credential response from the user's passkey provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Credential
        {
            get { return this._credential; }
            set { this._credential = value; }
        }

        // Check to see if Credential property is set
        internal bool IsSetCredential()
        {
            return !this._credential.IsNull();
        }

    }
}