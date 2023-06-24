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
    /// Container for the parameters to the ChangePassword operation.
    /// Changes the password for a specified user in a user pool.
    /// </summary>
    public partial class ChangePasswordRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private string _previousPassword;
        private string _proposedPassword;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user whose password you want
        /// to change.
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
        /// Gets and sets the property PreviousPassword. 
        /// <para>
        /// The old password.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=256)]
        public string PreviousPassword
        {
            get { return this._previousPassword; }
            set { this._previousPassword = value; }
        }

        // Check to see if PreviousPassword property is set
        internal bool IsSetPreviousPassword()
        {
            return this._previousPassword != null;
        }

        /// <summary>
        /// Gets and sets the property ProposedPassword. 
        /// <para>
        /// The new password.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=256)]
        public string ProposedPassword
        {
            get { return this._proposedPassword; }
            set { this._proposedPassword = value; }
        }

        // Check to see if ProposedPassword property is set
        internal bool IsSetProposedPassword()
        {
            return this._proposedPassword != null;
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