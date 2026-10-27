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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains command execution information.
    /// </summary>
    public partial class CommandExecution
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that needs to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the command execution process ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code to return upon completion.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ExitCode { get; set; }

        /// <summary>
        /// Checks to see if the ExitCode property is set.
        /// </summary>
        internal bool IsSetExitCode() => this.ExitCode != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the command execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Logs.
        /// </summary>
        public LogsLocation Logs { get; set; }

        /// <summary>
        /// Checks to see if the Logs property is set.
        /// </summary>
        internal bool IsSetLogs() => this.Logs != null;

        /// <summary>
        /// Gets and sets the property SandboxArn. 
        /// <para>
        /// A <c>sandboxArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SandboxArn { get; set; }

        /// <summary>
        /// Checks to see if the SandboxArn property is set.
        /// </summary>
        internal bool IsSetSandboxArn() => this.SandboxArn != null;

        /// <summary>
        /// Gets and sets the property SandboxId. 
        /// <para>
        /// A <c>sandboxId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SandboxId { get; set; }

        /// <summary>
        /// Checks to see if the SandboxId property is set.
        /// </summary>
        internal bool IsSetSandboxId() => this.SandboxId != null;

        /// <summary>
        /// Gets and sets the property StandardErrContent. 
        /// <para>
        /// The text written by the command to stderr.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string StandardErrContent { get; set; }

        /// <summary>
        /// Checks to see if the StandardErrContent property is set.
        /// </summary>
        internal bool IsSetStandardErrContent() => this.StandardErrContent != null;

        /// <summary>
        /// Gets and sets the property StandardOutputContent. 
        /// <para>
        /// The text written by the command to stdout.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string StandardOutputContent { get; set; }

        /// <summary>
        /// Checks to see if the StandardOutputContent property is set.
        /// </summary>
        internal bool IsSetStandardOutputContent() => this.StandardOutputContent != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the command execution process started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the command execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// When the command execution process was initially submitted, expressed in Unix time
        /// format.
        /// </para>
        /// </summary>
        public DateTime? SubmitTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTime property is set.
        /// </summary>
        internal bool IsSetSubmitTime() => this.SubmitTime.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The command type.
        /// </para>
        /// </summary>
        public CommandType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
