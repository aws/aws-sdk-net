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
    /// Container for the parameters to the GetIdentityProviderByIdentifier operation.
    /// Given the identifier of an identity provider (IdP), for example <c>examplecorp</c>,
    /// returns information about the user pool configuration for that IdP. For more information
    /// about IdPs, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation.html">Third-party
    /// IdP sign-in</a>.
    /// </summary>
    public partial class GetIdentityProviderByIdentifierRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _idpIdentifier;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property IdpIdentifier. 
        /// <para>
        /// The identifier that you assigned to your user pool. The identifier is an alternative
        /// name for an IdP that is distinct from the IdP name. For example, an IdP with a name
        /// of <c>MyIdP</c> might have an identifier of the email domain <c>example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string IdpIdentifier
        {
            get { return this._idpIdentifier; }
            set { this._idpIdentifier = value; }
        }

        // Check to see if IdpIdentifier property is set
        internal bool IsSetIdpIdentifier()
        {
            return this._idpIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to get information about the IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}