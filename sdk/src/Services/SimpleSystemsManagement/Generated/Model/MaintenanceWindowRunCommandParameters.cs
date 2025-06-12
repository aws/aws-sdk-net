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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The parameters for a <c>RUN_COMMAND</c> task type.
    /// 
    ///  
    /// <para>
    /// For information about specifying and updating task parameters, see <a>RegisterTaskWithMaintenanceWindow</a>
    /// and <a>UpdateMaintenanceWindowTask</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>LoggingInfo</c> has been deprecated. To specify an Amazon Simple Storage Service
    /// (Amazon S3) bucket to contain logs, instead use the <c>OutputS3BucketName</c> and
    /// <c>OutputS3KeyPrefix</c> options in the <c>TaskInvocationParameters</c> structure.
    /// For information about how Amazon Web Services Systems Manager handles these options
    /// for the supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>TaskParameters</c> has been deprecated. To specify parameters to pass to a task
    /// when it runs, instead use the <c>Parameters</c> option in the <c>TaskInvocationParameters</c>
    /// structure. For information about how Systems Manager handles these options for the
    /// supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  
    /// <para>
    /// For <c>RUN_COMMAND</c> tasks, Systems Manager uses specified values for <c>TaskParameters</c>
    /// and <c>LoggingInfo</c> only if no values are specified for <c>TaskInvocationParameters</c>.
    /// 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class MaintenanceWindowRunCommandParameters
    {
        private CloudWatchOutputConfig _cloudWatchOutputConfig;
        private string _comment;
        private string _documentHash;
        private DocumentHashType _documentHashType;
        private string _documentVersion;
        private NotificationConfig _notificationConfig;
        private string _outputS3BucketName;
        private string _outputS3KeyPrefix;
        private Dictionary<string, List<string>> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _serviceRoleArn;
        private int? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property CloudWatchOutputConfig.
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
        /// Information about the commands to run.
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
        /// The SHA-256 or SHA-1 hash created by the system when the document was created. SHA-1
        /// hashes have been deprecated.
        /// </para>
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
        /// SHA-256 or SHA-1. SHA-1 hashes have been deprecated.
        /// </para>
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
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The Amazon Web Services Systems Manager document (SSM document) version to use in
        /// the request. You can specify <c>$DEFAULT</c>, <c>$LATEST</c>, or a specific version
        /// number. If you run commands by using the Amazon Web Services CLI, then you must escape
        /// the first two options by using a backslash. If you specify a version number, then
        /// you don't need to use the backslash. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>--document-version "\$DEFAULT"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>--document-version "\$LATEST"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>--document-version "3"</c> 
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
        /// Gets and sets the property NotificationConfig. 
        /// <para>
        /// Configurations for sending notifications about command status changes on a per-managed
        /// node basis.
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
        /// The name of the Amazon Simple Storage Service (Amazon S3) bucket.
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
        /// The S3 bucket subfolder.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the <c>RUN_COMMAND</c> task execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role for Amazon Web Services Systems
        /// Manager to assume when running a maintenance window task. If you do not specify a
        /// service role ARN, Systems Manager uses a service-linked role in your account. If no
        /// appropriate service-linked role for Systems Manager exists in your account, it is
        /// created when you run <c>RegisterTaskWithMaintenanceWindow</c>.
        /// </para>
        ///  
        /// <para>
        /// However, for an improved security posture, we strongly recommend creating a custom
        /// policy and custom service role for running your maintenance window tasks. The policy
        /// can be crafted to provide only the permissions needed for your particular maintenance
        /// window tasks. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-maintenance-permissions.html">Setting
        /// up Maintenance Windows</a> in the in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
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
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// If this time is reached and the command hasn't already started running, it doesn't
        /// run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30, Max=2592000)]
        public int? TimeoutSeconds
        {
            get { return this._timeoutSeconds; }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

    }
}