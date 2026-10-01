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
        /// <summary>
        /// Gets and sets the property ActionGroup. 
        /// <para>
        /// The action group that the API operation belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActionGroup { get; set; }

        /// <summary>
        /// Checks to see if the ActionGroup property is set.
        /// </summary>
        internal bool IsSetActionGroup() => this.ActionGroup != null;

        /// <summary>
        /// Gets and sets the property ActionInvocationType. 
        /// <para>
        /// Contains information about the API operation to invoke.
        /// </para>
        /// </summary>
        public ActionInvocationType ActionInvocationType { get; set; }

        /// <summary>
        /// Checks to see if the ActionInvocationType property is set.
        /// </summary>
        internal bool IsSetActionInvocationType() => this.ActionInvocationType != null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The agent's ID.
        /// </para>
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property ApiPath. 
        /// <para>
        /// The path to the API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ApiPath { get; set; }

        /// <summary>
        /// Checks to see if the ApiPath property is set.
        /// </summary>
        internal bool IsSetApiPath() => this.ApiPath != null;

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        /// The agent collaborator's name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CollaboratorName { get; set; }

        /// <summary>
        /// Checks to see if the CollaboratorName property is set.
        /// </summary>
        internal bool IsSetCollaboratorName() => this.CollaboratorName != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP method of the API operation.
        /// </para>
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters to provide for the API request, as the agent elicited from the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApiParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ApiParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// The request body to provide for the API request, as the agent elicited from the user.
        /// </para>
        /// </summary>
        public ApiRequestBody RequestBody { get; set; }

        /// <summary>
        /// Checks to see if the RequestBody property is set.
        /// </summary>
        internal bool IsSetRequestBody() => this.RequestBody != null;
    }
}
