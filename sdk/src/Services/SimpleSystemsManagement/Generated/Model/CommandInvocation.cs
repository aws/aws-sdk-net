/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An invocation is copy of a command sent to a specific instance. A command can apply
    /// to one or more instances. A command invocation applies to one instance. For example,
    /// if a user executes SendCommand against three instances, then a command invocation
    /// is created for each requested instance ID. A command invocation returns status and
    /// detail information about a command you executed.
    /// </summary>
    public partial class CommandInvocation
    {
        private string _commandId;
        private List<CommandPlugin> _commandPlugins = new List<CommandPlugin>();
        private string _comment;
        private string _documentName;
        private string _instanceId;
        private DateTime? _requestedDateTime;
        private CommandInvocationStatus _status;
        private string _traceOutput;

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The command against which this invocation was requested.
        /// </para>
        /// </summary>
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property CommandPlugins.
        /// </summary>
        public List<CommandPlugin> CommandPlugins
        {
            get { return this._commandPlugins; }
            set { this._commandPlugins = value; }
        }

        // Check to see if CommandPlugins property is set
        internal bool IsSetCommandPlugins()
        {
            return this._commandPlugins != null && this._commandPlugins.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// User-specified information about the command, such as a brief description of what
        /// the command should do.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The document name that was requested for execution.
        /// </para>
        /// </summary>
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID in which this invocation was requested.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedDateTime. 
        /// <para>
        /// The time and date the request was sent to this instance.
        /// </para>
        /// </summary>
        public DateTime RequestedDateTime
        {
            get { return this._requestedDateTime.GetValueOrDefault(); }
            set { this._requestedDateTime = value; }
        }

        // Check to see if RequestedDateTime property is set
        internal bool IsSetRequestedDateTime()
        {
            return this._requestedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether or not the invocation succeeded, failed, or is pending.
        /// </para>
        /// </summary>
        public CommandInvocationStatus Status
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
        /// Gets and sets the property TraceOutput. 
        /// <para>
        ///  Gets the trace output sent by the agent. 
        /// </para>
        /// </summary>
        public string TraceOutput
        {
            get { return this._traceOutput; }
            set { this._traceOutput = value; }
        }

        // Check to see if TraceOutput property is set
        internal bool IsSetTraceOutput()
        {
            return this._traceOutput != null;
        }

    }
}