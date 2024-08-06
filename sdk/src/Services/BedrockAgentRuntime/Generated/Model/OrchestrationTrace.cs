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
    /// Details about the orchestration step, in which the agent determines the order in which
    /// actions are executed and which knowledge bases are retrieved.
    /// </summary>
    public partial class OrchestrationTrace
    {
        private InvocationInput _invocationInput;
        private ModelInvocationInput _modelInvocationInput;
        private OrchestrationModelInvocationOutput _modelInvocationOutput;
        private Observation _observation;
        private Rationale _rationale;

        /// <summary>
        /// Gets and sets the property InvocationInput. 
        /// <para>
        /// Contains information pertaining to the action group or knowledge base that is being
        /// invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public InvocationInput InvocationInput
        {
            get { return this._invocationInput; }
            set { this._invocationInput = value; }
        }

        // Check to see if InvocationInput property is set
        internal bool IsSetInvocationInput()
        {
            return this._invocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property ModelInvocationInput. 
        /// <para>
        /// The input for the orchestration step.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>type</c> is <c>ORCHESTRATION</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>text</c> contains the prompt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>inferenceConfiguration</c>, <c>parserMode</c>, and <c>overrideLambda</c> values
        /// are set in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_PromptOverrideConfiguration.html">PromptOverrideConfiguration</a>
        /// object that was set when the agent was created or updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ModelInvocationInput ModelInvocationInput
        {
            get { return this._modelInvocationInput; }
            set { this._modelInvocationInput = value; }
        }

        // Check to see if ModelInvocationInput property is set
        internal bool IsSetModelInvocationInput()
        {
            return this._modelInvocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property ModelInvocationOutput. 
        /// <para>
        /// Contains information pertaining to the output from the foundation model that is being
        /// invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public OrchestrationModelInvocationOutput ModelInvocationOutput
        {
            get { return this._modelInvocationOutput; }
            set { this._modelInvocationOutput = value; }
        }

        // Check to see if ModelInvocationOutput property is set
        internal bool IsSetModelInvocationOutput()
        {
            return this._modelInvocationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property Observation. 
        /// <para>
        /// Details about the observation (the output of the action group Lambda or knowledge
        /// base) made by the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Observation Observation
        {
            get { return this._observation; }
            set { this._observation = value; }
        }

        // Check to see if Observation property is set
        internal bool IsSetObservation()
        {
            return this._observation != null;
        }

        /// <summary>
        /// Gets and sets the property Rationale. 
        /// <para>
        /// Details about the reasoning, based on the input, that the agent uses to justify carrying
        /// out an action group or getting information from a knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Rationale Rationale
        {
            get { return this._rationale; }
            set { this._rationale = value; }
        }

        // Check to see if Rationale property is set
        internal bool IsSetRationale()
        {
            return this._rationale != null;
        }

    }
}