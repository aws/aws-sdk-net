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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains configurations for a node in your flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-nodes.html">Node
    /// types in a flow</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class FlowNodeConfiguration
    {
        /// <summary>
        /// Gets and sets the property Agent. 
        /// <para>
        /// Contains configurations for an agent node in your flow. Invokes an alias of an agent
        /// and returns the response.
        /// </para>
        /// </summary>
        public AgentFlowNodeConfiguration Agent { get; set; }

        /// <summary>
        /// Checks to see if the Agent property is set.
        /// </summary>
        internal bool IsSetAgent() => this.Agent != null;

        /// <summary>
        /// Gets and sets the property Collector. 
        /// <para>
        /// Contains configurations for a collector node in your flow. Collects an iteration of
        /// inputs and consolidates them into an array of outputs.
        /// </para>
        /// </summary>
        public CollectorFlowNodeConfiguration Collector { get; set; }

        /// <summary>
        /// Checks to see if the Collector property is set.
        /// </summary>
        internal bool IsSetCollector() => this.Collector != null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// Contains configurations for a condition node in your flow. Defines conditions that
        /// lead to different branches of the flow.
        /// </para>
        /// </summary>
        public ConditionFlowNodeConfiguration Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property InlineCode. 
        /// <para>
        /// Contains configurations for an inline code node in your flow. Inline code nodes let
        /// you write and execute code directly within your flow, enabling data transformations,
        /// custom logic, and integrations without needing an external Lambda function.
        /// </para>
        /// </summary>
        public InlineCodeFlowNodeConfiguration InlineCode { get; set; }

        /// <summary>
        /// Checks to see if the InlineCode property is set.
        /// </summary>
        internal bool IsSetInlineCode() => this.InlineCode != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains configurations for an input flow node in your flow. The first node in the
        /// flow. <c>inputs</c> can't be specified for this node.
        /// </para>
        /// </summary>
        public InputFlowNodeConfiguration Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property Iterator. 
        /// <para>
        /// Contains configurations for an iterator node in your flow. Takes an input that is
        /// an array and iteratively sends each item of the array as an output to the following
        /// node. The size of the array is also returned in the output.
        /// </para>
        ///  
        /// <para>
        /// The output flow node at the end of the flow iteration will return a response for each
        /// member of the array. To return only one response, you can include a collector node
        /// downstream from the iterator node.
        /// </para>
        /// </summary>
        public IteratorFlowNodeConfiguration Iterator { get; set; }

        /// <summary>
        /// Checks to see if the Iterator property is set.
        /// </summary>
        internal bool IsSetIterator() => this.Iterator != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBase. 
        /// <para>
        /// Contains configurations for a knowledge base node in your flow. Queries a knowledge
        /// base and returns the retrieved results or generated response.
        /// </para>
        /// </summary>
        public KnowledgeBaseFlowNodeConfiguration KnowledgeBase { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBase property is set.
        /// </summary>
        internal bool IsSetKnowledgeBase() => this.KnowledgeBase != null;

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// Contains configurations for a Lambda function node in your flow. Invokes an Lambda
        /// function.
        /// </para>
        /// </summary>
        public LambdaFunctionFlowNodeConfiguration LambdaFunction { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunction property is set.
        /// </summary>
        internal bool IsSetLambdaFunction() => this.LambdaFunction != null;

        /// <summary>
        /// Gets and sets the property Lex. 
        /// <para>
        /// Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to
        /// identify the intent of the input and return the intent as the output.
        /// </para>
        /// </summary>
        public LexFlowNodeConfiguration Lex { get; set; }

        /// <summary>
        /// Checks to see if the Lex property is set.
        /// </summary>
        internal bool IsSetLex() => this.Lex != null;

        /// <summary>
        /// Gets and sets the property Loop. 
        /// <para>
        /// Contains configurations for a DoWhile loop in your flow.
        /// </para>
        /// </summary>
        public LoopFlowNodeConfiguration Loop { get; set; }

        /// <summary>
        /// Checks to see if the Loop property is set.
        /// </summary>
        internal bool IsSetLoop() => this.Loop != null;

        /// <summary>
        /// Gets and sets the property LoopController. 
        /// <para>
        /// Contains controller node configurations for a DoWhile loop in your flow.
        /// </para>
        /// </summary>
        public LoopControllerFlowNodeConfiguration LoopController { get; set; }

        /// <summary>
        /// Checks to see if the LoopController property is set.
        /// </summary>
        internal bool IsSetLoopController() => this.LoopController != null;

        /// <summary>
        /// Gets and sets the property LoopInput. 
        /// <para>
        /// Contains input node configurations for a DoWhile loop in your flow.
        /// </para>
        /// </summary>
        public LoopInputFlowNodeConfiguration LoopInput { get; set; }

        /// <summary>
        /// Checks to see if the LoopInput property is set.
        /// </summary>
        internal bool IsSetLoopInput() => this.LoopInput != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Contains configurations for an output flow node in your flow. The last node in the
        /// flow. <c>outputs</c> can't be specified for this node.
        /// </para>
        /// </summary>
        public OutputFlowNodeConfiguration Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// Contains configurations for a prompt node in your flow. Runs a prompt and generates
        /// the model response as the output. You can use a prompt from Prompt management or you
        /// can configure one in this node.
        /// </para>
        /// </summary>
        public PromptFlowNodeConfiguration Prompt { get; set; }

        /// <summary>
        /// Checks to see if the Prompt property is set.
        /// </summary>
        internal bool IsSetPrompt() => this.Prompt != null;

        /// <summary>
        /// Gets and sets the property Retrieval. 
        /// <para>
        /// Contains configurations for a retrieval node in your flow. Retrieves data from an
        /// Amazon S3 location and returns it as the output.
        /// </para>
        /// </summary>
        public RetrievalFlowNodeConfiguration Retrieval { get; set; }

        /// <summary>
        /// Checks to see if the Retrieval property is set.
        /// </summary>
        internal bool IsSetRetrieval() => this.Retrieval != null;

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// Contains configurations for a storage node in your flow. Stores an input in an Amazon
        /// S3 location.
        /// </para>
        /// </summary>
        public StorageFlowNodeConfiguration Storage { get; set; }

        /// <summary>
        /// Checks to see if the Storage property is set.
        /// </summary>
        internal bool IsSetStorage() => this.Storage != null;
    }
}
