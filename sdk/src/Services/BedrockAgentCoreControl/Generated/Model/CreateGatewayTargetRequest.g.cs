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
    /// Container for the parameters to the CreateGatewayTarget operation. Creates a target
    /// for a gateway. A target defines an endpoint that the gateway can connect to.
    /// </summary>
    public partial class CreateGatewayTargetRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateConfigurations. 
        /// <para>
        /// The private certificate authority (CA) configurations for the gateway target. Use
        /// this to have the gateway trust a private CA when it establishes TLS connections to
        /// the target endpoint. Provide each certificate by reference to an Amazon S3 object
        /// or an Amazon Web Services Secrets Manager secret. You can specify only one certificate
        /// authority configuration in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<CertificateConfiguration> CertificateConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CertificateConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CertificateConfigurations property is set.
        /// </summary>
        internal bool IsSetCertificateConfigurations() => this.CertificateConfigurations != null && (this.CertificateConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CredentialProviderConfigurations. 
        /// <para>
        /// The credential provider configurations for the target. These configurations specify
        /// how the gateway authenticates with the target endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<CredentialProviderConfiguration> CredentialProviderConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CredentialProviderConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CredentialProviderConfigurations property is set.
        /// </summary>
        internal bool IsSetCredentialProviderConfigurations() => this.CredentialProviderConfigurations != null && (this.CredentialProviderConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the gateway target.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GatewayIdentifier. 
        /// <para>
        /// The identifier of the gateway to create a target for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GatewayIdentifier property is set.
        /// </summary>
        internal bool IsSetGatewayIdentifier() => this.GatewayIdentifier != null;

        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// Optional configuration for HTTP header and query parameter propagation to and from
        /// the gateway target.
        /// </para>
        /// </summary>
        public MetadataConfiguration MetadataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MetadataConfiguration property is set.
        /// </summary>
        internal bool IsSetMetadataConfiguration() => this.MetadataConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the gateway target. The name must be unique within the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The private endpoint configuration for the gateway target. Use this to connect the
        /// gateway to private resources in your VPC.
        /// </para>
        /// </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpoint property is set.
        /// </summary>
        internal bool IsSetPrivateEndpoint() => this.PrivateEndpoint != null;

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// The configuration settings for the target, including endpoint information and schema
        /// definitions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;
    }
}
