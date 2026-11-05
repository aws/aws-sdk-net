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
    /// Stripe Privy configuration output with secret ARNs.
    /// </summary>
    public partial class StripePrivyConfigurationOutput
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
        /// Gets and sets the property AppSecretArn.
        /// </summary>
        [AWSProperty(Required = true)]
        public Secret AppSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the AppSecretArn property is set.
        /// </summary>
        internal bool IsSetAppSecretArn() => this.AppSecretArn != null;

        /// <summary>
        /// Gets and sets the property AppSecretJsonKey. 
        /// <para>
        /// The JSON key used to extract the app secret value from the Amazon Web Services Secrets
        /// Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AppSecretJsonKey { get; set; }

        /// <summary>
        /// Checks to see if the AppSecretJsonKey property is set.
        /// </summary>
        internal bool IsSetAppSecretJsonKey() => this.AppSecretJsonKey != null;

        /// <summary>
        /// Gets and sets the property AppSecretSource. 
        /// <para>
        /// The source type of the app secret. Either <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web Services Secrets
        /// Manager.
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
        /// Gets and sets the property AuthorizationPrivateKeyArn.
        /// </summary>
        [AWSProperty(Required = true)]
        public Secret AuthorizationPrivateKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationPrivateKeyArn property is set.
        /// </summary>
        internal bool IsSetAuthorizationPrivateKeyArn() => this.AuthorizationPrivateKeyArn != null;

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKeyJsonKey. 
        /// <para>
        /// The JSON key used to extract the authorization private key value from the Amazon Web
        /// Services Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AuthorizationPrivateKeyJsonKey { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationPrivateKeyJsonKey property is set.
        /// </summary>
        internal bool IsSetAuthorizationPrivateKeyJsonKey() => this.AuthorizationPrivateKeyJsonKey != null;

        /// <summary>
        /// Gets and sets the property AuthorizationPrivateKeySource. 
        /// <para>
        /// The source type of the authorization private key. Either <c>MANAGED</c> if the secret
        /// is managed by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web
        /// Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType AuthorizationPrivateKeySource { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationPrivateKeySource property is set.
        /// </summary>
        internal bool IsSetAuthorizationPrivateKeySource() => this.AuthorizationPrivateKeySource != null;
    }
}
