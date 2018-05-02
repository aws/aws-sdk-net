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
    /// Describes a command request.
    /// </summary>
    public partial class Command
    {
        private string _commandId;
        private string _comment;
        private int? _completedCount;
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

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// A unique identifier for this command.
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
        /// Gets and sets the property CompletedCount. 
        /// <para>
        /// The number of targets for which the command invocation reached a terminal state. Terminal
        /// states include the following: Success, Failed, Execution Timed Out, Delivery Timed
        /// Out, Canceled, Terminated, or Undeliverable.
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
        /// If this time is reached and the command has not already started executing, it will
        /// not run. Calculated based on the ExpiresAfter user input provided as part of the SendCommand
        /// API.
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
        /// The instance IDs against which this command was requested.
        /// </para>
        /// </summary>
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
        /// The maximum number of instances that are allowed to execute the command at the same
        /// time. You can specify a number of instances, such as 10, or a percentage of instances,
        /// such as 10%. The default value is 50. For more information about how to use MaxConcurrency,
        /// see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Executing
        /// a Command Using Systems Manager Run Command</a>.
        /// </para>
        /// </summary>
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
        /// or errors, such as 10%. The default value is 0. For more information about how to
        /// use MaxErrors, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Executing
        /// a Command Using Systems Manager Run Command</a>.
        /// </para>
        /// </summary>
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
        /// Systems Manager automatically determines the Amazon S3 bucket region.
        /// </para>
        /// </summary>
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
        /// The parameter values to be inserted in the document when executing the command.
        /// </para>
        /// </summary>
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
        /// The IAM service role that Run Command uses to act on your behalf when sending notifications
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
        /// A detailed status of the command execution. StatusDetails includes more information
        /// than Status because it includes states resulting from error and concurrency control
        /// parameters. StatusDetails can show different results than Status. For more information
        /// about these statuses, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/monitor-about-status.html">Run
        /// Command Status</a>. StatusDetails can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The command has not been sent to any instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Progress: The command has been sent to at least one instance but has not reached
        /// a final state on all instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success: The command successfully executed on all invocations. This is a terminal
        /// state.
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
        /// Incomplete: The command was attempted on all instances and one or more invocations
        /// does not have a value of Success but not enough invocations failed for the status
        /// to be Failed. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Canceled: The command was terminated before it was completed. This is a terminal state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rate Exceeded: The number of instances targeted by the command exceeded the account
        /// limit for pending invocations. The system has canceled the command before executing
        /// it on any instance. This is a terminal state.
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
        /// An array of search criteria that targets instances using a Key,Value combination that
        /// you specify. Targets is required if you don't provide one or more instance IDs in
        /// the call.
        /// </para>
        /// </summary>
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

    }
}