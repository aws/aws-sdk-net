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
    /// An event that signals the completion of a command execution. This event contains the
    /// final status and exit code of the executed command.
    /// </summary>
    public partial class ContentStopEvent
    {
        private int? _exitCode;
        private CommandExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code returned by the executed command. An exit code of 0 indicates successful
        /// execution, -1 indicates a platform error, and values greater than 0 indicate command-specific
        /// errors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The final status of the command execution. Valid values are <c>COMPLETED</c> for successful
        /// completion or <c>TIMED_OUT</c> if the command exceeded the specified timeout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CommandExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}