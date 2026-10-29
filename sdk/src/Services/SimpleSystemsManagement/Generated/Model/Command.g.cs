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
    /// Describes a command request.
    /// </summary>
    public partial class Command
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm applied to your command.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetAlarmConfiguration() => this.AlarmConfiguration != null;

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
        /// A unique identifier for this command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

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
        /// Gets and sets the property CompletedCount. 
        /// <para>
        /// The number of targets for which the command invocation reached a terminal state. Terminal
        /// states include the following: Success, Failed, Execution Timed Out, Delivery Timed
        /// Out, Cancelled, Terminated, or Undeliverable.
        /// </para>
        /// </summary>
        public int? CompletedCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedCount property is set.
        /// </summary>
        internal bool IsSetCompletedCount() => this.CompletedCount.HasValue;

        /// <summary>
        /// Gets and sets the property DeliveryTimedOutCount. 
        /// <para>
        /// The number of targets for which the status is Delivery Timed Out.
        /// </para>
        /// </summary>
        public int? DeliveryTimedOutCount { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryTimedOutCount property is set.
        /// </summary>
        internal bool IsSetDeliveryTimedOutCount() => this.DeliveryTimedOutCount.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the document requested for execution.
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
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The number of targets for which the status is Failed or Execution Timed Out.
        /// </para>
        /// </summary>
        public int? ErrorCount { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCount property is set.
        /// </summary>
        internal bool IsSetErrorCount() => this.ErrorCount.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAfter. 
        /// <para>
        /// If a command expires, it changes status to <c>DeliveryTimedOut</c> for all invocations
        /// that have the status <c>InProgress</c>, <c>Pending</c>, or <c>Delayed</c>. <c>ExpiresAfter</c>
        /// is calculated based on the total timeout for the overall command. For more information,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-commands.html?icmpid=docs_ec2_console#monitor-about-status-timeouts">Understanding
        /// command timeout values</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAfter { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAfter property is set.
        /// </summary>
        internal bool IsSetExpiresAfter() => this.ExpiresAfter.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The managed node IDs against which this command was requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> InstanceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceIds property is set.
        /// </summary>
        internal bool IsSetInstanceIds() => this.InstanceIds != null && (this.InstanceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of managed nodes that are allowed to run the command at the same
        /// time. You can specify a number of managed nodes, such as 10, or a percentage of nodes,
        /// such as 10%. The default value is 50. For more information about how to use <c>MaxConcurrency</c>,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Amazon
        /// Web Services Systems Manager Run Command</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The maximum number of errors allowed before the system stops sending the command to
        /// additional targets. You can specify a number of errors, such as 10, or a percentage
        /// or errors, such as 10%. The default value is <c>0</c>. For more information about
        /// how to use <c>MaxErrors</c>, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Amazon
        /// Web Services Systems Manager Run Command</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxErrors property is set.
        /// </summary>
        internal bool IsSetMaxErrors() => this.MaxErrors != null;

        /// <summary>
        /// Gets and sets the property NotificationConfig. 
        /// <para>
        /// Configurations for sending notifications about command status changes. 
        /// </para>
        /// </summary>
        public NotificationConfig NotificationConfig { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfig property is set.
        /// </summary>
        internal bool IsSetNotificationConfig() => this.NotificationConfig != null;

        /// <summary>
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// The S3 bucket where the responses to the command executions should be stored. This
        /// was requested when issuing the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string OutputS3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3BucketName property is set.
        /// </summary>
        internal bool IsSetOutputS3BucketName() => this.OutputS3BucketName != null;

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The S3 directory path inside the bucket where the responses to the command executions
        /// should be stored. This was requested when issuing the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string OutputS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetOutputS3KeyPrefix() => this.OutputS3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property OutputS3Region. 
        /// <para>
        /// (Deprecated) You can no longer specify this parameter. The system ignores it. Instead,
        /// Systems Manager automatically determines the Amazon Web Services Region of the S3
        /// bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20)]
        public string OutputS3Region { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Region property is set.
        /// </summary>
        internal bool IsSetOutputS3Region() => this.OutputS3Region != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter values to be inserted in the document when running the command.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedDateTime. 
        /// <para>
        /// The date and time the command was requested.
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
        /// about command status changes. 
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the command.
        /// </para>
        /// </summary>
        public CommandStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A detailed status of the command execution. <c>StatusDetails</c> includes more information
        /// than <c>Status</c> because it includes states resulting from error and concurrency
        /// control parameters. <c>StatusDetails</c> can show different results than Status. For
        /// more information about these statuses, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-commands.html">Understanding
        /// command statuses</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// StatusDetails can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The command hasn't been sent to any managed nodes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Progress: The command has been sent to at least one managed node but hasn't reached
        /// a final state on all managed nodes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success: The command successfully ran on all invocations. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delivery Timed Out: The value of MaxErrors or more command invocations shows a status
        /// of Delivery Timed Out. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Execution Timed Out: The value of MaxErrors or more command invocations shows a status
        /// of Execution Timed Out. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The value of MaxErrors or more command invocations shows a status of Failed.
        /// This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Incomplete: The command was attempted on all managed nodes and one or more invocations
        /// doesn't have a value of Success but not enough invocations failed for the status to
        /// be Failed. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cancelled: The command was terminated before it was completed. This is a terminal
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rate Exceeded: The number of managed nodes targeted by the command exceeded the account
        /// limit for pending invocations. The system has canceled the command before running
        /// it on any managed node. This is a terminal state.
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
        /// Gets and sets the property TargetCount. 
        /// <para>
        /// The number of targets for the command.
        /// </para>
        /// </summary>
        public int? TargetCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetCount property is set.
        /// </summary>
        internal bool IsSetTargetCount() => this.TargetCount.HasValue;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// An array of search criteria that targets managed nodes using a Key,Value combination
        /// that you specify. Targets is required if you don't provide one or more managed node
        /// IDs in the call.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The <c>TimeoutSeconds</c> value specified for a command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 2592000)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarm that was invoked by the command.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AlarmStateInformation> TriggeredAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;

        /// <summary>
        /// Checks to see if the TriggeredAlarms property is set.
        /// </summary>
        internal bool IsSetTriggeredAlarms() => this.TriggeredAlarms != null && (this.TriggeredAlarms.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
