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
    /// Container for the parameters to the CreateApiKeyCredentialProvider operation. Creates
    /// a new API key credential provider.
    /// </summary>
    public partial class CreateApiKeyCredentialProviderRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API key to use for authentication. This value is encrypted and stored securely.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 65536)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKey property is set.
        /// </summary>
        internal bool IsSetApiKey() => this.ApiKey != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the API
        /// key. This includes the secret ID and the JSON key used to extract the API key value
        /// from the secret. Required when <c>apiKeySecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference ApiKeySecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretConfig property is set.
        /// </summary>
        internal bool IsSetApiKeySecretConfig() => this.ApiKeySecretConfig != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretSource. 
        /// <para>
        /// The source type of the API key secret. Use <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if you manage the secret yourself in Amazon Web
        /// Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ApiKeySecretSource { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretSource property is set.
        /// </summary>
        internal bool IsSetApiKeySecretSource() => this.ApiKeySecretSource != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API key credential provider. The name must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to the API key credential provider. Tags enable
        /// you to categorize your resources in different ways, for example, by purpose, owner,
        /// or environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
