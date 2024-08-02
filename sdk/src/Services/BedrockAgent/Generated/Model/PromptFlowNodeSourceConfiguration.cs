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
    /// Contains configurations for a prompt and whether it is from Prompt management or defined
    /// inline.
    /// </summary>
    public partial class PromptFlowNodeSourceConfiguration
    {
        private PromptFlowNodeInlineConfiguration _inline;
        private PromptFlowNodeResourceConfiguration _resource;

        /// <summary>
        /// Gets and sets the property Inline. 
        /// <para>
        /// Contains configurations for a prompt that is defined inline
        /// </para>
        /// </summary>
        public PromptFlowNodeInlineConfiguration Inline
        {
            get { return this._inline; }
            set { this._inline = value; }
        }

        // Check to see if Inline property is set
        internal bool IsSetInline()
        {
            return this._inline != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// Contains configurations for a prompt from Prompt management.
        /// </para>
        /// </summary>
        public PromptFlowNodeResourceConfiguration Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}