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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The batch import job details.
    /// </summary>
    public partial class BatchImport
    {
        private string _arn;
        private string _completionTime;
        private string _eventTypeName;
        private int? _failedRecordsCount;
        private string _failureReason;
        private string _iamRoleArn;
        private string _inputPath;
        private string _jobId;
        private string _outputPath;
        private int? _processedRecordsCount;
        private string _startTime;
        private AsyncJobStatus _status;
        private int? _totalRecordsCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the batch import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// Timestamp of when batch import job completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The name of the event type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property FailedRecordsCount. 
        /// <para>
        /// The number of records that failed to import. 
        /// </para>
        /// </summary>
        public int? FailedRecordsCount
        {
            get { return this._failedRecordsCount; }
            set { this._failedRecordsCount = value; }
        }

        // Check to see if FailedRecordsCount property is set
        internal bool IsSetFailedRecordsCount()
        {
            return this._failedRecordsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason batch import job failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role to use for this job request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property InputPath. 
        /// <para>
        /// The Amazon S3 location of your data file for batch import.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string InputPath
        {
            get { return this._inputPath; }
            set { this._inputPath = value; }
        }

        // Check to see if InputPath property is set
        internal bool IsSetInputPath()
        {
            return this._inputPath != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the batch import job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputPath. 
        /// <para>
        /// The Amazon S3 location of your output file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string OutputPath
        {
            get { return this._outputPath; }
            set { this._outputPath = value; }
        }

        // Check to see if OutputPath property is set
        internal bool IsSetOutputPath()
        {
            return this._outputPath != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessedRecordsCount. 
        /// <para>
        /// The number of records processed by batch import job.
        /// </para>
        /// </summary>
        public int? ProcessedRecordsCount
        {
            get { return this._processedRecordsCount; }
            set { this._processedRecordsCount = value; }
        }

        // Check to see if ProcessedRecordsCount property is set
        internal bool IsSetProcessedRecordsCount()
        {
            return this._processedRecordsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Timestamp of when the batch import job started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch import job.
        /// </para>
        /// </summary>
        public AsyncJobStatus Status
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
        /// Gets and sets the property TotalRecordsCount. 
        /// <para>
        /// The total number of records in the batch import job.
        /// </para>
        /// </summary>
        public int? TotalRecordsCount
        {
            get { return this._totalRecordsCount; }
            set { this._totalRecordsCount = value; }
        }

        // Check to see if TotalRecordsCount property is set
        internal bool IsSetTotalRecordsCount()
        {
            return this._totalRecordsCount.HasValue; 
        }

    }
}