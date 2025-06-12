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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about the API operation that the agent predicts should be called.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// In the <c>returnControl</c> field of the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_ResponseSyntax">InvokeAgent
    /// response</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ApiInvocationInput
    {
        private string _actionGroup;
        private ActionInvocationType _actionInvocationType;
        private string _agentId;
        private string _apiPath;
        private string _collaboratorName;
        private string _httpMethod;
        private List<ApiParameter> _parameters = AWSConfigs.InitializeCollections ? new List<ApiParameter>() : null;
        private ApiRequestBody _requestBody;

        /// <summary>
        /// Gets and sets the property ActionGroup. 
        /// <para>
        /// The action group that the API operation belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionGroup
        {
            get { return this._actionGroup; }
            set { this._actionGroup = value; }
        }

        // Check to see if ActionGroup property is set
        internal bool IsSetActionGroup()
        {
            return this._actionGroup != null;
        }

        /// <summary>
        /// Gets and sets the property ActionInvocationType. 
        /// <para>
        /// Contains information about the API operation to invoke.
        /// </para>
        /// </summary>
        public ActionInvocationType ActionInvocationType
        {
            get { return this._actionInvocationType; }
            set { this._actionInvocationType = value; }
        }

        // Check to see if ActionInvocationType property is set
        internal bool IsSetActionInvocationType()
        {
            return this._actionInvocationType != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The agent's ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ApiPath. 
        /// <para>
        /// The path to the API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ApiPath
        {
            get { return this._apiPath; }
            set { this._apiPath = value; }
        }

        // Check to see if ApiPath property is set
        internal bool IsSetApiPath()
        {
            return this._apiPath != null;
        }

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        /// The agent collaborator's name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CollaboratorName
        {
            get { return this._collaboratorName; }
            set { this._collaboratorName = value; }
        }

        // Check to see if CollaboratorName property is set
        internal bool IsSetCollaboratorName()
        {
            return this._collaboratorName != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP method of the API operation.
        /// </para>
        /// </summary>
        public string HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters to provide for the API request, as the agent elicited from the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApiParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// The request body to provide for the API request, as the agent elicited from the user.
        /// </para>
        /// </summary>
        public ApiRequestBody RequestBody
        {
            get { return this._requestBody; }
            set { this._requestBody = value; }
        }

        // Check to see if RequestBody property is set
        internal bool IsSetRequestBody()
        {
            return this._requestBody != null;
        }

    }
}