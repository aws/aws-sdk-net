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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID provided by Privy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property AppSecret. 
        /// <para>
        /// The app secret provided by Privy.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string AppSecret { get; set; }

        /// <summary>
        /// Checks to see if the AppSecret property is set.
        /// </summary>
        internal bool IsSetAppSecret() => this.AppSecret != null;

        /// <summary>
        /// Gets and sets the property AppSecretConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the app
        /// secret. This includes the secret ID and the JSON key used to extract the app secret
        /// value from the secret. Required when <c>appSecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference AppSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the AppSecretConfig property is set.
        /// </summary>
        internal bool IsSetAppSecretConfig() => this.AppSecretConfig != null;

        /// <summary>
        /// Gets and sets the property AppSecretSource. 
        /// <para>
        /// The source type of the app secret. Use <c>MANAGED</c> if the secret is managed by
        /// the service, or <c>EXTERNAL</c> if you manage the secret yourself in Amazon Web Services
        /// Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType AppSecretSource { get; set; }

        /// <summary>
        /// Checks to see if the AppSecretSource property is set.
        /// </summary>
        internal bool IsSetAppSecretSource() => this.AppSecretSource != null;

        /// <summary>
        /// Gets and sets the property AuthorizationId. 
        /// <para>
        /// The authorization ID for the Stripe Privy integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationId property is set.
        /// </summary>
        internal bool IsSetAuthorizationId() => this.AuthorizationId != null;

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKey. 
        /// <para>
        /// The authorization private key for the Stripe Privy integration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string AuthorizationPrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationPrivateKey property is set.
        /// </summary>
        internal bool IsSetAuthorizationPrivateKey() => this.AuthorizationPrivateKey != null;

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKeyConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the authorization
        /// private key. This includes the secret ID and the JSON key used to extract the authorization
        /// private key value from the secret. Required when <c>authorizationPrivateKeySource</c>
        /// is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference AuthorizationPrivateKeyConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationPrivateKeyConfig property is set.
        /// </summary>
        internal bool IsSetAuthorizationPrivateKeyConfig() => this.AuthorizationPrivateKeyConfig != null;

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKeySource. 
        /// <para>
        /// The source type of the authorization private key. Use <c>MANAGED</c> if the secret
        /// is managed by the service, or <c>EXTERNAL</c> if you manage the secret yourself in
        /// Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType AuthorizationPrivateKeySource { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationPrivateKeySource property is set.
        /// </summary>
        internal bool IsSetAuthorizationPrivateKeySource() => this.AuthorizationPrivateKeySource != null;
    }
}
