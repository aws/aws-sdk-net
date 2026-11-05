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
    /// This is the response object from the UpdateApiKeyCredentialProvider operation.
    /// </summary>
    public partial class UpdateApiKeyCredentialProviderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApiKeySecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the API key secret in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Secret ApiKeySecretArn { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretArn property is set.
        /// </summary>
        internal bool IsSetApiKeySecretArn() => this.ApiKeySecretArn != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretJsonKey. 
        /// <para>
        /// The JSON key used to extract the API key value from the Amazon Web Services Secrets
        /// Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ApiKeySecretJsonKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretJsonKey property is set.
        /// </summary>
        internal bool IsSetApiKeySecretJsonKey() => this.ApiKeySecretJsonKey != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretSource. 
        /// <para>
        /// The source type of the API key secret. Either <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ApiKeySecretSource { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretSource property is set.
        /// </summary>
        internal bool IsSetApiKeySecretSource() => this.ApiKeySecretSource != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the API key credential provider was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the API key credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CredentialProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialProviderArn property is set.
        /// </summary>
        internal bool IsSetCredentialProviderArn() => this.CredentialProviderArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the API key credential provider was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API key credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
