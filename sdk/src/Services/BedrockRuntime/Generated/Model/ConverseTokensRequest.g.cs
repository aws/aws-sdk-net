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
        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// The additionalModelRequestFields of Converse input request to count tokens for. Use
        /// this field when you want to pass additional parameters that the model supports.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalModelRequestFields { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalModelRequestFields property is set.
        /// </summary>
        internal bool IsSetAdditionalModelRequestFields() => !this.AdditionalModelRequestFields.IsNull();

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// An array of messages to count tokens for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Message> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// The system content blocks to count tokens for. System content provides instructions
        /// or context to the model about how it should behave or respond. The token count will
        /// include any system content provided.
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
        /// Gets and sets the property ToolConfig. 
        /// <para>
        /// The toolConfig of Converse input request to count tokens for. Configuration information
        /// for the tools that the model can use when generating a response.
        /// </para>
        /// </summary>
        public ToolConfiguration ToolConfig { get; set; }

        /// <summary>
        /// Checks to see if the ToolConfig property is set.
        /// </summary>
        internal bool IsSetToolConfig() => this.ToolConfig != null;
    }
}
