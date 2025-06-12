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
    /// Contains configurations to use a prompt in a conversational format. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-create.html">Create
    /// a prompt using Prompt management</a>.
    /// </summary>
    public partial class ChatPromptTemplateConfiguration
    {
        private List<PromptInputVariable> _inputVariables = AWSConfigs.InitializeCollections ? new List<PromptInputVariable>() : null;
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;
        private List<SystemContentBlock> _system = AWSConfigs.InitializeCollections ? new List<SystemContentBlock>() : null;
        private ToolConfiguration _toolConfiguration;

        /// <summary>
        /// Gets and sets the property InputVariables. 
        /// <para>
        /// An array of the variables in the prompt template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public List<PromptInputVariable> InputVariables
        {
            get { return this._inputVariables; }
            set { this._inputVariables = value; }
        }

        // Check to see if InputVariables property is set
        internal bool IsSetInputVariables()
        {
            return this._inputVariables != null && (this._inputVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Contains messages in the chat for the prompt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// Contains system prompts to provide context to the model or to describe how it should
        /// behave.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SystemContentBlock> System
        {
            get { return this._system; }
            set { this._system = value; }
        }

        // Check to see if System property is set
        internal bool IsSetSystem()
        {
            return this._system != null && (this._system.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToolConfiguration. 
        /// <para>
        /// Configuration information for the tools that the model can use when generating a response.
        /// </para>
        /// </summary>
        public ToolConfiguration ToolConfiguration
        {
            get { return this._toolConfiguration; }
            set { this._toolConfiguration = value; }
        }

        // Check to see if ToolConfiguration property is set
        internal bool IsSetToolConfiguration()
        {
            return this._toolConfiguration != null;
        }

    }
}