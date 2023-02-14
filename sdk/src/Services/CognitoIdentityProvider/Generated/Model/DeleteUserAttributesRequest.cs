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
    /// Container for the parameters to the DeleteUserAttributes operation.
    /// Deletes the attributes for a user.
    /// </summary>
    public partial class DeleteUserAttributesRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private List<string> _userAttributeNames = new List<string>();

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the user whose attributes you want
        /// to delete.
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
        /// Gets and sets the property UserAttributeNames. 
        /// <para>
        /// An array of strings representing the user attribute names you want to delete.
        /// </para>
        ///  
        /// <para>
        /// For custom attributes, you must prependattach the <code>custom:</code> prefix to the
        /// front of the attribute name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> UserAttributeNames
        {
            get { return this._userAttributeNames; }
            set { this._userAttributeNames = value; }
        }

        // Check to see if UserAttributeNames property is set
        internal bool IsSetUserAttributeNames()
        {
            return this._userAttributeNames != null && this._userAttributeNames.Count > 0; 
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