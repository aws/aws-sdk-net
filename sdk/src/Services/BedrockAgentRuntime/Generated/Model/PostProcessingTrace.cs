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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Trace Part which contains information related to post processing step
    /// </summary>
    public partial class PostProcessingTrace
    {
        private ModelInvocationInput _modelInvocationInput;
        private PostProcessingModelInvocationOutput _modelInvocationOutput;

        /// <summary>
        /// Gets and sets the property ModelInvocationInput.
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
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PostProcessingModelInvocationOutput ModelInvocationOutput
        {
            get { return this._modelInvocationOutput; }
            set { this._modelInvocationOutput = value; }
        }

        // Check to see if ModelInvocationOutput property is set
        internal bool IsSetModelInvocationOutput()
        {
            return this._modelInvocationOutput != null;
        }

    }
}