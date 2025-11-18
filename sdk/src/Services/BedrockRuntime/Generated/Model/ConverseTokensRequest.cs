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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The inputs from a <c>Converse</c> API request for token counting.
    /// 
    ///  
    /// <para>
    /// This structure mirrors the input format for the <c>Converse</c> operation, allowing
    /// you to count tokens for conversation-based inference requests.
    /// </para>
    /// </summary>
    public partial class ConverseTokensRequest
    {
        private Amazon.Runtime.Documents.Document _additionalModelRequestFields;
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;
        private List<SystemContentBlock> _system = AWSConfigs.InitializeCollections ? new List<SystemContentBlock>() : null;
        private ToolConfiguration _toolConfig;

        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// The additionalModelRequestFields of Converse input request to count tokens for. Use
        /// this field when you want to pass additional parameters that the model supports.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalModelRequestFields
        {
            get { return this._additionalModelRequestFields; }
            set { this._additionalModelRequestFields = value; }
        }

        // Check to see if AdditionalModelRequestFields property is set
        internal bool IsSetAdditionalModelRequestFields()
        {
            return !this._additionalModelRequestFields.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// An array of messages to count tokens for.
        /// </para>
        /// </summary>
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
        /// The system content blocks to count tokens for. System content provides instructions
        /// or context to the model about how it should behave or respond. The token count will
        /// include any system content provided.
        /// </para>
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
        /// Gets and sets the property ToolConfig. 
        /// <para>
        /// The toolConfig of Converse input request to count tokens for. Configuration information
        /// for the tools that the model can use when generating a response.
        /// </para>
        /// </summary>
        public ToolConfiguration ToolConfig
        {
            get { return this._toolConfig; }
            set { this._toolConfig = value; }
        }

        // Check to see if ToolConfig property is set
        internal bool IsSetToolConfig()
        {
            return this._toolConfig != null;
        }

    }
}