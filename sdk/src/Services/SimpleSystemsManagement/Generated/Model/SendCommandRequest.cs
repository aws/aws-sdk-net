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
    /// Container for the parameters to the SendCommand operation.
    /// Runs commands on one or more managed nodes.
    /// </summary>
    public partial class SendCommandRequest : AmazonSimpleSystemsManagementRequest
    {
        private AlarmConfiguration _alarmConfiguration;
        private CloudWatchOutputConfig _cloudWatchOutputConfig;
        private string _comment;
        private string _documentHash;
        private DocumentHashType _documentHashType;
        private string _documentName;
        private string _documentVersion;
        private List<string> _instanceIds = new List<string>();
        private string _maxConcurrency;
        private string _maxErrors;
        private NotificationConfig _notificationConfig;
        private string _outputS3BucketName;
        private string _outputS3KeyPrefix;
        private string _outputS3Region;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _serviceRoleArn;
        private List<Target> _targets = new List<Target>();
        private int? _timeoutSeconds;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendCommandRequest() { }

        /// <summary>
        /// Instantiates SendCommandRequest with the parameterized properties
        /// </summary>
        /// <param name="documentName">The name of the Amazon Web Services Systems Manager document (SSM document) to run. This can be a public document or a custom document. To run a shared document belonging to another account, specify the document Amazon Resource Name (ARN). For more information about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ssm-using-shared.html">Using shared SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>. <note> If you specify a document name or ARN that hasn't been shared with your account, you receive an <code>InvalidDocument</code> error.  </note></param>
        /// <param name="instanceIds">The IDs of the managed nodes where the command should run. Specifying managed node IDs is most useful when you are targeting a limited number of managed nodes, though you can specify up to 50 IDs. To target a larger number of managed nodes, or if you prefer not to list individual node IDs, we recommend using the <code>Targets</code> option instead. Using <code>Targets</code>, which accepts tag key-value pairs to identify the managed nodes to send commands to, you can a send command to tens, hundreds, or thousands of nodes at once. For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Using targets and rate controls to send commands to a fleet</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.</param>
        public SendCommandRequest(string documentName, List<string> instanceIds)
        {
            _documentName = documentName;
            _instanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The CloudWatch alarm you want to apply to your command.
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
        /// Enables Amazon Web Services Systems Manager to send Run Command output to Amazon CloudWatch
        /// Logs. Run Command is a capability of Amazon Web Services Systems Manager.
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
        /// Gets and sets the property DocumentHash. 
        /// <para>
        /// The Sha256 or Sha1 hash created by the system when the document was created. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DocumentHash
        {
            get { return this._documentHash; }
            set { this._documentHash = value; }
        }

        // Check to see if DocumentHash property is set
        internal bool IsSetDocumentHash()
        {
            return this._documentHash != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentHashType. 
        /// <para>
        /// Sha256 or Sha1.
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public DocumentHashType DocumentHashType
        {
            get { return this._documentHashType; }
            set { this._documentHashType = value; }
        }

        // Check to see if DocumentHashType property is set
        internal bool IsSetDocumentHashType()
        {
            return this._documentHashType != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Amazon Web Services Systems Manager document (SSM document) to run.
        /// This can be a public document or a custom document. To run a shared document belonging
        /// to another account, specify the document Amazon Resource Name (ARN). For more information
        /// about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ssm-using-shared.html">Using
        /// shared SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify a document name or ARN that hasn't been shared with your account, you
        /// receive an <code>InvalidDocument</code> error. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The SSM document version to use in the request. You can specify $DEFAULT, $LATEST,
        /// or a specific version number. If you run commands by using the Command Line Interface
        /// (Amazon Web Services CLI), then you must escape the first two options by using a backslash.
        /// If you specify a version number, then you don't need to use the backslash. For example:
        /// </para>
        ///  
        /// <para>
        /// --document-version "\$DEFAULT"
        /// </para>
        ///  
        /// <para>
        /// --document-version "\$LATEST"
        /// </para>
        ///  
        /// <para>
        /// --document-version "3"
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the managed nodes where the command should run. Specifying managed node
        /// IDs is most useful when you are targeting a limited number of managed nodes, though
        /// you can specify up to 50 IDs.
        /// </para>
        ///  
        /// <para>
        /// To target a larger number of managed nodes, or if you prefer not to list individual
        /// node IDs, we recommend using the <code>Targets</code> option instead. Using <code>Targets</code>,
        /// which accepts tag key-value pairs to identify the managed nodes to send commands to,
        /// you can a send command to tens, hundreds, or thousands of nodes at once.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Using
        /// targets and rate controls to send commands to a fleet</a> in the <i>Amazon Web Services
        /// Systems Manager User Guide</i>.
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
        /// (Optional) The maximum number of managed nodes that are allowed to run the command
        /// at the same time. You can specify a number such as 10 or a percentage such as 10%.
        /// The default value is <code>50</code>. For more information about how to use <code>MaxConcurrency</code>,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html#send-commands-velocity">Using
        /// concurrency controls</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// The maximum number of errors allowed without the command failing. When the command
        /// fails one more time beyond the value of <code>MaxErrors</code>, the systems stops
        /// sending the command to additional targets. You can specify a number like 10 or a percentage
        /// like 10%. The default value is <code>0</code>. For more information about how to use
        /// <code>MaxErrors</code>, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html#send-commands-maxerrors">Using
        /// error controls</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// Configurations for sending notifications.
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
        /// The name of the S3 bucket where command execution responses should be stored.
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
        /// The directory structure within the S3 bucket where the responses should be stored.
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
        /// The required and optional parameters specified in the document being run.
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
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The ARN of the Identity and Access Management (IAM) service role to use to publish
        /// Amazon Simple Notification Service (Amazon SNS) notifications for Run Command commands.
        /// </para>
        ///  
        /// <para>
        /// This role must provide the <code>sns:Publish</code> permission for your notification
        /// topic. For information about creating and using this service role, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitoring-sns-notifications.html">Monitoring
        /// Systems Manager status changes using Amazon SNS notifications</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// An array of search criteria that targets managed nodes using a <code>Key,Value</code>
        /// combination that you specify. Specifying targets is most useful when you want to send
        /// a command to a large number of managed nodes at once. Using <code>Targets</code>,
        /// which accepts tag key-value pairs to identify managed nodes, you can send a command
        /// to tens, hundreds, or thousands of nodes at once.
        /// </para>
        ///  
        /// <para>
        /// To send a command to a smaller number of managed nodes, you can use the <code>InstanceIds</code>
        /// option instead.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Sending
        /// commands to a fleet</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// If this time is reached and the command hasn't already started running, it won't run.
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

    }
}