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
    /// Container for the parameters to the ChangePassword operation.
    /// Changes the password for the currently signed-in user.
    /// 
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
        /// The user's previous password. Required if the user has a password. If the user has
        /// no password and only signs in with passwordless authentication options, you can omit
        /// this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
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
        /// A new password that you prompted the user to enter in your application.
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

    }
}