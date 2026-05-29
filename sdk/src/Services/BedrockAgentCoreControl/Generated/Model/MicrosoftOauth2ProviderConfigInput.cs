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
    /// Input configuration for a Microsoft OAuth2 provider.
    /// </summary>
    public partial class MicrosoftOauth2ProviderConfigInput
    {
        private string _clientId;
        private string _clientSecret;
        private SecretReference _clientSecretConfig;
        private SecretSourceType _clientSecretSource;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the Microsoft OAuth2 provider.
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
        /// The client secret for the Microsoft OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property ClientSecretConfig. 
        /// <para>
        /// A reference to the AWS Secrets Manager secret that stores the client secret. This
        /// includes the secret ID and the JSON key used to extract the client secret value from
        /// the secret. Required when <c>clientSecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference ClientSecretConfig
        {
            get { return this._clientSecretConfig; }
            set { this._clientSecretConfig = value; }
        }

        // Check to see if ClientSecretConfig property is set
        internal bool IsSetClientSecretConfig()
        {
            return this._clientSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecretSource. 
        /// <para>
        /// The source type of the client secret. Use <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if you manage the secret yourself in AWS Secrets
        /// Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ClientSecretSource
        {
            get { return this._clientSecretSource; }
            set { this._clientSecretSource = value; }
        }

        // Check to see if ClientSecretSource property is set
        internal bool IsSetClientSecretSource()
        {
            return this._clientSecretSource != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The Microsoft Entra ID (formerly Azure AD) tenant ID for your organization. This identifies
        /// the specific tenant within Microsoft's identity platform where your application is
        /// registered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

    }
}