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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the CancelExportTask operation.
    /// </summary>
    public partial class CancelExportTaskResponse : AmazonWebServiceResponse
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportOnly { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExportOnly property is set.
        /// </summary>
        internal bool IsSetExportOnly() => this.ExportOnly != null && (this.ExportOnly.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// A unique identifier for the snapshot or cluster export task. This ID isn't an identifier
        /// for the Amazon S3 bucket where the data is exported.
        /// </para>
        /// </summary>
        public string ExportTaskIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExportTaskIdentifier property is set.
        /// </summary>
        internal bool IsSetExportTaskIdentifier() => this.ExportTaskIdentifier != null;

        /// <summary>
        /// Gets and sets the property FailureCause. 
        /// <para>
        /// The reason the export failed, if it failed.
        /// </para>
        /// </summary>
        public string FailureCause { get; set; }

        /// <summary>
        /// Checks to see if the FailureCause property is set.
        /// </summary>
        internal bool IsSetFailureCause() => this.FailureCause != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The name of the IAM role that is used to write to Amazon S3 when exporting a snapshot
        /// or cluster.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The key identifier of the Amazon Web Services KMS key that is used to encrypt the
        /// data when it's exported to Amazon S3. The KMS key identifier is its key ARN, key ID,
        /// alias ARN, or alias name. The IAM role used for the export must have encryption and
        /// decryption permissions to use this KMS key.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the snapshot or cluster export task as a percentage.
        /// </para>
        /// </summary>
        public int? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket where the snapshot or cluster is exported to.
        /// </para>
        /// </summary>
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 bucket prefix that is the file name and path of the exported data.
        /// </para>
        /// </summary>
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;

        /// <summary>
        /// Gets and sets the property SnapshotTime. 
        /// <para>
        /// The time when the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? SnapshotTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotTime property is set.
        /// </summary>
        internal bool IsSetSnapshotTime() => this.SnapshotTime.HasValue;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot or cluster exported to Amazon S3.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source for the export.
        /// </para>
        /// </summary>
        public ExportSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

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
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskEndTime. 
        /// <para>
        /// The time when the snapshot or cluster export task ended.
        /// </para>
        /// </summary>
        public DateTime? TaskEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TaskEndTime property is set.
        /// </summary>
        internal bool IsSetTaskEndTime() => this.TaskEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time when the snapshot or cluster export task started.
        /// </para>
        /// </summary>
        public DateTime? TaskStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartTime property is set.
        /// </summary>
        internal bool IsSetTaskStartTime() => this.TaskStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TotalExtractedDataInGB. 
        /// <para>
        /// The total amount of data exported, in gigabytes.
        /// </para>
        /// </summary>
        public int? TotalExtractedDataInGB { get; set; }

        /// <summary>
        /// Checks to see if the TotalExtractedDataInGB property is set.
        /// </summary>
        internal bool IsSetTotalExtractedDataInGB() => this.TotalExtractedDataInGB.HasValue;

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// A warning about the snapshot or cluster export task.
        /// </para>
        /// </summary>
        public string WarningMessage { get; set; }

        /// <summary>
        /// Checks to see if the WarningMessage property is set.
        /// </summary>
        internal bool IsSetWarningMessage() => this.WarningMessage != null;
    }
}
