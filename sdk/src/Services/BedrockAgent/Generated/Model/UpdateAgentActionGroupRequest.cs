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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAgentActionGroup operation.
    /// Updates the configuration for an action group for an agent.
    /// </summary>
    public partial class UpdateAgentActionGroupRequest : AmazonBedrockAgentRequest
    {
        private ActionGroupExecutor _actionGroupExecutor;
        private string _actionGroupId;
        private string _actionGroupName;
        private ActionGroupState _actionGroupState;
        private string _agentId;
        private string _agentVersion;
        private APISchema _apiSchema;
        private string _description;
        private FunctionSchema _functionSchema;
        private ActionGroupSignature _parentActionGroupSignature;
        private Dictionary<string, string> _parentActionGroupSignatureParams = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActionGroupExecutor. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function containing the business logic
        /// that is carried out upon invoking the action.
        /// </para>
        /// </summary>
        public ActionGroupExecutor ActionGroupExecutor
        {
            get { return this._actionGroupExecutor; }
            set { this._actionGroupExecutor = value; }
        }

        // Check to see if ActionGroupExecutor property is set
        internal bool IsSetActionGroupExecutor()
        {
            return this._actionGroupExecutor != null;
        }

        /// <summary>
        /// Gets and sets the property ActionGroupId. 
        /// <para>
        /// The unique identifier of the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionGroupId
        {
            get { return this._actionGroupId; }
            set { this._actionGroupId = value; }
        }

        // Check to see if ActionGroupId property is set
        internal bool IsSetActionGroupId()
        {
            return this._actionGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionGroupName. 
        /// <para>
        /// Specifies a new name for the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionGroupName
        {
            get { return this._actionGroupName; }
            set { this._actionGroupName = value; }
        }

        // Check to see if ActionGroupName property is set
        internal bool IsSetActionGroupName()
        {
            return this._actionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ActionGroupState. 
        /// <para>
        /// Specifies whether the action group is available for the agent to invoke or not when
        /// sending an <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html">InvokeAgent</a>
        /// request.
        /// </para>
        /// </summary>
        public ActionGroupState ActionGroupState
        {
            get { return this._actionGroupState; }
            set { this._actionGroupState = value; }
        }

        // Check to see if ActionGroupState property is set
        internal bool IsSetActionGroupState()
        {
            return this._actionGroupState != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent for which to update the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The unique identifier of the agent version for which to update the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ApiSchema. 
        /// <para>
        /// Contains either details about the S3 object containing the OpenAPI schema for the
        /// action group or the JSON or YAML-formatted payload defining the schema. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-api-schema.html">Action
        /// group OpenAPI schemas</a>.
        /// </para>
        /// </summary>
        public APISchema ApiSchema
        {
            get { return this._apiSchema; }
            set { this._apiSchema = value; }
        }

        // Check to see if ApiSchema property is set
        internal bool IsSetApiSchema()
        {
            return this._apiSchema != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies a new name for the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property FunctionSchema. 
        /// <para>
        /// Contains details about the function schema for the action group or the JSON or YAML-formatted
        /// payload defining the schema.
        /// </para>
        /// </summary>
        public FunctionSchema FunctionSchema
        {
            get { return this._functionSchema; }
            set { this._functionSchema = value; }
        }

        // Check to see if FunctionSchema property is set
        internal bool IsSetFunctionSchema()
        {
            return this._functionSchema != null;
        }

        /// <summary>
        /// Gets and sets the property ParentActionGroupSignature. 
        /// <para>
        /// Update the built-in or computer use action for this action group. If you specify a
        /// value, you must leave the <c>description</c>, <c>apiSchema</c>, and <c>actionGroupExecutor</c>
        /// fields empty for this action group. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To allow your agent to request the user for additional information when trying to
        /// complete a task, set this field to <c>AMAZON.UserInput</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To allow your agent to generate, run, and troubleshoot code when trying to complete
        /// a task, set this field to <c>AMAZON.CodeInterpreter</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To allow your agent to use an Anthropic computer use tool, specify one of the following
        /// values. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  Computer use is a new Anthropic Claude model capability (in beta) available with
        /// Anthropic Claude 3.7 Sonnet and Claude 3.5 Sonnet v2 only. When operating computer
        /// use functionality, we recommend taking additional security precautions, such as executing
        /// computer actions in virtual environments with restricted data access and limited internet
        /// connectivity. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agent-computer-use.html">Configure
        /// an Amazon Bedrock Agent to complete tasks with computer use tools</a>. 
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <c>ANTHROPIC.Computer</c> - Gives the agent permission to use the mouse and keyboard
        /// and take screenshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANTHROPIC.TextEditor</c> - Gives the agent permission to view, create and edit
        /// files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANTHROPIC.Bash</c> - Gives the agent permission to run commands in a bash shell.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// During orchestration, if your agent determines that it needs to invoke an API in an
        /// action group, but doesn't have enough information to complete the API request, it
        /// will invoke this action group instead and return an <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Observation.html">Observation</a>
        /// reprompting the user for more information.
        /// </para>
        /// </summary>
        public ActionGroupSignature ParentActionGroupSignature
        {
            get { return this._parentActionGroupSignature; }
            set { this._parentActionGroupSignature = value; }
        }

        // Check to see if ParentActionGroupSignature property is set
        internal bool IsSetParentActionGroupSignature()
        {
            return this._parentActionGroupSignature != null;
        }

        /// <summary>
        /// Gets and sets the property ParentActionGroupSignatureParams. 
        /// <para>
        /// The configuration settings for a computer use action.
        /// </para>
        ///  <important> 
        /// <para>
        ///  Computer use is a new Anthropic Claude model capability (in beta) available with
        /// Claude 3.7 and Claude 3.5 Sonnet v2 only. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agent-computer-use.html">Configure
        /// an Amazon Bedrock Agent to complete tasks with computer use tools</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        public Dictionary<string, string> ParentActionGroupSignatureParams
        {
            get { return this._parentActionGroupSignatureParams; }
            set { this._parentActionGroupSignatureParams = value; }
        }

        // Check to see if ParentActionGroupSignatureParams property is set
        internal bool IsSetParentActionGroupSignatureParams()
        {
            return this._parentActionGroupSignatureParams != null && (this._parentActionGroupSignatureParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}