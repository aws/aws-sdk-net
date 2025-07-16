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
    /// Contains structured content from a tool result.
    /// </summary>
    public partial class ToolResultStructuredContent
    {
        private double? _executionTime;
        private int? _exitCode;
        private string _stderr;
        private string _stdout;
        private string _taskId;
        private TaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The execution time of the tool operation in milliseconds.
        /// </para>
        /// </summary>
        public double? ExecutionTime
        {
            get { return this._executionTime; }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code from the tool execution.
        /// </para>
        /// </summary>
        public int? ExitCode
        {
            get { return this._exitCode; }
            set { this._exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this._exitCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stderr. 
        /// <para>
        /// The standard error output from the tool execution.
        /// </para>
        /// </summary>
        public string Stderr
        {
            get { return this._stderr; }
            set { this._stderr = value; }
        }

        // Check to see if Stderr property is set
        internal bool IsSetStderr()
        {
            return this._stderr != null;
        }

        /// <summary>
        /// Gets and sets the property Stdout. 
        /// <para>
        /// The standard output from the tool execution.
        /// </para>
        /// </summary>
        public string Stdout
        {
            get { return this._stdout; }
            set { this._stdout = value; }
        }

        // Check to see if Stdout property is set
        internal bool IsSetStdout()
        {
            return this._stdout != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The identifier of the task that produced the result.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The status of the task that produced the result.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}