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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The specification of which trace or span IDs to evaluate within the provided input
    /// data. Allows precise targeting of evaluation at different levels: tool calls, traces,
    /// or sessions.
    /// </summary>
    public partial class EvaluationTarget
    {
        private List<string> _spanIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _traceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SpanIds. 
        /// <para>
        ///  The list of specific span IDs to evaluate within the provided traces. Used to target
        /// evaluation at individual tool calls or specific operations within the agent's execution
        /// flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> SpanIds
        {
            get { return this._spanIds; }
            set { this._spanIds = value; }
        }

        // Check to see if SpanIds property is set
        internal bool IsSetSpanIds()
        {
            return this._spanIds != null && (this._spanIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TraceIds. 
        /// <para>
        ///  The list of trace IDs to evaluate, representing complete request-response interactions.
        /// Used to evaluate entire conversation turns or specific agent interactions within a
        /// session. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> TraceIds
        {
            get { return this._traceIds; }
            set { this._traceIds = value; }
        }

        // Check to see if TraceIds property is set
        internal bool IsSetTraceIds()
        {
            return this._traceIds != null && (this._traceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}