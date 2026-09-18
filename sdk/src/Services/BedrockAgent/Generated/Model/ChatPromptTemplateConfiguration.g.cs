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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property InputVariables. 
        /// <para>
        /// An array of the variables in the prompt template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 20)]
        public List<PromptInputVariable> InputVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<PromptInputVariable>() : null;

        /// <summary>
        /// Checks to see if the InputVariables property is set.
        /// </summary>
        internal bool IsSetInputVariables() => this.InputVariables != null && (this.InputVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Contains messages in the chat for the prompt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Message> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// Contains system prompts to provide context to the model or to describe how it should
        /// behave.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SystemContentBlock> System { get; set; } = AWSConfigs.InitializeCollections ? new List<SystemContentBlock>() : null;

        /// <summary>
        /// Checks to see if the System property is set.
        /// </summary>
        internal bool IsSetSystem() => this.System != null && (this.System.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToolConfiguration. 
        /// <para>
        /// Configuration information for the tools that the model can use when generating a response.
        /// </para>
        /// </summary>
        public ToolConfiguration ToolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ToolConfiguration property is set.
        /// </summary>
        internal bool IsSetToolConfiguration() => this.ToolConfiguration != null;
    }
}
