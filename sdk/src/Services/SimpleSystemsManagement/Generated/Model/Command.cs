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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a command request.
    /// </summary>
    public partial class Command
    {
        private AlarmConfiguration _alarmConfiguration;
        private CloudWatchOutputConfig _cloudWatchOutputConfig;
        private string _commandId;
        private string _comment;
        private int? _completedCount;
        private int? _deliveryTimedOutCount;
        private string _documentName;
        private string _documentVersion;
        private int? _errorCount;
        private DateTime? _expiresAfter;
        private List<string> _instanceIds = new List<string>();
        private string _maxConcurrency;
        private string _maxErrors;
        private NotificationConfig _notificationConfig;
        private string _outputS3BucketName;
        private string _outputS3KeyPrefix;
        private string _outputS3Region;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private DateTime? _requestedDateTime;
        private string _serviceRole;
        private CommandStatus _status;
        private string _statusDetails;
        private int? _targetCount;
        private List<Target> _targets = new List<Target>();
        private int? _timeoutSeconds;
        private List<AlarmStateInformation> _triggeredAlarms = new List<AlarmStateInformation>();

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm applied to your command.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration
        {
            get { return this._alarmConfiguration; }
            set { this._alarmConfiguration = value; }
        }

        // Check to see if AlarmConfiguration property is set
        internal bool IsSetAlarmConfiguration()
        {
            return this._alarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchOutputConfig. 
        /// <para>
        /// Amazon CloudWatch Logs information where you want Amazon Web Services Systems Manager
        /// to send the command output.
        /// </para>
        /// </summary>
        public CloudWatchOutputConfig CloudWatchOutputConfig
        {
            get { return this._cloudWatchOutputConfig; }
            set { this._cloudWatchOutputConfig = value; }
        }

        // Check to see if CloudWatchOutputConfig property is set
        internal bool IsSetCloudWatchOutputConfig()
        {
            return this._cloudWatchOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// A unique identifier for this command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property Comment. 
        /// <para>
        /// User-specified information about the command, such as a brief description of what
        /// the command should do.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
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
        /// Gets and sets the property CompletedCount. 
        /// <para>
        /// The number of targets for which the command invocation reached a terminal state. Terminal
        /// states include the following: Success, Failed, Execution Timed Out, Delivery Timed
        /// Out, Cancelled, Terminated, or Undeliverable.
        /// </para>
        /// </summary>
        public int CompletedCount
        {
            get { return this._completedCount.GetValueOrDefault(); }
            set { this._completedCount = value; }
        }

        // Check to see if CompletedCount property is set
        internal bool IsSetCompletedCount()
        {
            return this._completedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryTimedOutCount. 
        /// <para>
        /// The number of targets for which the status is Delivery Timed Out.
        /// </para>
        /// </summary>
        public int DeliveryTimedOutCount
        {
            get { return this._deliveryTimedOutCount.GetValueOrDefault(); }
            set { this._deliveryTimedOutCount = value; }
        }

        // Check to see if DeliveryTimedOutCount property is set
        internal bool IsSetDeliveryTimedOutCount()
        {
            return this._deliveryTimedOutCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the document requested for execution.
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
        /// The Systems Manager document (SSM document) version.
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
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The number of targets for which the status is Failed or Execution Timed Out.
        /// </para>
        /// </summary>
        public int ErrorCount
        {
            get { return this._errorCount.GetValueOrDefault(); }
            set { this._errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this._errorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAfter. 
        /// <para>
        /// If a command expires, it changes status to <code>DeliveryTimedOut</code> for all invocations
        /// that have the status <code>InProgress</code>, <code>Pending</code>, or <code>Delayed</code>.
        /// <code>ExpiresAfter</code> is calculated based on the total timeout for the overall
        /// command. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-commands.html?icmpid=docs_ec2_console#monitor-about-status-timeouts">Understanding
        /// command timeout values</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public DateTime ExpiresAfter
        {
            get { return this._expiresAfter.GetValueOrDefault(); }
            set { this._expiresAfter = value; }
        }

        // Check to see if ExpiresAfter property is set
        internal bool IsSetExpiresAfter()
        {
            return this._expiresAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The managed node IDs against which this command was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of managed nodes that are allowed to run the command at the same
        /// time. You can specify a number of managed nodes, such as 10, or a percentage of nodes,
        /// such as 10%. The default value is 50. For more information about how to use <code>MaxConcurrency</code>,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Running
        /// commands using Systems Manager Run Command</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The maximum number of errors allowed before the system stops sending the command to
        /// additional targets. You can specify a number of errors, such as 10, or a percentage
        /// or errors, such as 10%. The default value is <code>0</code>. For more information
        /// about how to use <code>MaxErrors</code>, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Running
        /// commands using Systems Manager Run Command</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxErrors
        {
            get { return this._maxErrors; }
            set { this._maxErrors = value; }
        }

        // Check to see if MaxErrors property is set
        internal bool IsSetMaxErrors()
        {
            return this._maxErrors != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfig. 
        /// <para>
        /// Configurations for sending notifications about command status changes. 
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
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// The S3 bucket where the responses to the command executions should be stored. This
        /// was requested when issuing the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string OutputS3BucketName
        {
            get { return this._outputS3BucketName; }
            set { this._outputS3BucketName = value; }
        }

        // Check to see if OutputS3BucketName property is set
        internal bool IsSetOutputS3BucketName()
        {
            return this._outputS3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The S3 directory path inside the bucket where the responses to the command executions
        /// should be stored. This was requested when issuing the command.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string OutputS3KeyPrefix
        {
            get { return this._outputS3KeyPrefix; }
            set { this._outputS3KeyPrefix = value; }
        }

        // Check to see if OutputS3KeyPrefix property is set
        internal bool IsSetOutputS3KeyPrefix()
        {
            return this._outputS3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3Region. 
        /// <para>
        /// (Deprecated) You can no longer specify this parameter. The system ignores it. Instead,
        /// Systems Manager automatically determines the Amazon Web Services Region of the S3
        /// bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20)]
        public string OutputS3Region
        {
            get { return this._outputS3Region; }
            set { this._outputS3Region = value; }
        }

        // Check to see if OutputS3Region property is set
        internal bool IsSetOutputS3Region()
        {
            return this._outputS3Region != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter values to be inserted in the document when running the command.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestedDateTime. 
        /// <para>
        /// The date and time the command was requested.
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
        /// The Identity and Access Management (IAM) service role that Run Command, a capability
        /// of Amazon Web Services Systems Manager, uses to act on your behalf when sending notifications
        /// about command status changes. 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the command.
        /// </para>
        /// </summary>
        public CommandStatus Status
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
        /// A detailed status of the command execution. <code>StatusDetails</code> includes more
        /// information than <code>Status</code> because it includes states resulting from error
        /// and concurrency control parameters. <code>StatusDetails</code> can show different
        /// results than Status. For more information about these statuses, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-commands.html">Understanding
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
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property TargetCount. 
        /// <para>
        /// The number of targets for the command.
        /// </para>
        /// </summary>
        public int TargetCount
        {
            get { return this._targetCount.GetValueOrDefault(); }
            set { this._targetCount = value; }
        }

        // Check to see if TargetCount property is set
        internal bool IsSetTargetCount()
        {
            return this._targetCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// An array of search criteria that targets managed nodes using a Key,Value combination
        /// that you specify. Targets is required if you don't provide one or more managed node
        /// IDs in the call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The <code>TimeoutSeconds</code> value specified for a command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30, Max=2592000)]
        public int TimeoutSeconds
        {
            get { return this._timeoutSeconds.GetValueOrDefault(); }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarm that was invoked by the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AlarmStateInformation> TriggeredAlarms
        {
            get { return this._triggeredAlarms; }
            set { this._triggeredAlarms = value; }
        }

        // Check to see if TriggeredAlarms property is set
        internal bool IsSetTriggeredAlarms()
        {
            return this._triggeredAlarms != null && this._triggeredAlarms.Count > 0; 
        }

    }
}