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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The output produced by executing code in a code interpreter session in Amazon Bedrock
    /// AgentCore. This structure contains the results of code execution, including textual
    /// output, structured data, and error information. Agents use these results to generate
    /// responses that incorporate computation, data analysis, and visualization.
    /// </summary>
    public partial class CodeInterpreterResult : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The textual content of the execution result. This includes standard output from the
        /// code execution, such as print statements, console output, and text representations
        /// of results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ContentBlock> Content { get; set; } = AWSConfigs.InitializeCollections ? new List<ContentBlock>() : null;

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null && (this.Content.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsError. 
        /// <para>
        /// Indicates whether the result represents an error. If true, the content contains error
        /// messages or exception information. If false, the content contains successful execution
        /// results.
        /// </para>
        /// </summary>
        public bool? IsError { get; set; }

        /// <summary>
        /// Checks to see if the IsError property is set.
        /// </summary>
        internal bool IsSetIsError() => this.IsError.HasValue;

        /// <summary>
        /// Gets and sets the property StructuredContent. 
        /// <para>
        /// The structured content of the execution result. This includes additional metadata
        /// about the execution, such as execution time, memory usage, and structured representations
        /// of output data. The format depends on the specific code interpreter and execution
        /// context.
        /// </para>
        /// </summary>
        public ToolResultStructuredContent StructuredContent { get; set; }

        /// <summary>
        /// Checks to see if the StructuredContent property is set.
        /// </summary>
        internal bool IsSetStructuredContent() => this.StructuredContent != null;
    }
}
