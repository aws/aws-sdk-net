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
    /// Trace contains intermidate response for customer
    /// </summary>
    public partial class Trace
    {
        private FailureTrace _failureTrace;
        private OrchestrationTrace _orchestrationTrace;
        private PostProcessingTrace _postProcessingTrace;
        private PreProcessingTrace _preProcessingTrace;

        /// <summary>
        /// Gets and sets the property FailureTrace.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FailureTrace FailureTrace
        {
            get { return this._failureTrace; }
            set { this._failureTrace = value; }
        }

        // Check to see if FailureTrace property is set
        internal bool IsSetFailureTrace()
        {
            return this._failureTrace != null;
        }

        /// <summary>
        /// Gets and sets the property OrchestrationTrace.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public OrchestrationTrace OrchestrationTrace
        {
            get { return this._orchestrationTrace; }
            set { this._orchestrationTrace = value; }
        }

        // Check to see if OrchestrationTrace property is set
        internal bool IsSetOrchestrationTrace()
        {
            return this._orchestrationTrace != null;
        }

        /// <summary>
        /// Gets and sets the property PostProcessingTrace.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PostProcessingTrace PostProcessingTrace
        {
            get { return this._postProcessingTrace; }
            set { this._postProcessingTrace = value; }
        }

        // Check to see if PostProcessingTrace property is set
        internal bool IsSetPostProcessingTrace()
        {
            return this._postProcessingTrace != null;
        }

        /// <summary>
        /// Gets and sets the property PreProcessingTrace.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PreProcessingTrace PreProcessingTrace
        {
            get { return this._preProcessingTrace; }
            set { this._preProcessingTrace = value; }
        }

        // Check to see if PreProcessingTrace property is set
        internal bool IsSetPreProcessingTrace()
        {
            return this._preProcessingTrace != null;
        }

    }
}