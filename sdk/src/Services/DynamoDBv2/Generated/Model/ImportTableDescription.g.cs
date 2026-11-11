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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the properties of the table being imported into.
    /// </summary>
    public partial class ImportTableDescription
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  The client token that was provided for the import task. Reusing the client token
        /// on retry makes a call to <c>ImportTable</c> idempotent. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the Cloudwatch Log Group associated with the
        /// target table. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CloudWatchLogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogGroupArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogGroupArn() => this.CloudWatchLogGroupArn != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The time at which the creation of the table associated with this import task completed.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        ///  The number of errors occurred on importing the source file into the target table.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ErrorCount { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCount property is set.
        /// </summary>
        internal bool IsSetErrorCount() => this.ErrorCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        ///  The error code corresponding to the failure that the import job ran into during execution.
        /// 
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        ///  The error message corresponding to the failure that the import job ran into during
        /// execution. 
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property ImportArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) corresponding to the import request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string ImportArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportArn property is set.
        /// </summary>
        internal bool IsSetImportArn() => this.ImportArn != null;

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        ///  The status of the import. 
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatus property is set.
        /// </summary>
        internal bool IsSetImportStatus() => this.ImportStatus != null;

        /// <summary>
        /// Gets and sets the property ImportedItemCount. 
        /// <para>
        ///  The number of items successfully imported into the new table. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ImportedItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ImportedItemCount property is set.
        /// </summary>
        internal bool IsSetImportedItemCount() => this.ImportedItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property InputCompressionType. 
        /// <para>
        ///  The compression options for the data that has been imported into the target table.
        /// The values are NONE, GZIP, or ZSTD. 
        /// </para>
        /// </summary>
        public InputCompressionType InputCompressionType { get; set; }

        /// <summary>
        /// Checks to see if the InputCompressionType property is set.
        /// </summary>
        internal bool IsSetInputCompressionType() => this.InputCompressionType != null;

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        ///  The format of the source data going into the target table. 
        /// </para>
        /// </summary>
        public InputFormat InputFormat { get; set; }

        /// <summary>
        /// Checks to see if the InputFormat property is set.
        /// </summary>
        internal bool IsSetInputFormat() => this.InputFormat != null;

        /// <summary>
        /// Gets and sets the property InputFormatOptions. 
        /// <para>
        ///  The format options for the data that was imported into the target table. There is
        /// one value, CsvOption. 
        /// </para>
        /// </summary>
        public InputFormatOptions InputFormatOptions { get; set; }

        /// <summary>
        /// Checks to see if the InputFormatOptions property is set.
        /// </summary>
        internal bool IsSetInputFormatOptions() => this.InputFormatOptions != null;

        /// <summary>
        /// Gets and sets the property ProcessedItemCount. 
        /// <para>
        ///  The total number of items processed from the source file. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ProcessedItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedItemCount property is set.
        /// </summary>
        internal bool IsSetProcessedItemCount() => this.ProcessedItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property ProcessedSizeBytes. 
        /// <para>
        ///  The total size of data processed from the source file, in Bytes. 
        /// </para>
        /// </summary>
        public long? ProcessedSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedSizeBytes property is set.
        /// </summary>
        internal bool IsSetProcessedSizeBytes() => this.ProcessedSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        ///  Values for the S3 bucket the source file is imported from. Includes bucket name (required),
        /// key prefix (optional) and bucket account owner ID (optional). 
        /// </para>
        /// </summary>
        public S3BucketSource S3BucketSource { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketSource property is set.
        /// </summary>
        internal bool IsSetS3BucketSource() => this.S3BucketSource != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The time when this import task started. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the table being imported into. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;

        /// <summary>
        /// Gets and sets the property TableCreationParameters. 
        /// <para>
        ///  The parameters for the new table that is being imported into. 
        /// </para>
        /// </summary>
        public TableCreationParameters TableCreationParameters { get; set; }

        /// <summary>
        /// Checks to see if the TableCreationParameters property is set.
        /// </summary>
        internal bool IsSetTableCreationParameters() => this.TableCreationParameters != null;

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        ///  The table id corresponding to the table created by import table process. 
        /// </para>
        /// </summary>
        public string TableId { get; set; }

        /// <summary>
        /// Checks to see if the TableId property is set.
        /// </summary>
        internal bool IsSetTableId() => this.TableId != null;
    }
}
