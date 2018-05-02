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
        private string _documentVersion;
        private string _instanceId;
        private string _instanceName;
        private NotificationConfig _notificationConfig;
        private DateTime? _requestedDateTime;
        private string _serviceRole;
        private string _standardErrorUrl;
        private string _standardOutputUrl;
        private CommandInvocationStatus _status;
        private string _statusDetails;
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
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The SSM document version.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
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
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the invocation target. For Amazon EC2 instances this is the value for
        /// the aws:Name tag. For on-premises instances, this is the name of the instance.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfig. 
        /// <para>
        /// Configurations for sending notifications about command status changes on a per instance
        /// basis.
        /// </para>
        /// </summary>
        public NotificationConfig NotificationConfig
        {
            get { return this._notificationConfig; }
            set { this._notificationConfig = value; }
        }

        // Check to see if NotificationConfig property is set
        internal bool IsSetNotificationConfig()
        {
            return this._notificationConfig != null;
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
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM service role that Run Command uses to act on your behalf when sending notifications
        /// about command status changes on a per instance basis.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property StandardErrorUrl. 
        /// <para>
        /// The URL to the plugin's StdErr file in Amazon S3, if the Amazon S3 bucket was defined
        /// for the parent command. For an invocation, StandardErrorUrl is populated if there
        /// is just one plugin defined for the command, and the Amazon S3 bucket was defined for
        /// the command.
        /// </para>
        /// </summary>
        public string StandardErrorUrl
        {
            get { return this._standardErrorUrl; }
            set { this._standardErrorUrl = value; }
        }

        // Check to see if StandardErrorUrl property is set
        internal bool IsSetStandardErrorUrl()
        {
            return this._standardErrorUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StandardOutputUrl. 
        /// <para>
        /// The URL to the plugin's StdOut file in Amazon S3, if the Amazon S3 bucket was defined
        /// for the parent command. For an invocation, StandardOutputUrl is populated if there
        /// is just one plugin defined for the command, and the Amazon S3 bucket was defined for
        /// the command.
        /// </para>
        /// </summary>
        public string StandardOutputUrl
        {
            get { return this._standardOutputUrl; }
            set { this._standardOutputUrl = value; }
        }

        // Check to see if StandardOutputUrl property is set
        internal bool IsSetStandardOutputUrl()
        {
            return this._standardOutputUrl != null;
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A detailed status of the command execution for each invocation (each instance targeted
        /// by the command). StatusDetails includes more information than Status because it includes
        /// states resulting from error and concurrency control parameters. StatusDetails can
        /// show different results than Status. For more information about these statuses, see
        /// <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-about-status.html">Run
        /// Command Status</a>. StatusDetails can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The command has not been sent to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Progress: The command has been sent to the instance but has not reached a terminal
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success: The execution of the command or plugin was successfully completed. This is
        /// a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delivery Timed Out: The command was not delivered to the instance before the delivery
        /// timeout expired. Delivery timeouts do not count against the parent command's MaxErrors
        /// limit, but they do contribute to whether the parent command status is Success or Incomplete.
        /// This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Execution Timed Out: Command execution started on the instance, but the execution
        /// was not complete before the execution timeout expired. Execution timeouts count against
        /// the MaxErrors limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The command was not successful on the instance. For a plugin, this indicates
        /// that the result code was not zero. For a command invocation, this indicates that the
        /// result code for one or more plugins was not zero. Invocation failures count against
        /// the MaxErrors limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Canceled: The command was terminated before it was completed. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Undeliverable: The command can't be delivered to the instance. The instance might
        /// not exist or might not be responding. Undeliverable invocations don't count against
        /// the parent command's MaxErrors limit and don't contribute to whether the parent command
        /// status is Success or Incomplete. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Terminated: The parent command exceeded its MaxErrors limit and subsequent command
        /// invocations were canceled by the system. This is a terminal state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
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