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
    /// Contains information about the API operation that was called from the action group
    /// and the response body that was returned.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// In the <c>returnControlInvocationResults</c> of the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_RequestSyntax">InvokeAgent
    /// request</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ApiResult
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
        /// Gets and sets the property ConfirmationState. 
        /// <para>
        /// Controls the API operations or functions to invoke based on the user confirmation.
        /// </para>
        /// </summary>
        public ConfirmationState ConfirmationState { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationState property is set.
        /// </summary>
        internal bool IsSetConfirmationState() => this.ConfirmationState != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP method for the API operation.
        /// </para>
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property HttpStatusCode. 
        /// <para>
        /// http status code from API execution response (for example: 200, 400, 500).
        /// </para>
        /// </summary>
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Checks to see if the HttpStatusCode property is set.
        /// </summary>
        internal bool IsSetHttpStatusCode() => this.HttpStatusCode.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseBody. 
        /// <para>
        /// The response body from the API operation. The key of the object is the content type
        /// (currently, only <c>TEXT</c> is supported). The response may be returned directly
        /// or from the Lambda function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ContentBody> ResponseBody { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ContentBody>() : null;

        /// <summary>
        /// Checks to see if the ResponseBody property is set.
        /// </summary>
        internal bool IsSetResponseBody() => this.ResponseBody != null && (this.ResponseBody.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseState. 
        /// <para>
        /// Controls the final response state returned to end user when API/Function execution
        /// failed. When this state is FAILURE, the request would fail with dependency failure
        /// exception. When this state is REPROMPT, the API/function response will be sent to
        /// model for re-prompt
        /// </para>
        /// </summary>
        public ResponseState ResponseState { get; set; }

        /// <summary>
        /// Checks to see if the ResponseState property is set.
        /// </summary>
        internal bool IsSetResponseState() => this.ResponseState != null;
    }
}
