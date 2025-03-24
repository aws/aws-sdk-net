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
    /// Container for the parameters to the GetUICustomization operation.
    /// Given a user pool ID or app client, returns information about classic hosted UI branding
    /// that you applied, if any. Returns user-pool level branding information if no app client
    /// branding is applied, or if you don't specify an app client ID. Returns an empty object
    /// if you haven't applied hosted UI branding to either the client or the user pool. For
    /// more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/hosted-ui-classic-branding.html">Hosted
    /// UI (classic) branding</a>.
    /// </summary>
    public partial class GetUICustomizationRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _clientId;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that you want to query for branding settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that you want to query for branding settings.
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