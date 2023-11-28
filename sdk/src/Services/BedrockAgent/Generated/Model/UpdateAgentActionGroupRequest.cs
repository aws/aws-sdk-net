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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAgentActionGroup operation.
    /// Updates an existing Action Group for Amazon Bedrock Agent
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
        private ActionGroupSignature _parentActionGroupSignature;

        /// <summary>
        /// Gets and sets the property ActionGroupExecutor.
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
        /// Id generated at the server side when an Action Group is created under Agent
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
        /// Id generated at the server side when an Agent is created
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
        /// Draft Version of the Agent.
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
        /// Gets and sets the property ParentActionGroupSignature.
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

    }
}