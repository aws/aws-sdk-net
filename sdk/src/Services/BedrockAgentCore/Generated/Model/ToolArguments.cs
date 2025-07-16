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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// when invoking a tool in Amazon Bedrock. Different tools require different arguments,
    /// and this structure provides a flexible way to pass the appropriate arguments to each
    /// tool type.
    /// </summary>
    public partial class ToolArguments
    {
        private bool? _clearContext;
        private string _code;
        private string _command;
        private List<InputContentBlock> _content = AWSConfigs.InitializeCollections ? new List<InputContentBlock>() : null;
        private string _directoryPath;
        private ProgrammingLanguage _language;
        private string _path;
        private List<string> _paths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property ClearContext. 
        /// <para>
        /// Whether to clear the context for the tool.
        /// </para>
        /// </summary>
        public bool? ClearContext
        {
            get { return this._clearContext; }
            set { this._clearContext = value; }
        }

        // Check to see if ClearContext property is set
        internal bool IsSetClearContext()
        {
            return this._clearContext.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code to execute in a code interpreter session. This is the source code in the
        /// specified programming language that will be executed by the code interpreter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000000)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to execute with the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000000)]
        public string Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content for the tool operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputContentBlock> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DirectoryPath. 
        /// <para>
        /// The directory path for the tool operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000000)]
        public string DirectoryPath
        {
            get { return this._directoryPath; }
            set { this._directoryPath = value; }
        }

        // Check to see if DirectoryPath property is set
        internal bool IsSetDirectoryPath()
        {
            return this._directoryPath != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The programming language of the code to execute. This tells the code interpreter which
        /// language runtime to use for execution. Common values include 'python', 'javascript',
        /// and 'r'.
        /// </para>
        /// </summary>
        public ProgrammingLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path for the tool operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000000)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// The paths for the tool operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Paths
        {
            get { return this._paths; }
            set { this._paths = value; }
        }

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this._paths != null && (this._paths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The identifier of the task for the tool operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000000)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}