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
    /// This is the response object from the GetOauth2CredentialProvider operation.
    /// </summary>
    public partial class GetOauth2CredentialProviderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CallbackUrl. 
        /// <para>
        /// Callback URL to register on the OAuth2 credential provider as an allowed callback
        /// URL. This URL is where the OAuth2 authorization server redirects users after they
        /// complete the authorization flow.
        /// </para>
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Checks to see if the CallbackUrl property is set.
        /// </summary>
        internal bool IsSetCallbackUrl() => this.CallbackUrl != null;

        /// <summary>
        /// Gets and sets the property ClientSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the client secret in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Secret ClientSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretArn property is set.
        /// </summary>
        internal bool IsSetClientSecretArn() => this.ClientSecretArn != null;

        /// <summary>
        /// Gets and sets the property ClientSecretJsonKey. 
        /// <para>
        /// The JSON key used to extract the client secret value from the Amazon Web Services
        /// Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientSecretJsonKey { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretJsonKey property is set.
        /// </summary>
        internal bool IsSetClientSecretJsonKey() => this.ClientSecretJsonKey != null;

        /// <summary>
        /// Gets and sets the property ClientSecretSource. 
        /// <para>
        /// The source type of the client secret. Either <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ClientSecretSource { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretSource property is set.
        /// </summary>
        internal bool IsSetClientSecretSource() => this.ClientSecretSource != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the OAuth2 credential provider was created.
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
        /// ARN of the credential provider requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CredentialProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialProviderArn property is set.
        /// </summary>
        internal bool IsSetCredentialProviderArn() => this.CredentialProviderArn != null;

        /// <summary>
        /// Gets and sets the property CredentialProviderVendor. 
        /// <para>
        /// The vendor of the OAuth2 credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CredentialProviderVendorType CredentialProviderVendor { get; set; }

        /// <summary>
        /// Checks to see if the CredentialProviderVendor property is set.
        /// </summary>
        internal bool IsSetCredentialProviderVendor() => this.CredentialProviderVendor != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for failure if the OAuth2 credential provider is in a failed state.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the OAuth2 credential provider was last updated.
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
        /// The name of the OAuth2 credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Oauth2ProviderConfigOutput. 
        /// <para>
        /// The configuration output for the OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Oauth2ProviderConfigOutput Oauth2ProviderConfigOutput { get; set; }

        /// <summary>
        /// Checks to see if the Oauth2ProviderConfigOutput property is set.
        /// </summary>
        internal bool IsSetOauth2ProviderConfigOutput() => this.Oauth2ProviderConfigOutput != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the OAuth2 credential provider.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
