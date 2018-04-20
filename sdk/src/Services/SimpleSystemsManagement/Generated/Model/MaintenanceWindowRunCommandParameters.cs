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
    /// The parameters for a RUN_COMMAND task type.
    /// 
    ///  
    /// <para>
    /// For information about specifying and updating task parameters, see <a>RegisterTaskWithMaintenanceWindow</a>
    /// and <a>UpdateMaintenanceWindowTask</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>LoggingInfo</code> has been deprecated. To specify an S3 bucket to contain
    /// logs, instead use the <code>OutputS3BucketName</code> and <code>OutputS3KeyPrefix</code>
    /// options in the <code>TaskInvocationParameters</code> structure. For information about
    /// how Systems Manager handles these options for the supported Maintenance Window task
    /// types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>TaskParameters</code> has been deprecated. To specify parameters to pass to
    /// a task when it runs, instead use the <code>Parameters</code> option in the <code>TaskInvocationParameters</code>
    /// structure. For information about how Systems Manager handles these options for the
    /// supported Maintenance Window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  
    /// <para>
    /// For Run Command tasks, Systems Manager uses specified values for <code>TaskParameters</code>
    /// and <code>LoggingInfo</code> only if no values are specified for <code>TaskInvocationParameters</code>.
    /// 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class MaintenanceWindowRunCommandParameters
    {
        private string _comment;
        private string _documentHash;
        private DocumentHashType _documentHashType;
        private NotificationConfig _notificationConfig;
        private string _outputS3BucketName;
        private string _outputS3KeyPrefix;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _serviceRoleArn;
        private int? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Information about the command(s) to execute.
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
        /// Gets and sets the property DocumentHash. 
        /// <para>
        /// The SHA-256 or SHA-1 hash created by the system when the document was created. SHA-1
        /// hashes have been deprecated.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NotificationConfig. 
        /// <para>
        /// Configurations for sending notifications about command status changes on a per-instance
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
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket.
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
        /// The Amazon S3 bucket subfolder.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the RUN_COMMAND task execution.
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
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The IAM service role to assume during task execution.
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
        /// If this time is reached and the command has not already started executing, it doesn
        /// not execute.
        /// </para>
        /// </summary>
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