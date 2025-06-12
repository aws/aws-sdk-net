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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details of a snapshot or cluster export to Amazon S3.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeExportTasks</c> operation.
    /// </para>
    /// </summary>
    public partial class StartExportTaskResponse : AmazonWebServiceResponse
    {
        private List<string> _exportOnly = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _exportTaskIdentifier;
        private string _failureCause;
        private string _iamRoleArn;
        private string _kmsKeyId;
        private int? _percentProgress;
        private string _s3Bucket;
        private string _s3Prefix;
        private DateTime? _snapshotTime;
        private string _sourceArn;
        private ExportSourceType _sourceType;
        private string _status;
        private DateTime? _taskEndTime;
        private DateTime? _taskStartTime;
        private int? _totalExtractedDataInGB;
        private string _warningMessage;

        /// <summary>
        /// Gets and sets the property ExportOnly. 
        /// <para>
        /// The data exported from the snapshot or cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>database</c> - Export all the data from a specified database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database.table</c> <i>table-name</i> - Export a table of the snapshot or cluster.
        /// This format is valid only for RDS for MySQL, RDS for MariaDB, and Aurora MySQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database.schema</c> <i>schema-name</i> - Export a database schema of the snapshot
        /// or cluster. This format is valid only for RDS for PostgreSQL and Aurora PostgreSQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database.schema.table</c> <i>table-name</i> - Export a table of the database schema.
        /// This format is valid only for RDS for PostgreSQL and Aurora PostgreSQL.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportOnly
        {
            get { return this._exportOnly; }
            set { this._exportOnly = value; }
        }

        // Check to see if ExportOnly property is set
        internal bool IsSetExportOnly()
        {
            return this._exportOnly != null && (this._exportOnly.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot or cluster export task. This ID isn't an identifier
        /// for the Amazon S3 bucket where the data is exported.
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
        /// The name of the IAM role that is used to write to Amazon S3 when exporting a snapshot
        /// or cluster.
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
        /// The key identifier of the Amazon Web Services KMS key that is used to encrypt the
        /// data when it's exported to Amazon S3. The KMS key identifier is its key ARN, key ID,
        /// alias ARN, or alias name. The IAM role used for the export must have encryption and
        /// decryption permissions to use this KMS key.
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
        /// The progress of the snapshot or cluster export task as a percentage.
        /// </para>
        /// </summary>
        public int? PercentProgress
        {
            get { return this._percentProgress; }
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
        /// The Amazon S3 bucket where the snapshot or cluster is exported to.
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
        /// The Amazon S3 bucket prefix that is the file name and path of the exported data.
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
        /// The time when the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? SnapshotTime
        {
            get { return this._snapshotTime; }
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
        /// The Amazon Resource Name (ARN) of the snapshot or cluster exported to Amazon S3.
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
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source for the export.
        /// </para>
        /// </summary>
        public ExportSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The progress status of the export task. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CANCELED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTING</c> 
        /// </para>
        ///  </li> </ul>
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
        /// The time when the snapshot or cluster export task ended.
        /// </para>
        /// </summary>
        public DateTime? TaskEndTime
        {
            get { return this._taskEndTime; }
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
        /// The time when the snapshot or cluster export task started.
        /// </para>
        /// </summary>
        public DateTime? TaskStartTime
        {
            get { return this._taskStartTime; }
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
        public int? TotalExtractedDataInGB
        {
            get { return this._totalExtractedDataInGB; }
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
        /// A warning about the snapshot or cluster export task.
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