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
    /// Input configuration for a custom OAuth2 provider.
    /// </summary>
    public partial class CustomOauth2ProviderConfigInput
    {
        private string _clientId;
        private string _clientSecret;
        private Oauth2Discovery _oauthDiscovery;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the custom OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret for the custom OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property OauthDiscovery. 
        /// <para>
        /// The OAuth2 discovery information for the custom provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Oauth2Discovery OauthDiscovery
        {
            get { return this._oauthDiscovery; }
            set { this._oauthDiscovery = value; }
        }

        // Check to see if OauthDiscovery property is set
        internal bool IsSetOauthDiscovery()
        {
            return this._oauthDiscovery != null;
        }

    }
}