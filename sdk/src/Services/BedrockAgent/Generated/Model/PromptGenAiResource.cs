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
    /// Contains specifications for a generative AI resource with which to use the prompt.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-create.html">Create
    /// a prompt using Prompt management</a>.
    /// </summary>
    public partial class PromptGenAiResource
    {
        private PromptAgentResource _agent;

        /// <summary>
        /// Gets and sets the property Agent. 
        /// <para>
        /// Specifies an Amazon Bedrock agent with which to use the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PromptAgentResource Agent
        {
            get { return this._agent; }
            set { this._agent = value; }
        }

        // Check to see if Agent property is set
        internal bool IsSetAgent()
        {
            return this._agent != null;
        }

    }
}