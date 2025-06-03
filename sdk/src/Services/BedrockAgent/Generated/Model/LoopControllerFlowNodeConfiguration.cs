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
    /// Contains configurations for the controller node of a DoWhile loop in the flow.
    /// </summary>
    public partial class LoopControllerFlowNodeConfiguration
    {
        private FlowCondition _continueCondition;
        private int? _maxIterations;

        /// <summary>
        /// Gets and sets the property ContinueCondition. 
        /// <para>
        /// Specifies the condition that determines when the flow exits the DoWhile loop. The
        /// loop executes until this condition evaluates to true.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowCondition ContinueCondition
        {
            get { return this._continueCondition; }
            set { this._continueCondition = value; }
        }

        // Check to see if ContinueCondition property is set
        internal bool IsSetContinueCondition()
        {
            return this._continueCondition != null;
        }

        /// <summary>
        /// Gets and sets the property MaxIterations. 
        /// <para>
        /// Specifies the maximum number of times the DoWhile loop can iterate before the flow
        /// exits the loop.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxIterations
        {
            get { return this._maxIterations; }
            set { this._maxIterations = value; }
        }

        // Check to see if MaxIterations property is set
        internal bool IsSetMaxIterations()
        {
            return this._maxIterations.HasValue; 
        }

    }
}