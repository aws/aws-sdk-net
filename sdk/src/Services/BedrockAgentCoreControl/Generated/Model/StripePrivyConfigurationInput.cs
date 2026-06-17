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
    /// Stripe Privy configuration — credentials provided by Stripe and Privy.
    /// </summary>
    public partial class StripePrivyConfigurationInput
    {
        private string _appId;
        private string _appSecret;
        private SecretReference _appSecretConfig;
        private SecretSourceType _appSecretSource;
        private string _authorizationId;
        private string _authorizationPrivateKey;
        private SecretReference _authorizationPrivateKeyConfig;
        private SecretSourceType _authorizationPrivateKeySource;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID provided by Privy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AppSecret. 
        /// <para>
        /// The app secret provided by Privy.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string AppSecret
        {
            get { return this._appSecret; }
            set { this._appSecret = value; }
        }

        // Check to see if AppSecret property is set
        internal bool IsSetAppSecret()
        {
            return this._appSecret != null;
        }

        /// <summary>
        /// Gets and sets the property AppSecretConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the app
        /// secret. This includes the secret ID and the JSON key used to extract the app secret
        /// value from the secret. Required when <c>appSecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference AppSecretConfig
        {
            get { return this._appSecretConfig; }
            set { this._appSecretConfig = value; }
        }

        // Check to see if AppSecretConfig property is set
        internal bool IsSetAppSecretConfig()
        {
            return this._appSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AppSecretSource. 
        /// <para>
        /// The source type of the app secret. Use <c>MANAGED</c> if the secret is managed by
        /// the service, or <c>EXTERNAL</c> if you manage the secret yourself in Amazon Web Services
        /// Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType AppSecretSource
        {
            get { return this._appSecretSource; }
            set { this._appSecretSource = value; }
        }

        // Check to see if AppSecretSource property is set
        internal bool IsSetAppSecretSource()
        {
            return this._appSecretSource != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationId. 
        /// <para>
        /// The authorization ID for the Stripe Privy integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AuthorizationId
        {
            get { return this._authorizationId; }
            set { this._authorizationId = value; }
        }

        // Check to see if AuthorizationId property is set
        internal bool IsSetAuthorizationId()
        {
            return this._authorizationId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKey. 
        /// <para>
        /// The authorization private key for the Stripe Privy integration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string AuthorizationPrivateKey
        {
            get { return this._authorizationPrivateKey; }
            set { this._authorizationPrivateKey = value; }
        }

        // Check to see if AuthorizationPrivateKey property is set
        internal bool IsSetAuthorizationPrivateKey()
        {
            return this._authorizationPrivateKey != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKeyConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the authorization
        /// private key. This includes the secret ID and the JSON key used to extract the authorization
        /// private key value from the secret. Required when <c>authorizationPrivateKeySource</c>
        /// is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference AuthorizationPrivateKeyConfig
        {
            get { return this._authorizationPrivateKeyConfig; }
            set { this._authorizationPrivateKeyConfig = value; }
        }

        // Check to see if AuthorizationPrivateKeyConfig property is set
        internal bool IsSetAuthorizationPrivateKeyConfig()
        {
            return this._authorizationPrivateKeyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKeySource. 
        /// <para>
        /// The source type of the authorization private key. Use <c>MANAGED</c> if the secret
        /// is managed by the service, or <c>EXTERNAL</c> if you manage the secret yourself in
        /// Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType AuthorizationPrivateKeySource
        {
            get { return this._authorizationPrivateKeySource; }
            set { this._authorizationPrivateKeySource = value; }
        }

        // Check to see if AuthorizationPrivateKeySource property is set
        internal bool IsSetAuthorizationPrivateKeySource()
        {
            return this._authorizationPrivateKeySource != null;
        }

    }
}