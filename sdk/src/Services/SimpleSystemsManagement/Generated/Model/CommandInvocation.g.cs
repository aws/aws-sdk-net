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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An invocation is a copy of a command sent to a specific managed node. A command can
    /// apply to one or more managed nodes. A command invocation applies to one managed node.
    /// For example, if a user runs <c>SendCommand</c> against three managed nodes, then a
    /// command invocation is created for each requested managed node ID. A command invocation
    /// returns status and detail information about a command you ran.
    /// </summary>
    public partial class CommandInvocation
    {
        /// <summary>
        /// Gets and sets the property CloudWatchOutputConfig. 
        /// <para>
        /// Amazon CloudWatch Logs information where you want Amazon Web Services Systems Manager
        /// to send the command output.
        /// </para>
        /// </summary>
        public CloudWatchOutputConfig CloudWatchOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchOutputConfig property is set.
        /// </summary>
        internal bool IsSetCloudWatchOutputConfig() => this.CloudWatchOutputConfig != null;

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The command against which this invocation was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

        /// <summary>
        /// Gets and sets the property CommandPlugins. 
        /// <para>
        /// Plugins processed by the command.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CommandPlugin> CommandPlugins { get; set; } = AWSConfigs.InitializeCollections ? new List<CommandPlugin>() : null;

        /// <summary>
        /// Checks to see if the CommandPlugins property is set.
        /// </summary>
        internal bool IsSetCommandPlugins() => this.CommandPlugins != null && (this.CommandPlugins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// User-specified information about the command, such as a brief description of what
        /// the command should do.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The document name that was requested for execution.
        /// </para>
        /// </summary>
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The Systems Manager document (SSM document) version.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID in which this invocation was requested.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The fully qualified host name of the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property NotificationConfig. 
        /// <para>
        /// Configurations for sending notifications about command status changes on a per managed
        /// node basis.
        /// </para>
        /// </summary>
        public NotificationConfig NotificationConfig { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfig property is set.
        /// </summary>
        internal bool IsSetNotificationConfig() => this.NotificationConfig != null;

        /// <summary>
        /// Gets and sets the property RequestedDateTime. 
        /// <para>
        /// The time and date the request was sent to this managed node.
        /// </para>
        /// </summary>
        public DateTime? RequestedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestedDateTime property is set.
        /// </summary>
        internal bool IsSetRequestedDateTime() => this.RequestedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The Identity and Access Management (IAM) service role that Run Command, a tool in
        /// Amazon Web Services Systems Manager, uses to act on your behalf when sending notifications
        /// about command status changes on a per managed node basis.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property StandardErrorUrl. 
        /// <para>
        /// The URL to the plugin's StdErr file in Amazon Simple Storage Service (Amazon S3),
        /// if the S3 bucket was defined for the parent command. For an invocation, <c>StandardErrorUrl</c>
        /// is populated if there is just one plugin defined for the command, and the S3 bucket
        /// was defined for the command.
        /// </para>
        /// </summary>
        public string StandardErrorUrl { get; set; }

        /// <summary>
        /// Checks to see if the StandardErrorUrl property is set.
        /// </summary>
        internal bool IsSetStandardErrorUrl() => this.StandardErrorUrl != null;

        /// <summary>
        /// Gets and sets the property StandardOutputUrl. 
        /// <para>
        /// The URL to the plugin's StdOut file in Amazon Simple Storage Service (Amazon S3),
        /// if the S3 bucket was defined for the parent command. For an invocation, <c>StandardOutputUrl</c>
        /// is populated if there is just one plugin defined for the command, and the S3 bucket
        /// was defined for the command.
        /// </para>
        /// </summary>
        public string StandardOutputUrl { get; set; }

        /// <summary>
        /// Checks to see if the StandardOutputUrl property is set.
        /// </summary>
        internal bool IsSetStandardOutputUrl() => this.StandardOutputUrl != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether or not the invocation succeeded, failed, or is pending.
        /// </para>
        /// </summary>
        public CommandInvocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A detailed status of the command execution for each invocation (each managed node
        /// targeted by the command). StatusDetails includes more information than Status because
        /// it includes states resulting from error and concurrency control parameters. StatusDetails
        /// can show different results than Status. For more information about these statuses,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-commands.html">Understanding
        /// command statuses</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// StatusDetails can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The command hasn't been sent to the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Progress: The command has been sent to the managed node but hasn't reached a terminal
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success: The execution of the command or plugin was successfully completed. This is
        /// a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delivery Timed Out: The command wasn't delivered to the managed node before the delivery
        /// timeout expired. Delivery timeouts don't count against the parent command's <c>MaxErrors</c>
        /// limit, but they do contribute to whether the parent command status is Success or Incomplete.
        /// This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Execution Timed Out: Command execution started on the managed node, but the execution
        /// wasn't complete before the execution timeout expired. Execution timeouts count against
        /// the <c>MaxErrors</c> limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The command wasn't successful on the managed node. For a plugin, this indicates
        /// that the result code wasn't zero. For a command invocation, this indicates that the
        /// result code for one or more plugins wasn't zero. Invocation failures count against
        /// the <c>MaxErrors</c> limit of the parent command. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cancelled: The command was terminated before it was completed. This is a terminal
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Undeliverable: The command can't be delivered to the managed node. The managed node
        /// might not exist or might not be responding. Undeliverable invocations don't count
        /// against the parent command's MaxErrors limit and don't contribute to whether the parent
        /// command status is Success or Incomplete. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Terminated: The parent command exceeded its MaxErrors limit and subsequent command
        /// invocations were canceled by the system. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delayed: The system attempted to send the command to the managed node but wasn't successful.
        /// The system retries again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property TraceOutput. 
        /// <para>
        ///  Gets the trace output sent by the agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public string TraceOutput { get; set; }

        /// <summary>
        /// Checks to see if the TraceOutput property is set.
        /// </summary>
        internal bool IsSetTraceOutput() => this.TraceOutput != null;
    }
}
