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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// An event in which the prompt was optimized.
    /// </summary>
    public partial class OptimizedPromptEvent
        : IEventStreamEvent
    {
        private OptimizedPrompt _optimizedPrompt;

        /// <summary>
        /// Gets and sets the property OptimizedPrompt. 
        /// <para>
        /// Contains information about the optimized prompt.
        /// </para>
        /// </summary>
        public OptimizedPrompt OptimizedPrompt
        {
            get { return this._optimizedPrompt; }
            set { this._optimizedPrompt = value; }
        }

        // Check to see if OptimizedPrompt property is set
        internal bool IsSetOptimizedPrompt()
        {
            return this._optimizedPrompt != null;
        }

    }
}