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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details of a snapshot export to Amazon S3. 
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <code>DescribeExportTasks</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class CancelExportTaskResponse : AmazonWebServiceResponse
    {
        private List<string> _exportOnly = new List<string>();
        private string _exportTaskIdentifier;
        private string _failureCause;
        private string _iamRoleArn;
        private string _kmsKeyId;
        private int? _percentProgress;
        private string _s3Bucket;
        private string _s3Prefix;
        private DateTime? _snapshotTime;
        private string _sourceArn;
        private string _status;
        private DateTime? _taskEndTime;
        private DateTime? _taskStartTime;
        private int? _totalExtractedDataInGB;
        private string _warningMessage;

        /// <summary>
        /// Gets and sets the property ExportOnly. 
        /// <para>
        /// The data exported from the snapshot. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>database</code> - Export all the data from a specified database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database.table</code> <i>table-name</i> - Export a table of the snapshot. This
        /// format is valid only for RDS for MySQL, RDS for MariaDB, and Aurora MySQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database.schema</code> <i>schema-name</i> - Export a database schema of the
        /// snapshot. This format is valid only for RDS for PostgreSQL and Aurora PostgreSQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database.schema.table</code> <i>table-name</i> - Export a table of the database
        /// schema. This format is valid only for RDS for PostgreSQL and Aurora PostgreSQL.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> ExportOnly
        {
            get { return this._exportOnly; }
            set { this._exportOnly = value; }
        }

        // Check to see if ExportOnly property is set
        internal bool IsSetExportOnly()
        {
            return this._exportOnly != null && this._exportOnly.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot export task. This ID isn't an identifier for
        /// the Amazon S3 bucket where the snapshot is exported to. 
        /// </para>
        /// </summary>
        public string ExportTaskIdentifier
        {
            get { return this._exportTaskIdentifier; }
            set { this._exportTaskIdentifier = value; }
        }

        // Check to see if ExportTaskIdentifier property is set
        internal bool IsSetExportTaskIdentifier()
        {
            return this._exportTaskIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCause. 
        /// <para>
        /// The reason the export failed, if it failed.
        /// </para>
        /// </summary>
        public string FailureCause
        {
            get { return this._failureCause; }
            set { this._failureCause = value; }
        }

        // Check to see if FailureCause property is set
        internal bool IsSetFailureCause()
        {
            return this._failureCause != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The name of the IAM role that is used to write to Amazon S3 when exporting a snapshot.
        /// 
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The key identifier of the AWS KMS customer master key (CMK) that is used to encrypt
        /// the snapshot when it's exported to Amazon S3. The AWS KMS CMK identifier is its key
        /// ARN, key ID, alias ARN, or alias name. The IAM role used for the snapshot export must
        /// have encryption and decryption permissions to use this AWS KMS CMK. 
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the snapshot export task as a percentage.
        /// </para>
        /// </summary>
        public int PercentProgress
        {
            get { return this._percentProgress.GetValueOrDefault(); }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket that the snapshot is exported to.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 bucket prefix that is the file name and path of the exported snapshot.
        /// </para>
        /// </summary>
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotTime. 
        /// <para>
        /// The time that the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime SnapshotTime
        {
            get { return this._snapshotTime.GetValueOrDefault(); }
            set { this._snapshotTime = value; }
        }

        // Check to see if SnapshotTime property is set
        internal bool IsSetSnapshotTime()
        {
            return this._snapshotTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot exported to Amazon S3.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The progress status of the export task.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TaskEndTime. 
        /// <para>
        /// The time that the snapshot export task completed.
        /// </para>
        /// </summary>
        public DateTime TaskEndTime
        {
            get { return this._taskEndTime.GetValueOrDefault(); }
            set { this._taskEndTime = value; }
        }

        // Check to see if TaskEndTime property is set
        internal bool IsSetTaskEndTime()
        {
            return this._taskEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time that the snapshot export task started.
        /// </para>
        /// </summary>
        public DateTime TaskStartTime
        {
            get { return this._taskStartTime.GetValueOrDefault(); }
            set { this._taskStartTime = value; }
        }

        // Check to see if TaskStartTime property is set
        internal bool IsSetTaskStartTime()
        {
            return this._taskStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalExtractedDataInGB. 
        /// <para>
        /// The total amount of data exported, in gigabytes.
        /// </para>
        /// </summary>
        public int TotalExtractedDataInGB
        {
            get { return this._totalExtractedDataInGB.GetValueOrDefault(); }
            set { this._totalExtractedDataInGB = value; }
        }

        // Check to see if TotalExtractedDataInGB property is set
        internal bool IsSetTotalExtractedDataInGB()
        {
            return this._totalExtractedDataInGB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// A warning about the snapshot export task.
        /// </para>
        /// </summary>
        public string WarningMessage
        {
            get { return this._warningMessage; }
            set { this._warningMessage = value; }
        }

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this._warningMessage != null;
        }

    }
}