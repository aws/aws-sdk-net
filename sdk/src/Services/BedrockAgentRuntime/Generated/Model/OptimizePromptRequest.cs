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
    /// Container for the parameters to the OptimizePrompt operation.
    /// Optimizes a prompt for the task that you specify. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-optimize.html">Optimize
    /// a prompt</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class OptimizePromptRequest : AmazonBedrockAgentRuntimeRequest
    {
        private InputPrompt _input;
        private string _targetModelId;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains the prompt to optimize.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputPrompt Input
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
        /// Gets and sets the property TargetModelId. 
        /// <para>
        /// The unique identifier of the model that you want to optimize the prompt for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TargetModelId
        {
            get { return this._targetModelId; }
            set { this._targetModelId = value; }
        }

        // Check to see if TargetModelId property is set
        internal bool IsSetTargetModelId()
        {
            return this._targetModelId != null;
        }

    }
}