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
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information to return from the action group that the agent has predicted
    /// to invoke.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_ResponseSyntax">InvokeAgent
    /// response</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ReturnControlPayload
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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