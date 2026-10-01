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
    /// Contains structured content from a tool result.
    /// </summary>
    public partial class ToolResultStructuredContent
    {
        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The execution time of the tool operation in milliseconds.
        /// </para>
        /// </summary>
        public double? ExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTime property is set.
        /// </summary>
        internal bool IsSetExecutionTime() => this.ExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code from the tool execution.
        /// </para>
        /// </summary>
        public int? ExitCode { get; set; }

        /// <summary>
        /// Checks to see if the ExitCode property is set.
        /// </summary>
        internal bool IsSetExitCode() => this.ExitCode.HasValue;

        /// <summary>
        /// Gets and sets the property Stderr. 
        /// <para>
        /// The standard error output from the tool execution.
        /// </para>
        /// </summary>
        public string Stderr { get; set; }

        /// <summary>
        /// Checks to see if the Stderr property is set.
        /// </summary>
        internal bool IsSetStderr() => this.Stderr != null;

        /// <summary>
        /// Gets and sets the property Stdout. 
        /// <para>
        /// The standard output from the tool execution.
        /// </para>
        /// </summary>
        public string Stdout { get; set; }

        /// <summary>
        /// Checks to see if the Stdout property is set.
        /// </summary>
        internal bool IsSetStdout() => this.Stdout != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The identifier of the task that produced the result.
        /// </para>
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The status of the task that produced the result.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}
