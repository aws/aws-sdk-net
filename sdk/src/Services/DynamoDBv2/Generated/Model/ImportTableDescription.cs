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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
        private string _clientToken;
        private string _cloudWatchLogGroupArn;
        private DateTime? _endTime;
        private long? _errorCount;
        private string _failureCode;
        private string _failureMessage;
        private string _importArn;
        private long? _importedItemCount;
        private ImportStatus _importStatus;
        private InputCompressionType _inputCompressionType;
        private InputFormat _inputFormat;
        private InputFormatOptions _inputFormatOptions;
        private long? _processedItemCount;
        private long? _processedSizeBytes;
        private S3BucketSource _s3BucketSource;
        private DateTime? _startTime;
        private string _tableArn;
        private TableCreationParameters _tableCreationParameters;
        private string _tableId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  The client token that was provided for the import task. Reusing the client token
        /// on retry makes a call to <c>ImportTable</c> idempotent. 
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the Cloudwatch Log Group associated with the
        /// target table. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CloudWatchLogGroupArn
        {
            get { return this._cloudWatchLogGroupArn; }
            set { this._cloudWatchLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogGroupArn property is set
        internal bool IsSetCloudWatchLogGroupArn()
        {
            return this._cloudWatchLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The time at which the creation of the table associated with this import task completed.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        ///  The number of errors occurred on importing the source file into the target table.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ErrorCount
        {
            get { return this._errorCount; }
            set { this._errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this._errorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        ///  The error code corresponding to the failure that the import job ran into during execution.
        /// 
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        ///  The error message corresponding to the failure that the import job ran into during
        /// execution. 
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ImportArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) corresponding to the import request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=37, Max=1024)]
        public string ImportArn
        {
            get { return this._importArn; }
            set { this._importArn = value; }
        }

        // Check to see if ImportArn property is set
        internal bool IsSetImportArn()
        {
            return this._importArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedItemCount. 
        /// <para>
        ///  The number of items successfully imported into the new table. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ImportedItemCount
        {
            get { return this._importedItemCount; }
            set { this._importedItemCount = value; }
        }

        // Check to see if ImportedItemCount property is set
        internal bool IsSetImportedItemCount()
        {
            return this._importedItemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        ///  The status of the import. 
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus
        {
            get { return this._importStatus; }
            set { this._importStatus = value; }
        }

        // Check to see if ImportStatus property is set
        internal bool IsSetImportStatus()
        {
            return this._importStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InputCompressionType. 
        /// <para>
        ///  The compression options for the data that has been imported into the target table.
        /// The values are NONE, GZIP, or ZSTD. 
        /// </para>
        /// </summary>
        public InputCompressionType InputCompressionType
        {
            get { return this._inputCompressionType; }
            set { this._inputCompressionType = value; }
        }

        // Check to see if InputCompressionType property is set
        internal bool IsSetInputCompressionType()
        {
            return this._inputCompressionType != null;
        }

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        ///  The format of the source data going into the target table. 
        /// </para>
        /// </summary>
        public InputFormat InputFormat
        {
            get { return this._inputFormat; }
            set { this._inputFormat = value; }
        }

        // Check to see if InputFormat property is set
        internal bool IsSetInputFormat()
        {
            return this._inputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property InputFormatOptions. 
        /// <para>
        ///  The format options for the data that was imported into the target table. There is
        /// one value, CsvOption. 
        /// </para>
        /// </summary>
        public InputFormatOptions InputFormatOptions
        {
            get { return this._inputFormatOptions; }
            set { this._inputFormatOptions = value; }
        }

        // Check to see if InputFormatOptions property is set
        internal bool IsSetInputFormatOptions()
        {
            return this._inputFormatOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessedItemCount. 
        /// <para>
        ///  The total number of items processed from the source file. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ProcessedItemCount
        {
            get { return this._processedItemCount; }
            set { this._processedItemCount = value; }
        }

        // Check to see if ProcessedItemCount property is set
        internal bool IsSetProcessedItemCount()
        {
            return this._processedItemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessedSizeBytes. 
        /// <para>
        ///  The total size of data processed from the source file, in Bytes. 
        /// </para>
        /// </summary>
        public long? ProcessedSizeBytes
        {
            get { return this._processedSizeBytes; }
            set { this._processedSizeBytes = value; }
        }

        // Check to see if ProcessedSizeBytes property is set
        internal bool IsSetProcessedSizeBytes()
        {
            return this._processedSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        ///  Values for the S3 bucket the source file is imported from. Includes bucket name (required),
        /// key prefix (optional) and bucket account owner ID (optional). 
        /// </para>
        /// </summary>
        public S3BucketSource S3BucketSource
        {
            get { return this._s3BucketSource; }
            set { this._s3BucketSource = value; }
        }

        // Check to see if S3BucketSource property is set
        internal bool IsSetS3BucketSource()
        {
            return this._s3BucketSource != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The time when this import task started. 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the table being imported into. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableCreationParameters. 
        /// <para>
        ///  The parameters for the new table that is being imported into. 
        /// </para>
        /// </summary>
        public TableCreationParameters TableCreationParameters
        {
            get { return this._tableCreationParameters; }
            set { this._tableCreationParameters = value; }
        }

        // Check to see if TableCreationParameters property is set
        internal bool IsSetTableCreationParameters()
        {
            return this._tableCreationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        ///  The table id corresponding to the table created by import table process. 
        /// </para>
        /// </summary>
        public string TableId
        {
            get { return this._tableId; }
            set { this._tableId = value; }
        }

        // Check to see if TableId property is set
        internal bool IsSetTableId()
        {
            return this._tableId != null;
        }

    }
}