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
    /// Container for the parameters to the ListFlowExecutionEvents operation. Lists events
    /// that occurred during a flow execution. Events provide detailed information about the
    /// execution progress, including node inputs and outputs, flow inputs and outputs, condition
    /// results, and failure events. <note> <para> Flow executions is in preview release for
    /// Amazon Bedrock and is subject to change. </para> </note>
    /// </summary>
    public partial class ListFlowExecutionEventsRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of events to retrieve. Specify <c>Node</c> for node-level events or <c>Flow</c>
        /// for flow-level events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowExecutionEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property ExecutionIdentifier. 
        /// <para>
        /// The unique identifier of the flow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ExecutionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionIdentifier property is set.
        /// </summary>
        internal bool IsSetExecutionIdentifier() => this.ExecutionIdentifier != null;

        /// <summary>
        /// Gets and sets the property FlowAliasIdentifier. 
        /// <para>
        /// The unique identifier of the flow alias used for the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string FlowAliasIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowAliasIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowAliasIdentifier() => this.FlowAliasIdentifier != null;

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string FlowIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowIdentifier() => this.FlowIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of events to return in a single response. If more events exist
        /// than the specified maxResults value, a token is included in the response so that the
        /// remaining results can be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to retrieve the next set of results. This value is returned in the response
        /// if more results are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
