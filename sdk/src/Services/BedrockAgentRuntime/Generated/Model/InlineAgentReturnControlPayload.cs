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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information to return from the action group that the agent has predicted
    /// to invoke.
    /// 
    ///  
    /// <para>
    /// This data type is used in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_ResponseSyntax">InvokeAgent
    /// response</a> API operation.
    /// </para>
    /// </summary>
    public partial class InlineAgentReturnControlPayload
        : IEventStreamEvent
    {
        private string _invocationId;
        private List<InvocationInputMember> _invocationInputs = AWSConfigs.InitializeCollections ? new List<InvocationInputMember>() : null;

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The identifier of the action group invocation. 
        /// </para>
        /// </summary>
        public string InvocationId
        {
            get { return this._invocationId; }
            set { this._invocationId = value; }
        }

        // Check to see if InvocationId property is set
        internal bool IsSetInvocationId()
        {
            return this._invocationId != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationInputs. 
        /// <para>
        /// A list of objects that contain information about the parameters and inputs that need
        /// to be sent into the API operation or function, based on what the agent determines
        /// from its session with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<InvocationInputMember> InvocationInputs
        {
            get { return this._invocationInputs; }
            set { this._invocationInputs = value; }
        }

        // Check to see if InvocationInputs property is set
        internal bool IsSetInvocationInputs()
        {
            return this._invocationInputs != null && (this._invocationInputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}