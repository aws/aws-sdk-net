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
    /// Container for the parameters to the StartFlowExecution operation. Starts an execution
    /// of an Amazon Bedrock flow. Unlike flows that run until completion or time out after
    /// five minutes, flow executions let you run flows asynchronously for longer durations.
    /// Flow executions also yield control so that your application can perform other tasks.
    /// <para> This operation returns an Amazon Resource Name (ARN) that you can use to track
    /// and manage your flow execution. </para> <note> <para> Flow executions is in preview
    /// release for Amazon Bedrock and is subject to change. </para> </note>
    /// </summary>
    public partial class StartFlowExecutionRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property FlowAliasIdentifier. 
        /// <para>
        /// The unique identifier of the flow alias to use for the flow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string FlowAliasIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowAliasIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowAliasIdentifier() => this.FlowAliasIdentifier != null;

        /// <summary>
        /// Gets and sets the property FlowExecutionName. 
        /// <para>
        /// The unique name for the flow execution. If you don't provide one, a system-generated
        /// name is used.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 36)]
        public string FlowExecutionName { get; set; }

        /// <summary>
        /// Checks to see if the FlowExecutionName property is set.
        /// </summary>
        internal bool IsSetFlowExecutionName() => this.FlowExecutionName != null;

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow to execute.
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
        /// The input data required for the flow execution. This must match the input schema defined
        /// in the flow.
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
        /// The performance settings for the foundation model used in the flow execution.
        /// </para>
        /// </summary>
        public ModelPerformanceConfiguration ModelPerformanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelPerformanceConfiguration property is set.
        /// </summary>
        internal bool IsSetModelPerformanceConfiguration() => this.ModelPerformanceConfiguration != null;
    }
}
