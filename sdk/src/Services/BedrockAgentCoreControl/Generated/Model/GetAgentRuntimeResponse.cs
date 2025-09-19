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
    /// This is the response object from the GetAgentRuntime operation.
    /// </summary>
    public partial class GetAgentRuntimeResponse : AmazonWebServiceResponse
    {
        private string _agentRuntimeArn;
        private AgentRuntimeArtifact _agentRuntimeArtifact;
        private string _agentRuntimeId;
        private string _agentRuntimeName;
        private string _agentRuntimeVersion;
        private AuthorizerConfiguration _authorizerConfiguration;
        private DateTime? _createdAt;
        private string _description;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _lastUpdatedAt;
        private NetworkConfiguration _networkConfiguration;
        private ProtocolConfiguration _protocolConfiguration;
        private RequestHeaderConfiguration _requestHeaderConfiguration;
        private string _roleArn;
        private AgentRuntimeStatus _status;
        private WorkloadIdentityDetails _workloadIdentityDetails;

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeArn
        {
            get { return this._agentRuntimeArn; }
            set { this._agentRuntimeArn = value; }
        }

        // Check to see if AgentRuntimeArn property is set
        internal bool IsSetAgentRuntimeArn()
        {
            return this._agentRuntimeArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeArtifact. 
        /// <para>
        /// The artifact of the AgentCore Runtime.
        /// </para>
        /// </summary>
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
        /// The unique identifier of the AgentCore Runtime.
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
        /// Gets and sets the property AgentRuntimeName. 
        /// <para>
        /// The name of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeName
        {
            get { return this._agentRuntimeName; }
            set { this._agentRuntimeName = value; }
        }

        // Check to see if AgentRuntimeName property is set
        internal bool IsSetAgentRuntimeName()
        {
            return this._agentRuntimeName != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeVersion. 
        /// <para>
        /// The version of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string AgentRuntimeVersion
        {
            get { return this._agentRuntimeVersion; }
            set { this._agentRuntimeVersion = value; }
        }

        // Check to see if AgentRuntimeVersion property is set
        internal bool IsSetAgentRuntimeVersion()
        {
            return this._agentRuntimeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The authorizer configuration for the AgentCore Runtime.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the AgentCore Runtime was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AgentCore Runtime.
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
        /// Environment variables set in the AgentCore Runtime environment.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the AgentCore Runtime was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the AgentCore Runtime.
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
        /// Configuration for HTTP request headers that will be passed through to the runtime.
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
        /// The IAM role ARN that provides permissions for the AgentCore Runtime.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentRuntimeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentityDetails. 
        /// <para>
        /// The workload identity details for the AgentCore Runtime.
        /// </para>
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails
        {
            get { return this._workloadIdentityDetails; }
            set { this._workloadIdentityDetails = value; }
        }

        // Check to see if WorkloadIdentityDetails property is set
        internal bool IsSetWorkloadIdentityDetails()
        {
            return this._workloadIdentityDetails != null;
        }

    }
}