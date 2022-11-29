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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes an update for a destination in Amazon Redshift.
    /// </summary>
    public partial class RedshiftDestinationUpdate
    {
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private string _clusterJDBCURL;
        private CopyCommand _copyCommand;
        private string _password;
        private ProcessingConfiguration _processingConfiguration;
        private RedshiftRetryOptions _retryOptions;
        private string _roleARN;
        private RedshiftS3BackupMode _s3BackupMode;
        private S3DestinationUpdate _s3BackupUpdate;
        private S3DestinationUpdate _s3Update;
        private string _username;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// The Amazon CloudWatch logging options for your delivery stream.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterJDBCURL. 
        /// <para>
        /// The database connection string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ClusterJDBCURL
        {
            get { return this._clusterJDBCURL; }
            set { this._clusterJDBCURL = value; }
        }

        // Check to see if ClusterJDBCURL property is set
        internal bool IsSetClusterJDBCURL()
        {
            return this._clusterJDBCURL != null;
        }

        /// <summary>
        /// Gets and sets the property CopyCommand. 
        /// <para>
        /// The <code>COPY</code> command.
        /// </para>
        /// </summary>
        public CopyCommand CopyCommand
        {
            get { return this._copyCommand; }
            set { this._copyCommand = value; }
        }

        // Check to see if CopyCommand property is set
        internal bool IsSetCopyCommand()
        {
            return this._copyCommand != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The user password.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=512)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// The data processing configuration.
        /// </para>
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration
        {
            get { return this._processingConfiguration; }
            set { this._processingConfiguration = value; }
        }

        // Check to see if ProcessingConfiguration property is set
        internal bool IsSetProcessingConfiguration()
        {
            return this._processingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The retry behavior in case Kinesis Data Firehose is unable to deliver documents to
        /// Amazon Redshift. Default value is 3600 (60 minutes).
        /// </para>
        /// </summary>
        public RedshiftRetryOptions RetryOptions
        {
            get { return this._retryOptions; }
            set { this._retryOptions = value; }
        }

        // Check to see if RetryOptions property is set
        internal bool IsSetRetryOptions()
        {
            return this._retryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services credentials. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// You can update a delivery stream to enable Amazon S3 backup if it is disabled. If
        /// backup is enabled, you can't update the delivery stream to disable it. 
        /// </para>
        /// </summary>
        public RedshiftS3BackupMode S3BackupMode
        {
            get { return this._s3BackupMode; }
            set { this._s3BackupMode = value; }
        }

        // Check to see if S3BackupMode property is set
        internal bool IsSetS3BackupMode()
        {
            return this._s3BackupMode != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupUpdate. 
        /// <para>
        /// The Amazon S3 destination for backup.
        /// </para>
        /// </summary>
        public S3DestinationUpdate S3BackupUpdate
        {
            get { return this._s3BackupUpdate; }
            set { this._s3BackupUpdate = value; }
        }

        // Check to see if S3BackupUpdate property is set
        internal bool IsSetS3BackupUpdate()
        {
            return this._s3BackupUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property S3Update. 
        /// <para>
        /// The Amazon S3 destination.
        /// </para>
        ///  
        /// <para>
        /// The compression formats <code>SNAPPY</code> or <code>ZIP</code> cannot be specified
        /// in <code>RedshiftDestinationUpdate.S3Update</code> because the Amazon Redshift <code>COPY</code>
        /// operation that reads from the S3 bucket doesn't support these compression formats.
        /// </para>
        /// </summary>
        public S3DestinationUpdate S3Update
        {
            get { return this._s3Update; }
            set { this._s3Update = value; }
        }

        // Check to see if S3Update property is set
        internal bool IsSetS3Update()
        {
            return this._s3Update != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}