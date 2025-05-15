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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private AgentFlowNodeConfiguration _agent;
        private CollectorFlowNodeConfiguration _collector;
        private ConditionFlowNodeConfiguration _condition;
        private InlineCodeFlowNodeConfiguration _inlineCode;
        private InputFlowNodeConfiguration _input;
        private IteratorFlowNodeConfiguration _iterator;
        private KnowledgeBaseFlowNodeConfiguration _knowledgeBase;
        private LambdaFunctionFlowNodeConfiguration _lambdaFunction;
        private LexFlowNodeConfiguration _lex;
        private LoopFlowNodeConfiguration _loop;
        private LoopControllerFlowNodeConfiguration _loopController;
        private LoopInputFlowNodeConfiguration _loopInput;
        private OutputFlowNodeConfiguration _output;
        private PromptFlowNodeConfiguration _prompt;
        private RetrievalFlowNodeConfiguration _retrieval;
        private StorageFlowNodeConfiguration _storage;

        /// <summary>
        /// Gets and sets the property Agent. 
        /// <para>
        /// Contains configurations for an agent node in your flow. Invokes an alias of an agent
        /// and returns the response.
        /// </para>
        /// </summary>
        public AgentFlowNodeConfiguration Agent
        {
            get { return this._agent; }
            set { this._agent = value; }
        }

        // Check to see if Agent property is set
        internal bool IsSetAgent()
        {
            return this._agent != null;
        }

        /// <summary>
        /// Gets and sets the property Collector. 
        /// <para>
        /// Contains configurations for a collector node in your flow. Collects an iteration of
        /// inputs and consolidates them into an array of outputs.
        /// </para>
        /// </summary>
        public CollectorFlowNodeConfiguration Collector
        {
            get { return this._collector; }
            set { this._collector = value; }
        }

        // Check to see if Collector property is set
        internal bool IsSetCollector()
        {
            return this._collector != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// Contains configurations for a condition node in your flow. Defines conditions that
        /// lead to different branches of the flow.
        /// </para>
        /// </summary>
        public ConditionFlowNodeConfiguration Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property InlineCode. 
        /// <para>
        /// Contains configurations for an inline code node in your flow. Inline code nodes let
        /// you write and execute code directly within your flow, enabling data transformations,
        /// custom logic, and integrations without needing an external Lambda function.
        /// </para>
        /// </summary>
        public InlineCodeFlowNodeConfiguration InlineCode
        {
            get { return this._inlineCode; }
            set { this._inlineCode = value; }
        }

        // Check to see if InlineCode property is set
        internal bool IsSetInlineCode()
        {
            return this._inlineCode != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains configurations for an input flow node in your flow. The first node in the
        /// flow. <c>inputs</c> can't be specified for this node.
        /// </para>
        /// </summary>
        public InputFlowNodeConfiguration Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

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
        public IteratorFlowNodeConfiguration Iterator
        {
            get { return this._iterator; }
            set { this._iterator = value; }
        }

        // Check to see if Iterator property is set
        internal bool IsSetIterator()
        {
            return this._iterator != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBase. 
        /// <para>
        /// Contains configurations for a knowledge base node in your flow. Queries a knowledge
        /// base and returns the retrieved results or generated response.
        /// </para>
        /// </summary>
        public KnowledgeBaseFlowNodeConfiguration KnowledgeBase
        {
            get { return this._knowledgeBase; }
            set { this._knowledgeBase = value; }
        }

        // Check to see if KnowledgeBase property is set
        internal bool IsSetKnowledgeBase()
        {
            return this._knowledgeBase != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// Contains configurations for a Lambda function node in your flow. Invokes an Lambda
        /// function.
        /// </para>
        /// </summary>
        public LambdaFunctionFlowNodeConfiguration LambdaFunction
        {
            get { return this._lambdaFunction; }
            set { this._lambdaFunction = value; }
        }

        // Check to see if LambdaFunction property is set
        internal bool IsSetLambdaFunction()
        {
            return this._lambdaFunction != null;
        }

        /// <summary>
        /// Gets and sets the property Lex. 
        /// <para>
        /// Contains configurations for a Lex node in your flow. Invokes an Amazon Lex bot to
        /// identify the intent of the input and return the intent as the output.
        /// </para>
        /// </summary>
        public LexFlowNodeConfiguration Lex
        {
            get { return this._lex; }
            set { this._lex = value; }
        }

        // Check to see if Lex property is set
        internal bool IsSetLex()
        {
            return this._lex != null;
        }

        /// <summary>
        /// Gets and sets the property Loop. 
        /// <para>
        /// Contains configurations for a DoWhile loop in your flow.
        /// </para>
        /// </summary>
        public LoopFlowNodeConfiguration Loop
        {
            get { return this._loop; }
            set { this._loop = value; }
        }

        // Check to see if Loop property is set
        internal bool IsSetLoop()
        {
            return this._loop != null;
        }

        /// <summary>
        /// Gets and sets the property LoopController. 
        /// <para>
        /// Contains controller node configurations for a DoWhile loop in your flow.
        /// </para>
        /// </summary>
        public LoopControllerFlowNodeConfiguration LoopController
        {
            get { return this._loopController; }
            set { this._loopController = value; }
        }

        // Check to see if LoopController property is set
        internal bool IsSetLoopController()
        {
            return this._loopController != null;
        }

        /// <summary>
        /// Gets and sets the property LoopInput. 
        /// <para>
        /// Contains input node configurations for a DoWhile loop in your flow.
        /// </para>
        /// </summary>
        public LoopInputFlowNodeConfiguration LoopInput
        {
            get { return this._loopInput; }
            set { this._loopInput = value; }
        }

        // Check to see if LoopInput property is set
        internal bool IsSetLoopInput()
        {
            return this._loopInput != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Contains configurations for an output flow node in your flow. The last node in the
        /// flow. <c>outputs</c> can't be specified for this node.
        /// </para>
        /// </summary>
        public OutputFlowNodeConfiguration Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// Contains configurations for a prompt node in your flow. Runs a prompt and generates
        /// the model response as the output. You can use a prompt from Prompt management or you
        /// can configure one in this node.
        /// </para>
        /// </summary>
        public PromptFlowNodeConfiguration Prompt
        {
            get { return this._prompt; }
            set { this._prompt = value; }
        }

        // Check to see if Prompt property is set
        internal bool IsSetPrompt()
        {
            return this._prompt != null;
        }

        /// <summary>
        /// Gets and sets the property Retrieval. 
        /// <para>
        /// Contains configurations for a retrieval node in your flow. Retrieves data from an
        /// Amazon S3 location and returns it as the output.
        /// </para>
        /// </summary>
        public RetrievalFlowNodeConfiguration Retrieval
        {
            get { return this._retrieval; }
            set { this._retrieval = value; }
        }

        // Check to see if Retrieval property is set
        internal bool IsSetRetrieval()
        {
            return this._retrieval != null;
        }

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// Contains configurations for a storage node in your flow. Stores an input in an Amazon
        /// S3 location.
        /// </para>
        /// </summary>
        public StorageFlowNodeConfiguration Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

    }
}