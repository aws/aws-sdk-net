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
    /// Contains details about the API operation or function that the agent predicts should
    /// be called. 
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
    public partial class InvocationInputMember
    {
        private ApiInvocationInput _apiInvocationInput;
        private FunctionInvocationInput _functionInvocationInput;

        /// <summary>
        /// Gets and sets the property ApiInvocationInput. 
        /// <para>
        /// Contains information about the API operation that the agent predicts should be called.
        /// </para>
        /// </summary>
        public ApiInvocationInput ApiInvocationInput
        {
            get { return this._apiInvocationInput; }
            set { this._apiInvocationInput = value; }
        }

        // Check to see if ApiInvocationInput property is set
        internal bool IsSetApiInvocationInput()
        {
            return this._apiInvocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionInvocationInput. 
        /// <para>
        /// Contains information about the function that the agent predicts should be called.
        /// </para>
        /// </summary>
        public FunctionInvocationInput FunctionInvocationInput
        {
            get { return this._functionInvocationInput; }
            set { this._functionInvocationInput = value; }
        }

        // Check to see if FunctionInvocationInput property is set
        internal bool IsSetFunctionInvocationInput()
        {
            return this._functionInvocationInput != null;
        }

    }
}