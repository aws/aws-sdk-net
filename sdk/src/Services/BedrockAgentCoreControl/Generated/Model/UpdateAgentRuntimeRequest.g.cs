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
    /// Container for the parameters to the UpdateAgentRuntime operation. Updates an existing
    /// Amazon Secure Agent.
    /// </summary>
    public partial class UpdateAgentRuntimeRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property AgentRuntimeArtifact. 
        /// <para>
        /// The updated artifact of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentRuntimeArtifact AgentRuntimeArtifact { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeArtifact property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeArtifact() => this.AgentRuntimeArtifact != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The unique identifier of the AgentCore Runtime to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeId property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeId() => this.AgentRuntimeId != null;

        /// <summary>
        /// Gets and sets the property AllowedPorts. 
        /// <para>
        /// The updated additional ports on the AgentCore Runtime that are reachable through the
        /// runtime's session URL. Specify one to five non-overlapping entries, each containing
        /// either a single port or an inclusive port range. Ports must be between <c>8000</c>
        /// and <c>12000</c>, excluding the reserved port <c>8443</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AllowedPort> AllowedPorts { get; set; } = AWSConfigs.InitializeCollections ? new List<AllowedPort>() : null;

        /// <summary>
        /// Checks to see if the AllowedPorts property is set.
        /// </summary>
        internal bool IsSetAllowedPorts() => this.AllowedPorts != null && (this.AllowedPorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The updated authorizer configuration for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthorizerConfiguration() => this.AuthorizerConfiguration != null;

        /// <summary>
        /// Gets and sets the property CapacityProviderConfiguration. 
        /// <para>
        /// The updated capacity provider configuration for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public CapacityProviderConfiguration CapacityProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetCapacityProviderConfiguration() => this.CapacityProviderConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Updated environment variables to set in the AgentCore Runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilesystemConfigurations. 
        /// <para>
        /// The updated filesystem configurations to mount into the AgentCore Runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<FilesystemConfiguration> FilesystemConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<FilesystemConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FilesystemConfigurations property is set.
        /// </summary>
        internal bool IsSetFilesystemConfigurations() => this.FilesystemConfigurations != null && (this.FilesystemConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LifecycleConfiguration. 
        /// <para>
        /// The updated life cycle configuration for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public LifecycleConfiguration LifecycleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleConfiguration property is set.
        /// </summary>
        internal bool IsSetLifecycleConfiguration() => this.LifecycleConfiguration != null;

        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// The updated configuration for microVM Metadata Service (MMDS) settings for the AgentCore
        /// Runtime.
        /// </para>
        /// </summary>
        public RuntimeMetadataConfiguration MetadataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MetadataConfiguration property is set.
        /// </summary>
        internal bool IsSetMetadataConfiguration() => this.MetadataConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The updated network configuration for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The updated version of the runtime platform to use for the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property ProtocolConfiguration. 
        /// <para>
        /// The updated protocol configuration for the AgentCore Runtime, including the protocol,
        /// port, and path on which the agent server is available.
        /// </para>
        /// </summary>
        public ProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolConfiguration property is set.
        /// </summary>
        internal bool IsSetProtocolConfiguration() => this.ProtocolConfiguration != null;

        /// <summary>
        /// Gets and sets the property RequestHeaderConfiguration. 
        /// <para>
        /// The updated configuration for HTTP request headers that will be passed through to
        /// the runtime.
        /// </para>
        /// </summary>
        public RequestHeaderConfiguration RequestHeaderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RequestHeaderConfiguration property is set.
        /// </summary>
        internal bool IsSetRequestHeaderConfiguration() => this.RequestHeaderConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The updated IAM role ARN that provides permissions for the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
