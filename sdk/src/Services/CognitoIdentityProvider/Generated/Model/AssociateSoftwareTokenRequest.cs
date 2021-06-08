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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateSoftwareToken operation.
    /// Returns a unique generated shared secret key code for the user account. The request
    /// takes an access token or a session string, but not both.
    /// 
    ///  <note> 
    /// <para>
    /// Calling AssociateSoftwareToken immediately disassociates the existing software token
    /// from the user account. If the user doesn't subsequently verify the software token,
    /// their account is essentially set up to authenticate without MFA. If MFA config is
    /// set to Optional at the user pool level, the user can then login without MFA. However,
    /// if MFA is set to Required for the user pool, the user will be asked to setup a new
    /// software token MFA during sign in.
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
        /// The access token.
        /// </para>
        /// </summary>
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
        /// The session which should be passed both ways in challenge-response calls to the service.
        /// This allows authentication of the user as part of the MFA setup process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

    }
}