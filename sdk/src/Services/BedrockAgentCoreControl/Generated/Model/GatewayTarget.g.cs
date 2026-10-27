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
    /// The gateway target.
    /// </summary>
    public partial class GatewayTarget
    {
        /// <summary>
        /// Gets and sets the property AuthorizationData. 
        /// <para>
        /// OAuth2 authorization data for the gateway target. This data is returned when a target
        /// is configured with a credential provider with authorization code grant type and requires
        /// user federation.
        /// </para>
        /// </summary>
        public AuthorizationData AuthorizationData { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationData property is set.
        /// </summary>
        internal bool IsSetAuthorizationData() => this.AuthorizationData != null;

        /// <summary>
        /// Gets and sets the property CertificateConfigurations. 
        /// <para>
        /// The private certificate authority (CA) configurations for the gateway target.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time at which the target was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialProviderConfigurations. 
        /// <para>
        /// The provider configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<CredentialProviderConfiguration> CredentialProviderConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CredentialProviderConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CredentialProviderConfigurations property is set.
        /// </summary>
        internal bool IsSetCredentialProviderConfigurations() => this.CredentialProviderConfigurations != null && (this.CredentialProviderConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the gateway target.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property LastSynchronizedAt. 
        /// <para>
        /// The last synchronization time.
        /// </para>
        /// </summary>
        public DateTime? LastSynchronizedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSynchronizedAt property is set.
        /// </summary>
        internal bool IsSetLastSynchronizedAt() => this.LastSynchronizedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// The metadata configuration for HTTP header and query parameter propagation to and
        /// from this gateway target.
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
        /// The name of the gateway target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpoint.
        /// </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpoint property is set.
        /// </summary>
        internal bool IsSetPrivateEndpoint() => this.PrivateEndpoint != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpointManagedResources. 
        /// <para>
        /// A list of managed resources created by the gateway for private endpoint connectivity.
        /// These resources are created in your account when you use a managed VPC Lattice resource
        /// configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedResourceDetails> PrivateEndpointManagedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedResourceDetails>() : null;

        /// <summary>
        /// Checks to see if the PrivateEndpointManagedResources property is set.
        /// </summary>
        internal bool IsSetPrivateEndpointManagedResources() => this.PrivateEndpointManagedResources != null && (this.PrivateEndpointManagedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The protocol type of the gateway target.
        /// </para>
        /// </summary>
        public TargetProtocolType ProtocolType { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolType property is set.
        /// </summary>
        internal bool IsSetProtocolType() => this.ProtocolType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the gateway target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// The status reasons for the target status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> StatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusReasons property is set.
        /// </summary>
        internal bool IsSetStatusReasons() => this.StatusReasons != null && (this.StatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetConfiguration.
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The target ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time at which the target was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
