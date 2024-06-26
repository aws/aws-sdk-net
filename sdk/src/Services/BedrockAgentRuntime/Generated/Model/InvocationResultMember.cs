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
    /// A result from the invocation of an action. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-returncontrol.html">Return
    /// control to the agent developer</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-session-state.html">Control
    /// session context</a>.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_RequestSyntax">InvokeAgent
    /// request</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InvocationResultMember
    {
        private ApiResult _apiResult;
        private FunctionResult _functionResult;

        /// <summary>
        /// Gets and sets the property ApiResult. 
        /// <para>
        /// The result from the API response from the action group invocation.
        /// </para>
        /// </summary>
        public ApiResult ApiResult
        {
            get { return this._apiResult; }
            set { this._apiResult = value; }
        }

        // Check to see if ApiResult property is set
        internal bool IsSetApiResult()
        {
            return this._apiResult != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionResult. 
        /// <para>
        /// The result from the function from the action group invocation.
        /// </para>
        /// </summary>
        public FunctionResult FunctionResult
        {
            get { return this._functionResult; }
            set { this._functionResult = value; }
        }

        // Check to see if FunctionResult property is set
        internal bool IsSetFunctionResult()
        {
            return this._functionResult != null;
        }

    }
}