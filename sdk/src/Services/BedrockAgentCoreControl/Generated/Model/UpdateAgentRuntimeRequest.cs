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
    /// Container for the parameters to the UpdateAgentRuntime operation.
    /// Updates an existing Amazon Secure Agent.
    /// </summary>
    public partial class UpdateAgentRuntimeRequest : AmazonBedrockAgentCoreControlRequest
    {
        private AgentRuntimeArtifact _agentRuntimeArtifact;
        private string _agentRuntimeId;
        private AuthorizerConfiguration _authorizerConfiguration;
        private string _clientToken;
        private string _description;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private NetworkConfiguration _networkConfiguration;
        private ProtocolConfiguration _protocolConfiguration;
        private RequestHeaderConfiguration _requestHeaderConfiguration;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AgentRuntimeArtifact. 
        /// <para>
        /// The updated artifact of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentRuntimeArtifact AgentRuntimeArtifact
        {
            get { return this._agentRuntimeArtifact; }
            set { this._agentRuntimeArtifact = value; }
        }

        // Check to see if AgentRuntimeArtifact property is set
        internal bool IsSetAgentRuntimeArtifact()
        {
            return this._agentRuntimeArtifact != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The unique identifier of the AgentCore Runtime to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeId
        {
            get { return this._agentRuntimeId; }
            set { this._agentRuntimeId = value; }
        }

        // Check to see if AgentRuntimeId property is set
        internal bool IsSetAgentRuntimeId()
        {
            return this._agentRuntimeId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The updated authorizer configuration for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration
        {
            get { return this._authorizerConfiguration; }
            set { this._authorizerConfiguration = value; }
        }

        // Check to see if AuthorizerConfiguration property is set
        internal bool IsSetAuthorizerConfiguration()
        {
            return this._authorizerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Updated environment variables to set in the AgentCore Runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The updated network configuration for the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolConfiguration.
        /// </summary>
        public ProtocolConfiguration ProtocolConfiguration
        {
            get { return this._protocolConfiguration; }
            set { this._protocolConfiguration = value; }
        }

        // Check to see if ProtocolConfiguration property is set
        internal bool IsSetProtocolConfiguration()
        {
            return this._protocolConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RequestHeaderConfiguration. 
        /// <para>
        /// The updated configuration for HTTP request headers that will be passed through to
        /// the runtime.
        /// </para>
        /// </summary>
        public RequestHeaderConfiguration RequestHeaderConfiguration
        {
            get { return this._requestHeaderConfiguration; }
            set { this._requestHeaderConfiguration = value; }
        }

        // Check to see if RequestHeaderConfiguration property is set
        internal bool IsSetRequestHeaderConfiguration()
        {
            return this._requestHeaderConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The updated IAM role ARN that provides permissions for the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}