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
    /// Container for the parameters to the CreateAgentRuntime operation. Creates an Amazon
    /// Bedrock AgentCore Runtime.
    /// </summary>
    public partial class CreateAgentRuntimeRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property AgentRuntimeArtifact. 
        /// <para>
        /// The artifact of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentRuntimeArtifact AgentRuntimeArtifact { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeArtifact property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeArtifact() => this.AgentRuntimeArtifact != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeName. 
        /// <para>
        /// The name of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeName property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeName() => this.AgentRuntimeName != null;

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The authorizer configuration for the AgentCore Runtime.
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
        /// The capacity provider configuration for the AgentCore Runtime. Use a capacity provider
        /// to run the AgentCore Runtime on the Instances compute type, which provisions Amazon
        /// Web Services managed compute in your account.
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
        /// The description of the AgentCore Runtime.
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
        /// Environment variables to set in the AgentCore Runtime environment.
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
        /// The filesystem configurations to mount into the AgentCore Runtime. Use filesystem
        /// configurations to provide persistent storage to your AgentCore Runtime sessions.
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
        /// The life cycle configuration for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public LifecycleConfiguration LifecycleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleConfiguration property is set.
        /// </summary>
        internal bool IsSetLifecycleConfiguration() => this.LifecycleConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the AgentCore Runtime.
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
        /// The version of the runtime platform to use for the AgentCore Runtime.
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
        /// </summary>
        public ProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolConfiguration property is set.
        /// </summary>
        internal bool IsSetProtocolConfiguration() => this.ProtocolConfiguration != null;

        /// <summary>
        /// Gets and sets the property RequestHeaderConfiguration. 
        /// <para>
        /// Configuration for HTTP request headers that will be passed through to the runtime.
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
        /// The IAM role ARN that provides permissions for the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to the agent runtime. Tags enable you to categorize
        /// your resources in different ways, for example, by purpose, owner, or environment.
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
