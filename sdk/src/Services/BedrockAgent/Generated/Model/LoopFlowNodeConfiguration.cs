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
    /// Contains configurations for the nodes of a DoWhile loop in your flow.
    /// 
    ///  
    /// <para>
    /// A DoWhile loop is made up of the following nodes:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Loop</c> - The container node that holds the loop's flow definition. This node
    /// encompasses the entire loop structure.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LoopInput</c> - The entry point node for the loop. This node receives inputs from
    /// nodes outside the loop and from previous loop iterations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Body nodes - The processing nodes that execute within each loop iteration. These can
    /// be nodes for handling data in your flow, such as a prompt or Lambda function nodes.
    /// Some node types aren't supported inside a DoWhile loop body. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_LoopIncompatibleNodeTypeFlowValidationDetails.html">LoopIncompatibleNodeTypeFlowValidationDetails</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LoopController</c> - The node that evaluates whether the loop should continue
    /// or exit based on a condition.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// These nodes work together to create a loop that runs at least once and continues until
    /// a specified condition is met or a maximum number of iterations is reached.
    /// </para>
    /// </summary>
    public partial class LoopFlowNodeConfiguration
    {
        private FlowDefinition _definition;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of the DoWhile loop nodes and connections between nodes in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public FlowDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

    }
}