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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
        private string _command;
        private DateTime? _endTime;
        private string _exitCode;
        private string _id;
        private LogsLocation _logs;
        private string _sandboxArn;
        private string _sandboxId;
        private string _standardErrContent;
        private string _standardOutputContent;
        private DateTime? _startTime;
        private string _status;
        private DateTime? _submitTime;
        private CommandType _type;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that needs to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the command execution process ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code to return upon completion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ExitCode
        {
            get { return this._exitCode; }
            set { this._exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this._exitCode != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the command execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Logs.
        /// </summary>
        public LogsLocation Logs
        {
            get { return this._logs; }
            set { this._logs = value; }
        }

        // Check to see if Logs property is set
        internal bool IsSetLogs()
        {
            return this._logs != null;
        }

        /// <summary>
        /// Gets and sets the property SandboxArn. 
        /// <para>
        /// A <c>sandboxArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SandboxArn
        {
            get { return this._sandboxArn; }
            set { this._sandboxArn = value; }
        }

        // Check to see if SandboxArn property is set
        internal bool IsSetSandboxArn()
        {
            return this._sandboxArn != null;
        }

        /// <summary>
        /// Gets and sets the property SandboxId. 
        /// <para>
        /// A <c>sandboxId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SandboxId
        {
            get { return this._sandboxId; }
            set { this._sandboxId = value; }
        }

        // Check to see if SandboxId property is set
        internal bool IsSetSandboxId()
        {
            return this._sandboxId != null;
        }

        /// <summary>
        /// Gets and sets the property StandardErrContent. 
        /// <para>
        /// The text written by the command to stderr.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string StandardErrContent
        {
            get { return this._standardErrContent; }
            set { this._standardErrContent = value; }
        }

        // Check to see if StandardErrContent property is set
        internal bool IsSetStandardErrContent()
        {
            return this._standardErrContent != null;
        }

        /// <summary>
        /// Gets and sets the property StandardOutputContent. 
        /// <para>
        /// The text written by the command to stdout.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string StandardOutputContent
        {
            get { return this._standardOutputContent; }
            set { this._standardOutputContent = value; }
        }

        // Check to see if StandardOutputContent property is set
        internal bool IsSetStandardOutputContent()
        {
            return this._standardOutputContent != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the command execution process started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the command execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// When the command execution process was initially submitted, expressed in Unix time
        /// format.
        /// </para>
        /// </summary>
        public DateTime? SubmitTime
        {
            get { return this._submitTime; }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The command type.
        /// </para>
        /// </summary>
        public CommandType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}