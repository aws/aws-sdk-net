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
    /// Summary information about the source file for the import.
    /// </summary>
    public partial class ImportSummary
    {
        private string _cloudWatchLogGroupArn;
        private DateTime? _endTime;
        private string _importArn;
        private ImportStatus _importStatus;
        private InputFormat _inputFormat;
        private S3BucketSource _s3BucketSource;
        private DateTime? _startTime;
        private string _tableArn;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the Cloudwatch Log Group associated with this
        /// import task. 
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
        ///  The time at which this import task ended. (Does this include the successful complete
        /// creation of the table it was imported to?) 
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
        /// Gets and sets the property ImportStatus. 
        /// <para>
        ///  The status of the import operation. 
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
        /// Gets and sets the property InputFormat. 
        /// <para>
        ///  The format of the source data. Valid values are <c>CSV</c>, <c>DYNAMODB_JSON</c>
        /// or <c>ION</c>.
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
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        ///  The path and S3 bucket of the source file that is being imported. This includes the
        /// S3Bucket (required), S3KeyPrefix (optional) and S3BucketOwner (optional if the bucket
        /// is owned by the requester). 
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
        ///  The time at which this import task began. 
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

    }
}