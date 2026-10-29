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
    /// Container for the parameters to the SendCommand operation. Runs commands on one or
    /// more managed nodes.
    /// </summary>
    public partial class SendCommandRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public SendCommandRequest() { }

        /// <summary>
        /// Instantiates SendCommandRequest with the parameterized properties
        /// </summary>
        /// <param name="documentName">The name of the Amazon Web Services Systems Manager document (SSM document) to run. This can be a public document or a   custom document. To run a shared document belonging to another account, specify the document   Amazon Resource Name (ARN). For more information about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ssm-using-shared.html">Sharing SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.   <note>   If you specify a document name or ARN that hasn't been shared with your account, you receive an <c>InvalidDocument</c> error.    </note></param>
        /// <param name="instanceIds">The IDs of the managed nodes where the command should run. Specifying managed node IDs is   most useful when you are targeting a limited number of managed nodes, though you can specify up   to 50 IDs.   To target a larger number of managed nodes, or if you prefer not to list individual node   IDs, we recommend using the <c>Targets</c> option instead. Using <c>Targets</c>,   which accepts tag key-value pairs to identify the managed nodes to send commands to, you can a   send command to tens, hundreds, or thousands of nodes at once.   For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Run commands at scale</a>   in the <i>Amazon Web Services Systems Manager User Guide</i>.</param>
        public SendCommandRequest(string documentName, List<string> instanceIds)
        {
            this.DocumentName = documentName;
            this.InstanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The CloudWatch alarm you want to apply to your command.
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
        /// Enables Amazon Web Services Systems Manager to send Run Command output to Amazon CloudWatch
        /// Logs. Run Command is a tool in Amazon Web Services Systems Manager.
        /// </para>
        /// </summary>
        public CloudWatchOutputConfig CloudWatchOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchOutputConfig property is set.
        /// </summary>
        internal bool IsSetCloudWatchOutputConfig() => this.CloudWatchOutputConfig != null;

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
        [AWSProperty(Min = 0, Max = 256)]
        public string DocumentHash { get; set; }

        /// <summary>
        /// Checks to see if the DocumentHash property is set.
        /// </summary>
        internal bool IsSetDocumentHash() => this.DocumentHash != null;

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
        public DocumentHashType DocumentHashType { get; set; }

        /// <summary>
        /// Checks to see if the DocumentHashType property is set.
        /// </summary>
        internal bool IsSetDocumentHashType() => this.DocumentHashType != null;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Amazon Web Services Systems Manager document (SSM document) to run.
        /// This can be a public document or a custom document. To run a shared document belonging
        /// to another account, specify the document Amazon Resource Name (ARN). For more information
        /// about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ssm-using-shared.html">Sharing
        /// SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify a document name or ARN that hasn't been shared with your account, you
        /// receive an <c>InvalidDocument</c> error. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

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
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

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
        /// node IDs, we recommend using the <c>Targets</c> option instead. Using <c>Targets</c>,
        /// which accepts tag key-value pairs to identify the managed nodes to send commands to,
        /// you can a send command to tens, hundreds, or thousands of nodes at once.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Run
        /// commands at scale</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// (Optional) The maximum number of managed nodes that are allowed to run the command
        /// at the same time. You can specify a number such as 10 or a percentage such as 10%.
        /// The default value is <c>50</c>. For more information about how to use <c>MaxConcurrency</c>,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html#send-commands-velocity">Using
        /// concurrency controls</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// The maximum number of errors allowed without the command failing. When the command
        /// fails one more time beyond the value of <c>MaxErrors</c>, the systems stops sending
        /// the command to additional targets. You can specify a number like 10 or a percentage
        /// like 10%. The default value is <c>0</c>. For more information about how to use <c>MaxErrors</c>,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html#send-commands-maxerrors">Using
        /// error controls</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// Configurations for sending notifications.
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
        /// The name of the S3 bucket where command execution responses should be stored.
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
        /// The directory structure within the S3 bucket where the responses should be stored.
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
        /// The required and optional parameters specified in the document being run.
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
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The ARN of the Identity and Access Management (IAM) service role to use to publish
        /// Amazon Simple Notification Service (Amazon SNS) notifications for Run Command commands.
        /// </para>
        ///  
        /// <para>
        /// This role must provide the <c>sns:Publish</c> permission for your notification topic.
        /// For information about creating and using this service role, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitoring-sns-notifications.html">Monitoring
        /// Systems Manager status changes using Amazon SNS notifications</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public string ServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceRoleArn() => this.ServiceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// An array of search criteria that targets managed nodes using a <c>Key,Value</c> combination
        /// that you specify. Specifying targets is most useful when you want to send a command
        /// to a large number of managed nodes at once. Using <c>Targets</c>, which accepts tag
        /// key-value pairs to identify managed nodes, you can send a command to tens, hundreds,
        /// or thousands of nodes at once.
        /// </para>
        ///  
        /// <para>
        /// To send a command to a smaller number of managed nodes, you can use the <c>InstanceIds</c>
        /// option instead.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Run
        /// commands at scale</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// If this time is reached and the command hasn't already started running, it won't run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 2592000)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;
    }
}
