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
    /// Container for the parameters to the InvokeFlow operation. Invokes an alias of a flow
    /// to run the inputs that you specify and return the output of each node as a stream.
    /// If there's an error, the error is returned. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-test.html">Test
    /// a flow in Amazon Bedrock</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>. <note> <para> The CLI doesn't support streaming operations
    /// in Amazon Bedrock, including <c>InvokeFlow</c>. </para> </note>
    /// </summary>
    public partial class InvokeFlowRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property EnableTrace. 
        /// <para>
        /// Specifies whether to return the trace for the flow or not. Traces track inputs and
        /// outputs for nodes in the flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-trace.html">Track
        /// each step in your prompt flow by viewing its trace in Amazon Bedrock</a>.
        /// </para>
        /// </summary>
        public bool? EnableTrace { get; set; }

        /// <summary>
        /// Checks to see if the EnableTrace property is set.
        /// </summary>
        internal bool IsSetEnableTrace() => this.EnableTrace.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier for the current flow execution. If you don't provide a value,
        /// Amazon Bedrock creates the identifier for you. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property FlowAliasIdentifier. 
        /// <para>
        /// The unique identifier of the flow alias.
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
        /// Gets and sets the property Inputs. 
        /// <para>
        /// A list of objects, each containing information about an input into the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<FlowInput> Inputs { get; set; } = AWSConfigs.InitializeCollections ? new List<FlowInput>() : null;

        /// <summary>
        /// Checks to see if the Inputs property is set.
        /// </summary>
        internal bool IsSetInputs() => this.Inputs != null && (this.Inputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModelPerformanceConfiguration. 
        /// <para>
        /// Model performance settings for the request.
        /// </para>
        /// </summary>
        public ModelPerformanceConfiguration ModelPerformanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelPerformanceConfiguration property is set.
        /// </summary>
        internal bool IsSetModelPerformanceConfiguration() => this.ModelPerformanceConfiguration != null;
    }
}
