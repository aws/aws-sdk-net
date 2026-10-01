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
    /// The collection of arguments that specify the operation to perform and its parameters
    /// when invoking a tool in Amazon Bedrock AgentCore. Different tools require different
    /// arguments, and this structure provides a flexible way to pass the appropriate arguments
    /// to each tool type.
    /// </summary>
    public partial class ToolArguments
    {
        /// <summary>
        /// Gets and sets the property ClearContext. 
        /// <para>
        /// Whether to clear the context for the tool.
        /// </para>
        /// </summary>
        public bool? ClearContext { get; set; }

        /// <summary>
        /// Checks to see if the ClearContext property is set.
        /// </summary>
        internal bool IsSetClearContext() => this.ClearContext.HasValue;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code to execute in a code interpreter session. This is the source code in the
        /// specified programming language that will be executed by the code interpreter.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100000000)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to execute with the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100000000)]
        public string Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content for the tool operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputContentBlock> Content { get; set; } = AWSConfigs.InitializeCollections ? new List<InputContentBlock>() : null;

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null && (this.Content.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DirectoryPath. 
        /// <para>
        /// The directory path for the tool operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100000000)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryPath property is set.
        /// </summary>
        internal bool IsSetDirectoryPath() => this.DirectoryPath != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The programming language of the code to execute. This tells the code interpreter which
        /// language runtime to use for execution.
        /// </para>
        /// </summary>
        public ProgrammingLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path for the tool operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100000000)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// The paths for the tool operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Paths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Paths property is set.
        /// </summary>
        internal bool IsSetPaths() => this.Paths != null && (this.Paths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime environment to use for code execution. If not specified, defaults to <c>deno</c>
        /// for JavaScript and TypeScript.
        /// </para>
        /// </summary>
        public LanguageRuntime Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The identifier of the task for the tool operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100000000)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
