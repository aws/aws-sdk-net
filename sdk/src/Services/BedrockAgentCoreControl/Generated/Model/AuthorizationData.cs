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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains the authorization data that is returned when a gateway target is configured
    /// with a credential provider with authorization code grant type and requires user federation.
    /// </summary>
    public partial class AuthorizationData
    {
        private OAuth2AuthorizationData _oauth2;

        /// <summary>
        /// Gets and sets the property Oauth2. 
        /// <para>
        /// OAuth2 authorization data for the gateway target.
        /// </para>
        /// </summary>
        public OAuth2AuthorizationData Oauth2
        {
            get { return this._oauth2; }
            set { this._oauth2 = value; }
        }

        // Check to see if Oauth2 property is set
        internal bool IsSetOauth2()
        {
            return this._oauth2 != null;
        }

    }
}